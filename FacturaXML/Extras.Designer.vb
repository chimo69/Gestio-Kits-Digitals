<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Extras
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
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Extras))
        DataExtres = New DataGridView()
        DataExtresGeneral = New DataGridView()
        Panel1 = New Panel()
        Label1 = New Label()
        TotalEmpresa = New TextBox()
        TotalGeneral = New TextBox()
        DataEstatSolucions = New DataGridView()
        Panel2 = New Panel()
        Label2 = New Label()
        CercaEmpreses = New DataGridView()
        TextCerca = New TextBox()
        TB_Empresa = New TextBox()
        CType(DataExtres, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataExtresGeneral, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(DataEstatSolucions, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(CercaEmpreses, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataExtres
        ' 
        DataExtres.AllowUserToAddRows = False
        DataExtres.AllowUserToDeleteRows = False
        DataExtres.AllowUserToResizeColumns = False
        DataExtres.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        DataExtres.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataExtres.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataExtres.BackgroundColor = SystemColors.Control
        DataExtres.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.Orchid
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataExtres.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataExtres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataExtres.EditMode = DataGridViewEditMode.EditProgrammatically
        DataExtres.Enabled = False
        DataExtres.EnableHeadersVisualStyles = False
        DataExtres.Location = New Point(374, 74)
        DataExtres.MultiSelect = False
        DataExtres.Name = "DataExtres"
        DataExtres.ReadOnly = True
        DataExtres.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataExtres.RowHeadersVisible = False
        DataExtres.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataExtres.RowTemplate.Height = 25
        DataExtres.ScrollBars = ScrollBars.None
        DataExtres.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataExtres.ShowEditingIcon = False
        DataExtres.Size = New Size(248, 251)
        DataExtres.TabIndex = 0
        DataExtres.TabStop = False
        ' 
        ' DataExtresGeneral
        ' 
        DataExtresGeneral.AllowUserToAddRows = False
        DataExtresGeneral.AllowUserToDeleteRows = False
        DataExtresGeneral.AllowUserToResizeColumns = False
        DataExtresGeneral.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        DataExtresGeneral.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        DataExtresGeneral.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataExtresGeneral.BackgroundColor = SystemColors.Control
        DataExtresGeneral.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.Orchid
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = Color.Orchid
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        DataExtresGeneral.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataExtresGeneral.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Control
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        DataExtresGeneral.DefaultCellStyle = DataGridViewCellStyle5
        DataExtresGeneral.EditMode = DataGridViewEditMode.EditProgrammatically
        DataExtresGeneral.Enabled = False
        DataExtresGeneral.EnableHeadersVisualStyles = False
        DataExtresGeneral.Location = New Point(653, 74)
        DataExtresGeneral.MultiSelect = False
        DataExtresGeneral.Name = "DataExtresGeneral"
        DataExtresGeneral.ReadOnly = True
        DataExtresGeneral.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataExtresGeneral.RowHeadersVisible = False
        DataExtresGeneral.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataExtresGeneral.RowTemplate.Height = 25
        DataExtresGeneral.ScrollBars = ScrollBars.None
        DataExtresGeneral.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataExtresGeneral.ShowEditingIcon = False
        DataExtresGeneral.Size = New Size(248, 251)
        DataExtresGeneral.TabIndex = 2
        DataExtresGeneral.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveBorder
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(653, 45)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(248, 23)
        Panel1.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(74, 3)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 15)
        Label1.TabIndex = 0
        Label1.Text = "SITUACIÓ GENERAL"' 
        ' TotalEmpresa
        ' 
        TotalEmpresa.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TotalEmpresa.Location = New Point(374, 331)
        TotalEmpresa.Name = "TotalEmpresa"
        TotalEmpresa.ReadOnly = True
        TotalEmpresa.Size = New Size(248, 29)
        TotalEmpresa.TabIndex = 4
        TotalEmpresa.TabStop = False
        TotalEmpresa.TextAlign = HorizontalAlignment.Center
        ' 
        ' TotalGeneral
        ' 
        TotalGeneral.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TotalGeneral.Location = New Point(653, 331)
        TotalGeneral.Name = "TotalGeneral"
        TotalGeneral.ReadOnly = True
        TotalGeneral.Size = New Size(248, 29)
        TotalGeneral.TabIndex = 5
        TotalGeneral.TextAlign = HorizontalAlignment.Center
        ' 
        ' DataEstatSolucions
        ' 
        DataEstatSolucions.AllowUserToAddRows = False
        DataEstatSolucions.AllowUserToDeleteRows = False
        DataEstatSolucions.AllowUserToResizeColumns = False
        DataEstatSolucions.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        DataEstatSolucions.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        DataEstatSolucions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataEstatSolucions.BackgroundColor = SystemColors.Control
        DataEstatSolucions.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = Color.Orchid
        DataGridViewCellStyle7.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle7.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.True
        DataEstatSolucions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        DataEstatSolucions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataEstatSolucions.EditMode = DataGridViewEditMode.EditProgrammatically
        DataEstatSolucions.Enabled = False
        DataEstatSolucions.EnableHeadersVisualStyles = False
        DataEstatSolucions.Location = New Point(932, 74)
        DataEstatSolucions.MultiSelect = False
        DataEstatSolucions.Name = "DataEstatSolucions"
        DataEstatSolucions.ReadOnly = True
        DataEstatSolucions.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataEstatSolucions.RowHeadersVisible = False
        DataEstatSolucions.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataEstatSolucions.RowTemplate.Height = 25
        DataEstatSolucions.ScrollBars = ScrollBars.None
        DataEstatSolucions.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataEstatSolucions.ShowEditingIcon = False
        DataEstatSolucions.Size = New Size(248, 251)
        DataEstatSolucions.TabIndex = 6
        DataEstatSolucions.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveBorder
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(932, 46)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(248, 23)
        Panel2.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(74, 3)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 15)
        Label2.TabIndex = 0
        Label2.Text = "ESTAT SOLUCIONS"' 
        ' CercaEmpreses
        ' 
        CercaEmpreses.AllowUserToAddRows = False
        CercaEmpreses.AllowUserToDeleteRows = False
        CercaEmpreses.AllowUserToResizeColumns = False
        CercaEmpreses.AllowUserToResizeRows = False
        CercaEmpreses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        CercaEmpreses.BackgroundColor = SystemColors.Control
        CercaEmpreses.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = Color.Orchid
        DataGridViewCellStyle8.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle8.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True
        CercaEmpreses.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        CercaEmpreses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = SystemColors.Window
        DataGridViewCellStyle9.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle9.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = SystemColors.ControlDark
        DataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = DataGridViewTriState.False
        CercaEmpreses.DefaultCellStyle = DataGridViewCellStyle9
        CercaEmpreses.EditMode = DataGridViewEditMode.EditProgrammatically
        CercaEmpreses.EnableHeadersVisualStyles = False
        CercaEmpreses.Location = New Point(29, 74)
        CercaEmpreses.MultiSelect = False
        CercaEmpreses.Name = "CercaEmpreses"
        CercaEmpreses.ReadOnly = True
        CercaEmpreses.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        CercaEmpreses.RowHeadersVisible = False
        CercaEmpreses.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        CercaEmpreses.RowTemplate.Height = 25
        CercaEmpreses.ScrollBars = ScrollBars.Vertical
        CercaEmpreses.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        CercaEmpreses.ShowEditingIcon = False
        CercaEmpreses.Size = New Size(315, 492)
        CercaEmpreses.TabIndex = 7
        CercaEmpreses.TabStop = False
        ' 
        ' TextCerca
        ' 
        TextCerca.Location = New Point(29, 46)
        TextCerca.Name = "TextCerca"
        TextCerca.PlaceholderText = "Cerca empresa"
        TextCerca.Size = New Size(315, 23)
        TextCerca.TabIndex = 1
        ' 
        ' TB_Empresa
        ' 
        TB_Empresa.BackColor = Color.Silver
        TB_Empresa.BorderStyle = BorderStyle.FixedSingle
        TB_Empresa.Location = New Point(374, 45)
        TB_Empresa.Name = "TB_Empresa"
        TB_Empresa.ReadOnly = True
        TB_Empresa.Size = New Size(248, 23)
        TB_Empresa.TabIndex = 9
        TB_Empresa.TextAlign = HorizontalAlignment.Center
        ' 
        ' Extras
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(1210, 602)
        Controls.Add(TB_Empresa)
        Controls.Add(TextCerca)
        Controls.Add(CercaEmpreses)
        Controls.Add(Panel2)
        Controls.Add(DataEstatSolucions)
        Controls.Add(TotalGeneral)
        Controls.Add(TotalEmpresa)
        Controls.Add(Panel1)
        Controls.Add(DataExtresGeneral)
        Controls.Add(DataExtres)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Extras"
        ShowInTaskbar = False
        Text = "Informes"
        CType(DataExtres, ComponentModel.ISupportInitialize).EndInit()
        CType(DataExtresGeneral, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataEstatSolucions, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(CercaEmpreses, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataExtres As DataGridView
    Friend WithEvents DataExtresGeneral As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TotalEmpresa As TextBox
    Friend WithEvents TotalGeneral As TextBox
    Friend WithEvents DataEstatSolucions As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents CercaEmpreses As DataGridView
    Friend WithEvents TextCerca As TextBox
    Friend WithEvents TB_Empresa As TextBox
End Class
