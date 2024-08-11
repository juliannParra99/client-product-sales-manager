Imports System
Imports System.Data.SqlClient
Imports Model.Models

Namespace Business
    Public Class ProductBusiness
        Private dataAccess As DataAccess

        Public Sub New()
            dataAccess = New DataAccess()
        End Sub
        Public Function ListProducts() As List(Of Product)
            Dim lista As New List(Of Product)()
            dataAccess.SetQuery("SELECT ID, Nombre, Precio, Categoria FROM productos")

            Try
                dataAccess.ExecuteReader()

                While dataAccess.Reader.Read()
                    Dim aux As New Product()
                    aux.Id = dataAccess.Reader.GetInt32(0)
                    aux.Name = dataAccess.Reader.GetString(1)
                    aux.Price = If(dataAccess.Reader.IsDBNull(2), 0.0, dataAccess.Reader.GetDouble(2))
                    aux.Category = If(dataAccess.Reader.IsDBNull(3), Nothing, dataAccess.Reader.GetString(3))

                    lista.Add(aux)
                End While
            Catch ex As Exception
                Throw ex
            Finally
                dataAccess.CloseConnection()
            End Try

            Return lista
        End Function

        ' Add a new product
        Public Sub AddProduct(product As Product)
            dataAccess.SetQuery("INSERT INTO productos (Nombre, Precio, Categoria) VALUES (@Name, @Price, @Category)")
            dataAccess.SetParameter("@Name", product.Name)
            dataAccess.SetParameter("@Price", product.Price)
            dataAccess.SetParameter("@Category", product.Category)
            dataAccess.ExecuteNonQuery()
        End Sub

        ' Delete a product
        Public Sub DeleteProduct(product As Product)
            dataAccess.SetQuery("DELETE FROM productos WHERE ID = @ProductId")
            dataAccess.SetParameter("@ProductId", product.Id)
            dataAccess.ExecuteNonQuery()
        End Sub

        ' Update a product
        Public Sub UpdateProduct(product As Product)
            dataAccess.SetQuery("UPDATE productos SET Nombre = @Name, Precio = @Price, Categoria = @Category WHERE ID = @ProductId")
            dataAccess.SetParameter("@ProductId", product.Id)
            dataAccess.SetParameter("@Name", product.Name)
            dataAccess.SetParameter("@Price", product.Price)
            dataAccess.SetParameter("@Category", product.Category)
            dataAccess.ExecuteNonQuery()
        End Sub
    End Class
End Namespace
