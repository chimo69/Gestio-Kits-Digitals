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

    Private Sub PreferenciesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreferenciesToolStripMenuItem.Click
        Dim Preferencies As New Preferencies
        OpenSubForm(Preferencies)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start(New ProcessStartInfo("https://appkitdigital.idrconsulting.com/") With {.UseShellExecute = True})
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start(New ProcessStartInfo("https://portal.gestion.sedepkd.red.gob.es/portal/espacioAD") With {.UseShellExecute = True})
    End Sub

    Private Sub IdrConsultingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IdrConsultingToolStripMenuItem.Click
        Process.Start(New ProcessStartInfo("https://appkitdigital.idrconsulting.com/") With {.UseShellExecute = True})
    End Sub

    Private Sub EspacioDigitalizadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EspacioDigitalizadorToolStripMenuItem.Click
        Process.Start(New ProcessStartInfo("https://portal.gestion.sedepkd.red.gob.es/portal/espacioAD") With {.UseShellExecute = True})
    End Sub

    Private Sub Btn_Extres_Click(sender As Object, e As EventArgs) Handles Btn_Extres.Click
        Dim Extres As New Extras
        OpenSubForm(Extres)
    End Sub

    Private Sub Btn_Empreses_Click(sender As Object, e As EventArgs) Handles Btn_Empreses.Click
        Dim Empreses As New Empreses
        OpenSubForm(Empreses)
    End Sub
End Class