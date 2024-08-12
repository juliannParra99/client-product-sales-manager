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
            If ValidateRequiredFields() Then
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
            saleBusiness.UpdateSaleTotal(sale)


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


        Dim valid As Boolean = False

        ' Check if required fields are empty
        If String.IsNullOrEmpty(txtIdClient.Text) OrElse
       String.IsNullOrEmpty(txtIdProduct.Text) OrElse
       String.IsNullOrEmpty(txtUnitPrice.Text) OrElse
       String.IsNullOrEmpty(txtQuantity.Text) Then
            MessageBox.Show("Please fill all required fields.")
            Return True
        End If

        ' Validate numeric values
        Dim unitPrice As Double
        Dim quantity As Integer

        If Not Double.TryParse(txtUnitPrice.Text, unitPrice) Then
            MessageBox.Show("Please enter a valid Unit Price.")
            Return True
        End If

        If Not Integer.TryParse(txtQuantity.Text, quantity) OrElse quantity <= 0 Then
            MessageBox.Show("Please enter a valid Quantity (positive integer).")
            Return True
        End If

        ' Additional validation checks can be added here

        Return False
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