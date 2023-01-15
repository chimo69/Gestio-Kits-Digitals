Imports System.Data.SQLite

Public Class Llistat

    Dim DT_Llistat As New DataTable
    Dim MostratActual As Integer
    Dim SitioWeb, ComercioElectronico, RedesSociales, Procesos, Clientes, Business, Factura, Oficina, Comunicaciones, Ciberseguridad As Integer

    Private Sub DataLlistat_DataSourceChanged(sender As Object, e As EventArgs) Handles DataLlistat.DataSourceChanged


        With DataLlistat
            .ClearSelection()

            .Columns("IdSolucio").Visible = False
            .Columns("IdEmpresa").Visible = False
            .Columns("IdTipusSolucio").Visible = False
            .Columns("Data contracte").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Data venciment").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Dies").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Estat justificació").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Justificat").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Observacions").DefaultCellStyle.WrapMode = DataGridViewTriState.True
            .Columns("Word").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Comp. Pagament").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("XML").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Fabricant Solució").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("D1").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("D2").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        End With

        If MostratActual = 0 Then
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

        'If DataLlistat.Rows.Count > 0 Then
        '    For Each Fila As DataGridViewRow In DataLlistat.Rows

        '        If Fila.Cells("Dies").Value <= 90 And Fila.Cells("Dies").Value >= 1 Then Fila.DefaultCellStyle.BackColor = taronja
        '        If Fila.Cells("Dies").Value <= 0 Then Fila.DefaultCellStyle.BackColor = vermell

        '        If Fila.Cells("Justificat").Value = "Si" Then Fila.DefaultCellStyle.BackColor = verd

        '        If MostratActual = 0 Then
        '            If IsNumeric(Fila.Cells("IdTipusSolucio").Value) Then
        '                If Fila.Cells("IdTipusSolucio").Value = 1 Then
        '                    SitioWeb += 1

        '                End If
        '                If Fila.Cells("IdSolucio").Value = 2 Then
        '                    ComercioElectronico += 1

        '                End If
        '                If Fila.Cells("IdTipusSolucio").Value = 3 Then
        '                    RedesSociales += 1

        '                End If
        '                If Fila.Cells("IdTipusSolucio").Value = 4 Then
        '                    Clientes += 1

        '                End If
        '                If Fila.Cells("IdTipusSolucio").Value = 5 Then
        '                    Business += 1

        '                End If
        '                If Fila.Cells("IdTipusSolucio").Value = 6 Then
        '                    Procesos += 1

        '                End If
        '                If Fila.Cells("IdTipusSolucio").Value = 7 Then
        '                    Factura += 1

        '                End If
        '                If Fila.Cells("IdTipusSolucio").Value = 8 Then
        '                    Oficina += 1

        '                End If
        '                If Fila.Cells("IdTipusSolucio").Value = 9 Then
        '                    Comunicaciones += 1

        '                End If
        '                If Fila.Cells("IdTipusSolucio").Value = 10 Then
        '                    Ciberseguridad += 1

        '                End If
        '            End If
        '        End If
        '    Next
        'End If
        'NumeraSolucions()

    End Sub

    Private Sub DataLlistat_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataLlistat.CellFormatting
        Dim dgv As DataGridView = sender

        If dgv.Columns(e.ColumnIndex).Name = "Word" Or dgv.Columns(e.ColumnIndex).Name = "Comp. Pagament" Or dgv.Columns(e.ColumnIndex).Name = "XML" Or dgv.Columns(e.ColumnIndex).Name = "D1" Or dgv.Columns(e.ColumnIndex).Name = "D2" Then
            If e.Value = 1 Then
                e.CellStyle.BackColor = verd
                e.Value = ""
            Else
                e.CellStyle.BackColor = vermell
                e.Value = ""
            End If
        End If
        If dgv.Columns(e.ColumnIndex).Name = "Fabricant Solució" Then
            If e.Value <> "" Then
                e.CellStyle.BackColor = verd
                e.Value = ""
            Else
                e.CellStyle.BackColor = vermell
                e.Value = ""
            End If

        End If
        Dim font As New Font("Calibri", 7, FontStyle.Regular)

        With dgv
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

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CarregaLlistat()

    End Sub

    Private Sub DataLlistat_DataBindingComplete(ByVal sender As Object, ByVal e As DataGridViewBindingCompleteEventArgs) Handles DataLlistat.DataBindingComplete

        Dim dgv As DataGridView = sender

        With sender
            .AutoResizeColumns()
            .AutoResizeRows()
            .ClearSelection()
        End With


        If dgv.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In dgv.Rows

                If Fila.Cells("Dies").Value <= 90 And Fila.Cells("Dies").Value >= 1 Then Fila.DefaultCellStyle.BackColor = taronja
                If Fila.Cells("Dies").Value <= 0 Then Fila.DefaultCellStyle.BackColor = vermell

                If Fila.Cells("Justificat").Value = "Si" Then Fila.DefaultCellStyle.BackColor = verd

                If MostratActual = 0 Then
                    If IsNumeric(Fila.Cells("IdTipusSolucio").Value) Then
                        If Fila.Cells("IdTipusSolucio").Value = 1 Then
                            SitioWeb += 1

                        End If
                        If Fila.Cells("IdSolucio").Value = 2 Then
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
        NumeraSolucions()



    End Sub


    'Carrega el llistat de solucions de la base de dades
    Public Sub CarregaLlistat(i As Integer)
        Try
            Dim conexion As New SQLiteConnection()
            Dim Sql As String
            MostratActual = i

            conexion = New SQLiteConnection(cadena)
            conexion.Open()

            If conexion.State = ConnectionState.Open Then
                Dim DA As New SQLiteDataAdapter
                Dim comm As SQLiteCommand
                DT_Llistat.Clear()

                If CB_JaPresentades.Checked = False Then
                    Sql = "SELECT Empreses.Nom As Empresa,
                          Empreses.Id As IdEmpresa,  
                          TipusSolucions.Id As IdTipusSolucio,    
                          TipusSolucions.Nom As Solucio,
                          Solucions.Id As IdSolucio,
                          Solucions.Contracte,                          
                          Solucions.DataContracte AS 'Data contracte',
                          Solucions.DataVenciment AS 'Data venciment',
                          julianday(Solucions.DataVenciment) - julianday(date())  AS Dies,
                          Justificacions.Percentatge AS 'Estat justificació',                         
                          Solucions.Justificat,
                          Solucions.Observacions,
                          TeWord As 'Word',
                          TeComprovantPagament As 'Comp. Pagament',
                          TeFacturaXML AS 'XML',
                          FabricantSolucio As 'Fabricant Solució',
                          Dada1 as 'D1',
                          Dada2 as 'D2'
                          FROM Solucions
                          INNER JOIN Empreses ON Solucions.idEmpresa=Empreses.Id
                          INNER JOIN TipusSolucions ON Solucions.idSolucio=TipusSolucions.Id
                          INNER JOIN Justificacions ON Solucions.id=Justificacions.idSolucio 
                          WHERE Solucions.Justificat='No' AND Solucions.idSolucio=" & i & " 
                          ORDER BY Solucions.DataVenciment ASC"

                Else
                    Sql = "SELECT Empreses.Nom As Empresa,
                          Empreses.Id As IdEmpresa,  
                          TipusSolucions.Id As IdTipusSolucio,    
                          TipusSolucions.Nom As Solucio,
                          Solucions.Contracte,
                          Solucions.Id As IdSolucio,
                          Solucions.DataContracte AS 'Data contracte',
                          Solucions.DataVenciment AS 'Data venciment',
                          julianday(Solucions.DataVenciment) - julianday(date())  AS Dies, 
                          Justificacions.Percentatge AS 'Estat justificació',                          
                          Solucions.Justificat,
                          Solucions.Observacions,
                          TeWord As 'Word',
                          TeComprovantPagament As 'Comp. Pagament',
                          TeFacturaXML AS 'XML',
                          FabricantSolucio As 'Fabricant Solució',
                          Dada1 as 'D1',
                          Dada2 as 'D2'
                          FROM Solucions
                          INNER JOIN Empreses ON Solucions.idEmpresa=Empreses.Id
                          INNER JOIN TipusSolucions ON Solucions.idSolucio=TipusSolucions.Id
                          INNER JOIN Justificacions ON Solucions.id=Justificacions.idSolucio  
                          WHERE Solucions.idSolucio=" & i & "
                          ORDER BY Solucions.DataVenciment ASC"
                End If

                comm = New SQLiteCommand(Sql, conexion)

                DA.SelectCommand = comm
                DA.Fill(DT_Llistat)
                DataLlistat.DataSource = DT_Llistat

            End If
            conexion.Close()
        Catch ex As Exception
            MsgBox("No s'han pogut carregar les solucions desde la base de dades",, "Error")
        End Try


    End Sub
    Public Sub CarregaLlistat()
        Try
            Dim conexion As New SQLiteConnection()
            Dim Sql As String

            conexion = New SQLiteConnection(cadena)
            conexion.Open()

            If conexion.State = ConnectionState.Open Then
                Dim DA As New SQLiteDataAdapter
                Dim comm As SQLiteCommand
                DT_Llistat.Clear()

                If CB_JaPresentades.Checked = False Then
                    Sql = "SELECT Empreses.Nom As Empresa,
                          Empreses.Id  As IdEmpresa,  
                          TipusSolucions.Id As IdTipusSolucio,    
                          TipusSolucions.Nom As Solucio,
                          Solucions.Contracte,
                          Solucions.Id As IdSolucio,
                          Solucions.DataContracte AS 'Data contracte',
                          Solucions.DataVenciment AS 'Data venciment',
                          julianday(Solucions.DataVenciment) - julianday(date()) AS Dies,                           
                          Justificacions.percentatge AS 'Estat justificació',                                                    
                          Solucions.Justificat,
                          Solucions.Observacions,
                          TeWord As 'Word',
                          TeComprovantPagament As 'Comp. Pagament',
                          TeFacturaXML AS 'XML',
                          FabricantSolucio As 'Fabricant Solució',
                          Dada1 as 'D1',
                          Dada2 as 'D2'
                          FROM Solucions
                          INNER JOIN Empreses ON Solucions.idEmpresa=Empreses.Id
                          INNER JOIN TipusSolucions ON Solucions.idSolucio=TipusSolucions.Id
                          INNER JOIN Justificacions ON Solucions.id=Justificacions.idSolucio  
                          WHERE Solucions.Justificat='No' 
                          ORDER BY Solucions.DataVenciment ASC"
                Else
                    Sql = "SELECT Empreses.Nom As Empresa,
                          Empreses.Id As IdEmpresa,  
                          TipusSolucions.Id As IdTipusSolucio,    
                          TipusSolucions.Nom As Solucio,
                          Solucions.Contracte,
                          Solucions.Id As IdSolucio,
                          Solucions.DataContracte AS 'Data contracte',
                          Solucions.DataVenciment AS 'Data venciment',
                          julianday(Solucions.DataVenciment) - julianday(date()) AS Dies, 
                          Justificacions.percentatge AS 'Estat justificació',                          
                          Solucions.Justificat,
                          Solucions.Observacions,
                          TeWord As 'Word',
                          TeComprovantPagament As 'Comp. Pagament',
                          TeFacturaXML AS 'XML',
                          FabricantSolucio As 'Fabricant Solució',
                          Dada1 as 'D1',
                          Dada2 as 'D2'
                          FROM Solucions
                          INNER JOIN Empreses ON Solucions.idEmpresa=Empreses.Id
                          INNER JOIN TipusSolucions ON Solucions.idSolucio=TipusSolucions.Id                          
                          INNER JOIN Justificacions ON Solucions.id=Justificacions.idSolucio  
                          ORDER BY Solucions.DataVenciment ASC"
                End If

                comm = New SQLiteCommand(Sql, conexion)

                DA.SelectCommand = comm
                DT_Llistat.Clear()
                DA.Fill(DT_Llistat)
                DataLlistat.DataSource = DT_Llistat

            End If
            conexion.Close()

        Catch ex As Exception
            MsgBox("No s'han pogut carregar les solucions desde la base de dades",, "Error")
        End Try

    End Sub

    Private Sub NumeraSolucions()
        If MostratActual = 0 Then TB_totes.Text = DataLlistat.RowCount.ToString
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
        If MostratActual <> 0 Then
            CarregaLlistat(MostratActual)
        Else
            CarregaLlistat()
        End If
    End Sub

    Private Sub TipusSolucions_CheckedChanged(sender As Object, e As EventArgs) Handles RB_SitioWeb.CheckedChanged,
        RB_ComercioElectronico.CheckedChanged, RB_RedesSociales.CheckedChanged, RB_GestionClientes.CheckedChanged,
        RB_BusinessInteligence.CheckedChanged, RB_GestionProcesos.CheckedChanged, RB_FacturaElectronica.CheckedChanged,
        RB_OficinaVirtual.CheckedChanged, RB_ComunicacionesSeguras.CheckedChanged, RB_Ciberseguridad.CheckedChanged, RB_Totes.CheckedChanged

        If RB_SitioWeb.Checked Then
            CarregaLlistat(1)
        ElseIf RB_ComercioElectronico.Checked Then
            CarregaLlistat(2)
        ElseIf RB_RedesSociales.Checked Then
            CarregaLlistat(3)
        ElseIf RB_GestionClientes.Checked Then
            CarregaLlistat(4)
        ElseIf RB_BusinessInteligence.Checked Then
            CarregaLlistat(5)
        ElseIf RB_GestionProcesos.Checked Then
            CarregaLlistat(6)
        ElseIf RB_FacturaElectronica.Checked Then
            CarregaLlistat(7)
        ElseIf RB_OficinaVirtual.Checked Then
            CarregaLlistat(8)
        ElseIf RB_ComunicacionesSeguras.Checked Then
            CarregaLlistat(9)
        ElseIf RB_Ciberseguridad.Checked Then
            CarregaLlistat(10)
        ElseIf RB_Totes.Checked Then
            MostratActual = 0
            CarregaLlistat()

        End If

    End Sub

End Class