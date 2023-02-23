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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Extras))
        DataExtres = New DataGridView()
        CB_Empreses = New ComboBox()
        DataExtresGeneral = New DataGridView()
        Panel1 = New Panel()
        Label1 = New Label()
        TotalEmpresa = New TextBox()
        TotalGeneral = New TextBox()
        DataEstatSolucions = New DataGridView()
        Panel2 = New Panel()
        Label2 = New Label()
        CType(DataExtres, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataExtresGeneral, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(DataEstatSolucions, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataExtres
        ' 
        DataExtres.AllowUserToAddRows = False
        DataExtres.AllowUserToDeleteRows = False
        DataExtres.AllowUserToResizeColumns = False
        DataExtres.AllowUserToResizeRows = False
        DataExtres.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataExtres.BackgroundColor = SystemColors.Control
        DataExtres.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataExtres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataExtres.EditMode = DataGridViewEditMode.EditProgrammatically
        DataExtres.Location = New Point(26, 74)
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
        ' 
        ' CB_Empreses
        ' 
        CB_Empreses.FormattingEnabled = True
        CB_Empreses.Location = New Point(26, 45)
        CB_Empreses.Name = "CB_Empreses"
        CB_Empreses.Size = New Size(248, 23)
        CB_Empreses.TabIndex = 1
        ' 
        ' DataExtresGeneral
        ' 
        DataExtresGeneral.AllowUserToAddRows = False
        DataExtresGeneral.AllowUserToDeleteRows = False
        DataExtresGeneral.AllowUserToResizeColumns = False
        DataExtresGeneral.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        DataExtresGeneral.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataExtresGeneral.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataExtresGeneral.BackgroundColor = SystemColors.Control
        DataExtresGeneral.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.MediumSlateBlue
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = Color.MediumSlateBlue
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataExtresGeneral.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataExtresGeneral.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataExtresGeneral.EditMode = DataGridViewEditMode.EditProgrammatically
        DataExtresGeneral.Location = New Point(304, 74)
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
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveBorder
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(304, 45)
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
        TotalEmpresa.Location = New Point(26, 331)
        TotalEmpresa.Name = "TotalEmpresa"
        TotalEmpresa.Size = New Size(248, 29)
        TotalEmpresa.TabIndex = 4
        TotalEmpresa.TextAlign = HorizontalAlignment.Center
        ' 
        ' TotalGeneral
        ' 
        TotalGeneral.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TotalGeneral.Location = New Point(304, 331)
        TotalGeneral.Name = "TotalGeneral"
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
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        DataEstatSolucions.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        DataEstatSolucions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataEstatSolucions.BackgroundColor = SystemColors.Control
        DataEstatSolucions.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.MediumSlateBlue
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        DataEstatSolucions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataEstatSolucions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataEstatSolucions.EditMode = DataGridViewEditMode.EditProgrammatically
        DataEstatSolucions.Location = New Point(582, 74)
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
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveBorder
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(582, 45)
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
        ' Extras
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(858, 450)
        Controls.Add(Panel2)
        Controls.Add(DataEstatSolucions)
        Controls.Add(TotalGeneral)
        Controls.Add(TotalEmpresa)
        Controls.Add(Panel1)
        Controls.Add(DataExtresGeneral)
        Controls.Add(CB_Empreses)
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
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataExtres As DataGridView
    Friend WithEvents CB_Empreses As ComboBox
    Friend WithEvents DataExtresGeneral As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TotalEmpresa As TextBox
    Friend WithEvents TotalGeneral As TextBox
    Friend WithEvents DataEstatSolucions As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
End Class
