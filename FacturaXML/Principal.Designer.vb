<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.Btn_Factures = New System.Windows.Forms.Button()
        Me.Btn_Contractes = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.ArxiuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SortirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KitsDigitalsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LlistatTotalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestióDeKitsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearFacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DadesEmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreGestioDeKitsDigitalsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_Factures
        '
        Me.Btn_Factures.BackgroundImage = Global.FacturaXML.My.Resources.Resources.icono_facturas
        Me.Btn_Factures.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_Factures.FlatAppearance.BorderSize = 0
        Me.Btn_Factures.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Factures.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Btn_Factures.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Factures.Location = New System.Drawing.Point(115, 216)
        Me.Btn_Factures.Name = "Btn_Factures"
        Me.Btn_Factures.Size = New System.Drawing.Size(132, 124)
        Me.Btn_Factures.TabIndex = 0
        Me.Btn_Factures.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_Factures.UseVisualStyleBackColor = True
        '
        'Btn_Contractes
        '
        Me.Btn_Contractes.BackgroundImage = Global.FacturaXML.My.Resources.Resources.icono_empresas
        Me.Btn_Contractes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_Contractes.FlatAppearance.BorderSize = 0
        Me.Btn_Contractes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Contractes.Location = New System.Drawing.Point(278, 216)
        Me.Btn_Contractes.Name = "Btn_Contractes"
        Me.Btn_Contractes.Size = New System.Drawing.Size(130, 124)
        Me.Btn_Contractes.TabIndex = 1
        Me.Btn_Contractes.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FacturaXML.My.Resources.Resources.logo_telematic_2
        Me.PictureBox1.Location = New System.Drawing.Point(39, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(222, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(296, 52)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(399, 73)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 19
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(137, 343)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 25)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Factures"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(256, 343)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 25)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Gestió de solucions"
        '
        'MenuPrincipal
        '
        Me.MenuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArxiuToolStripMenuItem, Me.KitsDigitalsToolStripMenuItem, Me.FacturesToolStripMenuItem, Me.AjudaToolStripMenuItem})
        Me.MenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.MenuPrincipal.Name = "MenuPrincipal"
        Me.MenuPrincipal.Size = New System.Drawing.Size(727, 24)
        Me.MenuPrincipal.TabIndex = 22
        Me.MenuPrincipal.Text = "MenuStrip1"
        '
        'ArxiuToolStripMenuItem
        '
        Me.ArxiuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SortirToolStripMenuItem})
        Me.ArxiuToolStripMenuItem.Name = "ArxiuToolStripMenuItem"
        Me.ArxiuToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ArxiuToolStripMenuItem.Text = "Arxiu"
        '
        'SortirToolStripMenuItem
        '
        Me.SortirToolStripMenuItem.Image = Global.FacturaXML.My.Resources.Resources.icono_salir
        Me.SortirToolStripMenuItem.Name = "SortirToolStripMenuItem"
        Me.SortirToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.SortirToolStripMenuItem.Text = "Sortir"
        '
        'KitsDigitalsToolStripMenuItem
        '
        Me.KitsDigitalsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LlistatTotalToolStripMenuItem, Me.GestióDeKitsToolStripMenuItem})
        Me.KitsDigitalsToolStripMenuItem.Name = "KitsDigitalsToolStripMenuItem"
        Me.KitsDigitalsToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.KitsDigitalsToolStripMenuItem.Text = "Kits Digitals"
        '
        'LlistatTotalToolStripMenuItem
        '
        Me.LlistatTotalToolStripMenuItem.Name = "LlistatTotalToolStripMenuItem"
        Me.LlistatTotalToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LlistatTotalToolStripMenuItem.Text = "Llistat total"
        '
        'GestióDeKitsToolStripMenuItem
        '
        Me.GestióDeKitsToolStripMenuItem.Name = "GestióDeKitsToolStripMenuItem"
        Me.GestióDeKitsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GestióDeKitsToolStripMenuItem.Text = "Gestió de Solucions"
        '
        'FacturesToolStripMenuItem
        '
        Me.FacturesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearFacturaToolStripMenuItem, Me.DadesEmpresaToolStripMenuItem})
        Me.FacturesToolStripMenuItem.Name = "FacturesToolStripMenuItem"
        Me.FacturesToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.FacturesToolStripMenuItem.Text = "Factures"
        '
        'CrearFacturaToolStripMenuItem
        '
        Me.CrearFacturaToolStripMenuItem.Name = "CrearFacturaToolStripMenuItem"
        Me.CrearFacturaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CrearFacturaToolStripMenuItem.Text = "Crear factura"
        '
        'DadesEmpresaToolStripMenuItem
        '
        Me.DadesEmpresaToolStripMenuItem.Name = "DadesEmpresaToolStripMenuItem"
        Me.DadesEmpresaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DadesEmpresaToolStripMenuItem.Text = "Dades empresa"
        '
        'AjudaToolStripMenuItem
        '
        Me.AjudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SobreGestioDeKitsDigitalsToolStripMenuItem})
        Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.AjudaToolStripMenuItem.Text = "Ajuda"
        '
        'SobreGestioDeKitsDigitalsToolStripMenuItem
        '
        Me.SobreGestioDeKitsDigitalsToolStripMenuItem.Image = Global.FacturaXML.My.Resources.Resources.icono_ayuda
        Me.SobreGestioDeKitsDigitalsToolStripMenuItem.Name = "SobreGestioDeKitsDigitalsToolStripMenuItem"
        Me.SobreGestioDeKitsDigitalsToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.SobreGestioDeKitsDigitalsToolStripMenuItem.Text = "Sobre Gestió de Kits Digitals"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(443, 343)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 25)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Llistat de solucions"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.FacturaXML.My.Resources.Resources.tarea
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(463, 216)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 124)
        Me.Button1.TabIndex = 23
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(727, 408)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Btn_Contractes)
        Me.Controls.Add(Me.Btn_Factures)
        Me.Controls.Add(Me.MenuPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuPrincipal
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestió de Kits Digitals"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuPrincipal.ResumeLayout(False)
        Me.MenuPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Factures As Button
    Friend WithEvents Btn_Contractes As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuPrincipal As MenuStrip
    Friend WithEvents ArxiuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SortirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SobreGestioDeKitsDigitalsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KitsDigitalsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LlistatTotalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestióDeKitsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearFacturaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DadesEmpresaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class
