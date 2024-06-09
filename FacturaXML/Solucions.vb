Imports System.Data.SQLite

Public Class Solucions

    Dim DT_Llistat As New DataTable
    Dim SolucioFiltre, SolucioFiltreEstat As Integer
    Dim SitioWeb, ComercioElectronico, RedesSociales, Procesos, Clientes, Business, Factura, Oficina, Comunicaciones, Ciberseguridad As Integer
    Dim Preparant, Enviada, Esborrany, Presentada, EsmenaObert, ValidadaPagament, Pagada, FinalitzatEsmena, EsmenaIncorrecta As Integer
    Dim tipusJustificacio As Integer


    Public Sub New()
        MyBase.New
        Me.DoubleBuffered = True
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        SolucioFiltre = 0
        SolucioFiltreEstat = -1
        tipusJustificacio = 1
        CB_JaPresentades.Checked = My.Settings.MostrarLlistatAprovades
        CarregaLlistat()

    End Sub
    'Obre el formulari de contractes amb l'empresa i la solució ja seleccionades
    Private Sub DataLlistat_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataLlistat.CellDoubleClick
        Debug.WriteLine("Enviant a Contractes")
        idEmpresaSeleccionadaUtils = DataLlistat.CurrentRow.Cells("IdEmpresa").Value
        idSolucioSeleccionadaUtils = DataLlistat.CurrentRow.Cells("IdSolucio").Value
        Inici.MostraForm(fcontr)
    End Sub

    Private Sub contracte_TextChanged(sender As Object, e As EventArgs) Handles contracte.TextChanged
        CarregaLlistat()
    End Sub

    Private Sub animacioText(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If AdvertenciaCaducats.Visible = True Then
            AdvertenciaCaducats.Visible = False
        Else
            AdvertenciaCaducats.Visible = True
        End If
    End Sub

    Private Sub Btn_actualitzar_Click(sender As Object, e As EventArgs) Handles Btn_actualitzar.Click
        CarregaLlistat()
    End Sub

    Private Sub Solucions_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        CarregaLlistat()
    End Sub

    Private Sub NomEmpresa_TextChanged(sender As Object, e As EventArgs) Handles nomEmpresa.TextChanged
        CarregaLlistat()
    End Sub

    Private Sub Llistat_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        DataLlistat.AutoResizeColumns()
        DataLlistat.AutoResizeRows()
    End Sub

    Private Sub DataLlistat_DataSourceChanged(sender As Object, e As EventArgs) Handles DataLlistat.DataSourceChanged
        Dim dgv As DataGridView = sender
        Dim imgVerificat As New DataGridViewImageColumn
        Dim imgWord As New DataGridViewImageColumn
        Dim imgCompPagament As New DataGridViewImageColumn
        Dim imgXML As New DataGridViewImageColumn
        Dim imgFabSolucio As New DataGridViewImageColumn
        Dim imgD1 As New DataGridViewImageColumn
        Dim imgD2 As New DataGridViewImageColumn

        imgVerificat.Name = "Verificat"
        imgWord.Name = "Word"
        imgCompPagament.Name = "Comp. Pagament"
        imgXML.Name = "XML"
        imgFabSolucio.Name = "Fabricant Solució"
        imgD1.Name = "D1"
        imgD2.Name = "D2"

        With DataLlistat
            .ClearSelection()
            .Columns("IdSolucio").Visible = False
            .Columns("IdEmpresa").Visible = False
            .Columns("IdTipusSolucio").Visible = False
            .Columns("IdEstat").Visible = False
            .Columns("Justificat").Visible = False
            .Columns("TWord").Visible = False
            .Columns("TComp. Pagament").Visible = False
            .Columns("TXML").Visible = False
            .Columns("TFabricant Solució").Visible = False
            .Columns("TD1").Visible = False
            .Columns("TD2").Visible = False
            .Columns("Data contracte").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Data factura").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Data pagament").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Data venciment").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Dies").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Justificat").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Observacions").DefaultCellStyle.WrapMode = DataGridViewTriState.True
            .Columns("Estat").DefaultCellStyle.WrapMode = DataGridViewTriState.True

            .Columns.Add(imgVerificat)
            '.Columns.Add(imgWord)
            '.Columns.Add(imgCompPagament)
            '.Columns.Add(imgXML)
            '.Columns.Add(imgFabSolucio)
            '.Columns.Add(imgD1)
            '.Columns.Add(imgD2)
            .Columns("Verificat").DisplayIndex = 0

        End With

        If SolucioFiltre = 0 Then
            SitioWeb = 0
            ComercioElectronico = 0
            RedesSociales = 0
            Clientes = 0
            Business = 0
            Procesos = 0
            Factura = 0
            Oficina = 0
            Comunicaciones = 0
            Ciberseguridad = 0
        End If

        If SolucioFiltreEstat = -1 Then
            Preparant = 0
            Enviada = 0
            Esborrany = 0
            Presentada = 0
            EsmenaObert = 0
            ValidadaPagament = 0
            Pagada = 0
            FinalitzatEsmena = 0
            EsmenaIncorrecta = 0
        End If

        If dgv.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In dgv.Rows

                If SolucioFiltre = 0 Then
                    If IsNumeric(Fila.Cells("IdTipusSolucio").Value) Then
                        If Fila.Cells("IdTipusSolucio").Value = 1 Then
                            SitioWeb += 1
                        End If
                        If Fila.Cells("IdTipusSolucio").Value = 2 Then
                            ComercioElectronico += 1
                        End If
                        If Fila.Cells("IdTipusSolucio").Value = 3 Then
                            RedesSociales += 1
                        End If
                        If Fila.Cells("IdTipusSolucio").Value = 4 Then
                            Clientes += 1
                        End If
                        If Fila.Cells("IdTipusSolucio").Value = 5 Then
                            Business += 1
                        End If
                        If Fila.Cells("IdTipusSolucio").Value = 6 Then
                            Procesos += 1
                        End If
                        If Fila.Cells("IdTipusSolucio").Value = 7 Then
                            Factura += 1
                        End If
                        If Fila.Cells("IdTipusSolucio").Value = 8 Then
                            Oficina += 1
                        End If
                        If Fila.Cells("IdTipusSolucio").Value = 9 Then
                            Comunicaciones += 1
                        End If
                        If Fila.Cells("IdTipusSolucio").Value = 10 Then
                            Ciberseguridad += 1
                        End If
                    End If
                End If

                If SolucioFiltreEstat = -1 Then
                    If IsNumeric(Fila.Cells("IdEstat").Value) Then
                        If Fila.Cells("IdEstat").Value = 0 Then
                            Preparant += 1
                        End If
                        If Fila.Cells("IdEstat").Value = 1 Then
                            Enviada += 1
                        End If
                        If Fila.Cells("IdEstat").Value = 2 Then
                            Esborrany += 1
                        End If
                        If Fila.Cells("IdEstat").Value = 3 Then
                            Presentada += 1
                        End If
                        If Fila.Cells("IdEstat").Value = 4 Then
                            EsmenaObert += 1
                        End If
                        If Fila.Cells("IdEstat").Value = 5 Then
                            ValidadaPagament += 1
                        End If
                        If Fila.Cells("IdEstat").Value = 6 Then
                            Pagada += 1
                        End If
                        If Fila.Cells("IdEstat").Value = 7 Then
                            FinalitzatEsmena += 1
                        End If
                        If Fila.Cells("IdEstat").Value = 8 Then
                            EsmenaIncorrecta += 1
                        End If
                    End If
                End If
            Next
        End If

    End Sub
    Private Sub DataLlistat_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataLlistat.CellFormatting
        Dim dgv As DataGridView = sender
        'If dgv.Columns(e.ColumnIndex).Name = "TWord" Or dgv.Columns(e.ColumnIndex).Name = "TComp. Pagament" Or dgv.Columns(e.ColumnIndex).Name = "TXML" Or dgv.Columns(e.ColumnIndex).Name = "TD1" Or dgv.Columns(e.ColumnIndex).Name = "TD2" Then

        '    If e.Value = 1 Then
        '        dgv.Item(e.ColumnIndex - 21, e.RowIndex).Value = My.Resources.verificado_petit
        '    Else
        '        dgv.Item(e.ColumnIndex - 21, e.RowIndex).Value = My.Resources.sin_verificar_petit
        '    End If
        'End If
        'If dgv.Columns(e.ColumnIndex).Name = "TFabricant Solució" Then
        '    If e.Value <> "" Then
        '        dgv.Item(e.ColumnIndex - 21, e.RowIndex).Value = My.Resources.verificado_petit
        '    Else
        '        dgv.Item(e.ColumnIndex - 21, e.RowIndex).Value = My.Resources.sin_verificar_petit
        '    End If
        'End If

        If dgv.Columns(e.ColumnIndex).Name = "Justificat" Then
            If e.Value = "Si" Then
                dgv.Item(dgv.Columns("Verificat").Index, e.RowIndex).Value = My.Resources.verificado_petit
            Else
                dgv.Item(dgv.Columns("Verificat").Index, e.RowIndex).Value = My.Resources.sin_verificar_petit
            End If
        End If

        If dgv.Columns(e.ColumnIndex).Name = "Dies" Then
            If e.Value < 0 Then e.Value = "Caducat"
        End If

        If dgv.Columns(e.ColumnIndex).Name = "Data factura" Then
            If IsDBNull(e.Value) Then
                e.Value = "Pendent"
                e.CellStyle.BackColor = groc
            End If

        End If
        If dgv.Columns(e.ColumnIndex).Name = "Data contracte" Then
            If IsDBNull(e.Value) Then
                e.Value = "Pendent"
                e.CellStyle.BackColor = groc
            End If
        End If
        If dgv.Columns(e.ColumnIndex).Name = "Data pagament" Then
            If IsDBNull(e.Value) Then
                e.Value = "Pendent"
                e.CellStyle.BackColor = groc
            End If

        End If


        Dim font As New Font("Calibri", 7, FontStyle.Regular)

        With dgv
            .Columns("Empresa").Width = 300
            .Columns("Solucio").Width = 150
            .Columns("Contracte").Width = 100
            .Columns("Verificat").Width = 50
            .Columns("Observacions").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns("Observacions").MinimumWidth = 100
            '.Columns("Word").Width = 50
            .Columns("Data contracte").Width = 70
            .Columns("Data pagament").Width = 70
            .Columns("Data venciment").Width = 70
            .Columns("Data factura").Width = 70
            '.Columns("Word").HeaderCell.Style.Font = font
            '.Columns("Comp. Pagament").Width = 50
            '.Columns("Comp. Pagament").HeaderCell.Style.Font = font
            '.Columns("XML").Width = 50
            '.Columns("XML").HeaderCell.Style.Font = font
            '.Columns("Fabricant Solució").Width = 50
            '.Columns("Fabricant Solució").HeaderCell.Style.Font = font
            '.Columns("D1").Width = 50
            '.Columns("D1").HeaderCell.Style.Font = font
            '.Columns("D2").Width = 50
            '.Columns("D2").HeaderCell.Style.Font = font
        End With

    End Sub
    Private Sub DataLlistat_DataBindingComplete(ByVal sender As Object, ByVal e As DataGridViewBindingCompleteEventArgs) Handles DataLlistat.DataBindingComplete

        Dim dgv As DataGridView = sender

        With sender
            .AutoResizeColumns()
            .AutoResizeRows()
            .ClearSelection()
        End With

        NumeraSolucions()

        For Each Fila As DataGridViewRow In dgv.Rows

            If Fila.Cells("Dies").Value <= 90 And Fila.Cells("Dies").Value >= 1 Then Fila.Cells("Empresa").Style.BackColor = taronja
            If Fila.Cells("Dies").Value <= 0 Then Fila.Cells("Empresa").Style.BackColor = vermell
            If Fila.Cells("Justificat").Value = "Si" Then Fila.Cells("Empresa").Style.BackColor = verd
            If Fila.Cells("Estat").Value = "Presentada" Then Fila.Cells("Empresa").Style.BackColor = blau
            If Fila.Cells("Estat").Value = "Enviada" Then Fila.Cells("Empresa").Style.BackColor = blau
            If Fila.Cells("Estat").Value = "Termini d'esmena obert" Then Fila.Cells("Empresa").Style.BackColor = blau
            If Fila.Cells("Estat").Value = "Finalitzat termini d'esmena" Then Fila.Cells("Empresa").Style.BackColor = blau
        Next

        ' Si hi ha alguna solució apunt de caducar mostrarà un missatge 
        For Each Fila As DataGridViewRow In dgv.Rows
            If Fila.Cells("Dies").Value < My.Settings.DiesAvis And Fila.Cells("Dies").Value > 0 Then
                Timer1.Start()
                Exit For
            Else
                Timer1.Stop()
                AdvertenciaCaducats.Visible = False
            End If
        Next

    End Sub
    'Carrega el llistat de solucions de la base de dades

    Public Sub CarregaLlistat()

        Try
            Dim SqlFiltre As String = ""
            Dim SqlFiltreStats As String = ""
            Dim SqlJustificats As String = ""

            If SolucioFiltre <> 0 Then
                SqlFiltre = "AND (Solucions.idSolucio=" & SolucioFiltre & ")"
            End If

            If SolucioFiltreEstat <> -1 Then
                SqlFiltreStats = "AND (Justificacions.estat=" & SolucioFiltreEstat & ")"
            End If

            If CB_JaPresentades.Checked = False Then
                SqlJustificats = "AND (Solucions.Justificat='No')"
            End If

            Dim Sql As String = "
            SELECT Empreses.Nom AS Empresa,
                   Empreses.Id AS IdEmpresa,  
                   TipusSolucions.Id AS IdTipusSolucio,    
                   TipusSolucions.Nom AS Solucio,
                   Solucions.Id AS IdSolucio,
                   Solucions.Contracte,                
                   strftime('%d-%m-%Y',Solucions.DataContracte) AS 'Data contracte',
                   strftime('%d-%m-%Y',Solucions.DataFactura) AS 'Data factura',
                   strftime('%d-%m-%Y',Solucions.DataPagament) AS 'Data pagament',  
                   strftime('%d-%m-%Y',Solucions.DataVenciment) AS 'Data venciment',
                   julianday(Solucions.DataVenciment) - julianday(date())  AS Dies,
                   TipusEstats.NomEstat AS 'Estat',
                   TipusEstats.Id as 'IdEstat', 
                   Solucions.Justificat,
                   Solucions.Observacions,
                   TeWord AS 'TWord',
                   TeComprovantPagament AS 'TComp. Pagament',
                   TeFacturaXML AS 'TXML',
                   FabricantSolucio AS 'TFabricant Solució',
                   Dada1 AS 'TD1',
                   Dada2 AS 'TD2'
            FROM Solucions
            INNER JOIN Empreses ON Solucions.idEmpresa=Empreses.Id
            INNER JOIN TipusSolucions ON Solucions.idSolucio=TipusSolucions.Id
            INNER JOIN Justificacions ON Solucions.id=Justificacions.idSolucio
            INNER JOIN TipusEstats ON Justificacions.Estat=TipusEstats.id
            WHERE (Solucions.Contracte like '%' || @contracte || '%')" & SqlJustificats & " AND (Empreses.Nom like '%'|| @nomEmpresa ||'%')" & SqlFiltre & SqlFiltreStats & "AND tipus=" & tipusJustificacio & " ORDER BY Solucions.DataVenciment ASC"

            Debug.WriteLine(Sql)

            Using conexion As New SQLiteConnection(cadena),
              comm As New SQLiteCommand(Sql, conexion),
              DA As New SQLiteDataAdapter(comm)

                comm.Parameters.AddWithValue("@contracte", contracte.Text)
                comm.Parameters.AddWithValue("@nomEmpresa", nomEmpresa.Text)

                DT_Llistat.Clear()
                DA.Fill(DT_Llistat)
                DataLlistat.DataSource = DT_Llistat
            End Using
        Catch ex As Exception
            MsgBox("No s'han pogut carregar les solucions des de la base de dades - " + ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub NumeraSolucions()
        If SolucioFiltre = 0 Then TB_totes.Text = DataLlistat.RowCount.ToString
        TB_SitioWeb.Text = SitioWeb.ToString
        TB_ComercioElectronico.Text = ComercioElectronico.ToString
        TB_RedesSociales.Text = RedesSociales.ToString
        TB_GestionClientes.Text = Clientes.ToString
        TB_BusinessInteligence.Text = Business.ToString
        TB_GestionProcesos.Text = Procesos.ToString
        TB_FacturaElectronica.Text = Factura.ToString
        TB_OficinaVirtual.Text = Oficina.ToString
        TB_ComunicacionesSeguras.Text = Comunicaciones.ToString
        TB_Ciberseguridad.Text = Ciberseguridad.ToString

        If SolucioFiltreEstat = -1 Then TB_TotsEstats.Text = DataLlistat.RowCount.ToString
        TB_PreparantDocumentacio.Text = Preparant.ToString
        TB_Enviada.Text = Enviada.ToString
        TB_Esborrany.Text = Esborrany.ToString
        TB_Presentada.Text = Presentada.ToString
        TB_EsmenaObert.Text = EsmenaObert.ToString
        TB_ValidadaPagament.Text = ValidadaPagament.ToString
        TB_Pagada.Text = Pagada.ToString
        TB_FinalitzadaEsmena.Text = FinalitzatEsmena.ToString
        TB_EsmenaIncorrecta.Text = EsmenaIncorrecta.ToString
    End Sub
    Private Sub CB_JaPresentades_CheckedChanged(sender As Object, e As EventArgs) Handles CB_JaPresentades.CheckedChanged
        CarregaLlistat()
    End Sub

    Private Sub TipusSolucions_CheckedChanged(sender As Object, e As EventArgs) Handles RB_SitioWeb.CheckedChanged,
        RB_ComercioElectronico.CheckedChanged, RB_RedesSociales.CheckedChanged, RB_GestionClientes.CheckedChanged,
        RB_BusinessInteligence.CheckedChanged, RB_GestionProcesos.CheckedChanged, RB_FacturaElectronica.CheckedChanged,
        RB_OficinaVirtual.CheckedChanged, RB_ComunicacionesSeguras.CheckedChanged, RB_Ciberseguridad.CheckedChanged, RB_Totes.CheckedChanged

        If RB_SitioWeb.Checked Then
            SolucioFiltre = 1
        ElseIf RB_ComercioElectronico.Checked Then
            SolucioFiltre = 2
        ElseIf RB_RedesSociales.Checked Then
            SolucioFiltre = 3
        ElseIf RB_GestionClientes.Checked Then
            SolucioFiltre = 4
        ElseIf RB_BusinessInteligence.Checked Then
            SolucioFiltre = 5
        ElseIf RB_GestionProcesos.Checked Then
            SolucioFiltre = 6
        ElseIf RB_FacturaElectronica.Checked Then
            SolucioFiltre = 7
        ElseIf RB_OficinaVirtual.Checked Then
            SolucioFiltre = 8
        ElseIf RB_ComunicacionesSeguras.Checked Then
            SolucioFiltre = 9
        ElseIf RB_Ciberseguridad.Checked Then
            SolucioFiltre = 10
        ElseIf RB_Totes.Checked Then
            SolucioFiltre = 0
        End If
        CarregaLlistat()
    End Sub

    Private Sub TipusEstats_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Enviada.CheckedChanged, RB_PreparantDocumentacio.CheckedChanged,
            RB_Esborrany.CheckedChanged, RB_Presentada.CheckedChanged, RB_EsmenaObert.CheckedChanged, RB_ValidadaPagament.CheckedChanged,
            RB_Pagada.CheckedChanged, RB_FinalitzadaEsmena.CheckedChanged, RB_EsmenaIncorrecta.CheckedChanged, RB_TotsEstats.CheckedChanged

        If RB_Enviada.Checked Then
            SolucioFiltreEstat = 1
        ElseIf RB_PreparantDocumentacio.Checked Then
            SolucioFiltreEstat = 0
        ElseIf RB_Esborrany.Checked Then
            SolucioFiltreEstat = 2
        ElseIf RB_Presentada.Checked Then
            SolucioFiltreEstat = 3
        ElseIf RB_EsmenaObert.Checked Then
            SolucioFiltreEstat = 4
        ElseIf RB_ValidadaPagament.Checked Then
            SolucioFiltreEstat = 5
        ElseIf RB_Pagada.Checked Then
            SolucioFiltreEstat = 6
        ElseIf RB_FinalitzadaEsmena.Checked Then
            SolucioFiltreEstat = 7
        ElseIf RB_EsmenaIncorrecta.Checked Then
            SolucioFiltreEstat = 8
        ElseIf RB_TotsEstats.Checked Then
            SolucioFiltreEstat = -1
        End If
        CarregaLlistat()

    End Sub

    Private Sub tipusJustificacio_CheckedChanged(sender As Object, e As EventArgs) Handles RB_primera.CheckedChanged, RB_segona.CheckedChanged
        If DataLlistat IsNot Nothing AndAlso DataLlistat.DataSource IsNot Nothing Then
            If RB_primera.Checked Then
                tipusJustificacio = 1
                CarregaLlistat()
            End If
            If RB_segona.Checked Then
                tipusJustificacio = 2
                CarregaLlistat()
            End If
        End If
    End Sub
End Class