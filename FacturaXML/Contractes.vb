Imports System.Data.SQLite
Imports System.IO
Imports System.Text
Imports System.Threading
Imports ClosedXML.Excel
Imports FacturaXML.Empresa

Public Class Contractes
    Private empresaSeleccionada, solucioSeleccionada As Boolean
    Private idEmpresaSeleccionada, idSolucioSeleccionada, segmentEmpresaSeleccionada, teContractes, tipusJustificacioSeleccionada As Integer
    Private subvencioSolucioSeleccionada As Double
    Private DT_TipusSolucions, DT_Solucions, DT_Empreses As New DataTable
    Private idEmpresaRebuda, idSolucioRebuda As Integer
    Private DataVenciment, DataVenciment2 As Date
    Private DataPresentacio As String
    Private vuelta As Int32 = 0

    Private Sub Contractes_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Debug.WriteLine("Activated Contractes")
    End Sub
    'Carrega els tipus de solucions per omplir el combobox
    Private Sub Contractes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ActualitzaEmpreses(TB_CercaEmpreses.Text)
        CheckJustificat.Checked = My.Settings.MostrarGestioAprovades

    End Sub
    'Private Sub carregaTipusSolucions()
    '    Dim conexion As New SQLiteConnection(cadena)
    '    Try

    '        conexion.Open()

    '        DT_TipusSolucions.Clear()
    '        Dim query As String = "SELECT * FROM TipusSolucions where Segment" + segmentEmpresaSeleccionada.ToString() + ">0"

    '        If conexion.State = ConnectionState.Open Then
    '            Dim DA As New SQLiteDataAdapter(query, conexion)
    '            DA.Fill(DT_TipusSolucions)
    '            CB_TipusSolucio.DataSource = DT_TipusSolucions
    '            CB_TipusSolucio.DisplayMember = "Nom"
    '            CB_TipusSolucio.ValueMember = "Id"
    '            CB_TipusSolucio.Text = "Selecciona un tipus de solució"
    '        End If

    '    Catch
    '        MsgBox("No s'ha pogut accedir a la base de dades", vbCritical, "Error")
    '    End Try

    '    conexion.Close()
    'End Sub
    Private Sub carregaTipusSolucions()
        Dim conexion As New SQLiteConnection(cadena)
        Dim DT_TipusSolucions As New DataTable() ' Crear nueva instancia de DataTable
        Try
            conexion.Open()

            ' Aseguramos que el valor de segmentEmpresaSeleccionada se incluya correctamente en la consulta SQL
            Dim query As String = "SELECT * FROM TipusSolucions WHERE Segment" & segmentEmpresaSeleccionada.ToString() & " > 0"

            If conexion.State = ConnectionState.Open Then
                Dim DA As New SQLiteDataAdapter(query, conexion)

                ' Llenar la tabla
                DA.Fill(DT_TipusSolucions)

                ' Asignamos la tabla al ComboBox
                CB_TipusSolucio.DataSource = DT_TipusSolucions
                CB_TipusSolucio.DisplayMember = "Nom"
                CB_TipusSolucio.ValueMember = "Id"
                CB_TipusSolucio.Text = "Selecciona un tipus de solució"
            End If

        Catch ex As Exception
            MsgBox("No s'ha pogut accedir a la base de dades: " & ex.Message, vbCritical, "Error")
        Finally
            ' Aseguramos que la conexión se cierre correctamente
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
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
        Dim empresaTxt As String = Empresa.Text.TrimEnd()
        Dim nifTxt As String = Nif.Text.Trim()
        Dim direccioTxt As String = Direccio.Text.TrimEnd()
        Dim codiPostalTxt As String = CodiPostal.Text.Trim()
        Dim ciutatTxt As String = Ciutat.Text.TrimEnd()
        Dim provinciaTxt As String = Provincia.Text.TrimEnd()
        Dim paisTxt As String = Pais.Text.TrimEnd()
        Dim codiBonoTxt As String = TB_CodiBono.Text.Trim()
        Dim dataConcessioTxt As String
        Dim dataFiConcessioTxt As String
        Dim seleccio As Boolean
        Dim segment As Integer
        Dim import As Double
        seleccio = empresaSeleccionada

        If RB_Segment1.Checked = True Then segment = 1
        If RB_Segment2.Checked = True Then segment = 2
        If RB_Segment3.Checked = True Then segment = 3
        If RB_Segment4.Checked = True Then segment = 4
        If RB_Segment5.Checked = True Then segment = 5

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
        EsborrarCampsSolucio(True)

    End Sub
    Private Sub ImportarEmpresa(empresa As Empresa.Empresa)

        Dim conexion As New SQLiteConnection(cadena)
        Dim Query As String
        Dim strCommand As SQLiteCommand


        ' Asegúrate de que las fechas estén en el formato correcto YYYY-MM-DD
        Dim fechaFormateada As String = DateTime.Parse(empresa.Fecha).ToString("yyyy-MM-dd")
        Dim caducaFormateada As String = DateTime.Parse(empresa.caduca).ToString("yyyy-MM-dd")

        ' Construcción de la consulta
        Query = "INSERT INTO Empreses (Nom,Nif,Direccio,CodiPostal,Ciutat,Provincia,Pais,Segment,DataConcessio,DataCaducitat,CodiBono,Import) VALUES (" &
         StringDB(empresa.Empresa) & "," &
         StringDB(empresa.Nif) & "," &
         StringDB("-") & "," &
         StringDB("-") & "," &
         StringDB("-") & "," &
         StringDB("-") & "," &
         StringDB("-") & "," &
         empresa.SegmentoValor & "," &
         StringDB(fechaFormateada) & "," &
         StringDB(caducaFormateada) & "," &
         StringDB(empresa.Bono) & "," &
         empresa.Importe & ")"




        Try
            strCommand = New SQLiteCommand(Query, conexion)
            conexion.Open()

            If conexion.State = ConnectionState.Open Then
                strCommand.ExecuteNonQuery()
            End If

        Catch ex As Exception

        End Try
        conexion.Close()

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

        If RB_Segment1.Checked = False And RB_Segment2.Checked = False And RB_Segment3.Checked = False And RB_Segment4.Checked = False And RB_Segment5.Checked = False Then
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
        EsborrarCampsSolucio(True)

        RB_Segment1.Checked = False
        RB_Segment2.Checked = False
        RB_Segment3.Checked = False
        RB_Segment4.Checked = False
        RB_Segment5.Checked = False
    End Sub
    Private Sub Btn_EsborrarSeleccioSolucio_Click(sender As Object, e As EventArgs) Handles Btn_EsborrarSeleccioSolucio.Click
        EsborrarCampsSolucio(True)
    End Sub
    'Carrega la taula amb les solucions trobades a la base de dades
    'Private Sub OmpleSolucions(id As Integer)

    '    Dim conexion As New SQLiteConnection(cadena)
    '    Dim concedit, consumit As Double

    '    Try

    '        conexion.Open()

    '        If conexion.State = ConnectionState.Open Then
    '            Dim DA As New SQLiteDataAdapter
    '            Dim comm As SQLiteCommand

    '            If CheckJustificat.Checked = True Then

    '                comm = New SQLiteCommand("SELECT Solucions.Id,
    '                                      Solucions.tipus,
    '                                      Solucions.IdSolucio,
    '                                      TipusSolucions.Nom,
    '                                      Solucions.Contracte,                                          
    '                                      strftime('%d-%m-%Y',DataContracte) AS 'Dia contracte',                                          
    '                                      strftime('%d-%m-%Y',Solucions.DataFactura) AS 'Dia factura',
    '                                      Solucions.DataPagament,
    '                                      strftime('%d-%m-%Y',Solucions.DataVenciment) AS 'Dia venciment',                                          
    '                                      Solucions.Justificat,
    '                                      Solucions.SegonJustificat,
    '                                      Solucions.PrimerPagament,
    '                                      Solucions.SegonPagament,
    '                                      julianday(Solucions.DataVenciment) - julianday(date())  AS Dies,
    '                                      Justificacions.Percentatge AS '%',
    '                                      Justificacions.Estat,
    '                                      Justificacions.DataPresentacio,
    '                                      Justificacions.Subvencio, 
    '                                      Solucions.Observacions,
    '                                      Solucions.Quantitat   
    '                                      FROM Solucions
    '                                      INNER JOIN TipusSolucions ON TipusSolucions.Id=Solucions.idSolucio
    '                                      INNER JOIN Justificacions ON Solucions.Id=Justificacions.idSolucio  
    '                                      WHERE idEmpresa=" & id &
    '                                      " Order by tipus, contracte", conexion)

    '            Else

    '                comm = New SQLiteCommand("SELECT Solucions.Id,
    '                                      Solucions.tipus,
    '                                      Solucions.IdSolucio,
    '                                      TipusSolucions.Nom,
    '                                      Solucions.Contracte,                                          
    '                                      Solucions.DataContracte AS 'Dia contracte',
    '                                      Solucions.DataFactura AS 'Dia factura',
    '                                      Solucions.DataPagament,
    '                                      Solucions.DataVenciment AS 'Dia venciment',
    '                                      Solucions.Justificat,
    '                                      Solucions.SegonJustificat,
    '                                      Solucions.PrimerPagament,
    '                                      Solucions.SegonPagament,  
    '                                      IFNULL(julianday(Solucions.DataVenciment) - julianday(date()),0)  AS Dies,
    '                                      Justificacions.Percentatge AS '%',
    '                                      Justificacions.Estat,
    '                                      Justificacions.DataPresentacio,
    '                                      Justificacions.Subvencio, 
    '                                      Solucions.Observacions,
    '                                      Solucions.Quantitat 
    '                                      FROM Solucions
    '                                      INNER JOIN TipusSolucions On TipusSolucions.Id=Solucions.idSolucio
    '                                      INNER JOIN Justificacions ON Solucions.Id=Justificacions.idSolucio  
    '                                      WHERE (idEmpresa=" & id & " And Justificat='No') order by tipus, contracte", conexion)
    '            End If


    '            DA.SelectCommand = comm
    '            DT_Solucions.Clear()
    '            DA.Fill(DT_Solucions)

    '            If DT_Solucions.Rows.Count > 0 Then
    '                DataSolucions.DataSource = DT_Solucions
    '                TitolSolucio.Text = "SELECCIONA JUSTIFICACIÓ"
    '            Else
    '                DataSolucions.DataSource = Nothing
    '                TitolSolucio.Text = "SENSE SOLUCIONS"
    '            End If

    '            If DataSolucions.DataSource IsNot Nothing Then

    '                With DataSolucions
    '                    .Columns("Id").Visible = False
    '                    .Columns("IdSolucio").Visible = False
    '                    .Columns("Justificat").Visible = False
    '                    .Columns("SegonJustificat").Visible = False
    '                    .Columns("Observacions").Visible = False
    '                    .Columns("DataPagament").Visible = False
    '                    .Columns("Quantitat").Visible = False
    '                    .Columns("PrimerPagament").Visible = False
    '                    .Columns("SegonPagament").Visible = False
    '                    .Columns("Estat").Visible = False
    '                    .Columns("DataPresentacio").Visible = False
    '                    .Columns("Subvencio").Visible = False
    '                    .Columns("Dies").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    '                    .Columns("Dia contracte").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    '                    .Columns("Dia factura").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    '                    .Columns("Dia venciment").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    '                    .Columns("%").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    '                    .Columns("Nom").Width = 150
    '                    .Columns("Contracte").Width = 100
    '                    .Columns("%").Width = 30
    '                    .Columns("Dies").Width = 70
    '                    .Columns("Tipus").HeaderText = ""
    '                    .Columns("Tipus").Width = 20
    '                    .Columns("Tipus").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    '                    .ClearSelection()
    '                End With


    '            End If

    '        End If

    '        If conexion.State = ConnectionState.Open Then
    '            Dim Sql As String = "SELECT sum(Justificacions.Subvencio) as Consumit                                          
    '                                      FROM Solucions
    '                                      INNER JOIN TipusSolucions ON TipusSolucions.Id=Solucions.idSolucio
    '                                      INNER JOIN Justificacions ON Solucions.Id=Justificacions.idSolucio  
    '                                      WHERE idEmpresa=" & id & " and tipus=1"

    '            Dim strCommand As SQLiteCommand = New SQLiteCommand(Sql, conexion)
    '            Dim lector As SQLiteDataReader = strCommand.ExecuteReader

    '            If lector.Read Then
    '                If Not IsDBNull(lector.GetValue("Consumit")) Then
    '                    consumit = lector.GetValue("Consumit")
    '                Else
    '                    consumit = 0
    '                End If

    '                concedit = TB_ImportBono.Text
    '                TB_BonusRestant.Text = (concedit - consumit).ToString
    '            End If
    '            lector.Close()

    '        End If


    '    Catch ex As Exception
    '        MsgBox("No s'ha pogut accedir a la base de dades" & ex.Message, vbCritical, "Error")
    '    End Try
    '    conexion.Close()
    'End Sub
    Private Sub OmpleSolucions(id As Integer)
        Dim concedit, consumit As Double

        ' Usamos Using para garantizar el cierre de la conexión automáticamente
        Using conexion As New SQLiteConnection(cadena)
            Try
                conexion.Open()

                If conexion.State = ConnectionState.Open Then
                    Dim DA As New SQLiteDataAdapter
                    Dim query As String

                    ' Seleccionamos la consulta adecuada según si CheckJustificat está marcado o no
                    If CheckJustificat.Checked Then
                        query = "SELECT Solucions.Id, Solucions.tipus, Solucions.IdSolucio, TipusSolucions.Nom, Solucions.Contracte, 
                  SUBSTR(Solucions.Contracte, 1, 2) AS 'TipusAcord',
                  strftime('%d-%m-%Y', DataContracte) AS 'Dia contracte', 
                  strftime('%d-%m-%Y', Solucions.DataFactura) AS 'Dia factura', 
                  Solucions.DataPagament, strftime('%d-%m-%Y', Solucions.DataVenciment) AS 'Dia venciment', 
                  Solucions.Justificat, Solucions.SegonJustificat, Solucions.PagamentFet, Solucions.SegonPagament, 
                  julianday(Solucions.DataVenciment) - julianday(date()) AS Dies, 
                  Justificacions.Percentatge AS '%', Justificacions.Estat, Justificacions.DataPresentacio, 
                  Justificacions.Subvencio, Solucions.Observacions, Solucions.Quantitat 
           FROM Solucions
           INNER JOIN TipusSolucions ON TipusSolucions.Id = Solucions.idSolucio
           INNER JOIN Justificacions ON Solucions.Id = Justificacions.idSolucio  
           WHERE idEmpresa = @id
           ORDER BY tipus, contracte"
                    Else
                        query = "SELECT Solucions.Id, Solucions.tipus, Solucions.IdSolucio, TipusSolucions.Nom, Solucions.Contracte, 
                  SUBSTR(Solucions.Contracte, 1, 2) AS 'TipusAcord',
                  Solucions.DataContracte AS 'Dia contracte', Solucions.DataFactura AS 'Dia factura', 
                  Solucions.DataPagament, Solucions.DataVenciment AS 'Dia venciment', Solucions.Justificat, 
                  Solucions.SegonJustificat, Solucions.PagamentFet, Solucions.SegonPagament, 
                  IFNULL(julianday(Solucions.DataVenciment) - julianday(date()), 0) AS Dies, 
                  Justificacions.Percentatge AS '%', Justificacions.Estat, Justificacions.DataPresentacio, 
                  Justificacions.Subvencio, Solucions.Observacions, Solucions.Quantitat 
           FROM Solucions
           INNER JOIN TipusSolucions ON TipusSolucions.Id = Solucions.idSolucio
           INNER JOIN Justificacions ON Solucions.Id = Justificacions.idSolucio  
           WHERE (idEmpresa = @id AND Justificat = 'No')
           ORDER BY tipus, contracte"
                    End If


                    ' Preparamos el comando con parámetros para evitar inyecciones SQL
                    Using comm As New SQLiteCommand(query, conexion)
                        comm.Parameters.AddWithValue("@id", id)
                        DA.SelectCommand = comm

                        ' Limpiamos y llenamos la tabla de datos
                        DT_Solucions.Clear()
                        DA.Fill(DT_Solucions)

                        ' Asignamos el origen de datos según el resultado
                        If DT_Solucions.Rows.Count > 0 Then
                            DataSolucions.DataSource = DT_Solucions
                            TitolSolucio.Text = "SELECCIONA JUSTIFICACIÓ"
                        Else
                            DataSolucions.DataSource = Nothing
                            TitolSolucio.Text = "SENSE SOLUCIONS"
                        End If

                        ' Configuración de columnas si hay datos
                        If DataSolucions.DataSource IsNot Nothing Then
                            ConfigurarColumnasDataGridView()
                        End If
                    End Using
                End If

                ' Consulta para calcular el "Consumit"
                If conexion.State = ConnectionState.Open Then
                    Using strCommand As New SQLiteCommand("SELECT sum(Justificacions.Subvencio) AS Consumit 
                                                       FROM Solucions
                                                       INNER JOIN TipusSolucions ON TipusSolucions.Id = Solucions.idSolucio
                                                       INNER JOIN Justificacions ON Solucions.Id = Justificacions.idSolucio  
                                                       WHERE idEmpresa = @id AND tipus = 1", conexion)
                        strCommand.Parameters.AddWithValue("@id", id)
                        Using lector As SQLiteDataReader = strCommand.ExecuteReader
                            If lector.Read Then
                                consumit = If(IsDBNull(lector("Consumit")), 0, Convert.ToDouble(lector("Consumit")))
                            End If
                        End Using
                    End Using

                    concedit = If(IsNumeric(TB_ImportBono.Text), Convert.ToDouble(TB_ImportBono.Text), 0)
                    TB_BonusRestant.Text = (concedit - consumit).ToString()
                End If

            Catch ex As Exception
                MsgBox("No s'ha pogut accedir a la base de dades. " & ex.Message, vbCritical, "Error")
            End Try
        End Using
    End Sub

    ' Método para configurar las columnas del DataGridView
    Private Sub ConfigurarColumnasDataGridView()
        With DataSolucions

            .Columns("Id").Visible = False
            .Columns("IdSolucio").Visible = False
            .Columns("Justificat").Visible = False
            .Columns("SegonJustificat").Visible = False
            .Columns("Observacions").Visible = False
            .Columns("DataPagament").Visible = False
            .Columns("Quantitat").Visible = False
            .Columns("PagamentFet").Visible = False
            .Columns("SegonPagament").Visible = False
            .Columns("Estat").Visible = False
            .Columns("DataPresentacio").Visible = False
            .Columns("Subvencio").Visible = False
            .Columns("%").Visible = False
            .Columns("Dies").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Dia contracte").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Dia factura").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Dia venciment").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("%").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Nom").Width = 300
            .Columns("Contracte").Width = 100
            .Columns("%").Width = 30
            .Columns("Dies").Width = 70
            .Columns("Tipus").HeaderText = ""
            .Columns("Tipus").Width = 20
            .Columns("Tipus").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("TipusAcord").DisplayIndex = 2
            .Columns("TipusAcord").HeaderText = "TA"
            .Columns("TipusAcord").Width = 27
            .ClearSelection()
        End With
    End Sub


    Private Sub Btn_EsborrarSolucio_Click(sender As Object, e As EventArgs) Handles Btn_EsborrarSolucio.Click
        Dim index As Integer = DataSolucions.CurrentCell.RowIndex
        Dim row As DataGridViewRow = DataSolucions.Rows(index)
        Dim idBorrar As Integer
        Dim contracte As String = row.Cells("Contracte").Value
        idBorrar = row.Cells("Id").Value

        Dim resposta = MsgBox("¿Estàs segur que vols esborrar aquesta solució?", vbYesNo + vbQuestion, "Esborrar solució")


        If resposta = vbYes Then
            Try
                For Each linea In DataSolucions.Rows
                    Debug.WriteLine("Buscada:" + contracte.ToString() & " - Probada:" + linea.Cells("Contracte").Value.ToString())
                    If contracte = linea.Cells("Contracte").Value Then
                        EsborrarSolucio(linea.Cells("Id").Value)
                    End If
                Next

                OmpleSolucions(idEmpresaSeleccionada)
                MsgBox("S'ha esborrat correctament la solució", , "Esborrar solució")
            Catch ex As Exception
                MsgBox("No s'ha pogut esborrar la solució ", vbCritical, "Esborrar solució")
            End Try
        End If
    End Sub
    'Esborra tots els camps de la solució
    Private Sub EsborrarCampsSolucio(esborrarSeleccioSolucio As Boolean)



        If esborrarSeleccioSolucio = True Then
            DataSolucions.ClearSelection()
            tipusJustificacioSeleccionada = 0
        End If

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
        DiesCaducitat.Text = "-"
        DataCaducitat.Text = "-"
        solucioSeleccionada = False
        TitolSolucio.Clear()

        TBObservacions.Clear()
        CheckEstaJustificat.Checked = False
        CB_TipusSolucio.Text = "Selecciona un tipus de solució"

        infoMax.Visible = False
        InfoVariable.Visible = False
        InfoVariableNum.Visible = False
        InfoVariableNum.Value = 1
        CB_PagamentFet.Checked = False
        EstaLaSolucioSeleccionada(False)
        InfoSubvencio.Clear()

        Lbl_estat.Text = ""
        Lbl_tipus.Text = ""
        Lbl_estat.BackColor = SystemColors.Control
        Lbl_tipus.BackColor = SystemColors.Control

    End Sub

    Private Sub Btn_AfegirSolucio_Click(sender As Object, e As EventArgs) Handles Btn_AfegirSolucio.Click
        AfegirSolucio(idSolucioSeleccionada)
    End Sub

    Private Sub Btn_EstatJustificacio_Click(sender As Object, e As EventArgs) Handles Btn_EstatJustificacio.Click
        Dim EstatJustificacio As New EstatJustificacio(TitolEmpresa.Text, TitolSolucio.Text, idEmpresaSeleccionada, idSolucioSeleccionada, CB_TipusSolucio.SelectedValue, InfoSubvencio.Text, tipusJustificacioSeleccionada)
        OpenSubFormDialog(EstatJustificacio)
        OmpleSolucions(idEmpresaSeleccionada)
        seleccionaFila(idSolucioSeleccionada, 2)
    End Sub
    'Esborra la solució seleccionada
    Private Sub EsborrarSolucio(id As Integer)

        'Dim resposta = MsgBox("¿Estàs segur que vols esborrar aquesta solució?", vbYesNo + vbQuestion, "Esborrar solució")
        Dim conexion As New SQLiteConnection(cadena)


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

            'OmpleSolucions(idEmpresaSeleccionada)
            'MsgBox("S'ha esborrat correctament la solució", , "Esborrar solució")
        Catch ex As Exception
            'MsgBox("No s'ha pogut esborrar la solució ", vbCritical, "Esborrar solució")
        End Try
        conexion.Close()


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
            '.Columns("nif").Width = 60
            .Columns("ciutat").Visible = False
            .Columns("provincia").Visible = False
            '.Columns("segment").Width = 60
            '.Columns("concessió").Width = 90
            .AutoResizeColumns()
            .ClearSelection()
        End With

    End Sub
    'Donem format al llistat de solucions quan acaba de carregarse
    'Private Sub DataSolucions_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataSolucions.DataBindingComplete
    '    Debug.WriteLine("DataBindingComplete de Solucions")

    '    'EsborrarCampsSolucio(False)
    '    EstaLaSolucioSeleccionada(False)

    '        For Each Fila As DataGridViewRow In DataSolucions.Rows
    '            If Not IsDBNull(Fila.Cells("Dies").Value) AndAlso IsNumeric(Fila.Cells("Dies").Value) Then
    '                Dim dies As Integer = Convert.ToInt32(Fila.Cells("Dies").Value)

    '                If dies <= 90 AndAlso dies >= 1 Then
    '                    Fila.DefaultCellStyle.BackColor = Color.Orange
    '                ElseIf dies <= 0 Then
    '                    Fila.DefaultCellStyle.BackColor = Color.Red
    '                End If
    '            End If

    '            'If Fila.Cells("Dies").Value <= 90 And Fila.Cells("Dies").Value >= 1 Then Fila.DefaultCellStyle.BackColor = Color.Orange
    '            'If Fila.Cells("Dies").Value <= 0 Then Fila.DefaultCellStyle.BackColor = Color.Red
    '            If Fila.Cells("Justificat").Value = "Si" Then Fila.DefaultCellStyle.BackColor = Color.LightGreen
    '            If Fila.Cells("Estat").Value = "3" Then Fila.DefaultCellStyle.BackColor = blau
    '            If Fila.Cells("Estat").Value = "1" Then Fila.DefaultCellStyle.BackColor = blau
    '            If Fila.Cells("Estat").Value = "4" Then Fila.DefaultCellStyle.BackColor = blau
    '            If Fila.Cells("Estat").Value = "7" Then Fila.DefaultCellStyle.BackColor = blau
    '            If Fila.Cells("Tipus").Value = 1 Then
    '                Dim style As New DataGridViewCellStyle()
    '                style.Font = New Font(Fila.Cells("Tipus").InheritedStyle.Font, FontStyle.Bold)
    '                style.BackColor = tipus1
    '                style.ForeColor = Color.White
    '                Fila.Cells("Tipus").Style = style

    '            End If
    '            If Fila.Cells("Tipus").Value = 2 Then
    '                Dim style As New DataGridViewCellStyle()
    '                style.Font = New Font(Fila.Cells("Tipus").InheritedStyle.Font, FontStyle.Bold)
    '                style.BackColor = tipus2
    '                style.ForeColor = Color.White
    '                Fila.Cells("Tipus").Style = style
    '            End If
    '        Next



    'End Sub
    Private Sub DataSolucions_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataSolucions.DataBindingComplete
        Debug.WriteLine("DataBindingComplete de Solucions")

        'EsborrarCampsSolucio(False)
        EstaLaSolucioSeleccionada(False)

        For Each Fila As DataGridViewRow In DataSolucions.Rows
            ' Manejo de la columna "Dies"
            If Not IsDBNull(Fila.Cells("Dies").Value) AndAlso IsNumeric(Fila.Cells("Dies").Value) Then
                Dim dies As Integer = Convert.ToInt32(Fila.Cells("Dies").Value)
                Fila.DefaultCellStyle.BackColor = GetDiesBackColor(dies)
            End If

            ' Manejo de "Justificat" y "Estat"
            If Fila.Cells("Justificat").Value = "Si" Then
                Fila.DefaultCellStyle.BackColor = Color.LightGreen
            Else
                Select Case Fila.Cells("Estat").Value.ToString()
                    Case "3", "1", "4", "7"
                        Fila.DefaultCellStyle.BackColor = blau
                End Select
            End If

            ' Estilo para "Tipus"
            ApplyTipusStyle(Fila)
            ApplyTipusAcordStyle(Fila)
        Next
    End Sub

    ' Función para obtener el color de fondo basado en el valor de "Dies"
    Private Function GetDiesBackColor(dies As Integer) As Color
        If dies <= 0 Then
            Return Color.Red
        ElseIf dies <= 90 Then
            Return Color.Orange
        End If
        Return Color.White ' Color predeterminado si no aplica ninguna condición
    End Function

    ' Función para aplicar el estilo según el valor de "Tipus"
    Private Sub ApplyTipusStyle(ByRef Fila As DataGridViewRow)
        Dim style As New DataGridViewCellStyle() With {
        .Font = New Font(Fila.Cells("Tipus").InheritedStyle.Font, FontStyle.Bold),
        .ForeColor = Color.White
    }

        Select Case Fila.Cells("Tipus").Value
            Case 1
                style.BackColor = tipus1
            Case 2
                style.BackColor = tipus2
            Case Else
                Exit Sub ' No aplicamos estilo si no es Tipo 1 o 2
        End Select

        Fila.Cells("Tipus").Style = style
    End Sub
    ' Función para aplicar el estilo según las dos primeras letras de "TipusAcord"
    Private Sub ApplyTipusAcordStyle(ByRef Fila As DataGridViewRow)
        Dim style As New DataGridViewCellStyle() With {
        .Font = New Font(Fila.Cells("TipusAcord").InheritedStyle.Font, FontStyle.Bold),
        .ForeColor = Color.White
    }


        ' Evaluar las dos primeras letras
        Select Case Fila.Cells("TipusAcord").Value
            Case "KD" ' Puedes cambiar estos valores según lo que esperas encontrar
                style.BackColor = kdcolor
            Case "KC"
                style.BackColor = kccolor
            Case Else
                Exit Sub ' No aplicamos estilo si no es un caso esperado
        End Select

        Fila.Cells("TipusAcord").Style = style
    End Sub


    'Afegeix o actualitza una solució
    Private Sub AfegirSolucio(idSolucio As Integer)

        If ComprovaDadesSolucions() = False Then Exit Sub

        Dim conexion As New SQLiteConnection(cadena)
        Dim Query As String
        Dim strCommand As SQLiteCommand
        Dim idTipusSolucio As Integer = CB_TipusSolucio.SelectedValue
        Dim NoAcordTxt As String = NoAcord.Text.Trim()
        Dim Observacions As String = TBObservacions.Text
        Dim DataPagamentTxt, DataFacturaTxt, DataContracteTxt, DataVencimentTxt, DataVenciment2Txt As String
        Dim seleccio As Boolean
        Dim Justificat As String
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
            DataVenciment2Txt = Format(DataVenciment2, "yyyy-MM-dd")
        Else
            DataVencimentTxt = Format(Date.Now.AddYears(1000), "yyyy-MM-dd")
        End If

        If CheckEstaJustificat.Checked = True Then
            Justificat = "'Si'"
        Else
            Justificat = "'No'"
        End If

        Try
            ' Primeres justificacions
            If (seleccio = True) Then

                Query = "UPDATE Solucions SET
                            idSolucio=" & idTipusSolucio & ", 
                            Contracte= " & StringDB(NoAcordTxt) & ",                            
                            DataContracte=" & StringDB(DataContracteTxt) & ",
                            DataFactura= " & StringDB(DataFacturaTxt) & ",
                            DataPagament= " & StringDB(DataPagamentTxt) & ",
                            DataVenciment=" & StringDB(DataVencimentTxt) & ", 
                            Justificat=" & Justificat & ",                            
                            PagamentFet=" & CB_PagamentFet.Checked & ",                            
                            Observacions=" & StringDB(Observacions) & ",
                            Quantitat=" & InfoVariableNum.Value &
                            " WHERE Contracte=" & StringDB(NoAcordTxt) & " AND tipus=" & tipusJustificacioSeleccionada


            Else
                Query = "INSERT INTO Solucions (IdSolucio,Tipus,Contracte,DataContracte,DataFactura,DataPagament,DataVenciment,idEmpresa,Justificat,PagamentFet,Observacions,Quantitat) VALUES (" &
                                 idTipusSolucio & "," &
                                 "1" & "," &
                                 StringDB(NoAcordTxt) & "," &
                                 StringDB(DataContracteTxt) & "," &
                                 StringDB(DataFacturaTxt) & "," &
                                 StringDB(DataPagamentTxt) & "," &
                                 StringDB(DataVencimentTxt) & "," &
                                 idEmpresaSeleccionada & "," &
                                 Justificat & "," &
                                 CB_PagamentFet.Checked & "," &
                                 StringDB(Observacions) & "," &
                                 InfoVariableNum.Value & ")"

            End If



            conexion.Open()
            If conexion.State = ConnectionState.Open Then
                strCommand = New SQLiteCommand(Query, conexion)
                strCommand.ExecuteNonQuery()
            End If

            ' Segones justificacions
            If seleccio = True Then
                Query = "UPDATE Solucions SET
                            idSolucio=" & idTipusSolucio & ", 
                            Contracte= " & StringDB(NoAcordTxt) & ",                            
                            DataContracte=" & StringDB(DataContracteTxt) & ",
                            DataFactura= " & StringDB(DataFacturaTxt) & ",
                            DataPagament= " & StringDB(DataPagamentTxt) & ",
                            DataVenciment= " & StringDB(DataVenciment2Txt) &
                           " WHERE Contracte=" & StringDB(NoAcordTxt) & " AND tipus=2"
            Else

                Query = "INSERT INTO Solucions (IdSolucio,Tipus,Contracte,DataContracte,DataFactura,DataPagament,DataVenciment,idEmpresa,Justificat,PagamentFet,Observacions,Quantitat) VALUES (" &
                                 idTipusSolucio & "," &
                                 "2" & "," &
                                 StringDB(NoAcordTxt) & "," &
                                 StringDB(DataContracteTxt) & "," &
                                 StringDB(DataFacturaTxt) & "," &
                                 StringDB(DataPagamentTxt) & "," &
                                 StringDB("") & "," &
                                 idEmpresaSeleccionada & "," &
                                 Justificat & "," &
                                 CB_PagamentFet.Checked & "," &
                                 StringDB(Observacions) & "," &
                                 InfoVariableNum.Value & ")"
            End If

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

            Dim lector As SQLiteDataReader

            If conexion.State = ConnectionState.Open Then
                'Introduim primera justificació
                Query = "SELECT * FROM Solucions WHERE idSolucio=" & idSolucio & " AND idEmpresa=" & idEmpresa & " AND tipus=1"
                strCommand = New SQLiteCommand(Query, conexion)

                lector = strCommand.ExecuteReader
                If lector.Read Then
                    id = lector.GetValue("Id")
                End If
                lector.Close()

                Query = "INSERT INTO Justificacions (IdSolucio,Subvencio) VALUES (" & id & "," & InfoSubvencio.Text & ")"

                strCommand = New SQLiteCommand(Query, conexion)
                strCommand.ExecuteNonQuery()

                ' Introduim segona justificació
                Query = "SELECT * FROM Solucions WHERE idSolucio=" & idSolucio & " AND idEmpresa=" & idEmpresa & " AND tipus=2"
                strCommand = New SQLiteCommand(Query, conexion)

                lector = strCommand.ExecuteReader
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
            TBObservacions.Enabled = True
            Btn_AfegirSolucio.Enabled = True
            Btn_esborrarEmpresa.Enabled = True
        Else
            CB_TipusSolucio.Enabled = False
            NoAcord.Enabled = False

            CB_DataPagamentIVA.Enabled = False
            CheckEstaJustificat.Enabled = False
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
        carregaTipusSolucions()
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
            CB_PagamentFet.Enabled = True
        Else
            verificat.Visible = False
            CB_PagamentFet.Enabled = False
            CB_PagamentFet.Checked = False
        End If
    End Sub

    'Private Sub DataSolucions_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataSolucions.CellFormatting


    '    Dim dgv As DataGridView = sender

    '    If dgv.Columns(e.ColumnIndex).Name = "Dies" Then
    '        If Not IsDBNull(e.Value) AndAlso IsNumeric(e.Value) Then
    '            If e.Value < 0 Then
    '                e.Value = "Caducat"
    '            ElseIf e.Value > 365000 Then
    '                e.Value = "Pendent"
    '            End If
    '        Else
    '            e.Value = "Pendent"
    '        End If
    '    End If


    '    'If dgv.Columns(e.ColumnIndex).Name = "Dies" Then
    '    '    If IsDBNull(e.Value) Then
    '    '        If e.Value < 0 Then
    '    '            e.Value = "Caducat"
    '    '        ElseIf e.Value > 365000 Then
    '    '            e.Value = "Pendent"
    '    '        End If
    '    '    Else
    '    '        e.Value = "Pendent"
    '    '    End If
    '    'End If

    '    If dgv.Columns(e.ColumnIndex).Name = "Dia factura" Then
    '        If IsDBNull(e.Value) Then e.Value = "Pendent"
    '    End If

    '    If dgv.Columns(e.ColumnIndex).Name = "Dia contracte" Then
    '        If IsDBNull(e.Value) Then e.Value = "Pendent"
    '    End If

    '    If dgv.Columns(e.ColumnIndex).Name = "Data venciment" Then
    '        If IsDBNull(e.Value) Then e.Value = "Pendent"
    '    End If


    'End Sub
    Private Sub DataSolucions_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataSolucions.CellFormatting
        Dim dgv As DataGridView = sender

        ' Formateo de la columna "Dies"
        If dgv.Columns(e.ColumnIndex).Name = "Dies" Then
            e.Value = FormatDiesColumn(e.Value)
        End If

        ' Formateo de las columnas de fecha
        If {"Dia factura", "Dia contracte", "Dia venciment", "DataPagament"}.Contains(dgv.Columns(e.ColumnIndex).Name) Then
            e.Value = If(IsDBNull(e.Value), "Pendent", e.Value)
        End If
    End Sub

    ' Función para formatear la columna "Dies"
    Private Function FormatDiesColumn(value As Object) As String

        If Not IsDBNull(value) AndAlso IsNumeric(value) Then
            Dim dies As Integer = Convert.ToInt32(value)
            If dies < 0 Then
                Return "Caducat"
                'ElseIf dies > 365000 Then
                '    Return "Pendent"
            Else
                Return value
            End If
        Else
            Return "Pendent"
        End If
        Return value
    End Function

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
            Dim tipusJustificacio As Integer = DataSolucions.Rows(RowBorrar).Cells("Tipus").Value

            Dim EstatJustificacio As New EstatJustificacio(TitolEmpresa.Text, TitolSolucio.Text, idEmpresaSeleccionada, IdSolucio, CB_TipusSolucio.SelectedValue, InfoSubvencio.Text, tipusJustificacio)

            OpenSubFormDialog(EstatJustificacio)
            OmpleSolucions(idEmpresaSeleccionada)
            EsborrarCampsSolucio(True)
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

    'Private Sub MiraCaducitat()

    '    Dim dies As Integer = 0

    '    Dim CaducitatContracte As Date = DataContracte.Value.AddMonths(My.Settings.MesosContractacio)
    '    Dim CaducitatFactura As Date = DataFactura.Value.AddMonths(My.Settings.MesosFactura)
    '    Dim CaducitatPagament As Date = DataFactura.Value.AddMonths(My.Settings.MesosFactura)

    '    Dim CaducitatJustificacio As Date

    '    If tipusJustificacioSeleccionada = 1 Then
    '        CaducitatJustificacio = DataFactura.Value.AddMonths(My.Settings.MesosFactura + 3)
    '    ElseIf tipusJustificacioSeleccionada = 2 Then
    '        CaducitatJustificacio = DataFactura.Value.AddMonths(My.Settings.MesosSuport + 3)
    '    End If

    '    Debug.WriteLine("Data antes: " + CaducitatJustificacio)
    '    Dim CaducitatConcessio As Date = DataAprovacio.Value.AddMonths(My.Settings.MesosAprovacio)

    '    DiesCaducitat.Clear()
    '    DataCaducitat.Clear()

    '    ' Comprovem si les dates de contractació son correctes

    '    'If CB_DataFactura.Checked = True Then
    '    '    DataContracteOK.Image = My.Resources.verificado_petit
    '    'Else
    '    '    If DateDiff(DateInterval.Day, Now, CaducitatContracte) < 0 Then
    '    '        DataContracteOK.Image = My.Resources.sin_verificar_petit
    '    '    Else
    '    '        DataContracteOK.Image = My.Resources.verificado_petit
    '    '    End If
    '    'End If

    '    '' Comprovem si les dates de la factura son correctes

    '    'If DataFactura.Value.Date > CaducitatContracte Then
    '    '    DataFacturaOK.Image = My.Resources.sin_verificar_petit
    '    'Else
    '    '    DataFacturaOK.Image = My.Resources.verificado_petit
    '    'End If

    '    ''Comprovem si les dates del pagament son correctes

    '    'If DataPagament.Value.Date > CaducitatContracte Then
    '    '    DataPagamentOK.Image = My.Resources.sin_verificar_petit
    '    'Else
    '    '    DataPagamentOK.Image = My.Resources.verificado_petit
    '    'End If

    '    '' Comprovem si les dates de la concessio son correctes

    '    'If CB_DataConcessio.Checked = True Then
    '    '    If DataSolucions.RowCount > 0 Then
    '    '        DataConcessioOK.Image = My.Resources.verificado_petit
    '    '    Else
    '    '        If DateDiff(DateInterval.Day, Now, CaducitatConcessio) < 0 Then
    '    '            DataConcessioOK.Image = My.Resources.sin_verificar_petit
    '    '        Else
    '    '            DataConcessioOK.Image = My.Resources.verificado_petit
    '    '        End If
    '    '    End If
    '    DataVenciment = CaducitatConcessio
    '    'End If

    '    If CB_DataContracte.Checked = True Then DataVenciment = CaducitatContracte
    '    If CB_DataFactura.Checked = True Then DataVenciment = CaducitatFactura
    '    If CheckEstaJustificat.Checked = True Then DataVenciment = CaducitatJustificacio

    '    Debug.WriteLine("Data despues: " + CaducitatJustificacio)

    '    dies = DateDiff(DateInterval.Day, Now, DataVenciment)
    '    Debug.WriteLine("Dias despues: " + dies.ToString)

    '    If tipusJustificacioSeleccionada = 1 Then
    '        If CheckEstaJustificat.Checked Then
    '            DiesCaducitat.Text = "Validat"
    '            DataCaducitat.Text = "Validat"
    '        Else
    '            If CB_DataFactura.Checked Then
    '                If dies >= 0 Then
    '                    DiesCaducitat.Text = dies.ToString
    '                    DataCaducitat.Text = Format(DataVenciment.Date, "Short Date")
    '                Else
    '                    DiesCaducitat.Text = "Caducat"
    '                    DataCaducitat.Text = "Caducat"
    '                End If
    '            Else
    '                If dies >= 0 Then
    '                    DiesCaducitat.Text = dies.ToString
    '                    DataCaducitat.Text = Format(DataVenciment.Date, "Short Date")
    '                Else
    '                    DiesCaducitat.Text = "Caducat"
    '                    DataCaducitat.Text = "Caducat"
    '                End If
    '            End If
    '        End If
    '    ElseIf tipusJustificacioSeleccionada = 2 Then
    '        Debug.WriteLine(CheckEstaJustificat.Checked.ToString)
    '        If CheckEstaJustificat.Checked Then
    '            DiesCaducitat.Text = "Validat"
    '            DataCaducitat.Text = "Validat"
    '        Else
    '            If CB_DataFactura.Checked Then
    '                If dies >= 0 Then
    '                    DiesCaducitat.Text = dies.ToString
    '                    DataCaducitat.Text = Format(DataVenciment.Date, "Short Date")
    '                Else
    '                    DiesCaducitat.Text = "Caducat"
    '                    DataCaducitat.Text = "Caducat"
    '                End If
    '            Else
    '                DiesCaducitat.Text = "Pendent"
    '                DataCaducitat.Text = "Pendent"
    '            End If
    '        End If
    '    End If


    '    'dies = DateDiff(DateInterval.Day, Now, DataVenciment)

    '    'If tipusJustificacioSeleccionada <> 2 Then
    '    '    If solucioSeleccionada Then
    '    '        If CB_DataConcessio.Checked = True Then
    '    '            If dies >= 0 Then
    '    '                DiesCaducitat.Text = dies.ToString
    '    '                DataCaducitat.Text = Format(DataVenciment.Date, "Short Date")
    '    '            Else
    '    '                DiesCaducitat.Text = "Caducat"
    '    '                DataCaducitat.Text = Format(DataVenciment.Date, "Short Date")
    '    '            End If
    '    '        Else
    '    '            DiesCaducitat.Text = ""
    '    '            DataCaducitat.Text = ""
    '    '        End If
    '    '    Else
    '    '        If teContractes = 1 And CB_TipusSolucio.SelectedValue = Nothing Then
    '    '            DiesCaducitat.Text = ""
    '    '            DataCaducitat.Text = ""
    '    '        Else
    '    '            If CB_DataConcessio.Checked = True Then
    '    '                If dies >= 0 Then
    '    '                    DiesCaducitat.Text = dies.ToString
    '    '                    DataCaducitat.Text = Format(DataVenciment.Date, "Short Date")
    '    '                Else
    '    '                    DiesCaducitat.Text = "Caducat"
    '    '                    DataCaducitat.Text = Format(DataVenciment.Date, "Short Date")
    '    '                    Debug.WriteLine("Data caducitat: " + Format(DataVenciment.Date, "Short Date"))
    '    '                End If
    '    '            Else
    '    '                DiesCaducitat.Text = ""
    '    '                DataCaducitat.Text = ""
    '    '            End If
    '    '        End If
    '    '    End If
    '    'Else
    '    '    If CB_DataFactura.Checked Then
    '    '        If dies >= 0 Then
    '    '            DiesCaducitat.Text = dies.ToString
    '    '            DataCaducitat.Text = Format(DataVenciment.Date, "Short Date")
    '    '        Else
    '    '            DiesCaducitat.Text = "Caducat"
    '    '            DataCaducitat.Text = Format(DataVenciment.Date, "Short Date")
    '    '        End If
    '    '    Else
    '    '        DiesCaducitat.Text = "Pendent"
    '    '        DataCaducitat.Text = "Pendent"
    '    '    End If
    '    'End If

    'End Sub
    Private Sub MiraCaducitat()
        ' Verifica si el método está siendo ejecutado desde un hilo diferente al hilo principal
        If Me.InvokeRequired Then
            ' Si estamos en un hilo diferente, invocamos el método en el hilo principal
            Me.Invoke(New Action(AddressOf MiraCaducitat))
        Else
            ' Lógica para verificar la caducidad en el hilo principal

            Dim dies As Integer = 0

            ' Calculamos las fechas de caducidad con base en los valores del DateTimePicker y las configuraciones
            Dim CaducitatContracte As Date = DataContracte.Value.AddMonths(My.Settings.MesosContractacio)
            Dim CaducitatFactura As Date = DataFactura.Value.AddMonths(My.Settings.MesosFactura)
            Dim CaducitatPagament As Date = DataFactura.Value.AddMonths(My.Settings.MesosFactura)

            Dim CaducitatJustificacio As Date

            ' Verificamos el tipo de justificación seleccionada y calculamos la fecha de caducidad correspondiente
            If tipusJustificacioSeleccionada = 1 Then
                CaducitatJustificacio = DataFactura.Value.AddMonths(My.Settings.MesosFactura + 3)
            End If

            Dim CaducitatConcessio As Date = DataAprovacio.Value.AddMonths(My.Settings.MesosAprovacio)

            ' Limpiamos los controles de días y fecha de caducidad

            DiesCaducitat.Text = "-"
            DataCaducitat.Text = "-"

            ' Calculamos la fecha de vencimiento según los CheckBoxes
            DataVenciment = CaducitatConcessio
            If CB_DataContracte.Checked = True Then DataVenciment = CaducitatContracte
            If CB_DataFactura.Checked = True Then
                DataVenciment = CaducitatFactura
                DataVenciment2 = CaducitatFactura.AddYears(1)
            End If


            'If CheckEstaJustificat.Checked = True Then DataVenciment = CaducitatJustificacio

            If tipusJustificacioSeleccionada = 2 Then DataVenciment = DataFactura.Value.AddMonths(My.Settings.MesosSuport + 3)

            ' Calculamos los días restantes hasta la fecha de vencimiento
            dies = DateDiff(DateInterval.Day, Now.Date, DataVenciment.Date)

            ' Verificamos el tipo de justificación seleccionada para establecer el texto correspondiente
            Debug.WriteLine("Contractes: " + teContractes.ToString)
            Debug.WriteLine("Tipus: " + tipusJustificacioSeleccionada.ToString)
            If tipusJustificacioSeleccionada = 1 Then

                If CheckEstaJustificat.Checked Then
                    DiesCaducitat.Text = "Validat"
                    DataCaducitat.Text = "Validat"
                Else
                    If CB_DataFactura.Checked Then
                        If dies >= 0 Then
                            DiesCaducitat.Text = dies.ToString()
                            DataCaducitat.Text = Format(DataVenciment.Date, "Short Date")
                        Else
                            DiesCaducitat.Text = "Caducat"
                            DataCaducitat.Text = "Caducat"
                        End If
                    Else
                        If dies >= 0 Then
                            DiesCaducitat.Text = dies.ToString()
                            DataCaducitat.Text = Format(DataVenciment.Date, "Short Date")
                        Else
                            DiesCaducitat.Text = "Caducat"
                            DataCaducitat.Text = "Caducat"
                        End If
                    End If
                End If

            ElseIf tipusJustificacioSeleccionada = 2 Then
                If CheckEstaJustificat.Checked Then
                    DiesCaducitat.Text = "Validat"
                    DataCaducitat.Text = "Validat"
                Else
                    If CB_DataFactura.Checked Then
                        If dies >= 0 Then
                            DiesCaducitat.Text = dies.ToString()
                            DataCaducitat.Text = Format(DataVenciment.Date, "Short Date")
                        Else
                            DiesCaducitat.Text = "Caducat"
                            DataCaducitat.Text = "Caducat"
                        End If
                    Else
                        DiesCaducitat.Text = "Pendent"
                        DataCaducitat.Text = "Pendent"
                    End If
                End If
            ElseIf tipusJustificacioSeleccionada = 0 Then

                If teContractes = 1 Then
                    DiesCaducitat.Text = "-"
                    DataCaducitat.Text = "-"
                Else
                    If dies > 0 Then
                        DiesCaducitat.Text = dies.ToString()
                        DataCaducitat.Text = Format(DataVenciment.Date, "Short Date")
                    Else
                        DiesCaducitat.Text = "Caducat"
                        DataCaducitat.Text = "Caducat"
                    End If

                End If

            End If
        End If
    End Sub


    Private Sub CB_DataContracte_Click(sender As Object, e As EventArgs) Handles CB_DataContracte.Click
        DataContracte.Value = Date.Now
        MiraCaducitat()
    End Sub
    Private Sub CB_DataFactura_Click(sender As Object, e As EventArgs) Handles CB_DataFactura.Click
        DataFactura.Value = Date.Now
        MiraCaducitat()
    End Sub
    Private Sub CB_DataPagamentIVA_Click(sender As Object, e As EventArgs) Handles CB_DataPagamentIVA.Click
        DataPagament.Value = Date.Now
        MiraCaducitat()
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

    Private Sub CB_PagamentFet_CheckedChanged(sender As Object, e As EventArgs) Handles CB_PagamentFet.CheckedChanged
        If CB_PagamentFet.Checked = True Then
            Pagat1.Visible = True
        Else
            Pagat1.Visible = False
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
        'If TB_CercaEmpreses.Text <> "" Then
        EsborrarCampsSolucio(True)
        EsborraCampsEmpresa()
        EstaLaEmpresaSeleccionada(False)
        EstaLaSolucioSeleccionada(False)
        TB_CercaEmpreses.Clear()
        DataEmpreses.ClearSelection()
        'End If
    End Sub

    Private Sub TB_CercaEmpreses_TextChanged(sender As Object, e As EventArgs) Handles TB_CercaEmpreses.TextChanged
        ActualitzaEmpreses(TB_CercaEmpreses.Text)
        EsborrarCampsSolucio(True)
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
        vuelta = vuelta + 1
    End Sub
    'Omple els camps de la solucio rebuda per posicio a la taula
    'Private Sub OmpleDadesSolucions(Index As Integer)

    '    EsborrarCampsSolucio(False)

    '    Dim row As DataGridViewRow = DataSolucions.Rows(Index)

    '    CB_TipusSolucio.Text = row.Cells("Nom").Value
    '    NoAcord.Text = row.Cells("Contracte").Value
    '    GestionaInfo(row.Cells("IdSolucio").Value)

    '    idSolucioSeleccionada = row.Cells("Id").Value
    '    tipusJustificacioSeleccionada = row.Cells("Tipus").Value
    '    TitolSolucio.Text = row.Cells("Nom").Value
    '    TBObservacions.Text = row.Cells("Observacions").Value
    '    InfoVariableNum.Value = row.Cells("Quantitat").Value

    '    DataPresentacio = row.Cells("DataPresentacio").Value

    '    If row.Cells("Justificat").Value = "Si" Then
    '        CheckEstaJustificat.Checked = True
    '    Else
    '        CheckEstaJustificat.Checked = False
    '    End If

    '    CB_PrimerPagament.Checked = row.Cells("PrimerPagament").Value

    '    If Not IsDBNull(row.Cells("Dia contracte").Value) Then
    '        If row.Cells("Dia contracte").Value <> "" Then
    '            DataContracte.Text = Format(row.Cells("Dia contracte").Value, "Short Date")
    '            CB_DataContracte.Checked = True
    '        Else
    '            DataContracte.Text = Date.Now
    '            CB_DataContracte.Checked = False
    '        End If
    '    End If

    '    If Not IsDBNull(row.Cells("Dia factura").Value) Then
    '        If row.Cells("Dia factura").Value <> "" Then
    '            DataFactura.Text = Format(row.Cells("Dia factura").Value, "Short Date")
    '            CB_DataFactura.Checked = True
    '        Else
    '            DataFactura.Text = Date.Now
    '            CB_DataFactura.Checked = False
    '        End If
    '    End If

    '    If Not IsDBNull(row.Cells("DataPagament").Value) Then
    '        If row.Cells("DataPagament").Value <> "" Then
    '            DataPagament.Text = Format(row.Cells("DataPagament").Value, "Short Date")
    '            CB_DataPagamentIVA.Checked = True
    '        Else
    '            DataPagament.Text = Date.Now
    '            CB_DataPagamentIVA.Checked = False
    '        End If
    '    End If

    '    InfoSubvencioReal.Text = row.Cells("Subvencio").Value.ToString

    '    ' Formatejem estats

    '    Select Case row.Cells("Tipus").Value
    '        Case 1
    '            Lbl_tipus.Text = "Primera"
    '            Lbl_tipus.BackColor = tipus1
    '        Case 2
    '            Lbl_tipus.Text = "Segona"
    '            Lbl_tipus.BackColor = tipus2
    '    End Select
    '    Select Case row.Cells("Estat").Value
    '        Case 0
    '            Lbl_estat.Text = "Preparant documentació"
    '            Lbl_estat.BackColor = taronja
    '        Case 1
    '            Lbl_estat.Text = "Enviada"
    '            Lbl_estat.BackColor = taronja
    '        Case 2
    '            Lbl_estat.Text = "Esborrany"
    '            Lbl_estat.BackColor = taronja
    '        Case 3
    '            Lbl_estat.Text = "Presentada"
    '            Lbl_estat.BackColor = taronja
    '        Case 4
    '            Lbl_estat.Text = "Termini d'esmena obert"
    '            Lbl_estat.BackColor = vermell
    '        Case 5
    '            Lbl_estat.Text = "Validada per pagament"
    '            Lbl_estat.BackColor = verdClar
    '        Case 6
    '            Lbl_estat.Text = "Pagada"
    '            Lbl_estat.BackColor = verdClar
    '        Case 7
    '            Lbl_estat.Text = "Finalitzat termini d'esmena"
    '            Lbl_estat.BackColor = vermell
    '        Case 8
    '            Lbl_estat.Text = "Esmena incorrecta"
    '            Lbl_estat.BackColor = vermell
    '        Case 9
    '            Lbl_estat.Text = "No pagada"
    '            Lbl_estat.BackColor = vermell
    '        Case 10
    '            Lbl_estat.Text = "Pagament minorat"
    '            Lbl_estat.BackColor = verdClar
    '        Case 11
    '            Lbl_estat.Text = "Documentació addicional"
    '            Lbl_estat.BackColor = vermell
    '    End Select

    '    EstaLaSolucioSeleccionada(True)
    'End Sub
    'Private Sub OmpleDadesSolucions(Index As Integer)

    '    EsborrarCampsSolucio(False)

    '    Dim row As DataGridViewRow = DataSolucions.Rows(Index)

    '    CB_TipusSolucio.Text = row.Cells("Nom").Value
    '    NoAcord.Text = row.Cells("Contracte").Value
    '    GestionaInfo(row.Cells("IdSolucio").Value)

    '    idSolucioSeleccionada = row.Cells("Id").Value
    '    tipusJustificacioSeleccionada = row.Cells("Tipus").Value
    '    TitolSolucio.Text = row.Cells("Nom").Value
    '    TBObservacions.Text = row.Cells("Observacions").Value
    '    InfoVariableNum.Value = row.Cells("Quantitat").Value
    '    DataPresentacio = row.Cells("DataPresentacio").Value

    '    CheckEstaJustificat.Checked = (row.Cells("Justificat").Value = "Si")
    '    CB_PagamentFet.Checked = row.Cells("PagamentFet").Value

    '    ' Simplificación para el manejo de fechas
    '    SetDateControl(DataContracte, CB_DataContracte, row.Cells("Dia contracte").Value)
    '    SetDateControl(DataFactura, CB_DataFactura, row.Cells("Dia factura").Value)
    '    SetDateControl(DataPagament, CB_DataPagamentIVA, row.Cells("DataPagament").Value)

    '    InfoSubvencioReal.Text = row.Cells("Subvencio").Value.ToString

    '    ' Formateo de estatus
    '    Select Case row.Cells("Tipus").Value
    '        Case 1
    '            Lbl_tipus.Text = "Primera"
    '            Lbl_tipus.BackColor = tipus1
    '        Case 2
    '            Lbl_tipus.Text = "Segona"
    '            Lbl_tipus.BackColor = tipus2
    '    End Select

    '    Select Case row.Cells("Estat").Value
    '        Case 0 To 3
    '            Lbl_estat.Text = GetEstatText(row.Cells("Estat").Value)
    '            Lbl_estat.BackColor = taronja
    '        Case 4, 7, 8, 9, 11
    '            Lbl_estat.Text = GetEstatText(row.Cells("Estat").Value)
    '            Lbl_estat.BackColor = vermell
    '        Case 5, 6, 10
    '            Lbl_estat.Text = GetEstatText(row.Cells("Estat").Value)
    '            Lbl_estat.BackColor = verdClar
    '    End Select

    '    EstaLaSolucioSeleccionada(True)

    'End Sub
    Private Sub OmpleDadesSolucions(Index As Integer)
        ' Verifica si el método está siendo ejecutado desde un hilo diferente al hilo principal
        If Me.InvokeRequired Then
            ' Si estamos en un hilo diferente, invocamos el método en el hilo principal
            Me.Invoke(New Action(Of Integer)(AddressOf OmpleDadesSolucions), Index)
        Else
            ' Lógica de la interfaz de usuario en el hilo principal

            ' Limpia los campos de la solución antes de cargar nuevos datos
            EsborrarCampsSolucio(False)

            ' Obtiene la fila seleccionada del DataGridView
            Dim row As DataGridViewRow = DataSolucions.Rows(Index)

            ' Rellena los controles con los datos de la fila
            CB_TipusSolucio.Text = row.Cells("Nom").Value
            NoAcord.Text = row.Cells("Contracte").Value
            GestionaInfo(row.Cells("IdSolucio").Value)

            tipusJustificacioSeleccionada = 0
            ' Asigna valores a las variables y controles relacionados
            idSolucioSeleccionada = row.Cells("Id").Value
            tipusJustificacioSeleccionada = row.Cells("Tipus").Value
            TitolSolucio.Text = row.Cells("Nom").Value
            TBObservacions.Text = row.Cells("Observacions").Value
            InfoVariableNum.Value = row.Cells("Quantitat").Value
            DataPresentacio = row.Cells("DataPresentacio").Value

            ' Actualiza los CheckBoxes
            CheckEstaJustificat.Checked = (row.Cells("Justificat").Value = "Si")
            CB_PagamentFet.Checked = row.Cells("PagamentFet").Value

            ' Simplificación para el manejo de fechas con función auxiliar
            SetDateControl(DataContracte, CB_DataContracte, row.Cells("Dia contracte").Value)
            SetDateControl(DataFactura, CB_DataFactura, row.Cells("Dia factura").Value)
            SetDateControl(DataPagament, CB_DataPagamentIVA, row.Cells("DataPagament").Value)

            ' Actualiza otros controles con datos de la fila
            InfoSubvencioReal.Text = row.Cells("Subvencio").Value.ToString()

            ' Formateo y actualización de estatus visual según el tipo y el estado
            Select Case row.Cells("Tipus").Value
                Case 1
                    Lbl_tipus.Text = "Primera"
                    Lbl_tipus.BackColor = tipus1
                Case 2
                    Lbl_tipus.Text = "Segona"
                    Lbl_tipus.BackColor = tipus2
            End Select

            ' Formateo de colores y texto según el estado
            Select Case row.Cells("Estat").Value
                Case 0 To 3
                    Lbl_estat.Text = GetEstatText(row.Cells("Estat").Value)
                    Lbl_estat.BackColor = taronja
                Case 4, 7, 8, 9, 11
                    Lbl_estat.Text = GetEstatText(row.Cells("Estat").Value)
                    Lbl_estat.BackColor = vermell
                Case 5, 6, 10
                    Lbl_estat.Text = GetEstatText(row.Cells("Estat").Value)
                    Lbl_estat.BackColor = verdClar
            End Select

            ' Finaliza marcando que la solución ha sido seleccionada
            EstaLaSolucioSeleccionada(True)
        End If
    End Sub


    ' Función para gestionar los controles de fecha
    Private Sub SetDateControl(ByRef controlFecha As Control, ByRef checkBox As CheckBox, ByVal valor As Object)
        If Not IsDBNull(valor) AndAlso valor <> "" Then
            controlFecha.Text = Format(valor, "Short Date")
            checkBox.Checked = True
        Else
            controlFecha.Text = Date.Now
            checkBox.Checked = False
        End If
    End Sub

    ' Función para obtener el texto del estado
    Private Function GetEstatText(ByVal estat As Integer) As String
        Select Case estat
            Case 0 : Return "Preparant documentació"
            Case 1 : Return "Enviada"
            Case 2 : Return "Esborrany"
            Case 3 : Return "Presentada"
            Case 4 : Return "Termini d'esmena obert"
            Case 5 : Return "Validada per pagament"
            Case 6 : Return "Pagada"
            Case 7 : Return "Finalitzat termini d'esmena"
            Case 8 : Return "Esmena incorrecta"
            Case 9 : Return "No pagada"
            Case 10 : Return "Pagament minorat"
            Case 11 : Return "Documentació addicional"
            Case Else : Return ""
        End Select
    End Function

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
            Case 12
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
                Debug.Write("Error recibiendo subvencion")
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
        ElseIf segmentEmpresaSeleccionada = 4 Then
            infoMax.Text = "Màxim 99"
            InfoVariableNum.Maximum = 99
        ElseIf segmentEmpresaSeleccionada = 5 Then
            infoMax.Text = "Màxim 145"
            InfoVariableNum.Maximum = 145
        End If
    End Sub

    Private Sub MostraSubvencioConcedida() Handles RB_Segment1.CheckedChanged, RB_Segment2.CheckedChanged, RB_Segment3.CheckedChanged, RB_Segment4.CheckedChanged, RB_Segment5.CheckedChanged

        If RB_Segment1.Checked = True Then TB_ImportBono.Text = "12000"
        If RB_Segment2.Checked = True Then TB_ImportBono.Text = "6000"
        If RB_Segment3.Checked = True Then TB_ImportBono.Text = "3000"
        If RB_Segment4.Checked = True Then TB_ImportBono.Text = "25000"
        If RB_Segment5.Checked = True Then TB_ImportBono.Text = "29000"

    End Sub

    Private Sub btn_importarEmpreses_Click(sender As Object, e As EventArgs) Handles btn_importarEmpreses.Click
        importaEmpresasExcel()
    End Sub

    Private Sub importaEmpresasExcel()
        Dim listaEmpresas As New List(Of Empresa.Empresa)
        Dim listaEmpresasNuevas As New List(Of String)

        Dim rutaArchivo As String

        Try
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
                    ' Crear una nueva instancia de empresa
                    Dim empresa As New Empresa.Empresa()

                    ' Asignar los valores de las celdas a las propiedades de la instancia de Empresa

                    empresa.Nif = row.Cell(1).GetValue(Of String)()
                    empresa.Empresa = row.Cell(2).GetValue(Of String)().ToUpper
                    empresa.Bono = row.Cell(3).GetValue(Of String)().ToUpper
                    empresa.Fecha = row.Cell(4).GetValue(Of String)()
                    empresa.caduca = row.Cell(5).GetValue(Of String)()
                    empresa.Importe = row.Cell(6).GetValue(Of Int32)()

                    ' Agregar la instancia a la lista
                    If Not ExisteNIF(empresa.Nif) Then listaEmpresas.Add(empresa)

                Next
            End Using
        Catch ex As IOException
            MessageBox.Show("El fitxer està en ús per una altra aplicació. Tanqueu el fitxer i torneu-ho a provar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Catch es As Exception
            MessageBox.Show("El fitxer no s'ha pogut obrir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try


        If listaEmpresas.Count > 0 Then
            For Each empresax In listaEmpresas
                Debug.WriteLine("Empresa nova: " + empresax.Empresa + " - NIF: " + empresax.Nif)
                ImportarEmpresa(empresax)
            Next
            Debug.WriteLine("Afegides " + listaEmpresas.Count.ToString + " empreses noves")
            Dim cambiosExcel As cambiosEmpresas = New cambiosEmpresas(listaEmpresas)
            cambiosExcel.Show()
        Else
            MsgBox("No hi ha empreses noves que actualitzar", vbOK, "Actualitzar empreses")

            Debug.WriteLine("No hi ha empreses noves: ")
        End If

    End Sub
    Public Function ExisteNIF(nif As String) As Boolean
        Dim conexion As New SQLiteConnection(cadena)

        ' Convertimos tanto el NIF almacenado en la base de datos como el parámetro a minúsculas
        Dim query As String = "SELECT COUNT(*) FROM Empreses WHERE trim(LOWER(NIF)) = LOWER(@nif);"
        Using cmd As New SQLiteCommand(query, conexion)
            cmd.Parameters.AddWithValue("@nif", nif.ToLower()) ' También podrías usar ToUpper()
            conexion.Open() ' Asegúrate de abrir la conexión
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return count > 0
        End Using
    End Function

End Class