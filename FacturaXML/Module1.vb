Imports System.Data.SQLite

Module Module1

    Public Function conexio()
        Dim con As New SQLiteConnection(cadena)
        con.Open()
        conexio = con
    End Function

    Public fcontr As New Contractes
    Public fempre As New Empreses
    Public fextra As New Extras
    Public ffactu As New Factures
    Public fsolu As New Solucions
    Public flogo As New Logo
    Public finfo As New Informacio

End Module
