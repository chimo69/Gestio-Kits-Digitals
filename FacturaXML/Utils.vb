'Imports System.Data.SqlClient
Imports System.Data.SQLite
Imports ADODB
Module Utils
    Public cadena As String = "Data Source=" & Application.StartupPath & "\Database\GestioKitsDB.db;Version=3;UseUTF8Encoding=True;"
    'Sustitueix cometes per cometes dobles per evitar errors
    Public Function StringDB(arg As String) As String
        StringDB = "'" & Replace(arg, "'", "''") & "'"
    End Function

End Module
