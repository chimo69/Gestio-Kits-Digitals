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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Preferencies))
        Label1 = New Label()
        DiesAvisCaducat = New NumericUpDown()
        Btn_Guardar = New Button()
        MesosAprovacio = New NumericUpDown()
        Label2 = New Label()
        MesosContractacio = New NumericUpDown()
        Label3 = New Label()
        MesosFactura = New NumericUpDown()
        Label4 = New Label()
        MostrarLlistatAprovades = New CheckBox()
        MostrarGestioAprovades = New CheckBox()
        DiesAvisConcessio = New NumericUpDown()
        Label5 = New Label()
        CB_MostrarEmpresesContractes = New CheckBox()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        TabPage2 = New TabPage()
        TB_Pais = New TextBox()
        TB_Provincia = New TextBox()
        TB_ciutat = New TextBox()
        TB_CodiPostal = New TextBox()
        TB_Direccio = New TextBox()
        TB_NomEmpresa = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        TabPage3 = New TabPage()
        PictureBox2 = New PictureBox()
        Label12 = New Label()
        PictureBox1 = New PictureBox()
        Label13 = New Label()
        MesosSuport = New NumericUpDown()
        CType(DiesAvisCaducat, ComponentModel.ISupportInitialize).BeginInit()
        CType(MesosAprovacio, ComponentModel.ISupportInitialize).BeginInit()
        CType(MesosContractacio, ComponentModel.ISupportInitialize).BeginInit()
        CType(MesosFactura, ComponentModel.ISupportInitialize).BeginInit()
        CType(DiesAvisConcessio, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(MesosSuport, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(15, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(293, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nº de dies per avisar per una solució apunt de caducar"
        ' 
        ' DiesAvisCaducat
        ' 
        DiesAvisCaducat.Location = New Point(323, 25)
        DiesAvisCaducat.Name = "DiesAvisCaducat"
        DiesAvisCaducat.Size = New Size(58, 23)
        DiesAvisCaducat.TabIndex = 1
        ' 
        ' Btn_Guardar
        ' 
        Btn_Guardar.Location = New Point(12, 375)
        Btn_Guardar.Name = "Btn_Guardar"
        Btn_Guardar.Size = New Size(421, 49)
        Btn_Guardar.TabIndex = 2
        Btn_Guardar.Text = "Guardar"
        Btn_Guardar.UseVisualStyleBackColor = True
        ' 
        ' MesosAprovacio
        ' 
        MesosAprovacio.Location = New Point(323, 83)
        MesosAprovacio.Name = "MesosAprovacio"
        MesosAprovacio.Size = New Size(58, 23)
        MesosAprovacio.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(15, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(191, 15)
        Label2.TabIndex = 3
        Label2.Text = "Nº de mesos a partir de l'aprovació"
        ' 
        ' MesosContractacio
        ' 
        MesosContractacio.Location = New Point(323, 112)
        MesosContractacio.Name = "MesosContractacio"
        MesosContractacio.Size = New Size(58, 23)
        MesosContractacio.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(15, 114)
        Label3.Name = "Label3"
        Label3.Size = New Size(211, 15)
        Label3.TabIndex = 5
        Label3.Text = "Nº de mesos a partir de la contractació"
        ' 
        ' MesosFactura
        ' 
        MesosFactura.Location = New Point(323, 141)
        MesosFactura.Name = "MesosFactura"
        MesosFactura.Size = New Size(58, 23)
        MesosFactura.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(15, 143)
        Label4.Name = "Label4"
        Label4.Size = New Size(250, 15)
        Label4.TabIndex = 7
        Label4.Text = "Nº de mesos a partir de la emisió de la Factura"
        ' 
        ' MostrarLlistatAprovades
        ' 
        MostrarLlistatAprovades.AutoSize = True
        MostrarLlistatAprovades.Location = New Point(15, 206)
        MostrarLlistatAprovades.Name = "MostrarLlistatAprovades"
        MostrarLlistatAprovades.Size = New Size(249, 19)
        MostrarLlistatAprovades.TabIndex = 9
        MostrarLlistatAprovades.Text = "Mostrar al llistat les solucions ja aprovades"
        MostrarLlistatAprovades.UseVisualStyleBackColor = True
        ' 
        ' MostrarGestioAprovades
        ' 
        MostrarGestioAprovades.AutoSize = True
        MostrarGestioAprovades.Location = New Point(15, 231)
        MostrarGestioAprovades.Name = "MostrarGestioAprovades"
        MostrarGestioAprovades.Size = New Size(262, 19)
        MostrarGestioAprovades.TabIndex = 10
        MostrarGestioAprovades.Text = "Mostrar a la gestió les solucions ja aprovades"
        MostrarGestioAprovades.UseVisualStyleBackColor = True
        ' 
        ' DiesAvisConcessio
        ' 
        DiesAvisConcessio.Location = New Point(323, 54)
        DiesAvisConcessio.Name = "DiesAvisConcessio"
        DiesAvisConcessio.Size = New Size(58, 23)
        DiesAvisConcessio.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(15, 56)
        Label5.Name = "Label5"
        Label5.Size = New Size(307, 15)
        Label5.TabIndex = 11
        Label5.Text = "Nº de dies per avisar per una concessió apunt de caducar"
        ' 
        ' CB_MostrarEmpresesContractes
        ' 
        CB_MostrarEmpresesContractes.AutoSize = True
        CB_MostrarEmpresesContractes.Location = New Point(15, 258)
        CB_MostrarEmpresesContractes.Name = "CB_MostrarEmpresesContractes"
        CB_MostrarEmpresesContractes.Size = New Size(205, 19)
        CB_MostrarEmpresesContractes.TabIndex = 13
        CB_MostrarEmpresesContractes.Text = "Mostrar empreses amb contractes"
        CB_MostrarEmpresesContractes.UseVisualStyleBackColor = True
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(12, 12)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(425, 344)
        TabControl1.TabIndex = 14
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(MesosSuport)
        TabPage1.Controls.Add(Label13)
        TabPage1.Controls.Add(CB_MostrarEmpresesContractes)
        TabPage1.Controls.Add(Label1)
        TabPage1.Controls.Add(DiesAvisConcessio)
        TabPage1.Controls.Add(DiesAvisCaducat)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(MostrarGestioAprovades)
        TabPage1.Controls.Add(MesosAprovacio)
        TabPage1.Controls.Add(MostrarLlistatAprovades)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(MesosFactura)
        TabPage1.Controls.Add(MesosContractacio)
        TabPage1.Controls.Add(Label4)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(417, 316)
        TabPage1.TabIndex = 0
        TabPage1.Text = "General"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(TB_Pais)
        TabPage2.Controls.Add(TB_Provincia)
        TabPage2.Controls.Add(TB_ciutat)
        TabPage2.Controls.Add(TB_CodiPostal)
        TabPage2.Controls.Add(TB_Direccio)
        TabPage2.Controls.Add(TB_NomEmpresa)
        TabPage2.Controls.Add(Label6)
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(Label8)
        TabPage2.Controls.Add(Label9)
        TabPage2.Controls.Add(Label10)
        TabPage2.Controls.Add(Label11)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(417, 316)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Empresa"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' TB_Pais
        ' 
        TB_Pais.CharacterCasing = CharacterCasing.Upper
        TB_Pais.Location = New Point(130, 253)
        TB_Pais.Name = "TB_Pais"
        TB_Pais.Size = New Size(270, 23)
        TB_Pais.TabIndex = 19
        ' 
        ' TB_Provincia
        ' 
        TB_Provincia.CharacterCasing = CharacterCasing.Upper
        TB_Provincia.Location = New Point(130, 205)
        TB_Provincia.Name = "TB_Provincia"
        TB_Provincia.Size = New Size(270, 23)
        TB_Provincia.TabIndex = 17
        ' 
        ' TB_ciutat
        ' 
        TB_ciutat.CharacterCasing = CharacterCasing.Upper
        TB_ciutat.Location = New Point(130, 157)
        TB_ciutat.Name = "TB_ciutat"
        TB_ciutat.Size = New Size(270, 23)
        TB_ciutat.TabIndex = 15
        ' 
        ' TB_CodiPostal
        ' 
        TB_CodiPostal.CharacterCasing = CharacterCasing.Upper
        TB_CodiPostal.Location = New Point(130, 109)
        TB_CodiPostal.Name = "TB_CodiPostal"
        TB_CodiPostal.Size = New Size(131, 23)
        TB_CodiPostal.TabIndex = 13
        ' 
        ' TB_Direccio
        ' 
        TB_Direccio.CharacterCasing = CharacterCasing.Upper
        TB_Direccio.Location = New Point(130, 61)
        TB_Direccio.Name = "TB_Direccio"
        TB_Direccio.Size = New Size(270, 23)
        TB_Direccio.TabIndex = 11
        ' 
        ' TB_NomEmpresa
        ' 
        TB_NomEmpresa.CharacterCasing = CharacterCasing.Upper
        TB_NomEmpresa.Location = New Point(130, 13)
        TB_NomEmpresa.Name = "TB_NomEmpresa"
        TB_NomEmpresa.Size = New Size(270, 23)
        TB_NomEmpresa.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(17, 261)
        Label6.Name = "Label6"
        Label6.Size = New Size(28, 15)
        Label6.TabIndex = 18
        Label6.Text = "Pais"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(17, 213)
        Label7.Name = "Label7"
        Label7.Size = New Size(56, 15)
        Label7.TabIndex = 16
        Label7.Text = "Provincia"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(17, 165)
        Label8.Name = "Label8"
        Label8.Size = New Size(39, 15)
        Label8.TabIndex = 14
        Label8.Text = "Ciutat"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(17, 117)
        Label9.Name = "Label9"
        Label9.Size = New Size(67, 15)
        Label9.TabIndex = 12
        Label9.Text = "Codi Postal"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(17, 69)
        Label10.Name = "Label10"
        Label10.Size = New Size(50, 15)
        Label10.TabIndex = 10
        Label10.Text = "Direcció"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(17, 21)
        Label11.Name = "Label11"
        Label11.Size = New Size(82, 15)
        Label11.TabIndex = 8
        Label11.Text = "Nom empresa"
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(PictureBox2)
        TabPage3.Controls.Add(Label12)
        TabPage3.Controls.Add(PictureBox1)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(417, 316)
        TabPage3.TabIndex = 2
        TabPage3.Text = "A sobre de"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.Ayudas_Kit_Digital__Grande_
        PictureBox2.Location = New Point(56, 174)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(300, 50)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(76, 257)
        Label12.Name = "Label12"
        Label12.Size = New Size(267, 17)
        Label12.TabIndex = 3
        Label12.Text = "Made by Antonio Rodríguez Sirgado ®2022"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logo_telematic
        PictureBox1.Location = New Point(56, 31)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(300, 137)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(15, 170)
        Label13.Name = "Label13"
        Label13.Size = New Size(127, 15)
        Label13.TabIndex = 14
        Label13.Text = "Nº de mesos de suport"
        ' 
        ' MesosSuport
        ' 
        MesosSuport.Location = New Point(323, 169)
        MesosSuport.Name = "MesosSuport"
        MesosSuport.Size = New Size(58, 23)
        MesosSuport.TabIndex = 15
        ' 
        ' Preferencies
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(466, 441)
        Controls.Add(Btn_Guardar)
        Controls.Add(TabControl1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Preferencies"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Preferències"
        CType(DiesAvisCaducat, ComponentModel.ISupportInitialize).EndInit()
        CType(MesosAprovacio, ComponentModel.ISupportInitialize).EndInit()
        CType(MesosContractacio, ComponentModel.ISupportInitialize).EndInit()
        CType(MesosFactura, ComponentModel.ISupportInitialize).EndInit()
        CType(DiesAvisConcessio, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(MesosSuport, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
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
    Friend WithEvents MesosSuport As NumericUpDown
    Friend WithEvents Label13 As Label
End Class
