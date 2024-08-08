Imports System
Imports System.Data
Imports System.Data.SqlClient

Namespace Business
    Public Class DataAccess
        Private connection As SqlConnection
        Private command As SqlCommand
        Private _reader As SqlDataReader ' Cambiado a _reader

        ' Public property to access the SqlDataReader content
        Public ReadOnly Property Reader As SqlDataReader
            Get
                Return _reader
            End Get
        End Property

        ' Constructor
        Public Sub New(connectionString As String)
            connection = New SqlConnection(connectionString)
            command = New SqlCommand()
        End Sub

        ' Set the SQL query to execute
        Public Sub SetQuery(query As String)
            command.CommandType = CommandType.Text
            command.CommandText = query
        End Sub

        ' Execute a query and read data
        Public Sub ExecuteReader()
            command.Connection = connection
            Try
                connection.Open()
                _reader = command.ExecuteReader()
            Catch ex As Exception
                Throw New Exception("An error occurred while executing the query.", ex)
            End Try
        End Sub

        ' Close the connection and reader
        Public Sub CloseConnection()
            If _reader IsNot Nothing AndAlso Not _reader.IsClosed Then
                _reader.Close()
            End If
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Sub

        ' Execute non-query SQL commands such as INSERT, UPDATE, DELETE
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

        ' Configure SQL queries with parameters
        Public Sub SetParameter(parameterName As String, value As Object)
            command.Parameters.AddWithValue(parameterName, value)
        End Sub
    End Class
End Namespace
