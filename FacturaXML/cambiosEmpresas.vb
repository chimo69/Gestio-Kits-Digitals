Public Class cambiosEmpresas
    Public Sub New(listaCambios As List(Of Empresa.Empresa))

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Data_canvisEmpreses.DataSource = listaCambios

    End Sub
    Private Sub Data_canvisEmpreses_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles Data_canvisEmpreses.DataBindingComplete
        Dim dgv As DataGridView = sender

        dgv.Columns("Importe").HeaderText = "Import"
        dgv.Columns("Fecha").HeaderText = "Data"
        dgv.Columns("caduca").HeaderText = "Caducitat"
        dgv.Columns("SegmentoValor").HeaderText = "Segment"

        With sender
            .AutoResizeColumns()
            .ClearSelection()
        End With

    End Sub
End Class