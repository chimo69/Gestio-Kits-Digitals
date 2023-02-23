Imports System.Data.SQLite

Public Class Extras
    Private DT_Extres, DT_Empreses, DT_ExtresGeneral, DT_EstatSolucions As New DataTable
    Private TotalEmpresaValor, TotalGeneralValor As Double
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub Extras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim SQL As String
        Dim conexion As New SQLiteConnection()

        conexion = New SQLiteConnection(cadena)
        conexion.Open()

        SQL = "SELECT * FROM Empreses ORDER BY Nom ASC"
        Try
            If conexion.State = ConnectionState.Open Then
                Dim DA_Empreses As New SQLiteDataAdapter(SQL, conexion)
                DA_Empreses.Fill(DT_Empreses)
                CB_Empreses.DataSource = DT_Empreses
                CB_Empreses.DisplayMember = "Nom"
                CB_Empreses.Text = "Selecciona empresa"
                CB_Empreses.ValueMember = "Id"
            End If

        Catch ex As Exception
            MsgBox("No s'han pogut carregar les empreses desde la base de dades", vbCritical, "Error")
        End Try

        Try
            If conexion.State = ConnectionState.Open Then
                Dim DA As New SQLiteDataAdapter("SELECT TipusSolucions.Nom, sum(Justificacions.Subvencio) as Subvencions from Solucions
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

        conexion.Close()

    End Sub

    Private Sub DataExtresGeneral_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataExtresGeneral.CellFormatting
        DataExtresGeneral.Columns("Nom").Width = 150
    End Sub

    Private Sub DataExtres_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataExtres.DataBindingComplete

        If DataExtres.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In DataExtres.Rows
                If Fila IsNot Nothing Then
                    TotalEmpresaValor += Fila.Cells("Subvencions").Value
                End If
            Next
        End If

        TotalEmpresa.Text = Format(TotalEmpresaValor, "#,##0.00 €")
    End Sub

    Private Sub DataEstatSolucions_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataEstatSolucions.CellFormatting
        DataEstatSolucions.Columns("Estat").Width = 150
    End Sub

    Private Sub DataExtresGeneral_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataExtresGeneral.DataBindingComplete
        If DataExtresGeneral.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In DataExtresGeneral.Rows
                If Fila IsNot Nothing Then
                    TotalGeneralValor = TotalGeneralValor + Fila.Cells("Subvencions").Value
                End If
            Next
        End If
        TotalGeneral.Text = Format(TotalGeneralValor, "#,##0.00 €")
    End Sub

    Private Sub DataExtres_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataExtres.CellFormatting
        DataExtres.Columns("Nom").Width = 150
    End Sub

    Private Sub CB_Empreses_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CB_Empreses.SelectionChangeCommitted
        TotalEmpresaValor = 0
        CarregaDades(CB_Empreses.SelectedValue)
    End Sub

    Private Sub CarregaDades(idEmpresa As Integer)
        Dim conexion As New SQLiteConnection(cadena)
        Try
            conexion.Open()

            If conexion.State = ConnectionState.Open Then
                Dim DA As New SQLiteDataAdapter("SELECT TipusSolucions.Nom, sum(Justificacions.Subvencio) as Subvencions from Solucions
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
End Class