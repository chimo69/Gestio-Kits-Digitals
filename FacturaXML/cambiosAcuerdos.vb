Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Linq

Public Class cambiosAcuerdos
    Public Sub New(listaCambios As List(Of AcuerdosCambiados))

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().


        Dim listaCambiosOrdenada = listaCambios.OrderBy(Function(cambio) cambio.Tipus).ToList()
        Data_canvisAcords.DataSource = listaCambiosOrdenada

    End Sub

    Private Sub Data_canvisAcords_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles Data_canvisAcords.DataBindingComplete
        Dim dgv As DataGridView = sender

        dgv.Columns("AnticEstat").HeaderText = "Antic estat"
        dgv.Columns("Estat").HeaderText = "Nou estat"

        With sender
            .AutoResizeColumns()
            .ClearSelection()
        End With

    End Sub

    Private Sub Data_canvisAcords_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles Data_canvisAcords.CellFormatting
        Dim dgv As DataGridView = sender
        If dgv.Columns(e.ColumnIndex).Name = "AnticEstat" Or dgv.Columns(e.ColumnIndex).Name = "Estat" Then
            Select Case (e.Value)
                Case 0
                    e.Value = "Preparant documentació"
                Case 1
                    e.Value = "Enviada"
                Case 2
                    e.Value = "Esborrany"
                Case 3
                    e.Value = "Presentada"
                Case 4
                    e.Value = "Termini d'esmena obert"
                    e.CellStyle.BackColor = vermell
                Case 5
                    e.Value = "Validada per pagament"
                    e.CellStyle.BackColor = verd
                Case 6
                    e.Value = "Pagada"
                    e.CellStyle.BackColor = verd
                Case 7
                    e.Value = "Finalitzat termini d'esmena"
                    e.CellStyle.BackColor = vermell
                Case 8
                    e.Value = "Esmena incorrecta"
                    e.CellStyle.BackColor = vermell
                Case 9
                    e.Value = "No pagada"
                    e.CellStyle.BackColor = vermell
                Case 10
                    e.Value = "Pagament minorat"
                    e.CellStyle.BackColor = verd
                Case 11
                    e.Value = "Documentació addicional"
                    e.CellStyle.BackColor = vermell
            End Select
        End If

        If dgv.Columns(e.ColumnIndex).Name = "Tipus" Then
            Select Case (e.Value)
                Case 1
                    e.CellStyle.BackColor = tipus1
                    e.Value = "PRIMERA"
                Case 2
                    e.CellStyle.BackColor = tipus2
                    e.Value = "SEGONA"
            End Select
        End If
    End Sub
End Class