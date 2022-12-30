Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices

Public Class EstatJustificacio
    Dim cadena As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""C:\Users\telematic\Documents\Antonio\KitDigital2\FacturaXML\Database1.mdf"";Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False"
    Dim Id As Integer
    Public Sub New(EmpresaRebuda As String, SolucioRebuda As String, IdRebut As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Id = IdRebut
        Empresa.Text = EmpresaRebuda
        Solucio.Text = SolucioRebuda

        rebreDades()
    End Sub

    Private Sub rebreDades()
        Dim conexion As New SqlConnection(cadena)
        Dim Query As String
        Dim strCommand As SqlCommand

        Query = "SELECT Empreses.Nom FROM Empreses INNER JOIN Solucions ON Solucions.IdEmpresa = Empreses.Id  WHERE Solucions.Id=" & Id

        strCommand = New SqlCommand(Query, conexion)
        conexion.Open()
        Dim lector As SqlDataReader = strCommand.ExecuteReader
        If lector.Read() Then
            'Empresa.Text = lector.GetValue(0)
        End If
        lector.Close()
        conexion.Close()




    End Sub

End Class