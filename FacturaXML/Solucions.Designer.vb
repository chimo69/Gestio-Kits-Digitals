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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_actualitzar = New System.Windows.Forms.Button()
        Me.AdvertenciaCaducats = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DataLlistat = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.contracte = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nomEmpresa = New System.Windows.Forms.TextBox()
        Me.GB_TipusSolucions = New System.Windows.Forms.GroupBox()
        Me.TB_FacturaElectronica = New System.Windows.Forms.TextBox()
        Me.CB_JaPresentades = New System.Windows.Forms.CheckBox()
        Me.RB_FacturaElectronica = New System.Windows.Forms.RadioButton()
        Me.TB_Ciberseguridad = New System.Windows.Forms.TextBox()
        Me.TB_ComunicacionesSeguras = New System.Windows.Forms.TextBox()
        Me.TB_OficinaVirtual = New System.Windows.Forms.TextBox()
        Me.RB_OficinaVirtual = New System.Windows.Forms.RadioButton()
        Me.RB_Ciberseguridad = New System.Windows.Forms.RadioButton()
        Me.RB_ComunicacionesSeguras = New System.Windows.Forms.RadioButton()
        Me.TB_GestionClientes = New System.Windows.Forms.TextBox()
        Me.RB_GestionClientes = New System.Windows.Forms.RadioButton()
        Me.TB_GestionProcesos = New System.Windows.Forms.TextBox()
        Me.TB_BusinessInteligence = New System.Windows.Forms.TextBox()
        Me.RB_GestionProcesos = New System.Windows.Forms.RadioButton()
        Me.RB_BusinessInteligence = New System.Windows.Forms.RadioButton()
        Me.TB_totes = New System.Windows.Forms.TextBox()
        Me.RB_Totes = New System.Windows.Forms.RadioButton()
        Me.TB_RedesSociales = New System.Windows.Forms.TextBox()
        Me.TB_ComercioElectronico = New System.Windows.Forms.TextBox()
        Me.TB_SitioWeb = New System.Windows.Forms.TextBox()
        Me.RB_SitioWeb = New System.Windows.Forms.RadioButton()
        Me.RB_RedesSociales = New System.Windows.Forms.RadioButton()
        Me.RB_ComercioElectronico = New System.Windows.Forms.RadioButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataLlistat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_TipusSolucions.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Btn_actualitzar)
        Me.Panel1.Controls.Add(Me.AdvertenciaCaducats)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1631, 53)
        Me.Panel1.TabIndex = 0
        '
        'Btn_actualitzar
        '
        Me.Btn_actualitzar.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_actualitzar.BackgroundImage = Global.FacturaXML.My.Resources.Resources.recargar1
        Me.Btn_actualitzar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_actualitzar.FlatAppearance.BorderSize = 0
        Me.Btn_actualitzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_actualitzar.Location = New System.Drawing.Point(513, 7)
        Me.Btn_actualitzar.Name = "Btn_actualitzar"
        Me.Btn_actualitzar.Size = New System.Drawing.Size(40, 40)
        Me.Btn_actualitzar.TabIndex = 20
        Me.Btn_actualitzar.UseVisualStyleBackColor = False
        '
        'AdvertenciaCaducats
        '
        Me.AdvertenciaCaducats.AutoSize = True
        Me.AdvertenciaCaducats.BackColor = System.Drawing.SystemColors.Control
        Me.AdvertenciaCaducats.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AdvertenciaCaducats.ForeColor = System.Drawing.Color.Red
        Me.AdvertenciaCaducats.Location = New System.Drawing.Point(633, 10)
        Me.AdvertenciaCaducats.Name = "AdvertenciaCaducats"
        Me.AdvertenciaCaducats.Size = New System.Drawing.Size(375, 29)
        Me.AdvertenciaCaducats.TabIndex = 18
        Me.AdvertenciaCaducats.Text = "Atenció! Solucions apunt de caducar"
        Me.AdvertenciaCaducats.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(218, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(279, 15)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "(Doble click per accedir a les dades de cada solució)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 30)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Llistat de solucions"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 53)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.DataLlistat)
        Me.SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(20, 0, 0, 20)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.contracte)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.nomEmpresa)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GB_TipusSolucions)
        Me.SplitContainer1.Size = New System.Drawing.Size(1631, 603)
        Me.SplitContainer1.SplitterDistance = 1371
        Me.SplitContainer1.TabIndex = 1
        '
        'DataLlistat
        '
        Me.DataLlistat.AllowUserToAddRows = False
        Me.DataLlistat.AllowUserToDeleteRows = False
        Me.DataLlistat.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataLlistat.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataLlistat.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataLlistat.ColumnHeadersHeight = 40
        Me.DataLlistat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataLlistat.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataLlistat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLlistat.EnableHeadersVisualStyles = False
        Me.DataLlistat.Location = New System.Drawing.Point(20, 0)
        Me.DataLlistat.MultiSelect = False
        Me.DataLlistat.Name = "DataLlistat"
        Me.DataLlistat.ReadOnly = True
        Me.DataLlistat.RowHeadersVisible = False
        DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.DataLlistat.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DataLlistat.RowTemplate.Height = 25
        Me.DataLlistat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataLlistat.ShowEditingIcon = False
        Me.DataLlistat.Size = New System.Drawing.Size(1351, 583)
        Me.DataLlistat.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 544)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 15)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Buscar per contracte"
        '
        'contracte
        '
        Me.contracte.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.contracte.Location = New System.Drawing.Point(14, 562)
        Me.contracte.Name = "contracte"
        Me.contracte.Size = New System.Drawing.Size(220, 23)
        Me.contracte.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 468)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 15)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Buscar per empresa"
        '
        'nomEmpresa
        '
        Me.nomEmpresa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nomEmpresa.Location = New System.Drawing.Point(14, 486)
        Me.nomEmpresa.Name = "nomEmpresa"
        Me.nomEmpresa.Size = New System.Drawing.Size(220, 23)
        Me.nomEmpresa.TabIndex = 16
        '
        'GB_TipusSolucions
        '
        Me.GB_TipusSolucions.Controls.Add(Me.TB_FacturaElectronica)
        Me.GB_TipusSolucions.Controls.Add(Me.CB_JaPresentades)
        Me.GB_TipusSolucions.Controls.Add(Me.RB_FacturaElectronica)
        Me.GB_TipusSolucions.Controls.Add(Me.TB_Ciberseguridad)
        Me.GB_TipusSolucions.Controls.Add(Me.TB_ComunicacionesSeguras)
        Me.GB_TipusSolucions.Controls.Add(Me.TB_OficinaVirtual)
        Me.GB_TipusSolucions.Controls.Add(Me.RB_OficinaVirtual)
        Me.GB_TipusSolucions.Controls.Add(Me.RB_Ciberseguridad)
        Me.GB_TipusSolucions.Controls.Add(Me.RB_ComunicacionesSeguras)
        Me.GB_TipusSolucions.Controls.Add(Me.TB_GestionClientes)
        Me.GB_TipusSolucions.Controls.Add(Me.RB_GestionClientes)
        Me.GB_TipusSolucions.Controls.Add(Me.TB_GestionProcesos)
        Me.GB_TipusSolucions.Controls.Add(Me.TB_BusinessInteligence)
        Me.GB_TipusSolucions.Controls.Add(Me.RB_GestionProcesos)
        Me.GB_TipusSolucions.Controls.Add(Me.RB_BusinessInteligence)
        Me.GB_TipusSolucions.Controls.Add(Me.TB_totes)
        Me.GB_TipusSolucions.Controls.Add(Me.RB_Totes)
        Me.GB_TipusSolucions.Controls.Add(Me.TB_RedesSociales)
        Me.GB_TipusSolucions.Controls.Add(Me.TB_ComercioElectronico)
        Me.GB_TipusSolucions.Controls.Add(Me.TB_SitioWeb)
        Me.GB_TipusSolucions.Controls.Add(Me.RB_SitioWeb)
        Me.GB_TipusSolucions.Controls.Add(Me.RB_RedesSociales)
        Me.GB_TipusSolucions.Controls.Add(Me.RB_ComercioElectronico)
        Me.GB_TipusSolucions.Location = New System.Drawing.Point(11, 0)
        Me.GB_TipusSolucions.Name = "GB_TipusSolucions"
        Me.GB_TipusSolucions.Size = New System.Drawing.Size(236, 441)
        Me.GB_TipusSolucions.TabIndex = 15
        Me.GB_TipusSolucions.TabStop = False
        Me.GB_TipusSolucions.Text = "Tipus de solucions"
        '
        'TB_FacturaElectronica
        '
        Me.TB_FacturaElectronica.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_FacturaElectronica.Enabled = False
        Me.TB_FacturaElectronica.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_FacturaElectronica.Location = New System.Drawing.Point(187, 261)
        Me.TB_FacturaElectronica.Name = "TB_FacturaElectronica"
        Me.TB_FacturaElectronica.Size = New System.Drawing.Size(40, 23)
        Me.TB_FacturaElectronica.TabIndex = 29
        Me.TB_FacturaElectronica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CB_JaPresentades
        '
        Me.CB_JaPresentades.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CB_JaPresentades.AutoSize = True
        Me.CB_JaPresentades.Location = New System.Drawing.Point(7, 406)
        Me.CB_JaPresentades.Name = "CB_JaPresentades"
        Me.CB_JaPresentades.Size = New System.Drawing.Size(189, 19)
        Me.CB_JaPresentades.TabIndex = 5
        Me.CB_JaPresentades.Text = "Mostrar solucions ja aprovades"
        Me.CB_JaPresentades.UseVisualStyleBackColor = True
        '
        'RB_FacturaElectronica
        '
        Me.RB_FacturaElectronica.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RB_FacturaElectronica.Appearance = System.Windows.Forms.Appearance.Button
        Me.RB_FacturaElectronica.Location = New System.Drawing.Point(7, 260)
        Me.RB_FacturaElectronica.Name = "RB_FacturaElectronica"
        Me.RB_FacturaElectronica.Size = New System.Drawing.Size(174, 25)
        Me.RB_FacturaElectronica.TabIndex = 28
        Me.RB_FacturaElectronica.Text = "Factura electrónica"
        Me.RB_FacturaElectronica.UseVisualStyleBackColor = True
        '
        'TB_Ciberseguridad
        '
        Me.TB_Ciberseguridad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_Ciberseguridad.Enabled = False
        Me.TB_Ciberseguridad.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_Ciberseguridad.Location = New System.Drawing.Point(187, 354)
        Me.TB_Ciberseguridad.Name = "TB_Ciberseguridad"
        Me.TB_Ciberseguridad.Size = New System.Drawing.Size(40, 23)
        Me.TB_Ciberseguridad.TabIndex = 27
        Me.TB_Ciberseguridad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TB_ComunicacionesSeguras
        '
        Me.TB_ComunicacionesSeguras.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_ComunicacionesSeguras.Enabled = False
        Me.TB_ComunicacionesSeguras.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_ComunicacionesSeguras.Location = New System.Drawing.Point(187, 323)
        Me.TB_ComunicacionesSeguras.Name = "TB_ComunicacionesSeguras"
        Me.TB_ComunicacionesSeguras.Size = New System.Drawing.Size(40, 23)
        Me.TB_ComunicacionesSeguras.TabIndex = 26
        Me.TB_ComunicacionesSeguras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TB_OficinaVirtual
        '
        Me.TB_OficinaVirtual.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_OficinaVirtual.Enabled = False
        Me.TB_OficinaVirtual.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_OficinaVirtual.Location = New System.Drawing.Point(187, 292)
        Me.TB_OficinaVirtual.Name = "TB_OficinaVirtual"
        Me.TB_OficinaVirtual.Size = New System.Drawing.Size(40, 23)
        Me.TB_OficinaVirtual.TabIndex = 25
        Me.TB_OficinaVirtual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RB_OficinaVirtual
        '
        Me.RB_OficinaVirtual.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RB_OficinaVirtual.Appearance = System.Windows.Forms.Appearance.Button
        Me.RB_OficinaVirtual.Location = New System.Drawing.Point(7, 291)
        Me.RB_OficinaVirtual.Name = "RB_OficinaVirtual"
        Me.RB_OficinaVirtual.Size = New System.Drawing.Size(174, 25)
        Me.RB_OficinaVirtual.TabIndex = 22
        Me.RB_OficinaVirtual.Text = "Oficina virtual"
        Me.RB_OficinaVirtual.UseVisualStyleBackColor = True
        '
        'RB_Ciberseguridad
        '
        Me.RB_Ciberseguridad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RB_Ciberseguridad.Appearance = System.Windows.Forms.Appearance.Button
        Me.RB_Ciberseguridad.Location = New System.Drawing.Point(7, 353)
        Me.RB_Ciberseguridad.Name = "RB_Ciberseguridad"
        Me.RB_Ciberseguridad.Size = New System.Drawing.Size(174, 25)
        Me.RB_Ciberseguridad.TabIndex = 24
        Me.RB_Ciberseguridad.Text = "Ciberseguridad"
        Me.RB_Ciberseguridad.UseVisualStyleBackColor = True
        '
        'RB_ComunicacionesSeguras
        '
        Me.RB_ComunicacionesSeguras.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RB_ComunicacionesSeguras.Appearance = System.Windows.Forms.Appearance.Button
        Me.RB_ComunicacionesSeguras.Location = New System.Drawing.Point(7, 322)
        Me.RB_ComunicacionesSeguras.Name = "RB_ComunicacionesSeguras"
        Me.RB_ComunicacionesSeguras.Size = New System.Drawing.Size(174, 25)
        Me.RB_ComunicacionesSeguras.TabIndex = 23
        Me.RB_ComunicacionesSeguras.Text = "Comunicaciones seguras"
        Me.RB_ComunicacionesSeguras.UseVisualStyleBackColor = True
        '
        'TB_GestionClientes
        '
        Me.TB_GestionClientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_GestionClientes.Enabled = False
        Me.TB_GestionClientes.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_GestionClientes.Location = New System.Drawing.Point(187, 168)
        Me.TB_GestionClientes.Name = "TB_GestionClientes"
        Me.TB_GestionClientes.Size = New System.Drawing.Size(40, 23)
        Me.TB_GestionClientes.TabIndex = 21
        Me.TB_GestionClientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RB_GestionClientes
        '
        Me.RB_GestionClientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RB_GestionClientes.Appearance = System.Windows.Forms.Appearance.Button
        Me.RB_GestionClientes.Location = New System.Drawing.Point(7, 167)
        Me.RB_GestionClientes.Name = "RB_GestionClientes"
        Me.RB_GestionClientes.Size = New System.Drawing.Size(174, 25)
        Me.RB_GestionClientes.TabIndex = 20
        Me.RB_GestionClientes.Text = "Gestión de clientes"
        Me.RB_GestionClientes.UseVisualStyleBackColor = True
        '
        'TB_GestionProcesos
        '
        Me.TB_GestionProcesos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_GestionProcesos.Enabled = False
        Me.TB_GestionProcesos.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_GestionProcesos.Location = New System.Drawing.Point(187, 230)
        Me.TB_GestionProcesos.Name = "TB_GestionProcesos"
        Me.TB_GestionProcesos.Size = New System.Drawing.Size(40, 23)
        Me.TB_GestionProcesos.TabIndex = 19
        Me.TB_GestionProcesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TB_BusinessInteligence
        '
        Me.TB_BusinessInteligence.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_BusinessInteligence.Enabled = False
        Me.TB_BusinessInteligence.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_BusinessInteligence.Location = New System.Drawing.Point(187, 199)
        Me.TB_BusinessInteligence.Name = "TB_BusinessInteligence"
        Me.TB_BusinessInteligence.Size = New System.Drawing.Size(40, 23)
        Me.TB_BusinessInteligence.TabIndex = 18
        Me.TB_BusinessInteligence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RB_GestionProcesos
        '
        Me.RB_GestionProcesos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RB_GestionProcesos.Appearance = System.Windows.Forms.Appearance.Button
        Me.RB_GestionProcesos.Location = New System.Drawing.Point(7, 229)
        Me.RB_GestionProcesos.Name = "RB_GestionProcesos"
        Me.RB_GestionProcesos.Size = New System.Drawing.Size(174, 25)
        Me.RB_GestionProcesos.TabIndex = 16
        Me.RB_GestionProcesos.Text = "Gestión de procesos"
        Me.RB_GestionProcesos.UseVisualStyleBackColor = True
        '
        'RB_BusinessInteligence
        '
        Me.RB_BusinessInteligence.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RB_BusinessInteligence.Appearance = System.Windows.Forms.Appearance.Button
        Me.RB_BusinessInteligence.Location = New System.Drawing.Point(7, 198)
        Me.RB_BusinessInteligence.Name = "RB_BusinessInteligence"
        Me.RB_BusinessInteligence.Size = New System.Drawing.Size(174, 25)
        Me.RB_BusinessInteligence.TabIndex = 15
        Me.RB_BusinessInteligence.Text = "Business Inteligence"
        Me.RB_BusinessInteligence.UseVisualStyleBackColor = True
        '
        'TB_totes
        '
        Me.TB_totes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_totes.Enabled = False
        Me.TB_totes.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_totes.Location = New System.Drawing.Point(187, 29)
        Me.TB_totes.Name = "TB_totes"
        Me.TB_totes.Size = New System.Drawing.Size(40, 23)
        Me.TB_totes.TabIndex = 13
        Me.TB_totes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RB_Totes
        '
        Me.RB_Totes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RB_Totes.Appearance = System.Windows.Forms.Appearance.Button
        Me.RB_Totes.Location = New System.Drawing.Point(7, 28)
        Me.RB_Totes.Name = "RB_Totes"
        Me.RB_Totes.Size = New System.Drawing.Size(174, 25)
        Me.RB_Totes.TabIndex = 12
        Me.RB_Totes.Text = "Totes les solucions"
        Me.RB_Totes.UseVisualStyleBackColor = True
        '
        'TB_RedesSociales
        '
        Me.TB_RedesSociales.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_RedesSociales.Enabled = False
        Me.TB_RedesSociales.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_RedesSociales.Location = New System.Drawing.Point(187, 137)
        Me.TB_RedesSociales.Name = "TB_RedesSociales"
        Me.TB_RedesSociales.Size = New System.Drawing.Size(40, 23)
        Me.TB_RedesSociales.TabIndex = 11
        Me.TB_RedesSociales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TB_ComercioElectronico
        '
        Me.TB_ComercioElectronico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_ComercioElectronico.Enabled = False
        Me.TB_ComercioElectronico.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_ComercioElectronico.Location = New System.Drawing.Point(187, 106)
        Me.TB_ComercioElectronico.Name = "TB_ComercioElectronico"
        Me.TB_ComercioElectronico.Size = New System.Drawing.Size(40, 23)
        Me.TB_ComercioElectronico.TabIndex = 10
        Me.TB_ComercioElectronico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TB_SitioWeb
        '
        Me.TB_SitioWeb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_SitioWeb.Enabled = False
        Me.TB_SitioWeb.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_SitioWeb.Location = New System.Drawing.Point(187, 75)
        Me.TB_SitioWeb.Name = "TB_SitioWeb"
        Me.TB_SitioWeb.Size = New System.Drawing.Size(40, 23)
        Me.TB_SitioWeb.TabIndex = 9
        Me.TB_SitioWeb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RB_SitioWeb
        '
        Me.RB_SitioWeb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RB_SitioWeb.Appearance = System.Windows.Forms.Appearance.Button
        Me.RB_SitioWeb.Location = New System.Drawing.Point(7, 74)
        Me.RB_SitioWeb.Name = "RB_SitioWeb"
        Me.RB_SitioWeb.Size = New System.Drawing.Size(174, 25)
        Me.RB_SitioWeb.TabIndex = 6
        Me.RB_SitioWeb.Text = "Sitio Web"
        Me.RB_SitioWeb.UseVisualStyleBackColor = True
        '
        'RB_RedesSociales
        '
        Me.RB_RedesSociales.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RB_RedesSociales.Appearance = System.Windows.Forms.Appearance.Button
        Me.RB_RedesSociales.Location = New System.Drawing.Point(7, 136)
        Me.RB_RedesSociales.Name = "RB_RedesSociales"
        Me.RB_RedesSociales.Size = New System.Drawing.Size(174, 25)
        Me.RB_RedesSociales.TabIndex = 8
        Me.RB_RedesSociales.Text = "Gestión de redes sociales"
        Me.RB_RedesSociales.UseVisualStyleBackColor = True
        '
        'RB_ComercioElectronico
        '
        Me.RB_ComercioElectronico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RB_ComercioElectronico.Appearance = System.Windows.Forms.Appearance.Button
        Me.RB_ComercioElectronico.Location = New System.Drawing.Point(7, 105)
        Me.RB_ComercioElectronico.Name = "RB_ComercioElectronico"
        Me.RB_ComercioElectronico.Size = New System.Drawing.Size(174, 25)
        Me.RB_ComercioElectronico.TabIndex = 7
        Me.RB_ComercioElectronico.Text = "Comercio electrónico"
        Me.RB_ComercioElectronico.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Solucions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1631, 656)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Solucions"
        Me.Text = "Solucions"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataLlistat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_TipusSolucions.ResumeLayout(False)
        Me.GB_TipusSolucions.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents AdvertenciaCaducats As Label
    Friend WithEvents Label2 As Label
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
    Friend WithEvents TB_GestionClientes As TextBox
    Friend WithEvents RB_GestionClientes As RadioButton
    Friend WithEvents TB_GestionProcesos As TextBox
    Friend WithEvents TB_BusinessInteligence As TextBox
    Friend WithEvents RB_GestionProcesos As RadioButton
    Friend WithEvents RB_BusinessInteligence As RadioButton
    Friend WithEvents TB_totes As TextBox
    Friend WithEvents RB_Totes As RadioButton
    Friend WithEvents TB_RedesSociales As TextBox
    Friend WithEvents TB_ComercioElectronico As TextBox
    Friend WithEvents TB_SitioWeb As TextBox
    Friend WithEvents RB_SitioWeb As RadioButton
    Friend WithEvents RB_RedesSociales As RadioButton
    Friend WithEvents RB_ComercioElectronico As RadioButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Btn_actualitzar As Button
End Class
