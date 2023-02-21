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
        CType(Me.DataExtres, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataExtres
        '
        Me.DataExtres.AllowUserToAddRows = False
        Me.DataExtres.AllowUserToDeleteRows = False
        Me.DataExtres.AllowUserToResizeColumns = False
        Me.DataExtres.AllowUserToResizeRows = False
        Me.DataExtres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataExtres.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataExtres.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataExtres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataExtres.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataExtres.Location = New System.Drawing.Point(232, 45)
        Me.DataExtres.MultiSelect = False
        Me.DataExtres.Name = "DataExtres"
        Me.DataExtres.ReadOnly = True
        Me.DataExtres.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
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
        Me.CB_Empreses.Size = New System.Drawing.Size(191, 23)
        Me.CB_Empreses.TabIndex = 1
        '
        'Extras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CB_Empreses)
        Me.Controls.Add(Me.DataExtres)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Extras"
        Me.Text = "Extres"
        CType(Me.DataExtres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataExtres As DataGridView
    Friend WithEvents CB_Empreses As ComboBox
End Class
