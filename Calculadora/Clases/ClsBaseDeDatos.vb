Imports System.Data.SqlClient
Imports System.Configuration
Public Class ClsBaseDeDatos
    '-------------------------------------
    'Variables
    '-------------------------------------
    Private myConn As SqlConnection
    Private myReader As SqlDataReader
    Private results As String

    '-------------------------------------
    'Constructor
    '-------------------------------------
    Public Sub New(ByVal conectionString As String)
        Try
            myConn = New SqlConnection(conectionString)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    '-------------------------------------
    'Constructor
    '-------------------------------------

    Public Sub connectToDatabase()
        Try
            myConn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
            myConn.Close()
        End Try
    End Sub

    Public Sub disconnectFromDatabase()
        Try
            myConn.Close()
        Catch ex As Exception
            MsgBox("Error al cerrar la conexion a la base de datos")
        End Try
    End Sub

    Public Sub saveToDatabase(ByVal expresion As String)
        Try
            Dim sqlcommand = "INSERT INTO Historial values(GETDATE()" & "," & expresion.Replace("""", "") & ")"
            'myCmd = myConn.CreateCommand
            'myCmd.ExecuteNonQuery(sqlcommand, myConn.ConnectionString)
            Dim command As New SqlCommand(sqlcommand, myConn)
            Me.connectToDatabase()
            command.ExecuteNonQuery()
            Me.disconnectFromDatabase()
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.disconnectFromDatabase()
        End Try
    End Sub

    Public Function retriveFromDatabase() As DataTable
        Dim table As New DataTable()
        Try
            Dim adapter As New SqlDataAdapter("select fechaHora, expresion from Historial", myConn)
            adapter.Fill(table)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return table
    End Function

End Class
