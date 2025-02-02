Imports System.Data.SQLite
Imports System.IO
Imports System.Reflection
Imports ClosedXML.Excel

Public Class Solucions


    Dim DT_Llistat As New DataTable
    Dim SolucioFiltre, SolucioFiltreEstat As Integer
    Dim SitioWeb, ComercioElectronico, RedesSociales, Procesos, Clientes, Business, Factura, Oficina, Comunicaciones, Ciberseguridad, Puestoseguro As Integer
    Dim Preparant, Enviada, Esborrany, Presentada, EsmenaObert, ValidadaPagament, Pagada, FinalitzatEsmena, EsmenaIncorrecta, NoPagada, PagamentMinorat, DocumentacioAddicional As Integer
    Dim tipusJustificacio As Integer
    Dim cambios As New List(Of AcuerdosCambiados)()

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
        Dim dgvType As Type = GetType(DataGridView)
        Dim dgvPropInfo As PropertyInfo = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
        dgvPropInfo.SetValue(DataLlistat, True, Nothing)
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
            .Columns("TipusAcord").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Contracte").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Observacions").DefaultCellStyle.WrapMode = DataGridViewTriState.True
            .Columns("Estat").DefaultCellStyle.WrapMode = DataGridViewTriState.True
            .Columns("Solucio").DefaultCellStyle.WrapMode = DataGridViewTriState.True
            .RowTemplate.MinimumHeight = 30

            .Columns.Add(imgVerificat)
            '.Columns.Add(imgWord)
            '.Columns.Add(imgCompPagament)
            '.Columns.Add(imgXML)
            '.Columns.Add(imgFabSolucio)
            '.Columns.Add(imgD1)
            '.Columns.Add(imgD2)
            .Columns("Verificat").DisplayIndex = 0
            .Columns("Verificat").Name = "Verificat"


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
            Puestoseguro = 0
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
            NoPagada = 0
            PagamentMinorat = 0
            DocumentacioAddicional = 0
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
                        If Fila.Cells("IdTipusSolucio").Value = 11 Then
                            Puestoseguro += 1
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
                        If Fila.Cells("IdEstat").Value = 9 Then
                            NoPagada += 1
                        End If
                        If Fila.Cells("IdEstat").Value = 10 Then
                            PagamentMinorat += 1
                        End If
                        If Fila.Cells("IdEstat").Value = 11 Then
                            DocumentacioAddicional += 1
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
        If dgv.Columns(e.ColumnIndex).Name = "Data venciment" Then
            If IsDBNull(e.Value) Then
                e.Value = "Pendent"
                e.CellStyle.BackColor = groc
            End If
        End If


        'Dim font As New Font("Calibri", 7, FontStyle.Regular)



    End Sub
    Private Sub DataLlistat_DataBindingComplete(ByVal sender As Object, ByVal e As DataGridViewBindingCompleteEventArgs) Handles DataLlistat.DataBindingComplete

        Dim dgv As DataGridView = sender

        With sender
            .AutoResizeColumns()

            .ClearSelection()
        End With
        With dgv
            .Columns("Empresa").Width = 300
            .Columns("TipusAcord").Width = 30
            .Columns("Contracte").Width = 100
            .Columns("Observacions").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns("Observacions").MinimumWidth = 100
            .Columns("Data contracte").Width = 70
            .Columns("Data pagament").Width = 70
            .Columns("Data venciment").Width = 70
            .Columns("Data factura").Width = 70
            .Columns("Solucio").Width = 200
            .Columns("TipusAcord").HeaderText = "TA"
            .AutoResizeRows()
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
            If Fila.Cells("Estat").Value = "Documentació addicional" Then Fila.Cells("Empresa").Style.BackColor = blau
            If Fila.Cells("Estat").Value = "No pagada" Then Fila.Cells("Empresa").Style.BackColor = blau

            If Fila.Cells("TipusAcord").Value = "KD" Then Fila.Cells("TipusAcord").Style.BackColor = kdcolor
            If Fila.Cells("TipusAcord").Value = "KC" Then Fila.Cells("TipusAcord").Style.BackColor = kccolor

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
            Dim SqlFiltreFactura As String = ""
            

            If tipusJustificacio = 2 Then SqlFiltreFactura = " AND DataFactura <> ''"

            If SolucioFiltre <> 0 Then
                SqlFiltre = "AND (Solucions.idSolucio=" & SolucioFiltre & ")"
            End If

            If SolucioFiltreEstat <> -1 Then
                SqlFiltreStats = "AND (Justificacions.estat=" & SolucioFiltreEstat & ")"
            End If

            If CB_JaPresentades.Checked = False Then
                SqlJustificats = "AND (Solucions.Justificat='No')"
            End If

            If CB_mostrarSenseFactures.Checked = False Then
                SqlFiltreFactura = " AND DataFactura <> ''"
            End If

            Dim Sql As String = "
            SELECT Empreses.Nom AS Empresa,
                   Empreses.Id AS IdEmpresa,
                   SUBSTR(Solucions.Contracte, 1, 2) AS 'TipusAcord',
                   TipusSolucions.Id AS IdTipusSolucio,    
                   TipusSolucions.Nom AS Solucio,
                   Solucions.Id AS IdSolucio,
                   Solucions.Contracte,                
                   strftime('%d-%m-%Y',Solucions.DataContracte) AS 'Data contracte',
                   strftime('%d-%m-%Y',Solucions.DataFactura) AS 'Data factura',
                   strftime('%d-%m-%Y',Solucions.DataPagament) AS 'Data pagament',  
                   strftime('%d-%m-%Y',Solucions.DataVenciment) AS 'Data venciment',
                   IFNULL(julianday(Solucions.DataVenciment) - julianday(date()), 0) AS Dies,                                   
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
            WHERE (Solucions.Contracte like '%' || @contracte || '%')" & SqlJustificats & " AND (Empreses.Nom like '%'|| @nomEmpresa ||'%')" & SqlFiltre & SqlFiltreStats & "AND tipus=" & tipusJustificacio & SqlFiltreFactura & " ORDER BY Solucions.DataVenciment ASC"

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
        TB_BusinessInteligence.Text = Business.ToString
        TB_GestionProcesos.Text = Procesos.ToString
        TB_FacturaElectronica.Text = Factura.ToString
        TB_OficinaVirtual.Text = Oficina.ToString
        TB_ComunicacionesSeguras.Text = Comunicaciones.ToString
        TB_Ciberseguridad.Text = Ciberseguridad.ToString
        TB_Puestoseguro.Text = Puestoseguro.ToString

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
        TB_NoPagada.Text = NoPagada.ToString
        TB_PagamentMinorat.Text = PagamentMinorat.ToString
        TB_DocumentacioAddicional.Text = DocumentacioAddicional.ToString
    End Sub
    Private Sub CB_JaPresentades_CheckedChanged(sender As Object, e As EventArgs) Handles CB_JaPresentades.CheckedChanged
        CarregaLlistat()
    End Sub

    Private Sub TipusSolucions_CheckedChanged(sender As Object, e As EventArgs) Handles RB_SitioWeb.CheckedChanged, RB_ComercioElectronico.CheckedChanged, RB_BusinessInteligence.CheckedChanged, RB_GestionProcesos.CheckedChanged, RB_FacturaElectronica.CheckedChanged, RB_OficinaVirtual.CheckedChanged, RB_ComunicacionesSeguras.CheckedChanged, RB_Ciberseguridad.CheckedChanged, RB_Totes.CheckedChanged, RB_PuestoSeguro.CheckedChanged

        If RB_SitioWeb.Checked Then
            SolucioFiltre = 1
        ElseIf RB_ComercioElectronico.Checked Then
            SolucioFiltre = 2
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
        ElseIf RB_PuestoSeguro.Checked Then
            SolucioFiltre = 11
        End If
        CarregaLlistat()
    End Sub

    Private Sub TipusEstats_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Enviada.CheckedChanged, RB_PreparantDocumentacio.CheckedChanged, RB_Esborrany.CheckedChanged, RB_Presentada.CheckedChanged, RB_EsmenaObert.CheckedChanged, RB_ValidadaPagament.CheckedChanged, RB_Pagada.CheckedChanged, RB_FinalitzadaEsmena.CheckedChanged, RB_EsmenaIncorrecta.CheckedChanged, RB_TotsEstats.CheckedChanged, RB_NoPagada.CheckedChanged, RB_PagamentMinorat.CheckedChanged, RB_DocumentacioAddicional.CheckedChanged

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
        ElseIf RB_NoPagada.Checked Then
            SolucioFiltreEstat = 9
        ElseIf RB_PagamentMinorat.Checked Then
            SolucioFiltreEstat = 10
        ElseIf RB_DocumentacioAddicional.Checked Then
            SolucioFiltreEstat = 11
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

    Private Sub btn_importarExcel_Click(sender As Object, e As EventArgs) Handles btn_importarExcel.Click
        importaAcuerdosExcel()
    End Sub

    Private Sub importaAcuerdosExcel()
        Dim listaAcuerdos As New List(Of acuerdo)
        Dim listaEmpresasNuevas As New List(Of String)

        Dim rutaArchivo As String


        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx"
            openFileDialog.Title = "Seleccione un archivo Excel"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                rutaArchivo = openFileDialog.FileName
            Else
                Exit Sub
            End If
        End Using

        ' Abrir el archivo Excel
        Using workbook As New XLWorkbook(rutaArchivo)
            ' Seleccionar la primera hoja
            Dim worksheet = workbook.Worksheet(1)

            ' Recorrer las filas (empezando desde la fila 2 para omitir los encabezados)
            For Each row As IXLRow In worksheet.RowsUsed().Skip(1)
                ' Crear una nueva instancia de Persona
                Dim acuerdo As New acuerdo()

                ' Asignar los valores de las celdas a las propiedades de la instancia de Persona
                acuerdo.Codigo = row.Cell(1).GetValue(Of String)()
                acuerdo.Acuerdo = row.Cell(2).GetValue(Of String)()
                acuerdo.Bono = row.Cell(3).GetValue(Of String)()
                acuerdo.Estado = row.Cell(4).GetValue(Of String)()
                acuerdo.NifIniciador = row.Cell(5).GetValue(Of String)()
                acuerdo.NifDigitalizador = row.Cell(6).GetValue(Of String)()
                acuerdo.Digitalizador = row.Cell(7).GetValue(Of String)()
                acuerdo.NifBeneficiario = row.Cell(8).GetValue(Of String)()
                acuerdo.Beneficiario = row.Cell(9).GetValue(Of String)()
                acuerdo.Categoria = row.Cell(10).GetValue(Of String)()
                acuerdo.Fecha = row.Cell(11).GetValue(Of String)()

                ' Agregar la instancia a la lista
                listaAcuerdos.Add(acuerdo)

                If Not ExisteNIF(acuerdo.NifBeneficiario) Then
                    listaEmpresasNuevas.Add(acuerdo.NifBeneficiario)
                End If

            Next
        End Using


        ' Aquí puedes usar la listaPersonas según necesites
        ' Por ejemplo, mostrar el contenido en la consola
        PB_importarExcel.Minimum = 0
        PB_importarExcel.Maximum = listaAcuerdos.Count

        Dim i As Integer = 0
        PB_importarExcel.Visible = True
        cambios.Clear()
        For Each acuerdo In listaAcuerdos

            actualizaAcuerdo(acuerdo)
            Debug.WriteLine($"Contracte: {acuerdo.Acuerdo}, Tipo: {acuerdo.Codigo}, Beneficiario: {acuerdo.Beneficiario}, Nuevo estado: {acuerdo.Estado}")

            PB_importarExcel.Value = i
            i = i + 1
        Next
        PB_importarExcel.Visible = False

        ' Mostrar los cambios realizados
        If listaEmpresasNuevas.Count > 0 Then
            MessageBox.Show("Hi ha empreses noves o donades de baixa, potser no estan pasades per IDR i s'han d'introduir manualment , aquestes no s'actualitzaran", "Noves empreses", MessageBoxButtons.OK)
        End If

        If cambios.Count > 0 Then
            Debug.WriteLine("Ha habido cambios")
            For Each cambio In cambios
                Debug.WriteLine($"Contracte: {cambio.Contracte}, Tipus {cambio.Tipus} Nuevo estado: {cambio.Estat}")
            Next
            Dim cambiosAcuerdos As cambiosAcuerdos = New cambiosAcuerdos(cambios)
            cambiosAcuerdos.Show()

        Else
            MessageBox.Show("No hi ha canvis als acords", "Actualitzacions", MessageBoxButtons.OK)
            Debug.WriteLine("No ha habido cambios")


        End If



    End Sub

    Private Sub actualizaAcuerdo(acuerdo As acuerdo)
        Dim tipus, estat As Integer
        Dim conexion As New SQLiteConnection(cadena)
        Dim Query As String

        'Dim strCommand As SQLiteCommand

        If acuerdo.Codigo.Substring(14) = "001" Then
            tipus = 1
        Else
            tipus = 2
        End If

        Select Case (acuerdo.Estado)
            Case "Borrador"
                estat = 2
            Case "Presentada"
                estat = 3
            Case "Pdte. presentar"
                estat = 3
            Case "Pdte. conformidad PYME"
                estat = 3
            Case "Enviada para pago"
                estat = 5
            Case "Plazo de subsanación abierto"
                estat = 4
            Case "Pagada"
                estat = 6
            Case "Finalizado plazo subsanación"
                estat = 7
            Case "No Pagada"
                estat = 9
            Case "Proceso de Documentación Adicional"
                estat = 11
            Case "Pagada con minoración"
                estat = 10
            Case "Subsanada incorrecta"
                estat = 8
        End Select


        Try
            conexion.Open()

            If conexion.State = ConnectionState.Open Then

                ' Seleccionar los idSolucio de Solucions que cumplen las condiciones
                Dim selectQuery As String = "SELECT Solucions.id
                                     FROM Solucions
                                     WHERE Solucions.Contracte = @contracte AND Solucions.Tipus = @tipus"

                Dim idSolucions As New List(Of Integer)()

                Using selectCommand As New SQLiteCommand(selectQuery, conexion)
                    selectCommand.Parameters.AddWithValue("@contracte", acuerdo.Acuerdo.Substring(0, 13))
                    selectCommand.Parameters.AddWithValue("@tipus", tipus)
                    Using reader As SQLiteDataReader = selectCommand.ExecuteReader()
                        While reader.Read()
                            idSolucions.Add(reader.GetInt32(0))
                        End While
                    End Using
                End Using

                ' Verificar y actualizar solo los registros que necesiten cambiar
                For Each idSolucio As Integer In idSolucions
                    Dim currentEstat As Integer

                    ' Obtener el valor actual de Estat
                    Dim getCurrentEstatQuery As String = "SELECT Estat FROM Justificacions WHERE idSolucio = @idSolucio"
                    Using getCurrentEstatCommand As New SQLiteCommand(getCurrentEstatQuery, conexion)
                        getCurrentEstatCommand.Parameters.AddWithValue("@idSolucio", idSolucio)
                        currentEstat = Convert.ToInt32(getCurrentEstatCommand.ExecuteScalar())
                    End Using

                    ' Solo actualizar si el valor actual es diferente del nuevo valor
                    If currentEstat <> estat Then
                        Query = "UPDATE Justificacions
                         SET Estat = @estat
                         WHERE idSolucio = @idSolucio"

                        Using strCommand As New SQLiteCommand(Query, conexion)
                            strCommand.Parameters.AddWithValue("@estat", estat)
                            strCommand.Parameters.AddWithValue("@idSolucio", idSolucio)
                            strCommand.ExecuteNonQuery()
                        End Using

                        ' Añadir el cambio a la lista de cambios
                        cambios.Add(New AcuerdosCambiados With {
                            .Tipus = tipus,
                            .Empresa = acuerdo.Beneficiario,
                            .Contracte = acuerdo.Acuerdo.Substring(0, 13),
                            .AnticEstat = currentEstat,
                            .Estat = estat,
                            .Solucio = Trim(acuerdo.Categoria)
                        })
                    End If
                Next

                ' Cambiar el estado de Justificat en Solucions solo si es necesario
                Dim currentJustificat As String
                Dim getJustificatQuery As String = "SELECT Justificat FROM Solucions WHERE Contracte = @contracte AND Tipus = @tipus"
                Using getJustificatCommand As New SQLiteCommand(getJustificatQuery, conexion)
                    getJustificatCommand.Parameters.AddWithValue("@contracte", acuerdo.Acuerdo.Substring(0, 13))
                    getJustificatCommand.Parameters.AddWithValue("@tipus", tipus)
                    currentJustificat = Convert.ToString(getJustificatCommand.ExecuteScalar())
                End Using

                Dim newJustificat As String = If(estat = 5 Or estat = 6 Or estat = 10, "Si", "No")
                If currentJustificat <> newJustificat Then
                    Query = "UPDATE Solucions SET Justificat = @justificat
                     WHERE Contracte = @contracte AND Tipus = @tipus;"

                    Using strCommand As New SQLiteCommand(Query, conexion)
                        strCommand.Parameters.AddWithValue("@justificat", newJustificat)
                        strCommand.Parameters.AddWithValue("@contracte", acuerdo.Acuerdo.Substring(0, 13))
                        strCommand.Parameters.AddWithValue("@tipus", tipus)
                        strCommand.ExecuteNonQuery()
                    End Using
                End If

                ' Cambiar el estado de PagamentFet en Solucions solo si es necesario
                Dim currentPagamentFet As Integer
                Dim getPagamentFetQuery As String = "SELECT PagamentFet FROM Solucions WHERE Contracte = @contracte AND Tipus = @tipus"
                Using getpagamentFetCommand As New SQLiteCommand(getPagamentFetQuery, conexion)
                    getpagamentFetCommand.Parameters.AddWithValue("@contracte", acuerdo.Acuerdo.Substring(0, 13))
                    getpagamentFetCommand.Parameters.AddWithValue("@tipus", tipus)
                    currentPagamentFet = Convert.ToInt32(getpagamentFetCommand.ExecuteScalar())
                End Using

                Dim newPagamentFet As Integer = If(estat = 6 Or estat = 10, 1, 0)
                If currentPagamentFet <> newPagamentFet Then
                    Query = "UPDATE Solucions SET PagamentFet = @PagamentFet
                     WHERE Contracte = @contracte AND Tipus = @tipus;"

                    Using strCommand As New SQLiteCommand(Query, conexion)
                        strCommand.Parameters.AddWithValue("@PagamentFet", newPagamentFet)
                        strCommand.Parameters.AddWithValue("@contracte", acuerdo.Acuerdo.Substring(0, 13))
                        strCommand.Parameters.AddWithValue("@tipus", tipus)
                        strCommand.ExecuteNonQuery()
                    End Using
                End If
            End If
        Catch ex As Exception
            ' Manejo del error
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try



    End Sub
    Public Function ExisteNIF(nif As String) As Boolean
        Dim conexion As New SQLiteConnection(cadena)

        Dim query As String = "SELECT COUNT(*) FROM Empreses WHERE trim(NIF) = @nif;"
        Using cmd As New SQLiteCommand(query, conexio)
            cmd.Parameters.AddWithValue("@nif", nif)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return count > 0
        End Using
    End Function

    Private Sub CB_mostrarSenseFactures_CheckedChanged(sender As Object, e As EventArgs) Handles CB_mostrarSenseFactures.CheckedChanged
        CarregaLlistat()
    End Sub
End Class