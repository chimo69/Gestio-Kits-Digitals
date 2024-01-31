Imports System.Data.SQLite
Imports System.Diagnostics.Contracts

Public Class Segona
    Dim DT_Llistat As New DataTable
    Dim SolucioFiltre As Integer
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        SolucioFiltre = 0
        CarregaLlistat()

    End Sub

    Private Sub CarregaLlistat()

        Dim sql As String = ""
        Dim sqlFiltre As String = ""
        Dim sqlMostraJust As String = ""

        If SolucioFiltre <> 0 Then
            sqlFiltre = "AND (solucions.idSolucio=" & SolucioFiltre & ")"
        End If

        If CB_MostraJustificades.Checked = False Then
            sqlMostraJust = "AND (solucions.SegonJustificat = 'No')"
        Else
            sqlMostraJust = ""
        End If

        sql = "Select Empreses.Nom AS Empresa,
                                    TipusSolucions.nom AS Solucio,
                                    Solucions.Contracte,
                                    strftime('%d-%m-%Y',Solucions.DataFactura) AS 'Data factura',                                    
                                    strftime('%d-%m-%Y',Solucions.DataVenciment) AS 'Data màxima segona Justificació',
                                    Solucions.SegonJustificat
                             From Solucions
                             INNER JOIN Empreses ON Solucions.idEmpresa=Empreses.Id
                             INNER JOIN TipusSolucions ON Solucions.idSolucio=TipusSolucions.Id
                             WHERE justificat='Si'" & sqlFiltre & sqlMostraJust & "
                             ORDER by dataFactura"
        Try
            Using conexion As New SQLiteConnection(cadena),
              comm As New SQLiteCommand(Sql, conexion),
DA As New SQLiteDataAdapter(comm)

                DT_Llistat.Clear()
                DA.Fill(DT_Llistat)
                Llista_segona.DataSource = DT_Llistat
                Llista_segona.Columns("SegonJustificat").Visible = False

            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Llista_segona_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles Llista_segona.CellFormatting
        Dim dgv As DataGridView = sender

        Llista_segona.Columns("Empresa").Width = 300
        Llista_segona.Columns("mesos").Width = 50
        Llista_segona.Columns("mesos").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        For Each Fila As DataGridViewRow In dgv.Rows

            Dim dataFactura As DateTime = Fila.Cells("Data Factura").Value
            Dim dataAvui As DateTime = DateTime.Now
            Dim diferencia As TimeSpan = dataAvui - dataFactura

            If diferencia.Days >= 365 Then Fila.Cells("Empresa").Style.BackColor = blau
            If diferencia.Days < 365 And diferencia.Days >= 275 Then Fila.Cells("Empresa").Style.BackColor = taronja
            If Fila.Cells("SegonJustificat").Value = "Si" Then Fila.Cells("Empresa").Style.BackColor = verdClar

            Fila.Cells("Mesos").Value = Math.Truncate(diferencia.Days / 30)
        Next
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

        With Llista_segona.Columns("Mesos")
            .DisplayIndex = 0
            .DefaultCellStyle.Font = New Font(Llista_segona.DefaultCellStyle.Font.FontFamily, 12, FontStyle.Bold)
        End With

    End Sub

    Private Sub Segona_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Llista_segona_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles Llista_segona.DataBindingComplete
        Llista_segona.ClearSelection()
    End Sub

    Private Sub CB_MostraJustificades_CheckedChanged(sender As Object, e As EventArgs) Handles CB_MostraJustificades.CheckedChanged
        CarregaLlistat()

        'If CB_MostraJustificades.Checked = True Then

        'Else

        'End If
    End Sub
End Class