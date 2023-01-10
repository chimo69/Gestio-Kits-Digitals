Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Imports System.Data.SQLite

Public Class EstatJustificacio

    Dim Id, IdTipusSolucio As Integer
    Dim PorcentatgeDesglossament As Integer = 0
    Dim PorcentatgeFabricantSolucio As Integer = 0
    Dim PercentatgeTeComprovant As Integer = 0
    Dim PercentatgeTeWord As Integer = 0
    Dim PercentatgeTeDada1 As Integer = 0
    Dim PercentatgeTeDada2 As Integer = 0
    Dim Progress As Integer
    Dim PercentatgeTeFactura As Integer = 0

    Public Sub New(EmpresaRebuda As String, SolucioRebuda As String, IdRebut As Integer, IdTipusSolucioRebuda As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Id = IdRebut
        IdTipusSolucio = IdTipusSolucioRebuda
        Empresa.Text = EmpresaRebuda
        Solucio.Text = SolucioRebuda

        rebreDades()
    End Sub

    Private Sub rebreDades()
        Dim conexion As New SqLiteConnection(cadena)
        Dim Query As String
        Dim strCommand As SQLiteCommand

        Query = "SELECT * FROM Justificacions WHERE iDSolucio=" & Id
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

            End If
            lector.Close()
        conexion.Close()

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
            Case 4, 5
                TeDada1.Text = "Fichero log con los logs de login (inicio sesion) a la solución" & vbCrLf & "implantada en el que aparezcan los como mínimo (1,1,3)" & vbCrLf & "usuarios dados de alta según segmento (III,II,I)"
                TeDada2.Text = ""
                PercentatgeTeDada2 = 10
                TeDada2.Visible = False
            Case 6
                TeDada1.Text = "fichero con los logs de login (inicio de sesión) a la solución" & vbCrLf & "implantada en el que aparezcan los como mínimo (1, 3, 10)" & vbCrLf & "usuarios dados de alta según segmento (III, II, I)"
                TeDada2.Text = ""
                PercentatgeTeDada2 = 10
                TeDada2.Visible = False
            Case 7
                TeDada1.Text = ""
                TeDada2.Text = ""
                PercentatgeTeDada1 = 10
                PercentatgeTeDada2 = 10
                TeDada1.Visible = False
                TeDada2.Visible = False
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
        End Select
        ActualitzaProgresBar()
    End Sub
    Private Sub guardarDades()
        Dim conexion As New SQLiteConnection(cadena)
        Dim Query As String
        Dim strCommand As SQLiteCommand

        Try
            Query = "UPDATE Justificacions SET
                        Percentatge=" & Progress & ",
                        TeWord='" & tornaBoolean(TeWord.Checked) & "',
                        TeComprovantPagament='" & tornaBoolean(TeComprovant.Checked) & "',
                        TeFacturaXML='" & tornaBoolean(TeFactura.Checked) & "',
                        Dada1='" & tornaBoolean(TeDada1.Checked) & "',
                        Dada2='" & tornaBoolean(TeDada2.Checked) & "',
                        TotalSolucio=" & CDbl(TotalSolucio.Text) & ",
                        FabricantSolucio =" & StringDB(FabricantSolucio.Text) & "
                        
                        WHERE iDSolucio=" & Id
            strCommand = New SQLiteCommand(Query, conexion)

            conexion.Open()
            strCommand.ExecuteNonQuery()
            conexion.Close()
            MsgBox("L'estat de justificació ha sigut actualitzat", vbInformation, "Justificació")
            Me.Close()
        Catch ex As Exception
            MsgBox("No s'ha pogut actualitzar l'estat", vbCritical, "Justificació")
        End Try

    End Sub
    Private Function tornaBoolean(B As Boolean) As Integer
        If B = True Then
            Return 1
        Else
            Return 0
        End If
    End Function

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
                    PercentatgeTefactura = 0
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

    Private Sub TotalSolucio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TotalSolucio.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = ","
    End Sub
    Private Sub ActualitzaProgresBar()
        Progress = PorcentatgeDesglossament + PorcentatgeFabricantSolucio + PercentatgeTeComprovant + PercentatgeTeFactura + PercentatgeTeWord + PercentatgeTeDada1 + PercentatgeTeDada2
        ProgressBar1.Value = Progress
        If Progress = 100 Then
            Completat.Visible = True
        Else
            Completat.Visible = False
        End If
    End Sub
    Private Sub Btn_guardar_Click(sender As Object, e As EventArgs) Handles Btn_guardar.Click
        guardarDades()
    End Sub
End Class