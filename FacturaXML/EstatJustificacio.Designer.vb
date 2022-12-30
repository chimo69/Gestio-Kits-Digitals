<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EstatJustificacio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EstatJustificacio))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Empresa = New System.Windows.Forms.Label()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.Solucio = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Empresa)
        Me.Panel1.Location = New System.Drawing.Point(25, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(95, 43)
        Me.Panel1.TabIndex = 0
        '
        'Empresa
        '
        Me.Empresa.AutoSize = True
        Me.Empresa.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Empresa.Location = New System.Drawing.Point(3, 9)
        Me.Empresa.Name = "Empresa"
        Me.Empresa.Size = New System.Drawing.Size(87, 25)
        Me.Empresa.TabIndex = 0
        Me.Empresa.Text = "Empresa"
        '
        'Panel
        '
        Me.Panel.AutoSize = True
        Me.Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel.Controls.Add(Me.Solucio)
        Me.Panel.Location = New System.Drawing.Point(25, 74)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(86, 43)
        Me.Panel.TabIndex = 1
        '
        'Solucio
        '
        Me.Solucio.AutoSize = True
        Me.Solucio.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Solucio.Location = New System.Drawing.Point(3, 9)
        Me.Solucio.Name = "Solucio"
        Me.Solucio.Size = New System.Drawing.Size(78, 25)
        Me.Solucio.TabIndex = 0
        Me.Solucio.Text = "Solucio"
        '
        'EstatJustificacio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 681)
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EstatJustificacio"
        Me.Text = "EstatJustificacio"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Empresa As Label
    Friend WithEvents Panel As Panel
    Friend WithEvents Solucio As Label
End Class
