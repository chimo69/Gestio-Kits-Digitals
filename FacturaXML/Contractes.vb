Imports System.Data.SqlClient
Imports System.Data
Imports System.Runtime.CompilerServices

Public Class Contractes

    Dim cadena As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""C:\Users\telematic\Documents\Antonio\KitDigital2\FacturaXML\Database1.mdf"";Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False"

    Dim empresaSeleccionada, solucioSeleccionada As Boolean
    Dim idEmpresaSeleccionada, idSolucioSeleccionada As Integer
    Dim DT_Empreses, DT_Solucions As New DataTable

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        actualitzaTaula()

        DataEmpreses.ClearSelection()

    End Sub

    Private Sub Btn_afegir_Click(sender As Object, e As EventArgs) Handles Btn_afegir.Click
        inserirEmpresa()
    End Sub

    'Actualitza la taula amb dades de la Base de dades
    Private Sub actualitzaTaula()

        Dim conexion As New SqlConnection()

        Try
            conexion = New SqlConnection(cadena)
            conexion.Open()

            If conexion.State = ConnectionState.Open Then
                Dim DT As New DataTable
                Dim DA As New SqlDataAdapter("SELECT * FROM Empreses", conexion)
                DA.Fill(DT)
                DataEmpreses.DataSource = DT
                Dim colId As DataGridViewColumn = DataEmpreses.Columns(0)
                colId.Visible = False

            End If
            conexion.Close()

        Catch ex As Exception
            MsgBox("No s'ha pogut accedir a la base de dades",, "Error")
        End Try

    End Sub
    'Introdueix una empresa nova
    Private Sub inserirEmpresa()

        Dim conexion As New SqlConnection(cadena)
        Dim Query As String
        Dim strCommand As SqlCommand
        Dim empresaTxt As String = Empresa.Text
        Dim nifTxt As String = Nif.Text
        Dim direccioTxt As String = Direccio.Text
        Dim codiPostalTxt As String = CodiPostal.Text
        Dim ciutatTxt As String = Ciutat.Text
        Dim provinciaTxt As String = Provincia.Text
        Dim paisTxt As String = Pais.Text
        Dim seleccio As Boolean
        seleccio = empresaSeleccionada

        If (seleccio = True) Then

            Dim index As Integer = DataEmpreses.CurrentCell.RowIndex
            Dim row As DataGridViewRow = DataEmpreses.Rows(index)
            Dim idBorrar As Integer
            idBorrar = row.Cells(0).Value
            Query = "UPDATE Empreses SET 
                     Nom=" & StringDB(empresaTxt) &
                     ",Nif=" & StringDB(nifTxt) &
                     ",DIreccio=" & StringDB(direccioTxt) &
                     ",CodiPostal=" & StringDB(codiPostalTxt) &
                     ",Ciutat=" & StringDB(ciutatTxt) &
                     ",Provincia=" & StringDB(provinciaTxt) &
                     ",Pais=" & StringDB(paisTxt) &
                     "WHERE Id=" & idBorrar
        Else
            Query = "INSERT INTO Empreses VALUES (" &
                    StringDB(empresaTxt) & "," &
                    StringDB(nifTxt) & "," &
                    StringDB(direccioTxt) & "," &
                    StringDB(codiPostalTxt) & "," &
                    StringDB(ciutatTxt) & "," &
                    StringDB(provinciaTxt) & "," &
                    StringDB(paisTxt) & ")"
        End If

        Try
            strCommand = New SqlCommand(Query, conexion)
            conexion.Open()
            strCommand.ExecuteNonQuery()
            conexion.Close()
            actualitzaTaula()

            If seleccio = True Then MsgBox("Empresa modificada correctament",, "Modificar empresa")
            If seleccio = False Then MsgBox("Empresa introduida correctament",, "Introduir empresa")
        Catch ex As Exception
            If seleccio = True Then MsgBox("No s'ha pogut modificar l'empresa",, "Modificar empresa")
            If seleccio = False Then MsgBox("No s'ha pogut introduir l'empresa",, "Introduir empresa")
        End Try
    End Sub
    'Esborra l'empresa seleccionada
    Private Sub esborrarEmpresa(id As Integer)

        Dim resposta = MsgBox("¿Estàs segur que vols esborrar aquesta empresa?", vbYesNo, "Esborrar empresa")

        If resposta = vbYes Then
            Try
                Dim conexion As New SqlConnection(cadena)
                Dim Query As String
                Dim strCommand As SqlCommand
                Query = "DELETE FROM Empreses WHERE id=" & id
                strCommand = New SqlCommand(Query, conexion)
                conexion.Open()
                strCommand.ExecuteNonQuery()
                conexion.Close()
                actualitzaTaula()
                MsgBox("S'ha esborrat correctament l'empresa",, "Esborrar l'empresa")
            Catch ex As Exception
                MsgBox("No s'ha pogut esborrar l'empresa",, "Esborrar l'empresa")
            End Try
        End If

    End Sub
    Private Sub Btn_esborrar_Click(sender As Object, e As EventArgs) Handles Btn_esborrar.Click
        Dim index As Integer = DataEmpreses.CurrentCell.RowIndex
        Dim row As DataGridViewRow = DataEmpreses.Rows(index)
        Dim idBorrar As Integer
        idBorrar = row.Cells(0).Value
        esborrarEmpresa(idBorrar)
    End Sub
    'Sustitueix comilles per comilles dobles per evitar errors
    Public Function StringDB(arg As String) As String
        StringDB = "'" & Replace(arg, "'", "''") & "'"
    End Function
    'Modifica els camps quan la selecció d'empresa canvia
    Private Sub DataEmpreses_SelectionChanged(sender As Object, e As EventArgs) Handles DataEmpreses.SelectionChanged

        If DataEmpreses.RowCount > 0 Then
            Dim index As Integer = DataEmpreses.CurrentCell.RowIndex
            Dim row As DataGridViewRow = DataEmpreses.Rows(index)

            TitolEmpresa.Text = row.Cells(1).Value
            Empresa.Text = row.Cells(1).Value
            Nif.Text = row.Cells(2).Value
            Direccio.Text = row.Cells(3).Value
            CodiPostal.Text = row.Cells(4).Value
            Ciutat.Text = row.Cells(5).Value
            Provincia.Text = row.Cells(6).Value
            Pais.Text = row.Cells(7).Value

            Btn_afegir.Text = "Modificar empresa"
            empresaSeleccionada = True
            idEmpresaSeleccionada = row.Cells(0).Value
            OmpleSolucions(idEmpresaSeleccionada)
            If DataSolucions.RowCount > 0 Then
                Btn_AfegirSolucio.Text = "Modificar solució"
            Else
                Btn_AfegirSolucio.Text = "Afegir solució"
            End If
        End If

    End Sub

    Private Sub btn_esborrarSeleccio_Click(sender As Object, e As EventArgs) Handles btn_esborrarSeleccio.Click

        DataEmpreses.ClearSelection()
        Empresa.Clear()
        Nif.Clear()
        Direccio.Clear()
        CodiPostal.Clear()
        Ciutat.Clear()
        Provincia.Clear()
        Pais.Clear()

        Btn_afegir.Text = "Afegir empresa"
        TitolEmpresa.Clear()
        empresaSeleccionada = False

    End Sub
    'Carrega els tipus de solucions per omplir el combobox
    Private Sub Contractes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New SqlConnection()

        conexion = New SqlConnection(cadena)
        conexion.Open()

        If conexion.State = ConnectionState.Open Then
            Dim DA As New SqlDataAdapter("SELECT * FROM TipusSolucions", conexion)
            DA.Fill(DT_Empreses)
            CB_TipusSolucio.DataSource = DT_Empreses
            CB_TipusSolucio.DisplayMember = "Nom"
            CB_TipusSolucio.ValueMember = "Id"
            CB_TipusSolucio.Text = "Selecciona un tipus de solució"
            If DT_Solucions.Rows.Count = 0 Then TitolSolucio.Text = "Sense solucions"
        End If
        conexion.Close()
    End Sub

    Private Sub DataContracte_ValueChanged(sender As Object, e As EventArgs) Handles DataContracte.ValueChanged
        Dim dies = DateDiff(DateInterval.Day, Now, DataContracte.Value.AddMonths(6))
        DataVenciment.Text = Format(DataContracte.Value.AddMonths(6).Date, "Short Date")
        DiesCaducitat.Text = dies.ToString

    End Sub
    'Omple els camps amb els valors de la solució seleccionada
    Private Sub DataSolucions_SelectionChanged(sender As Object, e As EventArgs) Handles DataSolucions.SelectionChanged

        If DataSolucions.RowCount > 0 Then

            Btn_AfegirSolucio.Enabled = True
            Btn_EsborrarSeleccioSolucio.Enabled = True
            Dim index As Integer = DataSolucions.CurrentCell.RowIndex
            Dim row As DataGridViewRow = DataSolucions.Rows(index)
            Dim dies = DateDiff(DateInterval.Day, Now, DataContracte.Value.AddMonths(6))

            CB_TipusSolucio.Text = row.Cells(1).Value
            NoAcord.Text = row.Cells(2).Value
            DataContracte.Text = Format(row.Cells(3).Value, "Short Date")
            DataVenciment.Text = Format(row.Cells(4).Value, "Short Date")
            DiesCaducitat.Text = dies.ToString
            solucioSeleccionada = True
            idSolucioSeleccionada = row.Cells(0).Value
            Btn_AfegirSolucio.Text = "Modificar solució"
            Btn_EsborrarSolucio.Enabled = True
            TitolSolucio.Text = row.Cells(1).Value
            CheckEstaJustificat.Checked = row.Cells(5).Value
        Else
            EsborrarCampsSolucio()
            Btn_AfegirSolucio.Text = "Afegir solució"
            Btn_EsborrarSolucio.Enabled = False
            TitolSolucio.Text = "Sense solucions"
        End If

    End Sub

    Private Sub Btn_EsborrarSeleccioSolucio_Click(sender As Object, e As EventArgs) Handles Btn_EsborrarSeleccioSolucio.Click
        EsborrarCampsSolucio()
    End Sub
    'Carrega la taula amb les solucions trobades a la base de dades
    Private Sub OmpleSolucions(id As Integer)
        Dim conexion As New SqlConnection()

        Try
            conexion = New SqlConnection(cadena)
            conexion.Open()

            If conexion.State = ConnectionState.Open Then
                Dim DA As New SqlDataAdapter
                Dim comm As SqlCommand

                If CheckJustificat.Checked = True Then
                    comm = New SqlCommand("SELECT Solucions.Id,
                                              TipusSolucions.Nom,
                                              Solucions.Contracte,
                                              Solucions.DataContracte,
                                              Solucions.DataVenciment,
                                              Solucions.Justificat
                                              FROM Solucions
                                              INNER JOIN TipusSolucions ON TipusSolucions.Id=Solucions.idSolucio
                                              WHERE idEmpresa=" & id, conexion)
                Else
                    comm = New SqlCommand("SELECT Solucions.Id,
                                              TipusSolucions.Nom,
                                              Solucions.Contracte,
                                              Solucions.DataContracte,
                                              Solucions.DataVenciment,
                                              Solucions.Justificat
                                              FROM Solucions
                                              INNER JOIN TipusSolucions On TipusSolucions.Id=Solucions.idSolucio
                                              WHERE (idEmpresa=" & id & " And Justificat=0)", conexion)
                End If

                DA.SelectCommand = comm
                DT_Solucions.Clear()
                DA.Fill(DT_Solucions)
                DataSolucions.DataSource = DT_Solucions

            End If
            conexion.Close()
        Catch ex As Exception
            MsgBox("No s'ha pogut accedir a la base de dades",, "Error")
        End Try



        If DataSolucions.Rows.Count > 0 Then
            Dim colId As DataGridViewColumn = DataSolucions.Columns(0)
            Dim colJustificat As DataGridViewColumn = DataSolucions.Columns(5)
            colId.Visible = False
            colJustificat.Visible = False
            For Each Fila As DataGridViewRow In DataSolucions.Rows
                If Not Fila.Cells("DataVenciment").Value > Date.Now Then
                    If Not Fila.Cells("Justificat").Value = 0 Then
                        Fila.DefaultCellStyle.BackColor = Color.LightGreen
                    Else
                        Fila.DefaultCellStyle.BackColor = Color.Red
                    End If
                End If
            Next
        End If

        DataVenciment.Text = DataContracte.Value.Date.AddMonths(6)

    End Sub

    Private Sub Btn_EsborrarSolucio_Click(sender As Object, e As EventArgs) Handles Btn_EsborrarSolucio.Click
        Dim index As Integer = DataSolucions.CurrentCell.RowIndex
        Dim row As DataGridViewRow = DataSolucions.Rows(index)
        Dim idBorrar As Integer
        idBorrar = row.Cells(0).Value
        esborrarSolucio(idBorrar)
    End Sub

    Private Sub EsborrarCampsSolucio()
        DataSolucions.ClearSelection()
        CB_TipusSolucio.Text = "Selecciona un tipus de solució"
        NoAcord.Clear()
        DataContracte.Text = ""
        DataVenciment.Text = ""
        DiesCaducitat.Clear()
        solucioSeleccionada = False
        Btn_AfegirSolucio.Text = "Afegir solució"
        TitolSolucio.Clear()
        DataVenciment.Text = DataContracte.Value.Date.AddMonths(6)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckJustificat.CheckedChanged
        OmpleSolucions(idEmpresaSeleccionada)
    End Sub
    Private Sub DataSolucions_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataSolucions.CellFormatting
        DataSolucions.Columns("DataContracte").Width = 100
        DataSolucions.Columns("DataContracte").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataSolucions.Columns("DataContracte").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataSolucions.Columns("DataVenciment").Width = 100
        DataSolucions.Columns("DataVenciment").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataSolucions.Columns("DataVenciment").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataSolucions.Columns("Contracte").Width = 100
    End Sub
    Private Sub DataEmpreses_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataEmpreses.CellFormatting
        DataEmpreses.Columns("Nom").Width = 300
        DataEmpreses.Columns("CodiPostal").Width = 70
        DataEmpreses.Columns("CodiPostal").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataEmpreses.Columns("Pais").Width = 100
    End Sub

    Private Sub Btn_AfegirSolucio_Click(sender As Object, e As EventArgs) Handles Btn_AfegirSolucio.Click
        afegirSolucio()
    End Sub

    Private Sub Btn_EstatJustificacio_Click(sender As Object, e As EventArgs) Handles Btn_EstatJustificacio.Click

    End Sub
    'Esborra la solució seleccionada
    Private Sub esborrarSolucio(id As Integer)

        Dim resposta = MsgBox("¿Estàs segur que vols esborrar aquesta solució?", vbYesNo, "Esborrar solució")

        If resposta = vbYes Then
            Try
                Dim conexion As New SqlConnection(cadena)
                Dim Query As String
                Dim strCommand As SqlCommand
                Query = "DELETE FROM Solucions WHERE id=" & id
                strCommand = New SqlCommand(Query, conexion)
                conexion.Open()
                strCommand.ExecuteNonQuery()
                conexion.Close()
                OmpleSolucions(idEmpresaSeleccionada)
                MsgBox("S'ha esborrat correctament la solució",, "Esborrar solució")
            Catch ex As Exception
                MsgBox("No s'ha pogut esborrar la solució ",, "Esborrar solució")
            End Try
        End If

    End Sub
    'Afegeix o actualitza una solució
    Private Sub afegirSolucio()

        If ComprovaDadesSolucions() = False Then Exit Sub

        Dim conexion As New SqlConnection(cadena)
        Dim Query As String
        Dim strCommand As SqlCommand
        Dim idSolucio As Integer = CB_TipusSolucio.SelectedValue
        Dim NoAcordTxt As String = NoAcord.Text
        Dim DataContracteTxt As String
        Dim DataVencimentTxt As String
        Dim seleccio As Boolean

        seleccio = solucioSeleccionada
        DataContracteTxt = Format(DataContracte.Value, "MM/dd/yyyy")
        DataVencimentTxt = Format(DataContracte.Value.AddMonths(6), "MM/dd/yyyy")

        If (seleccio = True) Then

            Dim index As Integer = DataSolucions.CurrentCell.RowIndex
            Dim row As DataGridViewRow = DataSolucions.Rows(index)
            Dim idAfegir, Justificat As Integer
            idAfegir = row.Cells(0).Value
            If CheckEstaJustificat.Checked = True Then
                Justificat = 1
            Else
                Justificat = 0
            End If

            Query = "UPDATE Solucions SET
                            idSolucio=" & idSolucio & ", 
                            Contracte= " & StringDB(NoAcordTxt) & ",
                            DataContracte=" & StringDB(DataContracteTxt) & ",
                            DataVenciment=" & StringDB(DataVencimentTxt) & ", 
                            Justificat=" & Justificat & " 
                            WHERE Id=" & idAfegir

        Else
            Query = "INSERT INTO Solucions VALUES (" &
                                 idSolucio & "," &
                                 StringDB(NoAcordTxt) & "," &
                                 StringDB(DataContracteTxt) & "," &
                                 StringDB(DataVencimentTxt) & "," &
                                 idEmpresaSeleccionada & ",0)"

        End If

        Try
            strCommand = New SqlCommand(Query, conexion)
            conexion.Open()
            strCommand.ExecuteNonQuery()
            conexion.Close()
            OmpleSolucions(idEmpresaSeleccionada)

            If seleccio = True Then MsgBox("Solució modificada correctament",, "Modificar solució")
            If seleccio = False Then MsgBox("Solució introduida correctament",, "Introduir solució")
        Catch ex As Exception
            If seleccio = True Then MsgBox("No s'ha pogut modificar la solució",, "Modificar solució")
            If seleccio = False Then MsgBox("No s'ha pogut introduir la solució",, "Introduir solució")
        End Try
    End Sub
    'Comproba que s'hagin introduit totes les dades
    Private Function ComprovaDadesSolucions() As Boolean
        If CB_TipusSolucio.Text = "Selecciona un tipus de solució" Then
            CB_TipusSolucio.Focus()
            MsgBox("Has de introduir el tipus de solució")
            Return False
        End If
        If NoAcord.Text = "" Then
            NoAcord.Focus()
            MsgBox("Has de introduir el nº d'acord")
            Return False
        End If
        Return True
    End Function

End Class