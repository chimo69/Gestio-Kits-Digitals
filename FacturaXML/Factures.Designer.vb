
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
        Btn_Guardar = New Button()
        PictureBox1 = New PictureBox()
        Btn_Visualitzar = New Button()
        Vigila = New Label()
        PanelLogotips = New Panel()
        PictureBox2 = New PictureBox()
        PanelBotons = New Panel()
        Btn_EsborraDades = New Button()
        PanelDadesFactura = New Panel()
        GroupBox2 = New GroupBox()
        Label20 = New Label()
        FacturaNumero = New TextBox()
        CB_Solucions = New ComboBox()
        FacturaAcord = New TextBox()
        FacturaImportSolucio = New TextBox()
        FacturaImportIVA = New TextBox()
        FacturaImportTotal = New TextBox()
        FacturaImportSubvencionat = New TextBox()
        FacturaSolucio = New ComboBox()
        FacturaData = New DateTimePicker()
        Label19 = New Label()
        Label18 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        Label8 = New Label()
        Label3 = New Label()
        Label7 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        PanelDeclaracio = New Panel()
        GroupBox3 = New GroupBox()
        CopiarDataCobrament = New Button()
        CopiarImportAbonat = New Button()
        CopiarImportFactura = New Button()
        CopiarNoFactura = New Button()
        CopiarDataFactura = New Button()
        CopiarNoAcord = New Button()
        CopiarNif = New Button()
        CopiarRaoSocial = New Button()
        TB_DataFactura = New TextBox()
        TB_DataCobrament = New TextBox()
        TB_Nif = New TextBox()
        Label26 = New Label()
        TB_Rao = New TextBox()
        Label25 = New Label()
        Label21 = New Label()
        TB_NoFactura = New TextBox()
        TB_NoAcord = New TextBox()
        TB_ImportFactura = New TextBox()
        TB_ImportAbonat = New TextBox()
        Label22 = New Label()
        Label23 = New Label()
        Label24 = New Label()
        Label27 = New Label()
        Label28 = New Label()
        Label29 = New Label()
        Label31 = New Label()
        Label32 = New Label()
        PanelDadesEmpresa = New Panel()
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        CB_Empreses = New ComboBox()
        EmpresaNom = New TextBox()
        EmpresaNif = New TextBox()
        EmpresaDireccio = New TextBox()
        EmpresaCodiPostal = New TextBox()
        EmpresaCiutat = New TextBox()
        EmpresaProvincia = New TextBox()
        EmpresaPais = New TextBox()
        Label15 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Panel1 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PanelLogotips.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        PanelBotons.SuspendLayout()
        PanelDadesFactura.SuspendLayout()
        GroupBox2.SuspendLayout()
        PanelDeclaracio.SuspendLayout()
        GroupBox3.SuspendLayout()
        PanelDadesEmpresa.SuspendLayout()
        GroupBox1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Btn_Guardar
        ' 
        Btn_Guardar.Anchor = AnchorStyles.None
        Btn_Guardar.Location = New Point(630, 9)
        Btn_Guardar.Margin = New Padding(20)
        Btn_Guardar.Name = "Btn_Guardar"
        Btn_Guardar.Size = New Size(182, 32)
        Btn_Guardar.TabIndex = 15
        Btn_Guardar.Text = "Guardar arxiu  Factura XML"
        Btn_Guardar.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.Image = My.Resources.Resources.logo_telematic
        PictureBox1.Location = New Point(358, 6)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(225, 52)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' Btn_Visualitzar
        ' 
        Btn_Visualitzar.Anchor = AnchorStyles.None
        Btn_Visualitzar.Location = New Point(435, 9)
        Btn_Visualitzar.Margin = New Padding(20)
        Btn_Visualitzar.Name = "Btn_Visualitzar"
        Btn_Visualitzar.Size = New Size(178, 32)
        Btn_Visualitzar.TabIndex = 16
        Btn_Visualitzar.Text = "Visualitzar Factura XML"
        Btn_Visualitzar.UseVisualStyleBackColor = True
        ' 
        ' Vigila
        ' 
        Vigila.Anchor = AnchorStyles.None
        Vigila.AutoSize = True
        Vigila.ForeColor = Color.Red
        Vigila.Location = New Point(515, 48)
        Vigila.Name = "Vigila"
        Vigila.Size = New Size(175, 15)
        Vigila.TabIndex = 20
        Vigila.Text = "Vigila! Procés no acabat al 100%"
        Vigila.TextAlign = ContentAlignment.MiddleRight
        Vigila.Visible = False
        ' 
        ' PanelLogotips
        ' 
        PanelLogotips.BorderStyle = BorderStyle.FixedSingle
        PanelLogotips.Controls.Add(PictureBox2)
        PanelLogotips.Controls.Add(PictureBox1)
        PanelLogotips.Dock = DockStyle.Top
        PanelLogotips.Location = New Point(20, 20)
        PanelLogotips.Name = "PanelLogotips"
        PanelLogotips.Size = New Size(1104, 68)
        PanelLogotips.TabIndex = 22
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.None
        PictureBox2.Image = My.Resources.Resources.Ayudas_Kit_Digital__Grande_
        PictureBox2.Location = New Point(589, 16)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(226, 32)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 19
        PictureBox2.TabStop = False
        ' 
        ' PanelBotons
        ' 
        PanelBotons.BorderStyle = BorderStyle.FixedSingle
        PanelBotons.Controls.Add(Btn_EsborraDades)
        PanelBotons.Controls.Add(Btn_Guardar)
        PanelBotons.Controls.Add(Btn_Visualitzar)
        PanelBotons.Controls.Add(Vigila)
        PanelBotons.Dock = DockStyle.Bottom
        PanelBotons.Location = New Point(20, 576)
        PanelBotons.Name = "PanelBotons"
        PanelBotons.Size = New Size(1104, 72)
        PanelBotons.TabIndex = 24
        ' 
        ' Btn_EsborraDades
        ' 
        Btn_EsborraDades.Anchor = AnchorStyles.None
        Btn_EsborraDades.Location = New Point(245, 9)
        Btn_EsborraDades.Margin = New Padding(20)
        Btn_EsborraDades.Name = "Btn_EsborraDades"
        Btn_EsborraDades.Size = New Size(178, 32)
        Btn_EsborraDades.TabIndex = 21
        Btn_EsborraDades.Text = "Esborrar dades"
        Btn_EsborraDades.UseVisualStyleBackColor = True
        ' 
        ' PanelDadesFactura
        ' 
        PanelDadesFactura.Controls.Add(GroupBox2)
        PanelDadesFactura.Location = New Point(377, 6)
        PanelDadesFactura.Name = "PanelDadesFactura"
        PanelDadesFactura.Padding = New Padding(10)
        PanelDadesFactura.Size = New Size(380, 447)
        PanelDadesFactura.TabIndex = 27
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label20)
        GroupBox2.Controls.Add(FacturaNumero)
        GroupBox2.Controls.Add(CB_Solucions)
        GroupBox2.Controls.Add(FacturaAcord)
        GroupBox2.Controls.Add(FacturaImportSolucio)
        GroupBox2.Controls.Add(FacturaImportIVA)
        GroupBox2.Controls.Add(FacturaImportTotal)
        GroupBox2.Controls.Add(FacturaImportSubvencionat)
        GroupBox2.Controls.Add(FacturaSolucio)
        GroupBox2.Controls.Add(FacturaData)
        GroupBox2.Controls.Add(Label19)
        GroupBox2.Controls.Add(Label18)
        GroupBox2.Controls.Add(Label16)
        GroupBox2.Controls.Add(Label17)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Dock = DockStyle.Fill
        GroupBox2.Location = New Point(10, 10)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(360, 427)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Dades factura"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(8, 35)
        Label20.Name = "Label20"
        Label20.Size = New Size(67, 15)
        Label20.TabIndex = 19
        Label20.Text = "Seleccionar"
        ' 
        ' FacturaNumero
        ' 
        FacturaNumero.CharacterCasing = CharacterCasing.Upper
        FacturaNumero.Location = New Point(257, 69)
        FacturaNumero.Name = "FacturaNumero"
        FacturaNumero.Size = New Size(92, 23)
        FacturaNumero.TabIndex = 1
        FacturaNumero.TextAlign = HorizontalAlignment.Right
        ' 
        ' CB_Solucions
        ' 
        CB_Solucions.FormattingEnabled = True
        CB_Solucions.Location = New Point(107, 27)
        CB_Solucions.Name = "CB_Solucions"
        CB_Solucions.Size = New Size(242, 23)
        CB_Solucions.TabIndex = 18
        ' 
        ' FacturaAcord
        ' 
        FacturaAcord.CharacterCasing = CharacterCasing.Upper
        FacturaAcord.Location = New Point(257, 108)
        FacturaAcord.Name = "FacturaAcord"
        FacturaAcord.Size = New Size(92, 23)
        FacturaAcord.TabIndex = 2
        FacturaAcord.TextAlign = HorizontalAlignment.Right
        ' 
        ' FacturaImportSolucio
        ' 
        FacturaImportSolucio.CharacterCasing = CharacterCasing.Upper
        FacturaImportSolucio.Location = New Point(198, 149)
        FacturaImportSolucio.Name = "FacturaImportSolucio"
        FacturaImportSolucio.Size = New Size(151, 23)
        FacturaImportSolucio.TabIndex = 3
        FacturaImportSolucio.TextAlign = HorizontalAlignment.Right
        ' 
        ' FacturaImportIVA
        ' 
        FacturaImportIVA.CharacterCasing = CharacterCasing.Upper
        FacturaImportIVA.Enabled = False
        FacturaImportIVA.Location = New Point(198, 195)
        FacturaImportIVA.Name = "FacturaImportIVA"
        FacturaImportIVA.Size = New Size(151, 23)
        FacturaImportIVA.TabIndex = 4
        FacturaImportIVA.TextAlign = HorizontalAlignment.Right
        ' 
        ' FacturaImportTotal
        ' 
        FacturaImportTotal.CharacterCasing = CharacterCasing.Upper
        FacturaImportTotal.Enabled = False
        FacturaImportTotal.Location = New Point(198, 241)
        FacturaImportTotal.Name = "FacturaImportTotal"
        FacturaImportTotal.Size = New Size(151, 23)
        FacturaImportTotal.TabIndex = 5
        FacturaImportTotal.TextAlign = HorizontalAlignment.Right
        ' 
        ' FacturaImportSubvencionat
        ' 
        FacturaImportSubvencionat.CharacterCasing = CharacterCasing.Upper
        FacturaImportSubvencionat.Location = New Point(218, 287)
        FacturaImportSubvencionat.Name = "FacturaImportSubvencionat"
        FacturaImportSubvencionat.Size = New Size(131, 23)
        FacturaImportSubvencionat.TabIndex = 6
        FacturaImportSubvencionat.TextAlign = HorizontalAlignment.Right
        ' 
        ' FacturaSolucio
        ' 
        FacturaSolucio.FormattingEnabled = True
        FacturaSolucio.Items.AddRange(New Object() {"Sitio web", "Comercio electrónico", "Gestión de redes sociales", "Gestión de clientes", "Business Inteligence", "Gestión de procesos", "Factura electrónica", "Oficina virtual", "Comunicaciones seguras", "Ciberseguridad"})
        FacturaSolucio.Location = New Point(178, 333)
        FacturaSolucio.Name = "FacturaSolucio"
        FacturaSolucio.Size = New Size(171, 23)
        FacturaSolucio.TabIndex = 7
        ' 
        ' FacturaData
        ' 
        FacturaData.Location = New Point(118, 379)
        FacturaData.Name = "FacturaData"
        FacturaData.Size = New Size(231, 23)
        FacturaData.TabIndex = 8
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label19.Location = New Point(8, 116)
        Label19.Name = "Label19"
        Label19.Size = New Size(56, 15)
        Label19.TabIndex = 13
        Label19.Text = "Nº Acord"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label18.Location = New Point(8, 387)
        Label18.Name = "Label18"
        Label18.Size = New Size(71, 15)
        Label18.TabIndex = 11
        Label18.Text = "Data factura"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label16.Location = New Point(8, 157)
        Label16.Name = "Label16"
        Label16.Size = New Size(84, 15)
        Label16.TabIndex = 9
        Label16.Text = "Import solució"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label17.Location = New Point(8, 341)
        Label17.Name = "Label17"
        Label17.Size = New Size(126, 15)
        Label17.TabIndex = 10
        Label17.Text = "Solució implementada"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(8, 249)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 15)
        Label4.TabIndex = 4
        Label4.Text = "Import TOTAL"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(27, -134)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 15)
        Label2.TabIndex = 2
        Label2.Text = "Tipus solució"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(8, 77)
        Label8.Name = "Label8"
        Label8.Size = New Size(63, 15)
        Label8.TabIndex = 8
        Label8.Text = "Nº Factura"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(27, -89)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 15)
        Label3.TabIndex = 3
        Label3.Text = "Nº Acord"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(8, 295)
        Label7.Name = "Label7"
        Label7.Size = New Size(117, 15)
        Label7.TabIndex = 7
        Label7.Text = "Import subvencionat"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(27, -44)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 15)
        Label5.TabIndex = 5
        Label5.Text = "Cost solució"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(8, 203)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 15)
        Label6.TabIndex = 6
        Label6.Text = "21% IVA"
        ' 
        ' PanelDeclaracio
        ' 
        PanelDeclaracio.Controls.Add(GroupBox3)
        PanelDeclaracio.Location = New Point(763, 6)
        PanelDeclaracio.Name = "PanelDeclaracio"
        PanelDeclaracio.Padding = New Padding(10)
        PanelDeclaracio.Size = New Size(340, 447)
        PanelDeclaracio.TabIndex = 26
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(CopiarDataCobrament)
        GroupBox3.Controls.Add(CopiarImportAbonat)
        GroupBox3.Controls.Add(CopiarImportFactura)
        GroupBox3.Controls.Add(CopiarNoFactura)
        GroupBox3.Controls.Add(CopiarDataFactura)
        GroupBox3.Controls.Add(CopiarNoAcord)
        GroupBox3.Controls.Add(CopiarNif)
        GroupBox3.Controls.Add(CopiarRaoSocial)
        GroupBox3.Controls.Add(TB_DataFactura)
        GroupBox3.Controls.Add(TB_DataCobrament)
        GroupBox3.Controls.Add(TB_Nif)
        GroupBox3.Controls.Add(Label26)
        GroupBox3.Controls.Add(TB_Rao)
        GroupBox3.Controls.Add(Label25)
        GroupBox3.Controls.Add(Label21)
        GroupBox3.Controls.Add(TB_NoFactura)
        GroupBox3.Controls.Add(TB_NoAcord)
        GroupBox3.Controls.Add(TB_ImportFactura)
        GroupBox3.Controls.Add(TB_ImportAbonat)
        GroupBox3.Controls.Add(Label22)
        GroupBox3.Controls.Add(Label23)
        GroupBox3.Controls.Add(Label24)
        GroupBox3.Controls.Add(Label27)
        GroupBox3.Controls.Add(Label28)
        GroupBox3.Controls.Add(Label29)
        GroupBox3.Controls.Add(Label31)
        GroupBox3.Controls.Add(Label32)
        GroupBox3.Dock = DockStyle.Fill
        GroupBox3.Location = New Point(10, 10)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(320, 427)
        GroupBox3.TabIndex = 21
        GroupBox3.TabStop = False
        GroupBox3.Text = "Declaració responsable de pagament"
        ' 
        ' CopiarDataCobrament
        ' 
        CopiarDataCobrament.BackgroundImage = My.Resources.Resources.icono_copiar
        CopiarDataCobrament.BackgroundImageLayout = ImageLayout.Zoom
        CopiarDataCobrament.FlatAppearance.BorderSize = 0
        CopiarDataCobrament.FlatStyle = FlatStyle.Flat
        CopiarDataCobrament.Location = New Point(287, 374)
        CopiarDataCobrament.Name = "CopiarDataCobrament"
        CopiarDataCobrament.Size = New Size(23, 23)
        CopiarDataCobrament.TabIndex = 39
        CopiarDataCobrament.UseVisualStyleBackColor = True
        ' 
        ' CopiarImportAbonat
        ' 
        CopiarImportAbonat.BackgroundImage = My.Resources.Resources.icono_copiar
        CopiarImportAbonat.BackgroundImageLayout = ImageLayout.Zoom
        CopiarImportAbonat.FlatAppearance.BorderSize = 0
        CopiarImportAbonat.FlatStyle = FlatStyle.Flat
        CopiarImportAbonat.Location = New Point(287, 326)
        CopiarImportAbonat.Name = "CopiarImportAbonat"
        CopiarImportAbonat.Size = New Size(23, 23)
        CopiarImportAbonat.TabIndex = 38
        CopiarImportAbonat.UseVisualStyleBackColor = True
        ' 
        ' CopiarImportFactura
        ' 
        CopiarImportFactura.BackgroundImage = My.Resources.Resources.icono_copiar
        CopiarImportFactura.BackgroundImageLayout = ImageLayout.Zoom
        CopiarImportFactura.FlatAppearance.BorderSize = 0
        CopiarImportFactura.FlatStyle = FlatStyle.Flat
        CopiarImportFactura.Location = New Point(287, 278)
        CopiarImportFactura.Name = "CopiarImportFactura"
        CopiarImportFactura.Size = New Size(23, 23)
        CopiarImportFactura.TabIndex = 37
        CopiarImportFactura.UseVisualStyleBackColor = True
        ' 
        ' CopiarNoFactura
        ' 
        CopiarNoFactura.BackgroundImage = My.Resources.Resources.icono_copiar
        CopiarNoFactura.BackgroundImageLayout = ImageLayout.Zoom
        CopiarNoFactura.FlatAppearance.BorderSize = 0
        CopiarNoFactura.FlatStyle = FlatStyle.Flat
        CopiarNoFactura.Location = New Point(287, 230)
        CopiarNoFactura.Name = "CopiarNoFactura"
        CopiarNoFactura.Size = New Size(23, 23)
        CopiarNoFactura.TabIndex = 36
        CopiarNoFactura.UseVisualStyleBackColor = True
        ' 
        ' CopiarDataFactura
        ' 
        CopiarDataFactura.BackgroundImage = My.Resources.Resources.icono_copiar
        CopiarDataFactura.BackgroundImageLayout = ImageLayout.Zoom
        CopiarDataFactura.FlatAppearance.BorderSize = 0
        CopiarDataFactura.FlatStyle = FlatStyle.Flat
        CopiarDataFactura.Location = New Point(287, 182)
        CopiarDataFactura.Name = "CopiarDataFactura"
        CopiarDataFactura.Size = New Size(23, 23)
        CopiarDataFactura.TabIndex = 35
        CopiarDataFactura.UseVisualStyleBackColor = True
        ' 
        ' CopiarNoAcord
        ' 
        CopiarNoAcord.BackgroundImage = My.Resources.Resources.icono_copiar
        CopiarNoAcord.BackgroundImageLayout = ImageLayout.Zoom
        CopiarNoAcord.FlatAppearance.BorderSize = 0
        CopiarNoAcord.FlatStyle = FlatStyle.Flat
        CopiarNoAcord.Location = New Point(287, 134)
        CopiarNoAcord.Name = "CopiarNoAcord"
        CopiarNoAcord.Size = New Size(23, 23)
        CopiarNoAcord.TabIndex = 34
        CopiarNoAcord.UseVisualStyleBackColor = True
        ' 
        ' CopiarNif
        ' 
        CopiarNif.BackgroundImage = My.Resources.Resources.icono_copiar
        CopiarNif.BackgroundImageLayout = ImageLayout.Zoom
        CopiarNif.FlatAppearance.BorderSize = 0
        CopiarNif.FlatStyle = FlatStyle.Flat
        CopiarNif.Location = New Point(287, 85)
        CopiarNif.Name = "CopiarNif"
        CopiarNif.Size = New Size(23, 23)
        CopiarNif.TabIndex = 33
        CopiarNif.UseVisualStyleBackColor = True
        ' 
        ' CopiarRaoSocial
        ' 
        CopiarRaoSocial.BackgroundImage = My.Resources.Resources.icono_copiar
        CopiarRaoSocial.BackgroundImageLayout = ImageLayout.Zoom
        CopiarRaoSocial.FlatAppearance.BorderSize = 0
        CopiarRaoSocial.FlatStyle = FlatStyle.Flat
        CopiarRaoSocial.Location = New Point(287, 38)
        CopiarRaoSocial.Name = "CopiarRaoSocial"
        CopiarRaoSocial.Size = New Size(23, 23)
        CopiarRaoSocial.TabIndex = 32
        CopiarRaoSocial.UseVisualStyleBackColor = True
        ' 
        ' TB_DataFactura
        ' 
        TB_DataFactura.CharacterCasing = CharacterCasing.Upper
        TB_DataFactura.Enabled = False
        TB_DataFactura.Location = New Point(130, 182)
        TB_DataFactura.Name = "TB_DataFactura"
        TB_DataFactura.ReadOnly = True
        TB_DataFactura.Size = New Size(151, 23)
        TB_DataFactura.TabIndex = 22
        TB_DataFactura.TextAlign = HorizontalAlignment.Right
        ' 
        ' TB_DataCobrament
        ' 
        TB_DataCobrament.CharacterCasing = CharacterCasing.Upper
        TB_DataCobrament.Enabled = False
        TB_DataCobrament.Location = New Point(130, 374)
        TB_DataCobrament.Name = "TB_DataCobrament"
        TB_DataCobrament.ReadOnly = True
        TB_DataCobrament.Size = New Size(151, 23)
        TB_DataCobrament.TabIndex = 21
        TB_DataCobrament.TextAlign = HorizontalAlignment.Right
        ' 
        ' TB_Nif
        ' 
        TB_Nif.CharacterCasing = CharacterCasing.Upper
        TB_Nif.Enabled = False
        TB_Nif.Location = New Point(189, 86)
        TB_Nif.Name = "TB_Nif"
        TB_Nif.ReadOnly = True
        TB_Nif.Size = New Size(92, 23)
        TB_Nif.TabIndex = 20
        TB_Nif.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label26.Location = New Point(30, 90)
        Label26.Name = "Label26"
        Label26.Size = New Size(83, 15)
        Label26.TabIndex = 19
        Label26.Text = "NIF Beneficiari"
        ' 
        ' TB_Rao
        ' 
        TB_Rao.CharacterCasing = CharacterCasing.Upper
        TB_Rao.Enabled = False
        TB_Rao.Location = New Point(154, 38)
        TB_Rao.Name = "TB_Rao"
        TB_Rao.ReadOnly = True
        TB_Rao.Size = New Size(127, 23)
        TB_Rao.TabIndex = 16
        TB_Rao.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label25.Location = New Point(30, 41)
        Label25.Name = "Label25"
        Label25.Size = New Size(118, 15)
        Label25.TabIndex = 17
        Label25.Text = "Raó social Beneficiari"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label21.Location = New Point(30, 384)
        Label21.Name = "Label21"
        Label21.Size = New Size(92, 15)
        Label21.TabIndex = 15
        Label21.Text = "Data cobrament"
        ' 
        ' TB_NoFactura
        ' 
        TB_NoFactura.CharacterCasing = CharacterCasing.Upper
        TB_NoFactura.Enabled = False
        TB_NoFactura.Location = New Point(189, 230)
        TB_NoFactura.Name = "TB_NoFactura"
        TB_NoFactura.ReadOnly = True
        TB_NoFactura.Size = New Size(92, 23)
        TB_NoFactura.TabIndex = 1
        TB_NoFactura.TextAlign = HorizontalAlignment.Right
        ' 
        ' TB_NoAcord
        ' 
        TB_NoAcord.CharacterCasing = CharacterCasing.Upper
        TB_NoAcord.Enabled = False
        TB_NoAcord.Location = New Point(189, 134)
        TB_NoAcord.Name = "TB_NoAcord"
        TB_NoAcord.ReadOnly = True
        TB_NoAcord.Size = New Size(92, 23)
        TB_NoAcord.TabIndex = 2
        TB_NoAcord.TextAlign = HorizontalAlignment.Right
        ' 
        ' TB_ImportFactura
        ' 
        TB_ImportFactura.CharacterCasing = CharacterCasing.Upper
        TB_ImportFactura.Enabled = False
        TB_ImportFactura.Location = New Point(130, 278)
        TB_ImportFactura.Name = "TB_ImportFactura"
        TB_ImportFactura.ReadOnly = True
        TB_ImportFactura.Size = New Size(151, 23)
        TB_ImportFactura.TabIndex = 3
        TB_ImportFactura.TextAlign = HorizontalAlignment.Right
        ' 
        ' TB_ImportAbonat
        ' 
        TB_ImportAbonat.CharacterCasing = CharacterCasing.Upper
        TB_ImportAbonat.Enabled = False
        TB_ImportAbonat.Location = New Point(130, 326)
        TB_ImportAbonat.Name = "TB_ImportAbonat"
        TB_ImportAbonat.ReadOnly = True
        TB_ImportAbonat.Size = New Size(151, 23)
        TB_ImportAbonat.TabIndex = 4
        TB_ImportAbonat.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label22.Location = New Point(30, 139)
        Label22.Name = "Label22"
        Label22.Size = New Size(56, 15)
        Label22.TabIndex = 13
        Label22.Text = "Nº Acord"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label23.Location = New Point(30, 188)
        Label23.Name = "Label23"
        Label23.Size = New Size(71, 15)
        Label23.TabIndex = 11
        Label23.Text = "Data factura"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label24.Location = New Point(30, 286)
        Label24.Name = "Label24"
        Label24.Size = New Size(83, 15)
        Label24.TabIndex = 9
        Label24.Text = "Import factura"
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label27.Location = New Point(27, -134)
        Label27.Name = "Label27"
        Label27.Size = New Size(76, 15)
        Label27.TabIndex = 2
        Label27.Text = "Tipus solució"
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label28.Location = New Point(30, 237)
        Label28.Name = "Label28"
        Label28.Size = New Size(63, 15)
        Label28.TabIndex = 8
        Label28.Text = "Nº Factura"
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label29.Location = New Point(27, -89)
        Label29.Name = "Label29"
        Label29.Size = New Size(56, 15)
        Label29.TabIndex = 3
        Label29.Text = "Nº Acord"
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label31.Location = New Point(27, -44)
        Label31.Name = "Label31"
        Label31.Size = New Size(72, 15)
        Label31.TabIndex = 5
        Label31.Text = "Cost solució"
        ' 
        ' Label32
        ' 
        Label32.AutoSize = True
        Label32.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label32.Location = New Point(30, 335)
        Label32.Name = "Label32"
        Label32.Size = New Size(83, 15)
        Label32.TabIndex = 6
        Label32.Text = "Import abonat"
        ' 
        ' PanelDadesEmpresa
        ' 
        PanelDadesEmpresa.Controls.Add(GroupBox1)
        PanelDadesEmpresa.Location = New Point(3, 6)
        PanelDadesEmpresa.Name = "PanelDadesEmpresa"
        PanelDadesEmpresa.Padding = New Padding(10)
        PanelDadesEmpresa.Size = New Size(368, 447)
        PanelDadesEmpresa.TabIndex = 25
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(CB_Empreses)
        GroupBox1.Controls.Add(EmpresaNom)
        GroupBox1.Controls.Add(EmpresaNif)
        GroupBox1.Controls.Add(EmpresaDireccio)
        GroupBox1.Controls.Add(EmpresaCodiPostal)
        GroupBox1.Controls.Add(EmpresaCiutat)
        GroupBox1.Controls.Add(EmpresaProvincia)
        GroupBox1.Controls.Add(EmpresaPais)
        GroupBox1.Controls.Add(Label15)
        GroupBox1.Controls.Add(Label14)
        GroupBox1.Controls.Add(Label13)
        GroupBox1.Controls.Add(Label12)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Dock = DockStyle.Fill
        GroupBox1.Location = New Point(10, 10)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(348, 427)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Dades Empresa"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(11, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 15)
        Label1.TabIndex = 17
        Label1.Text = "Seleccionar"
        ' 
        ' CB_Empreses
        ' 
        CB_Empreses.FormattingEnabled = True
        CB_Empreses.Location = New Point(92, 32)
        CB_Empreses.Name = "CB_Empreses"
        CB_Empreses.Size = New Size(242, 23)
        CB_Empreses.TabIndex = 16
        ' 
        ' EmpresaNom
        ' 
        EmpresaNom.CharacterCasing = CharacterCasing.Upper
        EmpresaNom.Location = New Point(92, 72)
        EmpresaNom.Name = "EmpresaNom"
        EmpresaNom.Size = New Size(242, 23)
        EmpresaNom.TabIndex = 9
        ' 
        ' EmpresaNif
        ' 
        EmpresaNif.CharacterCasing = CharacterCasing.Upper
        EmpresaNif.Location = New Point(92, 112)
        EmpresaNif.MaxLength = 9
        EmpresaNif.Name = "EmpresaNif"
        EmpresaNif.Size = New Size(100, 23)
        EmpresaNif.TabIndex = 10
        ' 
        ' EmpresaDireccio
        ' 
        EmpresaDireccio.CharacterCasing = CharacterCasing.Upper
        EmpresaDireccio.Location = New Point(92, 152)
        EmpresaDireccio.Name = "EmpresaDireccio"
        EmpresaDireccio.Size = New Size(242, 23)
        EmpresaDireccio.TabIndex = 11
        ' 
        ' EmpresaCodiPostal
        ' 
        EmpresaCodiPostal.CharacterCasing = CharacterCasing.Upper
        EmpresaCodiPostal.Location = New Point(92, 192)
        EmpresaCodiPostal.MaxLength = 5
        EmpresaCodiPostal.Name = "EmpresaCodiPostal"
        EmpresaCodiPostal.Size = New Size(100, 23)
        EmpresaCodiPostal.TabIndex = 12
        ' 
        ' EmpresaCiutat
        ' 
        EmpresaCiutat.CharacterCasing = CharacterCasing.Upper
        EmpresaCiutat.Location = New Point(92, 232)
        EmpresaCiutat.Name = "EmpresaCiutat"
        EmpresaCiutat.Size = New Size(242, 23)
        EmpresaCiutat.TabIndex = 13
        ' 
        ' EmpresaProvincia
        ' 
        EmpresaProvincia.CharacterCasing = CharacterCasing.Upper
        EmpresaProvincia.Location = New Point(92, 272)
        EmpresaProvincia.Name = "EmpresaProvincia"
        EmpresaProvincia.Size = New Size(242, 23)
        EmpresaProvincia.TabIndex = 14
        ' 
        ' EmpresaPais
        ' 
        EmpresaPais.CharacterCasing = CharacterCasing.Upper
        EmpresaPais.Enabled = False
        EmpresaPais.Location = New Point(92, 312)
        EmpresaPais.Name = "EmpresaPais"
        EmpresaPais.Size = New Size(242, 23)
        EmpresaPais.TabIndex = 15
        EmpresaPais.Text = "ESPAÑA"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(11, 115)
        Label15.Name = "Label15"
        Label15.Size = New Size(25, 15)
        Label15.TabIndex = 6
        Label15.Text = "NIF"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(11, 315)
        Label14.Name = "Label14"
        Label14.Size = New Size(28, 15)
        Label14.TabIndex = 5
        Label14.Text = "Pais"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(11, 275)
        Label13.Name = "Label13"
        Label13.Size = New Size(56, 15)
        Label13.TabIndex = 4
        Label13.Text = "Provincia"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(11, 235)
        Label12.Name = "Label12"
        Label12.Size = New Size(39, 15)
        Label12.TabIndex = 3
        Label12.Text = "Ciutat"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(11, 195)
        Label11.Name = "Label11"
        Label11.Size = New Size(67, 15)
        Label11.TabIndex = 2
        Label11.Text = "Codi postal"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(11, 155)
        Label10.Name = "Label10"
        Label10.Size = New Size(50, 15)
        Label10.TabIndex = 1
        Label10.Text = "Direcció"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(11, 75)
        Label9.Name = "Label9"
        Label9.Size = New Size(34, 15)
        Label9.TabIndex = 0
        Label9.Text = "Nom"
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.AutoScroll = True
        Panel1.AutoSize = True
        Panel1.Controls.Add(PanelDadesEmpresa)
        Panel1.Controls.Add(PanelDeclaracio)
        Panel1.Controls.Add(PanelDadesFactura)
        Panel1.Location = New Point(20, 88)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1106, 488)
        Panel1.TabIndex = 28
        ' 
        ' Factures
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(1144, 668)
        Controls.Add(Panel1)
        Controls.Add(PanelBotons)
        Controls.Add(PanelLogotips)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Factures"
        Padding = New Padding(20)
        Text = "Factures XML"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PanelLogotips.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        PanelBotons.ResumeLayout(False)
        PanelBotons.PerformLayout()
        PanelDadesFactura.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        PanelDeclaracio.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        PanelDadesEmpresa.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents Btn_Guardar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btn_Visualitzar As Button

    Dim textoXML As New System.Text.StringBuilder()
    Friend WithEvents Vigila As Label
    Friend WithEvents PanelLogotips As Panel
    Friend WithEvents PanelBotons As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Btn_EsborraDades As Button
    Friend WithEvents PanelDadesFactura As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label20 As Label
    Friend WithEvents FacturaNumero As TextBox
    Friend WithEvents CB_Solucions As ComboBox
    Friend WithEvents FacturaAcord As TextBox
    Friend WithEvents FacturaImportSolucio As TextBox
    Friend WithEvents FacturaImportIVA As TextBox
    Friend WithEvents FacturaImportTotal As TextBox
    Friend WithEvents FacturaImportSubvencionat As TextBox
    Friend WithEvents FacturaSolucio As ComboBox
    Friend WithEvents FacturaData As DateTimePicker
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PanelDeclaracio As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CopiarDataCobrament As Button
    Friend WithEvents CopiarImportAbonat As Button
    Friend WithEvents CopiarImportFactura As Button
    Friend WithEvents CopiarNoFactura As Button
    Friend WithEvents CopiarDataFactura As Button
    Friend WithEvents CopiarNoAcord As Button
    Friend WithEvents CopiarNif As Button
    Friend WithEvents CopiarRaoSocial As Button
    Friend WithEvents TB_DataFactura As TextBox
    Friend WithEvents TB_DataCobrament As TextBox
    Friend WithEvents TB_Nif As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents TB_Rao As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents TB_NoFactura As TextBox
    Friend WithEvents TB_NoAcord As TextBox
    Friend WithEvents TB_ImportFactura As TextBox
    Friend WithEvents TB_ImportAbonat As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents PanelDadesEmpresa As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CB_Empreses As ComboBox
    Friend WithEvents EmpresaNom As TextBox
    Friend WithEvents EmpresaNif As TextBox
    Friend WithEvents EmpresaDireccio As TextBox
    Friend WithEvents EmpresaCodiPostal As TextBox
    Friend WithEvents EmpresaCiutat As TextBox
    Friend WithEvents EmpresaProvincia As TextBox
    Friend WithEvents EmpresaPais As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
End Class