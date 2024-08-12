Imports System.ComponentModel
Imports System.Reflection
Imports Business.Business
Imports Model.Models

Public Class frmSalesManagement

    Private Sub frmSalesManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSaleItems()
    End Sub
    Private Sub LoadSaleItems()
        Dim saleBusiness As New SaleBusiness()

        Try
            Dim saleItemsList As List(Of SaleItem) = saleBusiness.ListSaleItems()

            dgvSaleItems.DataSource = saleItemsList

            ConfigurarColumnas()

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

    End Sub
End Class