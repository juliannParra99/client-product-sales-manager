Imports Business.Business
Imports Model.Models

Public Class frmUpdateSale
    Private saleItem As SaleItem = Nothing


    ' Constructor que acepta un parámetro
    Public Sub New(item As SaleItem)
        ' Llamar al constructor base
        InitializeComponent()

        ' Guardar el parámetro en la variable de instancia
        Me.saleItem = item
        PopulateFields()
        ' Inicializar el formulario con los datos del saleItem
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click

    End Sub

    Private Sub PopulateFields()
        If SaleItem IsNot Nothing Then
            ' Llenar los campos relacionados con la venta
            Dim saleBusiness As New SaleBusiness()
            Dim sale As Sale = saleBusiness.GetSaleById(SaleItem.SaleId)

            txtIdClient.Text = sale.ClientId.ToString()
            dtmSaleDate.Value = sale.Date

            ' Llenar los campos relacionados con el SaleItem
            txtIdProduct.Text = SaleItem.ProductId.ToString()
            txtUnitPrice.Text = SaleItem.UnitPrice.ToString()
            txtQuantity.Text = SaleItem.Quantity.ToString()
        End If
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
End Class