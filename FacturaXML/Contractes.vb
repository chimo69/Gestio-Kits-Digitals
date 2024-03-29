﻿Imports System.Data.SQLite
Imports System.Threading

Public Class Contractes
    Private empresaSeleccionada, solucioSeleccionada As Boolean
    Private idEmpresaSeleccionada, idSolucioSeleccionada, segmentEmpresaSeleccionada, teContractes As Integer
    Private subvencioSolucioSeleccionada As Double
    Private DT_TipusSolucions, DT_Solucions, DT_Empreses As New DataTable
    Private idEmpresaRebuda, idSolucioRebuda As Integer
    Private DataVenciment As Date
    Private DataPresentacio As String

    Private Sub Contractes_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Debug.WriteLine("Activated Contractes")
    End Sub
    'Carrega els tipus de solucions per omplir el combobox
    Private Sub Contractes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ActualitzaEmpreses(TB_CercaEmpreses.Text)

        Dim conexion As New SQLiteConnection(cadena)
        Try

            conexion.Open()

            If conexion.State = ConnectionState.Open Then
                Dim DA As New SQLiteDataAdapter("SELECT * FROM TipusSolucions", conexion)
                DA.Fill(DT_TipusSolucions)
                CB_TipusSolucio.DataSource = DT_TipusSolucions
                CB_TipusSolucio.DisplayMember = "Nom"
                CB_TipusSolucio.ValueMember = "Id"
                CB_TipusSolucio.Text = "Selecciona un tipus de solució"
            End If

        Catch
            MsgBox("No s'ha pogut accedir a la base de dades", vbCritical, "Error")
        End Try

        conexion.Close()

        CheckJustificat.Checked = My.Settings.MostrarGestioAprovades
    End Sub
    Private Sub clickEmpreses(row As Integer)
        If DataEmpreses.SelectedRows.Count > 0 Then
            teContractes = DataEmpreses.Rows(row).Cells("Contractes").Value
            EsborraCampsEmpresa()
            OmpleDadesEmpresa(row)
            EstaLaEmpresaSeleccionada(True)
            MiraCaducitat()
        End If
    End Sub
    Private Sub clickSolucions(row As Integer)
        If DataSolucions.SelectedRows.Count > 0 Then
            OmpleDadesSolucions(row)
        End If
    End Sub
    Private Sub seleccionaFila(id As Integer, NoGrid As Integer)
        ' 1 Data Empreses
        ' 2 Data Solucions

        Select Case NoGrid
            Case 1
                For Each Fila As DataGridViewRow In DataEmpreses.Rows
                    If Fila.Cells("Id").Value = id Then
                        Fila.Selected = True
                        clickEmpreses(Fila.Index)
                        Exit For
                    End If
                Next
                idEmpresaSeleccionadaUtils = 0
            Case 2
                For Each Fila As DataGridViewRow In DataSolucions.Rows
                    If Fila.Cells("Id").Value = id Then
                        Fila.Selected = True
                        clickSolucions(Fila.Index)
                        Exit For
                    End If
                Next
                idSolucioSeleccionadaUtils = 0
        End Select

    End Sub

    Private Sub Btn_afegir_Click(sender As Object, e As EventArgs) Handles Btn_afegir.Click
        InserirEmpresa(idEmpresaSeleccionada)
    End Sub

    'Actualitza la taula amb dades de la Base de dades
    Private Sub ActualitzaEmpreses(TextABuscar As String)


        Dim conexion As New SQLiteConnection(cadena)
        Try
            conexion.Open()
            Dim DA As New SQLiteDataAdapter
            Dim comm As SQLiteCommand

            If conexion.State = ConnectionState.Open Then

                If TextABuscar = "" Then
                    comm = New SQLiteCommand("SELECT id,
                                nom,
                                nif,
                                direccio,
                                codipostal,
                                Ciutat,
                                provincia,
                                pais,
                                segment,                                                        
                                strftime('%d-%m-%Y',DataConcessio) AS 'Concessió',
                                CodiBono,
                                Import,
                                Contractes
                                FROM Empreses
                                ORDER BY nom ASC", conexion)
                Else
                    comm = New SQLiteCommand("SELECT id,
                                nom,
                                nif,
                                direccio,
                                codipostal,
                                Ciutat,
                                provincia,
                                pais,
                                segment,                                                        
                                strftime('%d-%m-%Y',DataConcessio) AS 'Concessió',
                                CodiBono,
                                Import,
                                Contractes
                                FROM Empreses
                                WHERE nom LIKE '%" & TextABuscar & "%' 
                                ORDER BY nom ASC", conexion)

                End If

                DA.SelectCommand = comm
                DT_Empreses.Clear()
                DA.Fill(DT_Empreses)

                If DT_Empreses.Rows.Count > 0 Then
                    DataEmpreses.DataSource = DT_Empreses
                    TitolEmpresa.Text = "SELECCIONA EMPRESA"
                Else
                    DataEmpreses.DataSource = Nothing
                    TitolSolucio.Text = "SENSE EMPRESES"
                End If

            End If
        Catch ex As Exception
            MsgBox("No s'ha pogut accedir a la base de dades", vbCritical, "Error")
        End Try

        conexion.Close()

    End Sub
    'Introdueix una empresa nova
    Private Sub InserirEmpresa(IdEmpresa As Integer)

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
        Dim codiBonoTxt As String = TB_CodiBono.Text
        Dim dataConcessioTxt As String
        Dim dataFiConcessioTxt As String
        Dim seleccio As Boolean
        Dim segment As Integer
        Dim import As Double
        seleccio = empresaSeleccionada

        If RB_Segment1.Checked = True Then segment = 1
        If RB_Segment2.Checked = True Then segment = 2
        If RB_Segment3.Checked = True Then segment = 3

        If TB_ImportBono.Text = "" Then
            import = 0
        Else
            import = CDbl(TB_ImportBono.Text)
        End If

        If CB_DataConcessio.Checked = True Then
            dataConcessioTxt = Format(DataConcessio.Value, "yyyy-MM-dd")
            dataFiConcessioTxt = Format(DataConcessio.Value.AddMonths(My.Settings.MesosAprovacio), "yyyy-MM-dd")
        Else
            dataConcessioTxt = ""
            dataFiConcessioTxt = ""
        End If
        If ComprovaDadesEmpresa() = False Then Exit Sub

        'Si hi ha una empresa seleccionada fara Update sino Insert
        If (seleccio = True) Then

            Query = "UPDATE Empreses SET 
                     Nom=" & StringDB(empresaTxt) &
                     ",Nif=" & StringDB(nifTxt) &
                     ",DIreccio=" & StringDB(direccioTxt) &
                     ",CodiPostal=" & StringDB(codiPostalTxt) &
                     ",Ciutat=" & StringDB(ciutatTxt) &
                     ",Provincia=" & StringDB(provinciaTxt) &
                     ",Pais=" & StringDB(paisTxt) &
                     ",Segment=" & segment &
                     ",DataConcessio=" & StringDB(dataConcessioTxt) &
                     ",DataCaducitat=" & StringDB(dataFiConcessioTxt) &
                     ",Import=" & CDbl(TB_ImportBono.Text) &
                     " WHERE Id=" & IdEmpresa
        Else
            Query = "INSERT INTO Empreses (Nom,Nif,Direccio,CodiPostal,Ciutat,Provincia,Pais,Segment,DataConcessio,DataCaducitat,CodiBono,Import) VALUES (" &
                    StringDB(empresaTxt) & "," &
                    StringDB(nifTxt) & "," &
                    StringDB(direccioTxt) & "," &
                    StringDB(codiPostalTxt) & "," &
                    StringDB(ciutatTxt) & "," &
                    StringDB(provinciaTxt) & "," &
                    StringDB(paisTxt) & "," &
                    segment & "," &
                    StringDB(dataConcessioTxt) & "," &
                    StringDB(dataFiConcessioTxt) & "," &
                    StringDB(codiBonoTxt) & "," &
                    import & ")"
        End If


        Try
            strCommand = New SQLiteCommand(Query, conexion)
            conexion.Open()

            If conexion.State = ConnectionState.Open Then
                strCommand.ExecuteNonQuery()
            End If

            ActualitzaEmpreses(TB_CercaEmpreses.Text)

            If seleccio = True Then MsgBox("Empresa modificada correctament", , "Modificar empresa")
            If seleccio = False Then MsgBox("Empresa introduida correctament", , "Introduir empresa")
        Catch ex As Exception
            If seleccio = True Then MsgBox("No s'ha pogut modificar l'empresa", vbCritical, "Modificar empresa")
            If seleccio = False Then MsgBox("No s'ha pogut introduir l'empresa", vbCritical, "Introduir empresa")
        End Try
        conexion.Close()

        EsborraCampsEmpresa()
        EsborrarCampsSolucio()

    End Sub
    'Comprova que no faltin dades per introduir
    Private Function ComprovaDadesEmpresa() As Boolean
        If Empresa.Text = "" Then
            Empresa.Focus()
            MsgBox("Has de introduir el nom de l'empresa", vbCritical, "Dades de empresa")
            Return False
        End If
        If Nif.Text = "" Then
            Nif.Focus()
            MsgBox("Has de introduir el NIF de l'empresa", vbCritical, "Dades de empresa")
            Return False
        End If
        If Direccio.Text = "" Then
            Direccio.Focus()
            MsgBox("Has de introduir la direcció de l'empresa", vbCritical, "Dades de empresa")
            Return False
        End If
        If CodiPostal.Text = "" Then
            CodiPostal.Focus()
            MsgBox("Has de introduir el Codi Postal de l'empresa", vbCritical, "Dades de empresa")
            Return False
        End If
        If Ciutat.Text = "" Then
            Ciutat.Focus()
            MsgBox("Has de introduir la ciutat de l'empresa", vbCritical, "Dades de empresa")
            Return False
        End If
        If Provincia.Text = "" Then
            Provincia.Focus()
            MsgBox("Has de introduir la provincia de l'empresa", vbCritical, "Dades de empresa")
            Return False
        End If
        If Pais.Text = "" Then
            Pais.Focus()
            MsgBox("Has de introduir el pais de l'empresa", vbCritical, "Dades de empresa")
            Return False
        End If

        If RB_Segment1.Checked = False And RB_Segment2.Checked = False And RB_Segment3.Checked = False Then
            MsgBox("Has de escollir el segment de l'empresa", vbCritical, "Dades de empresa")
            Return False
        End If

        Return True

    End Function
    'Esborra l'empresa seleccionada
    Private Sub EsborrarEmpresa(id As Integer)

        Dim resposta = MsgBox("¿Estàs segur que vols esborrar aquesta empresa?", vbYesNo, "Esborrar empresa")
        Dim conexion As New SQLiteConnection(cadena)

        If resposta = vbYes Then
            If ComprovaSiTeSolucions(id) = True Then
                MsgBox("No es pot esborrar una empresa amb solucions obertes", vbCritical, "Esborrar empresa")
                Exit Sub
            End If

            Try
                conexion.Open()
                If conexion.State = ConnectionState.Open Then
                    Dim Query As String
                    Dim strCommand As SQLiteCommand
                    Query = "DELETE FROM Empreses WHERE id=" & id
                    strCommand = New SQLiteCommand(Query, conexion)
                    strCommand.ExecuteNonQuery()
                End If
                ActualitzaEmpreses(TB_CercaEmpreses.Text)
                MsgBox("S'ha esborrat correctament l'empresa",, "Esborrar l'empresa")
            Catch ex As Exception
                MsgBox("No s'ha pogut esborrar l'empresa", vbCritical, "Esborrar l'empresa")
            End Try
        End If

        conexion.Close()

    End Sub
    'Comprova si la empresa que es vol esborrar te solucions obertes
    Private Shared Function ComprovaSiTeSolucions(id As Integer) As Boolean
        Dim conexion As New SQLiteConnection(cadena)
        Dim Query As String
        Dim strCommand As SQLiteCommand

        Try
            conexion.Open()

            If conexion.State = ConnectionState.Open Then
                Query = "SELECT * FROM Solucions WHERE iDEmpresa=" & id
                strCommand = New SQLiteCommand(Query, conexion)

                Dim lector As SQLiteDataReader = strCommand.ExecuteReader

                If lector.HasRows Then
                    Return True
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
            MsgBox("No s'ha pogut accedir a la base de dades", vbCritical, "Esborrar l'empresa")
        End Try
        conexion.Close()
        Return True
    End Function
    Private Sub Btn_esborrarEmpresa_Click(sender As Object, e As EventArgs) Handles Btn_esborrarEmpresa.Click
        Dim index As Integer = DataEmpreses.CurrentCell.RowIndex
        Dim row As DataGridViewRow = DataEmpreses.Rows(index)
        Dim idBorrar As Integer = row.Cells("Id").Value
        EsborrarEmpresa(idBorrar)
    End Sub
    Private Sub Btn_EsborrarSeleccioEmpresa_Click(sender As Object, e As EventArgs) Handles btn_EsborrarSeleccioEmpresa.Click
        DataEmpreses.ClearSelection()
        EsborraCampsEmpresa()
        EstaLaEmpresaSeleccionada(False)
    End Sub
    'Esborra tots els camps d'empresa
    Private Sub EsborraCampsEmpresa()

        Empresa.Clear()
        Nif.Clear()
        Direccio.Clear()
        CodiPostal.Clear()
        Ciutat.Clear()
        Provincia.Clear()
        Pais.Clear()
        TB_CodiBono.Clear()
        TB_ImportBono.Clear()
        TB_CaducitatConcessio.Clear()
        Btn_afegir.Text = "Afegir empresa"
        TitolEmpresa.Text = "Selecciona Empresa"
        empresaSeleccionada = False
        idEmpresaSeleccionada = 0
        DataSolucions.DataSource = Nothing
        CB_DataConcessio.Checked = False
        CB_DataAprovacio.Checked = False
        DataConcessioOK.Visible = False
        DataFiConcessio.Visible = False
        DataConcessio.Visible = False
        DataAprovacio.Visible = False
        TitolAprovacio.Visible = False
        EstaLaSolucioSeleccionada(False)
        EsborrarCampsSolucio()

        RB_Segment1.Checked = False
        RB_Segment2.Checked = False
        RB_Segment3.Checked = False

    End Sub
    Private Sub Btn_EsborrarSeleccioSolucio_Click(sender As Object, e As EventArgs) Handles Btn_EsborrarSeleccioSolucio.Click
        EsborrarCampsSolucio()
    End Sub
    'Carrega la taula amb les solucions trobades a la base de dades
    Private Sub OmpleSolucions(id As Integer)

        Dim conexion As New SQLiteConnection(cadena)
        Dim concedit, consumit As Double

        Try

            conexion.Open()

            If conexion.State = ConnectionState.Open Then
                Dim DA As New SQLiteDataAdapter
                Dim comm As SQLiteCommand

                If CheckJustificat.Checked = True Then

                    comm = New SQLiteCommand("SELECT Solucions.Id,
                                          Solucions.IdSolucio,
                                          TipusSolucions.Nom,
                                          Solucions.Contracte,                                          
                                          strftime('%d-%m-%Y',DataContracte) AS 'Dia contracte',                                          
                                          strftime('%d-%m-%Y',Solucions.DataFactura) AS 'Dia factura',
                                          Solucions.DataPagament,
                                          strftime('%d-%m-%Y',Solucions.DataVenciment) AS 'Dia venciment',                                          
                                          Solucions.Justificat,
                                          Solucions.SegonJustificat,
                                          Solucions.PrimerPagament,
                                          Solucions.SegonPagament,
                                          julianday(Solucions.DataVenciment) - julianday(date())  AS Dies,
                                          Justificacions.Percentatge AS '%',
                                          Justificacions.Estat,
                                          Justificacions.DataPresentacio,
                                          Justificacions.Subvencio, 
                                          Solucions.Observacions,
                                          Solucions.Quantitat   
                                          FROM Solucions
                                          INNER JOIN TipusSolucions ON TipusSolucions.Id=Solucions.idSolucio
                                          INNER JOIN Justificacions ON Solucions.Id=Justificacions.idSolucio  
                                          WHERE idEmpresa=" & id, conexion)
                Else

                    comm = New SQLiteCommand("SELECT Solucions.Id,
                                          Solucions.IdSolucio,
                                          TipusSolucions.Nom,
                                          Solucions.Contracte,                                          
                                          Solucions.DataContracte AS 'Dia contracte',
                                          Solucions.DataFactura AS 'Dia factura',
                                          Solucions.DataPagament,
                                          Solucions.DataVenciment AS 'Dia venciment',
                                          Solucions.Justificat,
                                          Solucions.SegonJustificat,
                                          Solucions.PrimerPagament,
                                          Solucions.SegonPagament,  
                                          julianday(Solucions.DataVenciment) - julianday(date())  AS Dies,
                                          Justificacions.Percentatge AS '%',
                                          Justificacions.Estat,
                                          Justificacions.DataPresentacio,
                                          Justificacions.Subvencio, 
                                          Solucions.Observacions,
                                          Solucions.Quantitat 
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
                    TitolSolucio.Text = "SELECCIONA SOLUCIÓ"
                Else
                    DataSolucions.DataSource = Nothing
                    TitolSolucio.Text = "SENSE SOLUCIONS"
                End If

            End If

            'Using conexion As New SQLiteConnection(cadena)

            'conexion.Open()

            If conexion.State = ConnectionState.Open Then
                Dim Sql As String = "SELECT sum(Justificacions.Subvencio) as Consumit                                          
                                          FROM Solucions
                                          INNER JOIN TipusSolucions ON TipusSolucions.Id=Solucions.idSolucio
                                          INNER JOIN Justificacions ON Solucions.Id=Justificacions.idSolucio  
                                          WHERE idEmpresa=" & id

                Dim strCommand As SQLiteCommand = New SQLiteCommand(Sql, conexion)
                Dim lector As SQLiteDataReader = strCommand.ExecuteReader

                If lector.Read Then
                    If Not IsDBNull(lector.GetValue("Consumit")) Then
                        consumit = lector.GetValue("Consumit")
                    Else
                        consumit = 0
                    End If

                    concedit = TB_ImportBono.Text
                    TB_BonusRestant.Text = (concedit - consumit).ToString
                End If
                lector.Close()

            End If


        Catch ex As Exception
            MsgBox("No s'ha pogut accedir a la base de dades" & ex.Message, vbCritical, "Error")
        End Try
        conexion.Close()
    End Sub

    Private Sub Btn_EsborrarSolucio_Click(sender As Object, e As EventArgs) Handles Btn_EsborrarSolucio.Click
        Dim index As Integer = DataSolucions.CurrentCell.RowIndex
        Dim row As DataGridViewRow = DataSolucions.Rows(index)
        Dim idBorrar As Integer
        idBorrar = row.Cells("Id").Value
        EsborrarSolucio(idBorrar)
    End Sub
    'Esborra tots els camps de la solució
    Private Sub EsborrarCampsSolucio()

        'Linea Contracte
        CB_DataContracte.Checked = False
        DataContracteOK.Visible = False

        'Linea Factura
        CB_DataFactura.Checked = False
        DataFacturaOK.Visible = False

        'Linea Pagament
        CB_DataPagamentIVA.Checked = False
        DataPagamentOK.Visible = False

        InfoSubvencio.Clear()
        InfoSubvencioReal.Clear()
        NoAcord.Clear()
        DiesCaducitat.Clear()
        DataCaducitat.Clear()
        solucioSeleccionada = False
        TitolSolucio.Clear()
        ProgressBar1.Value = 0
        TBObservacions.Clear()
        CheckEstaJustificat.Checked = False
        CheckEstaJustificat2.Checked = False
        CB_TipusSolucio.Text = "Selecciona un tipus de solució"
        DataSolucions.ClearSelection()
        infoMax.Visible = False
        InfoVariable.Visible = False
        InfoVariableNum.Visible = False
        InfoVariableNum.Value = 1
        CB_PrimerPagament.Checked = False
        CB_SegonPagament.Checked = False
        EstaLaSolucioSeleccionada(False)
        InfoSubvencio.Clear()

        ' Formatejem estats
        TB_Proces0.Enabled = False
        TB_Proces0.BackColor = SystemColors.Control
        TB_Proces1.Enabled = False
        TB_Proces1.BackColor = SystemColors.Control
        TB_Proces2.Enabled = False
        TB_Proces2.BackColor = SystemColors.Control
        TB_Proces3.Enabled = False
        TB_Proces3.BackColor = SystemColors.Control
        TB_Proces4.Enabled = False
        TB_Proces4.BackColor = SystemColors.Control
        TB_Proces5.Enabled = False
        TB_Proces5.BackColor = SystemColors.Control
        TB_Proces6.Enabled = False
        TB_Proces6.BackColor = SystemColors.Control
        TB_Proces7.Enabled = False
        TB_Proces7.BackColor = SystemColors.Control
        TB_Proces8.Enabled = False
        TB_Proces8.BackColor = SystemColors.Control

    End Sub

    Private Sub Btn_AfegirSolucio_Click(sender As Object, e As EventArgs) Handles Btn_AfegirSolucio.Click
        AfegirSolucio(idSolucioSeleccionada)
    End Sub

    Private Sub Btn_EstatJustificacio_Click(sender As Object, e As EventArgs) Handles Btn_EstatJustificacio.Click
        Dim EstatJustificacio As New EstatJustificacio(TitolEmpresa.Text, TitolSolucio.Text, idEmpresaSeleccionada, idSolucioSeleccionada, CB_TipusSolucio.SelectedValue, InfoSubvencio.Text)
        OpenSubFormDialog(EstatJustificacio)
        OmpleSolucions(idEmpresaSeleccionada)
        seleccionaFila(idSolucioSeleccionada, 2)
    End Sub
    'Esborra la solució seleccionada
    Private Sub EsborrarSolucio(id As Integer)

        Dim resposta = MsgBox("¿Estàs segur que vols esborrar aquesta solució?", vbYesNo + vbQuestion, "Esborrar solució")
        Dim conexion As New SQLiteConnection(cadena)

        If resposta = vbYes Then
            Try
                conexion.Open()
                If conexion.State = ConnectionState.Open Then
                    Dim Query As String
                    Dim strCommand As SQLiteCommand
                    ' Esborrem solucio
                    Query = "DELETE FROM Solucions WHERE id=" & id
                    strCommand = New SQLiteCommand(Query, conexion)

                    strCommand.ExecuteNonQuery()

                    'Esborrem Justificacions
                    Query = "DELETE FROM Justificacions WHERE IdSolucio=" & id
                    strCommand = New SQLiteCommand(Query, conexion)
                    strCommand.ExecuteNonQuery()
                End If

                OmpleSolucions(idEmpresaSeleccionada)
                MsgBox("S'ha esborrat correctament la solució", , "Esborrar solució")
            Catch ex As Exception
                MsgBox("No s'ha pogut esborrar la solució ", vbCritical, "Esborrar solució")
            End Try
            conexion.Close()
        End If

    End Sub

    'Donem format al llistat de empreses quan acaba de carregarse
    Private Sub DataEmpreses_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataEmpreses.DataBindingComplete
        Debug.WriteLine("DataBindingComplete de Empreses")
        EstaLaSolucioSeleccionada(False)
        EstaLaEmpresaSeleccionada(False)

        With DataEmpreses
            .Columns("CodiPostal").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Segment").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Concessió").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Id").Visible = False
            .Columns("Direccio").Visible = False
            .Columns("Pais").Visible = False
            .Columns("CodiPostal").Visible = False
            .Columns("CodiBono").Visible = False
            .Columns("Import").Visible = False
            .Columns("Contractes").Visible = False
            .AutoResizeColumns()
            .ClearSelection()
        End With

    End Sub
    'Donem format al llistat de solucions quan acaba de carregarse
    Private Sub DataSolucions_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataSolucions.DataBindingComplete
        Debug.WriteLine("DataBindingComplete de Solucions")
        EsborrarCampsSolucio()
        EstaLaSolucioSeleccionada(False)

        With DataSolucions
            .Columns("Id").Visible = False
            .Columns("IdSolucio").Visible = False
            .Columns("Justificat").Visible = False
            .Columns("SegonJustificat").Visible = False
            .Columns("Observacions").Visible = False
            .Columns("DataPagament").Visible = False
            .Columns("Quantitat").Visible = False
            .Columns("PrimerPagament").Visible = False
            .Columns("SegonPagament").Visible = False
            .Columns("Estat").Visible = False
            .Columns("DataPresentacio").Visible = False
            .Columns("Subvencio").Visible = False
            .Columns("Dies").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Dia contracte").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Dia factura").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Dia venciment").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("%").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Nom").Width = 150
            .Columns("Contracte").Width = 100
            .Columns("%").Width = 30
            .Columns("Dies").Width = 70
            .ClearSelection()
        End With

        For Each Fila As DataGridViewRow In DataSolucions.Rows
            If Fila.Cells("Dies").Value <= 90 And Fila.Cells("Dies").Value >= 1 Then Fila.DefaultCellStyle.BackColor = Color.Orange
            If Fila.Cells("Dies").Value <= 0 Then Fila.DefaultCellStyle.BackColor = Color.Red
            If Fila.Cells("Justificat").Value = "Si" Then Fila.DefaultCellStyle.BackColor = Color.LightGreen
            If Fila.Cells("Estat").Value = "3" Then Fila.DefaultCellStyle.BackColor = blau
            If Fila.Cells("Estat").Value = "1" Then Fila.DefaultCellStyle.BackColor = blau
            If Fila.Cells("Estat").Value = "4" Then Fila.DefaultCellStyle.BackColor = blau
            If Fila.Cells("Estat").Value = "7" Then Fila.DefaultCellStyle.BackColor = blau
        Next

    End Sub
    'Afegeix o actualitza una solució
    Private Sub AfegirSolucio(idSolucio As Integer)

        If ComprovaDadesSolucions() = False Then Exit Sub

        Dim conexion As New SQLiteConnection(cadena)
        Dim Query As String
        Dim strCommand As SQLiteCommand
        Dim idTipusSolucio As Integer = CB_TipusSolucio.SelectedValue
        Dim NoAcordTxt As String = NoAcord.Text
        Dim Observacions As String = TBObservacions.Text
        Dim DataPagamentTxt, DataFacturaTxt, DataContracteTxt, DataVencimentTxt As String
        Dim seleccio As Boolean
        Dim Justificat, Justificat2 As String
        Dim checks As Integer = 0

        seleccio = solucioSeleccionada

        If CB_DataContracte.Checked = True Then
            DataContracteTxt = Format(DataContracte.Value, "yyyy-MM-dd")
        Else
            DataContracteTxt = ""
            checks += 1
        End If

        If CB_DataFactura.Checked = True Then
            DataFacturaTxt = Format(DataFactura.Value, "yyyy-MM-dd")
        Else
            DataFacturaTxt = ""
            checks += 1
        End If

        If CB_DataPagamentIVA.Checked = True Then
            DataPagamentTxt = Format(DataPagament.Value, "yyyy-MM-dd")
        Else
            DataPagamentTxt = ""
            checks += 1
        End If

        If checks <> 3 Then
            DataVencimentTxt = Format(DataVenciment, "yyyy-MM-dd")
        Else
            DataVencimentTxt = Format(Date.Now.AddYears(1000), "yyyy-MM-dd")
        End If
        If CheckEstaJustificat.Checked = True Then
            Justificat = "'Si'"
        Else
            Justificat = "'No'"
        End If
        If CheckEstaJustificat2.Checked = True Then
            Justificat2 = "'Si'"
        Else
            Justificat2 = "'No'"
        End If

        If (seleccio = True) Then

            Query = "UPDATE Solucions SET
                            idSolucio=" & idTipusSolucio & ", 
                            Contracte= " & StringDB(NoAcordTxt) & ",                            
                            DataContracte=" & StringDB(DataContracteTxt) & ",
                            DataFactura= " & StringDB(DataFacturaTxt) & ",
                            DataPagament= " & StringDB(DataPagamentTxt) & ",
                            DataVenciment=" & StringDB(DataVencimentTxt) & ", 
                            Justificat=" & Justificat & ",
                            SegonJustificat=" & Justificat2 & ",
                            PrimerPagament=" & CB_PrimerPagament.Checked & ",
                            SegonPagament=" & CB_SegonPagament.Checked & ",
                            Observacions=" & StringDB(Observacions) & ",
                            Quantitat=" & InfoVariableNum.Value &
                            " WHERE Id=" & idSolucio

        Else
            Query = "INSERT INTO Solucions (IdSolucio,Contracte,DataContracte,DataFactura,DataPagament,DataVenciment,idEmpresa,Justificat,PrimerPagament,SegonPagament,Observacions,Quantitat) VALUES (" &
                                 idTipusSolucio & "," &
                                 StringDB(NoAcordTxt) & "," &
                                 StringDB(DataContracteTxt) & "," &
                                 StringDB(DataFacturaTxt) & "," &
                                 StringDB(DataPagamentTxt) & "," &
                                 StringDB(DataVencimentTxt) & "," &
                                 idEmpresaSeleccionada & "," &
                                 Justificat & "," &
                                 Justificat2 & "," &
                                 CB_PrimerPagament.Checked & "," &
                                 CB_SegonPagament.Checked & "," &
                                 StringDB(Observacions) & "," &
                                 InfoVariableNum.Value & ")"

        End If

        Try
            conexion.Open()
            If conexion.State = ConnectionState.Open Then
                strCommand = New SQLiteCommand(Query, conexion)
                strCommand.ExecuteNonQuery()
            End If

            Query = "UPDATE Empreses SET Contractes=1 WHERE id=" & idEmpresaSeleccionada

            If conexion.State = ConnectionState.Open Then
                strCommand = New SQLiteCommand(Query, conexion)
                strCommand.ExecuteNonQuery()
            End If

            If seleccio = True Then
                MsgBox("Solució modificada correctament",, "Modificar solució")
            End If
            If seleccio = False Then
                InsertaJustificacioBuida(idTipusSolucio, idEmpresaSeleccionada)
            End If
            OmpleSolucions(idEmpresaSeleccionada)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conexion.Close()

    End Sub
    'Comproba que s'hagin introduit totes les dades
    Private Function ComprovaDadesSolucions() As Boolean
        If CB_TipusSolucio.Text = "Selecciona un tipus de solució" Then
            CB_TipusSolucio.Focus()
            MsgBox("Has de introduir el tipus de solució", vbCritical, "Dades de la solució")
            Return False
        End If
        If NoAcord.Text = "" Then
            NoAcord.Focus()
            MsgBox("Has de introduir el nº d'acord", vbCritical, "Dades de la solució")
            Return False
        End If
        If ProgressBar1.Value < 100 And CheckEstaJustificat.Checked = True Then
            If MsgBox("¿Estas segur que ho vols donar per justificat sense tenir el proces al 100%?", vbYesNo + vbQuestion, "Introduir solució") = vbYes Then
                Return True
            Else
                Return False
            End If
        End If
        Return True
    End Function
    'Inserta una justificacio buida
    Private Sub InsertaJustificacioBuida(idSolucio As Integer, idEmpresa As Integer)
        Dim conexion As New SQLiteConnection(cadena)
        Dim Query As String
        Dim strCommand As SQLiteCommand
        Dim id As Integer
        Dim seleccio As Boolean
        seleccio = solucioSeleccionada

        Try
            conexion.Open()

            If conexion.State = ConnectionState.Open Then
                Query = "SELECT * FROM Solucions WHERE idSolucio=" & idSolucio & " AND idEmpresa=" & idEmpresa
                strCommand = New SQLiteCommand(Query, conexion)

                Dim lector As SQLiteDataReader = strCommand.ExecuteReader
                If lector.Read Then
                    id = lector.GetValue("Id")
                End If
                lector.Close()

                Query = "INSERT INTO Justificacions (IdSolucio,Subvencio) VALUES (" & id & "," & InfoSubvencio.Text & ")"

                strCommand = New SQLiteCommand(Query, conexion)
                strCommand.ExecuteNonQuery()

                MsgBox("Solució introduida correctament",, "Introduir solució")
            End If
        Catch ex As Exception
            If seleccio = True Then MsgBox("No s'ha pogut modificar la solució", vbCritical, "Modificar solució")
            If seleccio = False Then MsgBox("No s'ha pogut introduir la solució", vbCritical, "Introduir solució")
        End Try

        conexion.Close()
    End Sub
    'Activa o desactiva els camps de la solució depenent de si hi una seleccionada
    Private Sub EstaLaSolucioSeleccionada(x As Boolean)
        If x = True Then
            Btn_EstatJustificacio.Enabled = True
            Btn_EsborrarSeleccioSolucio.Enabled = True
            Btn_EsborrarSolucio.Enabled = True
            Btn_AfegirSolucio.Text = "Modificar solució"
            TBObservacions.Enabled = True
            solucioSeleccionada = True

        Else
            Btn_EstatJustificacio.Enabled = False
            Btn_AfegirSolucio.Text = "Afegir solució"
            Btn_AfegirSolucio.Enabled = True
            Btn_EsborrarSolucio.Enabled = False
            TBObservacions.Enabled = True
            solucioSeleccionada = False
        End If
    End Sub
    Private Sub EstaLaEmpresaSeleccionada(x As Boolean)
        If x = True Then
            CB_TipusSolucio.Enabled = True
            NoAcord.Enabled = True

            CB_DataPagamentIVA.Enabled = False
            CheckEstaJustificat.Enabled = True
            CheckEstaJustificat2.Enabled = True
            TBObservacions.Enabled = True
            Btn_AfegirSolucio.Enabled = True
            Btn_esborrarEmpresa.Enabled = True
        Else
            CB_TipusSolucio.Enabled = False
            NoAcord.Enabled = False

            CB_DataPagamentIVA.Enabled = False
            CheckEstaJustificat.Enabled = False
            CheckEstaJustificat2.Enabled = False
            Btn_EstatJustificacio.Enabled = False
            Btn_EsborrarSeleccioSolucio.Enabled = False
            Btn_AfegirSolucio.Enabled = False
            Btn_EsborrarSolucio.Enabled = False
            TBObservacions.Enabled = False
            Btn_esborrarEmpresa.Enabled = False
            infoMax.Visible = False
            InfoVariable.Visible = False
            InfoVariableNum.Visible = False
        End If
    End Sub
    'Modifica els camps quan la selecció d'empresa canvia
    Private Sub DataEmpreses_Click(sender As Object, e As EventArgs) Handles DataEmpreses.Click
        MostraDadesEmpresaSeleccionada()
    End Sub

    Private Sub MostraDadesEmpresaSeleccionada()
        If DataEmpreses.SelectedRows.Count > 0 Then
            teContractes = DataEmpreses.CurrentRow.Cells("Contractes").Value
            EsborraCampsEmpresa()
            OmpleDadesEmpresa(DataEmpreses.CurrentRow.Index)
            EstaLaEmpresaSeleccionada(True)
            MiraCaducitat()
        End If
    End Sub

    Private Sub CheckEstaJustificat_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEstaJustificat.CheckedChanged

        If CheckEstaJustificat.Checked = True Then
            verificat.Visible = True
            CB_PrimerPagament.Enabled = True
        Else
            verificat.Visible = False
            CB_PrimerPagament.Enabled = False
            CB_PrimerPagament.Checked = False
            CB_SegonPagament.Checked = False
        End If
    End Sub
    Private Sub CheckEstaJustificat2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEstaJustificat2.CheckedChanged
        If CheckEstaJustificat2.Checked = True Then
            verificat2.Visible = True
            CB_SegonPagament.Enabled = True
        Else
            verificat2.Visible = False
            CB_SegonPagament.Enabled = False
            CB_SegonPagament.Checked = False
        End If
    End Sub

    Private Sub DataSolucions_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataSolucions.CellFormatting

        Dim dgv As DataGridView = sender
        If dgv.Columns(e.ColumnIndex).Name = "Dies" Then
            If e.Value < 0 Then
                e.Value = "Caducat"
            ElseIf e.Value > 365000 Then
                e.Value = "Pendent"
            End If
        End If
        If dgv.Columns(e.ColumnIndex).Name = "Dia factura" Then
            If IsDBNull(e.Value) Then e.Value = "Pendent"
        End If
        If dgv.Columns(e.ColumnIndex).Name = "Dia contracte" Then
            If IsDBNull(e.Value) Then e.Value = "Pendent"
        End If
    End Sub
    'Dispara l'event click sobre les empreses i comprova on es clica
    Private Sub DataEmpreses_MouseClick(sender As Object, e As MouseEventArgs) Handles DataEmpreses.MouseClick
        If e.Button = MouseButtons.Right Then
            Dim menu = New System.Windows.Forms.ContextMenuStrip
            Dim posicio = DataEmpreses.HitTest(e.X, e.Y).RowIndex

            If posicio > -1 Then
                menu.Items.Add("Esborrar empresa").Name = "Esborrar" & posicio
            End If
            menu.Show(DataEmpreses, e.X, e.Y)
            OmpleDadesEmpresa(posicio)
            DataEmpreses.Rows(posicio).Selected = True
            AddHandler menu.ItemClicked, AddressOf menuClickDretEmpreses
        End If
    End Sub
    'Dispara l'event click sobre les solucions i comprova on es clica
    Private Sub DataSolucions_MouseClick(sender As Object, e As MouseEventArgs) Handles DataSolucions.MouseClick
        If e.Button = MouseButtons.Right Then
            Dim menu = New System.Windows.Forms.ContextMenuStrip
            Dim posicio = DataSolucions.HitTest(e.X, e.Y).RowIndex

            If posicio > -1 Then
                menu.Items.Add("Estat justificació").Name = "Estat" & posicio
                menu.Items.Add("Esborrar solució").Name = "Esborrar" & posicio
                menu.Items.Add("Crear factura").Name = "Factura" & posicio
            End If
            OmpleDadesSolucions(posicio)
            DataSolucions.Rows(posicio).Selected = True
            menu.Show(DataSolucions, e.X, e.Y)
            AddHandler menu.ItemClicked, AddressOf menuClickDretSolucions
        End If
    End Sub
    'Mostra el menu de solucions al fer click dret sobre la solució
    Private Sub menuClickDretSolucions(sender As Object, e As ToolStripItemClickedEventArgs)
        Dim nom As String = e.ClickedItem.Name

        If nom.Contains("Estat") Then
            Dim RowBorrar As Integer = nom.Replace("Estat", "")
            Dim IdSolucio As Integer = DataSolucions.Rows(RowBorrar).Cells("Id").Value

            Dim EstatJustificacio As New EstatJustificacio(TitolEmpresa.Text, TitolSolucio.Text, idEmpresaSeleccionada, IdSolucio, CB_TipusSolucio.SelectedValue, InfoSubvencio.Text)

            OpenSubFormDialog(EstatJustificacio)
            OmpleSolucions(idEmpresaSeleccionada)
            EsborrarCampsSolucio()
        End If
        If nom.Contains("Esborrar") Then
            Dim RowBorrar As Integer = nom.Replace("Esborrar", "")
            Dim IdBorrar As Integer = DataSolucions.Rows(RowBorrar).Cells("Id").Value
            EsborrarSolucio(IdBorrar)
        End If
        If nom.Contains("Factura") Then
            Dim RowBorrar As Integer = nom.Replace("Factura", "")
            Dim IdBorrar As Integer = DataSolucions.Rows(RowBorrar).Cells("Id").Value
            Dim IdSolucio As Integer = DataSolucions.Rows(RowBorrar).Cells("Id").Value

            idEmpresaFactura = idEmpresaSeleccionada
            idSolucioFactura = IdSolucio
            Debug.WriteLine(idEmpresaFactura & " - " & idSolucioFactura)
            Inici.MostraForm(ffactu)

        End If
    End Sub
    Private Sub MostraLinea(linea As Integer, mostrar As Boolean)
        Select Case linea
            Case 1
                DataAprovacio.Visible = mostrar
            Case 2
                DataContracte.Visible = mostrar
                DataContracteOK.Visible = mostrar
                DataFiContracte.Visible = mostrar
                TitolContracte.Visible = mostrar
            Case 3
                DataFactura.Visible = mostrar
                DataFacturaOK.Visible = mostrar
                DataFiFactura.Visible = mostrar
                TitolFactura.Visible = mostrar
                TitolJustificacio.Visible = mostrar
                DataFiJustificacio.Visible = mostrar
            Case 4
                DataPagament.Visible = mostrar
                DataPagamentOK.Visible = mostrar
        End Select
    End Sub
    Private Sub CB_DataAprovacio_CheckedChanged(sender As Object, e As EventArgs) Handles CB_DataAprovacio.CheckedChanged

        If CB_DataAprovacio.Checked = True Then
            MostraLinea(1, True)
            CB_DataContracte.Enabled = True
            TitolAprovacio.Visible = True
            DataFiConcessio.Visible = True
            DataConcessioOK.Visible = True
        Else
            MostraLinea(1, False)
            MostraLinea(2, False)
            MostraLinea(3, False)
            MostraLinea(4, False)
            CB_DataContracte.Enabled = False
            CB_DataContracte.Checked = False
            CB_DataFactura.Enabled = False
            CB_DataFactura.Checked = False
            CB_DataPagamentIVA.Enabled = False
            CB_DataPagamentIVA.Checked = False
            TitolAprovacio.Visible = False
            DataFiConcessio.Visible = False
            DataConcessioOK.Visible = False
        End If

    End Sub
    Private Sub CB_DataContracte_CheckedChanged(sender As Object, e As EventArgs) Handles CB_DataContracte.CheckedChanged
        If CB_DataContracte.Checked = True Then
            MostraLinea(2, True)
            CB_DataFactura.Enabled = True
        Else
            MostraLinea(2, False)
            MostraLinea(3, False)
            MostraLinea(4, False)
            CB_DataPagamentIVA.Enabled = False
            CB_DataPagamentIVA.Checked = False
            CB_DataFactura.Enabled = False
            CB_DataFactura.Checked = False
        End If
        MiraCaducitat()
    End Sub
    Private Sub CB_DataFactura_CheckedChanged(sender As Object, e As EventArgs) Handles CB_DataFactura.CheckedChanged
        If CB_DataFactura.Checked = True Then
            MostraLinea(3, True)
            CB_DataPagamentIVA.Enabled = True
        Else
            MostraLinea(3, False)
            MostraLinea(4, False)
            CB_DataPagamentIVA.Enabled = False
            CB_DataPagamentIVA.Checked = False
        End If

        MiraCaducitat()
    End Sub
    Private Sub CB_PagamentIVA_CheckedChanged(sender As Object, e As EventArgs) Handles CB_DataPagamentIVA.CheckedChanged
        If CB_DataPagamentIVA.Checked = True Then
            MostraLinea(4, True)
        Else
            MostraLinea(4, False)
        End If
        MiraCaducitat()
    End Sub
    Private Sub DataContracte_ValueChanged(sender As Object, e As EventArgs) Handles DataContracte.ValueChanged

        DataFiContracte.Text = Format(DataContracte.Value.AddMonths(My.Settings.MesosContractacio).Date, "Short Date")
        MiraCaducitat()
    End Sub
    Private Sub DataFactura_ValueChanged(sender As Object, e As EventArgs) Handles DataFactura.ValueChanged

        DataFiFactura.Text = Format(DataFactura.Value.AddMonths(My.Settings.MesosFactura).Date, "Short Date")
        DataFiJustificacio.Text = Format(DataFactura.Value.AddMonths(My.Settings.MesosSuport + 3).Date, "Short Date")
        MiraCaducitat()

    End Sub
    Private Sub DataPagament_ValueChanged(sender As Object, e As EventArgs) Handles DataPagament.ValueChanged

        'If DataPagament.Value.Date < DataContracte.Value Or DataPagament.Value.Date > DataContracte.Value.AddMonths(My.Settings.MesosContractacio) Then
        '    CB_DataPagamentIVA.ForeColor = Color.Red
        'Else
        '    CB_DataPagamentIVA.ForeColor = Color.Black
        'End If
        DataFiFactura.Text = Format(DataFactura.Value.AddMonths(My.Settings.MesosFactura).Date, "Short Date")

        MiraCaducitat()
    End Sub

    Private Sub MiraCaducitat()

        Dim dies As Integer = 0

        Dim CaducitatContracte As Date = DataContracte.Value.AddMonths(My.Settings.MesosContractacio)
        Dim CaducitatFactura As Date = DataFactura.Value.AddMonths(My.Settings.MesosFactura)
        Dim CaducitatPagament As Date = DataFactura.Value.AddMonths(My.Settings.MesosFactura)
        Dim CaducitatJustificacio As Date = DataFactura.Value.AddMonths(My.Settings.MesosSuport + 3)
        Dim CaducitatConcessio As Date = DataAprovacio.Value.AddMonths(My.Settings.MesosAprovacio)


        Dim DataToCheck As Date

        'Mostem icones de ok o ko

        DiesCaducitat.Clear()
        DataCaducitat.Clear()

        ' Comprovem si les date d'aprovacio son correctes

        If DataPresentacio = "" Then
            DataToCheck = Date.Now
        Else
            DataToCheck = CDate(DataPresentacio)
        End If

        ' Comprovem si les dates de contractació son correctes

        If DataFactura.Checked = True Then
            DataContracteOK.Image = My.Resources.verificado_petit
        Else
            If DateDiff(DateInterval.Day, Now, CaducitatContracte) < 0 Then
                DataContracteOK.Image = My.Resources.sin_verificar_petit
            Else
                DataContracteOK.Image = My.Resources.verificado_petit
            End If
        End If

        ' Comprovem si les dates de la factura son correctes

        If DataFactura.Value > CaducitatContracte Then
            DataFacturaOK.Image = My.Resources.sin_verificar_petit
        Else
            DataFacturaOK.Image = My.Resources.verificado_petit
        End If

        'Comprovem si les dates del pagament son correctes

        If DataPagament.Value.Date > CaducitatContracte Then
            DataPagamentOK.Image = My.Resources.sin_verificar_petit
        Else
            DataPagamentOK.Image = My.Resources.verificado_petit
        End If

        ' Comprovem si les dates de la concessio son correctes

        If CB_DataConcessio.Checked = True Then
            If DataSolucions.RowCount > 0 Then
                DataConcessioOK.Image = My.Resources.verificado_petit
            Else
                If DateDiff(DateInterval.Day, Now, CaducitatConcessio) < 0 Then
                    DataConcessioOK.Image = My.Resources.sin_verificar_petit
                Else
                    DataConcessioOK.Image = My.Resources.verificado_petit
                End If
            End If
            DataVenciment = CaducitatConcessio
        End If

        If CB_DataContracte.Checked = True Then DataVenciment = CaducitatContracte
        If CB_DataFactura.Checked = True Then DataVenciment = CaducitatFactura
        If CheckEstaJustificat.Checked = True Then DataVenciment = CaducitatJustificacio

        dies = DateDiff(DateInterval.Day, Now, DataVenciment)


        If solucioSeleccionada Then
            If CB_DataConcessio.Checked = True Then
                If dies >= 0 Then
                    DiesCaducitat.Text = dies.ToString
                    DataCaducitat.Text = Format(DataVenciment.Date, "Short Date")
                Else
                    DiesCaducitat.Text = "Caducat"
                    DataCaducitat.Text = Format(DataVenciment.Date, "Short Date")

                End If
            Else
                DiesCaducitat.Text = ""
                DataCaducitat.Text = ""
            End If
        Else
            If teContractes = 1 Then
                DiesCaducitat.Text = ""
                DataCaducitat.Text = ""
            Else
                If CB_DataConcessio.Checked = True Then
                    If dies >= 0 Then
                        DiesCaducitat.Text = dies.ToString
                        DataCaducitat.Text = Format(DataVenciment.Date, "Short Date")
                    Else
                        DiesCaducitat.Text = "Caducat"
                        DataCaducitat.Text = Format(DataVenciment.Date, "Short Date")
                        Debug.WriteLine("Data caducitat: " + Format(DataVenciment.Date, "Short Date"))
                    End If
                Else
                    DiesCaducitat.Text = ""
                    DataCaducitat.Text = ""
                End If
            End If
        End If

    End Sub

    Private Sub CB_DataContracte_Click(sender As Object, e As EventArgs) Handles CB_DataContracte.Click
        DataContracte.Value = Date.Now
    End Sub
    Private Sub CB_DataFactura_Click(sender As Object, e As EventArgs) Handles CB_DataFactura.Click
        DataFactura.Value = Date.Now
    End Sub
    Private Sub CB_DataPagamentIVA_Click(sender As Object, e As EventArgs) Handles CB_DataPagamentIVA.Click
        DataPagament.Value = Date.Now
    End Sub

    Private Sub CB_TipusSolucio_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CB_TipusSolucio.SelectionChangeCommitted
        GestionaInfo(CB_TipusSolucio.SelectedValue)
        'EsborrarCampsSolucio()
    End Sub

    'Mostra el menu d'empreses al fer click dret sobre l'empresa
    Private Sub menuClickDretEmpreses(sender As Object, e As ToolStripItemClickedEventArgs)
        Dim nom As String = e.ClickedItem.Name

        If nom.Contains("Esborrar") Then
            Dim RowBorrar As Integer = nom.Replace("Esborrar", "")
            Dim IdBorrar As Integer = DataEmpreses.Rows(RowBorrar).Cells("Id").Value
            EsborrarEmpresa(IdBorrar)
        End If
    End Sub

    Private Sub InfoVariableNum_ValueChanged(sender As Object, e As EventArgs) Handles InfoVariableNum.ValueChanged
        InfoSubvencio.Text = (subvencioSolucioSeleccionada * InfoVariableNum.Value).ToString
    End Sub

    Private Sub InfoVariableNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles InfoVariableNum.KeyPress
        Dim sep As Char = Convert.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator)
        If e.KeyChar = sep Then e.Handled = True
    End Sub

    Private Sub CB_PrimerPagament_CheckedChanged(sender As Object, e As EventArgs) Handles CB_PrimerPagament.CheckedChanged
        If CB_PrimerPagament.Checked = True Then
            Pagat1.Visible = True
            CB_SegonPagament.Enabled = True
        Else
            Pagat1.Visible = False
            CB_SegonPagament.Enabled = False
            CB_SegonPagament.Checked = False
        End If
    End Sub

    Private Sub CB_SegonPagament_CheckedChanged(sender As Object, e As EventArgs) Handles CB_SegonPagament.CheckedChanged
        If CB_SegonPagament.Checked = True Then
            Pagat2.Visible = True
        Else
            Pagat2.Visible = False
        End If
    End Sub

    'Modifica els camps quan la selecció de solucio canvia
    Private Sub DataSolucions_Click(Sender As Object, e As EventArgs) Handles DataSolucions.Click
        If DataSolucions.SelectedRows.Count > 0 Then
            OmpleDadesSolucions(DataSolucions.CurrentRow.Index)
            MiraCaducitat()
        End If
    End Sub

    Private Sub Contractes_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        seleccionaFila(idEmpresaSeleccionadaUtils, 1)
        seleccionaFila(idSolucioSeleccionadaUtils, 2)
    End Sub

    Private Sub PB_EliminaFiltre_Click(sender As Object, e As EventArgs) Handles PB_EliminaFiltre.Click
        If TB_CercaEmpreses.Text <> "" Then
            EsborrarCampsSolucio()
            EsborraCampsEmpresa()
            EstaLaEmpresaSeleccionada(False)
            EstaLaSolucioSeleccionada(False)
            TB_CercaEmpreses.Clear()
        End If
    End Sub

    Private Sub TB_CercaEmpreses_TextChanged(sender As Object, e As EventArgs) Handles TB_CercaEmpreses.TextChanged
        ActualitzaEmpreses(TB_CercaEmpreses.Text)
        EsborrarCampsSolucio()
        EsborraCampsEmpresa()
        EstaLaEmpresaSeleccionada(False)
        EstaLaSolucioSeleccionada(False)
    End Sub



    Private Sub CB_DataConcessio_Click(sender As Object, e As EventArgs) Handles CB_DataConcessio.Click
        If CB_DataConcessio.Checked = True Then
            DataConcessio.Value = Date.Now
            DataConcessio.Visible = True
            CB_DataAprovacio.Checked = True
            TitolAprovacio.Visible = True
            DataFiConcessio.Visible = True
        Else
            TitolAprovacio.Visible = False
            DataConcessio.Visible = False
            CB_DataAprovacio.Checked = False
            DataFiConcessio.Visible = False
        End If
    End Sub

    Private Sub DataConcessio_ValueChanged(sender As Object, e As EventArgs) Handles DataConcessio.ValueChanged
        DataAprovacio.Value = DataConcessio.Value
        DataFiConcessio.Text = Format(DataConcessio.Value.AddMonths(My.Settings.MesosAprovacio).Date, "Short Date")
        TB_CaducitatConcessio.Text = Format(DataConcessio.Value.AddMonths(My.Settings.MesosAprovacio).Date, "Short Date")
    End Sub

    Private Sub CheckJustificat_Click(sender As Object, e As EventArgs) Handles CheckJustificat.Click
        If empresaSeleccionada = True Then OmpleSolucions(idEmpresaSeleccionada)
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
        segmentEmpresaSeleccionada = row.Cells("Segment").Value

        If Not IsDBNull(row.Cells("Concessió").Value) Then
            CB_DataConcessio.Checked = True
            CB_DataAprovacio.Checked = True
            DataConcessio.Text = Format(row.Cells("Concessió").Value, "Short Date")
            TB_ImportBono.Text = row.Cells("Import").Value
            TB_CodiBono.Text = row.Cells("CodiBono").Value
            DataConcessio.Visible = True
        Else
            CB_DataConcessio.Checked = False
            DataConcessio.Visible = False
            CB_DataAprovacio.Checked = False
        End If

        EstaLaSolucioSeleccionada(False)

        If row.Cells("Id").Value <> idEmpresaSeleccionada Then
            idEmpresaSeleccionada = row.Cells("Id").Value
            OmpleSolucions(idEmpresaSeleccionada)
        End If

        Select Case (row.Cells("Segment").Value)
            Case 1
                RB_Segment1.Checked = True
            Case 2
                RB_Segment2.Checked = True
            Case 3
                RB_Segment3.Checked = True
        End Select

        EstaLaEmpresaSeleccionada(True)

    End Sub
    'Omple els camps de la solucio rebuda per posicio a la taula
    Private Sub OmpleDadesSolucions(Index As Integer)

        Dim row As DataGridViewRow = DataSolucions.Rows(Index)

        CB_TipusSolucio.Text = row.Cells("Nom").Value
        NoAcord.Text = row.Cells("Contracte").Value
        GestionaInfo(row.Cells("IdSolucio").Value)

        idSolucioSeleccionada = row.Cells("Id").Value
        TitolSolucio.Text = row.Cells("Nom").Value
        TBObservacions.Text = row.Cells("Observacions").Value
        InfoVariableNum.Value = row.Cells("Quantitat").Value

        DataPresentacio = row.Cells("DataPresentacio").Value

        If row.Cells("Justificat").Value = "Si" Then
            CheckEstaJustificat.Checked = True
        Else
            CheckEstaJustificat.Checked = False
        End If

        If row.Cells("SegonJustificat").Value = "Si" Then
            CheckEstaJustificat2.Checked = True
        Else
            CheckEstaJustificat2.Checked = False
        End If


        CB_PrimerPagament.Checked = row.Cells("PrimerPagament").Value
        CB_SegonPagament.Checked = row.Cells("SegonPagament").Value

        ProgressBar1.Value = row.Cells("%").Value

        If Not IsDBNull(row.Cells("Dia contracte").Value) Then
            If row.Cells("Dia contracte").Value <> "" Then
                DataContracte.Text = Format(row.Cells("Dia contracte").Value, "Short Date")
                CB_DataContracte.Checked = True
            Else
                DataContracte.Text = Date.Now
                CB_DataContracte.Checked = False
            End If
        End If

        If Not IsDBNull(row.Cells("Dia factura").Value) Then
            If row.Cells("Dia factura").Value <> "" Then
                DataFactura.Text = Format(row.Cells("Dia factura").Value, "Short Date")
                CB_DataFactura.Checked = True
            Else
                DataFactura.Text = Date.Now
                CB_DataFactura.Checked = False
            End If
        End If

        If Not IsDBNull(row.Cells("DataPagament").Value) Then
            If row.Cells("DataPagament").Value <> "" Then
                DataPagament.Text = Format(row.Cells("DataPagament").Value, "Short Date")
                CB_DataPagamentIVA.Checked = True
            Else
                DataPagament.Text = Date.Now
                CB_DataPagamentIVA.Checked = False
            End If
        End If

        InfoSubvencioReal.Text = row.Cells("Subvencio").Value.ToString

        ' Formatejem estats
        TB_Proces0.Enabled = False
        TB_Proces0.BackColor = SystemColors.Control
        TB_Proces1.Enabled = False
        TB_Proces1.BackColor = SystemColors.Control
        TB_Proces2.Enabled = False
        TB_Proces2.BackColor = SystemColors.Control
        TB_Proces3.Enabled = False
        TB_Proces3.BackColor = SystemColors.Control
        TB_Proces4.Enabled = False
        TB_Proces4.BackColor = SystemColors.Control
        TB_Proces5.Enabled = False
        TB_Proces5.BackColor = SystemColors.Control
        TB_Proces6.Enabled = False
        TB_Proces6.BackColor = SystemColors.Control
        TB_Proces7.Enabled = False
        TB_Proces7.BackColor = SystemColors.Control
        TB_Proces8.Enabled = False
        TB_Proces8.BackColor = SystemColors.Control

        Select Case row.Cells("Estat").Value
            Case 0
                TB_Proces0.Enabled = True
                TB_Proces0.BackColor = verdClar
            Case 1
                TB_Proces1.Enabled = True
                TB_Proces1.BackColor = verdClar
            Case 2
                TB_Proces2.Enabled = True
                TB_Proces2.BackColor = verdClar
            Case 3
                TB_Proces3.Enabled = True
                TB_Proces3.BackColor = verdClar
            Case 4
                TB_Proces4.Enabled = True
                TB_Proces4.BackColor = verdClar
            Case 5
                TB_Proces5.Enabled = True
                TB_Proces5.BackColor = verdClar
            Case 6
                TB_Proces6.Enabled = True
                TB_Proces6.BackColor = verdClar
            Case 7
                TB_Proces7.Enabled = True
                TB_Proces7.BackColor = verdClar
            Case 8
                TB_Proces8.Enabled = True
                TB_Proces8.BackColor = verdClar
        End Select

        EstaLaSolucioSeleccionada(True)
    End Sub
    Private Sub GestionaInfo(i As Integer)
        InfoVariableNum.Value = 1
        Select Case (i)
            Case 8
                InfoVariable.Visible = True
                InfoVariableNum.Visible = True
                infoMax.Visible = True
                InfoVariable.Text = "Nº de usuaris"

            Case 9
                InfoVariable.Visible = True
                InfoVariableNum.Visible = True
                infoMax.Visible = True
                InfoVariable.Text = "Nº de usuaris"
            Case 10
                InfoVariable.Visible = True
                InfoVariableNum.Visible = True
                infoMax.Visible = True
                InfoVariable.Text = "Nº de dispositius"
            Case Else
                InfoVariable.Visible = False
                InfoVariableNum.Visible = False
                infoMax.Visible = False
        End Select

        RebreSubvencio(segmentEmpresaSeleccionada)

    End Sub
    Private Sub RebreSubvencio(segment As Integer)
        Dim conexion As New SQLiteConnection(cadena)
        Dim Query As String
        Dim strCommand As SQLiteCommand
        Dim segmentString As String = "Segment" & segment

        conexion.Open()

        If conexion.State = ConnectionState.Open Then
            Query = "SELECT * FROM TipusSolucions WHERE Id=" & CB_TipusSolucio.SelectedValue

            Try
                strCommand = New SQLiteCommand(Query, conexion)

                Dim lector As SQLiteDataReader = strCommand.ExecuteReader


                If lector.Read() Then
                    subvencioSolucioSeleccionada = lector.GetValue(segmentString)
                    InfoSubvencio.Text = (subvencioSolucioSeleccionada * InfoVariableNum.Value).ToString

                End If
                lector.Close()

            Catch ex As Exception

            End Try

            conexion.Close()
        End If

        If segmentEmpresaSeleccionada = 1 Then
            infoMax.Text = "Màxim 48"
            InfoVariableNum.Maximum = 48
        ElseIf segmentEmpresaSeleccionada = 2 Then
            infoMax.Text = "Màxim 9"
            InfoVariableNum.Maximum = 9
        ElseIf segmentEmpresaSeleccionada = 3 Then
            infoMax.Text = "Màxim 2"
            InfoVariableNum.Maximum = 2
        End If
    End Sub


End Class