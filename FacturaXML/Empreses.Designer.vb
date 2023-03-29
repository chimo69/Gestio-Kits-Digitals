<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Empreses
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Empreses))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DataEmpreses = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataSolucions = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_BonusRestant = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_BonusConsumit = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TB_BonusConcedit = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Lbl_SitioWeb = New System.Windows.Forms.Label()
        Me.Lbl_Comercio = New System.Windows.Forms.Label()
        Me.Lbl_BI = New System.Windows.Forms.Label()
        Me.Lbl_Procesos = New System.Windows.Forms.Label()
        Me.Lbl_Factura = New System.Windows.Forms.Label()
        Me.Lbl_Oficina = New System.Windows.Forms.Label()
        Me.Lbl_Comunicaciones = New System.Windows.Forms.Label()
        Me.Lbl_Ciberseguridad = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TB_Segment = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TB_NumeroSolucions = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lbl_NomEmpresa = New System.Windows.Forms.Label()
        Me.Lbl_Direccio = New System.Windows.Forms.Label()
        Me.Btn_SenseFiltre = New System.Windows.Forms.Button()
        Me.TB_CampSeleccionat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextABuscar = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CB_MostrarContractes = New System.Windows.Forms.CheckBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataEmpreses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSolucions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DataEmpreses)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1658, 877)
        Me.SplitContainer1.SplitterDistance = 850
        Me.SplitContainer1.TabIndex = 9
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(174, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataEmpreses.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataEmpreses.ColumnHeadersHeight = 30
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(174, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataEmpreses.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataEmpreses.EnableHeadersVisualStyles = False
        Me.DataEmpreses.Location = New System.Drawing.Point(26, 6)
        Me.DataEmpreses.Name = "DataEmpreses"
        Me.DataEmpreses.ReadOnly = True
        Me.DataEmpreses.RowHeadersVisible = False
        Me.DataEmpreses.RowTemplate.Height = 25
        Me.DataEmpreses.ShowEditingIcon = False
        Me.DataEmpreses.Size = New System.Drawing.Size(809, 841)
        Me.DataEmpreses.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DataSolucions)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TB_BonusRestant)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TB_BonusConsumit)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.TB_BonusConcedit)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 178)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(786, 209)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Subvencions"
        '
        'DataSolucions
        '
        Me.DataSolucions.AllowUserToAddRows = False
        Me.DataSolucions.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataSolucions.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataSolucions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataSolucions.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataSolucions.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataSolucions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal
        Me.DataSolucions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataSolucions.ColumnHeadersVisible = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataSolucions.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataSolucions.Location = New System.Drawing.Point(6, 22)
        Me.DataSolucions.Name = "DataSolucions"
        Me.DataSolucions.ReadOnly = True
        Me.DataSolucions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DataSolucions.RowHeadersVisible = False
        Me.DataSolucions.RowTemplate.Height = 25
        Me.DataSolucions.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DataSolucions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataSolucions.ShowEditingIcon = False
        Me.DataSolucions.Size = New System.Drawing.Size(381, 181)
        Me.DataSolucions.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(597, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 20)
        Me.Label5.TabIndex = 108
        Me.Label5.Text = "€"
        '
        'TB_BonusRestant
        '
        Me.TB_BonusRestant.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_BonusRestant.Location = New System.Drawing.Point(528, 96)
        Me.TB_BonusRestant.Name = "TB_BonusRestant"
        Me.TB_BonusRestant.ReadOnly = True
        Me.TB_BonusRestant.Size = New System.Drawing.Size(63, 29)
        Me.TB_BonusRestant.TabIndex = 107
        Me.TB_BonusRestant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(393, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 21)
        Me.Label6.TabIndex = 106
        Me.Label6.Text = "Bonus restant"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(597, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 20)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "€"
        '
        'TB_BonusConsumit
        '
        Me.TB_BonusConsumit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_BonusConsumit.Location = New System.Drawing.Point(528, 57)
        Me.TB_BonusConsumit.Name = "TB_BonusConsumit"
        Me.TB_BonusConsumit.ReadOnly = True
        Me.TB_BonusConsumit.Size = New System.Drawing.Size(63, 29)
        Me.TB_BonusConsumit.TabIndex = 104
        Me.TB_BonusConsumit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label23.Location = New System.Drawing.Point(597, 20)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(18, 20)
        Me.Label23.TabIndex = 103
        Me.Label23.Text = "€"
        '
        'TB_BonusConcedit
        '
        Me.TB_BonusConcedit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TB_BonusConcedit.Location = New System.Drawing.Point(528, 18)
        Me.TB_BonusConcedit.Name = "TB_BonusConcedit"
        Me.TB_BonusConcedit.ReadOnly = True
        Me.TB_BonusConcedit.Size = New System.Drawing.Size(63, 29)
        Me.TB_BonusConcedit.TabIndex = 3
        Me.TB_BonusConcedit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(393, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Bonus consumit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(393, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bonus concedit"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.Controls.Add(Me.Lbl_SitioWeb)
        Me.FlowLayoutPanel1.Controls.Add(Me.Lbl_Comercio)
        Me.FlowLayoutPanel1.Controls.Add(Me.Lbl_BI)
        Me.FlowLayoutPanel1.Controls.Add(Me.Lbl_Procesos)
        Me.FlowLayoutPanel1.Controls.Add(Me.Lbl_Factura)
        Me.FlowLayoutPanel1.Controls.Add(Me.Lbl_Oficina)
        Me.FlowLayoutPanel1.Controls.Add(Me.Lbl_Comunicaciones)
        Me.FlowLayoutPanel1.Controls.Add(Me.Lbl_Ciberseguridad)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 83)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(789, 89)
        Me.FlowLayoutPanel1.TabIndex = 25
        '
        'Lbl_SitioWeb
        '
        Me.Lbl_SitioWeb.AutoSize = True
        Me.Lbl_SitioWeb.BackColor = System.Drawing.SystemColors.Control
        Me.Lbl_SitioWeb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_SitioWeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lbl_SitioWeb.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_SitioWeb.Location = New System.Drawing.Point(3, 3)
        Me.Lbl_SitioWeb.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Lbl_SitioWeb.Name = "Lbl_SitioWeb"
        Me.Lbl_SitioWeb.Size = New System.Drawing.Size(75, 22)
        Me.Lbl_SitioWeb.TabIndex = 17
        Me.Lbl_SitioWeb.Text = "Sitio Web"
        '
        'Lbl_Comercio
        '
        Me.Lbl_Comercio.AutoSize = True
        Me.Lbl_Comercio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_Comercio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lbl_Comercio.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_Comercio.Location = New System.Drawing.Point(84, 3)
        Me.Lbl_Comercio.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Lbl_Comercio.Name = "Lbl_Comercio"
        Me.Lbl_Comercio.Size = New System.Drawing.Size(153, 22)
        Me.Lbl_Comercio.TabIndex = 26
        Me.Lbl_Comercio.Text = "Comercio electrónico"
        '
        'Lbl_BI
        '
        Me.Lbl_BI.AutoSize = True
        Me.Lbl_BI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_BI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lbl_BI.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_BI.Location = New System.Drawing.Point(243, 3)
        Me.Lbl_BI.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Lbl_BI.Name = "Lbl_BI"
        Me.Lbl_BI.Size = New System.Drawing.Size(147, 22)
        Me.Lbl_BI.TabIndex = 26
        Me.Lbl_BI.Text = "Business Intelligence"
        '
        'Lbl_Procesos
        '
        Me.Lbl_Procesos.AutoSize = True
        Me.Lbl_Procesos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_Procesos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lbl_Procesos.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_Procesos.Location = New System.Drawing.Point(396, 3)
        Me.Lbl_Procesos.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Lbl_Procesos.Name = "Lbl_Procesos"
        Me.Lbl_Procesos.Size = New System.Drawing.Size(145, 22)
        Me.Lbl_Procesos.TabIndex = 26
        Me.Lbl_Procesos.Text = "Gestión de procesos"
        '
        'Lbl_Factura
        '
        Me.Lbl_Factura.AutoSize = True
        Me.Lbl_Factura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_Factura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lbl_Factura.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_Factura.Location = New System.Drawing.Point(547, 3)
        Me.Lbl_Factura.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Lbl_Factura.Name = "Lbl_Factura"
        Me.Lbl_Factura.Size = New System.Drawing.Size(135, 22)
        Me.Lbl_Factura.TabIndex = 24
        Me.Lbl_Factura.Text = "Factura electrónica"
        '
        'Lbl_Oficina
        '
        Me.Lbl_Oficina.AutoSize = True
        Me.Lbl_Oficina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_Oficina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lbl_Oficina.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_Oficina.Location = New System.Drawing.Point(3, 28)
        Me.Lbl_Oficina.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Lbl_Oficina.Name = "Lbl_Oficina"
        Me.Lbl_Oficina.Size = New System.Drawing.Size(103, 22)
        Me.Lbl_Oficina.TabIndex = 23
        Me.Lbl_Oficina.Text = "Oficina virtual"
        '
        'Lbl_Comunicaciones
        '
        Me.Lbl_Comunicaciones.AutoSize = True
        Me.Lbl_Comunicaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_Comunicaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lbl_Comunicaciones.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_Comunicaciones.Location = New System.Drawing.Point(112, 28)
        Me.Lbl_Comunicaciones.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Lbl_Comunicaciones.Name = "Lbl_Comunicaciones"
        Me.Lbl_Comunicaciones.Size = New System.Drawing.Size(173, 22)
        Me.Lbl_Comunicaciones.TabIndex = 22
        Me.Lbl_Comunicaciones.Text = "Comunicaciones seguras"
        '
        'Lbl_Ciberseguridad
        '
        Me.Lbl_Ciberseguridad.AutoSize = True
        Me.Lbl_Ciberseguridad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_Ciberseguridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lbl_Ciberseguridad.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_Ciberseguridad.Location = New System.Drawing.Point(291, 28)
        Me.Lbl_Ciberseguridad.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Lbl_Ciberseguridad.Name = "Lbl_Ciberseguridad"
        Me.Lbl_Ciberseguridad.Size = New System.Drawing.Size(112, 22)
        Me.Lbl_Ciberseguridad.TabIndex = 21
        Me.Lbl_Ciberseguridad.Text = "Ciberseguridad"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.TB_Segment)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TB_NumeroSolucions)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Lbl_NomEmpresa)
        Me.Panel1.Controls.Add(Me.Lbl_Direccio)
        Me.Panel1.Location = New System.Drawing.Point(3, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(789, 71)
        Me.Panel1.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(657, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 15)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Segment"
        '
        'TB_Segment
        '
        Me.TB_Segment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_Segment.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TB_Segment.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TB_Segment.Location = New System.Drawing.Point(667, 20)
        Me.TB_Segment.Name = "TB_Segment"
        Me.TB_Segment.ReadOnly = True
        Me.TB_Segment.Size = New System.Drawing.Size(34, 43)
        Me.TB_Segment.TabIndex = 19
        Me.TB_Segment.Text = "0"
        Me.TB_Segment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(712, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 15)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Contractes"
        '
        'TB_NumeroSolucions
        '
        Me.TB_NumeroSolucions.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_NumeroSolucions.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TB_NumeroSolucions.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TB_NumeroSolucions.Location = New System.Drawing.Point(727, 20)
        Me.TB_NumeroSolucions.Name = "TB_NumeroSolucions"
        Me.TB_NumeroSolucions.ReadOnly = True
        Me.TB_NumeroSolucions.Size = New System.Drawing.Size(34, 43)
        Me.TB_NumeroSolucions.TabIndex = 17
        Me.TB_NumeroSolucions.Text = "0"
        Me.TB_NumeroSolucions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FacturaXML.My.Resources.Resources.empresa
        Me.PictureBox1.Location = New System.Drawing.Point(8, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 43)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Lbl_NomEmpresa
        '
        Me.Lbl_NomEmpresa.AutoSize = True
        Me.Lbl_NomEmpresa.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_NomEmpresa.Location = New System.Drawing.Point(83, 15)
        Me.Lbl_NomEmpresa.Name = "Lbl_NomEmpresa"
        Me.Lbl_NomEmpresa.Size = New System.Drawing.Size(113, 21)
        Me.Lbl_NomEmpresa.TabIndex = 14
        Me.Lbl_NomEmpresa.Text = "Nom empresa"
        Me.Lbl_NomEmpresa.Visible = False
        '
        'Lbl_Direccio
        '
        Me.Lbl_Direccio.AutoSize = True
        Me.Lbl_Direccio.Location = New System.Drawing.Point(85, 39)
        Me.Lbl_Direccio.Name = "Lbl_Direccio"
        Me.Lbl_Direccio.Size = New System.Drawing.Size(50, 15)
        Me.Lbl_Direccio.TabIndex = 15
        Me.Lbl_Direccio.Text = "Direccio"
        Me.Lbl_Direccio.Visible = False
        '
        'Btn_SenseFiltre
        '
        Me.Btn_SenseFiltre.FlatAppearance.BorderSize = 0
        Me.Btn_SenseFiltre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_SenseFiltre.Font = New System.Drawing.Font("Webdings", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Btn_SenseFiltre.Image = Global.FacturaXML.My.Resources.Resources.icono_eliminar
        Me.Btn_SenseFiltre.Location = New System.Drawing.Point(440, 12)
        Me.Btn_SenseFiltre.Name = "Btn_SenseFiltre"
        Me.Btn_SenseFiltre.Size = New System.Drawing.Size(24, 23)
        Me.Btn_SenseFiltre.TabIndex = 13
        Me.Btn_SenseFiltre.UseVisualStyleBackColor = True
        '
        'TB_CampSeleccionat
        '
        Me.TB_CampSeleccionat.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TB_CampSeleccionat.Location = New System.Drawing.Point(187, 12)
        Me.TB_CampSeleccionat.Name = "TB_CampSeleccionat"
        Me.TB_CampSeleccionat.ReadOnly = True
        Me.TB_CampSeleccionat.Size = New System.Drawing.Size(100, 23)
        Me.TB_CampSeleccionat.TabIndex = 12
        Me.TB_CampSeleccionat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Cercar pel camp seleccionat"
        '
        'TextABuscar
        '
        Me.TextABuscar.Location = New System.Drawing.Point(293, 12)
        Me.TextABuscar.Name = "TextABuscar"
        Me.TextABuscar.Size = New System.Drawing.Size(141, 23)
        Me.TextABuscar.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CB_MostrarContractes)
        Me.Panel2.Controls.Add(Me.Btn_SenseFiltre)
        Me.Panel2.Controls.Add(Me.TextABuscar)
        Me.Panel2.Controls.Add(Me.TB_CampSeleccionat)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1658, 48)
        Me.Panel2.TabIndex = 10
        '
        'CB_MostrarContractes
        '
        Me.CB_MostrarContractes.AutoSize = True
        Me.CB_MostrarContractes.Location = New System.Drawing.Point(486, 14)
        Me.CB_MostrarContractes.Name = "CB_MostrarContractes"
        Me.CB_MostrarContractes.Size = New System.Drawing.Size(205, 19)
        Me.CB_MostrarContractes.TabIndex = 14
        Me.CB_MostrarContractes.Text = "Mostrar empreses amb contractes"
        Me.CB_MostrarContractes.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.SplitContainer1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 48)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1658, 877)
        Me.Panel3.TabIndex = 11
        '
        'Empreses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1658, 925)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Empreses"
        Me.Text = "Empreses"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataEmpreses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataSolucions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Btn_SenseFiltre As Button
    Friend WithEvents TB_CampSeleccionat As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextABuscar As TextBox
    Friend WithEvents DataEmpreses As DataGridView
    Friend WithEvents Lbl_NomEmpresa As Label
    Friend WithEvents Lbl_Direccio As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Lbl_SitioWeb As Label
    Friend WithEvents Lbl_Comunicaciones As Label
    Friend WithEvents Lbl_Ciberseguridad As Label
    Friend WithEvents Lbl_Factura As Label
    Friend WithEvents Lbl_Oficina As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Lbl_Comercio As Label
    Friend WithEvents Lbl_BI As Label
    Friend WithEvents Lbl_Procesos As Label
    Friend WithEvents TB_NumeroSolucions As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CB_MostrarContractes As CheckBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TB_BonusConcedit As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TB_BonusConsumit As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TB_BonusRestant As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TB_Segment As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DataSolucions As DataGridView
End Class
