﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Contractes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Contractes))
        DataEmpreses = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Empresa = New TextBox()
        Nif = New TextBox()
        Direccio = New TextBox()
        CodiPostal = New TextBox()
        Ciutat = New TextBox()
        Provincia = New TextBox()
        Pais = New TextBox()
        Btn_afegir = New Button()
        Btn_esborrarEmpresa = New Button()
        btn_EsborrarSeleccioEmpresa = New Button()
        DataSolucions = New DataGridView()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label13 = New Label()
        CB_TipusSolucio = New ComboBox()
        NoAcord = New TextBox()
        DiesCaducitat = New TextBox()
        Btn_AfegirSolucio = New Button()
        DataContracte = New DateTimePicker()
        Btn_EsborrarSeleccioSolucio = New Button()
        Btn_EsborrarSolucio = New Button()
        TitolEmpresa = New TextBox()
        TitolSolucio = New TextBox()
        CheckJustificat = New CheckBox()
        CheckEstaJustificat = New CheckBox()
        Btn_EstatJustificacio = New Button()
        TBObservacions = New TextBox()
        Label16 = New Label()
        verificat = New PictureBox()
        ContextMenuEsborrar = New ContextMenuStrip(components)
        DataAprovacio = New DateTimePicker()
        DataPagament = New DateTimePicker()
        TitolContracte = New Label()
        DataFiContracte = New TextBox()
        CB_DataContracte = New CheckBox()
        CB_DataPagamentIVA = New CheckBox()
        CB_DataAprovacio = New CheckBox()
        DataContracteOK = New PictureBox()
        DataPagamentOK = New PictureBox()
        DataCaducitat = New TextBox()
        Label11 = New Label()
        CB_DataFactura = New CheckBox()
        DataFactura = New DateTimePicker()
        DataFacturaOK = New PictureBox()
        DataFiFactura = New TextBox()
        TitolFactura = New Label()
        GroupBox1 = New GroupBox()
        RB_Segment5 = New RadioButton()
        RB_Segment4 = New RadioButton()
        RB_Segment3 = New RadioButton()
        RB_Segment2 = New RadioButton()
        RB_Segment1 = New RadioButton()
        Label12 = New Label()
        InfoVariable = New Label()
        InfoVariableNum = New NumericUpDown()
        infoMax = New Label()
        Label17 = New Label()
        InfoSubvencio = New TextBox()
        Label18 = New Label()
        CB_PagamentFet = New CheckBox()
        Pagat1 = New PictureBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        GroupBox2 = New GroupBox()
        Lbl_tipus = New Label()
        Lbl_estat = New Label()
        DataFiConcessio = New TextBox()
        TitolAprovacio = New Label()
        DataConcessioOK = New PictureBox()
        Label14 = New Label()
        InfoSubvencioReal = New TextBox()
        Label19 = New Label()
        GroupBox3 = New GroupBox()
        Label23 = New Label()
        TB_ImportBono = New TextBox()
        Label22 = New Label()
        TB_CodiBono = New TextBox()
        Label21 = New Label()
        Label20 = New Label()
        TB_CaducitatConcessio = New TextBox()
        DataConcessio = New DateTimePicker()
        CB_DataConcessio = New CheckBox()
        TB_CercaEmpreses = New TextBox()
        PB_EliminaFiltre = New PictureBox()
        Label24 = New Label()
        TB_BonusRestant = New TextBox()
        Label25 = New Label()
        TitolJustificacio = New Label()
        DataFiJustificacio = New TextBox()
        btn_importarEmpreses = New Button()
        Label15 = New Label()
        Retraso = New Timer(components)
        CType(DataEmpreses, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataSolucions, ComponentModel.ISupportInitialize).BeginInit()
        CType(verificat, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataContracteOK, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataPagamentOK, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataFacturaOK, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(InfoVariableNum, ComponentModel.ISupportInitialize).BeginInit()
        CType(Pagat1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(DataConcessioOK, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        CType(PB_EliminaFiltre, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataEmpreses
        ' 
        DataEmpreses.AllowUserToAddRows = False
        DataEmpreses.AllowUserToDeleteRows = False
        DataEmpreses.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        DataEmpreses.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataEmpreses.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataEmpreses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataEmpreses.BorderStyle = BorderStyle.Fixed3D
        DataEmpreses.CellBorderStyle = DataGridViewCellBorderStyle.Raised
        DataEmpreses.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.Gray
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(72), CByte(101), CByte(174))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataEmpreses.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataEmpreses.ColumnHeadersHeight = 30
        DataEmpreses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Window
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(72), CByte(101), CByte(174))
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        DataEmpreses.DefaultCellStyle = DataGridViewCellStyle3
        DataEmpreses.EditMode = DataGridViewEditMode.EditProgrammatically
        DataEmpreses.EnableHeadersVisualStyles = False
        DataEmpreses.Location = New Point(360, 65)
        DataEmpreses.MultiSelect = False
        DataEmpreses.Name = "DataEmpreses"
        DataEmpreses.ReadOnly = True
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(72), CByte(101), CByte(174))
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(CByte(72), CByte(101), CByte(174))
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        DataEmpreses.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataEmpreses.RowHeadersVisible = False
        DataEmpreses.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataEmpreses.RowTemplate.Height = 25
        DataEmpreses.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataEmpreses.ShowEditingIcon = False
        DataEmpreses.Size = New Size(429, 852)
        DataEmpreses.TabIndex = 6
        DataEmpreses.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(13, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 15)
        Label1.TabIndex = 1
        Label1.Text = "Empresa"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(13, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(25, 15)
        Label2.TabIndex = 2
        Label2.Text = "NIF"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(13, 123)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 15)
        Label3.TabIndex = 3
        Label3.Text = "Direcció"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(13, 165)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 15)
        Label4.TabIndex = 4
        Label4.Text = "Codi Postal"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(13, 207)
        Label5.Name = "Label5"
        Label5.Size = New Size(39, 15)
        Label5.TabIndex = 5
        Label5.Text = "Ciutat"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(13, 249)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 15)
        Label6.TabIndex = 6
        Label6.Text = "Provincia"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(13, 291)
        Label7.Name = "Label7"
        Label7.Size = New Size(28, 15)
        Label7.TabIndex = 7
        Label7.Text = "Pais"
        ' 
        ' Empresa
        ' 
        Empresa.CharacterCasing = CharacterCasing.Upper
        Empresa.Location = New Point(68, 31)
        Empresa.Name = "Empresa"
        Empresa.Size = New Size(225, 23)
        Empresa.TabIndex = 0
        ' 
        ' Nif
        ' 
        Nif.CharacterCasing = CharacterCasing.Upper
        Nif.Location = New Point(68, 73)
        Nif.Name = "Nif"
        Nif.Size = New Size(93, 23)
        Nif.TabIndex = 1
        ' 
        ' Direccio
        ' 
        Direccio.CharacterCasing = CharacterCasing.Upper
        Direccio.Location = New Point(68, 115)
        Direccio.Name = "Direccio"
        Direccio.Size = New Size(225, 23)
        Direccio.TabIndex = 2
        Direccio.Tag = ""
        ' 
        ' CodiPostal
        ' 
        CodiPostal.CharacterCasing = CharacterCasing.Upper
        CodiPostal.Location = New Point(97, 157)
        CodiPostal.Name = "CodiPostal"
        CodiPostal.Size = New Size(85, 23)
        CodiPostal.TabIndex = 3
        CodiPostal.Tag = ""
        ' 
        ' Ciutat
        ' 
        Ciutat.CharacterCasing = CharacterCasing.Upper
        Ciutat.Location = New Point(68, 199)
        Ciutat.Name = "Ciutat"
        Ciutat.Size = New Size(225, 23)
        Ciutat.TabIndex = 4
        ' 
        ' Provincia
        ' 
        Provincia.CharacterCasing = CharacterCasing.Upper
        Provincia.Location = New Point(87, 241)
        Provincia.Name = "Provincia"
        Provincia.Size = New Size(206, 23)
        Provincia.TabIndex = 5
        ' 
        ' Pais
        ' 
        Pais.CharacterCasing = CharacterCasing.Upper
        Pais.Location = New Point(68, 283)
        Pais.Name = "Pais"
        Pais.Size = New Size(225, 23)
        Pais.TabIndex = 6
        ' 
        ' Btn_afegir
        ' 
        Btn_afegir.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Btn_afegir.Location = New Point(28, 805)
        Btn_afegir.Name = "Btn_afegir"
        Btn_afegir.Size = New Size(148, 53)
        Btn_afegir.TabIndex = 9
        Btn_afegir.Text = "Afegir empresa"
        Btn_afegir.UseVisualStyleBackColor = True
        ' 
        ' Btn_esborrarEmpresa
        ' 
        Btn_esborrarEmpresa.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Btn_esborrarEmpresa.BackColor = Color.IndianRed
        Btn_esborrarEmpresa.Location = New Point(193, 805)
        Btn_esborrarEmpresa.Name = "Btn_esborrarEmpresa"
        Btn_esborrarEmpresa.Size = New Size(148, 53)
        Btn_esborrarEmpresa.TabIndex = 10
        Btn_esborrarEmpresa.Text = "Esborrar empresa"
        Btn_esborrarEmpresa.UseVisualStyleBackColor = False
        ' 
        ' btn_EsborrarSeleccioEmpresa
        ' 
        btn_EsborrarSeleccioEmpresa.Location = New Point(28, 881)
        btn_EsborrarSeleccioEmpresa.Name = "btn_EsborrarSeleccioEmpresa"
        btn_EsborrarSeleccioEmpresa.Size = New Size(148, 54)
        btn_EsborrarSeleccioEmpresa.TabIndex = 8
        btn_EsborrarSeleccioEmpresa.Text = "Esborrar selecció"
        btn_EsborrarSeleccioEmpresa.UseVisualStyleBackColor = True
        ' 
        ' DataSolucions
        ' 
        DataSolucions.AllowUserToAddRows = False
        DataSolucions.AllowUserToDeleteRows = False
        DataSolucions.AllowUserToResizeRows = False
        DataSolucions.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        DataSolucions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataSolucions.BorderStyle = BorderStyle.Fixed3D
        DataSolucions.CellBorderStyle = DataGridViewCellBorderStyle.Raised
        DataSolucions.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = Color.Gray
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(72), CByte(101), CByte(174))
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        DataSolucions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        DataSolucions.ColumnHeadersHeight = 30
        DataSolucions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.Window
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(72), CByte(101), CByte(174))
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        DataSolucions.DefaultCellStyle = DataGridViewCellStyle6
        DataSolucions.EditMode = DataGridViewEditMode.EditProgrammatically
        DataSolucions.EnableHeadersVisualStyles = False
        DataSolucions.Location = New Point(826, 65)
        DataSolucions.MultiSelect = False
        DataSolucions.Name = "DataSolucions"
        DataSolucions.ReadOnly = True
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = SystemColors.Control
        DataGridViewCellStyle7.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle7.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.True
        DataSolucions.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        DataSolucions.RowHeadersVisible = False
        DataSolucions.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataSolucions.RowTemplate.Height = 25
        DataSolucions.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataSolucions.ShowEditingIcon = False
        DataSolucions.Size = New Size(797, 264)
        DataSolucions.TabIndex = 18
        DataSolucions.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Location = New Point(1045, 26)
        Label8.Name = "Label8"
        Label8.Size = New Size(64, 15)
        Label8.TabIndex = 20
        Label8.Text = "Contractes"
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.Location = New Point(826, 371)
        Label9.Name = "Label9"
        Label9.Size = New Size(76, 15)
        Label9.TabIndex = 21
        Label9.Text = "Tipus solució"
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label10.AutoSize = True
        Label10.Location = New Point(826, 439)
        Label10.Name = "Label10"
        Label10.Size = New Size(56, 15)
        Label10.TabIndex = 22
        Label10.Text = "Nº Acord"
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label13.AutoSize = True
        Label13.Location = New Point(162, 15)
        Label13.Name = "Label13"
        Label13.Size = New Size(81, 15)
        Label13.TabIndex = 25
        Label13.Text = "Dies caducitat"
        ' 
        ' CB_TipusSolucio
        ' 
        CB_TipusSolucio.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        CB_TipusSolucio.Enabled = False
        CB_TipusSolucio.FormattingEnabled = True
        CB_TipusSolucio.Location = New Point(908, 368)
        CB_TipusSolucio.Name = "CB_TipusSolucio"
        CB_TipusSolucio.Size = New Size(323, 23)
        CB_TipusSolucio.TabIndex = 11
        ' 
        ' NoAcord
        ' 
        NoAcord.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        NoAcord.CharacterCasing = CharacterCasing.Upper
        NoAcord.Enabled = False
        NoAcord.Location = New Point(908, 434)
        NoAcord.Name = "NoAcord"
        NoAcord.Size = New Size(116, 23)
        NoAcord.TabIndex = 12
        NoAcord.TextAlign = HorizontalAlignment.Center
        ' 
        ' DiesCaducitat
        ' 
        DiesCaducitat.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        DiesCaducitat.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        DiesCaducitat.Location = New Point(288, 8)
        DiesCaducitat.Name = "DiesCaducitat"
        DiesCaducitat.ReadOnly = True
        DiesCaducitat.Size = New Size(112, 33)
        DiesCaducitat.TabIndex = 30
        DiesCaducitat.TabStop = False
        DiesCaducitat.Text = "-"
        DiesCaducitat.TextAlign = HorizontalAlignment.Center
        ' 
        ' Btn_AfegirSolucio
        ' 
        Btn_AfegirSolucio.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Btn_AfegirSolucio.Enabled = False
        Btn_AfegirSolucio.Location = New Point(1331, 864)
        Btn_AfegirSolucio.Name = "Btn_AfegirSolucio"
        Btn_AfegirSolucio.Size = New Size(146, 53)
        Btn_AfegirSolucio.TabIndex = 22
        Btn_AfegirSolucio.Text = "Modificar solució"
        Btn_AfegirSolucio.UseVisualStyleBackColor = True
        ' 
        ' DataContracte
        ' 
        DataContracte.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        DataContracte.Format = DateTimePickerFormat.Short
        DataContracte.Location = New Point(1085, 501)
        DataContracte.Name = "DataContracte"
        DataContracte.Size = New Size(111, 23)
        DataContracte.TabIndex = 14
        DataContracte.Visible = False
        ' 
        ' Btn_EsborrarSeleccioSolucio
        ' 
        Btn_EsborrarSeleccioSolucio.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Btn_EsborrarSeleccioSolucio.Enabled = False
        Btn_EsborrarSeleccioSolucio.Location = New Point(1001, 863)
        Btn_EsborrarSeleccioSolucio.Name = "Btn_EsborrarSeleccioSolucio"
        Btn_EsborrarSeleccioSolucio.Size = New Size(146, 53)
        Btn_EsborrarSeleccioSolucio.TabIndex = 21
        Btn_EsborrarSeleccioSolucio.Text = "Esborrar selecció"
        Btn_EsborrarSeleccioSolucio.UseVisualStyleBackColor = True
        ' 
        ' Btn_EsborrarSolucio
        ' 
        Btn_EsborrarSolucio.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Btn_EsborrarSolucio.BackColor = Color.IndianRed
        Btn_EsborrarSolucio.Enabled = False
        Btn_EsborrarSolucio.Location = New Point(1483, 864)
        Btn_EsborrarSolucio.Name = "Btn_EsborrarSolucio"
        Btn_EsborrarSolucio.Size = New Size(144, 53)
        Btn_EsborrarSolucio.TabIndex = 23
        Btn_EsborrarSolucio.Text = "Esborrar solució"
        Btn_EsborrarSolucio.UseVisualStyleBackColor = False
        ' 
        ' TitolEmpresa
        ' 
        TitolEmpresa.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TitolEmpresa.CharacterCasing = CharacterCasing.Upper
        TitolEmpresa.Enabled = False
        TitolEmpresa.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        TitolEmpresa.Location = New Point(575, 23)
        TitolEmpresa.Multiline = True
        TitolEmpresa.Name = "TitolEmpresa"
        TitolEmpresa.PlaceholderText = "SELECCIONA EMPRESA"
        TitolEmpresa.ReadOnly = True
        TitolEmpresa.Size = New Size(214, 36)
        TitolEmpresa.TabIndex = 36
        TitolEmpresa.TextAlign = HorizontalAlignment.Center
        ' 
        ' TitolSolucio
        ' 
        TitolSolucio.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TitolSolucio.CharacterCasing = CharacterCasing.Upper
        TitolSolucio.Enabled = False
        TitolSolucio.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        TitolSolucio.Location = New Point(826, 23)
        TitolSolucio.Multiline = True
        TitolSolucio.Name = "TitolSolucio"
        TitolSolucio.PlaceholderText = "SELECCIONA JUSTIFICACIÓ"
        TitolSolucio.ReadOnly = True
        TitolSolucio.Size = New Size(797, 36)
        TitolSolucio.TabIndex = 37
        TitolSolucio.TextAlign = HorizontalAlignment.Center
        ' 
        ' CheckJustificat
        ' 
        CheckJustificat.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        CheckJustificat.AutoSize = True
        CheckJustificat.CheckAlign = ContentAlignment.MiddleRight
        CheckJustificat.Location = New Point(826, 864)
        CheckJustificat.Name = "CheckJustificat"
        CheckJustificat.Size = New Size(120, 19)
        CheckJustificat.TabIndex = 19
        CheckJustificat.Text = "Mostrar justificats"
        CheckJustificat.UseVisualStyleBackColor = True
        ' 
        ' CheckEstaJustificat
        ' 
        CheckEstaJustificat.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        CheckEstaJustificat.AutoSize = True
        CheckEstaJustificat.Enabled = False
        CheckEstaJustificat.Location = New Point(16, 21)
        CheckEstaJustificat.Name = "CheckEstaJustificat"
        CheckEstaJustificat.Size = New Size(77, 19)
        CheckEstaJustificat.TabIndex = 17
        CheckEstaJustificat.Text = "Justificat?"
        CheckEstaJustificat.UseVisualStyleBackColor = True
        ' 
        ' Btn_EstatJustificacio
        ' 
        Btn_EstatJustificacio.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Btn_EstatJustificacio.Enabled = False
        Btn_EstatJustificacio.Location = New Point(1506, 368)
        Btn_EstatJustificacio.Name = "Btn_EstatJustificacio"
        Btn_EstatJustificacio.Size = New Size(121, 63)
        Btn_EstatJustificacio.TabIndex = 18
        Btn_EstatJustificacio.Text = "Veure estat de" & vbCrLf & "justificació"
        Btn_EstatJustificacio.UseVisualStyleBackColor = True
        ' 
        ' TBObservacions
        ' 
        TBObservacions.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TBObservacions.Enabled = False
        TBObservacions.Location = New Point(1001, 765)
        TBObservacions.Multiline = True
        TBObservacions.Name = "TBObservacions"
        TBObservacions.Size = New Size(622, 102)
        TBObservacions.TabIndex = 20
        ' 
        ' Label16
        ' 
        Label16.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label16.AutoSize = True
        Label16.Location = New Point(1114, 747)
        Label16.Name = "Label16"
        Label16.Size = New Size(78, 15)
        Label16.TabIndex = 45
        Label16.Text = "Observacions"
        ' 
        ' verificat
        ' 
        verificat.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        verificat.BackColor = Color.Transparent
        verificat.BackgroundImageLayout = ImageLayout.None
        verificat.Image = My.Resources.Resources.verificado
        verificat.Location = New Point(99, 8)
        verificat.Name = "verificat"
        verificat.Size = New Size(40, 40)
        verificat.SizeMode = PictureBoxSizeMode.Zoom
        verificat.TabIndex = 46
        verificat.TabStop = False
        verificat.Visible = False
        ' 
        ' ContextMenuEsborrar
        ' 
        ContextMenuEsborrar.Name = "ContextMenuStrip1"
        ContextMenuEsborrar.Size = New Size(61, 4)
        ' 
        ' DataAprovacio
        ' 
        DataAprovacio.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        DataAprovacio.Enabled = False
        DataAprovacio.Format = DateTimePickerFormat.Short
        DataAprovacio.Location = New Point(1085, 472)
        DataAprovacio.Name = "DataAprovacio"
        DataAprovacio.Size = New Size(111, 23)
        DataAprovacio.TabIndex = 13
        DataAprovacio.Visible = False
        ' 
        ' DataPagament
        ' 
        DataPagament.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        DataPagament.Format = DateTimePickerFormat.Short
        DataPagament.Location = New Point(1085, 561)
        DataPagament.Name = "DataPagament"
        DataPagament.Size = New Size(111, 23)
        DataPagament.TabIndex = 16
        DataPagament.Visible = False
        ' 
        ' TitolContracte
        ' 
        TitolContracte.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TitolContracte.AutoSize = True
        TitolContracte.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        TitolContracte.ImageAlign = ContentAlignment.MiddleRight
        TitolContracte.Location = New Point(1288, 506)
        TitolContracte.Name = "TitolContracte"
        TitolContracte.Size = New Size(206, 13)
        TitolContracte.TabIndex = 52
        TitolContracte.Text = "Data màxima per emetre factura i cobrar-la"
        TitolContracte.TextAlign = ContentAlignment.MiddleLeft
        TitolContracte.Visible = False
        ' 
        ' DataFiContracte
        ' 
        DataFiContracte.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        DataFiContracte.Location = New Point(1505, 498)
        DataFiContracte.Name = "DataFiContracte"
        DataFiContracte.ReadOnly = True
        DataFiContracte.Size = New Size(118, 23)
        DataFiContracte.TabIndex = 54
        DataFiContracte.TextAlign = HorizontalAlignment.Center
        DataFiContracte.Visible = False
        ' 
        ' CB_DataContracte
        ' 
        CB_DataContracte.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        CB_DataContracte.AutoSize = True
        CB_DataContracte.Enabled = False
        CB_DataContracte.ForeColor = SystemColors.ControlText
        CB_DataContracte.Location = New Point(826, 505)
        CB_DataContracte.Name = "CB_DataContracte"
        CB_DataContracte.Size = New Size(105, 19)
        CB_DataContracte.TabIndex = 57
        CB_DataContracte.Text = "Data Contracte"
        CB_DataContracte.UseVisualStyleBackColor = True
        ' 
        ' CB_DataPagamentIVA
        ' 
        CB_DataPagamentIVA.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        CB_DataPagamentIVA.AutoSize = True
        CB_DataPagamentIVA.Enabled = False
        CB_DataPagamentIVA.Location = New Point(826, 564)
        CB_DataPagamentIVA.Name = "CB_DataPagamentIVA"
        CB_DataPagamentIVA.Size = New Size(127, 19)
        CB_DataPagamentIVA.TabIndex = 7
        CB_DataPagamentIVA.Text = "Data pagament IVA"
        CB_DataPagamentIVA.UseVisualStyleBackColor = True
        ' 
        ' CB_DataAprovacio
        ' 
        CB_DataAprovacio.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        CB_DataAprovacio.AutoSize = True
        CB_DataAprovacio.Enabled = False
        CB_DataAprovacio.Location = New Point(826, 476)
        CB_DataAprovacio.Name = "CB_DataAprovacio"
        CB_DataAprovacio.Size = New Size(138, 19)
        CB_DataAprovacio.TabIndex = 59
        CB_DataAprovacio.Text = "Data Concessió Bono"
        CB_DataAprovacio.UseVisualStyleBackColor = True
        ' 
        ' DataContracteOK
        ' 
        DataContracteOK.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        DataContracteOK.Image = My.Resources.Resources.verificado_petit
        DataContracteOK.Location = New Point(1207, 500)
        DataContracteOK.Name = "DataContracteOK"
        DataContracteOK.Size = New Size(24, 24)
        DataContracteOK.SizeMode = PictureBoxSizeMode.Zoom
        DataContracteOK.TabIndex = 61
        DataContracteOK.TabStop = False
        DataContracteOK.Visible = False
        ' 
        ' DataPagamentOK
        ' 
        DataPagamentOK.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        DataPagamentOK.Image = My.Resources.Resources.verificado_petit
        DataPagamentOK.Location = New Point(1207, 560)
        DataPagamentOK.Name = "DataPagamentOK"
        DataPagamentOK.Size = New Size(24, 24)
        DataPagamentOK.SizeMode = PictureBoxSizeMode.Zoom
        DataPagamentOK.TabIndex = 62
        DataPagamentOK.TabStop = False
        DataPagamentOK.Visible = False
        ' 
        ' DataCaducitat
        ' 
        DataCaducitat.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        DataCaducitat.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        DataCaducitat.Location = New Point(589, 7)
        DataCaducitat.Name = "DataCaducitat"
        DataCaducitat.ReadOnly = True
        DataCaducitat.Size = New Size(180, 33)
        DataCaducitat.TabIndex = 63
        DataCaducitat.TabStop = False
        DataCaducitat.Text = "-"
        DataCaducitat.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label11.AutoSize = True
        Label11.Location = New Point(493, 15)
        Label11.Name = "Label11"
        Label11.Size = New Size(83, 15)
        Label11.TabIndex = 64
        Label11.Text = "Data caducitat"
        ' 
        ' CB_DataFactura
        ' 
        CB_DataFactura.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        CB_DataFactura.AutoSize = True
        CB_DataFactura.Enabled = False
        CB_DataFactura.Location = New Point(826, 536)
        CB_DataFactura.Name = "CB_DataFactura"
        CB_DataFactura.Size = New Size(90, 19)
        CB_DataFactura.TabIndex = 66
        CB_DataFactura.Text = "Data factura"
        CB_DataFactura.UseVisualStyleBackColor = True
        ' 
        ' DataFactura
        ' 
        DataFactura.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        DataFactura.Format = DateTimePickerFormat.Short
        DataFactura.Location = New Point(1085, 531)
        DataFactura.Name = "DataFactura"
        DataFactura.Size = New Size(111, 23)
        DataFactura.TabIndex = 15
        DataFactura.Visible = False
        ' 
        ' DataFacturaOK
        ' 
        DataFacturaOK.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        DataFacturaOK.Image = My.Resources.Resources.verificado_petit
        DataFacturaOK.Location = New Point(1207, 531)
        DataFacturaOK.Name = "DataFacturaOK"
        DataFacturaOK.Size = New Size(24, 24)
        DataFacturaOK.SizeMode = PictureBoxSizeMode.Zoom
        DataFacturaOK.TabIndex = 68
        DataFacturaOK.TabStop = False
        DataFacturaOK.Visible = False
        ' 
        ' DataFiFactura
        ' 
        DataFiFactura.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        DataFiFactura.Location = New Point(1505, 529)
        DataFiFactura.Name = "DataFiFactura"
        DataFiFactura.ReadOnly = True
        DataFiFactura.Size = New Size(118, 23)
        DataFiFactura.TabIndex = 67
        DataFiFactura.TextAlign = HorizontalAlignment.Center
        DataFiFactura.Visible = False
        ' 
        ' TitolFactura
        ' 
        TitolFactura.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TitolFactura.AutoSize = True
        TitolFactura.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        TitolFactura.ImageAlign = ContentAlignment.MiddleRight
        TitolFactura.Location = New Point(1330, 539)
        TitolFactura.Name = "TitolFactura"
        TitolFactura.Size = New Size(164, 13)
        TitolFactura.TabIndex = 69
        TitolFactura.Text = "Data màxima per fer la justificació"
        TitolFactura.TextAlign = ContentAlignment.MiddleLeft
        TitolFactura.Visible = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ControlLight
        GroupBox1.Controls.Add(RB_Segment5)
        GroupBox1.Controls.Add(RB_Segment4)
        GroupBox1.Controls.Add(RB_Segment3)
        GroupBox1.Controls.Add(RB_Segment2)
        GroupBox1.Controls.Add(RB_Segment1)
        GroupBox1.Controls.Add(Label12)
        GroupBox1.Controls.Add(Empresa)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Nif)
        GroupBox1.Controls.Add(Direccio)
        GroupBox1.Controls.Add(CodiPostal)
        GroupBox1.Controls.Add(Ciutat)
        GroupBox1.Controls.Add(Provincia)
        GroupBox1.Controls.Add(Pais)
        GroupBox1.Location = New Point(28, 65)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(313, 464)
        GroupBox1.TabIndex = 74
        GroupBox1.TabStop = False
        GroupBox1.Text = "Dades de l'empresa"
        ' 
        ' RB_Segment5
        ' 
        RB_Segment5.AutoSize = True
        RB_Segment5.Location = New Point(85, 427)
        RB_Segment5.Name = "RB_Segment5"
        RB_Segment5.Size = New Size(169, 19)
        RB_Segment5.TabIndex = 13
        RB_Segment5.TabStop = True
        RB_Segment5.Text = "V - Entre 100 i 249 empleats"
        RB_Segment5.UseVisualStyleBackColor = True
        ' 
        ' RB_Segment4
        ' 
        RB_Segment4.AutoSize = True
        RB_Segment4.Location = New Point(85, 403)
        RB_Segment4.Name = "RB_Segment4"
        RB_Segment4.Size = New Size(163, 19)
        RB_Segment4.TabIndex = 12
        RB_Segment4.TabStop = True
        RB_Segment4.Text = "IV  - Entre 50 i 99 empleats"
        RB_Segment4.UseVisualStyleBackColor = True
        ' 
        ' RB_Segment3
        ' 
        RB_Segment3.AutoSize = True
        RB_Segment3.Location = New Point(85, 379)
        RB_Segment3.Name = "RB_Segment3"
        RB_Segment3.Size = New Size(147, 19)
        RB_Segment3.TabIndex = 11
        RB_Segment3.TabStop = True
        RB_Segment3.Text = "III - Entre 1 i 2 empleats"
        RB_Segment3.UseVisualStyleBackColor = True
        ' 
        ' RB_Segment2
        ' 
        RB_Segment2.AutoSize = True
        RB_Segment2.Location = New Point(85, 355)
        RB_Segment2.Name = "RB_Segment2"
        RB_Segment2.Size = New Size(147, 19)
        RB_Segment2.TabIndex = 10
        RB_Segment2.TabStop = True
        RB_Segment2.Text = "II  - Entre 3 i 9 empleats"
        RB_Segment2.UseVisualStyleBackColor = True
        ' 
        ' RB_Segment1
        ' 
        RB_Segment1.AutoSize = True
        RB_Segment1.Location = New Point(85, 331)
        RB_Segment1.Name = "RB_Segment1"
        RB_Segment1.Size = New Size(159, 19)
        RB_Segment1.TabIndex = 7
        RB_Segment1.TabStop = True
        RB_Segment1.Text = "I   - Entre 10 i 49 empleats"
        RB_Segment1.UseVisualStyleBackColor = True
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(13, 335)
        Label12.Name = "Label12"
        Label12.Size = New Size(54, 15)
        Label12.TabIndex = 8
        Label12.Text = "Segment"
        ' 
        ' InfoVariable
        ' 
        InfoVariable.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        InfoVariable.AutoSize = True
        InfoVariable.Location = New Point(826, 405)
        InfoVariable.Name = "InfoVariable"
        InfoVariable.Size = New Size(72, 15)
        InfoVariable.TabIndex = 75
        InfoVariable.Text = "Info variable"
        InfoVariable.Visible = False
        ' 
        ' InfoVariableNum
        ' 
        InfoVariableNum.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        InfoVariableNum.Location = New Point(908, 402)
        InfoVariableNum.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        InfoVariableNum.Name = "InfoVariableNum"
        InfoVariableNum.Size = New Size(47, 23)
        InfoVariableNum.TabIndex = 76
        InfoVariableNum.Value = New Decimal(New Integer() {1, 0, 0, 0})
        InfoVariableNum.Visible = False
        ' 
        ' infoMax
        ' 
        infoMax.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        infoMax.AutoSize = True
        infoMax.Location = New Point(970, 404)
        infoMax.Name = "infoMax"
        infoMax.Size = New Size(54, 15)
        infoMax.TabIndex = 77
        infoMax.Text = "Info max"
        infoMax.Visible = False
        ' 
        ' Label17
        ' 
        Label17.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label17.AutoSize = True
        Label17.Location = New Point(1291, 408)
        Label17.Name = "Label17"
        Label17.Size = New Size(101, 15)
        Label17.TabIndex = 78
        Label17.Text = "Subvenció teórica"
        ' 
        ' InfoSubvencio
        ' 
        InfoSubvencio.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        InfoSubvencio.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        InfoSubvencio.Location = New Point(1294, 426)
        InfoSubvencio.Name = "InfoSubvencio"
        InfoSubvencio.ReadOnly = True
        InfoSubvencio.Size = New Size(81, 33)
        InfoSubvencio.TabIndex = 79
        InfoSubvencio.TabStop = False
        InfoSubvencio.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label18
        ' 
        Label18.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label18.Location = New Point(1377, 433)
        Label18.Name = "Label18"
        Label18.Size = New Size(18, 20)
        Label18.TabIndex = 80
        Label18.Text = "€"
        ' 
        ' CB_PagamentFet
        ' 
        CB_PagamentFet.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        CB_PagamentFet.AutoSize = True
        CB_PagamentFet.Enabled = False
        CB_PagamentFet.Location = New Point(16, 67)
        CB_PagamentFet.Name = "CB_PagamentFet"
        CB_PagamentFet.Size = New Size(61, 19)
        CB_PagamentFet.TabIndex = 81
        CB_PagamentFet.Text = "Pagat?"
        CB_PagamentFet.UseVisualStyleBackColor = True
        ' 
        ' Pagat1
        ' 
        Pagat1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Pagat1.BackColor = Color.Transparent
        Pagat1.BackgroundImageLayout = ImageLayout.None
        Pagat1.Image = My.Resources.Resources.Icono_Pagos
        Pagat1.Location = New Point(99, 54)
        Pagat1.Name = "Pagat1"
        Pagat1.Size = New Size(40, 40)
        Pagat1.SizeMode = PictureBoxSizeMode.Zoom
        Pagat1.TabIndex = 83
        Pagat1.TabStop = False
        Pagat1.Visible = False
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Panel1.BackColor = Color.LightGray
        Panel1.Controls.Add(CheckEstaJustificat)
        Panel1.Controls.Add(verificat)
        Panel1.Controls.Add(CB_PagamentFet)
        Panel1.Controls.Add(Pagat1)
        Panel1.Location = New Point(826, 765)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(160, 102)
        Panel1.TabIndex = 85
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Panel2.BackColor = Color.Pink
        Panel2.Controls.Add(DataCaducitat)
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(DiesCaducitat)
        Panel2.Controls.Add(Label11)
        Panel2.Location = New Point(826, 599)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(798, 48)
        Panel2.TabIndex = 86
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        GroupBox2.Controls.Add(Lbl_tipus)
        GroupBox2.Controls.Add(Lbl_estat)
        GroupBox2.Location = New Point(826, 659)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(797, 82)
        GroupBox2.TabIndex = 87
        GroupBox2.TabStop = False
        GroupBox2.Text = "Procés de justificació"
        ' 
        ' Lbl_tipus
        ' 
        Lbl_tipus.Font = New Font("Barlow Medium", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Lbl_tipus.Location = New Point(6, 20)
        Lbl_tipus.Name = "Lbl_tipus"
        Lbl_tipus.Size = New Size(270, 46)
        Lbl_tipus.TabIndex = 1
        Lbl_tipus.Text = "-"
        Lbl_tipus.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Lbl_estat
        ' 
        Lbl_estat.BackColor = SystemColors.Control
        Lbl_estat.Font = New Font("Barlow Medium", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Lbl_estat.Location = New Point(288, 20)
        Lbl_estat.Name = "Lbl_estat"
        Lbl_estat.Size = New Size(503, 46)
        Lbl_estat.TabIndex = 0
        Lbl_estat.Text = "-"
        Lbl_estat.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DataFiConcessio
        ' 
        DataFiConcessio.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        DataFiConcessio.Location = New Point(1505, 466)
        DataFiConcessio.Name = "DataFiConcessio"
        DataFiConcessio.ReadOnly = True
        DataFiConcessio.Size = New Size(118, 23)
        DataFiConcessio.TabIndex = 89
        DataFiConcessio.TextAlign = HorizontalAlignment.Center
        DataFiConcessio.Visible = False
        ' 
        ' TitolAprovacio
        ' 
        TitolAprovacio.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TitolAprovacio.AutoSize = True
        TitolAprovacio.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        TitolAprovacio.ImageAlign = ContentAlignment.MiddleRight
        TitolAprovacio.Location = New Point(1318, 474)
        TitolAprovacio.Name = "TitolAprovacio"
        TitolAprovacio.Size = New Size(176, 13)
        TitolAprovacio.TabIndex = 88
        TitolAprovacio.Text = "Data màxima per signar el contracte"
        TitolAprovacio.TextAlign = ContentAlignment.MiddleLeft
        TitolAprovacio.Visible = False
        ' 
        ' DataConcessioOK
        ' 
        DataConcessioOK.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        DataConcessioOK.Image = My.Resources.Resources.verificado_petit
        DataConcessioOK.Location = New Point(1207, 473)
        DataConcessioOK.Name = "DataConcessioOK"
        DataConcessioOK.Size = New Size(24, 24)
        DataConcessioOK.SizeMode = PictureBoxSizeMode.Zoom
        DataConcessioOK.TabIndex = 90
        DataConcessioOK.TabStop = False
        DataConcessioOK.Visible = False
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.Location = New Point(1480, 433)
        Label14.Name = "Label14"
        Label14.Size = New Size(18, 20)
        Label14.TabIndex = 93
        Label14.Text = "€"
        ' 
        ' InfoSubvencioReal
        ' 
        InfoSubvencioReal.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        InfoSubvencioReal.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        InfoSubvencioReal.Location = New Point(1396, 426)
        InfoSubvencioReal.Name = "InfoSubvencioReal"
        InfoSubvencioReal.ReadOnly = True
        InfoSubvencioReal.Size = New Size(81, 33)
        InfoSubvencioReal.TabIndex = 92
        InfoSubvencioReal.TabStop = False
        InfoSubvencioReal.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label19
        ' 
        Label19.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label19.AutoSize = True
        Label19.Location = New Point(1393, 408)
        Label19.Name = "Label19"
        Label19.Size = New Size(84, 15)
        Label19.TabIndex = 91
        Label19.Text = "Subvenció real"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = SystemColors.ControlLight
        GroupBox3.Controls.Add(Label23)
        GroupBox3.Controls.Add(TB_ImportBono)
        GroupBox3.Controls.Add(Label22)
        GroupBox3.Controls.Add(TB_CodiBono)
        GroupBox3.Controls.Add(Label21)
        GroupBox3.Controls.Add(Label20)
        GroupBox3.Controls.Add(TB_CaducitatConcessio)
        GroupBox3.Controls.Add(DataConcessio)
        GroupBox3.Controls.Add(CB_DataConcessio)
        GroupBox3.Location = New Point(28, 552)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(313, 189)
        GroupBox3.TabIndex = 94
        GroupBox3.TabStop = False
        GroupBox3.Text = "Dades concessió bono"
        ' 
        ' Label23
        ' 
        Label23.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label23.AutoSize = True
        Label23.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label23.Location = New Point(191, 135)
        Label23.Name = "Label23"
        Label23.Size = New Size(18, 20)
        Label23.TabIndex = 102
        Label23.Text = "€"
        ' 
        ' TB_ImportBono
        ' 
        TB_ImportBono.Location = New Point(85, 132)
        TB_ImportBono.Name = "TB_ImportBono"
        TB_ImportBono.Size = New Size(100, 23)
        TB_ImportBono.TabIndex = 103
        TB_ImportBono.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Location = New Point(16, 135)
        Label22.Name = "Label22"
        Label22.Size = New Size(55, 15)
        Label22.TabIndex = 101
        Label22.Text = "Concedit"
        ' 
        ' TB_CodiBono
        ' 
        TB_CodiBono.Location = New Point(85, 99)
        TB_CodiBono.Name = "TB_CodiBono"
        TB_CodiBono.Size = New Size(211, 23)
        TB_CodiBono.TabIndex = 2
        TB_CodiBono.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(16, 102)
        Label21.Name = "Label21"
        Label21.Size = New Size(63, 15)
        Label21.TabIndex = 99
        Label21.Text = "Codi Bono"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(31, 66)
        Label20.Name = "Label20"
        Label20.Size = New Size(113, 15)
        Label20.TabIndex = 98
        Label20.Text = "Caducitat concessió"
        ' 
        ' TB_CaducitatConcessio
        ' 
        TB_CaducitatConcessio.Location = New Point(165, 63)
        TB_CaducitatConcessio.Name = "TB_CaducitatConcessio"
        TB_CaducitatConcessio.ReadOnly = True
        TB_CaducitatConcessio.Size = New Size(131, 23)
        TB_CaducitatConcessio.TabIndex = 1
        ' 
        ' DataConcessio
        ' 
        DataConcessio.Format = DateTimePickerFormat.Short
        DataConcessio.Location = New Point(165, 34)
        DataConcessio.Name = "DataConcessio"
        DataConcessio.Size = New Size(131, 23)
        DataConcessio.TabIndex = 0
        DataConcessio.Visible = False
        ' 
        ' CB_DataConcessio
        ' 
        CB_DataConcessio.AutoSize = True
        CB_DataConcessio.Location = New Point(16, 35)
        CB_DataConcessio.Name = "CB_DataConcessio"
        CB_DataConcessio.Size = New Size(105, 19)
        CB_DataConcessio.TabIndex = 95
        CB_DataConcessio.Text = "Data concessió"
        CB_DataConcessio.UseVisualStyleBackColor = True
        ' 
        ' TB_CercaEmpreses
        ' 
        TB_CercaEmpreses.Location = New Point(360, 35)
        TB_CercaEmpreses.Name = "TB_CercaEmpreses"
        TB_CercaEmpreses.Size = New Size(182, 23)
        TB_CercaEmpreses.TabIndex = 0
        ' 
        ' PB_EliminaFiltre
        ' 
        PB_EliminaFiltre.Image = My.Resources.Resources.icono_eliminar
        PB_EliminaFiltre.Location = New Point(549, 35)
        PB_EliminaFiltre.Name = "PB_EliminaFiltre"
        PB_EliminaFiltre.Size = New Size(20, 24)
        PB_EliminaFiltre.SizeMode = PictureBoxSizeMode.Zoom
        PB_EliminaFiltre.TabIndex = 96
        PB_EliminaFiltre.TabStop = False
        ' 
        ' Label24
        ' 
        Label24.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label24.AutoSize = True
        Label24.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label24.Location = New Point(1480, 368)
        Label24.Name = "Label24"
        Label24.Size = New Size(18, 20)
        Label24.TabIndex = 98
        Label24.Text = "€"
        ' 
        ' TB_BonusRestant
        ' 
        TB_BonusRestant.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TB_BonusRestant.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TB_BonusRestant.Location = New Point(1396, 367)
        TB_BonusRestant.Name = "TB_BonusRestant"
        TB_BonusRestant.ReadOnly = True
        TB_BonusRestant.Size = New Size(81, 29)
        TB_BonusRestant.TabIndex = 97
        TB_BonusRestant.TabStop = False
        TB_BonusRestant.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label25
        ' 
        Label25.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label25.AutoSize = True
        Label25.Location = New Point(1396, 350)
        Label25.Name = "Label25"
        Label25.Size = New Size(79, 15)
        Label25.TabIndex = 99
        Label25.Text = "Bonus restant"
        ' 
        ' TitolJustificacio
        ' 
        TitolJustificacio.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TitolJustificacio.AutoSize = True
        TitolJustificacio.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        TitolJustificacio.ImageAlign = ContentAlignment.MiddleRight
        TitolJustificacio.Location = New Point(1317, 571)
        TitolJustificacio.Name = "TitolJustificacio"
        TitolJustificacio.Size = New Size(177, 13)
        TitolJustificacio.TabIndex = 101
        TitolJustificacio.Text = "Data màxima per fer la 2ª justificació"
        TitolJustificacio.TextAlign = ContentAlignment.MiddleLeft
        TitolJustificacio.Visible = False
        ' 
        ' DataFiJustificacio
        ' 
        DataFiJustificacio.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        DataFiJustificacio.Location = New Point(1505, 561)
        DataFiJustificacio.Name = "DataFiJustificacio"
        DataFiJustificacio.ReadOnly = True
        DataFiJustificacio.Size = New Size(118, 23)
        DataFiJustificacio.TabIndex = 100
        DataFiJustificacio.TextAlign = HorizontalAlignment.Center
        DataFiJustificacio.Visible = False
        ' 
        ' btn_importarEmpreses
        ' 
        btn_importarEmpreses.BackgroundImage = My.Resources.Resources._4202106excellogomicrosoftms_115582_115719
        btn_importarEmpreses.BackgroundImageLayout = ImageLayout.Zoom
        btn_importarEmpreses.Location = New Point(28, 13)
        btn_importarEmpreses.Name = "btn_importarEmpreses"
        btn_importarEmpreses.Size = New Size(40, 40)
        btn_importarEmpreses.TabIndex = 102
        btn_importarEmpreses.UseVisualStyleBackColor = True
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(74, 23)
        Label15.Name = "Label15"
        Label15.Size = New Size(106, 15)
        Label15.TabIndex = 103
        Label15.Text = "Importar empreses"
        ' 
        ' Retraso
        ' 
        Retraso.Enabled = True
        Retraso.Interval = 1000
        ' 
        ' Contractes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        AutoScrollMinSize = New Size(1657, 947)
        ClientSize = New Size(1653, 956)
        Controls.Add(Label15)
        Controls.Add(TBObservacions)
        Controls.Add(Panel1)
        Controls.Add(btn_importarEmpreses)
        Controls.Add(TitolJustificacio)
        Controls.Add(DataFiJustificacio)
        Controls.Add(Label25)
        Controls.Add(Label24)
        Controls.Add(TB_BonusRestant)
        Controls.Add(PB_EliminaFiltre)
        Controls.Add(TB_CercaEmpreses)
        Controls.Add(GroupBox3)
        Controls.Add(Label14)
        Controls.Add(InfoSubvencioReal)
        Controls.Add(Label19)
        Controls.Add(DataConcessioOK)
        Controls.Add(DataFiConcessio)
        Controls.Add(TitolAprovacio)
        Controls.Add(GroupBox2)
        Controls.Add(Panel2)
        Controls.Add(Label18)
        Controls.Add(InfoSubvencio)
        Controls.Add(CheckJustificat)
        Controls.Add(Label17)
        Controls.Add(infoMax)
        Controls.Add(DataEmpreses)
        Controls.Add(InfoVariableNum)
        Controls.Add(InfoVariable)
        Controls.Add(TitolFactura)
        Controls.Add(DataFacturaOK)
        Controls.Add(DataFiFactura)
        Controls.Add(CB_DataFactura)
        Controls.Add(DataFactura)
        Controls.Add(DataPagamentOK)
        Controls.Add(DataContracteOK)
        Controls.Add(btn_EsborrarSeleccioEmpresa)
        Controls.Add(CB_DataAprovacio)
        Controls.Add(CB_DataPagamentIVA)
        Controls.Add(CB_DataContracte)
        Controls.Add(DataFiContracte)
        Controls.Add(TitolContracte)
        Controls.Add(DataPagament)
        Controls.Add(DataAprovacio)
        Controls.Add(Label16)
        Controls.Add(Btn_EstatJustificacio)
        Controls.Add(TitolSolucio)
        Controls.Add(TitolEmpresa)
        Controls.Add(Btn_EsborrarSolucio)
        Controls.Add(Btn_EsborrarSeleccioSolucio)
        Controls.Add(DataContracte)
        Controls.Add(Btn_AfegirSolucio)
        Controls.Add(NoAcord)
        Controls.Add(CB_TipusSolucio)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(DataSolucions)
        Controls.Add(Btn_esborrarEmpresa)
        Controls.Add(Btn_afegir)
        Controls.Add(GroupBox1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Contractes"
        Text = "Contractes"
        CType(DataEmpreses, ComponentModel.ISupportInitialize).EndInit()
        CType(DataSolucions, ComponentModel.ISupportInitialize).EndInit()
        CType(verificat, ComponentModel.ISupportInitialize).EndInit()
        CType(DataContracteOK, ComponentModel.ISupportInitialize).EndInit()
        CType(DataPagamentOK, ComponentModel.ISupportInitialize).EndInit()
        CType(DataFacturaOK, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(InfoVariableNum, ComponentModel.ISupportInitialize).EndInit()
        CType(Pagat1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        GroupBox2.ResumeLayout(False)
        CType(DataConcessioOK, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(PB_EliminaFiltre, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataEmpreses As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Empresa As TextBox
    Friend WithEvents Nif As TextBox
    Friend WithEvents Direccio As TextBox
    Friend WithEvents CodiPostal As TextBox
    Friend WithEvents Ciutat As TextBox
    Friend WithEvents Provincia As TextBox
    Friend WithEvents Pais As TextBox
    Friend WithEvents Btn_afegir As Button
    Friend WithEvents Btn_esborrarEmpresa As Button
    Friend WithEvents btn_EsborrarSeleccioEmpresa As Button
    Friend WithEvents DataSolucions As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents CB_TipusSolucio As ComboBox
    Friend WithEvents NoAcord As TextBox
    Friend WithEvents DiesCaducitat As TextBox
    Friend WithEvents Btn_AfegirSolucio As Button
    Friend WithEvents DataContracte As DateTimePicker
    Friend WithEvents Btn_EsborrarSeleccioSolucio As Button
    Friend WithEvents Btn_EsborrarSolucio As Button
    Friend WithEvents TitolEmpresa As TextBox
    Friend WithEvents TitolSolucio As TextBox
    Friend WithEvents CheckJustificat As CheckBox
    Friend WithEvents CheckEstaJustificat As CheckBox
    Friend WithEvents Btn_EstatJustificacio As Button
    Friend WithEvents TBObservacions As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents verificat As PictureBox
    Friend WithEvents ContextMenuEsborrar As ContextMenuStrip
    Friend WithEvents DataAprovacio As DateTimePicker
    Friend WithEvents DataPagament As DateTimePicker
    Friend WithEvents TitolContracte As Label
    Friend WithEvents DataFiContracte As TextBox
    Friend WithEvents CB_DataContracte As CheckBox
    Friend WithEvents CB_DataPagamentIVA As CheckBox
    Friend WithEvents CB_DataAprovacio As CheckBox
    Friend WithEvents DataContracteOK As PictureBox
    Friend WithEvents DataPagamentOK As PictureBox
    Friend WithEvents DataCaducitat As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents CB_DataFactura As CheckBox
    Friend WithEvents DataFactura As DateTimePicker
    Friend WithEvents DataFacturaOK As PictureBox
    Friend WithEvents DataFiFactura As TextBox
    Friend WithEvents TitolFactura As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RB_Segment3 As RadioButton
    Friend WithEvents RB_Segment2 As RadioButton
    Friend WithEvents RB_Segment1 As RadioButton
    Friend WithEvents Label12 As Label
    Friend WithEvents InfoVariable As Label
    Friend WithEvents InfoVariableNum As NumericUpDown
    Friend WithEvents infoMax As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents InfoSubvencio As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents CB_PagamentFet As CheckBox
    Friend WithEvents Pagat1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataFiConcessio As TextBox
    Friend WithEvents TitolAprovacio As Label
    Friend WithEvents DataConcessioOK As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents InfoSubvencioReal As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label23 As Label
    Friend WithEvents TB_ImportBono As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents TB_CodiBono As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TB_CaducitatConcessio As TextBox
    Friend WithEvents DataConcessio As DateTimePicker
    Friend WithEvents CB_DataConcessio As CheckBox
    Friend WithEvents TB_CercaEmpreses As TextBox
    Friend WithEvents PB_EliminaFiltre As PictureBox
    Friend WithEvents Label24 As Label
    Friend WithEvents TB_BonusRestant As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents TitolJustificacio As Label
    Friend WithEvents DataFiJustificacio As TextBox
    Friend WithEvents Lbl_tipus As Label
    Friend WithEvents Lbl_estat As Label
    Friend WithEvents RB_Segment5 As RadioButton
    Friend WithEvents RB_Segment4 As RadioButton
    Friend WithEvents btn_importarEmpreses As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Retraso As Timer
End Class
