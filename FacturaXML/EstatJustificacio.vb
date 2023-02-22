Imports System.Data.SQLite

Public Class EstatJustificacio

    Dim IdSolucio, IdTipusSolucio, IdEmpresa As Integer
    Dim PorcentatgeDesglossament As Integer = 0
    Dim PorcentatgeFabricantSolucio As Integer = 0
    Dim PercentatgeTeComprovant As Integer = 0
    Dim PercentatgeTeWord As Integer = 0
    Dim PercentatgeTeDada1 As Integer = 0
    Dim PercentatgeTeDada2 As Integer = 0
    Dim Progress As Integer
    Dim PercentatgeTeFactura As Integer = 0
    Dim Subvencio As String

    Public Sub New(EmpresaRebuda As String, SolucioRebuda As String, IdEmpresaRebuda As Integer, IdSolucioRebuda As Integer, IdTipusSolucioRebuda As Integer, SubvencioRebuda As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        IdEmpresa = IdEmpresaRebuda
        IdSolucio = IdSolucioRebuda
        IdTipusSolucio = IdTipusSolucioRebuda
        Subvencio = SubvencioRebuda
        Empresa.Text = EmpresaRebuda
        Solucio.Text = SolucioRebuda
        ImportSubvencionat.Text = Subvencio

        RebreDades()
    End Sub
    'Carrega les justificacions de la solucio seleccionada
    Private Sub RebreDades()
        Dim conexion As New SQLiteConnection(cadena)
        Dim Query As String
        Dim strCommand As SQLiteCommand

        Query = "SELECT * FROM Justificacions WHERE iDSolucio=" & IdSolucio
        strCommand = New SQLiteCommand(Query, conexion)
        conexion.Open()
        Dim lector As SQLiteDataReader = strCommand.ExecuteReader

        If lector.Read() Then
            FabricantSolucio.Text = lector.GetString("FabricantSolucio")
            TeWord.Checked = lector.GetBoolean("TeWord")
            TeComprovant.Checked = lector.GetBoolean("TeComprovantPagament")
            TeFactura.Checked = lector.GetBoolean("TeFacturaXML")
            TeDada1.Checked = lector.GetBoolean("Dada1")
            TeDada2.Checked = lector.GetBoolean("Dada2")
            TotalSolucio.Text = (lector.GetValue("TotalSolucio")).ToString
            Factura.Text = lector.GetString("Factura")
            If lector.GetString("DataPresentacio") <> "" Then DataPresentacio.Value = lector.GetString("DataPresentacio")

            If lector.GetValue("Subvencio") <> 0 Then ImportSubvencionat.Text = lector.GetValue("Subvencio").ToString

            Select Case (lector.GetValue("Estat"))
                    Case 0
                        RB_Proces0.Checked = True
                    Case 1
                        RB_Proces1.Checked = True
                    Case 2
                        RB_Proces2.Checked = True
                    Case 3
                        RB_Proces3.Checked = True
                    Case 4
                        RB_Proces4.Checked = True
                    Case 5
                        RB_Proces5.Checked = True
                    Case 6
                        RB_Proces6.Checked = True
                End Select
            End If
            lector.Close()
        conexion.Close()

        'Depenent del tipus de solucio les dades 1 i 2 tindran diferents textos
        Select Case IdTipusSolucio
            Case 1
                TeDada1.Text = "Justificante de formalización de dominio" & vbCrLf & "(nuevo dominio si es segmento 1) PDF"
                TeDada2.Text = "Captura de pantalla que acredite la publicidad en la web"
            Case 2
                TeDada1.Text = "Indicar nº total de subidas"
                TeDada2.Text = "Captura de pantalla que acredite la publicidad en la web"
            Case 3
                TeDada1.Text = "Modelo que exponga la estrategia de comunicación digital" & vbCrLf & "para el cliente y un informe de publicaciones realizadas" & vbCrLf & "(+4 al mes)"
                TeDada2.Text = ""
                PercentatgeTeDada2 = 10
                TeDada2.Visible = False
                TeDada2.Checked = True
            Case 4, 5
                TeDada1.Text = "Fichero log con los logs de login (inicio sesion) a la solución" & vbCrLf & "implantada en el que aparezcan los como mínimo (1,1,3)" & vbCrLf & "usuarios dados de alta según segmento (III,II,I)"
                TeDada2.Text = ""
                PercentatgeTeDada2 = 10
                TeDada2.Visible = False
                TeDada2.Checked = True
            Case 6
                TeDada1.Text = "fichero con los logs de login (inicio de sesión) a la solución" & vbCrLf & "implantada en el que aparezcan los como mínimo (1, 3, 10)" & vbCrLf & "usuarios dados de alta según segmento (III, II, I)"
                TeDada2.Text = ""
                PercentatgeTeDada2 = 10
                TeDada2.Visible = False
                TeDada2.Checked = True
            Case 7
                TeDada1.Text = ""
                TeDada2.Text = ""
                PercentatgeTeDada1 = 10
                PercentatgeTeDada2 = 10
                TeDada1.Visible = False
                TeDada2.Visible = False
                TeDada1.Checked = True
                TeDada2.Checked = True
            Case 8, 9
                TeDada1.Text = "Fichero con los logs de login (inicio de sesión) a la solución" & vbCrLf & "implantada en el que aparezcan todos los usuarios dados" & vbCrLf & "de alta."
                TeDada2.Text = ""
                PercentatgeTeDada2 = 10
                TeDada2.Visible = False
            Case 10
                TeDada1.Text = "Fichero con los logs de funcionamiento de la solución (ya" & vbCrLf & "sea consola centralizada o instalación individual) donde se" & vbCrLf & "comprueben los análisis realizados por la herramienta, las" & vbCrLf & "actualizaciones de las bases de datos y los motores de" & vbCrLf & "análisis. Indicar también el nº de dispositivos suministrados" & vbCrLf & "si los hay (p.ej.: un firewall)"
                TeDada2.Text = ""
                PercentatgeTeDada2 = 10
                TeDada2.Visible = False
                TeDada2.Checked = True
        End Select
        ActualitzaProgresBar()
    End Sub
    'Guardem els canvis a la base de dades
    Private Sub GuardarDades()
        Dim conexion As New SQLiteConnection(cadena)
        Dim Query As String
        Dim strCommand As SQLiteCommand
        Dim estat As Integer
        Dim txtDataPresentacio As String
        Dim sqltxt As String

        If RB_Proces0.Checked = True Then estat = 0
        If RB_Proces1.Checked = True Then estat = 1
        If RB_Proces2.Checked = True Then estat = 2
        If RB_Proces3.Checked = True Then
            estat = 3
            txtDataPresentacio = StringDB(Format(DataPresentacio.Value, "yyyy-MM-dd"))
            sqltxt = ", DataPresentacio=" & txtDataPresentacio + " "
        Else
            sqltxt = ""
        End If
        If RB_Proces4.Checked = True Then estat = 4
        If RB_Proces5.Checked = True Then estat = 5
        If RB_Proces6.Checked = True Then estat = 6


        Try
            Query = "UPDATE Justificacions SET
                        Percentatge=" & Progress & ",
                        TeWord='" & TornaBoolean(TeWord.Checked) & "',
                        TeComprovantPagament='" & TornaBoolean(TeComprovant.Checked) & "',
                        TeFacturaXML='" & TornaBoolean(TeFactura.Checked) & "',
                        Dada1='" & TornaBoolean(TeDada1.Checked) & "',
                        Dada2='" & TornaBoolean(TeDada2.Checked) & "',
                        TotalSolucio=" & CDbl(TotalSolucio.Text) & ",
                        FabricantSolucio =" & StringDB(FabricantSolucio.Text) & ",
                        Subvencio=" & ImportSubvencionat.Text & ",
                        Factura=" & StringDB(Factura.Text) & ",
                        Estat=" & estat & sqltxt & "
                        WHERE iDSolucio=" & IdSolucio
            strCommand = New SQLiteCommand(Query, conexion)

            conexion.Open()
            strCommand.ExecuteNonQuery()
            MsgBox("L'estat de justificació ha sigut actualitzat", vbInformation, "Justificació")
            conexion.Close()
            Me.Close()
        Catch ex As Exception
            MsgBox("No s'ha pogut actualitzar l'estat ", vbCritical, "Justificació")
            conexion.Close()
        End Try

    End Sub
    'Converteix boolean en integer
    Private Shared Function TornaBoolean(B As Boolean) As Integer
        If B = True Then
            Return 1
        Else
            Return 0
        End If
    End Function
    'Controla els canvis fets als textbox del grup 2
    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles TotalSolucio.TextChanged, FabricantSolucio.TextChanged

        Select Case DirectCast(sender, TextBox).Name
            Case TotalSolucio.Name
                If (TotalSolucio.Text <> "" And TotalSolucio.Text <> "0") Then
                    PorcentatgeDesglossament = 20

                    ImplantacioInicial.Text = (CDbl(TotalSolucio.Text) * 0.85).ToString
                    Manteniment.Text = (CDbl(TotalSolucio.Text) * 0.05).ToString
                    Suport.Text = (CDbl(TotalSolucio.Text) * 0.05).ToString
                    Formacio.Text = (CDbl(TotalSolucio.Text) * 0.05).ToString
                Else
                    PorcentatgeDesglossament = 0
                    ImplantacioInicial.Text = "0"
                    Manteniment.Text = "0"
                    Suport.Text = "0"
                    Formacio.Text = "0"

                End If
                Exit Select

            Case FabricantSolucio.Name
                If FabricantSolucio.Text <> "" Then
                    PorcentatgeFabricantSolucio = 10
                Else
                    PorcentatgeFabricantSolucio = 0
                End If
                Exit Select

        End Select


        ActualitzaProgresBar()
    End Sub
    'Controla els canvis fets als textbox del grup 1
    Private Sub CheckBox_TextChanged(sender As Object, e As EventArgs) Handles TeComprovant.CheckedChanged, TeWord.CheckedChanged, TeFactura.CheckedChanged, TeDada1.CheckedChanged, TeDada2.CheckedChanged
        Select Case DirectCast(sender, CheckBox).Name
            Case TeComprovant.Name
                If TeComprovant.Checked = True Then
                    PercentatgeTeComprovant = 10
                Else
                    PercentatgeTeComprovant = 0
                End If
                Exit Select
            Case TeWord.Name
                If TeWord.Checked = True Then
                    PercentatgeTeWord = 30
                Else
                    PercentatgeTeWord = 0
                End If
                Exit Select
            Case TeFactura.Name
                If TeFactura.Checked = True Then
                    PercentatgeTeFactura = 10
                Else
                    PercentatgeTeFactura = 0
                End If
                Exit Select
            Case TeDada1.Name
                If TeDada1.Checked = True Then
                    PercentatgeTeDada1 = 10
                Else
                    PercentatgeTeDada1 = 0
                End If
                Exit Select
            Case TeDada2.Name
                If TeDada2.Checked = True Then
                    PercentatgeTeDada2 = 10
                Else
                    PercentatgeTeDada2 = 0
                End If
                Exit Select
        End Select
        ActualitzaProgresBar()
    End Sub
    'Controla els caracters que es poden introduir al textbox
    Private Sub TotalSolucio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TotalSolucio.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = ","
    End Sub
    'Actualitza la barra de progres amb els valors actuals
    Private Sub ActualitzaProgresBar()
        Progress = PorcentatgeDesglossament + PorcentatgeFabricantSolucio + PercentatgeTeComprovant + PercentatgeTeFactura + PercentatgeTeWord + PercentatgeTeDada1 + PercentatgeTeDada2
        ProgressBar1.Value = Progress
        If Progress = 100 Then
            Completat.Visible = True
        Else
            Completat.Visible = False
        End If
    End Sub

    Private Sub RB_Proces3_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Proces3.CheckedChanged
        If RB_Proces3.Checked = True Then
            DataPresentacio.Visible = True
            TitolDataPresentacio.Visible = True
        Else
            DataPresentacio.Visible = False
            TitolDataPresentacio.Visible = False
        End If
    End Sub

    Private Sub Btn_CreaFactura_Click(sender As Object, e As EventArgs) Handles Btn_CreaFactura.Click
        Dim FacturaXML As New Factures(IdEmpresa, IdSolucio)
        OpenSubFormDialog(FacturaXML)
        Dim resp As Integer
        resp = MsgBox("Activar FacturaXML com feta?", vbYesNo, "Crear factura")
        If resp = vbYes Then
            TeFactura.Checked = True
        Else
            TeFactura.Checked = False
        End If
    End Sub

    Private Sub Btn_guardar_Click(sender As Object, e As EventArgs) Handles Btn_guardar.Click
        GuardarDades()
    End Sub
End Class