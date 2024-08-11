Imports System
Imports System.Data.SqlClient
Imports Model.Models



Namespace Business
    Public Class ClientBusiness
        Private dataAccess As DataAccess



        Public Sub New()
            dataAccess = New DataAccess()
        End Sub

        Public Function ListClients() As List(Of Client)
            Dim lista As New List(Of Client)()
            dataAccess.SetQuery("SELECT ID, Cliente, Telefono, Correo FROM clientes")

            Try
                dataAccess.ExecuteReader()

                While dataAccess.Reader.Read()
                    Dim aux As New Client()
                    aux.Id = dataAccess.Reader.GetInt32(0)
                    aux.Name = dataAccess.Reader.GetString(1)
                    aux.Phone = If(dataAccess.Reader.IsDBNull(2), Nothing, dataAccess.Reader.GetString(2))
                    aux.Email = If(dataAccess.Reader.IsDBNull(3), Nothing, dataAccess.Reader.GetString(3))

                    lista.Add(aux)
                End While
            Catch ex As Exception
                Throw ex
            Finally
                dataAccess.CloseConnection()
            End Try

            Return lista
        End Function


        ' Add a new client
        Public Sub AddClient(client As Client)
            dataAccess.SetQuery("INSERT INTO clientes (Cliente, Telefono, Correo) VALUES (@Name, @Phone, @Email)")
            dataAccess.SetParameter("@Name", client.Name)
            dataAccess.SetParameter("@Phone", client.Phone)
            dataAccess.SetParameter("@Email", client.Email)
            dataAccess.ExecuteNonQuery()
        End Sub

        ' Delete a client
        Public Sub DeleteClient(client As Client)
            dataAccess.SetQuery("DELETE FROM clientes WHERE ID = @ClientId")
            dataAccess.SetParameter("@ClientId", client.Id)
            dataAccess.ExecuteNonQuery()
        End Sub

        ' Update a client
        Public Sub UpdateClient(client As Client)
            dataAccess.SetQuery("UPDATE clientes SET Cliente = @Name, Telefono = @Phone, Correo = @Email WHERE ID = @ClientId")
            dataAccess.SetParameter("@ClientId", client.Id)
            dataAccess.SetParameter("@Name", client.Name)
            dataAccess.SetParameter("@Phone", client.Phone)
            dataAccess.SetParameter("@Email", client.Email)
            dataAccess.ExecuteNonQuery()
        End Sub
    End Class
End Namespace
