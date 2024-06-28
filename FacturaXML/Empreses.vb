Imports System.Data.SqlClient
Imports System.Data.SQLite
Imports System.Diagnostics.Contracts

Public Class Empreses
    Private DT_Llistat, DT_Solucions As New DataTable
    Private columnaSeleccionada As DataGridViewColumn
    Private columnaIndexSeleccionada As Integer
    Private EmpresesTaronja, EmpresesVermell As Integer


    Private Sub Empreses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CB_MostrarContractes.Checked = My.Settings.MostrarEmpresesConcessio
        CarregaEmpreses("")
        columnaIndexSeleccionada = 0
        TB_Caducades.BackColor = vermell
        TB_ProxCad.BackColor = taronja
        Lbl_ProxCad.Text = "Empreses que caducaran en menys de " & My.Settings.DiesConcessio & " dies"
    End Sub
    Private Sub CarregaEmpreses(TextABuscar As String)
        Try
            Using conexion As New SQLiteConnection(cadena)

                conexion.Open()

                If conexion.State = ConnectionState.Open Then
                    DT_Llistat.Clear()
                    Dim Sql, MostraContactes As String
                    If CB_MostrarContractes.Checked = True Then
                        MostraContactes = " OR Contractes = 1"
                    Else
                        MostraContactes = ""
                    End If

                    If TextABuscar = "" Then
                        Sql = "Select Id,
                                      Nif,
                                      Nom,                                      
                                      Segment,                                      
                                      DataConcessio,
                                      DataCaducitat,
                                      CodiBono,
                                      Import,
                                      Contractes
                                      FROM Empreses
                                      WHERE Contractes = 0" & MostraContactes & "
                                      ORDER BY DataCaducitat ASC"
                    Else
                        Sql = "Select Id,
                                      Nif,
                                      Nom,                                      
                                      Segment,
                                      DataConcessio,
                                      DataCaducitat,
                                      CodiBono,
                                      Import,
                                      Contractes
                                      FROM Empreses WHERE " & columnaSeleccionada.HeaderText & " LIKE '%" & TextABuscar & "%' AND (Contractes = 0" & MostraContactes & ") 
                                      ORDER BY DataCaducitat ASC"
                    End If

                    Dim comm As New SQLiteCommand(Sql, conexion)
                    Dim adapter As New SQLiteDataAdapter(comm)
                    adapter.Fill(DT_Llistat)
                    DataEmpreses.DataSource = DT_Llistat
                End If
            End Using
        Catch ex As Exception
            MsgBox("No s'han pogut carregar les solucions desde la base de dades - " + ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub DataEmpreses_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataEmpreses.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            columnaSeleccionada = DataEmpreses.Columns(e.ColumnIndex)
            columnaIndexSeleccionada = e.ColumnIndex
            TB_CampSeleccionat.Text = columnaSeleccionada.HeaderText
            mostraInfoEmpresa(DataEmpreses.Rows(e.RowIndex).Cells("Id").Value)
        End If
    End Sub

    Private Sub TextABuscar_TextChanged(sender As Object, e As EventArgs) Handles TextABuscar.TextChanged
        If columnaIndexSeleccionada > 0 Then
            CarregaEmpreses(TextABuscar.Text)
        End If
    End Sub

    Private Sub DataEmpreses_DataSourceChanged(sender As Object, e As EventArgs) Handles DataEmpreses.DataSourceChanged
        Debug.Write("DataSourceChanged" & vbCrLf)
        With DataEmpreses
            .ClearSelection()
            .Columns("Id").Visible = False
            .Columns("Contractes").Visible = False
            .Columns("Import").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("Import").DefaultCellStyle.Format = "C"
            .Columns("Import").DefaultCellStyle.FormatProvider = New System.Globalization.CultureInfo("es-ES")
            .Columns("DataConcessio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("DataCaducitat").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Segment").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("CodiBono").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With

        For Each Fila As DataGridViewRow In DataEmpreses.Rows

            If Fila.Cells("DataCaducitat").Value <> "" Then
                If DateDiff(DateInterval.Day, Date.Now.Date, Fila.Cells("DataCaducitat").Value) <= My.Settings.DiesConcessio And Fila.Cells("Contractes").Value = 0 Then
                    EmpresesTaronja += 1
                End If

                If Fila.Cells("DataCaducitat").Value < Date.Now.Date And Fila.Cells("Contractes").Value = 0 Then
                    EmpresesVermell += 1
                End If
            End If
        Next

        TB_Caducades.Text = EmpresesVermell
        TB_ProxCad.Text = EmpresesTaronja - EmpresesVermell

    End Sub

    Private Sub Btn_SenseFiltre_Click(sender As Object, e As EventArgs) Handles Btn_SenseFiltre.Click
        TextABuscar.Clear()
    End Sub

    Private Sub DataEmpreses_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataEmpreses.DataBindingComplete

        Dim dgv As DataGridView = sender

            With dgv
                .ClearSelection()
                .Columns("Nif").Width = 75
                .Columns("Nom").Width = 300
                .Columns("Segment").Width = 60
                .Columns("DataCaducitat").Width = 100
                .Columns("DataConcessio").Width = 100
                .Columns("CodiBono").Width = 150
                .Columns("Import").Width = 75
            End With

        For Each Fila As DataGridViewRow In DataEmpreses.Rows

            If Fila.Cells("DataCaducitat").Value <> "" Then
                If DateDiff(DateInterval.Day, Date.Now.Date, Fila.Cells("DataCaducitat").Value) <= My.Settings.DiesConcessio And Fila.Cells("Contractes").Value = 0 Then
                    Fila.Cells("Nom").Style.BackColor = taronja
                    Fila.Cells("Nif").Style.BackColor = taronja

                End If

                If Fila.Cells("DataCaducitat").Value < Date.Now.Date And Fila.Cells("Contractes").Value = 0 Then
                    Fila.Cells("Nom").Style.BackColor = vermell
                    Fila.Cells("Nif").Style.BackColor = vermell
                End If
            End If
        Next

    End Sub

    Private Sub mostraInfoEmpresa(idEmpresa As Integer)

        Lbl_Direccio.Visible = True
        Lbl_NomEmpresa.Visible = True
        Dim concedit, consumit As Double

        Try
            Using conexion As New SQLiteConnection(cadena)

                conexion.Open()

                If conexion.State = ConnectionState.Open Then
                    Dim Sql As String = "SELECT Nom, Nif, Direccio, CodiPostal, Ciutat, Provincia, Import, Segment FROM Empreses WHERE Id=" & idEmpresa
                    Dim strCommand As SQLiteCommand = New SQLiteCommand(Sql, conexion)
                    Dim lector As SQLiteDataReader = strCommand.ExecuteReader

                    If lector.Read Then
                        Lbl_NomEmpresa.Text = lector.GetString("Nom") & "  -  " & lector.GetString("Nif")
                        Lbl_Direccio.Text = lector.GetString("Direccio") & "  -  " & lector.GetString("CodiPostal") & "  -  " & lector.GetString("Ciutat") & "  -  " & lector.GetString("Provincia")
                        TB_Segment.Text = lector.GetValue("Segment").ToString
                        concedit = lector.GetValue("Import")

                        TB_BonusConcedit.Text = concedit.ToString
                    End If
                    lector.Close()
                End If

            End Using

            Using conexion As New SQLiteConnection(cadena)

                conexion.Open()

                If conexion.State = ConnectionState.Open Then
                    Dim Sql As String = "select IdSolucio from solucions where idEmpresa=" & idEmpresa & " and tipus=1"
                    Dim strCommand As SQLiteCommand = New SQLiteCommand(Sql, conexion)
                    Dim lector As SQLiteDataReader = strCommand.ExecuteReader

                    Dim resultats As New List(Of Integer)()

                    While lector.Read()
                        resultats.Add(lector.GetInt32(0))
                    End While

                    TB_NumeroSolucions.Text = resultats.LongCount.ToString
                    lector.Close()

                    resetSolucions()

                    For Each sol As Integer In resultats
                        Select Case (sol)
                            Case 1
                                Lbl_SitioWeb.BackColor = verd
                            Case 2
                                Lbl_Comercio.BackColor = verd
                            Case 5
                                Lbl_BI.BackColor = verd
                            Case 6
                                Lbl_Procesos.BackColor = verd
                            Case 7
                                Lbl_Factura.BackColor = verd
                            Case 8
                                Lbl_Oficina.BackColor = verd
                            Case 9
                                Lbl_Comunicaciones.BackColor = verd
                            Case 10
                                Lbl_Ciberseguridad.BackColor = verd
                        End Select
                    Next
                End If
            End Using

            Using conexion As New SQLiteConnection(cadena)

                conexion.Open()

                If conexion.State = ConnectionState.Open Then
                    Dim Sql As String = "SELECT sum(Justificacions.Subvencio) as Consumit                                          
                                          FROM Solucions
                                          INNER JOIN TipusSolucions ON TipusSolucions.Id=Solucions.idSolucio
                                          INNER JOIN Justificacions ON Solucions.Id=Justificacions.idSolucio  
                                          WHERE idEmpresa=" & idEmpresa & " and tipus=1"

                    Dim strCommand As SQLiteCommand = New SQLiteCommand(Sql, conexion)
                    Dim lector As SQLiteDataReader = strCommand.ExecuteReader

                    If lector.Read Then
                        If Not IsDBNull(lector.GetValue("Consumit")) Then
                            consumit = lector.GetValue("Consumit")
                        Else
                            consumit = 0
                        End If
                        TB_BonusConsumit.Text = consumit.ToString
                        TB_BonusRestant.Text = (concedit - consumit).ToString
                    End If
                    lector.Close()

                End If
            End Using

            Using conexion As New SQLiteConnection(cadena)

                conexion.Open()

                If conexion.State = ConnectionState.Open Then
                    Dim Sql As String = "SELECT TipusSolucions.Nom, Justificacions.Subvencio                                          
                                          FROM Solucions
                                          INNER JOIN TipusSolucions ON TipusSolucions.Id=Solucions.idSolucio
                                          INNER JOIN Justificacions ON Solucions.Id=Justificacions.idSolucio  
                                          WHERE idEmpresa=" & idEmpresa & " and tipus=1"

                    Dim strCommand As SQLiteCommand = New SQLiteCommand(Sql, conexion)
                    Dim adapter As New SQLiteDataAdapter(strCommand)
                    DT_Solucions.Clear()
                    adapter.Fill(DT_Solucions)
                    DataSolucions.DataSource = DT_Solucions
                    DataSolucions.ClearSelection()
                    If DataSolucions.RowCount = 0 Then
                        DataSolucions.Visible = False
                    Else
                        DataSolucions.Visible = True
                    End If

                End If
            End Using

        Catch ex As Exception
            MsgBox("No s'han pogut carregar les solucions desde la base de dades - " + ex.Message, vbCritical, "Error")
        End Try

    End Sub

    Private Sub resetSolucions()

        Lbl_SitioWeb.BackColor = SystemColors.Control
        Lbl_Comercio.BackColor = SystemColors.Control
        Lbl_BI.BackColor = SystemColors.Control
        Lbl_Procesos.BackColor = SystemColors.Control
        Lbl_Factura.BackColor = SystemColors.Control
        Lbl_Oficina.BackColor = SystemColors.Control
        Lbl_Comunicaciones.BackColor = SystemColors.Control
        Lbl_Ciberseguridad.BackColor = SystemColors.Control
    End Sub

    Private Sub DataSolucions_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataSolucions.DataBindingComplete
        Dim dgv As DataGridView = sender
        With dgv
            .Columns("Subvencio").DefaultCellStyle.Format = "C"
            .Columns("Subvencio").DefaultCellStyle.FormatProvider = New System.Globalization.CultureInfo("es-ES")
            .Columns("Subvencio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
    End Sub
    Private Sub CB_MostrarContractes_CheckedChanged(sender As Object, e As EventArgs) Handles CB_MostrarContractes.CheckedChanged
        CarregaEmpreses(TextABuscar.Text)
    End Sub

End Class