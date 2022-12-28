Public Class VistaPrevia

    Public Sub New(textoXML As System.Text.StringBuilder)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Dim x As String
        x = textoXML.ToString
        XmlCreado.Text = x
    End Sub

End Class