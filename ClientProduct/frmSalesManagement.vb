Imports System.ComponentModel
Imports System.Reflection
Imports Business.Business
Imports Model.Models

Public Class frmSalesManagement
    Dim totalPriceSoldItems As Single

    Private Sub frmSalesManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSaleItems()
    End Sub
    Private Sub LoadSaleItems()
        Dim saleBusiness As New SaleBusiness()

        Try
            Dim saleItemsList As List(Of SaleItem) = saleBusiness.ListSaleItems()
            'add to the dataGried View related with the sales their data source
            Dim saleList As List(Of Sale) = saleBusiness.ListSales()

            dgvSaleItems.DataSource = saleItemsList
            dgvSalesInfo.DataSource = saleList

            ConfigurarColumnas()
            totalPriceSoldItems = saleBusiness.TotalPriceSoldItems()

            lblTotalSoldItems.Text = totalPriceSoldItems

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub


    Private Sub ConfigurarColumnas()
        For Each column As DataGridViewColumn In dgvSaleItems.Columns
            Dim prop = GetType(SaleItem).GetProperty(column.DataPropertyName)
            If prop IsNot Nothing Then
                Dim displayNameAttr = prop.GetCustomAttribute(Of DisplayNameAttribute)()
                If displayNameAttr IsNot Nothing Then
                    column.HeaderText = displayNameAttr.DisplayName
                End If
            End If
        Next
    End Sub

    Private Sub btnNewSale_Click(sender As Object, e As EventArgs) Handles btnNewSale.Click
        Dim addSalesForm As New frmAddSale()
        addSalesForm.ShowDialog()
        LoadSaleItems()
    End Sub

    Private Sub btnUpdateSale_Click(sender As Object, e As EventArgs) Handles btnUpdateSale.Click
        Try
            ' verify if there is a row selected
            If dgvSaleItems.SelectedRows.Count > 0 Then
                ' get the row
                Dim selectedRow As DataGridViewRow = dgvSaleItems.SelectedRows(0)

                ' Get the saleItem object from the row 
                Dim selectedSaleItem As SaleItem = CType(selectedRow.DataBoundItem, SaleItem)

                ' 
                Dim updateSaleForm As New frmUpdateSale(selectedSaleItem)
                updateSaleForm.ShowDialog()

                ' load the changes the user made
                LoadSaleItems()
            Else
                MessageBox.Show("Please select a record to modify.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDeleteSale_Click(sender As Object, e As EventArgs) Handles btnDeleteSale.Click
        Dim saleBusiness As New SaleBusiness()
        Dim saleItem As New SaleItem()

        Try
            If dgvSaleItems.CurrentRow Is Nothing Then
                MessageBox.Show("Please select a record to delete.")
                Return
            End If

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                saleItem = CType(dgvSaleItems.CurrentRow.DataBoundItem, SaleItem)
                saleBusiness.DeleteSaleItem(saleItem)
                MessageBox.Show("Sale Item deleted successfully.")

                LoadSaleItems()
                'update the Total for the sum of all those items which belong to that Sale into the table Ventas 
                saleBusiness.UpdateSaleTotal(saleItem.SaleId)

            End If


        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnSalesInfo_Click(sender As Object, e As EventArgs)

    End Sub

End Class