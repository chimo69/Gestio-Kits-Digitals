<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Preferencies
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Preferencies))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DiesAvisCaducat = New System.Windows.Forms.NumericUpDown()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        CType(Me.DiesAvisCaducat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nº de dies per avisar per una solució apunt de caducar"
        '
        'DiesAvisCaducat
        '
        Me.DiesAvisCaducat.Location = New System.Drawing.Point(336, 32)
        Me.DiesAvisCaducat.Name = "DiesAvisCaducat"
        Me.DiesAvisCaducat.Size = New System.Drawing.Size(58, 23)
        Me.DiesAvisCaducat.TabIndex = 1
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.Location = New System.Drawing.Point(444, 305)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(112, 49)
        Me.Btn_Guardar.TabIndex = 2
        Me.Btn_Guardar.Text = "Guardar"
        Me.Btn_Guardar.UseVisualStyleBackColor = True
        '
        'Preferencies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(584, 379)
        Me.Controls.Add(Me.Btn_Guardar)
        Me.Controls.Add(Me.DiesAvisCaducat)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Preferencies"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Preferencies"
        CType(Me.DiesAvisCaducat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DiesAvisCaducat As NumericUpDown
    Friend WithEvents Btn_Guardar As Button
End Class
