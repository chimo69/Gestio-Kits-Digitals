Imports System.Data.SQLite
Imports System.Diagnostics.Contracts
Imports System.IO
Imports System.Reflection

Public Class Segona
    Dim DT_Llistat As New DataTable
    Dim SolucioFiltre As Integer
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        SolucioFiltre = 0
        Me.DoubleBuffered = True

        Dim dgvType As Type = GetType(DataGridView)
        Dim dgvPropInfo As PropertyInfo = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
        dgvPropInfo.SetValue(Llista_segona, True, Nothing)


    End Sub

    Private Sub CarregaLlistat()

        Dim sql As String = ""
        Dim sqlFiltre As String = ""
        Dim sqlMostraJust As String = ""

        If SolucioFiltre <> 0 Then
            sqlFiltre = "AND (solucions.idSolucio=" & SolucioFiltre & ")"
        End If

        If CB_MostraJustificades.Checked = False Then
            sqlMostraJust = "AND (solucions.Justificat = 'No')"
        Else
            sqlMostraJust = ""
        End If

        sql = "SELECT Empreses.Nom AS Empresa,              
                                    TipusSolucions.Nom AS Solucio,       
                                    Solucions.Contracte,
                                    Solucions.Justificat,

                                    strftime('%d-%m-%Y',Solucions.DataContracte) AS 'Data contracte',
                                    strftime('%d-%m-%Y',Solucions.DataFactura) AS 'Data factura',                                    
                                    strftime('%d-%m-%Y',Solucions.DataVenciment) AS 'Data màxima segona Justificació',
                                    julianday(Solucions.DataVenciment) - julianday(date())  AS Dies,
                                    TipusEstats.NomEstat AS 'Estat',
                                    Solucions.observacions
       
                    FROM Solucions
                    INNER JOIN Empreses ON Solucions.idEmpresa=Empreses.Id
                    INNER JOIN TipusSolucions ON Solucions.idSolucio=TipusSolucions.Id
                    INNER JOIN Justificacions ON Solucions.id=Justificacions.idSolucio
                    INNER JOIN TipusEstats ON Justificacions.Estat=TipusEstats.id
                    WHERE (TIPUS = 2 AND Solucions.Datafactura <> '') " & sqlFiltre & sqlMostraJust & " ORDER by dataFactura"

        Try
            Using conexion As New SQLiteConnection(cadena),
              comm As New SQLiteCommand(sql, conexion),
DA As New SQLiteDataAdapter(comm)

                DT_Llistat.Clear()
                DA.Fill(DT_Llistat)
                Llista_segona.DataSource = DT_Llistat
                Llista_segona.Columns("Justificat").Visible = False

            End Using


        Catch ex As Exception

        End Try
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

    Private Sub Llista_segona_DataSourceChanged(sender As Object, e As EventArgs) Handles Llista_segona.DataSourceChanged

        Dim dgv As DataGridView = sender

        With dgv


        End With



    End Sub

    Private Sub Segona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregaLlistat()
    End Sub

    Private Sub Llista_segona_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles Llista_segona.DataBindingComplete

        Dim dgv As DataGridView = sender

        With dgv.Columns("Mesos")
            .DisplayIndex = 0
            .DefaultCellStyle.Font = New Font(Llista_segona.DefaultCellStyle.Font.FontFamily, 12, FontStyle.Bold)
        End With

        With dgv
            .ClearSelection()
            .Columns("Solucio").Width = 180
            .Columns("Empresa").Width = 300
            .Columns("mesos").Width = 50
            .Columns("dies").Width = 50
            .Columns("contracte").Width = 100
            .Columns("data contracte").Width = 100
            .Columns("data factura").Width = 100
            .Columns("data màxima segona justificació").Width = 100
            .Columns("Estat").Width = 180
            .Columns("mesos").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("dies").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("contracte").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("data contracte").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("data factura").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("data màxima segona justificació").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Observacions").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End With

        ConfigureDataGridViewColumns()

    End Sub

    Private Sub ConfigureDataGridViewColumns()

        Dim dataFactura As DateTime
        Dim dataAvui As DateTime
        Dim diferencia As TimeSpan

        Try

            For Each Fila As DataGridViewRow In Llista_segona.Rows

                If Not IsDBNull(Fila.Cells("Data Factura").Value) Then
                    dataFactura = Fila.Cells("Data Factura").Value
                    dataAvui = DateTime.Now
                    diferencia = dataAvui - dataFactura
                Else
                    diferencia = Nothing
                End If


                If Fila.Cells("Dies").Value < 0 Then Fila.Cells("Dies").Value = 0
                If diferencia.Days >= 365 Then Fila.Cells("Empresa").Style.BackColor = blau
                If diferencia.Days < 365 And diferencia.Days >= 275 Then Fila.Cells("Empresa").Style.BackColor = taronja
                If Fila.Cells("Justificat").Value = "Si" Then Fila.Cells("Empresa").Style.BackColor = verdClar

                Fila.Cells("Mesos").Value = Math.Truncate(diferencia.Days / 30)

                If Fila.Cells("Mesos").Value >= 10 And Fila.Cells("Mesos").Value <= 12 Then
                    If Fila.Cells("Solucio").Value <> "Sitio web" And Fila.Cells("Solucio").Value <> "Comercio electrónico" Then
                        Fila.Cells("Mesos").Style.BackColor = Color.Yellow
                    End If
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Error configuring columns: " & ex.Message)
        End Try
    End Sub

    Private Sub CB_MostraJustificades_CheckedChanged(sender As Object, e As EventArgs) Handles CB_MostraJustificades.CheckedChanged
        CarregaLlistat()
    End Sub
End Class