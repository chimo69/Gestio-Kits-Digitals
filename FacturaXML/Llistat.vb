Imports System.Data.SqlClient

Public Class Llistat
    Dim cadena As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""C:\Users\telematic\Documents\Antonio\KitDigital2\FacturaXML\Database1.mdf"";Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False"
    Dim DT_Llistat As New DataTable
    Dim MostratActual As Integer
    Dim SitioWeb, ComercioElectronico, RedesSociales, Procesos, Clientes, Business, Factura, Oficina, Comunicaciones, Ciberseguridad As Integer
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

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
                          Solucions.DataContracte,
                          Solucions.DataVenciment,
                          Solucions.Justificat
                          FROM Solucions
                          INNER JOIN Empreses ON Solucions.idEmpresa=Empreses.Id
                          INNER JOIN TipusSolucions ON Solucions.idSolucio=TipusSolucions.Id
                          WHERE Solucions.Justificat=0 AND Solucions.idSolucio=" & i & " 
                          ORDER BY Solucions.DataVenciment ASC"

                Else
                    Sql = "SELECT Empreses.Nom As Empresa,
                          TipusSolucions.Id,    
                          TipusSolucions.Nom As Solucio,
                          Solucions.Contracte,
                          Solucions.DataContracte,
                          Solucions.DataVenciment,
                          Solucions.Justificat
                          FROM Solucions
                          INNER JOIN Empreses ON Solucions.idEmpresa=Empreses.Id
                          INNER JOIN TipusSolucions ON Solucions.idSolucio=TipusSolucions.Id
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
                          Solucions.DataContracte,
                          Solucions.DataVenciment,
                          Solucions.Justificat
                          FROM Solucions
                          INNER JOIN Empreses ON Solucions.idEmpresa=Empreses.Id
                          INNER JOIN TipusSolucions ON Solucions.idSolucio=TipusSolucions.Id
                          WHERE Solucions.Justificat=0 
                          ORDER BY Solucions.DataVenciment ASC"
                Else
                    Sql = "SELECT Empreses.Nom As Empresa,
                          TipusSolucions.Id,    
                          TipusSolucions.Nom As Solucio,
                          Solucions.Contracte,
                          Solucions.DataContracte,
                          Solucions.DataVenciment,
                          Solucions.Justificat
                          FROM Solucions
                          INNER JOIN Empreses ON Solucions.idEmpresa=Empreses.Id
                          INNER JOIN TipusSolucions ON Solucions.idSolucio=TipusSolucions.Id                          
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


    Private Sub DataLlistat_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataLlistat.CellFormatting

        DataLlistat.Columns("Id").Visible = False
        DataLlistat.Columns("DataContracte").Width = 100
        DataLlistat.Columns("DataContracte").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataLlistat.Columns("DataVenciment").Width = 100
        DataLlistat.Columns("DataVenciment").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataLlistat.Columns("Empresa").Width = 300
        DataLlistat.Columns("Justificat").Width = 100
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
                If Fila.Cells("DataVenciment").Value < Date.Now Then
                    If Fila.Cells("Justificat").Value = 1 Then
                        Fila.DefaultCellStyle.BackColor = Color.Red
                    Else
                        Fila.DefaultCellStyle.BackColor = Color.LightGreen
                    End If
                End If

                If MostratActual = 0 Then
                    If IsNumeric(Fila.Cells("Id").Value) Then
                        If Fila.Cells("Id").Value = 1 Then SitioWeb += 1
                        If Fila.Cells("Id").Value = 2 Then ComercioElectronico += 1
                        If Fila.Cells("Id").Value = 3 Then RedesSociales += 1
                        If Fila.Cells("Id").Value = 4 Then Clientes += 1
                        If Fila.Cells("Id").Value = 5 Then Business += 1
                        If Fila.Cells("Id").Value = 6 Then Procesos += 1
                        If Fila.Cells("Id").Value = 7 Then Factura += 1
                        If Fila.Cells("Id").Value = 8 Then Oficina += 1
                        If Fila.Cells("Id").Value = 9 Then Comunicaciones += 1
                        If Fila.Cells("Id").Value = 10 Then Ciberseguridad += 1
                    End If
                End If
            Next
        End If
        numeraSolucions()

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