Imports System.Globalization

Public Class Inici

    Private Sub Inici_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

        flogo.MdiParent = Me
        fcontr.MdiParent = Me
        fempre.MdiParent = Me
        fextra.MdiParent = Me
        ffactu.MdiParent = Me
        fsolu.MdiParent = Me
        finfo.MdiParent = Me

        PanelContenedor.Controls.Add(flogo)
        PanelContenedor.Controls.Add(fcontr)
        PanelContenedor.Controls.Add(fempre)
        PanelContenedor.Controls.Add(fextra)
        PanelContenedor.Controls.Add(ffactu)
        PanelContenedor.Controls.Add(fsolu)
        PanelContenedor.Controls.Add(finfo)

        MostraForm(flogo)

    End Sub

    Private Sub TmOcultarMenu_Tick(sender As Object, e As EventArgs) Handles TmOcultarMenu.Tick
        If PanelMenu.Width < 80 Then
            Me.TmOcultarMenu.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width - 20
        End If
    End Sub

    Private Sub TmMostrarMenu_Tick(sender As Object, e As EventArgs) Handles TmMostrarMenu.Tick
        If PanelMenu.Width >= 220 Then
            Me.TmMostrarMenu.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width + 20
        End If
    End Sub

    Private Sub btn_Menu_Click(sender As Object, e As EventArgs) Handles btn_Menu.Click

        If PanelMenu.Width = 220 Then
            TmOcultarMenu.Enabled = True
        ElseIf PanelMenu.Width = 60 Then
            TmMostrarMenu.Enabled = True
        End If
    End Sub

    Public Sub MostraForm(ByVal FormMostrar As Form)

        If FormMostrar Is Nothing OrElse FormMostrar.IsDisposed Then
            Dim tipusFormulari As Type = FormMostrar.GetType
            Debug.WriteLine("No existe, creamos: " & FormMostrar.Name)
            Select Case (tipusFormulari.Name)
                Case Contractes.Name
                    fcontr = New Contractes
                    FormMostrar = fcontr
                Case Empreses.Name
                    fempre = New Empreses
                    FormMostrar = fempre
                Case Solucions.Name
                    fsolu = New Solucions
                    FormMostrar = fsolu
                Case Extras.Name
                    fextra = New Extras
                    FormMostrar = fextra
                Case Informacio.Name
                    finfo = New Informacio
                    FormMostrar = finfo
                Case Factures.Name
                    ffactu = New Factures
                    FormMostrar = ffactu
            End Select

            FormMostrar.MdiParent = Me
            PanelContenedor.Controls.Add(FormMostrar)
        End If

        formActual = FormMostrar

        ActivaBotonMenu(formActual)

        If Not FormsList.Contains(formActual) Then
            FormsList.Add(formActual)
            Debug.WriteLine("Añadido al listado: " & formActual.Name)
            For Each f As Form In FormsList
                Debug.WriteLine(f.Name)
            Next
        End If

        For Each f As Form In FormsList
            If f.Name = formActual.Name Then
                f.Dock = DockStyle.Fill
                f.Show()
            Else
                f.Hide()
            End If
        Next

        If FormsList.Count > 1 Then
            TancarForm.Visible = True
        Else
            TancarForm.Visible = False
        End If

    End Sub


    ' Botons menu dret
    Private Sub Btn_informacio_Click(sender As Object, e As EventArgs) Handles Btn_informacio.Click, Btn_Informació_obert.Click
        MostraForm(finfo)
    End Sub
    Private Sub Btn_factures_Click(sender As Object, e As EventArgs) Handles Btn_factures.Click, Btn_factures_obert.Click
        MostraForm(ffactu)
    End Sub
    Private Sub Btn_gestio_Click(sender As Object, e As EventArgs) Handles Btn_gestio.Click, Btn_Gestio_obert.Click
        MostraForm(fcontr)
    End Sub
    Private Sub Btn_config_Click(sender As Object, e As EventArgs) Handles Btn_config.Click
        Dim Preferencies As New Preferencies
        OpenSubForm(Preferencies)
    End Sub
    Private Sub Btn_informes_Click(sender As Object, e As EventArgs) Handles Btn_informes.Click, Btn_Informes_obert.Click
        MostraForm(fextra)
    End Sub
    Private Sub Btn_llistat_Click(sender As Object, e As EventArgs) Handles Btn_llistat.Click, Btn_llistat_obert.Click
        MostraForm(fsolu)
    End Sub
    Private Sub Btn_Empreses_Click(sender As Object, e As EventArgs) Handles Btn_Empreses.Click, Btn_Empreses_obert.Click
        MostraForm(fempre)
    End Sub

    Private Sub ActivaBotonMenu(FA As Form)

        Btn_Empreses.BackColor = telematic_oscur
        Btn_factures.BackColor = telematic_oscur
        Btn_gestio.BackColor = telematic_oscur
        Btn_informacio.BackColor = telematic_oscur
        Btn_informes.BackColor = telematic_oscur
        Btn_llistat.BackColor = telematic_oscur

        Btn_Empreses_obert.BackColor = telematic_oscur
        Btn_factures_obert.BackColor = telematic_oscur
        Btn_Gestio_obert.BackColor = telematic_oscur
        Btn_Informació_obert.BackColor = telematic_oscur
        Btn_Informes_obert.BackColor = telematic_oscur
        Btn_llistat_obert.BackColor = telematic_oscur

        Btn_Empreses_obert.FlatStyle = FlatStyle.Popup
        Btn_factures_obert.FlatStyle = FlatStyle.Popup
        Btn_Gestio_obert.FlatStyle = FlatStyle.Popup
        Btn_Informació_obert.FlatStyle = FlatStyle.Popup
        Btn_Informes_obert.FlatStyle = FlatStyle.Popup
        Btn_llistat_obert.FlatStyle = FlatStyle.Popup

        Select Case (FA.Name)
            Case Empreses.Name
                Btn_Empreses.BackColor = telematic
                Btn_Empreses_obert.BackColor = telematic
                Btn_Empreses_obert.FlatStyle = FlatStyle.Popup
                MostraPestanya(Panel_empreses_obert)
            Case Factures.Name
                Btn_factures.BackColor = telematic
                Btn_factures_obert.BackColor = telematic
                Btn_factures_obert.FlatStyle = FlatStyle.Popup
                MostraPestanya(Panel_Factures_obert)
            Case Contractes.Name
                Btn_gestio.BackColor = telematic
                Btn_Gestio_obert.BackColor = telematic
                Btn_Gestio_obert.FlatStyle = FlatStyle.Popup
                MostraPestanya(Panel_Gestio_obert)
            Case Informacio.Name
                Btn_informacio.BackColor = telematic
                Btn_Informació_obert.BackColor = telematic
                Btn_Informació_obert.FlatStyle = FlatStyle.Popup
                MostraPestanya(Panel_Informació_obert)
            Case Extras.Name
                Btn_informes.BackColor = telematic
                Btn_Informes_obert.BackColor = telematic
                Btn_Informes_obert.FlatStyle = FlatStyle.Popup
                MostraPestanya(Panel_Informes_obert)
            Case Solucions.Name
                Btn_llistat.BackColor = telematic
                Btn_llistat_obert.BackColor = telematic
                Btn_llistat_obert.FlatStyle = FlatStyle.Popup
                MostraPestanya(Panel_solucions_obert)
        End Select
    End Sub

    Private Sub MostraPestanya(ByVal Panelrebut As Panel)
        Panelrebut.Visible = True
    End Sub
    Private Sub OcultaPestanya(ByVal Panelrebut As Panel)
        Panelrebut.Visible = False
    End Sub
    Private Sub TancarForm_Click(sender As Object, e As EventArgs) Handles TancarForm.Click
        FormsList.Remove(formActual)
        Debug.WriteLine("Eliminado del listado: " & formActual.Name)
        If FormsList.Count = 1 Then TancarForm.Visible = False
        formActual.Close()

        ActivaBotonMenu(FormsList.Last)

        Select Case (formActual.Name)
            Case "Contractes"
                OcultaPestanya(Panel_Gestio_obert)
            Case "Factures"
                OcultaPestanya(Panel_Factures_obert)
            Case "Informacio"
                OcultaPestanya(Panel_Informació_obert)
            Case "Extras"
                OcultaPestanya(Panel_Informes_obert)
            Case "Solucions"
                OcultaPestanya(Panel_solucions_obert)
            Case "Empreses"
                OcultaPestanya(Panel_empreses_obert)
        End Select

        MostraForm(FormsList.Last)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim catData As CultureInfo = New CultureInfo("ca-Es")
        Lbl_Data.Text = DateTime.Now.ToLongDateString
        Lbl_Hora.Text = DateTime.Now.ToLongTimeString
    End Sub

End Class
