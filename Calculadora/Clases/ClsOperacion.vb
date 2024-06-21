Public Class ClsOperacion
    '-------------------------------------
    'Variables
    '-------------------------------------
    Dim dblnumeroUno As Double
    Dim dblnumeroDos As Double
    Dim boolHayError As Boolean
    Dim strOperador As String

    '-------------------------------------
    'Propiedades de Lecutura/Escritura
    '-------------------------------------
    Public Property NumeroUno() As Double
        Get
            Return dblnumeroUno
        End Get
        Set(ByVal value As Double)
            dblnumeroUno = value
        End Set
    End Property

    Public Property NumeroDos() As Double
        Get
            Return dblnumeroDos
        End Get
        Set(ByVal value As Double)
            dblnumeroDos = value
        End Set
    End Property

    Public Property Operador() As String
        Get
            Return strOperador
        End Get
        Set(ByVal value As String)
            strOperador = value
        End Set
    End Property

    Public Property HayError() As Boolean
        Get
            Return boolHayError
        End Get
        Set(ByVal value As Boolean)
            boolHayError = value
        End Set
    End Property
End Class
