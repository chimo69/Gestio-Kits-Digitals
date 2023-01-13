Imports System.Data.SQLite

Public Class Contractes
    Dim empresaSeleccionada, solucioSeleccionada As Boolean
    Dim idEmpresaSeleccionada, idSolucioSeleccionada As Integer
    Dim DT_TipusSolucions, DT_Solucions, DT_Empreses As New DataTable
    Dim vuelta As Integer = 0
    Private idEmpresa As Integer
    Private idSolucio As Integer

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        actualitzaTaula()

    End Sub

    Public Sub New(idEmpresa As Integer, idSolucio As Integer)
        Me.idEmpresa = idEmpresa
        Me.idSolucio = idSolucio

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        actualitzaTaula()
    End Sub

    Private Sub Btn_afegir_Click(sender As Object, e As EventArgs) Handles Btn_afegir.Click
        inserirEmpresa()
    End Sub

    'Actualitza la taula amb dades de la Base de dades
    Private Sub actualitzaTaula()

        Dim conexion As New SQLiteConnection()

        Try
            conexion = New SQLiteConnection(cadena)
            conexion.Open()

            If conexion.State = ConnectionState.Open Then
                Dim DA As New SQLiteDataAdapter("SELECT * FROM Empreses", conexion)
                DA.Fill(DT_Empreses)
                DataEmpreses.DataSource = DT_Empreses
            End If
            conexion.Close()

        Catch ex As Exception
            MsgBox("No s'ha pogut accedir a la base de dades",, "Error")
        End Try

    End Sub
    'Introdueix una empresa nova
    Private Sub inserirEmpresa()

        Dim conexion As New SQLiteConnection(cadena)
        Dim Query As String
        Dim strCommand As SQLiteCommand
        Dim empresaTxt As String = Empresa.Text
        Dim nifTxt As String = Nif.Text
        Dim direccioTxt As String = Direccio.Text
        Dim codiPostalTxt As String = CodiPostal.Text
        Dim ciutatTxt As String = Ciutat.Text
        Dim provinciaTxt As String = Provincia.Text
        Dim paisTxt As String = Pais.Text
        Dim seleccio As Boolean
        seleccio = empresaSeleccionada

        If comprovaDadesEmpresa() = False Then Exit Sub

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
            Query = "INSERT INTO Empreses (Nom,Nif,Direccio,CodiPostal,Ciutat,Provincia,Pais) VALUES (" &
                    StringDB(empresaTxt) & "," &
                    StringDB(nifTxt) & "," &
                    StringDB(direccioTxt) & "," &
                    StringDB(codiPostalTxt) & "," &
                    StringDB(ciutatTxt) & "," &
                    StringDB(provinciaTxt) & "," &
                    StringDB(paisTxt) & ")"
        End If

        Try
            strCommand = New SQLiteCommand(Query, conexion)
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
    Private Function comprovaDadesEmpresa() As Boolean
        If Empresa.Text = "" Then
            Empresa.Focus()
            MsgBox("Has de introduir el nom de l'empresa")
            Return False
        End If
        If Nif.Text = "" Then
            Nif.Focus()
            MsgBox("Has de introduir el NIF de l'empresa")
            Return False
        End If
        If Direccio.Text = "" Then
            Direccio.Focus()
            MsgBox("Has de introduir la direcció de l'empresa")
            Return False
        End If
        If CodiPostal.Text = "" Then
            CodiPostal.Focus()
            MsgBox("Has de introduir el Codi Postal de l'empresa")
            Return False
        End If
        If Ciutat.Text = "" Then
            Ciutat.Focus()
            MsgBox("Has de introduir la ciutat de l'empresa")
            Return False
        End If
        If Provincia.Text = "" Then
            Provincia.Focus()
            MsgBox("Has de introduir la provincia de l'empresa")
            Return False
        End If
        If Pais.Text = "" Then
            Pais.Focus()
            MsgBox("Has de introduir el pais de l'empresa")
            Return False
        End If
        Return True

    End Function
    'Esborra l'empresa seleccionada
    Private Sub esborrarEmpresa(id As Integer)

        Dim resposta = MsgBox("¿Estàs segur que vols esborrar aquesta empresa?", vbYesNo, "Esborrar empresa")

        If resposta = vbYes Then
            If ComprovaSiTeSolucions(id) = True Then
                MsgBox("No es pot esborrar una empresa amb solucions obertes", vbCritical, "Esborrar empresa")
                Exit Sub
            End If
            Try
                Dim conexion As New SQLiteConnection(cadena)
                Dim Query As String
                Dim strCommand As SQLiteCommand
                Query = "DELETE FROM Empreses WHERE id=" & id
                strCommand = New SQLiteCommand(Query, conexion)
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
    Private Function ComprovaSiTeSolucions(id As Integer) As Boolean
        Dim conexion As New SQLiteConnection(cadena)
        Dim Query As String
        Dim strCommand As SQLiteCommand

        Query = "SELECT * FROM Solucions WHERE iDEmpresa=" & id
        strCommand = New SQLiteCommand(Query, conexion)
        conexion.Open()
        Dim lector As SQLiteDataReader = strCommand.ExecuteReader

        If lector.HasRows Then
            Return True
        Else
            Return False
        End If

    End Function
    Private Sub Btn_esborrar_Click(sender As Object, e As EventArgs) Handles Btn_esborrar.Click
        Dim index As Integer = DataEmpreses.CurrentCell.RowIndex
        Dim row As DataGridViewRow = DataEmpreses.Rows(index)
        Dim idBorrar As Integer
        idBorrar = row.Cells(0).Value
        esborrarEmpresa(idBorrar)
    End Sub
    Private Sub btn_esborrarSeleccio_Click(sender As Object, e As EventArgs) Handles btn_esborrarSeleccio.Click
        EsborraCampsEmpresa()
    End Sub
    Private Sub EsborraCampsEmpresa()
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
        DataSolucions.DataSource = ""
        EstaLaSolucioSeleccionada(False)
    End Sub
    'Carrega els tipus de solucions per omplir el combobox
    Private Sub Contractes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New SQLiteConnection(cadena)
        conexion.Open()

        If conexion.State = ConnectionState.Open Then
            Dim DA As New SQLiteDataAdapter("SELECT * FROM TipusSolucions", conexion)
            DA.Fill(DT_TipusSolucions)
            CB_TipusSolucio.DataSource = DT_TipusSolucions
            CB_TipusSolucio.DisplayMember = "Nom"
            CB_TipusSolucio.ValueMember = "Id"
            CB_TipusSolucio.Text = "Selecciona un tipus de solució"
        End If
        conexion.Close()
    End Sub

    Private Sub DataContracte_ValueChanged(sender As Object, e As EventArgs) Handles DataContracte.ValueChanged
        Dim dies = DateDiff(DateInterval.Day, Now, DataContracte.Value.AddMonths(6))
        DataVenciment.Text = Format(DataContracte.Value.AddMonths(6).Date, "Short Date")
        DiesCaducitat.Text = dies.ToString

    End Sub
    Private Sub Btn_EsborrarSeleccioSolucio_Click(sender As Object, e As EventArgs) Handles Btn_EsborrarSeleccioSolucio.Click
        EsborrarCampsSolucio()
    End Sub
    'Carrega la taula amb les solucions trobades a la base de dades
    Private Sub OmpleSolucions(id As Integer)

        Dim conexion As New SQLiteConnection(cadena)

        Try

            conexion.Open()

            If conexion.State = ConnectionState.Open Then
                Dim DA As New SQLiteDataAdapter
                Dim comm As SQLiteCommand

                If CheckJustificat.Checked = True Then

                    comm = New SQLiteCommand("SELECT Solucions.Id,
                                          TipusSolucions.Nom,
                                          Solucions.Contracte,
                                          Solucions.DataContracte AS 'Dia contracte',
                                          Solucions.DataVenciment AS 'Dia venciment',
                                          Solucions.Justificat,                                              
                                          julianday(Solucions.DataVenciment) - julianday(date())  AS Dies,
                                          Justificacions.Percentatge AS '%',
                                          Solucions.Observacions  
                                          FROM Solucions
                                          INNER JOIN TipusSolucions ON TipusSolucions.Id=Solucions.idSolucio
                                          INNER JOIN Justificacions ON Solucions.Id=Justificacions.idSolucio  
                                          WHERE idEmpresa=" & id, conexion)
                Else

                    comm = New SQLiteCommand("SELECT Solucions.Id,
                                          TipusSolucions.Nom,
                                          Solucions.Contracte,
                                          Solucions.DataContracte AS 'Dia Contracte',
                                          Solucions.DataVenciment AS 'Dia Venciment',
                                          Solucions.Justificat,                                              
                                          julianday(Solucions.DataVenciment) - julianday(date())  AS Dies,
                                          Justificacions.Percentatge AS '%',
                                          Solucions.Observacions
                                          FROM Solucions
                                          INNER JOIN TipusSolucions On TipusSolucions.Id=Solucions.idSolucio
                                          INNER JOIN Justificacions ON Solucions.Id=Justificacions.idSolucio  
                                          WHERE (idEmpresa=" & id & " And Justificat='No')", conexion)
                End If

                DA.SelectCommand = comm
                DT_Solucions.Clear()
                DA.Fill(DT_Solucions)

                If DT_Solucions.Rows.Count > 0 Then
                    DataSolucions.DataSource = DT_Solucions
                    TitolSolucio.Text = "Escull una solució"
                Else
                    DataSolucions.DataSource = ""
                    TitolSolucio.Text = "Sense solucions"
                End If

            End If
            conexion.Close()
        Catch ex As Exception
            MsgBox("No s'ha pogut accedir a la base de dades", vbCritical, "Error")
        End Try

    End Sub

    Private Sub Btn_EsborrarSolucio_Click(sender As Object, e As EventArgs) Handles Btn_EsborrarSolucio.Click
        Dim index As Integer = DataSolucions.CurrentCell.RowIndex
        Dim row As DataGridViewRow = DataSolucions.Rows(index)
        Dim idBorrar As Integer
        idBorrar = row.Cells("Id").Value
        esborrarSolucio(idBorrar)
    End Sub

    Private Sub EsborrarCampsSolucio()

        NoAcord.Clear()
        DataContracte.Text = ""
        DataVenciment.Text = ""
        DiesCaducitat.Clear()
        solucioSeleccionada = False
        TitolSolucio.Clear()
        DataVenciment.Text = DataContracte.Value.Date.AddMonths(6)
        ProgressBar1.Value = 0
        TBObservacions.Clear()
        CheckEstaJustificat.Checked = False
        CB_TipusSolucio.Text = "Selecciona un tipus de solució"
        DataSolucions.ClearSelection()
        Dim dies = DateDiff(DateInterval.Day, Now, DataContracte.Value.AddMonths(6))
        DataVenciment.Text = Format(DataContracte.Value.AddMonths(6).Date, "Short Date")
        DiesCaducitat.Text = dies.ToString
        EstaLaSolucioSeleccionada(False)

    End Sub

    Private Sub Btn_AfegirSolucio_Click(sender As Object, e As EventArgs) Handles Btn_AfegirSolucio.Click
        afegirSolucio()
    End Sub

    Private Sub Btn_EstatJustificacio_Click(sender As Object, e As EventArgs) Handles Btn_EstatJustificacio.Click
        Dim EstatJustificacio As New EstatJustificacio(TitolEmpresa.Text, TitolSolucio.Text, idSolucioSeleccionada, CB_TipusSolucio.SelectedValue)
        EstatJustificacio.ShowDialog()
        OmpleSolucions(idEmpresaSeleccionada)
        EsborrarCampsSolucio()
    End Sub
    'Esborra la solució seleccionada
    Private Sub esborrarSolucio(id As Integer)

        Dim resposta = MsgBox("¿Estàs segur que vols esborrar aquesta solució?", vbYesNo, "Esborrar solució")

        If resposta = vbYes Then
            Try
                Dim conexion As New SQLiteConnection(cadena)
                Dim Query As String
                Dim strCommand As SQLiteCommand
                ' Esborrem solucio
                Query = "DELETE FROM Solucions WHERE id=" & id
                strCommand = New SQLiteCommand(Query, conexion)
                conexion.Open()
                strCommand.ExecuteNonQuery()

                'Esborrem Justificacions
                Query = "DELETE FROM Justificacions WHERE IdSolucio=" & id
                strCommand = New SQLiteCommand(Query, conexion)
                strCommand.ExecuteNonQuery()

                conexion.Close()
                OmpleSolucions(idEmpresaSeleccionada)
                MsgBox("S'ha esborrat correctament la solució",, "Esborrar solució")
            Catch ex As Exception
                MsgBox("No s'ha pogut esborrar la solució ",, "Esborrar solució")
            End Try
        End If

    End Sub
    'Donem format al llistat de empreses quan acaba de carregarse
    Private Sub DataEmpreses_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataEmpreses.DataBindingComplete

        'If vuelta = 3 Then
        EsborraCampsEmpresa()
        EstaLaSolucioSeleccionada(False)

            With DataEmpreses
                .Columns("CodiPostal").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("Id").Visible = False
            .AutoResizeColumns()
            .ClearSelection()
        End With

            For Each Fila As DataGridViewRow In DataEmpreses.Rows
                If Fila.Cells("Id").Value = idEmpresa Then
                    Fila.Selected = True
                    OmpleDadesEmpresa(Fila.Index)
                    Exit For
                End If
            Next
        'End If

        vuelta = vuelta + 1
    End Sub
    'Donem format al llistat de solucions quan acaba de carregarse
    Private Sub DataSolucions_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataSolucions.DataBindingComplete

        EsborrarCampsSolucio()
        EstaLaSolucioSeleccionada(False)

        With DataSolucions
            .Columns("Id").Visible = False
            .Columns("Justificat").Visible = False
            .Columns("Observacions").Visible = False
            .Columns("Dies").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Dia Contracte").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Dia Venciment").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("%").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .AutoResizeColumns()
        End With

        For Each Fila As DataGridViewRow In DataSolucions.Rows
            If Fila.Cells("Dies").Value <= 90 And Fila.Cells("Dies").Value >= 1 Then Fila.DefaultCellStyle.BackColor = Color.Orange
            If Fila.Cells("Dies").Value <= 0 Then Fila.DefaultCellStyle.BackColor = Color.Red
            If Fila.Cells("Justificat").Value = "Si" Then Fila.DefaultCellStyle.BackColor = Color.LightGreen
        Next

        For Each Fila As DataGridViewRow In DataSolucions.Rows
            If Fila.Cells("Id").Value = idSolucio Then
                Fila.Selected = True
                OmpleDadesSolucions(Fila.Index)
                Exit For
            End If
        Next

    End Sub
    'Afegeix o actualitza una solució
    Private Sub afegirSolucio()

        If ComprovaDadesSolucions() = False Then Exit Sub

        Dim conexion As New SQLiteConnection(cadena)
        Dim Query As String
        Dim strCommand As SQLiteCommand
        Dim idSolucio As Integer = CB_TipusSolucio.SelectedValue
        Dim NoAcordTxt As String = NoAcord.Text
        Dim Observacions As String = TBObservacions.Text
        Dim DataContracteTxt As String
        Dim DataVencimentTxt As String
        Dim seleccio As Boolean

        seleccio = solucioSeleccionada
        DataContracteTxt = Format(DataContracte.Value, "yyyy-MM-dd")
        DataVencimentTxt = Format(DataContracte.Value.AddMonths(6), "yyyy-MM-dd")

        Dim idAfegir As Integer
        Dim Justificat As String
        If CheckEstaJustificat.Checked = True Then
            Justificat = "'Si'"
        Else
            Justificat = "'No'"
        End If
        If (seleccio = True) Then

            Dim index As Integer = DataSolucions.CurrentCell.RowIndex
            Dim row As DataGridViewRow = DataSolucions.Rows(index)

            idAfegir = row.Cells(0).Value

            Query = "UPDATE Solucions SET
                            idSolucio=" & idSolucio & ", 
                            Contracte= " & StringDB(NoAcordTxt) & ",
                            DataContracte=" & StringDB(DataContracteTxt) & ",
                            DataVenciment=" & StringDB(DataVencimentTxt) & ", 
                            Justificat=" & Justificat & ",
                            Observacions=" & StringDB(Observacions) &
                            "WHERE Id=" & idAfegir

        Else
            Query = "INSERT INTO Solucions (IdSolucio,Contracte,DataContracte,DataVenciment,idEmpresa,Justificat,Observacions) VALUES (" &
                                 idSolucio & "," &
                                 StringDB(NoAcordTxt) & "," &
                                 StringDB(DataContracteTxt) & "," &
                                 StringDB(DataVencimentTxt) & "," &
                                 idEmpresaSeleccionada & "," &
                                 Justificat & "," &
                                 StringDB(Observacions) & ")"

        End If

        Try
            strCommand = New SQLiteCommand(Query, conexion)
            conexion.Open()
            strCommand.ExecuteNonQuery()
            conexion.Close()


            If seleccio = True Then
                MsgBox("Solució modificada correctament",, "Modificar solució")
            End If
            If seleccio = False Then
                insertaJustificacioBuida(idSolucio, idEmpresaSeleccionada)
            End If
            OmpleSolucions(idEmpresaSeleccionada)
        Catch ex As Exception

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
        If ProgressBar1.Value < 100 And CheckEstaJustificat.Checked = True Then
            If MsgBox("¿Estas segur que ho vols donar per justificat sense tenir el proces al 100%?", vbYesNo + vbExclamation, "Introduir solució") = vbYes Then
                Return True
            Else
                Return False
            End If
        End If
        Return True
    End Function
    'Inserta una justificacio buida
    Private Sub insertaJustificacioBuida(idSolucio As Integer, idEmpresa As Integer)
        Dim conexion As New SQLiteConnection(cadena)
        Dim Query As String
        Dim strCommand As SQLiteCommand
        Dim id As Integer
        Dim seleccio As Boolean
        seleccio = solucioSeleccionada

        Try
            Query = "SELECT * FROM Solucions WHERE idSolucio=" & idSolucio & " AND idEmpresa=" & idEmpresa
            strCommand = New SQLiteCommand(Query, conexion)
            conexion.Open()

            Dim lector As SQLiteDataReader = strCommand.ExecuteReader
            If lector.Read Then
                id = lector.GetValue("Id")
            End If
            lector.Close()

            Query = "INSERT INTO Justificacions (IdSolucio) VALUES (" & id & ")"

            strCommand = New SQLiteCommand(Query, conexion)
            strCommand.ExecuteNonQuery()

            conexion.Close()
            MsgBox("Solució introduida correctament",, "Introduir solució")

        Catch ex As Exception
            If seleccio = True Then MsgBox("No s'ha pogut modificar la solució",, "Modificar solució")
            If seleccio = False Then MsgBox("No s'ha pogut introduir la solució",, "Introduir solució")
        End Try
    End Sub
    Private Sub EstaLaSolucioSeleccionada(x As Boolean)
        If x = True Then
            Btn_EstatJustificacio.Enabled = True
            Btn_EsborrarSeleccioSolucio.Enabled = True
            Btn_EsborrarSolucio.Enabled = True
            Btn_AfegirSolucio.Text = "Modificar solució"
            Btn_AfegirSolucio.Enabled = True
        Else
            Btn_EstatJustificacio.Enabled = False
            Btn_EsborrarSeleccioSolucio.Enabled = False
            Btn_EsborrarSolucio.Enabled = False
            Btn_AfegirSolucio.Text = "Afegir solució"
            Btn_AfegirSolucio.Enabled = True
        End If
    End Sub
    'Modifica els camps quan la selecció d'empresa canvia
    Private Sub DataEmpreses_Click(sender As Object, e As EventArgs) Handles DataEmpreses.Click
        If DataEmpreses.SelectedRows.Count > 0 Then
            OmpleDadesEmpresa(DataEmpreses.CurrentRow.Index)
        End If
    End Sub
    'Modifica els camps quan la selecció de solucio canvia
    Private Sub DataSolucions_Click(Sender As Object, e As EventArgs) Handles DataSolucions.Click
        If DataSolucions.SelectedRows.Count > 0 Then
            OmpleDadesSolucions(DataSolucions.CurrentRow.Index)
            EstaLaSolucioSeleccionada(True)
        End If
    End Sub
    Private Sub CheckJustificat_Click(sender As Object, e As EventArgs) Handles CheckJustificat.Click
        OmpleSolucions(idEmpresaSeleccionada)
    End Sub
    Private Sub OmpleDadesEmpresa(Index As Integer)
        Dim row As DataGridViewRow = DataEmpreses.Rows(Index)

        TitolEmpresa.Text = row.Cells("Nom").Value
        Empresa.Text = row.Cells("Nom").Value
        Nif.Text = row.Cells("Nif").Value
        Direccio.Text = row.Cells("Direccio").Value
        CodiPostal.Text = row.Cells("CodiPostal").Value
        Ciutat.Text = row.Cells("Ciutat").Value
        Provincia.Text = row.Cells("Provincia").Value
        Pais.Text = row.Cells("Pais").Value
        Btn_afegir.Text = "Modificar empresa"
        empresaSeleccionada = True
        idEmpresa = 0

        DataEmpreses.ClearSelection()
        EsborraCampsEmpresa()
        EstaLaSolucioSeleccionada(False)

        If row.Cells("Id").Value <> idEmpresaSeleccionada Then
            idEmpresaSeleccionada = row.Cells("Id").Value
            OmpleSolucions(idEmpresaSeleccionada)
            EstaLaSolucioSeleccionada(False)
        End If

    End Sub
    Private Sub OmpleDadesSolucions(Index As Integer)

        Dim row As DataGridViewRow = DataSolucions.Rows(Index)

        EstaLaSolucioSeleccionada(True)
        CB_TipusSolucio.Text = row.Cells("Nom").Value
        NoAcord.Text = row.Cells("Contracte").Value
        DataContracte.Text = Format(row.Cells("Dia contracte").Value, "Short Date")
        DataVenciment.Text = Format(row.Cells("Dia venciment").Value, "Short Date")
        DiesCaducitat.Text = row.Cells("Dies").Value
        solucioSeleccionada = True
        idSolucioSeleccionada = row.Cells("Id").Value
        TitolSolucio.Text = row.Cells("Nom").Value
        TBObservacions.Text = row.Cells("Observacions").Value
        idSolucio = 0

        If row.Cells("Justificat").Value = "Si" Then
            CheckEstaJustificat.Checked = True
        Else
            CheckEstaJustificat.Checked = False
        End If

        ProgressBar1.Value = row.Cells("%").Value

    End Sub
End Class