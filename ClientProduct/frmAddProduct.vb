Imports Business.Business
Imports Model.Models


Public Class frmAddProduct
    Private product As Product = Nothing

    '2 constructors; the default, and one if the object is initialized with an object Product inside
    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(product As Product)
        InitializeComponent()
        Text = "Modify Product"
        Me.product = product

        ' Load the product data into the form's controls
        If product IsNot Nothing Then
            txtName.Text = product.Name
            txtPrice.Text = product.Price.ToString()
            txtCategory.Text = product.Category
        End If
    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        Dim businessProduct As New ProductBusiness()

        Try
            ' Check if the product object is already initialized, if not, create a new instance
            If product Is Nothing Then
                product = New Product()
            End If

            If ValidateRequiredFields() Then
                Return
            End If

            ' Assign values to the object
            product.Name = txtName.Text
            product.Price = Convert.ToDouble(txtPrice.Text)
            product.Category = txtCategory.Text

            ' chekc if the project was updated or added depending the button the user used
            If product.Id <> 0 Then
                businessProduct.UpdateProduct(product)
                MessageBox.Show("Product modified successfully.")
            Else
                businessProduct.AddProduct(product)
                MessageBox.Show("Product added successfully.")
            End If


            Close()

        Catch ex As Exception

            MessageBox.Show(ex.ToString())
            Clipboard.SetText(ex.ToString())
        End Try

    End Sub

    Private Function ValidateRequiredFields() As Boolean
        If String.IsNullOrEmpty(txtName.Text) Then
            MessageBox.Show("Please enter the product's name.")
            Return True
        End If

        If String.IsNullOrEmpty(txtPrice.Text) OrElse Not IsNumeric(txtPrice.Text) Then
            MessageBox.Show("Please enter a valid price for the product.")
            Return True
        End If

        If String.IsNullOrEmpty(txtCategory.Text) Then
            MessageBox.Show("Please enter the product's category.")
            Return True
        End If

        ' return False indicating no issues
        Return False
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class