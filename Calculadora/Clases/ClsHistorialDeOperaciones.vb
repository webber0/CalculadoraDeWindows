Public Class ClsHistorialDeOperaciones
    Private lstOperacion As List(Of ClsOperacion)
    Public Sub New()
        lstOperacion = New List(Of ClsOperacion)
    End Sub

    Public Sub agregarElemento(ByVal o As ClsOperacion)
        lstOperacion.Add(o)
    End Sub

    Public Sub mostrarElementos()
        For Each o In lstOperacion
            o.retornarOperacion()
        Next
    End Sub

    Public Function obtenerLista() As List(Of ClsOperacion)
        Return lstOperacion
    End Function

End Class
