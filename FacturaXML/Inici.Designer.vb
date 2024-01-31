<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inici
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inici))
        PanelCabecera = New Panel()
        Panel14 = New Panel()
        Lbl_Hora = New Label()
        Panel13 = New Panel()
        Lbl_Data = New Label()
        PictureBox1 = New PictureBox()
        Panel_empreses_obert = New Panel()
        Btn_Empreses_obert = New Button()
        Panel_solucions_obert = New Panel()
        Btn_llistat_obert = New Button()
        Panel_Factures_obert = New Panel()
        Btn_factures_obert = New Button()
        Panel_Informes_obert = New Panel()
        Btn_Informes_obert = New Button()
        Panel_Gestio_obert = New Panel()
        Btn_Gestio_obert = New Button()
        Panel_Informació_obert = New Panel()
        Btn_Informació_obert = New Button()
        TancarForm = New Button()
        PanelMenu = New Panel()
        Panel15 = New Panel()
        Panel16 = New Panel()
        btn_segona = New Button()
        Panel11 = New Panel()
        Panel12 = New Panel()
        Btn_Empreses = New Button()
        Btn_config = New Button()
        Panel9 = New Panel()
        Panel10 = New Panel()
        Btn_informes = New Button()
        Panel7 = New Panel()
        Panel8 = New Panel()
        Btn_informacio = New Button()
        Panel5 = New Panel()
        Panel6 = New Panel()
        Btn_llistat = New Button()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Btn_factures = New Button()
        btn_Menu = New PictureBox()
        Btn_gestio = New Button()
        TmOcultarMenu = New Timer(components)
        TmMostrarMenu = New Timer(components)
        Timer1 = New Timer(components)
        PanelContenedor = New Panel()
        Panell_segona_obert = New Panel()
        btn_segona_obert = New Button()
        PanelCabecera.SuspendLayout()
        Panel14.SuspendLayout()
        Panel13.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel_empreses_obert.SuspendLayout()
        Panel_solucions_obert.SuspendLayout()
        Panel_Factures_obert.SuspendLayout()
        Panel_Informes_obert.SuspendLayout()
        Panel_Gestio_obert.SuspendLayout()
        Panel_Informació_obert.SuspendLayout()
        PanelMenu.SuspendLayout()
        Panel15.SuspendLayout()
        Panel11.SuspendLayout()
        Panel9.SuspendLayout()
        Panel7.SuspendLayout()
        Panel5.SuspendLayout()
        Panel3.SuspendLayout()
        Panel1.SuspendLayout()
        CType(btn_Menu, ComponentModel.ISupportInitialize).BeginInit()
        PanelContenedor.SuspendLayout()
        Panell_segona_obert.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelCabecera
        ' 
        PanelCabecera.BackColor = Color.FromArgb(CByte(72), CByte(101), CByte(174))
        PanelCabecera.Controls.Add(Panell_segona_obert)
        PanelCabecera.Controls.Add(Panel14)
        PanelCabecera.Controls.Add(Panel13)
        PanelCabecera.Controls.Add(PictureBox1)
        PanelCabecera.Controls.Add(Panel_empreses_obert)
        PanelCabecera.Controls.Add(Panel_solucions_obert)
        PanelCabecera.Controls.Add(Panel_Factures_obert)
        PanelCabecera.Controls.Add(Panel_Informes_obert)
        PanelCabecera.Controls.Add(Panel_Gestio_obert)
        PanelCabecera.Controls.Add(Panel_Informació_obert)
        PanelCabecera.Controls.Add(TancarForm)
        PanelCabecera.Dock = DockStyle.Top
        PanelCabecera.Location = New Point(0, 0)
        PanelCabecera.Name = "PanelCabecera"
        PanelCabecera.Size = New Size(1227, 40)
        PanelCabecera.TabIndex = 0
        ' 
        ' Panel14
        ' 
        Panel14.AutoSize = True
        Panel14.Controls.Add(Lbl_Hora)
        Panel14.Dock = DockStyle.Left
        Panel14.Location = New Point(165, 0)
        Panel14.Name = "Panel14"
        Panel14.Size = New Size(54, 40)
        Panel14.TabIndex = 78
        ' 
        ' Lbl_Hora
        ' 
        Lbl_Hora.AutoSize = True
        Lbl_Hora.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Lbl_Hora.ForeColor = SystemColors.Control
        Lbl_Hora.Location = New Point(9, 13)
        Lbl_Hora.Name = "Lbl_Hora"
        Lbl_Hora.Size = New Size(42, 15)
        Lbl_Hora.TabIndex = 1
        Lbl_Hora.Text = "Label2"
        ' 
        ' Panel13
        ' 
        Panel13.AutoSize = True
        Panel13.Controls.Add(Lbl_Data)
        Panel13.Dock = DockStyle.Left
        Panel13.Location = New Point(108, 0)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(57, 40)
        Panel13.TabIndex = 77
        ' 
        ' Lbl_Data
        ' 
        Lbl_Data.AutoSize = True
        Lbl_Data.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Lbl_Data.ForeColor = SystemColors.Control
        Lbl_Data.Location = New Point(14, 13)
        Lbl_Data.Name = "Lbl_Data"
        Lbl_Data.Size = New Size(40, 15)
        Lbl_Data.TabIndex = 0
        Lbl_Data.Text = "Label1"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Left
        PictureBox1.Image = My.Resources.Resources.Logo_Telematic_blanco
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(108, 40)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 76
        PictureBox1.TabStop = False
        ' 
        ' Panel_empreses_obert
        ' 
        Panel_empreses_obert.AutoSize = True
        Panel_empreses_obert.Controls.Add(Btn_Empreses_obert)
        Panel_empreses_obert.Dock = DockStyle.Right
        Panel_empreses_obert.Location = New Point(617, 0)
        Panel_empreses_obert.Name = "Panel_empreses_obert"
        Panel_empreses_obert.Size = New Size(93, 40)
        Panel_empreses_obert.TabIndex = 11
        Panel_empreses_obert.Visible = False
        ' 
        ' Btn_Empreses_obert
        ' 
        Btn_Empreses_obert.BackColor = Color.FromArgb(CByte(37), CByte(46), CByte(59))
        Btn_Empreses_obert.FlatAppearance.BorderSize = 0
        Btn_Empreses_obert.FlatStyle = FlatStyle.Flat
        Btn_Empreses_obert.ForeColor = SystemColors.Control
        Btn_Empreses_obert.Location = New Point(10, 5)
        Btn_Empreses_obert.Margin = New Padding(10)
        Btn_Empreses_obert.Name = "Btn_Empreses_obert"
        Btn_Empreses_obert.Size = New Size(73, 30)
        Btn_Empreses_obert.TabIndex = 1
        Btn_Empreses_obert.Text = "Empreses"
        Btn_Empreses_obert.UseVisualStyleBackColor = False
        ' 
        ' Panel_solucions_obert
        ' 
        Panel_solucions_obert.AutoSize = True
        Panel_solucions_obert.Controls.Add(Btn_llistat_obert)
        Panel_solucions_obert.Dock = DockStyle.Right
        Panel_solucions_obert.Location = New Point(710, 0)
        Panel_solucions_obert.Name = "Panel_solucions_obert"
        Panel_solucions_obert.Size = New Size(94, 40)
        Panel_solucions_obert.TabIndex = 10
        Panel_solucions_obert.Visible = False
        ' 
        ' Btn_llistat_obert
        ' 
        Btn_llistat_obert.BackColor = Color.FromArgb(CByte(37), CByte(46), CByte(59))
        Btn_llistat_obert.FlatAppearance.BorderSize = 0
        Btn_llistat_obert.FlatStyle = FlatStyle.Flat
        Btn_llistat_obert.ForeColor = SystemColors.Control
        Btn_llistat_obert.Location = New Point(11, 5)
        Btn_llistat_obert.Margin = New Padding(10)
        Btn_llistat_obert.Name = "Btn_llistat_obert"
        Btn_llistat_obert.Size = New Size(73, 30)
        Btn_llistat_obert.TabIndex = 0
        Btn_llistat_obert.Text = "Solucions"
        Btn_llistat_obert.UseVisualStyleBackColor = False
        ' 
        ' Panel_Factures_obert
        ' 
        Panel_Factures_obert.AutoSize = True
        Panel_Factures_obert.Controls.Add(Btn_factures_obert)
        Panel_Factures_obert.Dock = DockStyle.Right
        Panel_Factures_obert.Location = New Point(804, 0)
        Panel_Factures_obert.Name = "Panel_Factures_obert"
        Panel_Factures_obert.Size = New Size(94, 40)
        Panel_Factures_obert.TabIndex = 6
        Panel_Factures_obert.Visible = False
        ' 
        ' Btn_factures_obert
        ' 
        Btn_factures_obert.BackColor = Color.FromArgb(CByte(37), CByte(46), CByte(59))
        Btn_factures_obert.FlatAppearance.BorderSize = 0
        Btn_factures_obert.FlatStyle = FlatStyle.Flat
        Btn_factures_obert.ForeColor = SystemColors.Control
        Btn_factures_obert.Location = New Point(11, 5)
        Btn_factures_obert.Margin = New Padding(10)
        Btn_factures_obert.Name = "Btn_factures_obert"
        Btn_factures_obert.Size = New Size(73, 30)
        Btn_factures_obert.TabIndex = 0
        Btn_factures_obert.Text = "Factures"
        Btn_factures_obert.UseVisualStyleBackColor = False
        ' 
        ' Panel_Informes_obert
        ' 
        Panel_Informes_obert.AutoSize = True
        Panel_Informes_obert.Controls.Add(Btn_Informes_obert)
        Panel_Informes_obert.Dock = DockStyle.Right
        Panel_Informes_obert.Location = New Point(898, 0)
        Panel_Informes_obert.Name = "Panel_Informes_obert"
        Panel_Informes_obert.Size = New Size(94, 40)
        Panel_Informes_obert.TabIndex = 9
        Panel_Informes_obert.Visible = False
        ' 
        ' Btn_Informes_obert
        ' 
        Btn_Informes_obert.BackColor = Color.FromArgb(CByte(37), CByte(46), CByte(59))
        Btn_Informes_obert.FlatAppearance.BorderSize = 0
        Btn_Informes_obert.FlatStyle = FlatStyle.Flat
        Btn_Informes_obert.ForeColor = SystemColors.Control
        Btn_Informes_obert.Location = New Point(11, 5)
        Btn_Informes_obert.Margin = New Padding(10)
        Btn_Informes_obert.Name = "Btn_Informes_obert"
        Btn_Informes_obert.Size = New Size(73, 30)
        Btn_Informes_obert.TabIndex = 0
        Btn_Informes_obert.Text = "Informes"
        Btn_Informes_obert.UseVisualStyleBackColor = False
        ' 
        ' Panel_Gestio_obert
        ' 
        Panel_Gestio_obert.AutoSize = True
        Panel_Gestio_obert.Controls.Add(Btn_Gestio_obert)
        Panel_Gestio_obert.Dock = DockStyle.Right
        Panel_Gestio_obert.Location = New Point(992, 0)
        Panel_Gestio_obert.Name = "Panel_Gestio_obert"
        Panel_Gestio_obert.Size = New Size(94, 40)
        Panel_Gestio_obert.TabIndex = 8
        Panel_Gestio_obert.Visible = False
        ' 
        ' Btn_Gestio_obert
        ' 
        Btn_Gestio_obert.BackColor = Color.FromArgb(CByte(37), CByte(46), CByte(59))
        Btn_Gestio_obert.FlatAppearance.BorderSize = 0
        Btn_Gestio_obert.FlatStyle = FlatStyle.Flat
        Btn_Gestio_obert.ForeColor = SystemColors.Control
        Btn_Gestio_obert.Location = New Point(11, 5)
        Btn_Gestio_obert.Margin = New Padding(10)
        Btn_Gestio_obert.Name = "Btn_Gestio_obert"
        Btn_Gestio_obert.Size = New Size(73, 30)
        Btn_Gestio_obert.TabIndex = 0
        Btn_Gestio_obert.Text = "Gestió"
        Btn_Gestio_obert.UseVisualStyleBackColor = False
        ' 
        ' Panel_Informació_obert
        ' 
        Panel_Informació_obert.AutoSize = True
        Panel_Informació_obert.Controls.Add(Btn_Informació_obert)
        Panel_Informació_obert.Dock = DockStyle.Right
        Panel_Informació_obert.Location = New Point(1086, 0)
        Panel_Informació_obert.Name = "Panel_Informació_obert"
        Panel_Informació_obert.Size = New Size(101, 40)
        Panel_Informació_obert.TabIndex = 7
        Panel_Informació_obert.Visible = False
        ' 
        ' Btn_Informació_obert
        ' 
        Btn_Informació_obert.BackColor = Color.FromArgb(CByte(37), CByte(46), CByte(59))
        Btn_Informació_obert.FlatAppearance.BorderSize = 0
        Btn_Informació_obert.FlatStyle = FlatStyle.Flat
        Btn_Informació_obert.ForeColor = SystemColors.Control
        Btn_Informació_obert.Location = New Point(11, 5)
        Btn_Informació_obert.Margin = New Padding(10)
        Btn_Informació_obert.Name = "Btn_Informació_obert"
        Btn_Informació_obert.Size = New Size(80, 30)
        Btn_Informació_obert.TabIndex = 0
        Btn_Informació_obert.Text = "Informació"
        Btn_Informació_obert.UseVisualStyleBackColor = False
        ' 
        ' TancarForm
        ' 
        TancarForm.AllowDrop = True
        TancarForm.Dock = DockStyle.Right
        TancarForm.FlatAppearance.BorderSize = 0
        TancarForm.FlatStyle = FlatStyle.Flat
        TancarForm.Image = My.Resources.Resources.Icono_cerrar_FN
        TancarForm.Location = New Point(1187, 0)
        TancarForm.Name = "TancarForm"
        TancarForm.Size = New Size(40, 40)
        TancarForm.TabIndex = 4
        TancarForm.UseVisualStyleBackColor = True
        TancarForm.Visible = False
        ' 
        ' PanelMenu
        ' 
        PanelMenu.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        PanelMenu.BackColor = Color.FromArgb(CByte(37), CByte(46), CByte(59))
        PanelMenu.Controls.Add(Panel15)
        PanelMenu.Controls.Add(btn_segona)
        PanelMenu.Controls.Add(Panel11)
        PanelMenu.Controls.Add(Btn_Empreses)
        PanelMenu.Controls.Add(Btn_config)
        PanelMenu.Controls.Add(Panel9)
        PanelMenu.Controls.Add(Btn_informes)
        PanelMenu.Controls.Add(Panel7)
        PanelMenu.Controls.Add(Btn_informacio)
        PanelMenu.Controls.Add(Panel5)
        PanelMenu.Controls.Add(Btn_llistat)
        PanelMenu.Controls.Add(Panel3)
        PanelMenu.Controls.Add(Panel1)
        PanelMenu.Controls.Add(Btn_factures)
        PanelMenu.Controls.Add(btn_Menu)
        PanelMenu.Controls.Add(Btn_gestio)
        PanelMenu.Location = New Point(0, 0)
        PanelMenu.Name = "PanelMenu"
        PanelMenu.Size = New Size(60, 621)
        PanelMenu.TabIndex = 1
        ' 
        ' Panel15
        ' 
        Panel15.BackColor = Color.FromArgb(CByte(72), CByte(101), CByte(174))
        Panel15.Controls.Add(Panel16)
        Panel15.Location = New Point(1, 508)
        Panel15.Name = "Panel15"
        Panel15.Size = New Size(7, 70)
        Panel15.TabIndex = 16
        ' 
        ' Panel16
        ' 
        Panel16.BackColor = Color.Orchid
        Panel16.Location = New Point(-108, 0)
        Panel16.Name = "Panel16"
        Panel16.Size = New Size(5, 70)
        Panel16.TabIndex = 4
        ' 
        ' btn_segona
        ' 
        btn_segona.BackgroundImageLayout = ImageLayout.None
        btn_segona.Cursor = Cursors.Hand
        btn_segona.FlatAppearance.BorderSize = 0
        btn_segona.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(38), CByte(56), CByte(99))
        btn_segona.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(72), CByte(101), CByte(174))
        btn_segona.FlatStyle = FlatStyle.Flat
        btn_segona.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_segona.ForeColor = Color.White
        btn_segona.Image = My.Resources.Resources._21
        btn_segona.ImageAlign = ContentAlignment.MiddleLeft
        btn_segona.Location = New Point(12, 508)
        btn_segona.Name = "btn_segona"
        btn_segona.Size = New Size(220, 70)
        btn_segona.TabIndex = 15
        btn_segona.Text = "   2ª Justificació"
        btn_segona.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_segona.UseVisualStyleBackColor = True
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = Color.FromArgb(CByte(72), CByte(101), CByte(174))
        Panel11.Controls.Add(Panel12)
        Panel11.Location = New Point(1, 280)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(7, 70)
        Panel11.TabIndex = 12
        ' 
        ' Panel12
        ' 
        Panel12.BackColor = Color.Orchid
        Panel12.Location = New Point(-108, 0)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(5, 70)
        Panel12.TabIndex = 4
        ' 
        ' Btn_Empreses
        ' 
        Btn_Empreses.BackgroundImageLayout = ImageLayout.None
        Btn_Empreses.Cursor = Cursors.Hand
        Btn_Empreses.FlatAppearance.BorderSize = 0
        Btn_Empreses.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(38), CByte(56), CByte(99))
        Btn_Empreses.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(72), CByte(101), CByte(174))
        Btn_Empreses.FlatStyle = FlatStyle.Flat
        Btn_Empreses.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Btn_Empreses.ForeColor = Color.White
        Btn_Empreses.Image = My.Resources.Resources.Icono_Empresas
        Btn_Empreses.ImageAlign = ContentAlignment.MiddleLeft
        Btn_Empreses.Location = New Point(3, 280)
        Btn_Empreses.Name = "Btn_Empreses"
        Btn_Empreses.Size = New Size(220, 70)
        Btn_Empreses.TabIndex = 14
        Btn_Empreses.Text = "Empreses"
        Btn_Empreses.TextImageRelation = TextImageRelation.ImageBeforeText
        Btn_Empreses.UseVisualStyleBackColor = True
        ' 
        ' Btn_config
        ' 
        Btn_config.Dock = DockStyle.Bottom
        Btn_config.FlatAppearance.BorderSize = 0
        Btn_config.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(38), CByte(56), CByte(99))
        Btn_config.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(72), CByte(101), CByte(174))
        Btn_config.FlatStyle = FlatStyle.Flat
        Btn_config.Image = My.Resources.Resources.Icono_Ajustes
        Btn_config.Location = New Point(0, 564)
        Btn_config.Name = "Btn_config"
        Btn_config.Padding = New Padding(0, 0, 0, 5)
        Btn_config.Size = New Size(60, 57)
        Btn_config.TabIndex = 13
        Btn_config.UseVisualStyleBackColor = True
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.FromArgb(CByte(72), CByte(101), CByte(174))
        Panel9.Controls.Add(Panel10)
        Panel9.Location = New Point(0, 432)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(7, 70)
        Panel9.TabIndex = 11
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.Orchid
        Panel10.Location = New Point(-108, 0)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(5, 70)
        Panel10.TabIndex = 4
        ' 
        ' Btn_informes
        ' 
        Btn_informes.BackgroundImageLayout = ImageLayout.None
        Btn_informes.Cursor = Cursors.Hand
        Btn_informes.FlatAppearance.BorderSize = 0
        Btn_informes.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(38), CByte(56), CByte(99))
        Btn_informes.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(72), CByte(101), CByte(174))
        Btn_informes.FlatStyle = FlatStyle.Flat
        Btn_informes.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Btn_informes.ForeColor = Color.White
        Btn_informes.Image = My.Resources.Resources.Icono_Estadisticas
        Btn_informes.ImageAlign = ContentAlignment.MiddleLeft
        Btn_informes.Location = New Point(3, 432)
        Btn_informes.Name = "Btn_informes"
        Btn_informes.Size = New Size(220, 70)
        Btn_informes.TabIndex = 12
        Btn_informes.Text = "Informes"
        Btn_informes.TextImageRelation = TextImageRelation.ImageBeforeText
        Btn_informes.UseVisualStyleBackColor = True
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(72), CByte(101), CByte(174))
        Panel7.Controls.Add(Panel8)
        Panel7.Location = New Point(0, 356)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(7, 70)
        Panel7.TabIndex = 9
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.Orchid
        Panel8.Location = New Point(-108, 0)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(5, 70)
        Panel8.TabIndex = 4
        ' 
        ' Btn_informacio
        ' 
        Btn_informacio.BackgroundImageLayout = ImageLayout.None
        Btn_informacio.Cursor = Cursors.Hand
        Btn_informacio.FlatAppearance.BorderSize = 0
        Btn_informacio.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(38), CByte(56), CByte(99))
        Btn_informacio.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(72), CByte(101), CByte(174))
        Btn_informacio.FlatStyle = FlatStyle.Flat
        Btn_informacio.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Btn_informacio.ForeColor = Color.White
        Btn_informacio.Image = My.Resources.Resources.Icono_Informacion
        Btn_informacio.ImageAlign = ContentAlignment.MiddleLeft
        Btn_informacio.Location = New Point(3, 356)
        Btn_informacio.Name = "Btn_informacio"
        Btn_informacio.Size = New Size(220, 70)
        Btn_informacio.TabIndex = 10
        Btn_informacio.Text = "Informació"
        Btn_informacio.TextImageRelation = TextImageRelation.ImageBeforeText
        Btn_informacio.UseVisualStyleBackColor = True
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(72), CByte(101), CByte(174))
        Panel5.Controls.Add(Panel6)
        Panel5.Location = New Point(0, 204)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(7, 70)
        Panel5.TabIndex = 7
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.Orchid
        Panel6.Location = New Point(-108, 0)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(5, 70)
        Panel6.TabIndex = 4
        ' 
        ' Btn_llistat
        ' 
        Btn_llistat.BackgroundImageLayout = ImageLayout.None
        Btn_llistat.Cursor = Cursors.Hand
        Btn_llistat.FlatAppearance.BorderSize = 0
        Btn_llistat.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(38), CByte(56), CByte(99))
        Btn_llistat.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(72), CByte(101), CByte(174))
        Btn_llistat.FlatStyle = FlatStyle.Flat
        Btn_llistat.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Btn_llistat.ForeColor = Color.White
        Btn_llistat.Image = My.Resources.Resources.Icono_Informes
        Btn_llistat.ImageAlign = ContentAlignment.MiddleLeft
        Btn_llistat.Location = New Point(3, 204)
        Btn_llistat.Name = "Btn_llistat"
        Btn_llistat.Size = New Size(220, 70)
        Btn_llistat.TabIndex = 8
        Btn_llistat.Text = "Solucions"
        Btn_llistat.TextImageRelation = TextImageRelation.ImageBeforeText
        Btn_llistat.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(72), CByte(101), CByte(174))
        Panel3.Controls.Add(Panel4)
        Panel3.Location = New Point(0, 128)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(7, 70)
        Panel3.TabIndex = 5
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Orchid
        Panel4.Location = New Point(-108, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(5, 70)
        Panel4.TabIndex = 4
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(72), CByte(101), CByte(174))
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(0, 52)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(7, 70)
        Panel1.TabIndex = 2
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Orchid
        Panel2.Location = New Point(-108, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(5, 70)
        Panel2.TabIndex = 4
        ' 
        ' Btn_factures
        ' 
        Btn_factures.Cursor = Cursors.Hand
        Btn_factures.FlatAppearance.BorderSize = 0
        Btn_factures.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(38), CByte(56), CByte(99))
        Btn_factures.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(72), CByte(101), CByte(174))
        Btn_factures.FlatStyle = FlatStyle.Flat
        Btn_factures.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Btn_factures.ForeColor = Color.White
        Btn_factures.Image = My.Resources.Resources.Icono_Facturas
        Btn_factures.ImageAlign = ContentAlignment.MiddleLeft
        Btn_factures.Location = New Point(3, 52)
        Btn_factures.Name = "Btn_factures"
        Btn_factures.Size = New Size(220, 70)
        Btn_factures.TabIndex = 1
        Btn_factures.Text = "Factures"
        Btn_factures.TextImageRelation = TextImageRelation.ImageBeforeText
        Btn_factures.UseVisualStyleBackColor = True
        ' 
        ' btn_Menu
        ' 
        btn_Menu.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btn_Menu.Image = My.Resources.Resources.Icono_Abrir_Menu
        btn_Menu.Location = New Point(6, 2)
        btn_Menu.Name = "btn_Menu"
        btn_Menu.Size = New Size(49, 33)
        btn_Menu.SizeMode = PictureBoxSizeMode.Zoom
        btn_Menu.TabIndex = 0
        btn_Menu.TabStop = False
        ' 
        ' Btn_gestio
        ' 
        Btn_gestio.BackgroundImageLayout = ImageLayout.None
        Btn_gestio.Cursor = Cursors.Hand
        Btn_gestio.FlatAppearance.BorderSize = 0
        Btn_gestio.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(38), CByte(56), CByte(99))
        Btn_gestio.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(72), CByte(101), CByte(174))
        Btn_gestio.FlatStyle = FlatStyle.Flat
        Btn_gestio.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Btn_gestio.ForeColor = Color.White
        Btn_gestio.Image = My.Resources.Resources.Icono_Soluciones
        Btn_gestio.ImageAlign = ContentAlignment.MiddleLeft
        Btn_gestio.Location = New Point(3, 128)
        Btn_gestio.Name = "Btn_gestio"
        Btn_gestio.Size = New Size(220, 70)
        Btn_gestio.TabIndex = 6
        Btn_gestio.Text = "Gestió"
        Btn_gestio.TextImageRelation = TextImageRelation.ImageBeforeText
        Btn_gestio.UseVisualStyleBackColor = True
        ' 
        ' TmOcultarMenu
        ' 
        TmOcultarMenu.Interval = 50
        ' 
        ' TmMostrarMenu
        ' 
        TmMostrarMenu.Interval = 50
        ' 
        ' Timer1
        ' 
        ' 
        ' PanelContenedor
        ' 
        PanelContenedor.AutoSizeMode = AutoSizeMode.GrowAndShrink
        PanelContenedor.Controls.Add(PanelMenu)
        PanelContenedor.Dock = DockStyle.Fill
        PanelContenedor.Location = New Point(0, 40)
        PanelContenedor.Name = "PanelContenedor"
        PanelContenedor.Padding = New Padding(60, 0, 0, 0)
        PanelContenedor.Size = New Size(1227, 621)
        PanelContenedor.TabIndex = 2
        ' 
        ' Panell_segona_obert
        ' 
        Panell_segona_obert.AutoSize = True
        Panell_segona_obert.Controls.Add(btn_segona_obert)
        Panell_segona_obert.Dock = DockStyle.Right
        Panell_segona_obert.Location = New Point(516, 0)
        Panell_segona_obert.Name = "Panell_segona_obert"
        Panell_segona_obert.Size = New Size(101, 40)
        Panell_segona_obert.TabIndex = 79
        Panell_segona_obert.Visible = False
        ' 
        ' btn_segona_obert
        ' 
        btn_segona_obert.BackColor = Color.FromArgb(CByte(37), CByte(46), CByte(59))
        btn_segona_obert.FlatAppearance.BorderSize = 0
        btn_segona_obert.FlatStyle = FlatStyle.Flat
        btn_segona_obert.ForeColor = SystemColors.Control
        btn_segona_obert.Location = New Point(-3, 5)
        btn_segona_obert.Margin = New Padding(10)
        btn_segona_obert.Name = "btn_segona_obert"
        btn_segona_obert.Size = New Size(94, 30)
        btn_segona_obert.TabIndex = 0
        btn_segona_obert.Text = "2ª Justificació"
        btn_segona_obert.UseVisualStyleBackColor = False
        ' 
        ' Inici
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(1227, 661)
        Controls.Add(PanelContenedor)
        Controls.Add(PanelCabecera)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        IsMdiContainer = True
        MinimumSize = New Size(1243, 642)
        Name = "Inici"
        SizeGripStyle = SizeGripStyle.Show
        StartPosition = FormStartPosition.CenterScreen
        Text = "Gestió de Kits Digital"
        WindowState = FormWindowState.Maximized
        PanelCabecera.ResumeLayout(False)
        PanelCabecera.PerformLayout()
        Panel14.ResumeLayout(False)
        Panel14.PerformLayout()
        Panel13.ResumeLayout(False)
        Panel13.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel_empreses_obert.ResumeLayout(False)
        Panel_solucions_obert.ResumeLayout(False)
        Panel_Factures_obert.ResumeLayout(False)
        Panel_Informes_obert.ResumeLayout(False)
        Panel_Gestio_obert.ResumeLayout(False)
        Panel_Informació_obert.ResumeLayout(False)
        PanelMenu.ResumeLayout(False)
        Panel15.ResumeLayout(False)
        Panel11.ResumeLayout(False)
        Panel9.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        CType(btn_Menu, ComponentModel.ISupportInitialize).EndInit()
        PanelContenedor.ResumeLayout(False)
        Panell_segona_obert.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents PanelCabecera As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btn_Menu As PictureBox
    Friend WithEvents TmOcultarMenu As Timer
    Friend WithEvents TmMostrarMenu As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btn_factures As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Btn_gestio As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Btn_informes As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Btn_informacio As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Btn_llistat As Button
    Friend WithEvents Btn_factures_obert As Button
    Friend WithEvents TancarForm As Button
    Friend WithEvents Panel_solucions_obert As Panel
    Friend WithEvents Btn_llistat_obert As Button
    Friend WithEvents Panel_Factures_obert As Panel
    Friend WithEvents Panel_Informes_obert As Panel
    Friend WithEvents Btn_Informes_obert As Button
    Friend WithEvents Panel_Gestio_obert As Panel
    Friend WithEvents Btn_Gestio_obert As Button
    Friend WithEvents Panel_Informació_obert As Panel
    Friend WithEvents Btn_Informació_obert As Button
    Friend WithEvents Btn_config As Button
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Btn_Empreses As Button
    Friend WithEvents Panel_empreses_obert As Panel
    Friend WithEvents Btn_Empreses_obert As Button
    Friend WithEvents Panel13 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Lbl_Hora As Label
    Friend WithEvents Lbl_Data As Label
    Friend WithEvents Panel14 As Panel
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents btn_segona As Button
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Panell_segona_obert As Panel
    Friend WithEvents btn_segona_obert As Button
End Class
