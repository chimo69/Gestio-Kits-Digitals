<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Solucions
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
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        PB_importarExcel = New ProgressBar()
        btn_importarExcel = New Button()
        RB_segona = New RadioButton()
        RB_primera = New RadioButton()
        Btn_actualitzar = New Button()
        Label4 = New Label()
        contracte = New TextBox()
        AdvertenciaCaducats = New Label()
        Label3 = New Label()
        nomEmpresa = New TextBox()
        Label1 = New Label()
        SplitContainer1 = New SplitContainer()
        DataLlistat = New DataGridView()
        GroupBox1 = New GroupBox()
        TB_DocumentacioAddicional = New TextBox()
        RB_DocumentacioAddicional = New RadioButton()
        TB_PagamentMinorat = New TextBox()
        RB_PagamentMinorat = New RadioButton()
        TB_NoPagada = New TextBox()
        RB_NoPagada = New RadioButton()
        TB_Pagada = New TextBox()
        RB_Pagada = New RadioButton()
        TB_EsmenaIncorrecta = New TextBox()
        TB_FinalitzadaEsmena = New TextBox()
        RB_FinalitzadaEsmena = New RadioButton()
        RB_EsmenaIncorrecta = New RadioButton()
        TB_Presentada = New TextBox()
        RB_Presentada = New RadioButton()
        TB_ValidadaPagament = New TextBox()
        TB_EsmenaObert = New TextBox()
        RB_ValidadaPagament = New RadioButton()
        RB_EsmenaObert = New RadioButton()
        TB_TotsEstats = New TextBox()
        RB_TotsEstats = New RadioButton()
        TB_Esborrany = New TextBox()
        TB_Enviada = New TextBox()
        TB_PreparantDocumentacio = New TextBox()
        RB_PreparantDocumentacio = New RadioButton()
        RB_Esborrany = New RadioButton()
        RB_Enviada = New RadioButton()
        GB_TipusSolucions = New GroupBox()
        TB_Puestoseguro = New TextBox()
        RB_PuestoSeguro = New RadioButton()
        TB_FacturaElectronica = New TextBox()
        CB_JaPresentades = New CheckBox()
        RB_FacturaElectronica = New RadioButton()
        TB_Ciberseguridad = New TextBox()
        TB_ComunicacionesSeguras = New TextBox()
        TB_OficinaVirtual = New TextBox()
        RB_OficinaVirtual = New RadioButton()
        RB_Ciberseguridad = New RadioButton()
        RB_ComunicacionesSeguras = New RadioButton()
        TB_GestionProcesos = New TextBox()
        TB_BusinessInteligence = New TextBox()
        RB_GestionProcesos = New RadioButton()
        RB_BusinessInteligence = New RadioButton()
        TB_totes = New TextBox()
        RB_Totes = New RadioButton()
        TB_ComercioElectronico = New TextBox()
        TB_SitioWeb = New TextBox()
        RB_SitioWeb = New RadioButton()
        RB_ComercioElectronico = New RadioButton()
        Timer1 = New Timer(components)
        Panel1.SuspendLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(DataLlistat, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GB_TipusSolucions.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(PB_importarExcel)
        Panel1.Controls.Add(btn_importarExcel)
        Panel1.Controls.Add(RB_segona)
        Panel1.Controls.Add(RB_primera)
        Panel1.Controls.Add(Btn_actualitzar)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(contracte)
        Panel1.Controls.Add(AdvertenciaCaducats)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(nomEmpresa)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1631, 53)
        Panel1.TabIndex = 0
        ' 
        ' PB_importarExcel
        ' 
        PB_importarExcel.Location = New Point(317, 16)
        PB_importarExcel.Name = "PB_importarExcel"
        PB_importarExcel.Size = New Size(310, 23)
        PB_importarExcel.TabIndex = 24
        PB_importarExcel.Visible = False
        ' 
        ' btn_importarExcel
        ' 
        btn_importarExcel.BackgroundImage = My.Resources.Resources._4202106excellogomicrosoftms_115582_115719
        btn_importarExcel.BackgroundImageLayout = ImageLayout.Zoom
        btn_importarExcel.FlatAppearance.BorderSize = 0
        btn_importarExcel.FlatStyle = FlatStyle.Flat
        btn_importarExcel.Location = New Point(266, 3)
        btn_importarExcel.Name = "btn_importarExcel"
        btn_importarExcel.Size = New Size(45, 45)
        btn_importarExcel.TabIndex = 23
        btn_importarExcel.TextImageRelation = TextImageRelation.TextBeforeImage
        btn_importarExcel.UseVisualStyleBackColor = True
        ' 
        ' RB_segona
        ' 
        RB_segona.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        RB_segona.AutoSize = True
        RB_segona.Location = New Point(1035, 29)
        RB_segona.Name = "RB_segona"
        RB_segona.Size = New Size(124, 19)
        RB_segona.TabIndex = 22
        RB_segona.Text = "Segona justificació"
        RB_segona.UseVisualStyleBackColor = True
        ' 
        ' RB_primera
        ' 
        RB_primera.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        RB_primera.AutoSize = True
        RB_primera.Checked = True
        RB_primera.Location = New Point(1035, 4)
        RB_primera.Name = "RB_primera"
        RB_primera.Size = New Size(126, 19)
        RB_primera.TabIndex = 21
        RB_primera.TabStop = True
        RB_primera.Text = "Primera justificació"
        RB_primera.UseVisualStyleBackColor = True
        ' 
        ' Btn_actualitzar
        ' 
        Btn_actualitzar.BackColor = SystemColors.Control
        Btn_actualitzar.BackgroundImage = My.Resources.Resources.Icono_Actualizar
        Btn_actualitzar.BackgroundImageLayout = ImageLayout.Zoom
        Btn_actualitzar.FlatAppearance.BorderSize = 0
        Btn_actualitzar.FlatStyle = FlatStyle.Flat
        Btn_actualitzar.Location = New Point(209, 4)
        Btn_actualitzar.Name = "Btn_actualitzar"
        Btn_actualitzar.Size = New Size(40, 40)
        Btn_actualitzar.TabIndex = 20
        Btn_actualitzar.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Location = New Point(1402, 6)
        Label4.Name = "Label4"
        Label4.Size = New Size(115, 15)
        Label4.TabIndex = 19
        Label4.Text = "Buscar per contracte"
        ' 
        ' contracte
        ' 
        contracte.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        contracte.Location = New Point(1401, 24)
        contracte.Name = "contracte"
        contracte.Size = New Size(220, 23)
        contracte.TabIndex = 18
        ' 
        ' AdvertenciaCaducats
        ' 
        AdvertenciaCaducats.AutoSize = True
        AdvertenciaCaducats.BackColor = SystemColors.Control
        AdvertenciaCaducats.Font = New Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point)
        AdvertenciaCaducats.ForeColor = Color.Red
        AdvertenciaCaducats.Location = New Point(633, 10)
        AdvertenciaCaducats.Name = "AdvertenciaCaducats"
        AdvertenciaCaducats.Size = New Size(375, 29)
        AdvertenciaCaducats.TabIndex = 18
        AdvertenciaCaducats.Text = "Atenció! Solucions apunt de caducar"
        AdvertenciaCaducats.Visible = False
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Location = New Point(1176, 6)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 15)
        Label3.TabIndex = 17
        Label3.Text = "Buscar per empresa"
        ' 
        ' nomEmpresa
        ' 
        nomEmpresa.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        nomEmpresa.Location = New Point(1176, 24)
        nomEmpresa.Name = "nomEmpresa"
        nomEmpresa.Size = New Size(220, 23)
        nomEmpresa.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(3, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(200, 30)
        Label1.TabIndex = 16
        Label1.Text = "Llistat de solucions"
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.FixedPanel = FixedPanel.Panel2
        SplitContainer1.Location = New Point(0, 53)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.AutoScroll = True
        SplitContainer1.Panel1.Controls.Add(DataLlistat)
        SplitContainer1.Panel1.Padding = New Padding(20, 0, 0, 20)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(GroupBox1)
        SplitContainer1.Panel2.Controls.Add(GB_TipusSolucions)
        SplitContainer1.Size = New Size(1631, 981)
        SplitContainer1.SplitterDistance = 1371
        SplitContainer1.TabIndex = 1
        ' 
        ' DataLlistat
        ' 
        DataLlistat.AllowUserToAddRows = False
        DataLlistat.AllowUserToDeleteRows = False
        DataLlistat.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        DataLlistat.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = Color.Gray
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(72), CByte(101), CByte(174))
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        DataLlistat.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        DataLlistat.ColumnHeadersHeight = 40
        DataLlistat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = SystemColors.Window
        DataGridViewCellStyle7.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle7.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(CByte(72), CByte(101), CByte(174))
        DataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.False
        DataLlistat.DefaultCellStyle = DataGridViewCellStyle7
        DataLlistat.Dock = DockStyle.Fill
        DataLlistat.EnableHeadersVisualStyles = False
        DataLlistat.Location = New Point(20, 0)
        DataLlistat.MultiSelect = False
        DataLlistat.Name = "DataLlistat"
        DataLlistat.ReadOnly = True
        DataLlistat.RowHeadersVisible = False
        DataGridViewCellStyle8.Padding = New Padding(0, 3, 0, 3)
        DataLlistat.RowsDefaultCellStyle = DataGridViewCellStyle8
        DataLlistat.RowTemplate.Height = 25
        DataLlistat.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataLlistat.ShowEditingIcon = False
        DataLlistat.Size = New Size(1351, 961)
        DataLlistat.TabIndex = 4
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TB_DocumentacioAddicional)
        GroupBox1.Controls.Add(RB_DocumentacioAddicional)
        GroupBox1.Controls.Add(TB_PagamentMinorat)
        GroupBox1.Controls.Add(RB_PagamentMinorat)
        GroupBox1.Controls.Add(TB_NoPagada)
        GroupBox1.Controls.Add(RB_NoPagada)
        GroupBox1.Controls.Add(TB_Pagada)
        GroupBox1.Controls.Add(RB_Pagada)
        GroupBox1.Controls.Add(TB_EsmenaIncorrecta)
        GroupBox1.Controls.Add(TB_FinalitzadaEsmena)
        GroupBox1.Controls.Add(RB_FinalitzadaEsmena)
        GroupBox1.Controls.Add(RB_EsmenaIncorrecta)
        GroupBox1.Controls.Add(TB_Presentada)
        GroupBox1.Controls.Add(RB_Presentada)
        GroupBox1.Controls.Add(TB_ValidadaPagament)
        GroupBox1.Controls.Add(TB_EsmenaObert)
        GroupBox1.Controls.Add(RB_ValidadaPagament)
        GroupBox1.Controls.Add(RB_EsmenaObert)
        GroupBox1.Controls.Add(TB_TotsEstats)
        GroupBox1.Controls.Add(RB_TotsEstats)
        GroupBox1.Controls.Add(TB_Esborrany)
        GroupBox1.Controls.Add(TB_Enviada)
        GroupBox1.Controls.Add(TB_PreparantDocumentacio)
        GroupBox1.Controls.Add(RB_PreparantDocumentacio)
        GroupBox1.Controls.Add(RB_Esborrany)
        GroupBox1.Controls.Add(RB_Enviada)
        GroupBox1.Location = New Point(11, 447)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(236, 514)
        GroupBox1.TabIndex = 20
        GroupBox1.TabStop = False
        GroupBox1.Text = "Tipus de estats"
        ' 
        ' TB_DocumentacioAddicional
        ' 
        TB_DocumentacioAddicional.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TB_DocumentacioAddicional.Enabled = False
        TB_DocumentacioAddicional.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TB_DocumentacioAddicional.Location = New Point(186, 410)
        TB_DocumentacioAddicional.Name = "TB_DocumentacioAddicional"
        TB_DocumentacioAddicional.Size = New Size(40, 23)
        TB_DocumentacioAddicional.TabIndex = 35
        TB_DocumentacioAddicional.TextAlign = HorizontalAlignment.Center
        ' 
        ' RB_DocumentacioAddicional
        ' 
        RB_DocumentacioAddicional.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        RB_DocumentacioAddicional.Appearance = Appearance.Button
        RB_DocumentacioAddicional.Location = New Point(6, 409)
        RB_DocumentacioAddicional.Name = "RB_DocumentacioAddicional"
        RB_DocumentacioAddicional.Size = New Size(174, 25)
        RB_DocumentacioAddicional.TabIndex = 34
        RB_DocumentacioAddicional.Text = "Documentació addicional"
        RB_DocumentacioAddicional.UseVisualStyleBackColor = True
        ' 
        ' TB_PagamentMinorat
        ' 
        TB_PagamentMinorat.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TB_PagamentMinorat.Enabled = False
        TB_PagamentMinorat.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TB_PagamentMinorat.Location = New Point(187, 379)
        TB_PagamentMinorat.Name = "TB_PagamentMinorat"
        TB_PagamentMinorat.Size = New Size(40, 23)
        TB_PagamentMinorat.TabIndex = 33
        TB_PagamentMinorat.TextAlign = HorizontalAlignment.Center
        ' 
        ' RB_PagamentMinorat
        ' 
        RB_PagamentMinorat.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        RB_PagamentMinorat.Appearance = Appearance.Button
        RB_PagamentMinorat.Location = New Point(7, 378)
        RB_PagamentMinorat.Name = "RB_PagamentMinorat"
        RB_PagamentMinorat.Size = New Size(174, 25)
        RB_PagamentMinorat.TabIndex = 32
        RB_PagamentMinorat.Text = "Pagament minorat"
        RB_PagamentMinorat.UseVisualStyleBackColor = True
        ' 
        ' TB_NoPagada
        ' 
        TB_NoPagada.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TB_NoPagada.Enabled = False
        TB_NoPagada.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TB_NoPagada.Location = New Point(186, 348)
        TB_NoPagada.Name = "TB_NoPagada"
        TB_NoPagada.Size = New Size(40, 23)
        TB_NoPagada.TabIndex = 31
        TB_NoPagada.TextAlign = HorizontalAlignment.Center
        ' 
        ' RB_NoPagada
        ' 
        RB_NoPagada.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        RB_NoPagada.Appearance = Appearance.Button
        RB_NoPagada.Location = New Point(6, 347)
        RB_NoPagada.Name = "RB_NoPagada"
        RB_NoPagada.Size = New Size(174, 25)
        RB_NoPagada.TabIndex = 30
        RB_NoPagada.Text = "No pagada"
        RB_NoPagada.UseVisualStyleBackColor = True
        ' 
        ' TB_Pagada
        ' 
        TB_Pagada.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TB_Pagada.Enabled = False
        TB_Pagada.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TB_Pagada.Location = New Point(187, 255)
        TB_Pagada.Name = "TB_Pagada"
        TB_Pagada.Size = New Size(40, 23)
        TB_Pagada.TabIndex = 29
        TB_Pagada.TextAlign = HorizontalAlignment.Center
        ' 
        ' RB_Pagada
        ' 
        RB_Pagada.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        RB_Pagada.Appearance = Appearance.Button
        RB_Pagada.Location = New Point(7, 254)
        RB_Pagada.Name = "RB_Pagada"
        RB_Pagada.Size = New Size(174, 25)
        RB_Pagada.TabIndex = 28
        RB_Pagada.Text = "Pagada"
        RB_Pagada.UseVisualStyleBackColor = True
        ' 
        ' TB_EsmenaIncorrecta
        ' 
        TB_EsmenaIncorrecta.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TB_EsmenaIncorrecta.Enabled = False
        TB_EsmenaIncorrecta.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TB_EsmenaIncorrecta.Location = New Point(187, 317)
        TB_EsmenaIncorrecta.Name = "TB_EsmenaIncorrecta"
        TB_EsmenaIncorrecta.Size = New Size(40, 23)
        TB_EsmenaIncorrecta.TabIndex = 26
        TB_EsmenaIncorrecta.TextAlign = HorizontalAlignment.Center
        ' 
        ' TB_FinalitzadaEsmena
        ' 
        TB_FinalitzadaEsmena.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TB_FinalitzadaEsmena.Enabled = False
        TB_FinalitzadaEsmena.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TB_FinalitzadaEsmena.Location = New Point(187, 286)
        TB_FinalitzadaEsmena.Name = "TB_FinalitzadaEsmena"
        TB_FinalitzadaEsmena.Size = New Size(40, 23)
        TB_FinalitzadaEsmena.TabIndex = 25
        TB_FinalitzadaEsmena.TextAlign = HorizontalAlignment.Center
        ' 
        ' RB_FinalitzadaEsmena
        ' 
        RB_FinalitzadaEsmena.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        RB_FinalitzadaEsmena.Appearance = Appearance.Button
        RB_FinalitzadaEsmena.Location = New Point(7, 285)
        RB_FinalitzadaEsmena.Name = "RB_FinalitzadaEsmena"
        RB_FinalitzadaEsmena.Size = New Size(174, 25)
        RB_FinalitzadaEsmena.TabIndex = 22
        RB_FinalitzadaEsmena.Text = "Finalitzat termini d'esmena"
        RB_FinalitzadaEsmena.UseVisualStyleBackColor = True
        ' 
        ' RB_EsmenaIncorrecta
        ' 
        RB_EsmenaIncorrecta.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        RB_EsmenaIncorrecta.Appearance = Appearance.Button
        RB_EsmenaIncorrecta.Location = New Point(7, 316)
        RB_EsmenaIncorrecta.Name = "RB_EsmenaIncorrecta"
        RB_EsmenaIncorrecta.Size = New Size(174, 25)
        RB_EsmenaIncorrecta.TabIndex = 23
        RB_EsmenaIncorrecta.Text = "Esmena incorrecta"
        RB_EsmenaIncorrecta.UseVisualStyleBackColor = True
        ' 
        ' TB_Presentada
        ' 
        TB_Presentada.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TB_Presentada.Enabled = False
        TB_Presentada.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TB_Presentada.Location = New Point(187, 162)
        TB_Presentada.Name = "TB_Presentada"
        TB_Presentada.Size = New Size(40, 23)
        TB_Presentada.TabIndex = 21
        TB_Presentada.TextAlign = HorizontalAlignment.Center
        ' 
        ' RB_Presentada
        ' 
        RB_Presentada.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        RB_Presentada.Appearance = Appearance.Button
        RB_Presentada.Location = New Point(7, 161)
        RB_Presentada.Name = "RB_Presentada"
        RB_Presentada.Size = New Size(174, 25)
        RB_Presentada.TabIndex = 20
        RB_Presentada.Text = "Presentada"
        RB_Presentada.UseVisualStyleBackColor = True
        ' 
        ' TB_ValidadaPagament
        ' 
        TB_ValidadaPagament.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TB_ValidadaPagament.Enabled = False
        TB_ValidadaPagament.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TB_ValidadaPagament.Location = New Point(187, 224)
        TB_ValidadaPagament.Name = "TB_ValidadaPagament"
        TB_ValidadaPagament.Size = New Size(40, 23)
        TB_ValidadaPagament.TabIndex = 19
        TB_ValidadaPagament.TextAlign = HorizontalAlignment.Center
        ' 
        ' TB_EsmenaObert
        ' 
        TB_EsmenaObert.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TB_EsmenaObert.Enabled = False
        TB_EsmenaObert.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TB_EsmenaObert.Location = New Point(187, 193)
        TB_EsmenaObert.Name = "TB_EsmenaObert"
        TB_EsmenaObert.Size = New Size(40, 23)
        TB_EsmenaObert.TabIndex = 18
        TB_EsmenaObert.TextAlign = HorizontalAlignment.Center
        ' 
        ' RB_ValidadaPagament
        ' 
        RB_ValidadaPagament.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        RB_ValidadaPagament.Appearance = Appearance.Button
        RB_ValidadaPagament.Location = New Point(7, 223)
        RB_ValidadaPagament.Name = "RB_ValidadaPagament"
        RB_ValidadaPagament.Size = New Size(174, 25)
        RB_ValidadaPagament.TabIndex = 16
        RB_ValidadaPagament.Text = "Validada per pagament"
        RB_ValidadaPagament.UseVisualStyleBackColor = True
        ' 
        ' RB_EsmenaObert
        ' 
        RB_EsmenaObert.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        RB_EsmenaObert.Appearance = Appearance.Button
        RB_EsmenaObert.Location = New Point(7, 192)
        RB_EsmenaObert.Name = "RB_EsmenaObert"
        RB_EsmenaObert.Size = New Size(174, 25)
        RB_EsmenaObert.TabIndex = 15
        RB_EsmenaObert.Text = "Termini d'esmena obert"
        RB_EsmenaObert.UseVisualStyleBackColor = True
        ' 
        ' TB_TotsEstats
        ' 
        TB_TotsEstats.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TB_TotsEstats.Enabled = False
        TB_TotsEstats.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TB_TotsEstats.Location = New Point(187, 23)
        TB_TotsEstats.Name = "TB_TotsEstats"
        TB_TotsEstats.Size = New Size(40, 23)
        TB_TotsEstats.TabIndex = 13
        TB_TotsEstats.TextAlign = HorizontalAlignment.Center
        ' 
        ' RB_TotsEstats
        ' 
        RB_TotsEstats.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        RB_TotsEstats.Appearance = Appearance.Button
        RB_TotsEstats.Location = New Point(7, 22)
        RB_TotsEstats.Name = "RB_TotsEstats"
        RB_TotsEstats.Size = New Size(174, 25)
        RB_TotsEstats.TabIndex = 12
        RB_TotsEstats.Text = "Totes els estats"
        RB_TotsEstats.UseVisualStyleBackColor = True
        ' 
        ' TB_Esborrany
        ' 
        TB_Esborrany.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TB_Esborrany.Enabled = False
        TB_Esborrany.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TB_Esborrany.Location = New Point(187, 131)
        TB_Esborrany.Name = "TB_Esborrany"
        TB_Esborrany.Size = New Size(40, 23)
        TB_Esborrany.TabIndex = 11
        TB_Esborrany.TextAlign = HorizontalAlignment.Center
        ' 
        ' TB_Enviada
        ' 
        TB_Enviada.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TB_Enviada.Enabled = False
        TB_Enviada.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TB_Enviada.Location = New Point(187, 100)
        TB_Enviada.Name = "TB_Enviada"
        TB_Enviada.Size = New Size(40, 23)
        TB_Enviada.TabIndex = 10
        TB_Enviada.TextAlign = HorizontalAlignment.Center
        ' 
        ' TB_PreparantDocumentacio
        ' 
        TB_PreparantDocumentacio.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TB_PreparantDocumentacio.Enabled = False
        TB_PreparantDocumentacio.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TB_PreparantDocumentacio.Location = New Point(187, 69)
        TB_PreparantDocumentacio.Name = "TB_PreparantDocumentacio"
        TB_PreparantDocumentacio.Size = New Size(40, 23)
        TB_PreparantDocumentacio.TabIndex = 9
        TB_PreparantDocumentacio.TextAlign = HorizontalAlignment.Center
        ' 
        ' RB_PreparantDocumentacio
        ' 
        RB_PreparantDocumentacio.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        RB_PreparantDocumentacio.Appearance = Appearance.Button
        RB_PreparantDocumentacio.Location = New Point(7, 68)
        RB_PreparantDocumentacio.Name = "RB_PreparantDocumentacio"
        RB_PreparantDocumentacio.Size = New Size(174, 25)
        RB_PreparantDocumentacio.TabIndex = 6
        RB_PreparantDocumentacio.Text = "Preparant documentació"
        RB_PreparantDocumentacio.UseVisualStyleBackColor = True
        ' 
        ' RB_Esborrany
        ' 
        RB_Esborrany.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        RB_Esborrany.Appearance = Appearance.Button
        RB_Esborrany.Location = New Point(7, 130)
        RB_Esborrany.Name = "RB_Esborrany"
        RB_Esborrany.Size = New Size(174, 25)
        RB_Esborrany.TabIndex = 8
        RB_Esborrany.Text = "Esborrany"
        RB_Esborrany.UseVisualStyleBackColor = True
        ' 
        ' RB_Enviada
        ' 
        RB_Enviada.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        RB_Enviada.Appearance = Appearance.Button
        RB_Enviada.Location = New Point(7, 99)
        RB_Enviada.Name = "RB_Enviada"
        RB_Enviada.Size = New Size(174, 25)
        RB_Enviada.TabIndex = 7
        RB_Enviada.Text = "Enviada"
        RB_Enviada.UseVisualStyleBackColor = True
        ' 
        ' GB_TipusSolucions
        ' 
        GB_TipusSolucions.Controls.Add(TB_Puestoseguro)
        GB_TipusSolucions.Controls.Add(RB_PuestoSeguro)
        GB_TipusSolucions.Controls.Add(TB_FacturaElectronica)
        GB_TipusSolucions.Controls.Add(CB_JaPresentades)
        GB_TipusSolucions.Controls.Add(RB_FacturaElectronica)
        GB_TipusSolucions.Controls.Add(TB_Ciberseguridad)
        GB_TipusSolucions.Controls.Add(TB_ComunicacionesSeguras)
        GB_TipusSolucions.Controls.Add(TB_OficinaVirtual)
        GB_TipusSolucions.Controls.Add(RB_OficinaVirtual)
        GB_TipusSolucions.Controls.Add(RB_Ciberseguridad)
        GB_TipusSolucions.Controls.Add(RB_ComunicacionesSeguras)
        GB_TipusSolucions.Controls.Add(TB_GestionProcesos)
        GB_TipusSolucions.Controls.Add(TB_BusinessInteligence)
        GB_TipusSolucions.Controls.Add(RB_GestionProcesos)
        GB_TipusSolucions.Controls.Add(RB_BusinessInteligence)
        GB_TipusSolucions.Controls.Add(TB_totes)
        GB_TipusSolucions.Controls.Add(RB_Totes)
        GB_TipusSolucions.Controls.Add(TB_ComercioElectronico)
        GB_TipusSolucions.Controls.Add(TB_SitioWeb)
        GB_TipusSolucions.Controls.Add(RB_SitioWeb)
        GB_TipusSolucions.Controls.Add(RB_ComercioElectronico)
        GB_TipusSolucions.Location = New Point(11, 0)
        GB_TipusSolucions.Name = "GB_TipusSolucions"
        GB_TipusSolucions.Size = New Size(236, 441)
        GB_TipusSolucions.TabIndex = 15
        GB_TipusSolucions.TabStop = False
        GB_TipusSolucions.Text = "Tipus de solucions"
        ' 
        ' TB_Puestoseguro
        ' 
        TB_Puestoseguro.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TB_Puestoseguro.Enabled = False
        TB_Puestoseguro.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TB_Puestoseguro.Location = New Point(187, 323)
        TB_Puestoseguro.Name = "TB_Puestoseguro"
        TB_Puestoseguro.Size = New Size(40, 23)
        TB_Puestoseguro.TabIndex = 31
        TB_Puestoseguro.TextAlign = HorizontalAlignment.Center
        ' 
        ' RB_PuestoSeguro
        ' 
        RB_PuestoSeguro.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        RB_PuestoSeguro.Appearance = Appearance.Button
        RB_PuestoSeguro.Location = New Point(7, 322)
        RB_PuestoSeguro.Name = "RB_PuestoSeguro"
        RB_PuestoSeguro.Size = New Size(174, 25)
        RB_PuestoSeguro.TabIndex = 30
        RB_PuestoSeguro.Text = "Puesto seguro"
        RB_PuestoSeguro.UseVisualStyleBackColor = True
        ' 
        ' TB_FacturaElectronica
        ' 
        TB_FacturaElectronica.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TB_FacturaElectronica.Enabled = False
        TB_FacturaElectronica.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TB_FacturaElectronica.Location = New Point(187, 199)
        TB_FacturaElectronica.Name = "TB_FacturaElectronica"
        TB_FacturaElectronica.Size = New Size(40, 23)
        TB_FacturaElectronica.TabIndex = 29
        TB_FacturaElectronica.TextAlign = HorizontalAlignment.Center
        ' 
        ' CB_JaPresentades
        ' 
        CB_JaPresentades.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        CB_JaPresentades.AutoSize = True
        CB_JaPresentades.Location = New Point(7, 406)
        CB_JaPresentades.Name = "CB_JaPresentades"
        CB_JaPresentades.Size = New Size(189, 19)
        CB_JaPresentades.TabIndex = 5
        CB_JaPresentades.Text = "Mostrar solucions ja aprovades"
        CB_JaPresentades.UseVisualStyleBackColor = True
        ' 
        ' RB_FacturaElectronica
        ' 
        RB_FacturaElectronica.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        RB_FacturaElectronica.Appearance = Appearance.Button
        RB_FacturaElectronica.Location = New Point(7, 198)
        RB_FacturaElectronica.Name = "RB_FacturaElectronica"
        RB_FacturaElectronica.Size = New Size(174, 25)
        RB_FacturaElectronica.TabIndex = 28
        RB_FacturaElectronica.Text = "Factura electrónica"
        RB_FacturaElectronica.UseVisualStyleBackColor = True
        ' 
        ' TB_Ciberseguridad
        ' 
        TB_Ciberseguridad.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TB_Ciberseguridad.Enabled = False
        TB_Ciberseguridad.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TB_Ciberseguridad.Location = New Point(187, 292)
        TB_Ciberseguridad.Name = "TB_Ciberseguridad"
        TB_Ciberseguridad.Size = New Size(40, 23)
        TB_Ciberseguridad.TabIndex = 27
        TB_Ciberseguridad.TextAlign = HorizontalAlignment.Center
        ' 
        ' TB_ComunicacionesSeguras
        ' 
        TB_ComunicacionesSeguras.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TB_ComunicacionesSeguras.Enabled = False
        TB_ComunicacionesSeguras.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TB_ComunicacionesSeguras.Location = New Point(187, 261)
        TB_ComunicacionesSeguras.Name = "TB_ComunicacionesSeguras"
        TB_ComunicacionesSeguras.Size = New Size(40, 23)
        TB_ComunicacionesSeguras.TabIndex = 26
        TB_ComunicacionesSeguras.TextAlign = HorizontalAlignment.Center
        ' 
        ' TB_OficinaVirtual
        ' 
        TB_OficinaVirtual.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TB_OficinaVirtual.Enabled = False
        TB_OficinaVirtual.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TB_OficinaVirtual.Location = New Point(187, 230)
        TB_OficinaVirtual.Name = "TB_OficinaVirtual"
        TB_OficinaVirtual.Size = New Size(40, 23)
        TB_OficinaVirtual.TabIndex = 25
        TB_OficinaVirtual.TextAlign = HorizontalAlignment.Center
        ' 
        ' RB_OficinaVirtual
        ' 
        RB_OficinaVirtual.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        RB_OficinaVirtual.Appearance = Appearance.Button
        RB_OficinaVirtual.Location = New Point(7, 229)
        RB_OficinaVirtual.Name = "RB_OficinaVirtual"
        RB_OficinaVirtual.Size = New Size(174, 25)
        RB_OficinaVirtual.TabIndex = 22
        RB_OficinaVirtual.Text = "Oficina virtual"
        RB_OficinaVirtual.UseVisualStyleBackColor = True
        ' 
        ' RB_Ciberseguridad
        ' 
        RB_Ciberseguridad.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        RB_Ciberseguridad.Appearance = Appearance.Button
        RB_Ciberseguridad.Location = New Point(7, 291)
        RB_Ciberseguridad.Name = "RB_Ciberseguridad"
        RB_Ciberseguridad.Size = New Size(174, 25)
        RB_Ciberseguridad.TabIndex = 24
        RB_Ciberseguridad.Text = "Ciberseguridad"
        RB_Ciberseguridad.UseVisualStyleBackColor = True
        ' 
        ' RB_ComunicacionesSeguras
        ' 
        RB_ComunicacionesSeguras.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        RB_ComunicacionesSeguras.Appearance = Appearance.Button
        RB_ComunicacionesSeguras.Location = New Point(7, 260)
        RB_ComunicacionesSeguras.Name = "RB_ComunicacionesSeguras"
        RB_ComunicacionesSeguras.Size = New Size(174, 25)
        RB_ComunicacionesSeguras.TabIndex = 23
        RB_ComunicacionesSeguras.Text = "Comunicaciones seguras"
        RB_ComunicacionesSeguras.UseVisualStyleBackColor = True
        ' 
        ' TB_GestionProcesos
        ' 
        TB_GestionProcesos.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TB_GestionProcesos.Enabled = False
        TB_GestionProcesos.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TB_GestionProcesos.Location = New Point(187, 168)
        TB_GestionProcesos.Name = "TB_GestionProcesos"
        TB_GestionProcesos.Size = New Size(40, 23)
        TB_GestionProcesos.TabIndex = 19
        TB_GestionProcesos.TextAlign = HorizontalAlignment.Center
        ' 
        ' TB_BusinessInteligence
        ' 
        TB_BusinessInteligence.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TB_BusinessInteligence.Enabled = False
        TB_BusinessInteligence.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TB_BusinessInteligence.Location = New Point(187, 137)
        TB_BusinessInteligence.Name = "TB_BusinessInteligence"
        TB_BusinessInteligence.Size = New Size(40, 23)
        TB_BusinessInteligence.TabIndex = 18
        TB_BusinessInteligence.TextAlign = HorizontalAlignment.Center
        ' 
        ' RB_GestionProcesos
        ' 
        RB_GestionProcesos.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        RB_GestionProcesos.Appearance = Appearance.Button
        RB_GestionProcesos.Location = New Point(7, 167)
        RB_GestionProcesos.Name = "RB_GestionProcesos"
        RB_GestionProcesos.Size = New Size(174, 25)
        RB_GestionProcesos.TabIndex = 16
        RB_GestionProcesos.Text = "Gestión de procesos"
        RB_GestionProcesos.UseVisualStyleBackColor = True
        ' 
        ' RB_BusinessInteligence
        ' 
        RB_BusinessInteligence.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        RB_BusinessInteligence.Appearance = Appearance.Button
        RB_BusinessInteligence.Location = New Point(7, 136)
        RB_BusinessInteligence.Name = "RB_BusinessInteligence"
        RB_BusinessInteligence.Size = New Size(174, 25)
        RB_BusinessInteligence.TabIndex = 15
        RB_BusinessInteligence.Text = "Business Inteligence"
        RB_BusinessInteligence.UseVisualStyleBackColor = True
        ' 
        ' TB_totes
        ' 
        TB_totes.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TB_totes.Enabled = False
        TB_totes.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TB_totes.Location = New Point(187, 29)
        TB_totes.Name = "TB_totes"
        TB_totes.Size = New Size(40, 23)
        TB_totes.TabIndex = 13
        TB_totes.TextAlign = HorizontalAlignment.Center
        ' 
        ' RB_Totes
        ' 
        RB_Totes.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        RB_Totes.Appearance = Appearance.Button
        RB_Totes.Location = New Point(7, 28)
        RB_Totes.Name = "RB_Totes"
        RB_Totes.Size = New Size(174, 25)
        RB_Totes.TabIndex = 12
        RB_Totes.Text = "Totes les solucions"
        RB_Totes.UseVisualStyleBackColor = True
        ' 
        ' TB_ComercioElectronico
        ' 
        TB_ComercioElectronico.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TB_ComercioElectronico.Enabled = False
        TB_ComercioElectronico.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TB_ComercioElectronico.Location = New Point(187, 106)
        TB_ComercioElectronico.Name = "TB_ComercioElectronico"
        TB_ComercioElectronico.Size = New Size(40, 23)
        TB_ComercioElectronico.TabIndex = 10
        TB_ComercioElectronico.TextAlign = HorizontalAlignment.Center
        ' 
        ' TB_SitioWeb
        ' 
        TB_SitioWeb.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TB_SitioWeb.Enabled = False
        TB_SitioWeb.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TB_SitioWeb.Location = New Point(187, 75)
        TB_SitioWeb.Name = "TB_SitioWeb"
        TB_SitioWeb.Size = New Size(40, 23)
        TB_SitioWeb.TabIndex = 9
        TB_SitioWeb.TextAlign = HorizontalAlignment.Center
        ' 
        ' RB_SitioWeb
        ' 
        RB_SitioWeb.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        RB_SitioWeb.Appearance = Appearance.Button
        RB_SitioWeb.Location = New Point(7, 74)
        RB_SitioWeb.Name = "RB_SitioWeb"
        RB_SitioWeb.Size = New Size(174, 25)
        RB_SitioWeb.TabIndex = 6
        RB_SitioWeb.Text = "Sitio Web"
        RB_SitioWeb.UseVisualStyleBackColor = True
        ' 
        ' RB_ComercioElectronico
        ' 
        RB_ComercioElectronico.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        RB_ComercioElectronico.Appearance = Appearance.Button
        RB_ComercioElectronico.Location = New Point(7, 105)
        RB_ComercioElectronico.Name = "RB_ComercioElectronico"
        RB_ComercioElectronico.Size = New Size(174, 25)
        RB_ComercioElectronico.TabIndex = 7
        RB_ComercioElectronico.Text = "Comercio electrónico"
        RB_ComercioElectronico.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' Solucions
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(1631, 1034)
        Controls.Add(SplitContainer1)
        Controls.Add(Panel1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "Solucions"
        Text = "Solucions"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        CType(DataLlistat, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GB_TipusSolucions.ResumeLayout(False)
        GB_TipusSolucions.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents AdvertenciaCaducats As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents DataLlistat As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents contracte As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents nomEmpresa As TextBox
    Friend WithEvents GB_TipusSolucions As GroupBox
    Friend WithEvents TB_FacturaElectronica As TextBox
    Friend WithEvents CB_JaPresentades As CheckBox
    Friend WithEvents RB_FacturaElectronica As RadioButton
    Friend WithEvents TB_Ciberseguridad As TextBox
    Friend WithEvents TB_ComunicacionesSeguras As TextBox
    Friend WithEvents TB_OficinaVirtual As TextBox
    Friend WithEvents RB_OficinaVirtual As RadioButton
    Friend WithEvents RB_Ciberseguridad As RadioButton
    Friend WithEvents RB_ComunicacionesSeguras As RadioButton
    Friend WithEvents TB_GestionProcesos As TextBox
    Friend WithEvents TB_BusinessInteligence As TextBox
    Friend WithEvents RB_GestionProcesos As RadioButton
    Friend WithEvents RB_BusinessInteligence As RadioButton
    Friend WithEvents TB_totes As TextBox
    Friend WithEvents RB_Totes As RadioButton
    Friend WithEvents TB_ComercioElectronico As TextBox
    Friend WithEvents TB_SitioWeb As TextBox
    Friend WithEvents RB_SitioWeb As RadioButton
    Friend WithEvents RB_ComercioElectronico As RadioButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Btn_actualitzar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TB_Pagada As TextBox
    Friend WithEvents RB_Pagada As RadioButton
    Friend WithEvents TB_EsmenaIncorrecta As TextBox
    Friend WithEvents TB_FinalitzadaEsmena As TextBox
    Friend WithEvents RB_FinalitzadaEsmena As RadioButton
    Friend WithEvents RB_EsmenaIncorrecta As RadioButton
    Friend WithEvents TB_Presentada As TextBox
    Friend WithEvents RB_Presentada As RadioButton
    Friend WithEvents TB_ValidadaPagament As TextBox
    Friend WithEvents TB_EsmenaObert As TextBox
    Friend WithEvents RB_ValidadaPagament As RadioButton
    Friend WithEvents RB_EsmenaObert As RadioButton
    Friend WithEvents TB_TotsEstats As TextBox
    Friend WithEvents RB_TotsEstats As RadioButton
    Friend WithEvents TB_Esborrany As TextBox
    Friend WithEvents TB_Enviada As TextBox
    Friend WithEvents TB_PreparantDocumentacio As TextBox
    Friend WithEvents RB_PreparantDocumentacio As RadioButton
    Friend WithEvents RB_Esborrany As RadioButton
    Friend WithEvents RB_Enviada As RadioButton
    Friend WithEvents RB_segona As RadioButton
    Friend WithEvents RB_primera As RadioButton
    Friend WithEvents TB_NoPagada As TextBox
    Friend WithEvents RB_NoPagada As RadioButton
    Friend WithEvents TB_DocumentacioAddicional As TextBox
    Friend WithEvents RB_DocumentacioAddicional As RadioButton
    Friend WithEvents TB_PagamentMinorat As TextBox
    Friend WithEvents RB_PagamentMinorat As RadioButton
    Friend WithEvents btn_importarExcel As Button
    Friend WithEvents PB_importarExcel As ProgressBar
    Friend WithEvents TB_Puestoseguro As TextBox
    Friend WithEvents RB_PuestoSeguro As RadioButton
End Class
