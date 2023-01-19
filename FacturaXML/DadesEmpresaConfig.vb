Imports System.IO

Public Class DadesEmpresaConfig
    Dim dadesEmpresa As New System.Text.StringBuilder()
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        TB_NomEmpresa.Text = My.Settings.Empresa
        TB_Direccio.Text = My.Settings.Direccio
        TB_CodiPostal.Text = My.Settings.CodiPostal
        TB_ciutat.Text = My.Settings.Ciuat
        TB_Provincia.Text = My.Settings.Provincia
        TB_Pais.Text = My.Settings.Pais
    End Sub
    Private Sub GuardarArchivo()

        My.Settings.Empresa = TB_NomEmpresa.Text
        My.Settings.Direccio = TB_Direccio.Text
        My.Settings.CodiPostal = TB_CodiPostal.Text
        My.Settings.Ciuat = TB_ciutat.Text
        My.Settings.Provincia = TB_Provincia.Text
        My.Settings.Pais = TB_Pais.Text

        Me.Close()
        MsgBox("Noves dades guardades", vbInformation, "Configuració empresa")

    End Sub

    Private Sub Btn_GuardarDades_Click(sender As Object, e As EventArgs) Handles Btn_GuardarDades.Click
        GuardarArchivo
    End Sub
End Class