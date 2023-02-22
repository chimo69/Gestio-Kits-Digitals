Imports System.Data.SQLite

Public Class Extras
    Private DT_Extres, DT_Empreses, DT_ExtresGeneral As New DataTable
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub Extras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim SQL As String
        Dim conexion As New SQLiteConnection()
        Dim strCommand As SQLiteCommand

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

        conexion.Close()
    End Sub

    Private Sub DataExtresGeneral_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataExtresGeneral.CellFormatting
        DataExtresGeneral.Columns("Nom").Width = 150
    End Sub

    Private Sub DataExtres_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataExtres.CellFormatting
        DataExtres.Columns("Nom").Width = 150
    End Sub
    Private Sub DataExtres_DataSourceChanged(sender As Object, e As EventArgs) Handles DataExtres.DataSourceChanged
        'DataExtres.Columns("Subvencio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    Private Sub DataExtresGeneral_DataSourceChanged(sender As Object, e As EventArgs) Handles DataExtresGeneral.DataSourceChanged
        'DataExtresGeneral.Columns("Subvencio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    Private Sub CB_Empreses_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CB_Empreses.SelectionChangeCommitted
        CarregaDades(CB_Empreses.SelectedValue)
    End Sub

    Private Sub CarregaDades(idEmpresa As Integer)
        Try
            Dim conexion As New SQLiteConnection(cadena)
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
            conexion.Close()

        Catch ex As Exception
            MsgBox("No s'ha pogut accedir a la base de dades", vbCritical, "Error")
        End Try
    End Sub
End Class