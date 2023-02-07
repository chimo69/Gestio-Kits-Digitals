Module Utils
    Public cadena As String = "Data Source=" & Application.StartupPath & "\Database\GestioKitsDB.db;Version=3;UseUTF8Encoding=True;"
    Public taronja As Color = Color.FromArgb(255, 197, 128)
    Public vermell As Color = Color.FromArgb(255, 128, 128)
    Public verd As Color = Color.FromArgb(164, 255, 150)
    Public groc As Color = Color.FromArgb(252, 255, 168)

    'Sustitueix cometes per cometes dobles per evitar errors
    Public Function StringDB(arg As String) As String
        StringDB = "'" & Replace(arg, "'", "''") & "'"
    End Function

    'Método para abrir el formulario una sola vez.
    Public Function OpenSubForm(ByVal form As Form) As Boolean
        'Chequeo si ya está abierto.
        For Each f As Form In Application.OpenForms
            'Si está abierto devuelvo False (no se puede abrir).
            If f.Name = form.Name Then
                Return False
            End If
        Next

        'Si se llega a este punto es porque no está abierto.
        'Abro el formulario.
        form.Show()

        'Indico apertura exitosa.
        Return True
    End Function
    Public Function OpenSubFormDialog(ByVal form As Form) As Boolean
        'Chequeo si ya está abierto.
        For Each f As Form In Application.OpenForms
            'Si está abierto devuelvo False (no se puede abrir).
            If f.Name = form.Name Then
                Return False
            End If
        Next

        'Si se llega a este punto es porque no está abierto.
        'Abro el formulario.
        form.ShowDialog()

        'Indico apertura exitosa.
        Return True
    End Function

End Module
