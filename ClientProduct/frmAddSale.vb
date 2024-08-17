Imports Business.Business
Imports Model.Models

Public Class frmAddSale
    Private saleItem As SaleItem = Nothing

    ' Constructor para agregar una nueva venta
    Public Sub New()
        InitializeComponent()
    End Sub


    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        Dim saleBusiness As New SaleBusiness()
        Dim sale As New Sale()
        Dim saleItems As New List(Of SaleItem)()
        Dim saleId As Integer

        Try
            If Not ValidateRequiredFields() Then
                Return
            End If

            ' Assign values to the Sale object
            sale.ClientId = Convert.ToInt32(txtIdClient.Text)
            sale.Date = dtmSaleDate.Value.Date

            ' Check if a sale already exists with the same client and date
            saleId = saleBusiness.GetExistingSaleId(sale.ClientId, sale.Date)

            ' If no sale exists, create a new one
            If saleId = 0 Then
                saleId = saleBusiness.AddSale(sale)
                sale.Id = saleId
            Else
                sale.Id = saleId ' Assign the existing sale ID to the sale object
            End If

            ' Create a new SaleItem
            Dim newSaleItem As New SaleItem() With {
                .ProductId = Convert.ToInt32(txtIdProduct.Text),
                .UnitPrice = Convert.ToDouble(txtUnitPrice.Text),
                .Quantity = Convert.ToInt32(txtQuantity.Text),
                .TotalPrice = .UnitPrice * .Quantity
            }

            ' Add the new SaleItem to the list
            saleItems.Add(newSaleItem)

            ' Add SaleItem to the database
            saleBusiness.AddSaleItems(saleId, saleItems)

            ' Update the sale total in the database
            saleBusiness.UpdateSaleTotal(sale.Id)


            MessageBox.Show("Sale item added successfully.")
            Close()

        Catch ex As Exception
            Dim errorMessage As String = $"An error occurred: {ex.Message}" & vbCrLf &
                                         $"Stack Trace: {ex.StackTrace}"
            Clipboard.SetText(errorMessage)
            MessageBox.Show(errorMessage)
        End Try
    End Sub

    Private Function ValidateRequiredFields() As Boolean

        ' Check if required fields are empty
        If String.IsNullOrEmpty(txtIdClient.Text) OrElse
       String.IsNullOrEmpty(txtIdProduct.Text) OrElse
       String.IsNullOrEmpty(txtUnitPrice.Text) OrElse
       String.IsNullOrEmpty(txtQuantity.Text) Then
            MessageBox.Show("Please fill all required fields.")
            Return False
        End If

        ' Validate numeric values
        Dim unitPrice As Double
        Dim quantity As Integer
        Dim idClient As Integer
        Dim idProduct As Integer

        If Not Integer.TryParse(txtIdClient.Text, idClient) OrElse idClient <= 0 Then
            MessageBox.Show("Client ID must be a positive integer greater than zero.")
            Return False
        End If

        ' check that the id product is greater than zero 
        If Not Integer.TryParse(txtIdProduct.Text, idProduct) OrElse idProduct <= 0 Then
            MessageBox.Show("Product ID must be a positive integer greater than zero.")
            Return False
        End If

        'if tryparse return false cause it couldn't convert the input into boolean, ask again
        If Not Double.TryParse(txtUnitPrice.Text, unitPrice) Then
            MessageBox.Show("Please enter a valid Unit Price.")
            Return False
        End If

        'check if the unitPrice is higher than zero, if not, ask again
        If unitPrice <= 0 Then
            MessageBox.Show("Unit Price must be greater than zero.")
            Return False
        End If

        If Not Integer.TryParse(txtQuantity.Text, quantity) OrElse quantity <= 0 Then
            MessageBox.Show("Please enter a valid Quantity (positive integer).")
            Return False
        End If

        ' Additional validation checks can be added here

        'if everything went good return true
        Return True
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub dtmSaleDate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtmSaleDate.KeyPress
        e.Handled = True
    End Sub

    Private Sub frmAddSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class