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
        Me.MesosAprovacio = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MesosContractacio = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MesosFactura = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MostrarLlistatAprovades = New System.Windows.Forms.CheckBox()
        Me.MostrarGestioAprovades = New System.Windows.Forms.CheckBox()
        Me.DiesAvisConcessio = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CB_MostrarEmpresesContractes = New System.Windows.Forms.CheckBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TB_Pais = New System.Windows.Forms.TextBox()
        Me.TB_Provincia = New System.Windows.Forms.TextBox()
        Me.TB_ciutat = New System.Windows.Forms.TextBox()
        Me.TB_CodiPostal = New System.Windows.Forms.TextBox()
        Me.TB_Direccio = New System.Windows.Forms.TextBox()
        Me.TB_NomEmpresa = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.DiesAvisCaducat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MesosAprovacio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MesosContractacio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MesosFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiesAvisConcessio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nº de dies per avisar per una solució apunt de caducar"
        '
        'DiesAvisCaducat
        '
        Me.DiesAvisCaducat.Location = New System.Drawing.Point(323, 25)
        Me.DiesAvisCaducat.Name = "DiesAvisCaducat"
        Me.DiesAvisCaducat.Size = New System.Drawing.Size(58, 23)
        Me.DiesAvisCaducat.TabIndex = 1
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.Location = New System.Drawing.Point(12, 375)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(421, 49)
        Me.Btn_Guardar.TabIndex = 2
        Me.Btn_Guardar.Text = "Guardar"
        Me.Btn_Guardar.UseVisualStyleBackColor = True
        '
        'MesosAprovacio
        '
        Me.MesosAprovacio.Location = New System.Drawing.Point(323, 83)
        Me.MesosAprovacio.Name = "MesosAprovacio"
        Me.MesosAprovacio.Size = New System.Drawing.Size(58, 23)
        Me.MesosAprovacio.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nº de mesos a partir de l'aprovació"
        '
        'MesosContractacio
        '
        Me.MesosContractacio.Location = New System.Drawing.Point(323, 112)
        Me.MesosContractacio.Name = "MesosContractacio"
        Me.MesosContractacio.Size = New System.Drawing.Size(58, 23)
        Me.MesosContractacio.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(211, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nº de mesos a partir de la contractació"
        '
        'MesosFactura
        '
        Me.MesosFactura.Location = New System.Drawing.Point(323, 141)
        Me.MesosFactura.Name = "MesosFactura"
        Me.MesosFactura.Size = New System.Drawing.Size(58, 23)
        Me.MesosFactura.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(250, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nº de mesos a partir de la emisió de la Factura"
        '
        'MostrarLlistatAprovades
        '
        Me.MostrarLlistatAprovades.AutoSize = True
        Me.MostrarLlistatAprovades.Location = New System.Drawing.Point(15, 199)
        Me.MostrarLlistatAprovades.Name = "MostrarLlistatAprovades"
        Me.MostrarLlistatAprovades.Size = New System.Drawing.Size(249, 19)
        Me.MostrarLlistatAprovades.TabIndex = 9
        Me.MostrarLlistatAprovades.Text = "Mostrar al llistat les solucions ja aprovades"
        Me.MostrarLlistatAprovades.UseVisualStyleBackColor = True
        '
        'MostrarGestioAprovades
        '
        Me.MostrarGestioAprovades.AutoSize = True
        Me.MostrarGestioAprovades.Location = New System.Drawing.Point(15, 224)
        Me.MostrarGestioAprovades.Name = "MostrarGestioAprovades"
        Me.MostrarGestioAprovades.Size = New System.Drawing.Size(262, 19)
        Me.MostrarGestioAprovades.TabIndex = 10
        Me.MostrarGestioAprovades.Text = "Mostrar a la gestió les solucions ja aprovades"
        Me.MostrarGestioAprovades.UseVisualStyleBackColor = True
        '
        'DiesAvisConcessio
        '
        Me.DiesAvisConcessio.Location = New System.Drawing.Point(323, 54)
        Me.DiesAvisConcessio.Name = "DiesAvisConcessio"
        Me.DiesAvisConcessio.Size = New System.Drawing.Size(58, 23)
        Me.DiesAvisConcessio.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(307, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Nº de dies per avisar per una concessió apunt de caducar"
        '
        'CB_MostrarEmpresesContractes
        '
        Me.CB_MostrarEmpresesContractes.AutoSize = True
        Me.CB_MostrarEmpresesContractes.Location = New System.Drawing.Point(15, 251)
        Me.CB_MostrarEmpresesContractes.Name = "CB_MostrarEmpresesContractes"
        Me.CB_MostrarEmpresesContractes.Size = New System.Drawing.Size(205, 19)
        Me.CB_MostrarEmpresesContractes.TabIndex = 13
        Me.CB_MostrarEmpresesContractes.Text = "Mostrar empreses amb contractes"
        Me.CB_MostrarEmpresesContractes.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(425, 344)
        Me.TabControl1.TabIndex = 14
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.CB_MostrarEmpresesContractes)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.DiesAvisConcessio)
        Me.TabPage1.Controls.Add(Me.DiesAvisCaducat)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.MostrarGestioAprovades)
        Me.TabPage1.Controls.Add(Me.MesosAprovacio)
        Me.TabPage1.Controls.Add(Me.MostrarLlistatAprovades)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.MesosFactura)
        Me.TabPage1.Controls.Add(Me.MesosContractacio)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(417, 316)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TB_Pais)
        Me.TabPage2.Controls.Add(Me.TB_Provincia)
        Me.TabPage2.Controls.Add(Me.TB_ciutat)
        Me.TabPage2.Controls.Add(Me.TB_CodiPostal)
        Me.TabPage2.Controls.Add(Me.TB_Direccio)
        Me.TabPage2.Controls.Add(Me.TB_NomEmpresa)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(417, 316)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Empresa"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TB_Pais
        '
        Me.TB_Pais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_Pais.Location = New System.Drawing.Point(130, 253)
        Me.TB_Pais.Name = "TB_Pais"
        Me.TB_Pais.Size = New System.Drawing.Size(270, 23)
        Me.TB_Pais.TabIndex = 19
        '
        'TB_Provincia
        '
        Me.TB_Provincia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_Provincia.Location = New System.Drawing.Point(130, 205)
        Me.TB_Provincia.Name = "TB_Provincia"
        Me.TB_Provincia.Size = New System.Drawing.Size(270, 23)
        Me.TB_Provincia.TabIndex = 17
        '
        'TB_ciutat
        '
        Me.TB_ciutat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_ciutat.Location = New System.Drawing.Point(130, 157)
        Me.TB_ciutat.Name = "TB_ciutat"
        Me.TB_ciutat.Size = New System.Drawing.Size(270, 23)
        Me.TB_ciutat.TabIndex = 15
        '
        'TB_CodiPostal
        '
        Me.TB_CodiPostal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_CodiPostal.Location = New System.Drawing.Point(130, 109)
        Me.TB_CodiPostal.Name = "TB_CodiPostal"
        Me.TB_CodiPostal.Size = New System.Drawing.Size(131, 23)
        Me.TB_CodiPostal.TabIndex = 13
        '
        'TB_Direccio
        '
        Me.TB_Direccio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_Direccio.Location = New System.Drawing.Point(130, 61)
        Me.TB_Direccio.Name = "TB_Direccio"
        Me.TB_Direccio.Size = New System.Drawing.Size(270, 23)
        Me.TB_Direccio.TabIndex = 11
        '
        'TB_NomEmpresa
        '
        Me.TB_NomEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_NomEmpresa.Location = New System.Drawing.Point(130, 13)
        Me.TB_NomEmpresa.Name = "TB_NomEmpresa"
        Me.TB_NomEmpresa.Size = New System.Drawing.Size(270, 23)
        Me.TB_NomEmpresa.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 261)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 15)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Pais"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 15)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Provincia"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 165)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 15)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Ciutat"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 15)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Codi Postal"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 69)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 15)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Direcció"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 15)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Nom empresa"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.PictureBox2)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.PictureBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(417, 316)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "A sobre de"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(76, 257)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(267, 17)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Made by Antonio Rodríguez Sirgado ®2022"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FacturaXML.My.Resources.Resources.logo_telematic
        Me.PictureBox1.Location = New System.Drawing.Point(56, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 137)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.FacturaXML.My.Resources.Resources.Ayudas_Kit_Digital__Grande_
        Me.PictureBox2.Location = New System.Drawing.Point(56, 174)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(300, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'Preferencies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(466, 441)
        Me.Controls.Add(Me.Btn_Guardar)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Preferencies"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Preferències"
        CType(Me.DiesAvisCaducat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MesosAprovacio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MesosContractacio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MesosFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiesAvisConcessio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DiesAvisCaducat As NumericUpDown
    Friend WithEvents Btn_Guardar As Button
    Friend WithEvents MesosAprovacio As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents MesosContractacio As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents MesosFactura As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents MostrarLlistatAprovades As CheckBox
    Friend WithEvents MostrarGestioAprovades As CheckBox
    Friend WithEvents DiesAvisConcessio As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents CB_MostrarEmpresesContractes As CheckBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TB_Pais As TextBox
    Friend WithEvents TB_Provincia As TextBox
    Friend WithEvents TB_ciutat As TextBox
    Friend WithEvents TB_CodiPostal As TextBox
    Friend WithEvents TB_Direccio As TextBox
    Friend WithEvents TB_NomEmpresa As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
