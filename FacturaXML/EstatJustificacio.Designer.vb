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
        Panel1 = New Panel()
        Empresa = New Label()
        Panel = New Panel()
        Solucio = New Label()
        TeWord = New CheckBox()
        TeComprovant = New CheckBox()
        TeFactura = New CheckBox()
        LB_ordinador = New Label()
        FabricantSolucio = New TextBox()
        TeDada1 = New CheckBox()
        TeDada2 = New CheckBox()
        Gp_cost = New GroupBox()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Suport = New TextBox()
        Manteniment = New TextBox()
        Formacio = New TextBox()
        ImplantacioInicial = New TextBox()
        Label6 = New Label()
        TotalSolucio = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Btn_guardar = New Button()
        ProgressBar1 = New ProgressBar()
        Completat = New Label()
        Btn_CreaFactura = New Button()
        GP_import = New GroupBox()
        Label12 = New Label()
        Label18 = New Label()
        ImportSubvencionat = New TextBox()
        Factura = New TextBox()
        Label13 = New Label()
        GroupBox3 = New GroupBox()
        RB_Proces9 = New RadioButton()
        RB_Proces11 = New RadioButton()
        RB_Proces10 = New RadioButton()
        RB_Proces8 = New RadioButton()
        RB_Proces7 = New RadioButton()
        RB_Proces0 = New RadioButton()
        RB_Proces6 = New RadioButton()
        RB_Proces5 = New RadioButton()
        RB_Proces4 = New RadioButton()
        RB_Proces3 = New RadioButton()
        RB_Proces2 = New RadioButton()
        RB_Proces1 = New RadioButton()
        DataPresentacio = New DateTimePicker()
        TitolDataPresentacio = New Label()
        PanelCompletat = New Panel()
        GP_word = New GroupBox()
        Panel2 = New Panel()
        Lbl_tipusJustificacio = New Label()
        TB_Monitor = New TextBox()
        LB_Monitor = New Label()
        Panel1.SuspendLayout()
        Panel.SuspendLayout()
        Gp_cost.SuspendLayout()
        GP_import.SuspendLayout()
        GroupBox3.SuspendLayout()
        PanelCompletat.SuspendLayout()
        GP_word.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AutoSize = True
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Empresa)
        Panel1.Location = New Point(27, 86)
        Panel1.MaximumSize = New Size(393, 36)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(95, 36)
        Panel1.TabIndex = 0
        ' 
        ' Empresa
        ' 
        Empresa.AutoSize = True
        Empresa.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Empresa.Location = New Point(3, 4)
        Empresa.Name = "Empresa"
        Empresa.Size = New Size(87, 25)
        Empresa.TabIndex = 0
        Empresa.Text = "Empresa"
        ' 
        ' Panel
        ' 
        Panel.AutoSize = True
        Panel.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Panel.BorderStyle = BorderStyle.FixedSingle
        Panel.Controls.Add(Solucio)
        Panel.Location = New Point(27, 135)
        Panel.Name = "Panel"
        Panel.Size = New Size(86, 43)
        Panel.TabIndex = 1
        ' 
        ' Solucio
        ' 
        Solucio.AutoSize = True
        Solucio.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Solucio.Location = New Point(3, 9)
        Solucio.Name = "Solucio"
        Solucio.Size = New Size(78, 25)
        Solucio.TabIndex = 0
        Solucio.Text = "Solucio"
        ' 
        ' TeWord
        ' 
        TeWord.AutoSize = True
        TeWord.Location = New Point(15, 31)
        TeWord.Name = "TeWord"
        TeWord.Size = New Size(189, 19)
        TeWord.TabIndex = 3
        TeWord.Text = "Document Word amb captures"
        TeWord.UseVisualStyleBackColor = True
        ' 
        ' TeComprovant
        ' 
        TeComprovant.AutoSize = True
        TeComprovant.Location = New Point(15, 74)
        TeComprovant.Name = "TeComprovant"
        TeComprovant.Size = New Size(224, 19)
        TeComprovant.TabIndex = 4
        TeComprovant.Text = "Declaració responsable de cobrament"
        TeComprovant.UseVisualStyleBackColor = True
        ' 
        ' TeFactura
        ' 
        TeFactura.AutoSize = True
        TeFactura.Location = New Point(15, 117)
        TeFactura.Name = "TeFactura"
        TeFactura.Size = New Size(92, 19)
        TeFactura.TabIndex = 5
        TeFactura.Text = "Factura XML"
        TeFactura.UseVisualStyleBackColor = True
        ' 
        ' LB_ordinador
        ' 
        LB_ordinador.AutoSize = True
        LB_ordinador.Location = New Point(442, 45)
        LB_ordinador.Name = "LB_ordinador"
        LB_ordinador.Size = New Size(126, 15)
        LB_ordinador.TabIndex = 6
        LB_ordinador.Text = "Fabricant de la Solució"
        LB_ordinador.TextAlign = ContentAlignment.TopRight
        ' 
        ' FabricantSolucio
        ' 
        FabricantSolucio.Location = New Point(573, 41)
        FabricantSolucio.Name = "FabricantSolucio"
        FabricantSolucio.Size = New Size(208, 23)
        FabricantSolucio.TabIndex = 7
        ' 
        ' TeDada1
        ' 
        TeDada1.AutoSize = True
        TeDada1.Location = New Point(15, 160)
        TeDada1.Name = "TeDada1"
        TeDada1.Size = New Size(62, 19)
        TeDada1.TabIndex = 8
        TeDada1.Text = "Dada 1"
        TeDada1.UseVisualStyleBackColor = True
        ' 
        ' TeDada2
        ' 
        TeDada2.AutoSize = True
        TeDada2.Location = New Point(15, 203)
        TeDada2.Name = "TeDada2"
        TeDada2.Size = New Size(62, 19)
        TeDada2.TabIndex = 9
        TeDada2.Text = "Dada 2"
        TeDada2.UseVisualStyleBackColor = True
        ' 
        ' Gp_cost
        ' 
        Gp_cost.Controls.Add(Label11)
        Gp_cost.Controls.Add(Label10)
        Gp_cost.Controls.Add(Label9)
        Gp_cost.Controls.Add(Label8)
        Gp_cost.Controls.Add(Label7)
        Gp_cost.Controls.Add(Suport)
        Gp_cost.Controls.Add(Manteniment)
        Gp_cost.Controls.Add(Formacio)
        Gp_cost.Controls.Add(ImplantacioInicial)
        Gp_cost.Controls.Add(Label6)
        Gp_cost.Controls.Add(TotalSolucio)
        Gp_cost.Controls.Add(Label5)
        Gp_cost.Controls.Add(Label4)
        Gp_cost.Controls.Add(Label3)
        Gp_cost.Controls.Add(Label2)
        Gp_cost.Location = New Point(441, 137)
        Gp_cost.Name = "Gp_cost"
        Gp_cost.Size = New Size(340, 250)
        Gp_cost.TabIndex = 10
        Gp_cost.TabStop = False
        Gp_cost.Text = "Desglossament Cost de la Solució"
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(249, 196)
        Label11.Name = "Label11"
        Label11.Size = New Size(18, 20)
        Label11.TabIndex = 86
        Label11.Text = "€"
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(286, 151)
        Label10.Name = "Label10"
        Label10.Size = New Size(18, 20)
        Label10.TabIndex = 85
        Label10.Text = "€"
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(212, 112)
        Label9.Name = "Label9"
        Label9.Size = New Size(18, 20)
        Label9.TabIndex = 84
        Label9.Text = "€"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(229, 70)
        Label8.Name = "Label8"
        Label8.Size = New Size(18, 20)
        Label8.TabIndex = 83
        Label8.Text = "€"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(229, 25)
        Label7.Name = "Label7"
        Label7.Size = New Size(18, 20)
        Label7.TabIndex = 82
        Label7.Text = "€"
        ' 
        ' Suport
        ' 
        Suport.Location = New Point(143, 193)
        Suport.Name = "Suport"
        Suport.ReadOnly = True
        Suport.Size = New Size(100, 23)
        Suport.TabIndex = 9
        ' 
        ' Manteniment
        ' 
        Manteniment.Location = New Point(180, 151)
        Manteniment.Name = "Manteniment"
        Manteniment.ReadOnly = True
        Manteniment.Size = New Size(100, 23)
        Manteniment.TabIndex = 8
        ' 
        ' Formacio
        ' 
        Formacio.Location = New Point(106, 109)
        Formacio.Name = "Formacio"
        Formacio.ReadOnly = True
        Formacio.Size = New Size(100, 23)
        Formacio.TabIndex = 7
        ' 
        ' ImplantacioInicial
        ' 
        ImplantacioInicial.Location = New Point(153, 67)
        ImplantacioInicial.Name = "ImplantacioInicial"
        ImplantacioInicial.ReadOnly = True
        ImplantacioInicial.Size = New Size(70, 23)
        ImplantacioInicial.TabIndex = 6
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(43, 33)
        Label6.Name = "Label6"
        Label6.Size = New Size(74, 15)
        Label6.TabIndex = 5
        Label6.Text = "Total Solució"
        ' 
        ' TotalSolucio
        ' 
        TotalSolucio.Location = New Point(123, 25)
        TotalSolucio.Name = "TotalSolucio"
        TotalSolucio.Size = New Size(100, 23)
        TotalSolucio.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(43, 201)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 15)
        Label5.TabIndex = 3
        Label5.Text = "Suport 12 mesos"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(43, 159)
        Label4.Name = "Label4"
        Label4.Size = New Size(131, 15)
        Label4.TabIndex = 2
        Label4.Text = "Manteniment 12 mesos"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(43, 117)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 15)
        Label3.TabIndex = 1
        Label3.Text = "Formació"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(43, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 15)
        Label2.TabIndex = 0
        Label2.Text = "Implantació inicial"
        ' 
        ' Btn_guardar
        ' 
        Btn_guardar.Location = New Point(798, 478)
        Btn_guardar.Name = "Btn_guardar"
        Btn_guardar.Size = New Size(268, 42)
        Btn_guardar.TabIndex = 11
        Btn_guardar.Text = "Guardar"
        Btn_guardar.UseVisualStyleBackColor = True
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(27, 491)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(393, 29)
        ProgressBar1.TabIndex = 12
        ' 
        ' Completat
        ' 
        Completat.AutoSize = True
        Completat.BackColor = Color.Lime
        Completat.FlatStyle = FlatStyle.Flat
        Completat.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Completat.ForeColor = Color.White
        Completat.Location = New Point(55, 2)
        Completat.Name = "Completat"
        Completat.Size = New Size(164, 50)
        Completat.TabIndex = 13
        Completat.Text = "DOCUMENTACIÓ" & vbCrLf & "COMPLETADA"
        Completat.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Btn_CreaFactura
        ' 
        Btn_CreaFactura.Location = New Point(126, 110)
        Btn_CreaFactura.Name = "Btn_CreaFactura"
        Btn_CreaFactura.Size = New Size(143, 30)
        Btn_CreaFactura.TabIndex = 14
        Btn_CreaFactura.Text = "Crear Factura XML"
        Btn_CreaFactura.UseVisualStyleBackColor = True
        ' 
        ' GP_import
        ' 
        GP_import.Controls.Add(Label12)
        GP_import.Controls.Add(Label18)
        GP_import.Controls.Add(ImportSubvencionat)
        GP_import.Location = New Point(441, 420)
        GP_import.Name = "GP_import"
        GP_import.Size = New Size(340, 100)
        GP_import.TabIndex = 15
        GP_import.TabStop = False
        GP_import.Text = "Import subvencionat"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(22, 35)
        Label12.Name = "Label12"
        Label12.Size = New Size(105, 45)
        Label12.TabIndex = 87
        Label12.Text = "Import subvenció" & vbCrLf & "que apareixerà a la" & vbCrLf & "factura XML"
        ' 
        ' Label18
        ' 
        Label18.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label18.Location = New Point(302, 48)
        Label18.Name = "Label18"
        Label18.Size = New Size(18, 20)
        Label18.TabIndex = 81
        Label18.Text = "€"
        ' 
        ' ImportSubvencionat
        ' 
        ImportSubvencionat.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        ImportSubvencionat.Location = New Point(151, 41)
        ImportSubvencionat.Name = "ImportSubvencionat"
        ImportSubvencionat.Size = New Size(145, 33)
        ImportSubvencionat.TabIndex = 0
        ImportSubvencionat.TextAlign = HorizontalAlignment.Right
        ' 
        ' Factura
        ' 
        Factura.Location = New Point(573, 78)
        Factura.Name = "Factura"
        Factura.Size = New Size(208, 23)
        Factura.TabIndex = 17
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(521, 82)
        Label13.Name = "Label13"
        Label13.Size = New Size(46, 15)
        Label13.TabIndex = 16
        Label13.Text = "Factura"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(RB_Proces9)
        GroupBox3.Controls.Add(RB_Proces11)
        GroupBox3.Controls.Add(RB_Proces10)
        GroupBox3.Controls.Add(RB_Proces8)
        GroupBox3.Controls.Add(RB_Proces7)
        GroupBox3.Controls.Add(RB_Proces0)
        GroupBox3.Controls.Add(RB_Proces6)
        GroupBox3.Controls.Add(RB_Proces5)
        GroupBox3.Controls.Add(RB_Proces4)
        GroupBox3.Controls.Add(RB_Proces3)
        GroupBox3.Controls.Add(RB_Proces2)
        GroupBox3.Controls.Add(RB_Proces1)
        GroupBox3.Location = New Point(798, 103)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(268, 324)
        GroupBox3.TabIndex = 18
        GroupBox3.TabStop = False
        GroupBox3.Text = "Procés de justificació"
        ' 
        ' RB_Proces9
        ' 
        RB_Proces9.AutoSize = True
        RB_Proces9.Location = New Point(17, 241)
        RB_Proces9.Name = "RB_Proces9"
        RB_Proces9.Size = New Size(83, 19)
        RB_Proces9.TabIndex = 11
        RB_Proces9.TabStop = True
        RB_Proces9.Text = "No pagada"
        RB_Proces9.UseVisualStyleBackColor = True
        ' 
        ' RB_Proces11
        ' 
        RB_Proces11.AutoSize = True
        RB_Proces11.Location = New Point(17, 291)
        RB_Proces11.Name = "RB_Proces11"
        RB_Proces11.Size = New Size(214, 19)
        RB_Proces11.TabIndex = 10
        RB_Proces11.TabStop = True
        RB_Proces11.Text = "Procés de documentació addicional"
        RB_Proces11.UseVisualStyleBackColor = True
        ' 
        ' RB_Proces10
        ' 
        RB_Proces10.AutoSize = True
        RB_Proces10.Location = New Point(17, 266)
        RB_Proces10.Name = "RB_Proces10"
        RB_Proces10.Size = New Size(124, 19)
        RB_Proces10.TabIndex = 9
        RB_Proces10.TabStop = True
        RB_Proces10.Text = "Pagament minorat"
        RB_Proces10.UseVisualStyleBackColor = True
        ' 
        ' RB_Proces8
        ' 
        RB_Proces8.AutoSize = True
        RB_Proces8.Location = New Point(17, 168)
        RB_Proces8.Name = "RB_Proces8"
        RB_Proces8.Size = New Size(122, 19)
        RB_Proces8.TabIndex = 8
        RB_Proces8.TabStop = True
        RB_Proces8.Text = "Esmena incorrecta"
        RB_Proces8.UseVisualStyleBackColor = True
        ' 
        ' RB_Proces7
        ' 
        RB_Proces7.AutoSize = True
        RB_Proces7.Location = New Point(17, 144)
        RB_Proces7.Name = "RB_Proces7"
        RB_Proces7.Size = New Size(167, 19)
        RB_Proces7.TabIndex = 7
        RB_Proces7.TabStop = True
        RB_Proces7.Text = "Finalitzat termini d'esmena"
        RB_Proces7.UseVisualStyleBackColor = True
        ' 
        ' RB_Proces0
        ' 
        RB_Proces0.AutoSize = True
        RB_Proces0.Location = New Point(17, 24)
        RB_Proces0.Name = "RB_Proces0"
        RB_Proces0.Size = New Size(156, 19)
        RB_Proces0.TabIndex = 6
        RB_Proces0.TabStop = True
        RB_Proces0.Text = "Preparant documentació"
        RB_Proces0.UseVisualStyleBackColor = True
        ' 
        ' RB_Proces6
        ' 
        RB_Proces6.AutoSize = True
        RB_Proces6.Location = New Point(17, 216)
        RB_Proces6.Name = "RB_Proces6"
        RB_Proces6.Size = New Size(64, 19)
        RB_Proces6.TabIndex = 5
        RB_Proces6.TabStop = True
        RB_Proces6.Text = "Pagada"
        RB_Proces6.UseVisualStyleBackColor = True
        ' 
        ' RB_Proces5
        ' 
        RB_Proces5.AutoSize = True
        RB_Proces5.Location = New Point(17, 192)
        RB_Proces5.Name = "RB_Proces5"
        RB_Proces5.Size = New Size(146, 19)
        RB_Proces5.TabIndex = 4
        RB_Proces5.TabStop = True
        RB_Proces5.Text = "Validada per pagament"
        RB_Proces5.UseVisualStyleBackColor = True
        ' 
        ' RB_Proces4
        ' 
        RB_Proces4.AutoSize = True
        RB_Proces4.Location = New Point(17, 120)
        RB_Proces4.Name = "RB_Proces4"
        RB_Proces4.Size = New Size(149, 19)
        RB_Proces4.TabIndex = 3
        RB_Proces4.TabStop = True
        RB_Proces4.Text = "Termini d'esmena obert"
        RB_Proces4.UseVisualStyleBackColor = True
        ' 
        ' RB_Proces3
        ' 
        RB_Proces3.AutoSize = True
        RB_Proces3.Location = New Point(17, 96)
        RB_Proces3.Name = "RB_Proces3"
        RB_Proces3.Size = New Size(83, 19)
        RB_Proces3.TabIndex = 2
        RB_Proces3.TabStop = True
        RB_Proces3.Text = "Presentada"
        RB_Proces3.UseVisualStyleBackColor = True
        ' 
        ' RB_Proces2
        ' 
        RB_Proces2.AutoSize = True
        RB_Proces2.Location = New Point(17, 72)
        RB_Proces2.Name = "RB_Proces2"
        RB_Proces2.Size = New Size(77, 19)
        RB_Proces2.TabIndex = 1
        RB_Proces2.TabStop = True
        RB_Proces2.Text = "Esborrany"
        RB_Proces2.UseVisualStyleBackColor = True
        ' 
        ' RB_Proces1
        ' 
        RB_Proces1.AutoSize = True
        RB_Proces1.Location = New Point(17, 48)
        RB_Proces1.Name = "RB_Proces1"
        RB_Proces1.Size = New Size(66, 19)
        RB_Proces1.TabIndex = 0
        RB_Proces1.TabStop = True
        RB_Proces1.Text = "Enviada"
        RB_Proces1.UseVisualStyleBackColor = True
        ' 
        ' DataPresentacio
        ' 
        DataPresentacio.Location = New Point(798, 449)
        DataPresentacio.Name = "DataPresentacio"
        DataPresentacio.Size = New Size(268, 23)
        DataPresentacio.TabIndex = 19
        DataPresentacio.Visible = False
        ' 
        ' TitolDataPresentacio
        ' 
        TitolDataPresentacio.AutoSize = True
        TitolDataPresentacio.Location = New Point(797, 430)
        TitolDataPresentacio.Name = "TitolDataPresentacio"
        TitolDataPresentacio.Size = New Size(167, 15)
        TitolDataPresentacio.TabIndex = 20
        TitolDataPresentacio.Text = "Introdueix data de presentació"
        TitolDataPresentacio.Visible = False
        ' 
        ' PanelCompletat
        ' 
        PanelCompletat.BackColor = Color.Lime
        PanelCompletat.BorderStyle = BorderStyle.FixedSingle
        PanelCompletat.Controls.Add(Completat)
        PanelCompletat.Location = New Point(798, 34)
        PanelCompletat.Name = "PanelCompletat"
        PanelCompletat.Size = New Size(268, 55)
        PanelCompletat.TabIndex = 21
        PanelCompletat.Visible = False
        ' 
        ' GP_word
        ' 
        GP_word.Controls.Add(TeWord)
        GP_word.Controls.Add(TeComprovant)
        GP_word.Controls.Add(TeFactura)
        GP_word.Controls.Add(TeDada1)
        GP_word.Controls.Add(Btn_CreaFactura)
        GP_word.Controls.Add(TeDada2)
        GP_word.Location = New Point(27, 197)
        GP_word.Name = "GP_word"
        GP_word.Size = New Size(393, 288)
        GP_word.TabIndex = 22
        GP_word.TabStop = False
        GP_word.Text = "Document Word"
        ' 
        ' Panel2
        ' 
        Panel2.AutoSize = True
        Panel2.BackColor = SystemColors.ButtonShadow
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Lbl_tipusJustificacio)
        Panel2.Location = New Point(27, 29)
        Panel2.MaximumSize = New Size(393, 36)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(393, 36)
        Panel2.TabIndex = 23
        ' 
        ' Lbl_tipusJustificacio
        ' 
        Lbl_tipusJustificacio.AutoSize = True
        Lbl_tipusJustificacio.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Lbl_tipusJustificacio.Location = New Point(102, 4)
        Lbl_tipusJustificacio.Name = "Lbl_tipusJustificacio"
        Lbl_tipusJustificacio.Size = New Size(181, 25)
        Lbl_tipusJustificacio.TabIndex = 0
        Lbl_tipusJustificacio.Text = "Primera justificació"
        Lbl_tipusJustificacio.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TB_Monitor
        ' 
        TB_Monitor.Location = New Point(573, 10)
        TB_Monitor.Name = "TB_Monitor"
        TB_Monitor.Size = New Size(208, 23)
        TB_Monitor.TabIndex = 25
        TB_Monitor.Visible = False
        ' 
        ' LB_Monitor
        ' 
        LB_Monitor.AutoSize = True
        LB_Monitor.Location = New Point(517, 14)
        LB_Monitor.Name = "LB_Monitor"
        LB_Monitor.Size = New Size(50, 15)
        LB_Monitor.TabIndex = 24
        LB_Monitor.Text = "Monitor"
        LB_Monitor.TextAlign = ContentAlignment.TopRight
        LB_Monitor.Visible = False
        ' 
        ' EstatJustificacio
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(1076, 547)
        Controls.Add(TB_Monitor)
        Controls.Add(LB_Monitor)
        Controls.Add(Panel2)
        Controls.Add(GP_word)
        Controls.Add(PanelCompletat)
        Controls.Add(TitolDataPresentacio)
        Controls.Add(DataPresentacio)
        Controls.Add(GroupBox3)
        Controls.Add(Factura)
        Controls.Add(Label13)
        Controls.Add(GP_import)
        Controls.Add(ProgressBar1)
        Controls.Add(Btn_guardar)
        Controls.Add(Gp_cost)
        Controls.Add(FabricantSolucio)
        Controls.Add(LB_ordinador)
        Controls.Add(Panel)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "EstatJustificacio"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Estat Justificacions"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel.ResumeLayout(False)
        Panel.PerformLayout()
        Gp_cost.ResumeLayout(False)
        Gp_cost.PerformLayout()
        GP_import.ResumeLayout(False)
        GP_import.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        PanelCompletat.ResumeLayout(False)
        PanelCompletat.PerformLayout()
        GP_word.ResumeLayout(False)
        GP_word.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Empresa As Label
    Friend WithEvents Panel As Panel
    Friend WithEvents Solucio As Label
    Friend WithEvents TeWord As CheckBox
    Friend WithEvents TeComprovant As CheckBox
    Friend WithEvents TeFactura As CheckBox
    Friend WithEvents LB_ordinador As Label
    Friend WithEvents FabricantSolucio As TextBox
    Friend WithEvents TeDada1 As CheckBox
    Friend WithEvents TeDada2 As CheckBox
    Friend WithEvents Gp_cost As GroupBox
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
    Friend WithEvents GP_import As GroupBox
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
    Friend WithEvents GP_word As GroupBox
    Friend WithEvents RB_Proces8 As RadioButton
    Friend WithEvents RB_Proces7 As RadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Lbl_tipusJustificacio As Label
    Friend WithEvents RB_Proces9 As RadioButton
    Friend WithEvents RB_Proces11 As RadioButton
    Friend WithEvents RB_Proces10 As RadioButton
    Friend WithEvents TB_Monitor As TextBox
    Friend WithEvents LB_Monitor As Label
End Class
