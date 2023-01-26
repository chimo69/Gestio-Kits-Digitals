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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Contractes))
        Me.DataEmpreses = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Empresa = New System.Windows.Forms.TextBox()
        Me.Nif = New System.Windows.Forms.TextBox()
        Me.Direccio = New System.Windows.Forms.TextBox()
        Me.CodiPostal = New System.Windows.Forms.TextBox()
        Me.Ciutat = New System.Windows.Forms.TextBox()
        Me.Provincia = New System.Windows.Forms.TextBox()
        Me.Pais = New System.Windows.Forms.TextBox()
        Me.Btn_afegir = New System.Windows.Forms.Button()
        Me.Btn_esborrarEmpresa = New System.Windows.Forms.Button()
        Me.btn_EsborrarSeleccioEmpresa = New System.Windows.Forms.Button()
        Me.DataSolucions = New System.Windows.Forms.DataGridView()
        Me.Empreses = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CB_TipusSolucio = New System.Windows.Forms.ComboBox()
        Me.NoAcord = New System.Windows.Forms.TextBox()
        Me.DiesCaducitat = New System.Windows.Forms.TextBox()
        Me.Btn_AfegirSolucio = New System.Windows.Forms.Button()
        Me.DataContracte = New System.Windows.Forms.DateTimePicker()
        Me.DataFiAprovacio = New System.Windows.Forms.TextBox()
        Me.Btn_EsborrarSeleccioSolucio = New System.Windows.Forms.Button()
        Me.Btn_EsborrarSolucio = New System.Windows.Forms.Button()
        Me.TitolEmpresa = New System.Windows.Forms.TextBox()
        Me.TitolSolucio = New System.Windows.Forms.TextBox()
        Me.CheckJustificat = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CheckEstaJustificat = New System.Windows.Forms.CheckBox()
        Me.Btn_EstatJustificacio = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TBObservacions = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.verificat = New System.Windows.Forms.PictureBox()
        Me.ContextMenuEsborrar = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DataAprovacio = New System.Windows.Forms.DateTimePicker()
        Me.DataPagament = New System.Windows.Forms.DateTimePicker()
        Me.TitolAprovacio = New System.Windows.Forms.Label()
        Me.TitolContracte = New System.Windows.Forms.Label()
        Me.DataFiContracte = New System.Windows.Forms.TextBox()
        Me.TitolPagament = New System.Windows.Forms.Label()
        Me.DataFiPagament = New System.Windows.Forms.TextBox()
        Me.CB_DataContracte = New System.Windows.Forms.CheckBox()
        Me.CB_DataPagamentIVA = New System.Windows.Forms.CheckBox()
        Me.CB_DataAprovacio = New System.Windows.Forms.CheckBox()
        Me.DataAprovacioOK = New System.Windows.Forms.PictureBox()
        Me.DataContracteOK = New System.Windows.Forms.PictureBox()
        Me.DataPagamentOK = New System.Windows.Forms.PictureBox()
        CType(Me.DataEmpreses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSolucions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verificat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataAprovacioOK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataContracteOK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataPagamentOK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataEmpreses
        '
        Me.DataEmpreses.AllowUserToAddRows = False
        Me.DataEmpreses.AllowUserToDeleteRows = False
        Me.DataEmpreses.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataEmpreses.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataEmpreses.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataEmpreses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataEmpreses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataEmpreses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataEmpreses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataEmpreses.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataEmpreses.ColumnHeadersHeight = 30
        Me.DataEmpreses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataEmpreses.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataEmpreses.EnableHeadersVisualStyles = False
        Me.DataEmpreses.Location = New System.Drawing.Point(360, 65)
        Me.DataEmpreses.MultiSelect = False
        Me.DataEmpreses.Name = "DataEmpreses"
        Me.DataEmpreses.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataEmpreses.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataEmpreses.RowHeadersVisible = False
        Me.DataEmpreses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataEmpreses.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataEmpreses.RowTemplate.Height = 25
        Me.DataEmpreses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataEmpreses.ShowEditingIcon = False
        Me.DataEmpreses.Size = New System.Drawing.Size(620, 883)
        Me.DataEmpreses.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Empresa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NIF"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Direcció"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Codi Postal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 241)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Ciutat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 283)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Provincia"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 325)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 15)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Pais"
        '
        'Empresa
        '
        Me.Empresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Empresa.Location = New System.Drawing.Point(76, 65)
        Me.Empresa.Name = "Empresa"
        Me.Empresa.Size = New System.Drawing.Size(255, 23)
        Me.Empresa.TabIndex = 8
        '
        'Nif
        '
        Me.Nif.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Nif.Location = New System.Drawing.Point(76, 107)
        Me.Nif.Name = "Nif"
        Me.Nif.Size = New System.Drawing.Size(93, 23)
        Me.Nif.TabIndex = 9
        '
        'Direccio
        '
        Me.Direccio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Direccio.Location = New System.Drawing.Point(76, 149)
        Me.Direccio.Name = "Direccio"
        Me.Direccio.Size = New System.Drawing.Size(255, 23)
        Me.Direccio.TabIndex = 10
        '
        'CodiPostal
        '
        Me.CodiPostal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CodiPostal.Location = New System.Drawing.Point(105, 191)
        Me.CodiPostal.Name = "CodiPostal"
        Me.CodiPostal.Size = New System.Drawing.Size(85, 23)
        Me.CodiPostal.TabIndex = 11
        '
        'Ciutat
        '
        Me.Ciutat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Ciutat.Location = New System.Drawing.Point(76, 233)
        Me.Ciutat.Name = "Ciutat"
        Me.Ciutat.Size = New System.Drawing.Size(255, 23)
        Me.Ciutat.TabIndex = 12
        '
        'Provincia
        '
        Me.Provincia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Provincia.Location = New System.Drawing.Point(95, 275)
        Me.Provincia.Name = "Provincia"
        Me.Provincia.Size = New System.Drawing.Size(236, 23)
        Me.Provincia.TabIndex = 13
        '
        'Pais
        '
        Me.Pais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Pais.Location = New System.Drawing.Point(76, 317)
        Me.Pais.Name = "Pais"
        Me.Pais.Size = New System.Drawing.Size(255, 23)
        Me.Pais.TabIndex = 14
        '
        'Btn_afegir
        '
        Me.Btn_afegir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_afegir.Location = New System.Drawing.Point(31, 895)
        Me.Btn_afegir.Name = "Btn_afegir"
        Me.Btn_afegir.Size = New System.Drawing.Size(148, 53)
        Me.Btn_afegir.TabIndex = 15
        Me.Btn_afegir.Text = "Afegir empresa"
        Me.Btn_afegir.UseVisualStyleBackColor = True
        '
        'Btn_esborrarEmpresa
        '
        Me.Btn_esborrarEmpresa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_esborrarEmpresa.BackColor = System.Drawing.Color.IndianRed
        Me.Btn_esborrarEmpresa.Location = New System.Drawing.Point(193, 895)
        Me.Btn_esborrarEmpresa.Name = "Btn_esborrarEmpresa"
        Me.Btn_esborrarEmpresa.Size = New System.Drawing.Size(148, 53)
        Me.Btn_esborrarEmpresa.TabIndex = 16
        Me.Btn_esborrarEmpresa.Text = "Esborrar empresa"
        Me.Btn_esborrarEmpresa.UseVisualStyleBackColor = False
        '
        'btn_EsborrarSeleccioEmpresa
        '
        Me.btn_EsborrarSeleccioEmpresa.Location = New System.Drawing.Point(21, 372)
        Me.btn_EsborrarSeleccioEmpresa.Name = "btn_EsborrarSeleccioEmpresa"
        Me.btn_EsborrarSeleccioEmpresa.Size = New System.Drawing.Size(148, 54)
        Me.btn_EsborrarSeleccioEmpresa.TabIndex = 17
        Me.btn_EsborrarSeleccioEmpresa.Text = "Esborrar selecció"
        Me.btn_EsborrarSeleccioEmpresa.UseVisualStyleBackColor = True
        '
        'DataSolucions
        '
        Me.DataSolucions.AllowUserToAddRows = False
        Me.DataSolucions.AllowUserToDeleteRows = False
        Me.DataSolucions.AllowUserToResizeRows = False
        Me.DataSolucions.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataSolucions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataSolucions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataSolucions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataSolucions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataSolucions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataSolucions.ColumnHeadersHeight = 30
        Me.DataSolucions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataSolucions.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataSolucions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataSolucions.EnableHeadersVisualStyles = False
        Me.DataSolucions.Location = New System.Drawing.Point(1003, 65)
        Me.DataSolucions.MultiSelect = False
        Me.DataSolucions.Name = "DataSolucions"
        Me.DataSolucions.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataSolucions.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataSolucions.RowHeadersVisible = False
        Me.DataSolucions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DataSolucions.RowTemplate.Height = 25
        Me.DataSolucions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataSolucions.Size = New System.Drawing.Size(618, 233)
        Me.DataSolucions.TabIndex = 18
        '
        'Empreses
        '
        Me.Empreses.AutoSize = True
        Me.Empreses.Location = New System.Drawing.Point(21, 23)
        Me.Empreses.Name = "Empreses"
        Me.Empreses.Size = New System.Drawing.Size(57, 15)
        Me.Empreses.TabIndex = 19
        Me.Empreses.Text = "Empreses"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1043, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 15)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Contractes"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1007, 323)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 15)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Tipus solució"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(1007, 363)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 15)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Nº Acord"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(1007, 562)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 15)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Dies caducitat"
        '
        'CB_TipusSolucio
        '
        Me.CB_TipusSolucio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CB_TipusSolucio.Enabled = False
        Me.CB_TipusSolucio.FormattingEnabled = True
        Me.CB_TipusSolucio.Location = New System.Drawing.Point(1139, 317)
        Me.CB_TipusSolucio.Name = "CB_TipusSolucio"
        Me.CB_TipusSolucio.Size = New System.Drawing.Size(287, 23)
        Me.CB_TipusSolucio.TabIndex = 26
        '
        'NoAcord
        '
        Me.NoAcord.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NoAcord.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NoAcord.Enabled = False
        Me.NoAcord.Location = New System.Drawing.Point(1139, 357)
        Me.NoAcord.Name = "NoAcord"
        Me.NoAcord.Size = New System.Drawing.Size(217, 23)
        Me.NoAcord.TabIndex = 27
        '
        'DiesCaducitat
        '
        Me.DiesCaducitat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DiesCaducitat.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DiesCaducitat.Location = New System.Drawing.Point(1139, 556)
        Me.DiesCaducitat.Name = "DiesCaducitat"
        Me.DiesCaducitat.ReadOnly = True
        Me.DiesCaducitat.Size = New System.Drawing.Size(111, 33)
        Me.DiesCaducitat.TabIndex = 30
        Me.DiesCaducitat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Btn_AfegirSolucio
        '
        Me.Btn_AfegirSolucio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_AfegirSolucio.Enabled = False
        Me.Btn_AfegirSolucio.Location = New System.Drawing.Point(1323, 895)
        Me.Btn_AfegirSolucio.Name = "Btn_AfegirSolucio"
        Me.Btn_AfegirSolucio.Size = New System.Drawing.Size(146, 53)
        Me.Btn_AfegirSolucio.TabIndex = 31
        Me.Btn_AfegirSolucio.Text = "Modificar solució"
        Me.Btn_AfegirSolucio.UseVisualStyleBackColor = True
        '
        'DataContracte
        '
        Me.DataContracte.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataContracte.Enabled = False
        Me.DataContracte.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataContracte.Location = New System.Drawing.Point(1139, 439)
        Me.DataContracte.Name = "DataContracte"
        Me.DataContracte.Size = New System.Drawing.Size(111, 23)
        Me.DataContracte.TabIndex = 32
        '
        'DataFiAprovacio
        '
        Me.DataFiAprovacio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataFiAprovacio.Location = New System.Drawing.Point(1475, 399)
        Me.DataFiAprovacio.Name = "DataFiAprovacio"
        Me.DataFiAprovacio.ReadOnly = True
        Me.DataFiAprovacio.Size = New System.Drawing.Size(116, 23)
        Me.DataFiAprovacio.TabIndex = 33
        Me.DataFiAprovacio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Btn_EsborrarSeleccioSolucio
        '
        Me.Btn_EsborrarSeleccioSolucio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_EsborrarSeleccioSolucio.Enabled = False
        Me.Btn_EsborrarSeleccioSolucio.Location = New System.Drawing.Point(1007, 895)
        Me.Btn_EsborrarSeleccioSolucio.Name = "Btn_EsborrarSeleccioSolucio"
        Me.Btn_EsborrarSeleccioSolucio.Size = New System.Drawing.Size(146, 53)
        Me.Btn_EsborrarSeleccioSolucio.TabIndex = 34
        Me.Btn_EsborrarSeleccioSolucio.Text = "Esborrar selecció"
        Me.Btn_EsborrarSeleccioSolucio.UseVisualStyleBackColor = True
        '
        'Btn_EsborrarSolucio
        '
        Me.Btn_EsborrarSolucio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_EsborrarSolucio.BackColor = System.Drawing.Color.IndianRed
        Me.Btn_EsborrarSolucio.Enabled = False
        Me.Btn_EsborrarSolucio.Location = New System.Drawing.Point(1475, 895)
        Me.Btn_EsborrarSolucio.Name = "Btn_EsborrarSolucio"
        Me.Btn_EsborrarSolucio.Size = New System.Drawing.Size(144, 53)
        Me.Btn_EsborrarSolucio.TabIndex = 35
        Me.Btn_EsborrarSolucio.Text = "Esborrar solució"
        Me.Btn_EsborrarSolucio.UseVisualStyleBackColor = False
        '
        'TitolEmpresa
        '
        Me.TitolEmpresa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitolEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TitolEmpresa.Enabled = False
        Me.TitolEmpresa.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TitolEmpresa.Location = New System.Drawing.Point(360, 23)
        Me.TitolEmpresa.Multiline = True
        Me.TitolEmpresa.Name = "TitolEmpresa"
        Me.TitolEmpresa.PlaceholderText = "Selecciona empresa"
        Me.TitolEmpresa.ReadOnly = True
        Me.TitolEmpresa.Size = New System.Drawing.Size(620, 36)
        Me.TitolEmpresa.TabIndex = 36
        Me.TitolEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TitolSolucio
        '
        Me.TitolSolucio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitolSolucio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TitolSolucio.Enabled = False
        Me.TitolSolucio.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TitolSolucio.Location = New System.Drawing.Point(1003, 23)
        Me.TitolSolucio.Multiline = True
        Me.TitolSolucio.Name = "TitolSolucio"
        Me.TitolSolucio.PlaceholderText = "Selecciona solució"
        Me.TitolSolucio.ReadOnly = True
        Me.TitolSolucio.Size = New System.Drawing.Size(618, 36)
        Me.TitolSolucio.TabIndex = 37
        Me.TitolSolucio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CheckJustificat
        '
        Me.CheckJustificat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckJustificat.AutoSize = True
        Me.CheckJustificat.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckJustificat.Location = New System.Drawing.Point(1498, 641)
        Me.CheckJustificat.Name = "CheckJustificat"
        Me.CheckJustificat.Size = New System.Drawing.Size(120, 19)
        Me.CheckJustificat.TabIndex = 38
        Me.CheckJustificat.Text = "Mostrar justificats"
        Me.CheckJustificat.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(1007, 604)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 15)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "Justificat?"
        '
        'CheckEstaJustificat
        '
        Me.CheckEstaJustificat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckEstaJustificat.AutoSize = True
        Me.CheckEstaJustificat.Enabled = False
        Me.CheckEstaJustificat.Location = New System.Drawing.Point(1139, 606)
        Me.CheckEstaJustificat.Name = "CheckEstaJustificat"
        Me.CheckEstaJustificat.Size = New System.Drawing.Size(15, 14)
        Me.CheckEstaJustificat.TabIndex = 40
        Me.CheckEstaJustificat.UseVisualStyleBackColor = True
        '
        'Btn_EstatJustificacio
        '
        Me.Btn_EstatJustificacio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_EstatJustificacio.Enabled = False
        Me.Btn_EstatJustificacio.Location = New System.Drawing.Point(1475, 317)
        Me.Btn_EstatJustificacio.Name = "Btn_EstatJustificacio"
        Me.Btn_EstatJustificacio.Size = New System.Drawing.Size(146, 63)
        Me.Btn_EstatJustificacio.TabIndex = 41
        Me.Btn_EstatJustificacio.Text = "Veure estat de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "justificació"
        Me.Btn_EstatJustificacio.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(1007, 820)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(611, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 42
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(1007, 802)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(146, 15)
        Me.Label15.TabIndex = 43
        Me.Label15.Text = "Percentatge de justificació"
        '
        'TBObservacions
        '
        Me.TBObservacions.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBObservacions.Enabled = False
        Me.TBObservacions.Location = New System.Drawing.Point(1007, 681)
        Me.TBObservacions.Multiline = True
        Me.TBObservacions.Name = "TBObservacions"
        Me.TBObservacions.Size = New System.Drawing.Size(611, 111)
        Me.TBObservacions.TabIndex = 44
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(1007, 636)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(78, 15)
        Me.Label16.TabIndex = 45
        Me.Label16.Text = "Observacions"
        '
        'verificat
        '
        Me.verificat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.verificat.BackColor = System.Drawing.Color.Transparent
        Me.verificat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.verificat.Image = Global.FacturaXML.My.Resources.Resources.verificado
        Me.verificat.Location = New System.Drawing.Point(1193, 595)
        Me.verificat.Name = "verificat"
        Me.verificat.Size = New System.Drawing.Size(57, 58)
        Me.verificat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.verificat.TabIndex = 46
        Me.verificat.TabStop = False
        Me.verificat.Visible = False
        '
        'ContextMenuEsborrar
        '
        Me.ContextMenuEsborrar.Name = "ContextMenuStrip1"
        Me.ContextMenuEsborrar.Size = New System.Drawing.Size(61, 4)
        '
        'DataAprovacio
        '
        Me.DataAprovacio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataAprovacio.Enabled = False
        Me.DataAprovacio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataAprovacio.Location = New System.Drawing.Point(1139, 399)
        Me.DataAprovacio.Name = "DataAprovacio"
        Me.DataAprovacio.Size = New System.Drawing.Size(111, 23)
        Me.DataAprovacio.TabIndex = 48
        '
        'DataPagament
        '
        Me.DataPagament.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataPagament.Enabled = False
        Me.DataPagament.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataPagament.Location = New System.Drawing.Point(1139, 478)
        Me.DataPagament.Name = "DataPagament"
        Me.DataPagament.Size = New System.Drawing.Size(111, 23)
        Me.DataPagament.TabIndex = 50
        '
        'TitolAprovacio
        '
        Me.TitolAprovacio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitolAprovacio.AutoSize = True
        Me.TitolAprovacio.Location = New System.Drawing.Point(1266, 402)
        Me.TitolAprovacio.Name = "TitolAprovacio"
        Me.TitolAprovacio.Size = New System.Drawing.Size(191, 15)
        Me.TitolAprovacio.TabIndex = 51
        Me.TitolAprovacio.Text = "<-- 6 mesos a partir d'aquesta data"
        '
        'TitolContracte
        '
        Me.TitolContracte.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitolContracte.AutoSize = True
        Me.TitolContracte.Location = New System.Drawing.Point(1266, 442)
        Me.TitolContracte.Name = "TitolContracte"
        Me.TitolContracte.Size = New System.Drawing.Size(191, 15)
        Me.TitolContracte.TabIndex = 52
        Me.TitolContracte.Text = "<-- 3 mesos a partir d'aquesta data"
        '
        'DataFiContracte
        '
        Me.DataFiContracte.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataFiContracte.Location = New System.Drawing.Point(1475, 438)
        Me.DataFiContracte.Name = "DataFiContracte"
        Me.DataFiContracte.ReadOnly = True
        Me.DataFiContracte.Size = New System.Drawing.Size(116, 23)
        Me.DataFiContracte.TabIndex = 54
        Me.DataFiContracte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TitolPagament
        '
        Me.TitolPagament.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitolPagament.AutoSize = True
        Me.TitolPagament.Location = New System.Drawing.Point(1266, 481)
        Me.TitolPagament.Name = "TitolPagament"
        Me.TitolPagament.Size = New System.Drawing.Size(191, 15)
        Me.TitolPagament.TabIndex = 55
        Me.TitolPagament.Text = "<-- 3 mesos a partir d'aquesta data"
        '
        'DataFiPagament
        '
        Me.DataFiPagament.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataFiPagament.Location = New System.Drawing.Point(1475, 477)
        Me.DataFiPagament.Name = "DataFiPagament"
        Me.DataFiPagament.ReadOnly = True
        Me.DataFiPagament.Size = New System.Drawing.Size(116, 23)
        Me.DataFiPagament.TabIndex = 56
        Me.DataFiPagament.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CB_DataContracte
        '
        Me.CB_DataContracte.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CB_DataContracte.AutoSize = True
        Me.CB_DataContracte.Enabled = False
        Me.CB_DataContracte.Location = New System.Drawing.Point(1007, 442)
        Me.CB_DataContracte.Name = "CB_DataContracte"
        Me.CB_DataContracte.Size = New System.Drawing.Size(105, 19)
        Me.CB_DataContracte.TabIndex = 57
        Me.CB_DataContracte.Text = "Data Contracte"
        Me.CB_DataContracte.UseVisualStyleBackColor = True
        '
        'CB_DataPagamentIVA
        '
        Me.CB_DataPagamentIVA.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CB_DataPagamentIVA.AutoSize = True
        Me.CB_DataPagamentIVA.Enabled = False
        Me.CB_DataPagamentIVA.Location = New System.Drawing.Point(1007, 482)
        Me.CB_DataPagamentIVA.Name = "CB_DataPagamentIVA"
        Me.CB_DataPagamentIVA.Size = New System.Drawing.Size(127, 19)
        Me.CB_DataPagamentIVA.TabIndex = 58
        Me.CB_DataPagamentIVA.Text = "Data pagament IVA"
        Me.CB_DataPagamentIVA.UseVisualStyleBackColor = True
        '
        'CB_DataAprovacio
        '
        Me.CB_DataAprovacio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CB_DataAprovacio.AutoSize = True
        Me.CB_DataAprovacio.Enabled = False
        Me.CB_DataAprovacio.Location = New System.Drawing.Point(1007, 401)
        Me.CB_DataAprovacio.Name = "CB_DataAprovacio"
        Me.CB_DataAprovacio.Size = New System.Drawing.Size(107, 19)
        Me.CB_DataAprovacio.TabIndex = 59
        Me.CB_DataAprovacio.Text = "Data Aprovació"
        Me.CB_DataAprovacio.UseVisualStyleBackColor = True
        '
        'DataAprovacioOK
        '
        Me.DataAprovacioOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataAprovacioOK.Image = Global.FacturaXML.My.Resources.Resources.verificado_petit
        Me.DataAprovacioOK.Location = New System.Drawing.Point(1597, 399)
        Me.DataAprovacioOK.Name = "DataAprovacioOK"
        Me.DataAprovacioOK.Size = New System.Drawing.Size(24, 23)
        Me.DataAprovacioOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.DataAprovacioOK.TabIndex = 60
        Me.DataAprovacioOK.TabStop = False
        Me.DataAprovacioOK.Visible = False
        '
        'DataContracteOK
        '
        Me.DataContracteOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataContracteOK.Image = Global.FacturaXML.My.Resources.Resources.verificado_petit
        Me.DataContracteOK.Location = New System.Drawing.Point(1597, 438)
        Me.DataContracteOK.Name = "DataContracteOK"
        Me.DataContracteOK.Size = New System.Drawing.Size(24, 24)
        Me.DataContracteOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.DataContracteOK.TabIndex = 61
        Me.DataContracteOK.TabStop = False
        Me.DataContracteOK.Visible = False
        '
        'DataPagamentOK
        '
        Me.DataPagamentOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataPagamentOK.Image = Global.FacturaXML.My.Resources.Resources.verificado_petit
        Me.DataPagamentOK.Location = New System.Drawing.Point(1597, 477)
        Me.DataPagamentOK.Name = "DataPagamentOK"
        Me.DataPagamentOK.Size = New System.Drawing.Size(24, 24)
        Me.DataPagamentOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.DataPagamentOK.TabIndex = 62
        Me.DataPagamentOK.TabStop = False
        Me.DataPagamentOK.Visible = False
        '
        'Contractes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1641, 978)
        Me.Controls.Add(Me.DataPagamentOK)
        Me.Controls.Add(Me.DataContracteOK)
        Me.Controls.Add(Me.DataAprovacioOK)
        Me.Controls.Add(Me.CB_DataAprovacio)
        Me.Controls.Add(Me.CB_DataPagamentIVA)
        Me.Controls.Add(Me.CB_DataContracte)
        Me.Controls.Add(Me.DataFiPagament)
        Me.Controls.Add(Me.TitolPagament)
        Me.Controls.Add(Me.DataFiContracte)
        Me.Controls.Add(Me.TitolContracte)
        Me.Controls.Add(Me.TitolAprovacio)
        Me.Controls.Add(Me.DataPagament)
        Me.Controls.Add(Me.DataAprovacio)
        Me.Controls.Add(Me.verificat)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TBObservacions)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Btn_EstatJustificacio)
        Me.Controls.Add(Me.CheckEstaJustificat)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.CheckJustificat)
        Me.Controls.Add(Me.TitolSolucio)
        Me.Controls.Add(Me.TitolEmpresa)
        Me.Controls.Add(Me.Btn_EsborrarSolucio)
        Me.Controls.Add(Me.Btn_EsborrarSeleccioSolucio)
        Me.Controls.Add(Me.DataFiAprovacio)
        Me.Controls.Add(Me.DataContracte)
        Me.Controls.Add(Me.Btn_AfegirSolucio)
        Me.Controls.Add(Me.DiesCaducitat)
        Me.Controls.Add(Me.NoAcord)
        Me.Controls.Add(Me.CB_TipusSolucio)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Empreses)
        Me.Controls.Add(Me.DataSolucions)
        Me.Controls.Add(Me.btn_EsborrarSeleccioEmpresa)
        Me.Controls.Add(Me.Btn_esborrarEmpresa)
        Me.Controls.Add(Me.Btn_afegir)
        Me.Controls.Add(Me.Pais)
        Me.Controls.Add(Me.Provincia)
        Me.Controls.Add(Me.Ciutat)
        Me.Controls.Add(Me.CodiPostal)
        Me.Controls.Add(Me.Direccio)
        Me.Controls.Add(Me.Nif)
        Me.Controls.Add(Me.Empresa)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataEmpreses)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1623, 891)
        Me.Name = "Contractes"
        Me.Text = "Contractes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataEmpreses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSolucions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verificat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataAprovacioOK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataContracteOK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataPagamentOK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents Empreses As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents CB_TipusSolucio As ComboBox
    Friend WithEvents NoAcord As TextBox
    Friend WithEvents DiesCaducitat As TextBox
    Friend WithEvents Btn_AfegirSolucio As Button
    Friend WithEvents DataContracte As DateTimePicker
    Friend WithEvents DataFiAprovacio As TextBox
    Friend WithEvents Btn_EsborrarSeleccioSolucio As Button
    Friend WithEvents Btn_EsborrarSolucio As Button
    Friend WithEvents TitolEmpresa As TextBox
    Friend WithEvents TitolSolucio As TextBox
    Friend WithEvents CheckJustificat As CheckBox
    Friend WithEvents Label14 As Label
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
    Friend WithEvents TitolAprovacio As Label
    Friend WithEvents TitolContracte As Label
    Friend WithEvents DataFiContracte As TextBox
    Friend WithEvents TitolPagament As Label
    Friend WithEvents DataFiPagament As TextBox
    Friend WithEvents CB_DataContracte As CheckBox
    Friend WithEvents CB_DataPagamentIVA As CheckBox
    Friend WithEvents CB_DataAprovacio As CheckBox
    Friend WithEvents DataAprovacioOK As PictureBox
    Friend WithEvents DataContracteOK As PictureBox
    Friend WithEvents DataPagamentOK As PictureBox
End Class
