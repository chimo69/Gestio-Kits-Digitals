Imports System.Data.SQLite

Public Class Extras
    Private DT_Extres, DT_ExtresGeneral, DT_EstatSolucions, DT_CercaEmpreses As New DataTable
    Private TotalEmpresaValor, TotalGeneralValor As Double
    Private TotalSolucionsValor As Integer
    Private resultatsPerEmpresa As New List(Of Object())
    Private resultatsTotals As New List(Of Object())
    Private resultatsEstatsTotals As New List(Of Object())
    Private llistaSegments As New List(Of String)

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        CB_Segment1.Checked = True
        CB_Segment2.Checked = True
        CB_Segment3.Checked = True
        CB_Segment4.Checked = True
        CB_Segment5.Checked = True

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub Extras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim conexion As New SQLiteConnection(cadena)

        conexion.Open()

        ' Columna Empreses
        Try
            If conexion.State = ConnectionState.Open Then
                Dim DA As New SQLiteDataAdapter("SELECT id,nom from empreses", conexion)
                DT_CercaEmpreses.Clear()
                DA.Fill(DT_CercaEmpreses)

                If DT_CercaEmpreses.Rows.Count > 0 Then
                    CercaEmpreses.DataSource = DT_CercaEmpreses
                Else
                    CercaEmpreses.DataSource = Nothing
                End If
            End If

        Catch ex As Exception
            MsgBox("No s'ha pogut accedir a la base de dades", vbCritical, "Error")
        End Try

        conexion.Close()

        ' carrega filtre segments



        CarregaSolucionsTotes()
        CarregaEstatsTotes()

    End Sub
    Private Sub CarregaSolucionsEmpresa(idEmpresa As Integer)
        Dim conexion As New SQLiteConnection(cadena)
        Try
            conexion.Open()

            If conexion.State = ConnectionState.Open Then

                Dim query As String = "select Solucions.IdSolucio, TipusSolucions.nom, ROUND (Justificacions.Subvencio * 0.7,1) as Subvencio, TipusEstats.NomEstat, Justificacions.Estat from Solucions
											     INNER JOIN TipusSolucions ON TipusSolucions.Id=Solucions.IdSolucio
                                                 INNER JOIN Justificacions ON Solucions.Id=Justificacions.IdSolucio
											     INNER JOIN TipusEstats ON TipusEstats.ID=Justificacions.Estat
                                                 WHERE Solucions.idEmpresa=" & idEmpresa & " and tipus=1"

                Dim cmd As New SQLiteCommand(query, conexion)
                Dim reader As SQLiteDataReader = cmd.ExecuteReader

                While reader.Read()
                    Dim values(reader.FieldCount - 1) As Object
                    reader.GetValues(values)
                    resultatsPerEmpresa.Add(values)
                End While

                reader.Close()
                conexion.Close()

                If resultatsPerEmpresa.Count > 0 Then
                    ompleDadesSolucionsEmpresa()
                    Panel_SolucionsEmpresa.Visible = True
                    Panel_SolucionsEmpresa2.Visible = True
                Else
                    Panel_SolucionsEmpresa.Visible = False
                    Panel_SolucionsEmpresa2.Visible = False
                End If

            End If
        Catch ex As Exception
            MsgBox("No s'ha pogut accedir a la base de dades", vbCritical, "Error")
        End Try
        conexion.Close()
    End Sub
    Private Sub CarregaSolucionsEmpresa2(idEmpresa As Integer)
        Dim conexion As New SQLiteConnection(cadena)
        Try
            conexion.Open()

            If conexion.State = ConnectionState.Open Then

                Dim query As String = "select Solucions.IdSolucio, TipusSolucions.nom, ROUND(Justificacions.Subvencio * 0.3,1) as Subvencio, TipusEstats.NomEstat, Justificacions.Estat from Solucions
											     INNER JOIN TipusSolucions ON TipusSolucions.Id=Solucions.IdSolucio
                                                 INNER JOIN Justificacions ON Solucions.Id=Justificacions.IdSolucio
											     INNER JOIN TipusEstats ON TipusEstats.ID=Justificacions.Estat
                                                 WHERE Solucions.idEmpresa=" & idEmpresa & " and tipus=2"
                Dim cmd As New SQLiteCommand(query, conexion)
                Dim reader As SQLiteDataReader = cmd.ExecuteReader

                While reader.Read()
                    Dim values(reader.FieldCount - 1) As Object
                    reader.GetValues(values)
                    resultatsPerEmpresa.Add(values)
                End While

                reader.Close()
                conexion.Close()

                ompleDadesSolucionsEmpresa2()
                'If resultatsPerEmpresa.Count > 0 Then
                '    ompleDadesSolucionsEmpresa()
                '    Panel_SolucionsEmpresa.Visible = True
                'Else
                '    Panel_SolucionsEmpresa.Visible = False
                'End If

            End If
        Catch ex As Exception
            MsgBox("No s'ha pogut accedir a la base de dades", vbCritical, "Error")
        End Try
        conexion.Close()
    End Sub
    Private Sub CarregaSolucionsTotes()
        Dim conexion As New SQLiteConnection(cadena)
        Dim filtre As String = ""
        Try
            conexion.Open()

            llistaSegments.Clear()

            If CB_Segment1.Checked Then llistaSegments.Add("1")
            If CB_Segment2.Checked Then llistaSegments.Add("2")
            If CB_Segment3.Checked Then llistaSegments.Add("3")
            If CB_Segment4.Checked Then llistaSegments.Add("4")
            If CB_Segment5.Checked Then llistaSegments.Add("5")

            If llistaSegments.Any() Then
                filtre = " AND segment IN (" & String.Join(",", llistaSegments) & ")"
            Else
                filtre = " AND 1=2 "
            End If

            If conexion.State = ConnectionState.Open Then
                Dim query As String = "SELECT TipusSolucions.id, TipusSolucions.Nom as 'Solució',  count(Justificacions.id) as Quantitat, sum(Justificacions.Subvencio) as Subvencions from Solucions
                                                 INNER JOIN TipusSolucions ON TipusSolucions.Id=Solucions.IdSolucio
                                                 INNER JOIN Justificacions ON Solucions.Id=Justificacions.IdSolucio
                                                 INNER JOIN Empreses ON Solucions.idEmpresa = Empreses.Id
                                                 WHERE Tipus=1" & filtre & "    
                                                 GROUP by TipusSolucions.Nom"

                Dim cmd As New SQLiteCommand(query, conexion)
                Dim reader As SQLiteDataReader = cmd.ExecuteReader

                resultatsTotals.Clear()

                While reader.Read()
                    Dim values(reader.FieldCount - 1) As Object
                    reader.GetValues(values)
                    resultatsTotals.Add(values)
                End While

                reader.Close()
                conexion.Close()

                'If resultatsTotals.Count > 0 Then
                ompleDadesSolucionsTotes()
                'End If

            End If
        Catch ex As Exception
            MsgBox("No s'ha pogut accedir a la base de dades", vbCritical, "Error")
        End Try
        conexion.Close()
    End Sub

    Private Sub CarregaEstatsTotes()
        Dim conexion As New SQLiteConnection(cadena)
        Dim filtre As String = ""
        Try
            conexion.Open()

            If conexion.State = ConnectionState.Open Then

                llistaSegments.Clear()

                If CB_Segment1.Checked Then llistaSegments.Add("1")
                If CB_Segment2.Checked Then llistaSegments.Add("2")
                If CB_Segment3.Checked Then llistaSegments.Add("3")
                If CB_Segment4.Checked Then llistaSegments.Add("4")
                If CB_Segment5.Checked Then llistaSegments.Add("5")

                If llistaSegments.Any() Then
                    filtre = " AND segment IN (" & String.Join(",", llistaSegments) & ")"
                Else
                    filtre = " AND 1=2 "
                End If

                Dim query As String = "SELECT TipusEstats.Id, count(Justificacions.Estat), tipus from Justificacions                                               
                                                 INNER JOIN TipusEstats ON TipusEstats.Id=Justificacions.Estat
                                                 INNER JOIN Solucions ON Justificacions.IdSolucio=Solucions.Id
                                                 INNER JOIN Empreses ON Solucions.idEmpresa = Empreses.Id
                                                 WHERE 1=1 " & filtre &
                                                 "GROUP by Justificacions.Estat, tipus"

                Debug.WriteLine(query)
                Dim cmd As New SQLiteCommand(query, conexion)
                Dim reader As SQLiteDataReader = cmd.ExecuteReader

                resultatsEstatsTotals.Clear()
                While reader.Read()
                    Dim values(reader.FieldCount - 1) As Object
                    reader.GetValues(values)
                    resultatsEstatsTotals.Add(values)
                End While

                reader.Close()
                conexion.Close()

                'If resultatsEstatsTotals.Count > 0 Then
                ompleDadesSolucionsEstatTotes()
                'End If

            End If
        Catch ex As Exception
            MsgBox("No s'ha pogut accedir a la base de dades", vbCritical, "Error")
        End Try
        conexion.Close()
    End Sub
    Private Sub ompleDadesSolucionsTotes()

        Dim TotalEmpreses As Double = 0

        TB_SitioWeb_TotalNum.Text = "0"
        TB_Ciberseguridad_TotalNum.Text = "0"
        TB_BI_TotalNum.Text = "0"
        TB_GestionProcesos_TotalNum.Text = "0"
        TB_FacturaElectronica_TotalNum.Text = "0"
        TB_OficinaVirtual_TotalNum.Text = "0"
        TB_ComunicacionesSeguras_TotalNum.Text = "0"
        TB_Ciberseguridad_TotalNum.Text = "0"
        TB_PuestoSeguro_TotalNum.Text = "0"
        TB_CiberseguridadGestionada_TotalNum.Text = "0"
        TB_ProcesosIA_TotalNum.Text = "0"
        TB_BusinessIA_TotalNum.Text = "0"
        TB_ComercioElectronico_TotalNum.Text = "0"

        TB_SitioWeb_SubTotal.Text = "0 €"
        TB_Ciberseguridad_SubTotal.Text = "0 €"
        TB_BI_SubTotal.Text = "0 €"
        TB_GestionProcesos_SubTotal.Text = "0 €"
        TB_FacturaElectronica_SubTotal.Text = "0 €"
        TB_OficinaVirtual_SubTotal.Text = "0 €"
        TB_ComunicacionesSeguras_SubTotal.Text = "0 €"
        TB_Ciberseguridad_SubTotal.Text = "0 €"
        TB_PuestoSeguro_SubTotal.Text = "0 €"
        TB_CiberseguridadGestionada_SubTotal.Text = "0 €"
        TB_ProcesosIA_SubTotal.Text = "0 €"
        TB_BusinessIA_SubTotal.Text = "0 €"
        TB_ComercioElectronico_SubTotal.Text = "0 €"

        For Each result As Object In resultatsTotals
            TotalEmpreses += result(3)
            Select Case result(0)
                Case 1
                    TB_SitioWeb_TotalNum.Text = result(2)
                    TB_SitioWeb_SubTotal.Text = result(3).ToString + " €"
                Case 2
                    TB_ComercioElectronico_TotalNum.Text = result(2)
                    TB_ComercioElectronico_SubTotal.Text = result(3).ToString + " €"
                Case 3, 4
                Case 5
                    TB_BI_TotalNum.Text = result(2)
                    TB_BI_SubTotal.Text = result(3).ToString + " €"
                Case 6
                    TB_GestionProcesos_TotalNum.Text = result(2)
                    TB_GestionProcesos_SubTotal.Text = result(3).ToString + " €"
                Case 7
                    TB_FacturaElectronica_TotalNum.Text = result(2)
                    TB_FacturaElectronica_SubTotal.Text = result(3).ToString + " €"
                Case 8
                    TB_OficinaVirtual_TotalNum.Text = result(2)
                    TB_OficinaVirtual_SubTotal.Text = result(3).ToString + " €"
                Case 9
                    TB_ComunicacionesSeguras_TotalNum.Text = result(2)
                    TB_ComunicacionesSeguras_SubTotal.Text = result(3).ToString + " €"
                Case 10
                    TB_Ciberseguridad_TotalNum.Text = result(2)
                    TB_Ciberseguridad_SubTotal.Text = result(3).ToString + " €"
                Case 11
                    TB_PuestoSeguro_TotalNum.Text = result(2)
                    TB_PuestoSeguro_SubTotal.Text = result(3).ToString + " €"
                Case 12
                    TB_CiberseguridadGestionada_TotalNum.Text = result(2)
                    TB_CiberseguridadGestionada_SubTotal.Text = result(3).ToString + " €"
                Case 13
                    TB_ProcesosIA_TotalNum.Text = result(2)
                    TB_ProcesosIA_SubTotal.Text = result(3).ToString + " €"
                Case 14
                    TB_BusinessIA_TotalNum.Text = result(2)
                    TB_BusinessIA_SubTotal.Text = result(3).ToString + " €"

            End Select
        Next
        TB_SubTotal.Text = TotalEmpreses.ToString("C0", New Globalization.CultureInfo("es-ES"))
        resultatsTotals.Clear()
    End Sub
    Private Sub ompleDadesSolucionsEstatTotes()

        TB_Preparant.Text = "0"
        TB_Enviada.Text = "0"
        TB_Esborrany.Text = "0"
        TB_Presentada.Text = "0"
        TB_EsmenaObert.Text = "0"
        TB_ValidadaPagament.Text = "0"
        TB_Pagada.Text = "0"
        TB_FinalitzadaEsmena.Text = "0"
        TB_EsmenaIncorrecta.Text = "0"
        TB_NoPagada.Text = "0"
        TB_pagamentMinorat1.Text = "0"
        TB_DocumentacioAddicional.Text = "0"

        TB_preparant2.Text = "0"
        TB_Enviada2.Text = "0"
        TB_Esborrany2.Text = "0"
        TB_Presentada2.Text = "0"
        TB_EsmenaObert2.Text = "0"
        TB_ValidadaPagament2.Text = "0"
        TB_Pagada2.Text = "0"
        TB_FinalitzadaEsmena2.Text = "0"
        TB_EsmenaIncorrecta2.Text = "0"
        TB_NoPagada2.Text = "0"
        TB_PagamentMinorat2.Text = "0"
        TB_DocumentacioAddicional2.Text = "0"


        For Each result As Object In resultatsEstatsTotals

            Select Case result(0)
                Case 0
                    If result(2) = 1 Then
                        TB_Preparant.Text = result(1)
                    Else
                        TB_preparant2.Text = result(1)
                    End If
                Case 1
                    If result(2) = 1 Then
                        TB_Enviada.Text = result(1)
                    Else
                        TB_Enviada2.Text = result(1)
                    End If
                Case 2
                    If result(2) = 1 Then
                        TB_Esborrany.Text = result(1)
                    Else
                        TB_Esborrany2.Text = result(1)
                    End If
                Case 3
                    If result(2) = 1 Then
                        TB_Presentada.Text = result(1)
                    Else
                        TB_Presentada2.Text = result(1)
                    End If
                Case 4
                    If result(2) = 1 Then
                        TB_EsmenaObert.Text = result(1)
                    Else
                        TB_EsmenaObert2.Text = result(1)
                    End If
                Case 5
                    If result(2) = 1 Then
                        TB_ValidadaPagament.Text = result(1)
                    Else
                        TB_ValidadaPagament2.Text = result(1)
                    End If
                Case 6
                    If result(2) = 1 Then
                        TB_Pagada.Text = result(1)
                    Else
                        TB_Pagada2.Text = result(1)
                    End If
                Case 7
                    If result(2) = 1 Then
                        TB_FinalitzadaEsmena.Text = result(1)
                    Else
                        TB_FinalitzadaEsmena2.Text = result(1)
                    End If
                Case 8
                    If result(2) = 1 Then
                        TB_EsmenaIncorrecta.Text = result(1)
                    Else
                        TB_EsmenaIncorrecta2.Text = result(1)
                    End If
                Case 9
                    If result(2) = 1 Then
                        TB_NoPagada.Text = result(1)
                    Else
                        TB_NoPagada2.Text = result(1)
                    End If
                Case 10
                    If result(2) = 1 Then
                        TB_pagamentMinorat1.Text = result(1)
                    Else
                        TB_PagamentMinorat2.Text = result(1)
                    End If
                Case 11
                    If result(2) = 1 Then
                        TB_DocumentacioAddicional.Text = result(1)
                    Else
                        TB_DocumentacioAddicional2.Text = result(1)
                    End If
            End Select
        Next

    End Sub

    Private Sub ompleDadesSolucionsEmpresa()
        Dim TotalEmpresaSeleccionada As Double = 0

        Panel_SitioWeb.Visible = False
        Panel_ComercioElectronico.Visible = False
        Panel_BI.Visible = False
        Panel_GestionProcesos.Visible = False
        Panel_FacturaElectronica.Visible = False
        Panel_OficinaVirtual.Visible = False
        Panel_ComunicacionesSeguras.Visible = False
        Panel_Ciberseguridad.Visible = False
        Panel_PuestoSeguro.Visible = False
        Panel_CiberseguridadGestionada.Visible = False
        Panel_ProcesosIA.Visible = False
        Panel_BusinessIA.Visible = False

        TB_SitioWeb_Estat.BackColor = SystemColors.Control
        TB_ComercioElectronico_Estat.BackColor = SystemColors.Control
        TB_BI_Estat.BackColor = SystemColors.Control
        TB_GestionProcesos_Estat.BackColor = SystemColors.Control
        TB_FacturaElectronica_Estat.BackColor = SystemColors.Control
        TB_FacturaElectronica_Estat.BackColor = SystemColors.Control
        TB_OficinaVirtual_Estat.BackColor = SystemColors.Control
        TB_OficinaVirtual_Estat.BackColor = SystemColors.Control
        TB_Ciberseguridad_Estat.BackColor = SystemColors.Control
        TB_PuestoSeguro_Estat.BackColor = SystemColors.Control
        TB_CiberseguridadGestionada_Estat.BackColor = SystemColors.Control
        TB_ProcesosIA_Estat.BackColor = SystemColors.Control
        TB_BusinessIA_Estat.BackColor = SystemColors.Control

        For Each result As Object In resultatsPerEmpresa

            TotalEmpresaSeleccionada += result(2)

            Select Case result(0)
                Case 1
                    TB_SitioWeb_Sub.Text = result(2).ToString + " €"
                    TB_SitioWeb_Estat.Text = result(3).ToString.ToUpper
                    Panel_SitioWeb.Visible = True
                    If result(4) = 4 Or result(4) = 8 Or result(4) = 9 Or result(4) = 7 Then
                        TB_SitioWeb_Estat.BackColor = vermell
                    End If
                    If result(4) = 5 Or result(4) = 6 Or result(4) = 10 Then
                        TB_SitioWeb_Estat.BackColor = verd
                    End If

                Case 2
                    TB_ComercioElectronico_Sub.Text = result(2).ToString + " €"
                    TB_ComercioElectronico_Estat.Text = result(3).ToString.ToUpper
                    Panel_ComercioElectronico.Visible = True
                    If result(4) = 4 Or result(4) = 8 Or result(4) = 9 Or result(4) = 7 Then
                        TB_ComercioElectronico_Estat.BackColor = vermell
                    End If
                    If result(4) = 5 Or result(4) = 6 Or result(4) = 10 Then
                        TB_ComercioElectronico_Estat.BackColor = verd
                    End If
                Case 3
                Case 4
                Case 5
                    TB_BI_Sub.Text = result(2).ToString + " €"
                    TB_BI_Estat.Text = result(3).ToString.ToUpper
                    Panel_BI.Visible = True
                    If result(4) = 4 Or result(4).ToString = 8 Or result(4) = 9 Or result(4) = 7 Then
                        TB_BI_Estat.BackColor = vermell
                    End If
                    If result(4) = 5 Or result(4) = 6 Or result(4) = 10 Then
                        TB_BI_Estat.BackColor = verd
                    End If
                Case 6

                    TB_GestionProcesos_Sub.Text = result(2).ToString + " €"
                    TB_GestionProcesos_Estat.Text = result(3).ToString.ToUpper
                    Panel_GestionProcesos.Visible = True
                    If result(4) = 4 Or result(4).ToString = 8 Or result(4) = 9 Or result(4) = 7 Then
                        TB_GestionProcesos_Estat.BackColor = vermell
                    End If
                    If result(4) = 5 Or result(4) = 6 Or result(4) = 10 Then
                        TB_GestionProcesos_Estat.BackColor = verd
                    End If
                Case 7
                    TB_FacturaElectronica_Sub.Text = result(2).ToString + " €"
                    TB_FacturaElectronica_Estat.Text = result(3).ToString.ToUpper
                    Panel_FacturaElectronica.Visible = True
                    If result(4) = 4 Or result(4).ToString = 8 Or result(4) = 9 Or result(4) = 7 Then
                        TB_FacturaElectronica_Estat.BackColor = vermell
                    End If
                    If result(4) = 5 Or result(4) = 6 Or result(4) = 10 Then
                        TB_FacturaElectronica_Estat.BackColor = verd
                    End If
                Case 8
                    TB_OficinaVirtual_Sub.Text = result(2).ToString + " €"
                    TB_OficinaVirtual_Estat.Text = result(3).ToString.ToUpper
                    Panel_OficinaVirtual.Visible = True
                    If result(4) = 4 Or result(4).ToString = 8 Or result(4) = 9 Or result(4) = 7 Then
                        TB_OficinaVirtual_Estat.BackColor = vermell
                    End If
                    If result(4) = 5 Or result(4) = 6 Or result(4) = 10 Then
                        TB_OficinaVirtual_Estat.BackColor = verd
                    End If
                Case 9
                    TB_ComunicacionesSeguras_Sub.Text = result(2).ToString + " €"
                    TB_ComunicacionesSeguras_Estat.Text = result(3).ToString.ToUpper
                    Panel_ComunicacionesSeguras.Visible = True
                    If result(4) = 4 Or result(4).ToString = 8 Or result(4) = 9 Or result(4) = 7 Then
                        TB_ComunicacionesSeguras_Estat.BackColor = vermell
                    End If
                    If result(4) = 5 Or result(4) = 6 Or result(4) = 10 Then
                        TB_ComunicacionesSeguras_Estat.BackColor = verd
                    End If
                Case 10
                    TB_Ciberseguridad_Sub.Text = result(2).ToString + " €"
                    TB_Ciberseguridad_Estat.Text = result(3).ToString.ToUpper
                    Panel_Ciberseguridad.Visible = True
                    If result(4) = 4 Or result(4).ToString = 8 Or result(4) = 9 Or result(4) = 7 Then
                        TB_Ciberseguridad_Estat.BackColor = vermell
                    End If
                    If result(4) = 5 Or result(4) = 6 Or result(4) = 10 Then
                        TB_Ciberseguridad_Estat.BackColor = verd
                    End If
                Case 11
                    TB_PuestoSeguro_Sub.Text = result(2).ToString + " €"
                    TB_PuestoSeguro_Estat.Text = result(3).ToString.ToUpper
                    Panel_PuestoSeguro.Visible = True
                    If result(4) = 4 Or result(4).ToString = 8 Or result(4) = 9 Or result(4) = 7 Then
                        TB_PuestoSeguro_Estat.BackColor = vermell
                    End If
                    If result(4) = 5 Or result(4) = 6 Or result(4) = 10 Then
                        TB_PuestoSeguro_Estat.BackColor = verd
                    End If
                Case 12
                    TB_CiberseguridadGestionada_Sub.Text = result(2).ToString + " €"
                    TB_CiberseguridadGestionada_Estat.Text = result(3).ToString.ToUpper
                    Panel_CiberseguridadGestionada.Visible = True
                    If result(4) = 4 Or result(4).ToString = 8 Or result(4) = 9 Or result(4) = 7 Then
                        TB_CiberseguridadGestionada_Estat.BackColor = vermell
                    End If
                    If result(4) = 5 Or result(4) = 6 Or result(4) = 10 Then
                        TB_CiberseguridadGestionada_Estat.BackColor = verd
                    End If
                Case 13
                    TB_ProcesosIA_Sub.Text = result(2).ToString + " €"
                    TB_ProcesosIA_Estat.Text = result(3).ToString.ToUpper
                    Panel_ProcesosIA.Visible = True
                    If result(4) = 4 Or result(4).ToString = 8 Or result(4) = 9 Or result(4) = 7 Then
                        TB_ProcesosIA_Estat.BackColor = vermell
                    End If
                    If result(4) = 5 Or result(4) = 6 Or result(4) = 10 Then
                        TB_ProcesosIA_Estat.BackColor = verd
                    End If
                Case 14
                    TB_BusinessIA_Sub.Text = result(2).ToString + " €"
                    TB_BusinessIA_Estat.Text = result(3).ToString.ToUpper
                    Panel_BusinessIA.Visible = True
                    If result(4) = 4 Or result(4).ToString = 8 Or result(4) = 9 Or result(4) = 7 Then
                        TB_BusinessIA_Estat.BackColor = vermell
                    End If
                    If result(4) = 5 Or result(4) = 6 Or result(4) = 10 Then
                        TB_BusinessIA_Estat.BackColor = verd
                    End If
            End Select
        Next

        TB_SubTotalEmpresa.Text = TotalEmpresaSeleccionada.ToString("C0", New Globalization.CultureInfo("es-ES"))
        resultatsPerEmpresa.Clear()
    End Sub
    Private Sub ompleDadesSolucionsEmpresa2()
        Dim TotalEmpresaSeleccionada As Double = 0

        Panel_SitioWeb2.Visible = False
        Panel_ComercioElectronico2.Visible = False
        Panel_BI2.Visible = False
        Panel_GestionProcesos2.Visible = False
        Panel_FacturaElectronica2.Visible = False
        Panel_OficinaVirtual2.Visible = False
        Panel_ComunicacionesSeguras2.Visible = False
        Panel_Ciberseguridad2.Visible = False
        Panel_PuestoSeguro2.Visible = False
        Panel_CiberseguridadGestionada2.Visible = False
        Panel_ProcesosIA2.Visible = False
        Panel_BusinessIA2.Visible = False

        TB_SitioWeb_Estat2.BackColor = SystemColors.Control
        TB_ComercioElectronico_Estat2.BackColor = SystemColors.Control
        TB_BI_Estat2.BackColor = SystemColors.Control
        TB_GestionProcesos_Estat2.BackColor = SystemColors.Control
        TB_FacturaElectronica_Estat2.BackColor = SystemColors.Control
        TB_FacturaElectronica_Estat2.BackColor = SystemColors.Control
        TB_OficinaVirtual_Estat2.BackColor = SystemColors.Control
        TB_ComunicacionesSeguras_Estat2.BackColor = SystemColors.Control
        TB_Ciberseguridad_Estat2.BackColor = SystemColors.Control
        TB_PuestoSeguro_Estat2.BackColor = SystemColors.Control
        TB_CiberseguridadGestionada_Estat2.BackColor = SystemColors.Control
        TB_ProcesosIA_Estat2.BackColor = SystemColors.Control
        TB_BusinessIA_Estat2.BackColor = SystemColors.Control

        For Each result As Object In resultatsPerEmpresa

            TotalEmpresaSeleccionada += result(2)

            Select Case result(0)
                Case 1
                    TB_SitioWeb_Sub2.Text = result(2).ToString + " €"
                    TB_SitioWeb_Estat2.Text = result(3).ToString.ToUpper
                    Panel_SitioWeb2.Visible = True
                    If result(4) = 4 Or result(4) = 8 Or result(4) = 9 Or result(4) = 7 Then
                        TB_SitioWeb_Estat2.BackColor = vermell
                    End If
                    If result(4) = 5 Or result(4) = 6 Or result(4) = 10 Then
                        TB_SitioWeb_Estat2.BackColor = verd
                    End If

                Case 2
                    TB_ComercioElectronico_Sub2.Text = result(2).ToString + " €"
                    TB_ComercioElectronico_Estat2.Text = result(3).ToString.ToUpper
                    Panel_ComercioElectronico2.Visible = True
                    If result(4) = 4 Or result(4) = 8 Or result(4) = 9 Or result(4) = 7 Then
                        TB_ComercioElectronico_Estat2.BackColor = vermell
                    End If
                    If result(4) = 5 Or result(4) = 6 Or result(4) = 10 Then
                        TB_ComercioElectronico_Estat2.BackColor = verd
                    End If
                Case 3
                Case 4
                Case 5
                    TB_BI_Sub2.Text = result(2).ToString + " €"
                    TB_BI_Estat2.Text = result(3).ToString.ToUpper
                    Panel_BI2.Visible = True
                    If result(4) = 4 Or result(4).ToString = 8 Or result(4) = 9 Or result(4) = 7 Then
                        TB_BI_Estat2.BackColor = vermell
                    End If
                    If result(4) = 5 Or result(4) = 6 Or result(4) = 10 Then
                        TB_BI_Estat2.BackColor = verd
                    End If
                Case 6

                    TB_GestionProcesos_Sub2.Text = result(2).ToString + " €"
                    TB_GestionProcesos_Estat2.Text = result(3).ToString.ToUpper
                    Panel_GestionProcesos2.Visible = True
                    If result(4) = 4 Or result(4).ToString = 8 Or result(4) = 9 Or result(4) = 7 Then
                        TB_GestionProcesos_Estat2.BackColor = vermell
                    End If
                    If result(4) = 5 Or result(4) = 6 Or result(4) = 10 Then
                        TB_GestionProcesos_Estat2.BackColor = verd
                    End If
                Case 7
                    TB_FacturaElectronica_Sub2.Text = result(2).ToString + " €"
                    TB_FacturaElectronica_Estat2.Text = result(3).ToString.ToUpper
                    Panel_FacturaElectronica2.Visible = True
                    If result(4) = 4 Or result(4).ToString = 8 Or result(4) = 9 Or result(4) = 7 Then
                        TB_FacturaElectronica_Estat2.BackColor = vermell
                    End If
                    If result(4) = 5 Or result(4) = 6 Or result(4) = 10 Then
                        TB_FacturaElectronica_Estat2.BackColor = verd
                    End If
                Case 8
                    TB_OficinaVirtual_Sub2.Text = result(2).ToString + " €"
                    TB_OficinaVirtual_Estat2.Text = result(3).ToString.ToUpper
                    Panel_OficinaVirtual2.Visible = True
                    If result(4) = 4 Or result(4).ToString = 8 Or result(4) = 9 Or result(4) = 7 Then
                        TB_OficinaVirtual_Estat2.BackColor = vermell
                    End If
                    If result(4) = 5 Or result(4) = 6 Or result(4) = 10 Then
                        TB_OficinaVirtual_Estat2.BackColor = verd
                    End If
                Case 9
                    TB_ComunicacionesSeguras_Sub2.Text = result(2).ToString + " €"
                    TB_ComunicacionesSeguras_Estat2.Text = result(3).ToString.ToUpper
                    Panel_ComunicacionesSeguras2.Visible = True
                    If result(4) = 4 Or result(4).ToString = 8 Or result(4) = 9 Or result(4) = 7 Then
                        TB_ComunicacionesSeguras_Estat2.BackColor = vermell
                    End If
                    If result(4) = 5 Or result(4) = 6 Or result(4) = 10 Then
                        TB_ComunicacionesSeguras_Estat2.BackColor = verd
                    End If
                Case 10
                    TB_Ciberseguridad_Sub2.Text = result(2).ToString + " €"
                    TB_Ciberseguridad_Estat2.Text = result(3).ToString.ToUpper
                    Panel_Ciberseguridad2.Visible = True
                    If result(4) = 4 Or result(4).ToString = 8 Or result(4) = 9 Or result(4) = 7 Then
                        TB_Ciberseguridad_Estat2.BackColor = vermell
                    End If
                    If result(4) = 5 Or result(4) = 6 Or result(4) = 10 Then
                        TB_Ciberseguridad_Estat2.BackColor = verd
                    End If
                Case 11
                    TB_PuestoSeguro_Sub2.Text = result(2).ToString + " €"
                    TB_PuestoSeguro_Estat2.Text = result(3).ToString.ToUpper
                    Panel_PuestoSeguro2.Visible = True
                    If result(4) = 4 Or result(4).ToString = 8 Or result(4) = 9 Or result(4) = 7 Then
                        TB_PuestoSeguro_Estat2.BackColor = vermell
                    End If
                    If result(4) = 5 Or result(4) = 6 Or result(4) = 10 Then
                        TB_PuestoSeguro_Estat2.BackColor = verd
                    End If
                Case 12
                    TB_CiberseguridadGestionada_Sub2.Text = result(2).ToString + " €"
                    TB_CiberseguridadGestionada_Estat2.Text = result(3).ToString.ToUpper
                    Panel_CiberseguridadGestionada2.Visible = True
                    If result(4) = 4 Or result(4).ToString = 8 Or result(4) = 9 Or result(4) = 7 Then
                        TB_CiberseguridadGestionada_Estat2.BackColor = vermell
                    End If
                    If result(4) = 5 Or result(4) = 6 Or result(4) = 10 Then
                        TB_CiberseguridadGestionada_Estat2.BackColor = verd
                    End If
                Case 13
                    TB_ProcesosIA_Sub2.Text = result(2).ToString + " €"
                    TB_ProcesosIA_Estat2.Text = result(3).ToString.ToUpper
                    Panel_ProcesosIA2.Visible = True
                    If result(4) = 4 Or result(4).ToString = 8 Or result(4) = 9 Or result(4) = 7 Then
                        TB_ProcesosIA_Estat2.BackColor = vermell
                    End If
                    If result(4) = 5 Or result(4) = 6 Or result(4) = 10 Then
                        TB_ProcesosIA_Estat2.BackColor = verd
                    End If
                Case 14
                    TB_BusinessIA_Sub2.Text = result(2).ToString + " €"
                    TB_BusinessIA_Estat2.Text = result(3).ToString.ToUpper
                    Panel_BusinessIA2.Visible = True
                    If result(4) = 4 Or result(4).ToString = 8 Or result(4) = 9 Or result(4) = 7 Then
                        TB_BusinessIA_Estat2.BackColor = vermell
                    End If
                    If result(4) = 5 Or result(4) = 6 Or result(4) = 10 Then
                        TB_BusinessIA_Estat2.BackColor = verd
                    End If
            End Select
        Next

        TB_SubTotalEmpresa2.Text = TotalEmpresaSeleccionada.ToString("C0", New Globalization.CultureInfo("es-ES"))
        resultatsPerEmpresa.Clear()
    End Sub

    Private Sub DataExtresGeneral_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)

        Dim dgv As DataGridView = sender
        If dgv.RowCount > 0 Then
            dgv.Columns("Solució").Width = 150
        End If
    End Sub

    Private Sub DataEstatSolucions_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        Dim dgv As DataGridView = sender
        If dgv.RowCount > 0 Then
            dgv.Columns("Estat").Width = 150
            dgv.Columns("Quantitat").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgv.Columns("Quantitat").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End If
    End Sub

    Private Sub DataExtresGeneral_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs)
        Dim dgv As DataGridView = sender

        dgv.Columns("Id").Visible = False
        TotalSolucionsValor = 0
        TotalGeneralValor = 0

        If dgv.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In dgv.Rows
                If Fila IsNot Nothing Then
                    TotalGeneralValor += Fila.Cells("Subvencions").Value
                    TotalSolucionsValor += Fila.Cells("Quantitat").Value
                End If
            Next
        End If
    End Sub

    Private Sub TextCerca_TextChanged(sender As Object, e As EventArgs) Handles TextCerca.TextChanged
        Dim txtCerca As String = TextCerca.Text
        Dim conexion As New SQLiteConnection(cadena)
        conexion.Open()

        Try
            If conexion.State = ConnectionState.Open Then
                Dim DA As New SQLiteDataAdapter("SELECT id, nom from empreses Where nom like '%" & txtCerca & "%'", conexion)
                DT_CercaEmpreses.Clear()
                DA.Fill(DT_CercaEmpreses)

                If DT_CercaEmpreses.Rows.Count > 0 Then
                    CercaEmpreses.DataSource = DT_CercaEmpreses
                Else
                    CercaEmpreses.DataSource = Nothing
                End If
            End If

        Catch ex As Exception
            MsgBox("No s'ha pogut accedir a la base de dades", vbCritical, "Error")
        End Try

        conexion.Close()


    End Sub

    Private Sub CercaEmpreses_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles CercaEmpreses.DataBindingComplete
        CercaEmpreses.Columns("Id").Visible = False
        If DT_CercaEmpreses.Rows.Count > 0 Then
            TB_EmpresaSeleccionada.Text = CercaEmpreses.Rows(0).Cells("Nom").Value
            CarregaSolucionsEmpresa(CercaEmpreses.Rows(0).Cells("Id").Value)
            CarregaSolucionsEmpresa2(CercaEmpreses.Rows(0).Cells("Id").Value)
        End If
    End Sub

    Private Sub CercaEmpreses_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CercaEmpreses.CellClick
        If e.RowIndex >= 0 Then
            TB_EmpresaSeleccionada.Text = CercaEmpreses.CurrentRow.Cells("Nom").Value
            CarregaSolucionsEmpresa(CercaEmpreses.Rows(e.RowIndex).Cells("Id").Value)
            CarregaSolucionsEmpresa2(CercaEmpreses.Rows(e.RowIndex).Cells("Id").Value)
        End If
    End Sub

    Private Sub FiltreSegments() Handles CB_Segment1.CheckedChanged, CB_Segment2.CheckedChanged, CB_Segment3.CheckedChanged, CB_Segment4.CheckedChanged, CB_Segment5.CheckedChanged

        CarregaEstatsTotes()
        CarregaSolucionsTotes()

    End Sub




End Class