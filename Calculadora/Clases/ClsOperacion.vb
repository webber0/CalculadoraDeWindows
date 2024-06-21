Public Class ClsOperacion
    '-------------------------------------
    'Variables
    '-------------------------------------
    Private dblnumeroUno As Double
    Private dblnumeroDos As Double
    Private dblResultado As Double
    Private strOperador As String

    '-------------------------------------
    'Constructor
    '-------------------------------------
    Public Sub New(numeroUno As Double, numeroDos As Double, operador As String)
        dblnumeroUno = numeroUno
        dblnumeroDos = numeroDos
        strOperador = operador
    End Sub

    '-------------------------------------
    'Rutinas necesarias
    '-------------------------------------

    Public Overridable Sub calcular()

    End Sub

    '-------------------------------------
    'Funciones
    '-------------------------------------

    Public Function retornarOperacion() As String

        Return dblnumeroUno.ToString + strOperador + dblnumeroDos.ToString + "=" + dblResultado.ToString + vbCrLf
    End Function

    '-------------------------------------
    'Propiedades Publicas de Lectura/Escritura
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

    Public Property Resultado() As Double
        Get
            Return dblResultado
        End Get
        Set(ByVal value As Double)
            dblResultado = value
        End Set
    End Property
End Class
