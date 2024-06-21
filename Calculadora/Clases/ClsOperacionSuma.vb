Public Class ClsOperacionSuma
    Inherits ClsOperacion

    Public Sub New(numeroUno As Double, numeroDos As Double, operador As String)
        MyBase.New(numeroUno, numeroDos, operador)
    End Sub

    Public Overrides Sub calcular()
        Resultado = NumeroUno + NumeroDos
    End Sub

End Class
