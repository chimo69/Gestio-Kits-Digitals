<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DadesEmpresaConfig
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DadesEmpresaConfig))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TB_NomEmpresa = New System.Windows.Forms.TextBox()
        Me.TB_Direccio = New System.Windows.Forms.TextBox()
        Me.TB_CodiPostal = New System.Windows.Forms.TextBox()
        Me.TB_ciutat = New System.Windows.Forms.TextBox()
        Me.TB_Provincia = New System.Windows.Forms.TextBox()
        Me.TB_Pais = New System.Windows.Forms.TextBox()
        Me.Btn_GuardarDades = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom empresa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Direcció"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Codi Postal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ciutat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(54, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Provincia"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(54, 278)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Pais"
        '
        'TB_NomEmpresa
        '
        Me.TB_NomEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_NomEmpresa.Location = New System.Drawing.Point(167, 30)
        Me.TB_NomEmpresa.Name = "TB_NomEmpresa"
        Me.TB_NomEmpresa.Size = New System.Drawing.Size(270, 23)
        Me.TB_NomEmpresa.TabIndex = 1
        '
        'TB_Direccio
        '
        Me.TB_Direccio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_Direccio.Location = New System.Drawing.Point(167, 78)
        Me.TB_Direccio.Name = "TB_Direccio"
        Me.TB_Direccio.Size = New System.Drawing.Size(270, 23)
        Me.TB_Direccio.TabIndex = 2
        '
        'TB_CodiPostal
        '
        Me.TB_CodiPostal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_CodiPostal.Location = New System.Drawing.Point(167, 126)
        Me.TB_CodiPostal.Name = "TB_CodiPostal"
        Me.TB_CodiPostal.Size = New System.Drawing.Size(131, 23)
        Me.TB_CodiPostal.TabIndex = 3
        '
        'TB_ciutat
        '
        Me.TB_ciutat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_ciutat.Location = New System.Drawing.Point(167, 174)
        Me.TB_ciutat.Name = "TB_ciutat"
        Me.TB_ciutat.Size = New System.Drawing.Size(270, 23)
        Me.TB_ciutat.TabIndex = 4
        '
        'TB_Provincia
        '
        Me.TB_Provincia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_Provincia.Location = New System.Drawing.Point(167, 222)
        Me.TB_Provincia.Name = "TB_Provincia"
        Me.TB_Provincia.Size = New System.Drawing.Size(270, 23)
        Me.TB_Provincia.TabIndex = 5
        '
        'TB_Pais
        '
        Me.TB_Pais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_Pais.Location = New System.Drawing.Point(167, 270)
        Me.TB_Pais.Name = "TB_Pais"
        Me.TB_Pais.Size = New System.Drawing.Size(270, 23)
        Me.TB_Pais.TabIndex = 6
        '
        'Btn_GuardarDades
        '
        Me.Btn_GuardarDades.Location = New System.Drawing.Point(306, 338)
        Me.Btn_GuardarDades.Name = "Btn_GuardarDades"
        Me.Btn_GuardarDades.Size = New System.Drawing.Size(131, 38)
        Me.Btn_GuardarDades.TabIndex = 7
        Me.Btn_GuardarDades.Text = "Guardar"
        Me.Btn_GuardarDades.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(499, 399)
        Me.Controls.Add(Me.Btn_GuardarDades)
        Me.Controls.Add(Me.TB_Pais)
        Me.Controls.Add(Me.TB_Provincia)
        Me.Controls.Add(Me.TB_ciutat)
        Me.Controls.Add(Me.TB_CodiPostal)
        Me.Controls.Add(Me.TB_Direccio)
        Me.Controls.Add(Me.TB_NomEmpresa)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dades empresa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TB_NomEmpresa As TextBox
    Friend WithEvents TB_Direccio As TextBox
    Friend WithEvents TB_CodiPostal As TextBox
    Friend WithEvents TB_ciutat As TextBox
    Friend WithEvents TB_Provincia As TextBox
    Friend WithEvents TB_Pais As TextBox
    Friend WithEvents Btn_GuardarDades As Button
End Class
