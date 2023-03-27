<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EstatJustificacio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EstatJustificacio))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Empresa = New System.Windows.Forms.Label()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.Solucio = New System.Windows.Forms.Label()
        Me.TeWord = New System.Windows.Forms.CheckBox()
        Me.TeComprovant = New System.Windows.Forms.CheckBox()
        Me.TeFactura = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FabricantSolucio = New System.Windows.Forms.TextBox()
        Me.TeDada1 = New System.Windows.Forms.CheckBox()
        Me.TeDada2 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Suport = New System.Windows.Forms.TextBox()
        Me.Manteniment = New System.Windows.Forms.TextBox()
        Me.Formacio = New System.Windows.Forms.TextBox()
        Me.ImplantacioInicial = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TotalSolucio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_guardar = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Completat = New System.Windows.Forms.Label()
        Me.Btn_CreaFactura = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ImportSubvencionat = New System.Windows.Forms.TextBox()
        Me.Factura = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RB_Proces0 = New System.Windows.Forms.RadioButton()
        Me.RB_Proces6 = New System.Windows.Forms.RadioButton()
        Me.RB_Proces5 = New System.Windows.Forms.RadioButton()
        Me.RB_Proces4 = New System.Windows.Forms.RadioButton()
        Me.RB_Proces3 = New System.Windows.Forms.RadioButton()
        Me.RB_Proces2 = New System.Windows.Forms.RadioButton()
        Me.RB_Proces1 = New System.Windows.Forms.RadioButton()
        Me.DataPresentacio = New System.Windows.Forms.DateTimePicker()
        Me.TitolDataPresentacio = New System.Windows.Forms.Label()
        Me.PanelCompletat = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RB_Proces7 = New System.Windows.Forms.RadioButton()
        Me.RB_Proces8 = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        Me.Panel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.PanelCompletat.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Empresa)
        Me.Panel1.Location = New System.Drawing.Point(25, 25)
        Me.Panel1.MaximumSize = New System.Drawing.Size(393, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(95, 36)
        Me.Panel1.TabIndex = 0
        '
        'Empresa
        '
        Me.Empresa.AutoSize = True
        Me.Empresa.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Empresa.Location = New System.Drawing.Point(3, 4)
        Me.Empresa.Name = "Empresa"
        Me.Empresa.Size = New System.Drawing.Size(87, 25)
        Me.Empresa.TabIndex = 0
        Me.Empresa.Text = "Empresa"
        '
        'Panel
        '
        Me.Panel.AutoSize = True
        Me.Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel.Controls.Add(Me.Solucio)
        Me.Panel.Location = New System.Drawing.Point(25, 74)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(86, 43)
        Me.Panel.TabIndex = 1
        '
        'Solucio
        '
        Me.Solucio.AutoSize = True
        Me.Solucio.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Solucio.Location = New System.Drawing.Point(3, 9)
        Me.Solucio.Name = "Solucio"
        Me.Solucio.Size = New System.Drawing.Size(78, 25)
        Me.Solucio.TabIndex = 0
        Me.Solucio.Text = "Solucio"
        '
        'TeWord
        '
        Me.TeWord.AutoSize = True
        Me.TeWord.Location = New System.Drawing.Point(15, 31)
        Me.TeWord.Name = "TeWord"
        Me.TeWord.Size = New System.Drawing.Size(189, 19)
        Me.TeWord.TabIndex = 3
        Me.TeWord.Text = "Document Word amb captures"
        Me.TeWord.UseVisualStyleBackColor = True
        '
        'TeComprovant
        '
        Me.TeComprovant.AutoSize = True
        Me.TeComprovant.Location = New System.Drawing.Point(15, 74)
        Me.TeComprovant.Name = "TeComprovant"
        Me.TeComprovant.Size = New System.Drawing.Size(224, 19)
        Me.TeComprovant.TabIndex = 4
        Me.TeComprovant.Text = "Declaració responsable de cobrament"
        Me.TeComprovant.UseVisualStyleBackColor = True
        '
        'TeFactura
        '
        Me.TeFactura.AutoSize = True
        Me.TeFactura.Location = New System.Drawing.Point(15, 117)
        Me.TeFactura.Name = "TeFactura"
        Me.TeFactura.Size = New System.Drawing.Size(92, 19)
        Me.TeFactura.TabIndex = 5
        Me.TeFactura.Text = "Factura XML"
        Me.TeFactura.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(439, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Fabricant de la Solució"
        '
        'FabricantSolucio
        '
        Me.FabricantSolucio.Location = New System.Drawing.Point(571, 25)
        Me.FabricantSolucio.Name = "FabricantSolucio"
        Me.FabricantSolucio.Size = New System.Drawing.Size(208, 23)
        Me.FabricantSolucio.TabIndex = 7
        '
        'TeDada1
        '
        Me.TeDada1.AutoSize = True
        Me.TeDada1.Location = New System.Drawing.Point(15, 160)
        Me.TeDada1.Name = "TeDada1"
        Me.TeDada1.Size = New System.Drawing.Size(62, 19)
        Me.TeDada1.TabIndex = 8
        Me.TeDada1.Text = "Dada 1"
        Me.TeDada1.UseVisualStyleBackColor = True
        '
        'TeDada2
        '
        Me.TeDada2.AutoSize = True
        Me.TeDada2.Location = New System.Drawing.Point(15, 203)
        Me.TeDada2.Name = "TeDada2"
        Me.TeDada2.Size = New System.Drawing.Size(62, 19)
        Me.TeDada2.TabIndex = 9
        Me.TeDada2.Text = "Dada 2"
        Me.TeDada2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Suport)
        Me.GroupBox1.Controls.Add(Me.Manteniment)
        Me.GroupBox1.Controls.Add(Me.Formacio)
        Me.GroupBox1.Controls.Add(Me.ImplantacioInicial)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TotalSolucio)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(439, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(340, 250)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Desglossament Cost de la Solució"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(249, 196)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 20)
        Me.Label11.TabIndex = 86
        Me.Label11.Text = "€"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(286, 151)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 20)
        Me.Label10.TabIndex = 85
        Me.Label10.Text = "€"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(212, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 20)
        Me.Label9.TabIndex = 84
        Me.Label9.Text = "€"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(229, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 20)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "€"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(229, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 20)
        Me.Label7.TabIndex = 82
        Me.Label7.Text = "€"
        '
        'Suport
        '
        Me.Suport.Location = New System.Drawing.Point(143, 193)
        Me.Suport.Name = "Suport"
        Me.Suport.ReadOnly = True
        Me.Suport.Size = New System.Drawing.Size(100, 23)
        Me.Suport.TabIndex = 9
        '
        'Manteniment
        '
        Me.Manteniment.Location = New System.Drawing.Point(180, 151)
        Me.Manteniment.Name = "Manteniment"
        Me.Manteniment.ReadOnly = True
        Me.Manteniment.Size = New System.Drawing.Size(100, 23)
        Me.Manteniment.TabIndex = 8
        '
        'Formacio
        '
        Me.Formacio.Location = New System.Drawing.Point(106, 109)
        Me.Formacio.Name = "Formacio"
        Me.Formacio.ReadOnly = True
        Me.Formacio.Size = New System.Drawing.Size(100, 23)
        Me.Formacio.TabIndex = 7
        '
        'ImplantacioInicial
        '
        Me.ImplantacioInicial.Location = New System.Drawing.Point(153, 67)
        Me.ImplantacioInicial.Name = "ImplantacioInicial"
        Me.ImplantacioInicial.ReadOnly = True
        Me.ImplantacioInicial.Size = New System.Drawing.Size(70, 23)
        Me.ImplantacioInicial.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total Solució"
        '
        'TotalSolucio
        '
        Me.TotalSolucio.Location = New System.Drawing.Point(123, 25)
        Me.TotalSolucio.Name = "TotalSolucio"
        Me.TotalSolucio.Size = New System.Drawing.Size(100, 23)
        Me.TotalSolucio.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Suport 12 mesos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Manteniment 12 mesos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Formació"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Implantació inicial"
        '
        'Btn_guardar
        '
        Me.Btn_guardar.Location = New System.Drawing.Point(796, 407)
        Me.Btn_guardar.Name = "Btn_guardar"
        Me.Btn_guardar.Size = New System.Drawing.Size(268, 52)
        Me.Btn_guardar.TabIndex = 11
        Me.Btn_guardar.Text = "Guardar"
        Me.Btn_guardar.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(25, 430)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(393, 29)
        Me.ProgressBar1.TabIndex = 12
        '
        'Completat
        '
        Me.Completat.AutoSize = True
        Me.Completat.BackColor = System.Drawing.Color.Lime
        Me.Completat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Completat.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Completat.ForeColor = System.Drawing.Color.White
        Me.Completat.Location = New System.Drawing.Point(55, 2)
        Me.Completat.Name = "Completat"
        Me.Completat.Size = New System.Drawing.Size(164, 50)
        Me.Completat.TabIndex = 13
        Me.Completat.Text = "DOCUMENTACIÓ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "COMPLETADA"
        Me.Completat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn_CreaFactura
        '
        Me.Btn_CreaFactura.Location = New System.Drawing.Point(126, 110)
        Me.Btn_CreaFactura.Name = "Btn_CreaFactura"
        Me.Btn_CreaFactura.Size = New System.Drawing.Size(143, 30)
        Me.Btn_CreaFactura.TabIndex = 14
        Me.Btn_CreaFactura.Text = "Crear Factura XML"
        Me.Btn_CreaFactura.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.ImportSubvencionat)
        Me.GroupBox2.Location = New System.Drawing.Point(439, 359)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(340, 100)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Import subvencionat"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(22, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 45)
        Me.Label12.TabIndex = 87
        Me.Label12.Text = "Import subvenció" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "que apareixerà a la" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "factura XML"
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label18.Location = New System.Drawing.Point(302, 48)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(18, 20)
        Me.Label18.TabIndex = 81
        Me.Label18.Text = "€"
        '
        'ImportSubvencionat
        '
        Me.ImportSubvencionat.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ImportSubvencionat.Location = New System.Drawing.Point(151, 41)
        Me.ImportSubvencionat.Name = "ImportSubvencionat"
        Me.ImportSubvencionat.Size = New System.Drawing.Size(145, 33)
        Me.ImportSubvencionat.TabIndex = 0
        Me.ImportSubvencionat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Factura
        '
        Me.Factura.Location = New System.Drawing.Point(571, 57)
        Me.Factura.Name = "Factura"
        Me.Factura.Size = New System.Drawing.Size(208, 23)
        Me.Factura.TabIndex = 17
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(519, 65)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 15)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Factura"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RB_Proces8)
        Me.GroupBox3.Controls.Add(Me.RB_Proces7)
        Me.GroupBox3.Controls.Add(Me.RB_Proces0)
        Me.GroupBox3.Controls.Add(Me.RB_Proces6)
        Me.GroupBox3.Controls.Add(Me.RB_Proces5)
        Me.GroupBox3.Controls.Add(Me.RB_Proces4)
        Me.GroupBox3.Controls.Add(Me.RB_Proces3)
        Me.GroupBox3.Controls.Add(Me.RB_Proces2)
        Me.GroupBox3.Controls.Add(Me.RB_Proces1)
        Me.GroupBox3.Location = New System.Drawing.Point(796, 103)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(268, 250)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Procés de justificació"
        '
        'RB_Proces0
        '
        Me.RB_Proces0.AutoSize = True
        Me.RB_Proces0.Location = New System.Drawing.Point(17, 24)
        Me.RB_Proces0.Name = "RB_Proces0"
        Me.RB_Proces0.Size = New System.Drawing.Size(156, 19)
        Me.RB_Proces0.TabIndex = 6
        Me.RB_Proces0.TabStop = True
        Me.RB_Proces0.Text = "Preparant documentació"
        Me.RB_Proces0.UseVisualStyleBackColor = True
        '
        'RB_Proces6
        '
        Me.RB_Proces6.AutoSize = True
        Me.RB_Proces6.Location = New System.Drawing.Point(17, 216)
        Me.RB_Proces6.Name = "RB_Proces6"
        Me.RB_Proces6.Size = New System.Drawing.Size(64, 19)
        Me.RB_Proces6.TabIndex = 5
        Me.RB_Proces6.TabStop = True
        Me.RB_Proces6.Text = "Pagada"
        Me.RB_Proces6.UseVisualStyleBackColor = True
        '
        'RB_Proces5
        '
        Me.RB_Proces5.AutoSize = True
        Me.RB_Proces5.Location = New System.Drawing.Point(17, 192)
        Me.RB_Proces5.Name = "RB_Proces5"
        Me.RB_Proces5.Size = New System.Drawing.Size(146, 19)
        Me.RB_Proces5.TabIndex = 4
        Me.RB_Proces5.TabStop = True
        Me.RB_Proces5.Text = "Validada per pagament"
        Me.RB_Proces5.UseVisualStyleBackColor = True
        '
        'RB_Proces4
        '
        Me.RB_Proces4.AutoSize = True
        Me.RB_Proces4.Location = New System.Drawing.Point(17, 120)
        Me.RB_Proces4.Name = "RB_Proces4"
        Me.RB_Proces4.Size = New System.Drawing.Size(149, 19)
        Me.RB_Proces4.TabIndex = 3
        Me.RB_Proces4.TabStop = True
        Me.RB_Proces4.Text = "Termini d'esmena obert"
        Me.RB_Proces4.UseVisualStyleBackColor = True
        '
        'RB_Proces3
        '
        Me.RB_Proces3.AutoSize = True
        Me.RB_Proces3.Location = New System.Drawing.Point(17, 96)
        Me.RB_Proces3.Name = "RB_Proces3"
        Me.RB_Proces3.Size = New System.Drawing.Size(83, 19)
        Me.RB_Proces3.TabIndex = 2
        Me.RB_Proces3.TabStop = True
        Me.RB_Proces3.Text = "Presentada"
        Me.RB_Proces3.UseVisualStyleBackColor = True
        '
        'RB_Proces2
        '
        Me.RB_Proces2.AutoSize = True
        Me.RB_Proces2.Location = New System.Drawing.Point(17, 72)
        Me.RB_Proces2.Name = "RB_Proces2"
        Me.RB_Proces2.Size = New System.Drawing.Size(77, 19)
        Me.RB_Proces2.TabIndex = 1
        Me.RB_Proces2.TabStop = True
        Me.RB_Proces2.Text = "Esborrany"
        Me.RB_Proces2.UseVisualStyleBackColor = True
        '
        'RB_Proces1
        '
        Me.RB_Proces1.AutoSize = True
        Me.RB_Proces1.Location = New System.Drawing.Point(17, 48)
        Me.RB_Proces1.Name = "RB_Proces1"
        Me.RB_Proces1.Size = New System.Drawing.Size(66, 19)
        Me.RB_Proces1.TabIndex = 0
        Me.RB_Proces1.TabStop = True
        Me.RB_Proces1.Text = "Enviada"
        Me.RB_Proces1.UseVisualStyleBackColor = True
        '
        'DataPresentacio
        '
        Me.DataPresentacio.Location = New System.Drawing.Point(796, 378)
        Me.DataPresentacio.Name = "DataPresentacio"
        Me.DataPresentacio.Size = New System.Drawing.Size(268, 23)
        Me.DataPresentacio.TabIndex = 19
        Me.DataPresentacio.Visible = False
        '
        'TitolDataPresentacio
        '
        Me.TitolDataPresentacio.AutoSize = True
        Me.TitolDataPresentacio.Location = New System.Drawing.Point(795, 359)
        Me.TitolDataPresentacio.Name = "TitolDataPresentacio"
        Me.TitolDataPresentacio.Size = New System.Drawing.Size(167, 15)
        Me.TitolDataPresentacio.TabIndex = 20
        Me.TitolDataPresentacio.Text = "Introdueix data de presentació"
        Me.TitolDataPresentacio.Visible = False
        '
        'PanelCompletat
        '
        Me.PanelCompletat.BackColor = System.Drawing.Color.Lime
        Me.PanelCompletat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelCompletat.Controls.Add(Me.Completat)
        Me.PanelCompletat.Location = New System.Drawing.Point(796, 25)
        Me.PanelCompletat.Name = "PanelCompletat"
        Me.PanelCompletat.Size = New System.Drawing.Size(268, 55)
        Me.PanelCompletat.TabIndex = 21
        Me.PanelCompletat.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TeWord)
        Me.GroupBox4.Controls.Add(Me.TeComprovant)
        Me.GroupBox4.Controls.Add(Me.TeFactura)
        Me.GroupBox4.Controls.Add(Me.TeDada1)
        Me.GroupBox4.Controls.Add(Me.Btn_CreaFactura)
        Me.GroupBox4.Controls.Add(Me.TeDada2)
        Me.GroupBox4.Location = New System.Drawing.Point(25, 136)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(393, 288)
        Me.GroupBox4.TabIndex = 22
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Document Word"
        '
        'RB_Proces7
        '
        Me.RB_Proces7.AutoSize = True
        Me.RB_Proces7.Location = New System.Drawing.Point(17, 144)
        Me.RB_Proces7.Name = "RB_Proces7"
        Me.RB_Proces7.Size = New System.Drawing.Size(167, 19)
        Me.RB_Proces7.TabIndex = 7
        Me.RB_Proces7.TabStop = True
        Me.RB_Proces7.Text = "Finalitzat termini d'esmena"
        Me.RB_Proces7.UseVisualStyleBackColor = True
        '
        'RB_Proces8
        '
        Me.RB_Proces8.AutoSize = True
        Me.RB_Proces8.Location = New System.Drawing.Point(17, 168)
        Me.RB_Proces8.Name = "RB_Proces8"
        Me.RB_Proces8.Size = New System.Drawing.Size(122, 19)
        Me.RB_Proces8.TabIndex = 8
        Me.RB_Proces8.TabStop = True
        Me.RB_Proces8.Text = "Esmena incorrecta"
        Me.RB_Proces8.UseVisualStyleBackColor = True
        '
        'EstatJustificacio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1076, 478)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.PanelCompletat)
        Me.Controls.Add(Me.TitolDataPresentacio)
        Me.Controls.Add(Me.DataPresentacio)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Factura)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Btn_guardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.FabricantSolucio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EstatJustificacio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estat Justificacions"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.PanelCompletat.ResumeLayout(False)
        Me.PanelCompletat.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Empresa As Label
    Friend WithEvents Panel As Panel
    Friend WithEvents Solucio As Label
    Friend WithEvents TeWord As CheckBox
    Friend WithEvents TeComprovant As CheckBox
    Friend WithEvents TeFactura As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FabricantSolucio As TextBox
    Friend WithEvents TeDada1 As CheckBox
    Friend WithEvents TeDada2 As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TotalSolucio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Suport As TextBox
    Friend WithEvents Manteniment As TextBox
    Friend WithEvents Formacio As TextBox
    Friend WithEvents ImplantacioInicial As TextBox
    Friend WithEvents Btn_guardar As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Completat As Label
    Friend WithEvents Btn_CreaFactura As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ImportSubvencionat As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Factura As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RB_Proces5 As RadioButton
    Friend WithEvents RB_Proces4 As RadioButton
    Friend WithEvents RB_Proces3 As RadioButton
    Friend WithEvents RB_Proces2 As RadioButton
    Friend WithEvents RB_Proces1 As RadioButton
    Friend WithEvents RB_Proces6 As RadioButton
    Friend WithEvents RB_Proces0 As RadioButton
    Friend WithEvents DataPresentacio As DateTimePicker
    Friend WithEvents TitolDataPresentacio As Label
    Friend WithEvents PanelCompletat As Panel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RB_Proces8 As RadioButton
    Friend WithEvents RB_Proces7 As RadioButton
End Class
