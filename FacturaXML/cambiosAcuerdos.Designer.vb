<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cambiosAcuerdos
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
        Data_canvisAcords = New DataGridView()
        CType(Data_canvisAcords, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Data_canvisAcords
        ' 
        Data_canvisAcords.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Data_canvisAcords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Data_canvisAcords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Data_canvisAcords.Location = New Point(12, 12)
        Data_canvisAcords.Name = "Data_canvisAcords"
        Data_canvisAcords.RowTemplate.Height = 25
        Data_canvisAcords.Size = New Size(1134, 533)
        Data_canvisAcords.TabIndex = 0
        ' 
        ' cambiosAcuerdos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1158, 557)
        Controls.Add(Data_canvisAcords)
        Name = "cambiosAcuerdos"
        ShowInTaskbar = False
        Text = "Actualitzacions fetes"
        CType(Data_canvisAcords, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Data_canvisAcords As DataGridView
End Class
