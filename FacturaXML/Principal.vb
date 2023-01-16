Imports System.Data.SqlClient

Public Class Principal

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub Btn_Factures_Click(sender As Object, e As EventArgs) Handles Btn_Factures.Click

        Dim Factures As New Factures
        OpenSubForm(Factures)

    End Sub

    Private Sub Btn_Contractes_Click(sender As Object, e As EventArgs) Handles Btn_Contractes.Click
        Dim Contractes As New Contractes
        OpenSubForm(Contractes)
    End Sub

    Private Sub SortirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SortirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SobreGestioDeKitsDigitalsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SobreGestioDeKitsDigitalsToolStripMenuItem.Click
        Dim ASobreDe As New ASobreDe()
        OpenSubForm(ASobreDe)
    End Sub

    Private Sub GestióDeKitsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestióDeKitsToolStripMenuItem.Click
        Dim Contractes As New Contractes
        OpenSubForm(Contractes)
    End Sub

    Private Sub LlistatTotalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LlistatTotalToolStripMenuItem.Click
        Dim Llistat As New Llistat
        OpenSubForm(Llistat)
    End Sub

    Private Sub CrearFacturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearFacturaToolStripMenuItem.Click
        Dim Factures As New Factures
        OpenSubForm(Factures)
    End Sub

    Private Sub DadesEmpresaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DadesEmpresaToolStripMenuItem.Click
        Dim dadesEmpresa As New DadesEmpresaConfig()
        OpenSubForm(dadesEmpresa)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Llistat As New Llistat
        OpenSubForm(Llistat)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Informacio As New Informacio
        OpenSubForm(Informacio)
    End Sub

    Private Sub InformacióDeSolucionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformacióDeSolucionsToolStripMenuItem.Click
        Dim Informacio As New Informacio
        OpenSubForm(Informacio)
    End Sub
End Class