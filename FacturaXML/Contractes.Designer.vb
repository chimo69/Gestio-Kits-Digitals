<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Contractes))
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
        ProgressBar1 = New ProgressBar()
        Label15 = New Label()
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
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        TB_DataAvui = New TextBox()
        TB_Hora = New TextBox()
        Timer1 = New Timer(components)
        GroupBox1 = New GroupBox()
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
        CB_PrimerPagament = New CheckBox()
        CB_SegonPagament = New CheckBox()
        Pagat1 = New PictureBox()
        Pagat2 = New PictureBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        GroupBox2 = New GroupBox()
        TB_Proces0 = New TextBox()
        TB_Proces4 = New TextBox()
        TB_Proces6 = New TextBox()
        TB_Proces5 = New TextBox()
        TB_Proces3 = New TextBox()
        TB_Proces2 = New TextBox()
        TB_Proces1 = New TextBox()
        CType(DataEmpreses, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataSolucions, ComponentModel.ISupportInitialize).BeginInit()
        CType(verificat, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataContracteOK, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataPagamentOK, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataFacturaOK, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(InfoVariableNum, ComponentModel.ISupportInitialize).BeginInit()
        CType(Pagat1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Pagat2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        GroupBox2.SuspendLayout()
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
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataEmpreses.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataEmpreses.ColumnHeadersHeight = 30
        DataEmpreses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataEmpreses.EditMode = DataGridViewEditMode.EditProgrammatically
        DataEmpreses.EnableHeadersVisualStyles = False
        DataEmpreses.Location = New Point(360, 65)
        DataEmpreses.MultiSelect = False
        DataEmpreses.Name = "DataEmpreses"
        DataEmpreses.ReadOnly = True
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DataEmpreses.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataEmpreses.RowHeadersVisible = False
        DataEmpreses.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        DataEmpreses.RowsDefaultCellStyle = DataGridViewCellStyle4
        DataEmpreses.RowTemplate.Height = 25
        DataEmpreses.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataEmpreses.ShowEditingIcon = False
        DataEmpreses.Size = New Size(620, 930)
        DataEmpreses.TabIndex = 0
        DataEmpreses.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(13, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 15)
        Label1.TabIndex = 1
        Label1.Text = "Empresa"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(13, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(25, 15)
        Label2.TabIndex = 2
        Label2.Text = "NIF"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(13, 123)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 15)
        Label3.TabIndex = 3
        Label3.Text = "Direcció"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(13, 165)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 15)
        Label4.TabIndex = 4
        Label4.Text = "Codi Postal"' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(13, 207)
        Label5.Name = "Label5"
        Label5.Size = New Size(39, 15)
        Label5.TabIndex = 5
        Label5.Text = "Ciutat"' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(13, 249)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 15)
        Label6.TabIndex = 6
        Label6.Text = "Provincia"' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(13, 291)
        Label7.Name = "Label7"
        Label7.Size = New Size(28, 15)
        Label7.TabIndex = 7
        Label7.Text = "Pais"' 
        ' Empresa
        ' 
        Empresa.CharacterCasing = CharacterCasing.Upper
        Empresa.Location = New Point(68, 31)
        Empresa.Name = "Empresa"
        Empresa.Size = New Size(225, 23)
        Empresa.TabIndex = 1
        ' 
        ' Nif
        ' 
        Nif.CharacterCasing = CharacterCasing.Upper
        Nif.Location = New Point(68, 73)
        Nif.Name = "Nif"
        Nif.Size = New Size(93, 23)
        Nif.TabIndex = 2
        ' 
        ' Direccio
        ' 
        Direccio.CharacterCasing = CharacterCasing.Upper
        Direccio.Location = New Point(68, 115)
        Direccio.Name = "Direccio"
        Direccio.Size = New Size(225, 23)
        Direccio.TabIndex = 3
        Direccio.Tag = ""' 
        ' CodiPostal
        ' 
        CodiPostal.CharacterCasing = CharacterCasing.Upper
        CodiPostal.Location = New Point(97, 157)
        CodiPostal.Name = "CodiPostal"
        CodiPostal.Size = New Size(85, 23)
        CodiPostal.TabIndex = 4
        CodiPostal.Tag = ""' 
        ' Ciutat
        ' 
        Ciutat.CharacterCasing = CharacterCasing.Upper
        Ciutat.Location = New Point(68, 199)
        Ciutat.Name = "Ciutat"
        Ciutat.Size = New Size(225, 23)
        Ciutat.TabIndex = 5
        ' 
        ' Provincia
        ' 
        Provincia.CharacterCasing = CharacterCasing.Upper
        Provincia.Location = New Point(87, 241)
        Provincia.Name = "Provincia"
        Provincia.Size = New Size(206, 23)
        Provincia.TabIndex = 6
        ' 
        ' Pais
        ' 
        Pais.CharacterCasing = CharacterCasing.Upper
        Pais.Location = New Point(68, 283)
        Pais.Name = "Pais"
        Pais.Size = New Size(225, 23)
        Pais.TabIndex = 7
        ' 
        ' Btn_afegir
        ' 
        Btn_afegir.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Btn_afegir.Location = New Point(31, 942)
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
        Btn_esborrarEmpresa.Location = New Point(193, 942)
        Btn_esborrarEmpresa.Name = "Btn_esborrarEmpresa"
        Btn_esborrarEmpresa.Size = New Size(148, 53)
        Btn_esborrarEmpresa.TabIndex = 10
        Btn_esborrarEmpresa.Text = "Esborrar empresa"
        Btn_esborrarEmpresa.UseVisualStyleBackColor = False
        ' 
        ' btn_EsborrarSeleccioEmpresa
        ' 
        btn_EsborrarSeleccioEmpresa.Location = New Point(31, 612)
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
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        DataSolucions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        DataSolucions.ColumnHeadersHeight = 30
        DataSolucions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.Window
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        DataSolucions.DefaultCellStyle = DataGridViewCellStyle6
        DataSolucions.EditMode = DataGridViewEditMode.EditProgrammatically
        DataSolucions.EnableHeadersVisualStyles = False
        DataSolucions.Location = New Point(1003, 65)
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
        DataSolucions.Size = New Size(618, 187)
        DataSolucions.TabIndex = 18
        DataSolucions.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Location = New Point(1043, 26)
        Label8.Name = "Label8"
        Label8.Size = New Size(64, 15)
        Label8.TabIndex = 20
        Label8.Text = "Contractes"' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.Location = New Point(1006, 279)
        Label9.Name = "Label9"
        Label9.Size = New Size(76, 15)
        Label9.TabIndex = 21
        Label9.Text = "Tipus solució"' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label10.AutoSize = True
        Label10.Location = New Point(1266, 363)
        Label10.Name = "Label10"
        Label10.Size = New Size(56, 15)
        Label10.TabIndex = 22
        Label10.Text = "Nº Acord"' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label13.AutoSize = True
        Label13.Location = New Point(5, 14)
        Label13.Name = "Label13"
        Label13.Size = New Size(81, 15)
        Label13.TabIndex = 25
        Label13.Text = "Dies caducitat"' 
        ' CB_TipusSolucio
        ' 
        CB_TipusSolucio.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        CB_TipusSolucio.Enabled = False
        CB_TipusSolucio.FormattingEnabled = True
        CB_TipusSolucio.Location = New Point(1138, 273)
        CB_TipusSolucio.Name = "CB_TipusSolucio"
        CB_TipusSolucio.Size = New Size(287, 23)
        CB_TipusSolucio.TabIndex = 11
        ' 
        ' NoAcord
        ' 
        NoAcord.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        NoAcord.CharacterCasing = CharacterCasing.Upper
        NoAcord.Enabled = False
        NoAcord.Location = New Point(1344, 357)
        NoAcord.Name = "NoAcord"
        NoAcord.Size = New Size(111, 23)
        NoAcord.TabIndex = 12
        NoAcord.TextAlign = HorizontalAlignment.Center
        ' 
        ' DiesCaducitat
        ' 
        DiesCaducitat.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        DiesCaducitat.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        DiesCaducitat.Location = New Point(131, 7)
        DiesCaducitat.Name = "DiesCaducitat"
        DiesCaducitat.ReadOnly = True
        DiesCaducitat.Size = New Size(112, 33)
        DiesCaducitat.TabIndex = 30
        DiesCaducitat.TabStop = False
        DiesCaducitat.TextAlign = HorizontalAlignment.Center
        ' 
        ' Btn_AfegirSolucio
        ' 
        Btn_AfegirSolucio.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Btn_AfegirSolucio.Enabled = False
        Btn_AfegirSolucio.Location = New Point(1325, 942)
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
        DataContracte.Location = New Point(1139, 400)
        DataContracte.Name = "DataContracte"
        DataContracte.Size = New Size(111, 23)
        DataContracte.TabIndex = 14
        DataContracte.Visible = False
        ' 
        ' Btn_EsborrarSeleccioSolucio
        ' 
        Btn_EsborrarSeleccioSolucio.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Btn_EsborrarSeleccioSolucio.Enabled = False
        Btn_EsborrarSeleccioSolucio.Location = New Point(1007, 942)
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
        Btn_EsborrarSolucio.Location = New Point(1477, 942)
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
        TitolEmpresa.Location = New Point(360, 23)
        TitolEmpresa.Multiline = True
        TitolEmpresa.Name = "TitolEmpresa"
        TitolEmpresa.PlaceholderText = "SELECCIONA EMPRESA"
        TitolEmpresa.ReadOnly = True
        TitolEmpresa.Size = New Size(620, 36)
        TitolEmpresa.TabIndex = 36
        TitolEmpresa.TextAlign = HorizontalAlignment.Center
        ' 
        ' TitolSolucio
        ' 
        TitolSolucio.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TitolSolucio.CharacterCasing = CharacterCasing.Upper
        TitolSolucio.Enabled = False
        TitolSolucio.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        TitolSolucio.Location = New Point(1003, 23)
        TitolSolucio.Multiline = True
        TitolSolucio.Name = "TitolSolucio"
        TitolSolucio.PlaceholderText = "SELECCIONA SOLUCIÓ"
        TitolSolucio.ReadOnly = True
        TitolSolucio.Size = New Size(618, 36)
        TitolSolucio.TabIndex = 37
        TitolSolucio.TextAlign = HorizontalAlignment.Center
        ' 
        ' CheckJustificat
        ' 
        CheckJustificat.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        CheckJustificat.AutoSize = True
        CheckJustificat.CheckAlign = ContentAlignment.MiddleRight
        CheckJustificat.Location = New Point(1501, 730)
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
        CheckEstaJustificat.Location = New Point(16, 6)
        CheckEstaJustificat.Name = "CheckEstaJustificat"
        CheckEstaJustificat.Size = New Size(72, 19)
        CheckEstaJustificat.TabIndex = 17
        CheckEstaJustificat.Text = "Justificat"
        CheckEstaJustificat.UseVisualStyleBackColor = True
        ' 
        ' Btn_EstatJustificacio
        ' 
        Btn_EstatJustificacio.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Btn_EstatJustificacio.Enabled = False
        Btn_EstatJustificacio.Location = New Point(1474, 273)
        Btn_EstatJustificacio.Name = "Btn_EstatJustificacio"
        Btn_EstatJustificacio.Size = New Size(147, 63)
        Btn_EstatJustificacio.TabIndex = 18
        Btn_EstatJustificacio.Text = "Veure estat de" & vbCrLf & "justificació"
        Btn_EstatJustificacio.UseVisualStyleBackColor = True
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ProgressBar1.Location = New Point(1006, 900)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(615, 30)
        ProgressBar1.Style = ProgressBarStyle.Continuous
        ProgressBar1.TabIndex = 42
        ' 
        ' Label15
        ' 
        Label15.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label15.AutoSize = True
        Label15.Location = New Point(1007, 880)
        Label15.Name = "Label15"
        Label15.Size = New Size(241, 15)
        Label15.TabIndex = 43
        Label15.Text = "Percentatge de preparació de documentació"' 
        ' TBObservacions
        ' 
        TBObservacions.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TBObservacions.Enabled = False
        TBObservacions.Location = New Point(1006, 811)
        TBObservacions.Multiline = True
        TBObservacions.Name = "TBObservacions"
        TBObservacions.Size = New Size(615, 61)
        TBObservacions.TabIndex = 20
        ' 
        ' Label16
        ' 
        Label16.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label16.AutoSize = True
        Label16.Location = New Point(1007, 793)
        Label16.Name = "Label16"
        Label16.Size = New Size(78, 15)
        Label16.TabIndex = 45
        Label16.Text = "Observacions"' 
        ' verificat
        ' 
        verificat.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        verificat.BackColor = Color.Transparent
        verificat.BackgroundImageLayout = ImageLayout.None
        verificat.Image = My.Resources.Resources.verificado
        verificat.Location = New Point(217, 10)
        verificat.Name = "verificat"
        verificat.Size = New Size(57, 58)
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
        DataAprovacio.Format = DateTimePickerFormat.Short
        DataAprovacio.Location = New Point(1139, 361)
        DataAprovacio.Name = "DataAprovacio"
        DataAprovacio.Size = New Size(111, 23)
        DataAprovacio.TabIndex = 13
        DataAprovacio.Visible = False
        ' 
        ' DataPagament
        ' 
        DataPagament.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        DataPagament.Format = DateTimePickerFormat.Short
        DataPagament.Location = New Point(1139, 483)
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
        TitolContracte.Location = New Point(1294, 404)
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
        DataFiContracte.Location = New Point(1503, 400)
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
        CB_DataContracte.Location = New Point(1006, 400)
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
        CB_DataPagamentIVA.Location = New Point(1006, 483)
        CB_DataPagamentIVA.Name = "CB_DataPagamentIVA"
        CB_DataPagamentIVA.Size = New Size(127, 19)
        CB_DataPagamentIVA.TabIndex = 58
        CB_DataPagamentIVA.Text = "Data pagament IVA"
        CB_DataPagamentIVA.UseVisualStyleBackColor = True
        ' 
        ' CB_DataAprovacio
        ' 
        CB_DataAprovacio.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        CB_DataAprovacio.AutoSize = True
        CB_DataAprovacio.Enabled = False
        CB_DataAprovacio.Location = New Point(1007, 361)
        CB_DataAprovacio.Name = "CB_DataAprovacio"
        CB_DataAprovacio.Size = New Size(107, 19)
        CB_DataAprovacio.TabIndex = 59
        CB_DataAprovacio.Text = "Data Aprovació"
        CB_DataAprovacio.UseVisualStyleBackColor = True
        ' 
        ' DataContracteOK
        ' 
        DataContracteOK.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        DataContracteOK.Image = My.Resources.Resources.verificado_petit
        DataContracteOK.Location = New Point(1260, 399)
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
        DataPagamentOK.Location = New Point(1260, 482)
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
        DataCaducitat.Location = New Point(404, 7)
        DataCaducitat.Name = "DataCaducitat"
        DataCaducitat.ReadOnly = True
        DataCaducitat.Size = New Size(180, 33)
        DataCaducitat.TabIndex = 63
        DataCaducitat.TabStop = False
        DataCaducitat.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label11.AutoSize = True
        Label11.Location = New Point(308, 15)
        Label11.Name = "Label11"
        Label11.Size = New Size(83, 15)
        Label11.TabIndex = 64
        Label11.Text = "Data caducitat"' 
        ' CB_DataFactura
        ' 
        CB_DataFactura.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        CB_DataFactura.AutoSize = True
        CB_DataFactura.Enabled = False
        CB_DataFactura.Location = New Point(1006, 441)
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
        DataFactura.Location = New Point(1139, 441)
        DataFactura.Name = "DataFactura"
        DataFactura.Size = New Size(111, 23)
        DataFactura.TabIndex = 15
        DataFactura.Visible = False
        ' 
        ' DataFacturaOK
        ' 
        DataFacturaOK.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        DataFacturaOK.Image = My.Resources.Resources.verificado_petit
        DataFacturaOK.Location = New Point(1260, 441)
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
        DataFiFactura.Location = New Point(1502, 442)
        DataFiFactura.Name = "DataFiFactura"
        DataFiFactura.ReadOnly = True
        DataFiFactura.Size = New Size(119, 23)
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
        TitolFactura.Location = New Point(1336, 448)
        TitolFactura.Name = "TitolFactura"
        TitolFactura.Size = New Size(164, 13)
        TitolFactura.TabIndex = 69
        TitolFactura.Text = "Data màxima per fer la justificació"
        TitolFactura.TextAlign = ContentAlignment.MiddleLeft
        TitolFactura.Visible = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logo_telematic
        PictureBox1.Location = New Point(31, 23)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(204, 68)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 70
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.Ayudas_Kit_Digital__Pequeño_
        PictureBox2.Location = New Point(241, 23)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(100, 68)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 71
        PictureBox2.TabStop = False
        ' 
        ' TB_DataAvui
        ' 
        TB_DataAvui.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TB_DataAvui.Location = New Point(31, 97)
        TB_DataAvui.Name = "TB_DataAvui"
        TB_DataAvui.ReadOnly = True
        TB_DataAvui.Size = New Size(204, 25)
        TB_DataAvui.TabIndex = 72
        TB_DataAvui.TextAlign = HorizontalAlignment.Center
        ' 
        ' TB_Hora
        ' 
        TB_Hora.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TB_Hora.Location = New Point(241, 97)
        TB_Hora.Name = "TB_Hora"
        TB_Hora.ReadOnly = True
        TB_Hora.Size = New Size(100, 25)
        TB_Hora.TabIndex = 73
        TB_Hora.TextAlign = HorizontalAlignment.Center
        ' 
        ' Timer1
        ' 
        ' 
        ' GroupBox1
        ' 
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
        GroupBox1.Location = New Point(31, 171)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(310, 414)
        GroupBox1.TabIndex = 74
        GroupBox1.TabStop = False
        GroupBox1.Text = "Dades de l'empresa"' 
        ' RB_Segment3
        ' 
        RB_Segment3.AutoSize = True
        RB_Segment3.Location = New Point(85, 381)
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
        RB_Segment2.Location = New Point(85, 356)
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
        RB_Segment1.TabIndex = 9
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
        Label12.Text = "Segment"' 
        ' InfoVariable
        ' 
        InfoVariable.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        InfoVariable.AutoSize = True
        InfoVariable.Location = New Point(1006, 313)
        InfoVariable.Name = "InfoVariable"
        InfoVariable.Size = New Size(72, 15)
        InfoVariable.TabIndex = 75
        InfoVariable.Text = "Info variable"
        InfoVariable.Visible = False
        ' 
        ' InfoVariableNum
        ' 
        InfoVariableNum.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        InfoVariableNum.Location = New Point(1138, 307)
        InfoVariableNum.Name = "InfoVariableNum"
        InfoVariableNum.Size = New Size(47, 23)
        InfoVariableNum.TabIndex = 76
        InfoVariableNum.Visible = False
        ' 
        ' infoMax
        ' 
        infoMax.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        infoMax.AutoSize = True
        infoMax.Location = New Point(1191, 311)
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
        Label17.Location = New Point(1276, 304)
        Label17.Name = "Label17"
        Label17.Size = New Size(62, 30)
        Label17.TabIndex = 78
        Label17.Text = "Subvenció" & vbCrLf & "teórica"' 
        ' InfoSubvencio
        ' 
        InfoSubvencio.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        InfoSubvencio.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        InfoSubvencio.Location = New Point(1344, 303)
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
        Label18.Location = New Point(1431, 310)
        Label18.Name = "Label18"
        Label18.Size = New Size(18, 20)
        Label18.TabIndex = 80
        Label18.Text = "€"' 
        ' CB_PrimerPagament
        ' 
        CB_PrimerPagament.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        CB_PrimerPagament.AutoSize = True
        CB_PrimerPagament.Enabled = False
        CB_PrimerPagament.Location = New Point(16, 33)
        CB_PrimerPagament.Name = "CB_PrimerPagament"
        CB_PrimerPagament.Size = New Size(118, 19)
        CB_PrimerPagament.TabIndex = 81
        CB_PrimerPagament.Text = "Primer pagament"
        CB_PrimerPagament.UseVisualStyleBackColor = True
        ' 
        ' CB_SegonPagament
        ' 
        CB_SegonPagament.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        CB_SegonPagament.AutoSize = True
        CB_SegonPagament.Enabled = False
        CB_SegonPagament.Location = New Point(16, 60)
        CB_SegonPagament.Name = "CB_SegonPagament"
        CB_SegonPagament.Size = New Size(116, 19)
        CB_SegonPagament.TabIndex = 82
        CB_SegonPagament.Text = "Segon pagament"
        CB_SegonPagament.UseVisualStyleBackColor = True
        ' 
        ' Pagat1
        ' 
        Pagat1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Pagat1.BackColor = Color.Transparent
        Pagat1.BackgroundImageLayout = ImageLayout.None
        Pagat1.Image = My.Resources.Resources.icons8_euro_banknote_96
        Pagat1.Location = New Point(280, 10)
        Pagat1.Name = "Pagat1"
        Pagat1.Size = New Size(57, 58)
        Pagat1.SizeMode = PictureBoxSizeMode.Zoom
        Pagat1.TabIndex = 83
        Pagat1.TabStop = False
        Pagat1.Visible = False
        ' 
        ' Pagat2
        ' 
        Pagat2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Pagat2.BackColor = Color.Transparent
        Pagat2.BackgroundImageLayout = ImageLayout.None
        Pagat2.Image = My.Resources.Resources.icons8_euro_banknote_96
        Pagat2.Location = New Point(343, 10)
        Pagat2.Name = "Pagat2"
        Pagat2.Size = New Size(57, 58)
        Pagat2.SizeMode = PictureBoxSizeMode.Zoom
        Pagat2.TabIndex = 84
        Pagat2.TabStop = False
        Pagat2.Visible = False
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Panel1.BackColor = Color.LightGray
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(CheckEstaJustificat)
        Panel1.Controls.Add(verificat)
        Panel1.Controls.Add(Pagat2)
        Panel1.Controls.Add(CB_PrimerPagament)
        Panel1.Controls.Add(Pagat1)
        Panel1.Controls.Add(CB_SegonPagament)
        Panel1.Location = New Point(1006, 696)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(487, 83)
        Panel1.TabIndex = 85
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Panel2.BackColor = Color.Pink
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(DataCaducitat)
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(DiesCaducitat)
        Panel2.Controls.Add(Label11)
        Panel2.Location = New Point(1006, 538)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(615, 48)
        Panel2.TabIndex = 86
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        GroupBox2.Controls.Add(TB_Proces0)
        GroupBox2.Controls.Add(TB_Proces4)
        GroupBox2.Controls.Add(TB_Proces6)
        GroupBox2.Controls.Add(TB_Proces5)
        GroupBox2.Controls.Add(TB_Proces3)
        GroupBox2.Controls.Add(TB_Proces2)
        GroupBox2.Controls.Add(TB_Proces1)
        GroupBox2.Location = New Point(1006, 597)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(614, 82)
        GroupBox2.TabIndex = 87
        GroupBox2.TabStop = False
        GroupBox2.Text = "Procés de justificació"' 
        ' TB_Proces0
        ' 
        TB_Proces0.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TB_Proces0.BackColor = SystemColors.Control
        TB_Proces0.Enabled = False
        TB_Proces0.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TB_Proces0.Location = New Point(76, 22)
        TB_Proces0.Name = "TB_Proces0"
        TB_Proces0.ReadOnly = True
        TB_Proces0.Size = New Size(195, 22)
        TB_Proces0.TabIndex = 6
        TB_Proces0.Text = "Preparant documentació"
        TB_Proces0.TextAlign = HorizontalAlignment.Center
        ' 
        ' TB_Proces4
        ' 
        TB_Proces4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TB_Proces4.BackColor = SystemColors.Control
        TB_Proces4.Enabled = False
        TB_Proces4.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TB_Proces4.Location = New Point(76, 49)
        TB_Proces4.Name = "TB_Proces4"
        TB_Proces4.ReadOnly = True
        TB_Proces4.Size = New Size(199, 22)
        TB_Proces4.TabIndex = 5
        TB_Proces4.Text = "Termini d'esmena obert"
        TB_Proces4.TextAlign = HorizontalAlignment.Center
        ' 
        ' TB_Proces6
        ' 
        TB_Proces6.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TB_Proces6.BackColor = SystemColors.Control
        TB_Proces6.Enabled = False
        TB_Proces6.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TB_Proces6.Location = New Point(476, 49)
        TB_Proces6.Name = "TB_Proces6"
        TB_Proces6.ReadOnly = True
        TB_Proces6.Size = New Size(69, 22)
        TB_Proces6.TabIndex = 4
        TB_Proces6.Text = "Pagada"
        TB_Proces6.TextAlign = HorizontalAlignment.Center
        ' 
        ' TB_Proces5
        ' 
        TB_Proces5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TB_Proces5.BackColor = SystemColors.Control
        TB_Proces5.Enabled = False
        TB_Proces5.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TB_Proces5.Location = New Point(281, 49)
        TB_Proces5.Name = "TB_Proces5"
        TB_Proces5.ReadOnly = True
        TB_Proces5.Size = New Size(189, 22)
        TB_Proces5.TabIndex = 3
        TB_Proces5.Text = "Validada per pagament"
        TB_Proces5.TextAlign = HorizontalAlignment.Center
        ' 
        ' TB_Proces3
        ' 
        TB_Proces3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TB_Proces3.BackColor = SystemColors.Control
        TB_Proces3.Enabled = False
        TB_Proces3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TB_Proces3.Location = New Point(447, 22)
        TB_Proces3.Name = "TB_Proces3"
        TB_Proces3.ReadOnly = True
        TB_Proces3.Size = New Size(98, 22)
        TB_Proces3.TabIndex = 2
        TB_Proces3.Text = "Presentada"
        TB_Proces3.TextAlign = HorizontalAlignment.Center
        ' 
        ' TB_Proces2
        ' 
        TB_Proces2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TB_Proces2.BackColor = SystemColors.Control
        TB_Proces2.Enabled = False
        TB_Proces2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TB_Proces2.Location = New Point(350, 22)
        TB_Proces2.Name = "TB_Proces2"
        TB_Proces2.ReadOnly = True
        TB_Proces2.Size = New Size(91, 22)
        TB_Proces2.TabIndex = 1
        TB_Proces2.Text = "Esborrany"
        TB_Proces2.TextAlign = HorizontalAlignment.Center
        ' 
        ' TB_Proces1
        ' 
        TB_Proces1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TB_Proces1.BackColor = SystemColors.Control
        TB_Proces1.Enabled = False
        TB_Proces1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TB_Proces1.Location = New Point(277, 22)
        TB_Proces1.Name = "TB_Proces1"
        TB_Proces1.ReadOnly = True
        TB_Proces1.Size = New Size(67, 22)
        TB_Proces1.TabIndex = 0
        TB_Proces1.Text = "Enviada"
        TB_Proces1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Contractes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1641, 1025)
        Controls.Add(GroupBox2)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label18)
        Controls.Add(InfoSubvencio)
        Controls.Add(CheckJustificat)
        Controls.Add(Label17)
        Controls.Add(infoMax)
        Controls.Add(InfoVariableNum)
        Controls.Add(InfoVariable)
        Controls.Add(TB_Hora)
        Controls.Add(TB_DataAvui)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
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
        Controls.Add(TBObservacions)
        Controls.Add(Label15)
        Controls.Add(ProgressBar1)
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
        Controls.Add(DataEmpreses)
        Controls.Add(GroupBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(1657, 1017)
        Name = "Contractes"
        Text = "Contractes"
        WindowState = FormWindowState.Maximized
        CType(DataEmpreses, ComponentModel.ISupportInitialize).EndInit()
        CType(DataSolucions, ComponentModel.ISupportInitialize).EndInit()
        CType(verificat, ComponentModel.ISupportInitialize).EndInit()
        CType(DataContracteOK, ComponentModel.ISupportInitialize).EndInit()
        CType(DataPagamentOK, ComponentModel.ISupportInitialize).EndInit()
        CType(DataFacturaOK, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(InfoVariableNum, ComponentModel.ISupportInitialize).EndInit()
        CType(Pagat1, ComponentModel.ISupportInitialize).EndInit()
        CType(Pagat2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
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
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label15 As Label
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TB_DataAvui As TextBox
    Friend WithEvents TB_Hora As TextBox
    Friend WithEvents Timer1 As Timer
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
    Friend WithEvents CB_PrimerPagament As CheckBox
    Friend WithEvents CB_SegonPagament As CheckBox
    Friend WithEvents Pagat1 As PictureBox
    Friend WithEvents Pagat2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TB_Proces2 As TextBox
    Friend WithEvents TB_Proces1 As TextBox
    Friend WithEvents TB_Proces4 As TextBox
    Friend WithEvents TB_Proces6 As TextBox
    Friend WithEvents TB_Proces5 As TextBox
    Friend WithEvents TB_Proces3 As TextBox
    Friend WithEvents TB_Proces0 As TextBox
End Class
