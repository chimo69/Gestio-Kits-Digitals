Imports System.Data.SqlClient

Public Class Llistat

    Dim DT_Llistat As New DataTable
    Dim MostratActual As Integer
    Dim SitioWeb, ComercioElectronico, RedesSociales, Procesos, Clientes, Business, Factura, Oficina, Comunicaciones, Ciberseguridad As Integer

    Private Sub DataLlistat_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataLlistat.DataBindingComplete


        DataLlistat.ClearSelection()
        DataLlistat.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue
        DataLlistat.Columns("Id").Visible = False
        DataLlistat.Columns("Data contracte").Width = 100
        DataLlistat.Columns("Data contracte").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataLlistat.Columns("Data contracte").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataLlistat.Columns("Data venciment").Width = 100
        DataLlistat.Columns("Data venciment").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataLlistat.Columns("Data venciment").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataLlistat.Columns("Empresa").Width = 300
        DataLlistat.Columns("Dies").Width = 100
        DataLlistat.Columns("Dies").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataLlistat.Columns("Dies").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataLlistat.Columns("Estat justificació").Width = 100
        DataLlistat.Columns("Estat justificació").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataLlistat.Columns("Estat justificació").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataLlistat.Columns("Justificat").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataLlistat.Columns("Justificat").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

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

        If DataLlistat.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In DataLlistat.Rows

                If Fila.Cells("Dies").Value <= 90 And Fila.Cells("Dies").Value >= 1 Then Fila.DefaultCellStyle.BackColor = Color.Orange
                If Fila.Cells("Dies").Value <= 0 Then Fila.DefaultCellStyle.BackColor = Color.Red
                If Fila.Cells("Justificat").Value = True Then Fila.DefaultCellStyle.BackColor = Color.LightGreen

                If MostratActual = 0 Then
                    If IsNumeric(Fila.Cells("Id").Value) Then
                        If Fila.Cells("Id").Value = 1 Then
                            SitioWeb += 1

                        End If
                        If Fila.Cells("Id").Value = 2 Then
                            ComercioElectronico += 1

                        End If
                        If Fila.Cells("Id").Value = 3 Then
                            RedesSociales += 1

                        End If
                        If Fila.Cells("Id").Value = 4 Then
                            Clientes += 1

                        End If
                        If Fila.Cells("Id").Value = 5 Then
                            Business += 1

                        End If
                        If Fila.Cells("Id").Value = 6 Then
                            Procesos += 1

                        End If
                        If Fila.Cells("Id").Value = 7 Then
                            Factura += 1

                        End If
                        If Fila.Cells("Id").Value = 8 Then
                            Oficina += 1

                        End If
                        If Fila.Cells("Id").Value = 9 Then
                            Comunicaciones += 1

                        End If
                        If Fila.Cells("Id").Value = 10 Then
                            Ciberseguridad += 1

                        End If
                    End If
                End If
            Next
        End If
        numeraSolucions()
    End Sub

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CarregaLlistat()
    End Sub
    'Carrega el llistat de solucions de la base de dades
    Public Sub CarregaLlistat(i As Integer)
        Try
            Dim conexion As New SqlConnection()
            Dim Sql As String
            MostratActual = i

            conexion = New SqlConnection(cadena)
            conexion.Open()

            If conexion.State = ConnectionState.Open Then
                Dim DA As New SqlDataAdapter
                Dim comm As SqlCommand
                DT_Llistat.Clear()

                If CB_JaPresentades.Checked = False Then
                    Sql = "SELECT Empreses.Nom As Empresa,
                          TipusSolucions.Id,    
                          TipusSolucions.Nom As Solucio,
                          Solucions.Contracte,
                          Solucions.DataContracte AS 'Data contracte',
                          Solucions.DataVenciment AS 'Data venciment',
                          DATEDIFF (day,getDate(),Solucions.DataVenciment) AS Dies,
                          Justificacions.Percentatge AS 'Estat justificació',
                          Solucions.Justificat                          
                          FROM Solucions
                          INNER JOIN Empreses ON Solucions.idEmpresa=Empreses.Id
                          INNER JOIN TipusSolucions ON Solucions.idSolucio=TipusSolucions.Id
                          INNER JOIN Justificacions ON Solucions.id=Justificacions.idSolucio 
                          WHERE Solucions.Justificat=0 AND Solucions.idSolucio=" & i & " 
                          ORDER BY Solucions.DataVenciment ASC"

                Else
                    Sql = "SELECT Empreses.Nom As Empresa,
                          TipusSolucions.Id,    
                          TipusSolucions.Nom As Solucio,
                          Solucions.Contracte,
                          Solucions.DataContracte AS 'Data contracte',
                          Solucions.DataVenciment AS 'Data venciment',
                          DATEDIFF (day,getDate(),Solucions.DataVenciment) AS Dies, 
                          Justificacions.Percentatge AS 'Estat justificació',
                          Solucions.Justificat
                          FROM Solucions
                          INNER JOIN Empreses ON Solucions.idEmpresa=Empreses.Id
                          INNER JOIN TipusSolucions ON Solucions.idSolucio=TipusSolucions.Id
                          INNER JOIN Justificacions ON Solucions.id=Justificacions.idSolucio  
                          WHERE Solucions.idSolucio=" & i & "
                          ORDER BY Solucions.DataVenciment ASC"
                End If

                comm = New SqlCommand(Sql, conexion)

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
            Dim conexion As New SqlConnection()
            Dim Sql As String

            conexion = New SqlConnection(cadena)
            conexion.Open()

            If conexion.State = ConnectionState.Open Then
                Dim DA As New SqlDataAdapter
                Dim comm As SqlCommand
                DT_Llistat.Clear()

                If CB_JaPresentades.Checked = False Then
                    Sql = "SELECT Empreses.Nom As Empresa,
                          TipusSolucions.Id,    
                          TipusSolucions.Nom As Solucio,
                          Solucions.Contracte,
                          Solucions.DataContracte AS 'Data contracte',
                          Solucions.DataVenciment AS 'Data venciment',
                          DATEDIFF (day,getDate(),Solucions.DataVenciment) AS Dies,                           
                          Justificacions.percentatge AS 'Estat justificació',                          
                          Solucions.Justificat
                          FROM Solucions
                          INNER JOIN Empreses ON Solucions.idEmpresa=Empreses.Id
                          INNER JOIN TipusSolucions ON Solucions.idSolucio=TipusSolucions.Id
                          INNER JOIN Justificacions ON Solucions.id=Justificacions.idSolucio  
                          WHERE Solucions.Justificat=0 
                          ORDER BY Solucions.DataVenciment ASC"
                Else
                    Sql = "SELECT Empreses.Nom As Empresa,
                          TipusSolucions.Id,    
                          TipusSolucions.Nom As Solucio,
                          Solucions.Contracte,
                          Solucions.DataContracte AS 'Data contracte',
                          Solucions.DataVenciment AS 'Data venciment',
                          DATEDIFF (day,getDate(),Solucions.DataVenciment) AS Dies, 
                          Justificacions.percentatge AS 'Estat justificació',
                          Solucions.Justificat
                          FROM Solucions
                          INNER JOIN Empreses ON Solucions.idEmpresa=Empreses.Id
                          INNER JOIN TipusSolucions ON Solucions.idSolucio=TipusSolucions.Id                          
                          INNER JOIN Justificacions ON Solucions.id=Justificacions.idSolucio  
                          ORDER BY Solucions.DataVenciment ASC"
                End If

                comm = New SqlCommand(Sql, conexion)

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

    Private Sub numeraSolucions()
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

    Private Sub tipusSolucions_CheckedChanged(sender As Object, e As EventArgs) Handles RB_SitioWeb.CheckedChanged,
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