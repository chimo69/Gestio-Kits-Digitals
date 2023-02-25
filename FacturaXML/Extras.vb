Imports System.Data.SQLite

Public Class Extras
    Private DT_Extres, DT_ExtresGeneral, DT_EstatSolucions, DT_CercaEmpreses As New DataTable
    Private TotalEmpresaValor, TotalGeneralValor As Double
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub Extras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim conexion As New SQLiteConnection(cadena)

        conexion.Open()

        Try
            If conexion.State = ConnectionState.Open Then
                Dim DA As New SQLiteDataAdapter("SELECT TipusSolucions.Nom as 'Solució', sum(Justificacions.Subvencio) as Subvencions from Solucions
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

        Try
            If conexion.State = ConnectionState.Open Then
                Dim DA As New SQLiteDataAdapter("SELECT TipusEstats.NomEstat as 'Estat', count(Justificacions.Estat) as 'Quantitat' from Justificacions                                               
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
        'DataExtresGeneral.Columns("Nom").Width = 150
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

        TotalEmpresa.Text = Format(TotalEmpresaValor, "#,##0.00 €")
        DataExtres.ClearSelection()
    End Sub

    Private Sub DataEstatSolucions_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataEstatSolucions.CellFormatting
        DataEstatSolucions.Columns("Estat").Width = 150
    End Sub

    Private Sub DataExtresGeneral_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataExtresGeneral.DataBindingComplete
        If DataExtresGeneral.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In DataExtresGeneral.Rows
                If Fila IsNot Nothing Then
                    TotalGeneralValor += Fila.Cells("Subvencions").Value
                End If
            Next
        End If
        TotalGeneral.Text = Format(TotalGeneralValor, "#,##0.00 €")
        DataExtresGeneral.ClearSelection()
    End Sub

    Private Sub DataExtres_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataExtres.CellFormatting
        Dim dgv As DataGridView = sender
        dgv.Columns("Solució").Width = 150
    End Sub

    Private Sub CarregaDades(idEmpresa As Integer)
        Dim conexion As New SQLiteConnection(cadena)
        Try
            conexion.Open()

            If conexion.State = ConnectionState.Open Then
                Dim DA As New SQLiteDataAdapter("SELECT TipusSolucions.Nom as 'Solució', sum(Justificacions.Subvencio) as Subvencions from Solucions
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
        TB_Empresa.Text = CercaEmpreses.Rows(e.RowIndex).Cells("Nom").Value
        CarregaDades(CercaEmpreses.Rows(e.RowIndex).Cells("Id").Value)
    End Sub
End Class