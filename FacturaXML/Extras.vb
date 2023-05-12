Imports System.Data.SQLite

Public Class Extras
    Private DT_Extres, DT_ExtresGeneral, DT_EstatSolucions, DT_CercaEmpreses As New DataTable
    Private TotalEmpresaValor, TotalGeneralValor As Double
    Private TotalSolucionsValor As Integer
    Private resultatsPerEmpresa As New List(Of Object())
    Private resultatsTotals As New List(Of Object())
    Private resultatsEstatsTotals As New List(Of Object())

    Private Sub Extras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim conexion As New SQLiteConnection(cadena)

        conexion.Open()

        ' Columna Empreses
        Try
            If conexion.State = ConnectionState.Open Then
                Dim DA As New SQLiteDataAdapter("SELECT id,nom from empreses", conexion)
                DT_CercaEmpreses.Clear()
                DA.Fill(DT_CercaEmpreses)

                If DT_CercaEmpreses.Rows.Count > 0 Then
                    CercaEmpreses.DataSource = DT_CercaEmpreses
                Else
                    CercaEmpreses.DataSource = Nothing
                End If
            End If

        Catch ex As Exception
            MsgBox("No s'ha pogut accedir a la base de dades", vbCritical, "Error")
        End Try

        conexion.Close()

        CarregaSolucionsTotes()
        CarregaEstatsTotes()

    End Sub
    Private Sub CarregaSolucionsEmpresa(idEmpresa As Integer)
        Dim conexion As New SQLiteConnection(cadena)
        Try
            conexion.Open()

            If conexion.State = ConnectionState.Open Then
                Dim query As String = "SELECT TipusSolucions.id, TipusSolucions.Nom as 'Solució', sum(Justificacions.Subvencio) as Subvencions, TipusEstats.NomEstat, Justificacions.Estat from Solucions
                                                 INNER JOIN TipusSolucions ON TipusSolucions.Id=Solucions.IdSolucio
                                                 INNER JOIN Justificacions ON Solucions.Id=Justificacions.IdSolucio
											     INNER JOIN TipusEstats ON TipusEstats.ID=Justificacions.Estat
                                                 WHERE Solucions.idEmpresa=" & idEmpresa & " 
                                                 GROUP by TipusSolucions.Nom"
                Dim cmd As New SQLiteCommand(query, conexion)
                Dim reader As SQLiteDataReader = cmd.ExecuteReader

                While reader.Read()
                    Dim values(reader.FieldCount - 1) As Object
                    reader.GetValues(values)
                    resultatsPerEmpresa.Add(values)
                End While

                reader.Close()
                conexion.Close()

                If resultatsPerEmpresa.Count > 0 Then
                    ompleDadesSolucionsEmpresa()
                    Panel_SolucionsEmpresa.Visible = True
                Else
                    Panel_SolucionsEmpresa.Visible = False
                End If

            End If
        Catch ex As Exception
            MsgBox("No s'ha pogut accedir a la base de dades", vbCritical, "Error")
        End Try
        conexion.Close()
    End Sub
    Private Sub CarregaSolucionsTotes()
        Dim conexion As New SQLiteConnection(cadena)
        Try
            conexion.Open()

            If conexion.State = ConnectionState.Open Then
                Dim query As String = "SELECT TipusSolucions.id, TipusSolucions.Nom as 'Solució',  count(Justificacions.id) as Quantitat, sum(Justificacions.Subvencio) as Subvencions from Solucions
                                                 INNER JOIN TipusSolucions ON TipusSolucions.Id=Solucions.IdSolucio
                                                 INNER JOIN Justificacions ON Solucions.Id=Justificacions.IdSolucio                                                 
                                                 GROUP by TipusSolucions.Nom"
                Dim cmd As New SQLiteCommand(query, conexion)
                Dim reader As SQLiteDataReader = cmd.ExecuteReader

                While reader.Read()
                    Dim values(reader.FieldCount - 1) As Object
                    reader.GetValues(values)
                    resultatsTotals.Add(values)
                End While

                reader.Close()
                conexion.Close()

                If resultatsTotals.Count > 0 Then
                    ompleDadesSolucionsTotes()
                End If

            End If
        Catch ex As Exception
            MsgBox("No s'ha pogut accedir a la base de dades", vbCritical, "Error")
        End Try
        conexion.Close()
    End Sub

    Private Sub CarregaEstatsTotes()
        Dim conexion As New SQLiteConnection(cadena)
        Try
            conexion.Open()

            If conexion.State = ConnectionState.Open Then
                Dim query As String = "SELECT TipusEstats.Id, count(Justificacions.Estat) from Justificacions                                               
                                                 INNER JOIN TipusEstats ON TipusEstats.Id=Justificacions.Estat                                                 
                                                 GROUP by Justificacions.Estat"
                Dim cmd As New SQLiteCommand(query, conexion)
                Dim reader As SQLiteDataReader = cmd.ExecuteReader

                While reader.Read()
                    Dim values(reader.FieldCount - 1) As Object
                    reader.GetValues(values)
                    resultatsEstatsTotals.Add(values)
                End While

                reader.Close()
                conexion.Close()

                If resultatsEstatsTotals.Count > 0 Then
                    ompleDadesSolucionsEstatTotes()
                End If

            End If
        Catch ex As Exception
            MsgBox("No s'ha pogut accedir a la base de dades", vbCritical, "Error")
        End Try
        conexion.Close()
    End Sub
    Private Sub ompleDadesSolucionsTotes()

        Dim TotalEmpreses As Double = 0

        TB_SitioWeb_TotalNum.Text = "0"
        TB_Ciberseguridad_TotalNum.Text = "0"
        TB_BI_TotalNum.Text = "0"
        TB_GestionProcesos_TotalNum.Text = "0"
        TB_FacturaElectronica_TotalNum.Text = "0"
        TB_OficinaVirtual_TotalNum.Text = "0"
        TB_ComunicacionesSeguras_TotalNum.Text = "0"
        TB_Ciberseguridad_TotalNum.Text = "0"

        For Each result As Object In resultatsTotals
            TotalEmpreses += result(3)
            Select Case result(0)
                Case 1
                    TB_SitioWeb_TotalNum.Text = result(2)
                    TB_SitioWeb_SubTotal.Text = result(3).ToString + " €"
                Case 2
                    TB_ComercioElectronico_TotalNum.Text = result(2)
                    TB_ComercioElectronico_SubTotal.Text = result(3).ToString + " €"
                Case 3, 4
                Case 5
                    TB_BI_TotalNum.Text = result(2)
                    TB_BI_SubTotal.Text = result(3).ToString + " €"
                Case 6
                    TB_GestionProcesos_TotalNum.Text = result(2)
                    TB_GestionProcesos_SubTotal.Text = result(3).ToString + " €"
                Case 7
                    TB_FacturaElectronica_TotalNum.Text = result(2)
                    TB_FacturaElectronica_SubTotal.Text = result(3).ToString + " €"
                Case 8
                    TB_OficinaVirtual_TotalNum.Text = result(2)
                    TB_OficinaVirtual_SubTotal.Text = result(3).ToString + " €"
                Case 9
                    TB_ComunicacionesSeguras_TotalNum.Text = result(2)
                    TB_ComunicacionesSeguras_SubTotal.Text = result(3).ToString + " €"
                Case 10
                    TB_Ciberseguridad_TotalNum.Text = result(2)
                    TB_Ciberseguridad_SubTotal.Text = result(3).ToString + " €"
            End Select
        Next
        TB_SubTotal.Text = TotalEmpreses.ToString("C0", New Globalization.CultureInfo("es-ES"))
        resultatsTotals.Clear()
    End Sub
    Private Sub ompleDadesSolucionsEstatTotes()

        TB_Preparant.Text = "0"
        TB_Enviada.Text = "0"
        TB_Esborrany.Text = "0"
        TB_Presentada.Text = "0"
        TB_EsmenaObert.Text = "0"
        TB_ValidadaPagament.Text = "0"
        TB_Pagada.Text = "0"
        TB_FinalitzadaEsmena.Text = "0"
        TB_EsmenaIncorrecta.Text = "0"

        For Each result As Object In resultatsEstatsTotals
            Debug.WriteLine(result(0) & " - " & result(1))
            Select Case result(0)
                Case 0
                    TB_Preparant.Text = result(1)
                Case 1
                    TB_Enviada.Text = result(1)
                Case 2
                    TB_Esborrany.Text = result(1)
                Case 3
                    TB_Presentada.Text = result(1)
                Case 4
                    TB_EsmenaObert.Text = result(1)
                Case 5
                    TB_ValidadaPagament.Text = result(1)
                Case 6
                    TB_Pagada.Text = result(1)
                Case 7
                    TB_FinalitzadaEsmena.Text = result(1)
                Case 8
                    TB_EsmenaIncorrecta.Text = result(1)
            End Select
        Next

    End Sub

    Private Sub ompleDadesSolucionsEmpresa()
        Dim TotalEmpresaSeleccionada As Double = 0

        Panel_SitioWeb.Visible = False
        Panel_ComercioElectronico.Visible = False
        Panel_BI.Visible = False
        Panel_GestionProcesos.Visible = False
        Panel_FacturaElectronica.Visible = False
        Panel_OficinaVirtual.Visible = False
        Panel_ComunicacionesSeguras.Visible = False
        Panel_Ciberseguridad.Visible = False

        TB_SitioWeb_Estat.BackColor = SystemColors.Control
        TB_ComercioElectronico_Estat.BackColor = SystemColors.Control
        TB_BI_Estat.BackColor = SystemColors.Control
        TB_GestionProcesos_Estat.BackColor = SystemColors.Control
        TB_FacturaElectronica_Estat.BackColor = SystemColors.Control
        TB_FacturaElectronica_Estat.BackColor = SystemColors.Control
        TB_OficinaVirtual_Estat.BackColor = SystemColors.Control
        TB_OficinaVirtual_Estat.BackColor = SystemColors.Control
        TB_Ciberseguridad_Estat.BackColor = SystemColors.Control

        For Each result As Object In resultatsPerEmpresa

            TotalEmpresaSeleccionada += result(2)

            Select Case result(0)
                Case 1
                    TB_SitioWeb_Sub.Text = result(2).ToString + " €"
                    TB_SitioWeb_Estat.Text = result(3).ToString.ToUpper
                    Panel_SitioWeb.Visible = True
                    If result(4) = 4 Or result(4).ToString = 8 Then
                        TB_SitioWeb_Estat.BackColor = vermell
                    End If
                    If result(4) = 3 Or result(4) = 6 Then
                        TB_SitioWeb_Estat.BackColor = verd
                    End If

                Case 2
                    TB_ComercioElectronico_Sub.Text = result(2).ToString + " €"
                    TB_ComercioElectronico_Estat.Text = result(3).ToString.ToUpper
                    Panel_ComercioElectronico.Visible = True
                    If result(4) = 4 Or result(4) = 8 Then
                        TB_ComercioElectronico_Estat.BackColor = vermell
                    End If
                    If result(4) = 5 Or result(4) = 6 Then
                        TB_ComercioElectronico_Estat.BackColor = verd
                    End If
                Case 3
                Case 4
                Case 5
                    TB_BI_Sub.Text = result(2).ToString + " €"
                    TB_BI_Estat.Text = result(3).ToString.ToUpper
                    Panel_BI.Visible = True
                    If result(4) = 4 Or result(4).ToString = 8 Then
                        TB_BI_Estat.BackColor = vermell
                    End If
                    If result(4) = 5 Or result(4) = 6 Then
                        TB_BI_Estat.BackColor = verd
                    End If
                Case 6

                    TB_GestionProcesos_Sub.Text = result(2).ToString + " €"
                    TB_GestionProcesos_Estat.Text = result(3).ToString.ToUpper
                    Panel_GestionProcesos.Visible = True
                    If result(4) = 4 Or result(4).ToString = 8 Then
                        TB_GestionProcesos_Estat.BackColor = vermell
                    End If
                    If result(4) = 5 Or result(4) = 6 Then
                        TB_GestionProcesos_Estat.BackColor = verd
                    End If
                Case 7
                    TB_FacturaElectronica_Sub.Text = result(2).ToString + " €"
                    TB_FacturaElectronica_Estat.Text = result(3).ToString.ToUpper
                    Panel_FacturaElectronica.Visible = True
                    If result(4) = 4 Or result(4).ToString = 8 Then
                        TB_FacturaElectronica_Estat.BackColor = vermell
                    End If
                    If result(4) = 5 Or result(4) = 6 Then
                        TB_FacturaElectronica_Estat.BackColor = verd
                    End If
                Case 8
                    TB_OficinaVirtual_Sub.Text = result(2).ToString + " €"
                    TB_OficinaVirtual_Estat.Text = result(3).ToString.ToUpper
                    Panel_OficinaVirtual.Visible = True
                    If result(4) = 4 Or result(4).ToString = 8 Then
                        TB_OficinaVirtual_Estat.BackColor = vermell
                    End If
                    If result(4) = 5 Or result(4) = 6 Then
                        TB_OficinaVirtual_Estat.BackColor = verd
                    End If
                Case 9
                    TB_ComunicacionesSeguras_Sub.Text = result(2).ToString + " €"
                    TB_ComunicacionesSeguras_Estat.Text = result(3).ToString.ToUpper
                    Panel_ComunicacionesSeguras.Visible = True
                    If result(4) = 4 Or result(4).ToString = 8 Then
                        TB_ComunicacionesSeguras_Estat.BackColor = vermell
                    End If
                    If result(4) = 5 Or result(4) = 6 Then
                        TB_ComunicacionesSeguras_Estat.BackColor = verd
                    End If
                Case 10
                    TB_Ciberseguridad_Sub.Text = result(2).ToString + " €"
                    TB_Ciberseguridad_Estat.Text = result(3).ToString.ToUpper
                    Panel_Ciberseguridad.Visible = True
                    If result(4) = 4 Or result(4).ToString = 8 Then
                        TB_Ciberseguridad_Estat.BackColor = vermell
                    End If
                    If result(4) = 5 Or result(4) = 6 Then
                        TB_Ciberseguridad_Estat.BackColor = verd
                    End If
            End Select
        Next

        TB_SubTotalEmpresa.Text = TotalEmpresaSeleccionada.ToString("C0", New Globalization.CultureInfo("es-ES"))
        resultatsPerEmpresa.Clear()
    End Sub

    Private Sub DataExtresGeneral_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)

        Dim dgv As DataGridView = sender
        If dgv.RowCount > 0 Then
            dgv.Columns("Solució").Width = 150
        End If
    End Sub

    Private Sub DataEstatSolucions_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        Dim dgv As DataGridView = sender
        If dgv.RowCount > 0 Then
            dgv.Columns("Estat").Width = 150
            dgv.Columns("Quantitat").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv.Columns("Quantitat").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End If
    End Sub

    Private Sub DataExtresGeneral_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs)
        Dim dgv As DataGridView = sender

        dgv.Columns("Id").Visible = False
        TotalSolucionsValor = 0
        TotalGeneralValor = 0

        If dgv.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In dgv.Rows
                If Fila IsNot Nothing Then
                    TotalGeneralValor += Fila.Cells("Subvencions").Value
                    TotalSolucionsValor += Fila.Cells("Quantitat").Value
                End If
            Next
        End If
    End Sub

    Private Sub TextCerca_TextChanged(sender As Object, e As EventArgs) Handles TextCerca.TextChanged
        Dim txtCerca As String = TextCerca.Text
        Dim conexion As New SQLiteConnection(cadena)
        conexion.Open()

        Try
            If conexion.State = ConnectionState.Open Then
                Dim DA As New SQLiteDataAdapter("SELECT id, nom from empreses Where nom like '%" & txtCerca & "%'", conexion)
                DT_CercaEmpreses.Clear()
                DA.Fill(DT_CercaEmpreses)

                If DT_CercaEmpreses.Rows.Count > 0 Then
                    CercaEmpreses.DataSource = DT_CercaEmpreses
                Else
                    CercaEmpreses.DataSource = Nothing
                End If
            End If

        Catch ex As Exception
            MsgBox("No s'ha pogut accedir a la base de dades", vbCritical, "Error")
        End Try

        conexion.Close()


    End Sub

    Private Sub CercaEmpreses_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles CercaEmpreses.DataBindingComplete
        CercaEmpreses.Columns("Id").Visible = False
        If DT_CercaEmpreses.Rows.Count > 0 Then
            TB_EmpresaSeleccionada.Text = CercaEmpreses.Rows(0).Cells("Nom").Value
            CarregaSolucionsEmpresa(CercaEmpreses.Rows(0).Cells("Id").Value)
        End If
    End Sub

    Private Sub CercaEmpreses_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CercaEmpreses.CellClick
        If e.RowIndex >= 0 Then
            TB_EmpresaSeleccionada.Text = CercaEmpreses.CurrentRow.Cells("Nom").Value
            CarregaSolucionsEmpresa(CercaEmpreses.Rows(e.RowIndex).Cells("Id").Value)
        End If
    End Sub

End Class