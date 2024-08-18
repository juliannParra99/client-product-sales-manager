Imports System.ComponentModel
Imports System.Reflection
Imports Model.Models
Imports Business.Business


Public Class frmSalesAndProd
    Private clientList As List(Of Client)
    Private productList As List(Of Product)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' change the data
        LoadClients()
        LoadProducts()
    End Sub


    ' method to centralize the list of clients to show
    Private Sub LoadClients()
        Dim clientBusiness As New ClientBusiness()

        Try
            ' get the list of clients
            clientList = clientBusiness.ListClients()

            'source data for dgv
            dgvClients.DataSource = clientList

            '
            ConfigurarColumnas()

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub LoadProducts()
        Dim productBusiness As New ProductBusiness()

        Try
            ' Retrieve the list of products
            productList = productBusiness.ListProducts()

            ' Set the list as the data source for the DataGridView
            dgvProducts.DataSource = productList

            ' Additional logic can be added here, such as formatting columns
            ConfigurarColumnas()


        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub ConfigurarColumnas()
        For Each column As DataGridViewColumn In dgvClients.Columns
            Dim prop = GetType(SaleItem).GetProperty(column.DataPropertyName)
            If prop IsNot Nothing Then
                Dim displayNameAttr = prop.GetCustomAttribute(Of DisplayNameAttribute)()
                If displayNameAttr IsNot Nothing Then
                    column.HeaderText = displayNameAttr.DisplayName
                End If
            End If
        Next
    End Sub

    Private Sub dgvClients_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClients.CellContentClick

    End Sub

    Private Sub btnNewClient_Click(sender As Object, e As EventArgs) Handles btnNewClient.Click
        Dim addClientForm As New frmAddClients()

        ' show the addClient Form as a dialog form
        addClientForm.ShowDialog()
        LoadClients()

    End Sub

    Private Sub btnUpdateClient_Click(sender As Object, e As EventArgs) Handles btnUpdateClient.Click
        Try
            ' get the client object from the selected row DataGridView
            Dim selectedClient As Client = CType(dgvClients.CurrentRow.DataBoundItem, Client)

            ' instance of  the form to update the client, passing the object as a parameter
            Dim updateClientForm As New frmAddClients(selectedClient)
            updateClientForm.ShowDialog()

            ' load the list of clients updated 
            LoadClients()

        Catch ex As Exception
            MessageBox.Show("Please select a record to modify.")
        End Try

    End Sub

    Private Sub btnDeleteClient_Click(sender As Object, e As EventArgs) Handles btnDeleteClient.Click
        Dim clientBusiness As New ClientBusiness()
        Dim selectedClient As Client

        Try
            ' Check if a row is selected in the DataGridView
            If dgvClients.CurrentRow Is Nothing Then
                MessageBox.Show("Please select a record to delete.")
                Return
            End If

            ' Confirm deletion with the user
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                ' Get the selected client from the current row of the DataGridView
                selectedClient = CType(dgvClients.CurrentRow.DataBoundItem, Client)

                ' Call the method to delete the client
                clientBusiness.DeleteClient(selectedClient)

                ' Reload the list of clients after deletion
                LoadClients()

                MessageBox.Show("Client deleted successfully.")
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred while deleting the client: " & ex.Message)
        End Try
    End Sub

    'Products data grid view logic
    Private Sub btnNewProduct_Click(sender As Object, e As EventArgs) Handles btnNewProduct.Click
        Dim addProductForm As New frmAddProduct()

        addProductForm.ShowDialog()
        LoadProducts()
    End Sub

    Private Sub btnUpdateProduct_Click(sender As Object, e As EventArgs) Handles btnUpdateProduct.Click
        Dim selectedProduct As Product = CType(dgvProducts.CurrentRow.DataBoundItem, Product)
        Dim updateProductForm As New frmAddProduct(selectedProduct)

        updateProductForm.ShowDialog()
        LoadProducts()

    End Sub

    Private Sub btnDeleteProduct_Click(sender As Object, e As EventArgs) Handles btnDeleteProduct.Click
        Dim productBusiness As New ProductBusiness()
        Dim selectedProduct As Product

        Try
            ' Check if a row is selected in the DataGridView
            If dgvProducts.CurrentRow Is Nothing Then
                MessageBox.Show("Please select a record to delete.")
                Return
            End If

            ' Confirm deletion with the user
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                ' Get the selected product from the current row of the DataGridView
                selectedProduct = CType(dgvProducts.CurrentRow.DataBoundItem, Product)

                ' Call the method to delete the product
                productBusiness.DeleteProduct(selectedProduct)

                ' Reload the list of products after deletion
                LoadProducts()

                MessageBox.Show("Product deleted successfully.")
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred while deleting the product: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvProducts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellContentClick

    End Sub


    'filter clients for name and email
    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        Dim filteredList As List(Of Client)
        Dim filter As String = txtName.Text

        Try
            ' If the filter is not empty, it searches for clients whose names contain the filter text, ignoring case sensitivity.
            ' The filtered list is then displayed in the DataGridView. If the filter is empty, the entire client list is shown.
            If filter <> "" Then
                filteredList = clientList.FindAll(Function(c) c.Name.ToUpper().Contains(filter.ToUpper()) Or c.Email.ToUpper().Contains(filter.ToUpper()))
            Else
                ' if empty show the entire list
                filteredList = clientList
            End If

            ' update the DataGridView with the filtered list
            ' clean the older one
            dgvClients.DataSource = Nothing
            dgvClients.DataSource = filteredList
            ConfigurarColumnas()

        Catch ex As Exception
            MessageBox.Show("An error occurred while filtering the data: " & ex.Message)
        End Try
    End Sub

    'filter products by name and category
    Private Sub txtNameOrCategory_TextChanged(sender As Object, e As EventArgs) Handles txtNameOrCategory.TextChanged
        Dim filteredList As List(Of Product)
        Dim filter As String = txtNameOrCategory.Text

        Try
            If Not String.IsNullOrWhiteSpace(filter) Then
                ' Filter the list of products by name or category
                filteredList = productList.FindAll(Function(p) p.Name.ToUpper().Contains(filter.ToUpper()) OrElse p.Category.ToUpper().Contains(filter.ToUpper()))
            Else
                ' If no filter is applied, show the entire list
                filteredList = productList
            End If

            dgvProducts.DataSource = Nothing
            dgvProducts.DataSource = filteredList
            ConfigurarColumnas()

        Catch ex As Exception
            MessageBox.Show("An error occurred while filtering the products: " & ex.Message)
        End Try
    End Sub



End Class
