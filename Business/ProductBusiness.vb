Imports System
Imports System.Data.SqlClient

Namespace Business
    Public Class ProductBusiness
        Private dataAccess As DataAccess

        Public Sub New(connectionString As String)
            dataAccess = New DataAccess(connectionString)
        End Sub

        ' Add a new product
        Public Sub AddProduct(name As String, price As Double, category As String)
            dataAccess.SetQuery("INSERT INTO productos (Nombre, Precio, Categoria) VALUES (@Name, @Price, @Category)")
            dataAccess.SetParameter("@Name", name)
            dataAccess.SetParameter("@Price", price)
            dataAccess.SetParameter("@Category", category)
            dataAccess.ExecuteNonQuery()
        End Sub

        ' Delete a product
        Public Sub DeleteProduct(productId As Integer)
            dataAccess.SetQuery("DELETE FROM productos WHERE ID = @ProductId")
            dataAccess.SetParameter("@ProductId", productId)
            dataAccess.ExecuteNonQuery()
        End Sub

        ' Update a product
        Public Sub UpdateProduct(productId As Integer, name As String, price As Double, category As String)
            dataAccess.SetQuery("UPDATE productos SET Nombre = @Name, Precio = @Price, Categoria = @Category WHERE ID = @ProductId")
            dataAccess.SetParameter("@ProductId", productId)
            dataAccess.SetParameter("@Name", name)
            dataAccess.SetParameter("@Price", price)
            dataAccess.SetParameter("@Category", category)
            dataAccess.ExecuteNonQuery()
        End Sub
    End Class
End Namespace
