Module Utils
    Public cadena As String = "Data Source=" & Application.StartupPath & "\Database\GestioKitsDB.db;Version=3;UseUTF8Encoding=True;"
    Public taronja As Color = Color.FromArgb(255, 195, 0)
    Public vermell As Color = Color.FromArgb(253, 88, 88)
    Public verd As Color = Color.FromArgb(175, 253, 88)

    'Sustitueix cometes per cometes dobles per evitar errors
    Public Function StringDB(arg As String) As String
        StringDB = "'" & Replace(arg, "'", "''") & "'"
    End Function

End Module
