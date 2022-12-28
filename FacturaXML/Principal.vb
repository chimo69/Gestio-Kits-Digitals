Public Class Principal
    Private Sub Btn_Factures_Click(sender As Object, e As EventArgs) Handles Btn_factures.Click

        Dim Factures As New Factures
        Factures.Show()

    End Sub

    Private Sub Btn_Contractes_Click(sender As Object, e As EventArgs) Handles Btn_Contractes.Click
        Dim Contractes As New Contractes
        Contractes.Show()
    End Sub

    Private Sub SortirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SortirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SobreGestioDeKitsDigitalsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SobreGestioDeKitsDigitalsToolStripMenuItem.Click
        Dim ASobreDe As New ASobreDe()
        ASobreDe.Show()
    End Sub

    Private Sub GestióDeKitsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestióDeKitsToolStripMenuItem.Click
        Dim Contractes As New Contractes
        Contractes.Show()
    End Sub

    Private Sub LlistatTotalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LlistatTotalToolStripMenuItem.Click
        Dim Llistat As New Llistat
        Llistat.Show()
    End Sub

    Private Sub CrearFacturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearFacturaToolStripMenuItem.Click

        Dim Factures As New Factures
        Factures.Show()
    End Sub

    Private Sub DadesEmpresaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DadesEmpresaToolStripMenuItem.Click
        Dim dadesEmpresa As New DadesEmpresaConfig()
        dadesEmpresa.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Llistat As New Llistat
        Llistat.Show()
    End Sub
End Class