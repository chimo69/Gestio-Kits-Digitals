Public Class Preferencies
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        DiesAvisCaducat.Value = My.Settings.DiesAvis
    End Sub
    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        My.Settings.DiesAvis = DiesAvisCaducat.Value
        Me.Close()
        MsgBox("Preferencies guardades", vbInformation, "Configuració preferencies")

    End Sub
End Class