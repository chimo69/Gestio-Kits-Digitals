<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Segona
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Llista_segona = New DataGridView()
        Mesos = New DataGridViewTextBoxColumn()
        SplitContainer1 = New SplitContainer()
        Panel2 = New Panel()
        Label1 = New Label()
        CB_MostraJustificades = New CheckBox()
        GB_TipusSolucions = New GroupBox()
        RB_FacturaElectronica = New RadioButton()
        RB_OficinaVirtual = New RadioButton()
        RB_Ciberseguridad = New RadioButton()
        RB_ComunicacionesSeguras = New RadioButton()
        RB_GestionClientes = New RadioButton()
        RB_GestionProcesos = New RadioButton()
        RB_BusinessInteligence = New RadioButton()
        RB_Totes = New RadioButton()
        RB_SitioWeb = New RadioButton()
        RB_RedesSociales = New RadioButton()
        RB_ComercioElectronico = New RadioButton()
        Panel1 = New Panel()
        Label2 = New Label()
        RB_PuestoSeguro = New RadioButton()
        CType(Llista_segona, ComponentModel.ISupportInitialize).BeginInit()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        Panel2.SuspendLayout()
        GB_TipusSolucions.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Llista_segona
        ' 
        Llista_segona.AllowUserToAddRows = False
        Llista_segona.AllowUserToDeleteRows = False
        Llista_segona.AllowUserToResizeColumns = False
        Llista_segona.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Llista_segona.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Llista_segona.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.ControlDark
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        Llista_segona.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Llista_segona.ColumnHeadersHeight = 35
        Llista_segona.Columns.AddRange(New DataGridViewColumn() {Mesos})
        Llista_segona.EnableHeadersVisualStyles = False
        Llista_segona.Location = New Point(15, 74)
        Llista_segona.MultiSelect = False
        Llista_segona.Name = "Llista_segona"
        Llista_segona.ReadOnly = True
        Llista_segona.RowHeadersVisible = False
        Llista_segona.RowTemplate.Height = 25
        Llista_segona.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Llista_segona.Size = New Size(722, 627)
        Llista_segona.TabIndex = 0
        ' 
        ' Mesos
        ' 
        Mesos.HeaderText = "Mesos"
        Mesos.Name = "Mesos"
        Mesos.ReadOnly = True
        Mesos.Width = 719
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.FixedPanel = FixedPanel.Panel1
        SplitContainer1.IsSplitterFixed = True
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(Panel2)
        SplitContainer1.Panel1.Controls.Add(CB_MostraJustificades)
        SplitContainer1.Panel1.Controls.Add(GB_TipusSolucions)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(Llista_segona)
        SplitContainer1.Size = New Size(990, 713)
        SplitContainer1.SplitterDistance = 237
        SplitContainer1.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Yellow
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(12, 571)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(221, 28)
        Panel2.TabIndex = 18
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(51, 6)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 15)
        Label1.TabIndex = 19
        Label1.Text = "S'han de fer captures"
        ' 
        ' CB_MostraJustificades
        ' 
        CB_MostraJustificades.AutoSize = True
        CB_MostraJustificades.Location = New Point(40, 509)
        CB_MostraJustificades.Name = "CB_MostraJustificades"
        CB_MostraJustificades.Size = New Size(178, 34)
        CB_MostraJustificades.TabIndex = 17
        CB_MostraJustificades.Text = "Mostrar solucions" & vbCrLf & "ja completament justificades"
        CB_MostraJustificades.UseVisualStyleBackColor = True
        ' 
        ' GB_TipusSolucions
        ' 
        GB_TipusSolucions.Controls.Add(RB_PuestoSeguro)
        GB_TipusSolucions.Controls.Add(RB_FacturaElectronica)
        GB_TipusSolucions.Controls.Add(RB_OficinaVirtual)
        GB_TipusSolucions.Controls.Add(RB_Ciberseguridad)
        GB_TipusSolucions.Controls.Add(RB_ComunicacionesSeguras)
        GB_TipusSolucions.Controls.Add(RB_GestionClientes)
        GB_TipusSolucions.Controls.Add(RB_GestionProcesos)
        GB_TipusSolucions.Controls.Add(RB_BusinessInteligence)
        GB_TipusSolucions.Controls.Add(RB_Totes)
        GB_TipusSolucions.Controls.Add(RB_SitioWeb)
        GB_TipusSolucions.Controls.Add(RB_RedesSociales)
        GB_TipusSolucions.Controls.Add(RB_ComercioElectronico)
        GB_TipusSolucions.Location = New Point(12, 74)
        GB_TipusSolucions.Name = "GB_TipusSolucions"
        GB_TipusSolucions.Size = New Size(221, 429)
        GB_TipusSolucions.TabIndex = 16
        GB_TipusSolucions.TabStop = False
        GB_TipusSolucions.Text = "Tipus de solucions"
        ' 
        ' RB_FacturaElectronica
        ' 
        RB_FacturaElectronica.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        RB_FacturaElectronica.Appearance = Appearance.Button
        RB_FacturaElectronica.Location = New Point(28, 260)
        RB_FacturaElectronica.Name = "RB_FacturaElectronica"
        RB_FacturaElectronica.Size = New Size(174, 25)
        RB_FacturaElectronica.TabIndex = 28
        RB_FacturaElectronica.Text = "Factura electrónica"
        RB_FacturaElectronica.UseVisualStyleBackColor = True
        ' 
        ' RB_OficinaVirtual
        ' 
        RB_OficinaVirtual.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        RB_OficinaVirtual.Appearance = Appearance.Button
        RB_OficinaVirtual.Location = New Point(28, 291)
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
        RB_Ciberseguridad.Location = New Point(28, 353)
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
        RB_ComunicacionesSeguras.Location = New Point(28, 322)
        RB_ComunicacionesSeguras.Name = "RB_ComunicacionesSeguras"
        RB_ComunicacionesSeguras.Size = New Size(174, 25)
        RB_ComunicacionesSeguras.TabIndex = 23
        RB_ComunicacionesSeguras.Text = "Comunicaciones seguras"
        RB_ComunicacionesSeguras.UseVisualStyleBackColor = True
        ' 
        ' RB_GestionClientes
        ' 
        RB_GestionClientes.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        RB_GestionClientes.Appearance = Appearance.Button
        RB_GestionClientes.Location = New Point(28, 167)
        RB_GestionClientes.Name = "RB_GestionClientes"
        RB_GestionClientes.Size = New Size(174, 25)
        RB_GestionClientes.TabIndex = 20
        RB_GestionClientes.Text = "Gestión de clientes"
        RB_GestionClientes.UseVisualStyleBackColor = True
        ' 
        ' RB_GestionProcesos
        ' 
        RB_GestionProcesos.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        RB_GestionProcesos.Appearance = Appearance.Button
        RB_GestionProcesos.Location = New Point(28, 229)
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
        RB_BusinessInteligence.Location = New Point(28, 198)
        RB_BusinessInteligence.Name = "RB_BusinessInteligence"
        RB_BusinessInteligence.Size = New Size(174, 25)
        RB_BusinessInteligence.TabIndex = 15
        RB_BusinessInteligence.Text = "Business Inteligence"
        RB_BusinessInteligence.UseVisualStyleBackColor = True
        ' 
        ' RB_Totes
        ' 
        RB_Totes.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        RB_Totes.Appearance = Appearance.Button
        RB_Totes.Location = New Point(28, 28)
        RB_Totes.Name = "RB_Totes"
        RB_Totes.Size = New Size(174, 25)
        RB_Totes.TabIndex = 12
        RB_Totes.Text = "Totes les solucions"
        RB_Totes.UseVisualStyleBackColor = True
        ' 
        ' RB_SitioWeb
        ' 
        RB_SitioWeb.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        RB_SitioWeb.Appearance = Appearance.Button
        RB_SitioWeb.Location = New Point(28, 74)
        RB_SitioWeb.Name = "RB_SitioWeb"
        RB_SitioWeb.Size = New Size(174, 25)
        RB_SitioWeb.TabIndex = 6
        RB_SitioWeb.Text = "Sitio Web"
        RB_SitioWeb.UseVisualStyleBackColor = True
        ' 
        ' RB_RedesSociales
        ' 
        RB_RedesSociales.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        RB_RedesSociales.Appearance = Appearance.Button
        RB_RedesSociales.Location = New Point(28, 136)
        RB_RedesSociales.Name = "RB_RedesSociales"
        RB_RedesSociales.Size = New Size(174, 25)
        RB_RedesSociales.TabIndex = 8
        RB_RedesSociales.Text = "Gestión de redes sociales"
        RB_RedesSociales.UseVisualStyleBackColor = True
        ' 
        ' RB_ComercioElectronico
        ' 
        RB_ComercioElectronico.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        RB_ComercioElectronico.Appearance = Appearance.Button
        RB_ComercioElectronico.Location = New Point(28, 105)
        RB_ComercioElectronico.Name = "RB_ComercioElectronico"
        RB_ComercioElectronico.Size = New Size(174, 25)
        RB_ComercioElectronico.TabIndex = 7
        RB_ComercioElectronico.Text = "Comercio electrónico"
        RB_ComercioElectronico.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(990, 63)
        Panel1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(44, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(232, 30)
        Label2.TabIndex = 17
        Label2.Text = "Segones Justificacions"
        ' 
        ' RB_PuestoSeguro
        ' 
        RB_PuestoSeguro.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        RB_PuestoSeguro.Appearance = Appearance.Button
        RB_PuestoSeguro.Location = New Point(28, 388)
        RB_PuestoSeguro.Name = "RB_PuestoSeguro"
        RB_PuestoSeguro.Size = New Size(174, 25)
        RB_PuestoSeguro.TabIndex = 29
        RB_PuestoSeguro.Text = "Puesto seguro"
        RB_PuestoSeguro.UseVisualStyleBackColor = True
        ' 
        ' Segona
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(990, 713)
        Controls.Add(Panel1)
        Controls.Add(SplitContainer1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "Segona"
        Text = "Segona"
        CType(Llista_segona, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.PerformLayout()
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        GB_TipusSolucions.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Llista_segona As DataGridView
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents GB_TipusSolucions As GroupBox
    Friend WithEvents RB_FacturaElectronica As RadioButton
    Friend WithEvents RB_OficinaVirtual As RadioButton
    Friend WithEvents RB_Ciberseguridad As RadioButton
    Friend WithEvents RB_ComunicacionesSeguras As RadioButton
    Friend WithEvents RB_GestionClientes As RadioButton
    Friend WithEvents RB_GestionProcesos As RadioButton
    Friend WithEvents RB_BusinessInteligence As RadioButton
    Friend WithEvents RB_Totes As RadioButton
    Friend WithEvents RB_SitioWeb As RadioButton
    Friend WithEvents RB_RedesSociales As RadioButton
    Friend WithEvents RB_ComercioElectronico As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Mesos As DataGridViewTextBoxColumn
    Friend WithEvents CB_MostraJustificades As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents RB_PuestoSeguro As RadioButton
End Class
