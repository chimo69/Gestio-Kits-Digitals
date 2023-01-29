Public Class Preferencies
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        DiesAvisCaducat.Value = My.Settings.DiesAvis
        MesosAprovacio.Value = My.Settings.MesosAprovacio
        MesosContractacio.Value = My.Settings.MesosContractacio
        MesosFactura.Value = My.Settings.MesosFactura
        MostrarLlistatAprovades.Checked = My.Settings.MostrarGestioAprovades
        MostrarGestioAprovades.Checked = My.Settings.MostrarGestioAprovades
    End Sub
    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        My.Settings.DiesAvis = DiesAvisCaducat.Value
        My.Settings.MesosAprovacio = MesosAprovacio.Value
        My.Settings.MesosContractacio = MesosContractacio.Value
        My.Settings.MesosFactura = MesosFactura.Value
        My.Settings.MostrarLlistatAprovades = MostrarLlistatAprovades.Checked
        My.Settings.MostrarGestioAprovades = MostrarGestioAprovades.Checked
        Me.Close()
        MsgBox("Preferencies guardades", vbInformation, "Configuració preferencies")


    End Sub
End Class