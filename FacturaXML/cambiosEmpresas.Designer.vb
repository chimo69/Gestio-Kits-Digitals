<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cambiosEmpresas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Data_canvisEmpreses = New DataGridView()
        CType(Data_canvisEmpreses, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Data_canvisEmpreses
        ' 
        Data_canvisEmpreses.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Data_canvisEmpreses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Data_canvisEmpreses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Data_canvisEmpreses.Location = New Point(12, 12)
        Data_canvisEmpreses.Name = "Data_canvisEmpreses"
        Data_canvisEmpreses.RowTemplate.Height = 25
        Data_canvisEmpreses.Size = New Size(776, 426)
        Data_canvisEmpreses.TabIndex = 1
        ' 
        ' cambiosEmpresas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Data_canvisEmpreses)
        Name = "cambiosEmpresas"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Llista de noves empreses introduides"
        CType(Data_canvisEmpreses, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Data_canvisEmpreses As DataGridView
End Class
