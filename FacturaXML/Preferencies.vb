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
        MesosSuport.Value = My.Settings.MesosSuport
        TB_NomEmpresa.Text = My.Settings.Empresa
        TB_Direccio.Text = My.Settings.Direccio
        TB_CodiPostal.Text = My.Settings.CodiPostal
        TB_ciutat.Text = My.Settings.Ciuat
        TB_Provincia.Text = My.Settings.Provincia
        TB_Pais.Text = My.Settings.Pais
    End Sub
    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        My.Settings.DiesAvis = DiesAvisCaducat.Value
        My.Settings.DiesConcessio = DiesAvisConcessio.Value
        My.Settings.MesosAprovacio = MesosAprovacio.Value
        My.Settings.MesosContractacio = MesosContractacio.Value
        My.Settings.MesosFactura = MesosFactura.Value
        My.Settings.MesosSuport = MesosSuport.Value
        My.Settings.MostrarLlistatAprovades = MostrarLlistatAprovades.Checked
        My.Settings.MostrarGestioAprovades = MostrarGestioAprovades.Checked
        My.Settings.MostrarEmpresesConcessio = CB_MostrarEmpresesContractes.Checked
        My.Settings.Empresa = TB_NomEmpresa.Text
        My.Settings.Direccio = TB_Direccio.Text
        My.Settings.CodiPostal = TB_CodiPostal.Text
        My.Settings.Ciuat = TB_ciutat.Text
        My.Settings.Provincia = TB_Provincia.Text
        My.Settings.Pais = TB_Pais.Text
        Me.Close()
        MsgBox("Preferències guardades",, "Configuració preferències")
    End Sub
End Class