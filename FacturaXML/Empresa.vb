Public Class Empresa
    Public Class Empresa
        Public Property Empresa As String
        Public Property Nif As String
        Public Property Bono As String
        Public Property Importe As Integer
        Public Property Fecha As String
        Public Property caduca As String

        ' Propiedad de solo lectura que devuelve el valor basado en Segmento
        Public ReadOnly Property SegmentoValor As Integer
            Get
                Select Case Importe
                    Case 2000, 3000
                        Return 3
                    Case 6000
                        Return 2
                    Case 12000
                        Return 1
                    Case Else
                        Return 0 ' Valor por defecto si no coincide con ninguno de los casos
                End Select
            End Get
        End Property
    End Class

End Class
