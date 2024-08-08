Imports System
Imports System.Data.SqlClient

Namespace Business
    Public Class ClientBusiness
        Private dataAccess As DataAccess

        Public Sub New(connectionString As String)
            dataAccess = New DataAccess(connectionString)
        End Sub

        ' Add a new client
        Public Sub AddClient(name As String, phone As String, email As String)
            dataAccess.SetQuery("INSERT INTO clientes (Cliente, Telefono, Correo) VALUES (@Name, @Phone, @Email)")
            dataAccess.SetParameter("@Name", name)
            dataAccess.SetParameter("@Phone", phone)
            dataAccess.SetParameter("@Email", email)
            dataAccess.ExecuteNonQuery()
        End Sub

        ' Delete a client
        Public Sub DeleteClient(clientId As Integer)
            dataAccess.SetQuery("DELETE FROM clientes WHERE ID = @ClientId")
            dataAccess.SetParameter("@ClientId", clientId)
            dataAccess.ExecuteNonQuery()
        End Sub

        ' Update a client
        Public Sub UpdateClient(clientId As Integer, name As String, phone As String, email As String)
            dataAccess.SetQuery("UPDATE clientes SET Cliente = @Name, Telefono = @Phone, Correo = @Email WHERE ID = @ClientId")
            dataAccess.SetParameter("@ClientId", clientId)
            dataAccess.SetParameter("@Name", name)
            dataAccess.SetParameter("@Phone", phone)
            dataAccess.SetParameter("@Email", email)
            dataAccess.ExecuteNonQuery()
        End Sub
    End Class
End Namespace
