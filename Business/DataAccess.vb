Imports System.Configuration
Imports System.Data.SqlClient

Namespace Business
    Public Class DataAccess
        Private connection As SqlConnection
        Private command As SqlCommand
        Private _reader As SqlDataReader

        ' Public property to access the SqlDataReader content
        Public ReadOnly Property Reader As SqlDataReader
            Get
                Return _reader
            End Get
        End Property

        ' Constructor que lee la cadena de conexión del archivo App.config
        Public Sub New()
            Dim connectionString As String = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString
            connection = New SqlConnection(connectionString)
            command = New SqlCommand()
        End Sub

        ' Establecer la consulta SQL a ejecutar
        Public Sub SetQuery(query As String)
            command.CommandType = CommandType.Text
            command.CommandText = query
        End Sub

        ' Ejecutar una consulta y leer datos
        Public Sub ExecuteReader()
            command.Connection = connection
            Try
                connection.Open()
                _reader = command.ExecuteReader()
            Catch ex As Exception
                Throw New Exception("An error occurred while executing the query.", ex)
            End Try
        End Sub

        ' close the conexion
        Public Sub CloseConnection()
            If _reader IsNot Nothing AndAlso Not _reader.IsClosed Then
                _reader.Close()
            End If
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Sub

        ' Ejecutar comandos SQL que no devuelven resultados (INSERT, UPDATE, DELETE)
        Public Sub ExecuteNonQuery()
            command.Connection = connection
            Try
                connection.Open()
                command.ExecuteNonQuery()
            Catch ex As Exception
                Throw New Exception("An error occurred while executing the command.", ex)
            Finally
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
        End Sub

        ' Configurar consultas SQL con parámetros
        Public Sub SetParameter(parameterName As String, value As Object)
            command.Parameters.AddWithValue(parameterName, value)
        End Sub
    End Class
End Namespace
