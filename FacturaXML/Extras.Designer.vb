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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Extras))
        Me.DataExtres = New System.Windows.Forms.DataGridView()
        Me.CB_Empreses = New System.Windows.Forms.ComboBox()
        Me.DataExtresGeneral = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataExtres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataExtresGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataExtres
        '
        Me.DataExtres.AllowUserToAddRows = False
        Me.DataExtres.AllowUserToDeleteRows = False
        Me.DataExtres.AllowUserToResizeColumns = False
        Me.DataExtres.AllowUserToResizeRows = False
        Me.DataExtres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataExtres.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataExtres.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataExtres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataExtres.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataExtres.Location = New System.Drawing.Point(26, 74)
        Me.DataExtres.MultiSelect = False
        Me.DataExtres.Name = "DataExtres"
        Me.DataExtres.ReadOnly = True
        Me.DataExtres.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataExtres.RowHeadersVisible = False
        Me.DataExtres.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataExtres.RowTemplate.Height = 25
        Me.DataExtres.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DataExtres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataExtres.ShowEditingIcon = False
        Me.DataExtres.Size = New System.Drawing.Size(248, 251)
        Me.DataExtres.TabIndex = 0
        '
        'CB_Empreses
        '
        Me.CB_Empreses.FormattingEnabled = True
        Me.CB_Empreses.Location = New System.Drawing.Point(26, 45)
        Me.CB_Empreses.Name = "CB_Empreses"
        Me.CB_Empreses.Size = New System.Drawing.Size(248, 23)
        Me.CB_Empreses.TabIndex = 1
        '
        'DataExtresGeneral
        '
        Me.DataExtresGeneral.AllowUserToAddRows = False
        Me.DataExtresGeneral.AllowUserToDeleteRows = False
        Me.DataExtresGeneral.AllowUserToResizeColumns = False
        Me.DataExtresGeneral.AllowUserToResizeRows = False
        Me.DataExtresGeneral.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataExtresGeneral.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataExtresGeneral.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataExtresGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataExtresGeneral.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataExtresGeneral.Location = New System.Drawing.Point(304, 74)
        Me.DataExtresGeneral.MultiSelect = False
        Me.DataExtresGeneral.Name = "DataExtresGeneral"
        Me.DataExtresGeneral.ReadOnly = True
        Me.DataExtresGeneral.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataExtresGeneral.RowHeadersVisible = False
        Me.DataExtresGeneral.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataExtresGeneral.RowTemplate.Height = 25
        Me.DataExtresGeneral.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DataExtresGeneral.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataExtresGeneral.ShowEditingIcon = False
        Me.DataExtresGeneral.Size = New System.Drawing.Size(248, 251)
        Me.DataExtresGeneral.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(304, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(248, 23)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SITUACIÓ GENERAL"
        '
        'Extras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataExtresGeneral)
        Me.Controls.Add(Me.CB_Empreses)
        Me.Controls.Add(Me.DataExtres)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Extras"
        Me.Text = "Extres"
        CType(Me.DataExtres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataExtresGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataExtres As DataGridView
    Friend WithEvents CB_Empreses As ComboBox
    Friend WithEvents DataExtresGeneral As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
