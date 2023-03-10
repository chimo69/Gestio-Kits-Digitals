Imports System.Data.SQLite

Public Class Extras
    Private DT_Extres, DT_ExtresGeneral, DT_EstatSolucions, DT_CercaEmpreses As New DataTable
    Private TotalEmpresaValor, TotalGeneralValor As Double
    Private TotalSolucionsValor As Integer
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub Extras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim conexion As New SQLiteConnection(cadena)

        conexion.Open()

        ' Columna de Soluciones general
        Try
            If conexion.State = ConnectionState.Open Then
                Dim DA As New SQLiteDataAdapter("SELECT TipusSolucions.id, TipusSolucions.Nom as 'Solució',  count(Justificacions.id) as Quantitat, sum(Justificacions.Subvencio) as Subvencions from Solucions
                                                 INNER JOIN TipusSolucions ON TipusSolucions.Id=Solucions.IdSolucio
                                                 INNER JOIN Justificacions ON Solucions.Id=Justificacions.IdSolucio                                                 
                                                 GROUP by TipusSolucions.Nom", conexion)
                DT_ExtresGeneral.Clear()
                DA.Fill(DT_ExtresGeneral)

                If DT_ExtresGeneral.Rows.Count > 0 Then
                    DataExtresGeneral.DataSource = DT_ExtresGeneral
                Else
                    DataExtresGeneral.DataSource = Nothing
                End If
            End If

        Catch ex As Exception
            MsgBox("No s'ha pogut accedir a la base de dades", vbCritical, "Error")
        End Try

        ' Columna de quantitat de estats
        Try
            If conexion.State = ConnectionState.Open Then
                Dim DA As New SQLiteDataAdapter("SELECT TipusEstats.NomEstat as 'Estat', count(Justificacions.Estat) as Quantitat from Justificacions                                               
                                                 INNER JOIN TipusEstats ON TipusEstats.Id=Justificacions.Estat                                                 
                                                 GROUP by Justificacions.Estat", conexion)
                DT_EstatSolucions.Clear()
                DA.Fill(DT_EstatSolucions)

                If DT_EstatSolucions.Rows.Count > 0 Then
                    DataEstatSolucions.DataSource = DT_EstatSolucions
                Else
                    DataEstatSolucions.DataSource = Nothing
                End If
            End If

        Catch ex As Exception
            MsgBox("No s'ha pogut accedir a la base de dades", vbCritical, "Error")
        End Try

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

    End Sub

    Private Sub DataExtresGeneral_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataExtresGeneral.CellFormatting
        Dim dgv As DataGridView = sender
        dgv.Columns("Solució").Width = 150
        dgv.Columns("Subvencions").Width = 80
        dgv.Columns("Subvencions").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv.Columns("Quantitat").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub DataExtres_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataExtres.DataBindingComplete
        TotalEmpresaValor = 0

        If DataExtres.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In DataExtres.Rows
                If Fila IsNot Nothing Then
                    TotalEmpresaValor += Fila.Cells("Subvencions").Value
                End If
            Next
        End If

        PB_SitioWeb.Value = 0
        PB_ComercioElectronico.Value = 0
        PB_RedesSociales.Value = 0
        PB_Clientes.Value = 0
        PB_BI.Value = 0
        PB_GestionProcesos.Value = 0
        PB_FacturaElectronica.Value = 0
        PB_OficinaVirtual.Value = 0
        PB_ComunicacionesSeguras.Value = 0
        PB_Ciberseguridad.Value = 0

        If DataExtres.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In DataExtres.Rows
                If Fila IsNot Nothing Then
                    Dim percentatge As Double = (Fila.Cells("Subvencions").Value * 100) / TotalEmpresaValor
                    Select Case (Fila.Cells("id")).Value
                        Case 1
                            PB_SitioWeb.Value = percentatge
                        Case 2
                            PB_ComercioElectronico.Value = percentatge
                        Case 3
                            PB_RedesSociales.Value = percentatge
                        Case 4
                            PB_Clientes.Value = percentatge
                        Case 5
                            PB_BI.Value = percentatge
                        Case 6
                            PB_GestionProcesos.Value = percentatge
                        Case 7
                            PB_FacturaElectronica.Value = percentatge
                        Case 8
                            PB_OficinaVirtual.Value = percentatge
                        Case 9
                            PB_ComunicacionesSeguras.Value = percentatge
                        Case 10
                            PB_Ciberseguridad.Value = percentatge
                    End Select
                End If
            Next
        End If

        TotalEmpresa.Text = Format(TotalEmpresaValor, "#,##0.00 €")
        DataExtres.Columns("Id").Visible = False
        DataExtres.ClearSelection()
    End Sub

    Private Sub DataEstatSolucions_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataEstatSolucions.CellFormatting
        Dim dgv As DataGridView = sender
        dgv.Columns("Estat").Width = 150
        dgv.Columns("Quantitat").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.Columns("Quantitat").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub DataExtresGeneral_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataExtresGeneral.DataBindingComplete
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

        PB_SitioWebG.Value = 0
        PB_ComercioElectronicoG.Value = 0
        PB_RedesSocialesG.Value = 0
        PB_ClientesG.Value = 0
        PB_BIG.Value = 0
        PB_ProcesosG.Value = 0
        PB_FacturaElectronicaG.Value = 0
        PB_OficinaVirtual.Value = 0
        PB_ComunicacionesSeguras.Value = 0
        PB_Ciberseguridad.Value = 0

        If dgv.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In dgv.Rows
                If Fila IsNot Nothing Then
                    Dim percentatge As Double = (Fila.Cells("Subvencions").Value * 100) / TotalGeneralValor
                    Select Case (Fila.Cells("Id")).Value
                        Case 1
                            PB_SitioWebG.Value = percentatge
                        Case 2
                            PB_ComercioElectronicoG.Value = percentatge
                        Case 3
                            PB_RedesSocialesG.Value = percentatge
                        Case 4
                            PB_ClientesG.Value = percentatge
                        Case 5
                            PB_BIG.Value = percentatge
                        Case 6
                            PB_ProcesosG.Value = percentatge
                        Case 7
                            PB_FacturaElectronicaG.Value = percentatge
                        Case 8
                            PB_OficinaVirtualG.Value = percentatge
                        Case 9
                            PB_ComunicacionesSegurasG.Value = percentatge
                        Case 10
                            PB_CiberseguridadG.Value = percentatge
                    End Select
                End If
            Next
        End If


        TotalGeneral.Text = Format(TotalGeneralValor, "#,##0.00 €")
        DataExtresGeneral.ClearSelection()
        TotalSolucions.Text = TotalSolucionsValor.ToString
    End Sub

    Private Sub DataExtres_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataExtres.CellFormatting
        Dim dgv As DataGridView = sender
        dgv.Columns("Solució").Width = 150
        dgv.Columns("Subvencions").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv.Columns("Subvencions").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    Private Sub CarregaDades(idEmpresa As Integer)
        Dim conexion As New SQLiteConnection(cadena)
        Try
            conexion.Open()

            If conexion.State = ConnectionState.Open Then
                Dim DA As New SQLiteDataAdapter("SELECT TipusSolucions.id, TipusSolucions.Nom as 'Solució', sum(Justificacions.Subvencio) as Subvencions from Solucions
                                                 INNER JOIN TipusSolucions ON TipusSolucions.Id=Solucions.IdSolucio
                                                 INNER JOIN Justificacions ON Solucions.Id=Justificacions.IdSolucio
                                                 WHERE Solucions.idEmpresa=" & idEmpresa & " 
                                                 GROUP by TipusSolucions.Nom", conexion)
                DT_Extres.Clear()
                DA.Fill(DT_Extres)

                If DT_Extres.Rows.Count > 0 Then
                    DataExtres.DataSource = DT_Extres
                Else
                    DataExtres.DataSource = Nothing
                End If
            End If
        Catch ex As Exception
            MsgBox("No s'ha pogut accedir a la base de dades", vbCritical, "Error")
        End Try
        conexion.Close()

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

    Private Sub DataEstatSolucions_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataEstatSolucions.DataBindingComplete
        DataEstatSolucions.ClearSelection()
    End Sub

    Private Sub CercaEmpreses_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles CercaEmpreses.CellFormatting

    End Sub

    Private Sub CercaEmpreses_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles CercaEmpreses.DataBindingComplete
        CercaEmpreses.Columns("Id").Visible = False
        If DT_CercaEmpreses.Rows.Count > 0 Then
            TB_Empresa.Text = CercaEmpreses.Rows(0).Cells("Nom").Value
            CarregaDades(CercaEmpreses.Rows(0).Cells("Id").Value)
        End If
    End Sub

    Private Sub CercaEmpreses_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CercaEmpreses.CellClick
        If e.RowIndex >= 0 Then
            TB_Empresa.Text = CercaEmpreses.Rows(e.RowIndex).Cells("Nom").Value
            CarregaDades(CercaEmpreses.Rows(e.RowIndex).Cells("Id").Value)
        End If
    End Sub


End Class