Imports System
Imports System.Data.SqlClient
Imports Model.Models
Imports System.Windows.Forms



Namespace Business
    Public Class SaleBusiness
        Private dataAccess As DataAccess

        Public Sub New()
            dataAccess = New DataAccess()
        End Sub


        Public Function ListSaleItems() As List(Of SaleItem)
            Dim saleItemsList As New List(Of SaleItem)()
            dataAccess.SetQuery("SELECT ID, IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal FROM ventasitems")

            Try
                dataAccess.ExecuteReader()

                While dataAccess.Reader.Read()
                    Dim saleItem As New SaleItem()
                    saleItem.Id = dataAccess.Reader.GetInt32(0)
                    saleItem.SaleId = dataAccess.Reader.GetInt32(1)
                    saleItem.ProductId = dataAccess.Reader.GetInt32(2)
                    saleItem.UnitPrice = If(dataAccess.Reader.IsDBNull(3), 0.0, dataAccess.Reader.GetDouble(3))
                    saleItem.Quantity = If(dataAccess.Reader.IsDBNull(4), 0.0, dataAccess.Reader.GetDouble(4))
                    saleItem.TotalPrice = If(dataAccess.Reader.IsDBNull(5), 0.0, dataAccess.Reader.GetDouble(5))

                    saleItemsList.Add(saleItem)
                End While
            Catch ex As Exception
                Throw ex
            Finally
                dataAccess.CloseConnection()
            End Try

            Return saleItemsList
        End Function



        ' Método para agregar una nueva venta
        Public Function AddSale(sale As Sale) As Integer
            Dim saleId As Integer = 0
            dataAccess.SetQuery("INSERT INTO ventas (IDCliente, Fecha) OUTPUT INSERTED.ID VALUES (@IdCliente, @Fecha)")
            dataAccess.SetParameter("@IdCliente", sale.ClientId)
            dataAccess.SetParameter("@Fecha", sale.Date)

            Try
                saleId = Convert.ToInt32(dataAccess.ExecuteScalar())
            Catch ex As Exception
                Throw ex
            Finally
                dataAccess.CloseConnection()
            End Try

            Return saleId
        End Function

        ' Method to add Sale items
        Public Sub AddSaleItems(saleId As Integer, items As List(Of SaleItem))
            dataAccess.SetQuery("INSERT INTO ventasitems (IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal) VALUES (@IDVenta, @IDProducto, @PrecioUnitario, @Cantidad, @PrecioTotal)")

            Try
                For Each item As SaleItem In items
                    dataAccess.SetParameter("@IDVenta", saleId)
                    dataAccess.SetParameter("@IDProducto", item.ProductId)
                    dataAccess.SetParameter("@PrecioUnitario", item.UnitPrice)
                    dataAccess.SetParameter("@Cantidad", item.Quantity)
                    dataAccess.SetParameter("@PrecioTotal", item.TotalPrice)
                    dataAccess.ExecuteNonQuery()
                Next
            Catch ex As Exception
                Throw ex
            Finally
                dataAccess.CloseConnection()
            End Try
        End Sub

        ' Updates the total amount for a sale based on the sum of items' prices.
        'The ID of the sale to update.
        Public Sub UpdateSaleTotal(saleId As Integer)
            Dim query As String = "UPDATE ventas SET Total = (SELECT SUM(PrecioTotal) FROM ventasitems WHERE IDVenta = @SaleId) WHERE ID = @SaleId"
            dataAccess.SetQuery(query)
            dataAccess.SetParameter("@SaleId", saleId)

            Try
                dataAccess.ExecuteNonQuery()
            Catch ex As SqlException
                Dim errorMessage As String = $"SQL Error: {ex.Number} - {ex.Message}" & vbCrLf &
                                     $"Query: {query}" & vbCrLf &
                                     $"Sale ID: {saleId}" & vbCrLf &
                                     $"Stack Trace: {ex.StackTrace}"

                Clipboard.SetText(ex.ToString())

                Clipboard.SetText(errorMessage)

                Throw New Exception(errorMessage, ex)
            Catch ex As Exception
                Dim errorMessage As String = $"An unexpected error occurred: {ex.Message}" & vbCrLf &
                                     $"Query: {query}" & vbCrLf &
                                     $"Sale ID: {saleId}" & vbCrLf &
                                     $"Stack Trace: {ex.StackTrace}"

                Clipboard.SetText(errorMessage)

                Throw New Exception(errorMessage, ex)
            Finally
                dataAccess.CloseConnection()
            End Try
        End Sub

        Public Function GetSaleById(saleId As Integer) As Sale
            Dim sale As New Sale()
            dataAccess.SetQuery("SELECT IDCliente, Fecha FROM ventas WHERE ID = @SaleId")
            dataAccess.SetParameter("@SaleId", saleId)

            Try
                dataAccess.ExecuteReader()

                If dataAccess.Reader.Read() Then
                    sale.Id = saleId
                    sale.ClientId = dataAccess.Reader.GetInt32(0) ' IDCliente
                    sale.Date = dataAccess.Reader.GetDateTime(1) ' Fecha
                End If
            Catch ex As Exception
                Throw New Exception("Error retrieving Sale data: " & ex.Message)
            Finally
                dataAccess.CloseConnection()
            End Try

            Return sale
        End Function

        Public Sub UpdateSale(sale As Sale)
            dataAccess.SetQuery("UPDATE ventas SET IDCliente = @ClientId, Fecha = @SaleDate WHERE ID = @SaleId")
            dataAccess.SetParameter("@ClientId", sale.ClientId)
            dataAccess.SetParameter("@SaleDate", sale.Date)
            dataAccess.SetParameter("@SaleId", sale.Id)

            Try
                dataAccess.ExecuteNonQuery()
            Catch ex As Exception
                Throw New Exception("Error updating Sale data: " & ex.Message)
            End Try
        End Sub

        Public Sub UpdateSaleItem(saleItem As SaleItem)
            dataAccess.SetQuery("UPDATE ventasitems SET IDProducto = @ProductId, PrecioUnitario = @UnitPrice, Cantidad = @Quantity, PrecioTotal = @TotalPrice WHERE ID = @SaleItemId")
            dataAccess.SetParameter("@ProductId", saleItem.ProductId)
            dataAccess.SetParameter("@UnitPrice", saleItem.UnitPrice)
            dataAccess.SetParameter("@Quantity", saleItem.Quantity)
            dataAccess.SetParameter("@TotalPrice", saleItem.TotalPrice)
            dataAccess.SetParameter("@SaleItemId", saleItem.Id)

            Try
                dataAccess.ExecuteNonQuery()
            Catch ex As Exception
                Throw New Exception("Error updating SaleItem data: " & ex.Message)
            End Try
        End Sub

        ' Method to list the sales
        Public Function ListSales() As List(Of Sale)
            Dim lista As New List(Of Sale)()
            dataAccess.SetQuery("SELECT ID, IDCliente, Fecha, Total FROM ventas")

            Try
                dataAccess.ExecuteReader()

                While dataAccess.Reader.Read()
                    Dim aux As New Sale()

                    aux.Id = If(Not dataAccess.Reader.IsDBNull(0), dataAccess.Reader.GetInt32(0), 0)
                    aux.ClientId = If(Not dataAccess.Reader.IsDBNull(1), dataAccess.Reader.GetInt32(1), 0)
                    aux.Date = If(Not dataAccess.Reader.IsDBNull(2), dataAccess.Reader.GetDateTime(2), DateTime.MinValue)
                    aux.Total = If(Not dataAccess.Reader.IsDBNull(3), dataAccess.Reader.GetDouble(3), 0.0)

                    lista.Add(aux)
                End While
            Catch ex As Exception
                Throw ' 
            Finally
                dataAccess.CloseConnection()
            End Try

            Return lista
        End Function

        Public Sub DeleteSaleById(saleId As Integer)
            Try
                dataAccess.SetQuery("DELETE FROM ventas WHERE ID = @id")
                dataAccess.SetParameter("@id", saleId)
                dataAccess.ExecuteNonQuery()
            Catch ex As Exception
                Throw
            End Try
        End Sub

        'in this part is important just to keep the date, and not include the hour. Otherwise the comparation will fail
        Public Function GetExistingSaleId(clientId As Integer, saleDate As Date) As Integer
            Dim query As String = "SELECT ID FROM ventas WHERE IDCliente = @ClientId AND CONVERT(date, Fecha) = CONVERT(date, @SaleDate)"
            dataAccess.SetQuery(query)
            dataAccess.SetParameter("@ClientId", clientId)
            dataAccess.SetParameter("@SaleDate", saleDate.Date) ' .Date to just include the Date, not hour

            Dim result As Object = dataAccess.ExecuteScalar()
            If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                Return Convert.ToInt32(result)
            Else
                Return 0 ' if there is any returns 0
            End If
        End Function


        Public Sub DeleteSaleItem(saleItem As SaleItem)
            dataAccess.SetQuery("DELETE FROM ventasItems WHERE ID = @saleItemId")
            dataAccess.SetParameter("@saleItemId", saleItem.Id)
            dataAccess.ExecuteNonQuery()
        End Sub

        ' get the sum of all the total prices from Item sold
        Public Function TotalPriceSoldItems() As Single
            Dim totalSum As Single = 0.0F

            Try
                ' Set the query to get the sum of PrecioTotal
                dataAccess.SetQuery("SELECT SUM(PrecioTotal) FROM ventasitems")

                ' Execute the query and retrieve the result
                Dim result = dataAccess.ExecuteScalar()

                ' Check if the result is not DBNull
                If result IsNot DBNull.Value Then
                    totalSum = Convert.ToSingle(result)
                End If

            Catch ex As Exception
                ' Handle any potential exceptions
                MessageBox.Show($"An error occurred: {ex.Message}")
            End Try

            Return totalSum
        End Function


    End Class
End Namespace
