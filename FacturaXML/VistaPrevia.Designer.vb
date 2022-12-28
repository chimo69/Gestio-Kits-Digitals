<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VistaPrevia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VistaPrevia))
        Me.XmlCreado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'XmlCreado
        '
        Me.XmlCreado.AutoSize = True
        Me.XmlCreado.Location = New System.Drawing.Point(26, 36)
        Me.XmlCreado.Name = "XmlCreado"
        Me.XmlCreado.Size = New System.Drawing.Size(32, 15)
        Me.XmlCreado.TabIndex = 0
        Me.XmlCreado.Text = "Hola"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(662, 643)
        Me.Controls.Add(Me.XmlCreado)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Vista prèvia Factura XML"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents XmlCreado As Label
End Class
