Imports Business.Business
Imports Model.Models

Public Class frmUpdateSale
    Private saleItem As SaleItem = Nothing


    Public Sub New(item As SaleItem)
        InitializeComponent()

        Me.saleItem = item
        PopulateFields()
    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click

        Dim saleBusiness As New SaleBusiness()

        Try
            ' Validate the required fields
            If ValidateRequiredFields() Then
                Return
            End If

            ' Update the SaleItem with the new values from the form
            saleItem.ProductId = Convert.ToInt32(txtIdProduct.Text)
            saleItem.UnitPrice = Convert.ToDouble(txtUnitPrice.Text)
            saleItem.Quantity = Convert.ToInt32(txtQuantity.Text)
            saleItem.TotalPrice = saleItem.UnitPrice * saleItem.Quantity

            ' Update the SaleItem in the database
            saleBusiness.UpdateSaleItem(saleItem)

            ' Recalculate and update the total sale amount in the database
            saleBusiness.UpdateSaleTotal(saleItem.SaleId)

            ' Show a success message
            MessageBox.Show("Sale item updated successfully.")
            Close()

        Catch ex As Exception
            ' Show error message and copy to clipboard
            Dim errorMessage As String = $"An error occurred: {ex.Message}" & vbCrLf &
                                         $"Stack Trace: {ex.StackTrace}"
            Clipboard.SetText(errorMessage)
            MessageBox.Show(errorMessage)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub


    Private Sub PopulateFields()
        If SaleItem IsNot Nothing Then
            ' Llenar los campos relacionados con la venta
            Dim saleBusiness As New SaleBusiness()
            Dim sale As Sale = saleBusiness.GetSaleById(saleItem.SaleId)

            ' Llenar los campos relacionados con el SaleItem
            txtIdProduct.Text = SaleItem.ProductId.ToString()
            txtUnitPrice.Text = SaleItem.UnitPrice.ToString()
            txtQuantity.Text = SaleItem.Quantity.ToString()
        End If
    End Sub

    Private Function ValidateRequiredFields() As Boolean



        ' Check if required fields are empty

        If String.IsNullOrEmpty(txtIdProduct.Text) OrElse
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
End Class