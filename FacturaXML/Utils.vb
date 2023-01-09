'Imports System.Data.SqlClient
Imports System.Data.SQLite
Imports ADODB
Module Utils
    'Public cadena As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""C:\Users\telematic\Documents\Antonio\KitDigital2\FacturaXML\GestioKitsDB.mdf"";Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False"
    'Public cadena As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=" & Application.StartupPath & "\Database1.mdf"";Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False"
    Public cadena As String = "Data Source=" & Application.StartupPath & "\GestioKitsDB.db;Version=3;UseUTF8Encoding=True;"
    'Sustitueix cometes per cometes dobles per evitar errors
    Public Function StringDB(arg As String) As String
        StringDB = "'" & Replace(arg, "'", "''") & "'"
    End Function

End Module
