
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Factures
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Factures))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CB_Empreses = New System.Windows.Forms.ComboBox()
        Me.EmpresaNom = New System.Windows.Forms.TextBox()
        Me.EmpresaNif = New System.Windows.Forms.TextBox()
        Me.EmpresaDireccio = New System.Windows.Forms.TextBox()
        Me.EmpresaCodiPostal = New System.Windows.Forms.TextBox()
        Me.EmpresaCiutat = New System.Windows.Forms.TextBox()
        Me.EmpresaProvincia = New System.Windows.Forms.TextBox()
        Me.EmpresaPais = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.FacturaNumero = New System.Windows.Forms.TextBox()
        Me.CB_Solucions = New System.Windows.Forms.ComboBox()
        Me.FacturaAcord = New System.Windows.Forms.TextBox()
        Me.FacturaImportSolucio = New System.Windows.Forms.TextBox()
        Me.FacturaImportIVA = New System.Windows.Forms.TextBox()
        Me.FacturaImportTotal = New System.Windows.Forms.TextBox()
        Me.FacturaImportSubvencionat = New System.Windows.Forms.TextBox()
        Me.FacturaSolucio = New System.Windows.Forms.ComboBox()
        Me.FacturaData = New System.Windows.Forms.DateTimePicker()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btn_Visualitzar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MenuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.MenuArxiu = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuDadesEmpresa = New System.Windows.Forms.ToolStripMenuItem()
        Me.XToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.GuardarFacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSortir = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuEditar = New System.Windows.Forms.ToolStripMenuItem()
        Me.EsborrarDadesFacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EsborrarDadesEmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuEsborrarTot = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreFacturesXMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreFacturesXMLToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Vigila = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(27, -134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tipus solució"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(27, -89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nº Acord"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(26, 255)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Import TOTAL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(27, -44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Cost solució"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(26, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "21% IVA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(26, 301)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 15)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Import subvencionat"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(26, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 15)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Nº Factura"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CB_Empreses)
        Me.GroupBox1.Controls.Add(Me.EmpresaNom)
        Me.GroupBox1.Controls.Add(Me.EmpresaNif)
        Me.GroupBox1.Controls.Add(Me.EmpresaDireccio)
        Me.GroupBox1.Controls.Add(Me.EmpresaCodiPostal)
        Me.GroupBox1.Controls.Add(Me.EmpresaCiutat)
        Me.GroupBox1.Controls.Add(Me.EmpresaProvincia)
        Me.GroupBox1.Controls.Add(Me.EmpresaPais)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 129)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(388, 368)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dades Empresa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Seleccionar"
        '
        'CB_Empreses
        '
        Me.CB_Empreses.FormattingEnabled = True
        Me.CB_Empreses.Location = New System.Drawing.Point(113, 28)
        Me.CB_Empreses.Name = "CB_Empreses"
        Me.CB_Empreses.Size = New System.Drawing.Size(242, 23)
        Me.CB_Empreses.TabIndex = 16
        '
        'EmpresaNom
        '
        Me.EmpresaNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EmpresaNom.Location = New System.Drawing.Point(113, 68)
        Me.EmpresaNom.Name = "EmpresaNom"
        Me.EmpresaNom.Size = New System.Drawing.Size(242, 23)
        Me.EmpresaNom.TabIndex = 9
        '
        'EmpresaNif
        '
        Me.EmpresaNif.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EmpresaNif.Location = New System.Drawing.Point(113, 108)
        Me.EmpresaNif.MaxLength = 9
        Me.EmpresaNif.Name = "EmpresaNif"
        Me.EmpresaNif.Size = New System.Drawing.Size(100, 23)
        Me.EmpresaNif.TabIndex = 10
        '
        'EmpresaDireccio
        '
        Me.EmpresaDireccio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EmpresaDireccio.Location = New System.Drawing.Point(113, 148)
        Me.EmpresaDireccio.Name = "EmpresaDireccio"
        Me.EmpresaDireccio.Size = New System.Drawing.Size(242, 23)
        Me.EmpresaDireccio.TabIndex = 11
        '
        'EmpresaCodiPostal
        '
        Me.EmpresaCodiPostal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EmpresaCodiPostal.Location = New System.Drawing.Point(113, 188)
        Me.EmpresaCodiPostal.MaxLength = 5
        Me.EmpresaCodiPostal.Name = "EmpresaCodiPostal"
        Me.EmpresaCodiPostal.Size = New System.Drawing.Size(100, 23)
        Me.EmpresaCodiPostal.TabIndex = 12
        '
        'EmpresaCiutat
        '
        Me.EmpresaCiutat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EmpresaCiutat.Location = New System.Drawing.Point(113, 228)
        Me.EmpresaCiutat.Name = "EmpresaCiutat"
        Me.EmpresaCiutat.Size = New System.Drawing.Size(242, 23)
        Me.EmpresaCiutat.TabIndex = 13
        '
        'EmpresaProvincia
        '
        Me.EmpresaProvincia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EmpresaProvincia.Location = New System.Drawing.Point(113, 268)
        Me.EmpresaProvincia.Name = "EmpresaProvincia"
        Me.EmpresaProvincia.Size = New System.Drawing.Size(242, 23)
        Me.EmpresaProvincia.TabIndex = 14
        '
        'EmpresaPais
        '
        Me.EmpresaPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EmpresaPais.Enabled = False
        Me.EmpresaPais.Location = New System.Drawing.Point(113, 308)
        Me.EmpresaPais.Name = "EmpresaPais"
        Me.EmpresaPais.Size = New System.Drawing.Size(242, 23)
        Me.EmpresaPais.TabIndex = 15
        Me.EmpresaPais.Text = "ESPAÑA"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(26, 116)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(25, 15)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "NIF"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(26, 316)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 15)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Pais"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(26, 276)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 15)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Provincia"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(26, 236)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 15)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Ciutat"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(26, 196)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 15)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Codi postal"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 156)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 15)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Direcció"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 15)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Nom"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.FacturaNumero)
        Me.GroupBox2.Controls.Add(Me.CB_Solucions)
        Me.GroupBox2.Controls.Add(Me.FacturaAcord)
        Me.GroupBox2.Controls.Add(Me.FacturaImportSolucio)
        Me.GroupBox2.Controls.Add(Me.FacturaImportIVA)
        Me.GroupBox2.Controls.Add(Me.FacturaImportTotal)
        Me.GroupBox2.Controls.Add(Me.FacturaImportSubvencionat)
        Me.GroupBox2.Controls.Add(Me.FacturaSolucio)
        Me.GroupBox2.Controls.Add(Me.FacturaData)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(456, 129)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(388, 440)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dades factura"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(26, 41)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(67, 15)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "Seleccionar"
        '
        'FacturaNumero
        '
        Me.FacturaNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FacturaNumero.Location = New System.Drawing.Point(275, 75)
        Me.FacturaNumero.Name = "FacturaNumero"
        Me.FacturaNumero.Size = New System.Drawing.Size(92, 23)
        Me.FacturaNumero.TabIndex = 1
        Me.FacturaNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CB_Solucions
        '
        Me.CB_Solucions.FormattingEnabled = True
        Me.CB_Solucions.Location = New System.Drawing.Point(125, 33)
        Me.CB_Solucions.Name = "CB_Solucions"
        Me.CB_Solucions.Size = New System.Drawing.Size(242, 23)
        Me.CB_Solucions.TabIndex = 18
        '
        'FacturaAcord
        '
        Me.FacturaAcord.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FacturaAcord.Location = New System.Drawing.Point(275, 114)
        Me.FacturaAcord.Name = "FacturaAcord"
        Me.FacturaAcord.Size = New System.Drawing.Size(92, 23)
        Me.FacturaAcord.TabIndex = 2
        Me.FacturaAcord.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FacturaImportSolucio
        '
        Me.FacturaImportSolucio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FacturaImportSolucio.Location = New System.Drawing.Point(216, 155)
        Me.FacturaImportSolucio.Name = "FacturaImportSolucio"
        Me.FacturaImportSolucio.Size = New System.Drawing.Size(151, 23)
        Me.FacturaImportSolucio.TabIndex = 3
        Me.FacturaImportSolucio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FacturaImportIVA
        '
        Me.FacturaImportIVA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FacturaImportIVA.Enabled = False
        Me.FacturaImportIVA.Location = New System.Drawing.Point(216, 201)
        Me.FacturaImportIVA.Name = "FacturaImportIVA"
        Me.FacturaImportIVA.Size = New System.Drawing.Size(151, 23)
        Me.FacturaImportIVA.TabIndex = 4
        Me.FacturaImportIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FacturaImportTotal
        '
        Me.FacturaImportTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FacturaImportTotal.Enabled = False
        Me.FacturaImportTotal.Location = New System.Drawing.Point(216, 247)
        Me.FacturaImportTotal.Name = "FacturaImportTotal"
        Me.FacturaImportTotal.Size = New System.Drawing.Size(151, 23)
        Me.FacturaImportTotal.TabIndex = 5
        Me.FacturaImportTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FacturaImportSubvencionat
        '
        Me.FacturaImportSubvencionat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FacturaImportSubvencionat.Location = New System.Drawing.Point(236, 293)
        Me.FacturaImportSubvencionat.Name = "FacturaImportSubvencionat"
        Me.FacturaImportSubvencionat.Size = New System.Drawing.Size(131, 23)
        Me.FacturaImportSubvencionat.TabIndex = 6
        Me.FacturaImportSubvencionat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FacturaSolucio
        '
        Me.FacturaSolucio.FormattingEnabled = True
        Me.FacturaSolucio.Items.AddRange(New Object() {"Sitio web", "Comercio electrónico", "Gestión de redes sociales", "Gestión de clientes", "BI", "Gestión de procesos", "Factura electrónica", "Oficina virtual", "Comunicaciones seguras", "Ciberseguridad"})
        Me.FacturaSolucio.Location = New System.Drawing.Point(196, 339)
        Me.FacturaSolucio.Name = "FacturaSolucio"
        Me.FacturaSolucio.Size = New System.Drawing.Size(171, 23)
        Me.FacturaSolucio.TabIndex = 7
        '
        'FacturaData
        '
        Me.FacturaData.Location = New System.Drawing.Point(136, 385)
        Me.FacturaData.Name = "FacturaData"
        Me.FacturaData.Size = New System.Drawing.Size(231, 23)
        Me.FacturaData.TabIndex = 8
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label19.Location = New System.Drawing.Point(26, 122)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(56, 15)
        Me.Label19.TabIndex = 13
        Me.Label19.Text = "Nº Acord"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label18.Location = New System.Drawing.Point(26, 393)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 15)
        Me.Label18.TabIndex = 11
        Me.Label18.Text = "Data factura"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label16.Location = New System.Drawing.Point(26, 163)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 15)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "Import solució"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label17.Location = New System.Drawing.Point(26, 347)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(126, 15)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "Solució implementada"
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.Location = New System.Drawing.Point(25, 533)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(182, 36)
        Me.Btn_Guardar.TabIndex = 15
        Me.Btn_Guardar.Text = "Guardar arxiu  Factura XML"
        Me.Btn_Guardar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FacturaXML.My.Resources.Resources.logo_telematic
        Me.PictureBox1.Location = New System.Drawing.Point(25, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(388, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Btn_Visualitzar
        '
        Me.Btn_Visualitzar.Location = New System.Drawing.Point(235, 533)
        Me.Btn_Visualitzar.Name = "Btn_Visualitzar"
        Me.Btn_Visualitzar.Size = New System.Drawing.Size(178, 36)
        Me.Btn_Visualitzar.TabIndex = 16
        Me.Btn_Visualitzar.Text = "Visualitzar Factura XML"
        Me.Btn_Visualitzar.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.FacturaXML.My.Resources.Resources.Ayudas_Kit_Digital__Grande_
        Me.PictureBox2.Location = New System.Drawing.Point(461, 37)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(383, 64)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'MenuPrincipal
        '
        Me.MenuPrincipal.BackColor = System.Drawing.SystemColors.Control
        Me.MenuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuArxiu, Me.MenuEditar, Me.SobreFacturesXMLToolStripMenuItem})
        Me.MenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.MenuPrincipal.Name = "MenuPrincipal"
        Me.MenuPrincipal.Size = New System.Drawing.Size(871, 24)
        Me.MenuPrincipal.TabIndex = 19
        Me.MenuPrincipal.Text = "MenuStrip1"
        '
        'MenuArxiu
        '
        Me.MenuArxiu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuDadesEmpresa, Me.XToolStripMenuItem, Me.GuardarFacturaToolStripMenuItem, Me.MenuSortir})
        Me.MenuArxiu.Name = "MenuArxiu"
        Me.MenuArxiu.Size = New System.Drawing.Size(47, 20)
        Me.MenuArxiu.Text = "Arxiu"
        '
        'MenuDadesEmpresa
        '
        Me.MenuDadesEmpresa.Image = Global.FacturaXML.My.Resources.Resources.icono_ajustes
        Me.MenuDadesEmpresa.Name = "MenuDadesEmpresa"
        Me.MenuDadesEmpresa.Size = New System.Drawing.Size(158, 22)
        Me.MenuDadesEmpresa.Text = "Dades empresa"
        '
        'XToolStripMenuItem
        '
        Me.XToolStripMenuItem.Name = "XToolStripMenuItem"
        Me.XToolStripMenuItem.Size = New System.Drawing.Size(155, 6)
        '
        'GuardarFacturaToolStripMenuItem
        '
        Me.GuardarFacturaToolStripMenuItem.Image = Global.FacturaXML.My.Resources.Resources.icono_guardar
        Me.GuardarFacturaToolStripMenuItem.Name = "GuardarFacturaToolStripMenuItem"
        Me.GuardarFacturaToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.GuardarFacturaToolStripMenuItem.Text = "Guardar Factura"
        '
        'MenuSortir
        '
        Me.MenuSortir.Image = Global.FacturaXML.My.Resources.Resources.icono_salir
        Me.MenuSortir.Name = "MenuSortir"
        Me.MenuSortir.Size = New System.Drawing.Size(158, 22)
        Me.MenuSortir.Text = "Sortir"
        '
        'MenuEditar
        '
        Me.MenuEditar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EsborrarDadesFacturaToolStripMenuItem, Me.EsborrarDadesEmpresaToolStripMenuItem, Me.MenuEsborrarTot})
        Me.MenuEditar.Name = "MenuEditar"
        Me.MenuEditar.Size = New System.Drawing.Size(49, 20)
        Me.MenuEditar.Text = "Editar"
        '
        'EsborrarDadesFacturaToolStripMenuItem
        '
        Me.EsborrarDadesFacturaToolStripMenuItem.Image = Global.FacturaXML.My.Resources.Resources.icono_borrar
        Me.EsborrarDadesFacturaToolStripMenuItem.Name = "EsborrarDadesFacturaToolStripMenuItem"
        Me.EsborrarDadesFacturaToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.EsborrarDadesFacturaToolStripMenuItem.Text = "Esborrar dades factura"
        '
        'EsborrarDadesEmpresaToolStripMenuItem
        '
        Me.EsborrarDadesEmpresaToolStripMenuItem.Image = Global.FacturaXML.My.Resources.Resources.icono_borrar
        Me.EsborrarDadesEmpresaToolStripMenuItem.Name = "EsborrarDadesEmpresaToolStripMenuItem"
        Me.EsborrarDadesEmpresaToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.EsborrarDadesEmpresaToolStripMenuItem.Text = "Esborrar dades empresa"
        '
        'MenuEsborrarTot
        '
        Me.MenuEsborrarTot.Image = Global.FacturaXML.My.Resources.Resources.icono_borrar
        Me.MenuEsborrarTot.Name = "MenuEsborrarTot"
        Me.MenuEsborrarTot.Size = New System.Drawing.Size(199, 22)
        Me.MenuEsborrarTot.Text = "Esborrar tot"
        '
        'SobreFacturesXMLToolStripMenuItem
        '
        Me.SobreFacturesXMLToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SobreFacturesXMLToolStripMenuItem1})
        Me.SobreFacturesXMLToolStripMenuItem.Name = "SobreFacturesXMLToolStripMenuItem"
        Me.SobreFacturesXMLToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.SobreFacturesXMLToolStripMenuItem.Text = "Ajuda"
        '
        'SobreFacturesXMLToolStripMenuItem1
        '
        Me.SobreFacturesXMLToolStripMenuItem1.Image = Global.FacturaXML.My.Resources.Resources.icono_ayuda
        Me.SobreFacturesXMLToolStripMenuItem1.Name = "SobreFacturesXMLToolStripMenuItem1"
        Me.SobreFacturesXMLToolStripMenuItem1.Size = New System.Drawing.Size(175, 22)
        Me.SobreFacturesXMLToolStripMenuItem1.Text = "Sobre FacturesXML"
        '
        'Vigila
        '
        Me.Vigila.AutoSize = True
        Me.Vigila.ForeColor = System.Drawing.Color.Red
        Me.Vigila.Location = New System.Drawing.Point(138, 508)
        Me.Vigila.Name = "Vigila"
        Me.Vigila.Size = New System.Drawing.Size(175, 15)
        Me.Vigila.TabIndex = 20
        Me.Vigila.Text = "Vigila! Procés no acabat al 100%"
        Me.Vigila.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Vigila.Visible = False
        '
        'Factures
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(871, 582)
        Me.Controls.Add(Me.Vigila)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Btn_Visualitzar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Btn_Guardar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuPrincipal
        Me.MaximizeBox = False
        Me.Name = "Factures"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factures XML"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuPrincipal.ResumeLayout(False)
        Me.MenuPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents EmpresaPais As TextBox
    Friend WithEvents EmpresaProvincia As TextBox
    Friend WithEvents EmpresaCiutat As TextBox
    Friend WithEvents EmpresaCodiPostal As TextBox
    Friend WithEvents EmpresaDireccio As TextBox
    Friend WithEvents EmpresaNif As TextBox
    Friend WithEvents EmpresaNom As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents FacturaData As DateTimePicker
    Friend WithEvents FacturaSolucio As ComboBox
    Friend WithEvents FacturaImportSubvencionat As TextBox
    Friend WithEvents FacturaImportTotal As TextBox
    Friend WithEvents FacturaImportIVA As TextBox
    Friend WithEvents FacturaImportSolucio As TextBox
    Friend WithEvents FacturaNumero As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Btn_Guardar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btn_Visualitzar As Button
    Friend WithEvents FacturaAcord As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents MenuPrincipal As MenuStrip
    Friend WithEvents MenuArxiu As ToolStripMenuItem
    Friend WithEvents MenuDadesEmpresa As ToolStripMenuItem
    Friend WithEvents MenuSortir As ToolStripMenuItem
    Friend WithEvents XToolStripMenuItem As ToolStripSeparator
    Friend WithEvents GuardarFacturaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuEditar As ToolStripMenuItem
    Friend WithEvents MenuEsborrarTot As ToolStripMenuItem
    Friend WithEvents EsborrarDadesFacturaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EsborrarDadesEmpresaToolStripMenuItem As ToolStripMenuItem

    Dim textoXML As New System.Text.StringBuilder()

    Friend WithEvents SobreFacturesXMLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SobreFacturesXMLToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents CB_Empreses As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents CB_Solucions As ComboBox
    Friend WithEvents Vigila As Label
End Class