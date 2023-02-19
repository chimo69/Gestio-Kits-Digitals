Imports System.Data.SQLite

Public Class Llistat

    Dim DT_Llistat As New DataTable
    Dim SolucioFiltre As Integer
    Dim SitioWeb, ComercioElectronico, RedesSociales, Procesos, Clientes, Business, Factura, Oficina, Comunicaciones, Ciberseguridad As Integer
    Public Sub New()
        MyBase.New
        MyBase.DoubleBuffered = True
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        SolucioFiltre = 0
        CB_JaPresentades.Checked = My.Settings.MostrarLlistatAprovades
        CarregaLlistat()

    End Sub
    'Obre el formulari de contractes amb l'empresa i la solució ja seleccionades
    Private Sub DataLlistat_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataLlistat.CellDoubleClick
        Dim dgv As DataGridView = sender
        Dim idEmpresa As Integer = dgv.CurrentRow.Cells("IdEmpresa").Value
        Dim idSolucio As Integer = dgv.CurrentRow.Cells("IdSolucio").Value
        Dim Contractes As New Contractes(idEmpresa, idSolucio)
        OpenSubFormDialog(Contractes)
        CarregaLlistat()
        For Each Fila As DataGridViewRow In DataLlistat.Rows
            If Fila.Cells("IdSolucio").Value = idSolucio Then
                Fila.Selected = True
                Exit For
            End If
        Next
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
            .Columns.Add(imgWord)
            .Columns.Add(imgCompPagament)
            .Columns.Add(imgXML)
            .Columns.Add(imgFabSolucio)
            .Columns.Add(imgD1)
            .Columns.Add(imgD2)
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
            Next
        End If

    End Sub
    Private Sub DataLlistat_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataLlistat.CellFormatting
        Dim dgv As DataGridView = sender

        If dgv.Columns(e.ColumnIndex).Name = "TWord" Or dgv.Columns(e.ColumnIndex).Name = "TComp. Pagament" Or dgv.Columns(e.ColumnIndex).Name = "TXML" Or dgv.Columns(e.ColumnIndex).Name = "TD1" Or dgv.Columns(e.ColumnIndex).Name = "TD2" Then

            If e.Value = 1 Then
                dgv.Item(e.ColumnIndex - 20, e.RowIndex).Value = My.Resources.verificado_petit
            Else
                dgv.Item(e.ColumnIndex - 20, e.RowIndex).Value = My.Resources.sin_verificar_petit
            End If
        End If
        If dgv.Columns(e.ColumnIndex).Name = "TFabricant Solució" Then
            If e.Value <> "" Then
                dgv.Item(e.ColumnIndex - 20, e.RowIndex).Value = My.Resources.verificado_petit
            Else
                dgv.Item(e.ColumnIndex - 20, e.RowIndex).Value = My.Resources.sin_verificar_petit
            End If
        End If

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
            .Columns("Data contracte").Width = 80
            .Columns("Data factura").Width = 80
            .Columns("Data pagament").Width = 80
            .Columns("Data venciment").Width = 80
            .Columns("Verificat").Width = 50
            .Columns("Word").Width = 50
            .Columns("Word").HeaderCell.Style.Font = font
            .Columns("Comp. Pagament").Width = 50
            .Columns("Comp. Pagament").HeaderCell.Style.Font = font
            .Columns("XML").Width = 50
            .Columns("XML").HeaderCell.Style.Font = font
            .Columns("Fabricant Solució").Width = 50
            .Columns("Fabricant Solució").HeaderCell.Style.Font = font
            .Columns("D1").Width = 50
            .Columns("D1").HeaderCell.Style.Font = font
            .Columns("D2").Width = 50
            .Columns("D2").HeaderCell.Style.Font = font
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
            Dim conexion As New SQLiteConnection()
            Dim Sql As String
            Dim SqlFiltre As String
            Dim SqlJustificats As String

            conexion = New SQLiteConnection(cadena)
            conexion.Open()

            If conexion.State = ConnectionState.Open Then
                Dim DA As New SQLiteDataAdapter
                Dim comm As SQLiteCommand
                DT_Llistat.Clear()

                If SolucioFiltre <> 0 Then
                    SqlFiltre = "And (Solucions.idSolucio=" & SolucioFiltre & ")"
                Else
                    SqlFiltre = ""
                End If
                If CB_JaPresentades.Checked = False Then
                    SqlJustificats = "AND (Solucions.Justificat='No')"
                Else
                    SqlJustificats = ""
                End If

                Sql = "SELECT Empreses.Nom As Empresa,
                          Empreses.Id As IdEmpresa,  
                          TipusSolucions.Id As IdTipusSolucio,    
                          TipusSolucions.Nom As Solucio,
                          Solucions.Id As IdSolucio,
                          Solucions.Contracte,                          
                          strftime('%d-%m-%Y',Solucions.DataContracte) AS 'Data contracte',
                          strftime('%d-%m-%Y',Solucions.DataFactura) AS 'Data factura',
                          strftime('%d-%m-%Y',Solucions.DataPagament) AS 'Data pagament',  
                          strftime('%d-%m-%Y',Solucions.DataVenciment) AS 'Data venciment',
                          julianday(Solucions.DataVenciment) - julianday(date())  AS Dies,
                          TipusEstats.NomEstat AS 'Estat',                         
                          Solucions.Justificat,
                          Solucions.Observacions,
                          TeWord As 'TWord',
                          TeComprovantPagament As 'TComp. Pagament',
                          TeFacturaXML AS 'TXML',
                          FabricantSolucio As 'TFabricant Solució',
                          Dada1 as 'TD1',
                          Dada2 as 'TD2'
                          FROM Solucions
                          INNER JOIN Empreses ON Solucions.idEmpresa=Empreses.Id
                          INNER JOIN TipusSolucions ON Solucions.idSolucio=TipusSolucions.Id
                          INNER JOIN Justificacions ON Solucions.id=Justificacions.idSolucio
                          INNER JOIN TipusEstats ON Justificacions.Estat=TipusEstats.id
                          WHERE (Solucions.Contracte like '%" & contracte.Text & "%')" & SqlJustificats & " AND (Empreses.Nom like '%" & nomEmpresa.Text & "%')" & SqlFiltre & "  
                          ORDER BY Solucions.DataVenciment ASC"

                comm = New SQLiteCommand(Sql, conexion)

                DA.SelectCommand = comm
                DT_Llistat.Clear()
                DA.Fill(DT_Llistat)
                DataLlistat.DataSource = DT_Llistat

            End If
            conexion.Close()
        Catch ex As Exception
            MsgBox("No s'han pogut carregar les solucions desde la base de dades - " + ex.Message, vbCritical, "Error")
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

End Class