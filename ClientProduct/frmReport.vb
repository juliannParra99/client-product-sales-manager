Imports Model.Models

Public Class frmReport
    Private _sales As List(Of Sale)
    Private _saleItems As List(Of SaleItem)

    Public Sub New(sales As List(Of Sale), saleItems As List(Of SaleItem))
        InitializeComponent()
        _sales = sales
        _saleItems = saleItems

    End Sub


    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim highestSale As Sale = GetSaleWithHighestTotal(_sales)
        LoadSaleHighestTotal(highestSale)
        Dim lowestSale As Sale = GetSaleWithLowestTotal(_sales)
        LoadSaleLowestTotal(lowestSale)

        ' Load most and least sold products
        Dim mostSoldProduct As SaleItem = GetMostSoldProduct(_saleItems)
        LoadMostSoldProduct(mostSoldProduct)
        Dim leastSoldProduct As SaleItem = GetLeastSoldProduct(_saleItems)
        LoadLeastSoldProduct(leastSoldProduct)
    End Sub

    Public Function GetSaleWithHighestTotal(sales As List(Of Sale)) As Sale

        ' Initialize with the first sale in the list to compare
        Dim highestSale As Sale = sales(0)

        ' Loop through each sale in the sales list
        For Each sale As Sale In sales
            ' Compare the Total of the current sale with the highestSale's Total
            If sale.Total > highestSale.Total Then
                ' If the current sale's Total is greater, update highestSale
                highestSale = sale
            End If
        Next

        ' Return the the highest Total
        Return highestSale
    End Function


    Public Function GetSaleWithLowestTotal(sales As List(Of Sale)) As Sale
        Dim lowestSale As Sale = sales(0)

        For Each sale As Sale In sales
            If sale.Total < lowestSale.Total Then
                lowestSale = sale
            End If
        Next

        Return lowestSale
    End Function

    ' Function to get the most sold product
    Public Function GetMostSoldProduct(saleItems As List(Of SaleItem)) As SaleItem
        Dim productTotals As New Dictionary(Of Integer, Double)()

        ' Accumulate quantities for each product
        For Each item As SaleItem In saleItems
            If item.ProductId > 0 Then
                If Not productTotals.ContainsKey(item.ProductId) Then
                    productTotals(item.ProductId) = 0
                End If
                productTotals(item.ProductId) += item.Quantity.GetValueOrDefault()
            End If
        Next

        ' Find the product with the highest quantity
        Dim mostSoldProductId As Integer = -1
        Dim maxQuantity As Double = 0

        For Each kvp In productTotals
            If kvp.Value > maxQuantity Then
                maxQuantity = kvp.Value
                mostSoldProductId = kvp.Key
            End If
        Next

        If mostSoldProductId = -1 Then
            Return Nothing
        End If

        Return New SaleItem With {
            .ProductId = mostSoldProductId,
            .Quantity = maxQuantity
        }
    End Function

    ' Function to get the least sold product
    Public Function GetLeastSoldProduct(saleItems As List(Of SaleItem)) As SaleItem
        Dim productTotals As New Dictionary(Of Integer, Double)()

        ' Accumulate quantities for each product
        For Each item As SaleItem In saleItems
            If item.ProductId > 0 Then
                If Not productTotals.ContainsKey(item.ProductId) Then
                    productTotals(item.ProductId) = 0
                End If
                productTotals(item.ProductId) += item.Quantity.GetValueOrDefault()
            End If
        Next

        ' Find the product with the lowest quantity
        Dim leastSoldProductId As Integer = -1
        Dim minQuantity As Double = Double.MaxValue

        For Each kvp In productTotals
            If kvp.Value < minQuantity Then
                minQuantity = kvp.Value
                leastSoldProductId = kvp.Key
            End If
        Next

        If leastSoldProductId = -1 Then
            Return Nothing
        End If

        Return New SaleItem With {
            .ProductId = leastSoldProductId,
            .Quantity = minQuantity
        }
    End Function

    Public Sub LoadSaleHighestTotal(sale As Sale)
        lblSaleIdInfoHigh.Text = sale.Id
        lblClientIdInfoHigh.Text = sale.ClientId
        lblSaleDateInfoHigh.Text = sale.Date
        lblTotalSaleInfoHigh.Text = sale.Total
    End Sub

    Public Sub LoadSaleLowestTotal(sale As Sale)
        lblSaleIdInfoLow.Text = sale.Id
        lblClientIdInfoLow.Text = sale.ClientId
        lblSaleDateInfoLow.Text = sale.Date
        lblTotalSaleInfoLow.Text = sale.Total
    End Sub

    Public Sub LoadMostSoldProduct(product As SaleItem)

        lblMostSoldProductId.Text = product.ProductId.ToString()
        lblMostSoldProductQuantity.Text = product.Quantity.ToString()
    End Sub

    Public Sub LoadLeastSoldProduct(product As SaleItem)

        lblLeastSoldProductId.Text = product.ProductId.ToString()
        lblLeastSoldProductQuantity.Text = product.Quantity.ToString()
    End Sub

End Class