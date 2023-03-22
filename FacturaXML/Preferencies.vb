Public Class Preferencies
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        DiesAvisCaducat.Value = My.Settings.DiesAvis
        DiesAvisConcessio.Value = My.Settings.DiesConcessio
        MesosAprovacio.Value = My.Settings.MesosAprovacio
        MesosContractacio.Value = My.Settings.MesosContractacio
        MesosFactura.Value = My.Settings.MesosFactura
        MostrarLlistatAprovades.Checked = My.Settings.MostrarGestioAprovades
        MostrarGestioAprovades.Checked = My.Settings.MostrarGestioAprovades
        CB_MostrarEmpresesContractes.Checked = My.Settings.MostrarEmpresesConcessio
    End Sub
    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        My.Settings.DiesAvis = DiesAvisCaducat.Value
        My.Settings.DiesConcessio = DiesAvisConcessio.Value
        My.Settings.MesosAprovacio = MesosAprovacio.Value
        My.Settings.MesosContractacio = MesosContractacio.Value
        My.Settings.MesosFactura = MesosFactura.Value
        My.Settings.MostrarLlistatAprovades = MostrarLlistatAprovades.Checked
        My.Settings.MostrarGestioAprovades = MostrarGestioAprovades.Checked
        My.Settings.MostrarEmpresesConcessio = CB_MostrarEmpresesContractes.Checked
        Me.Close()
        MsgBox("Preferencies guardades",, "Configuració preferencies")


    End Sub
End Class