Imports System.ComponentModel
Imports System.Reflection
Imports Model.Models
Imports Models.Models




Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Simula cargar datos
        Dim saleItems As New List(Of Model.Models.SaleItem) From {
            New SaleItem() With {.Id = 1, .SaleId = 1, .ProductId = 101, .UnitPrice = 50.0, .Quantity = 2, .TotalPrice = 100.0},
            New SaleItem() With {.Id = 2, .SaleId = 1, .ProductId = 102, .UnitPrice = 25.0, .Quantity = 1, .TotalPrice = 25.0}
        }

        ' Configura y muestra los datos en el DataGridView
        dgvClients.DataSource = saleItems
        ConfigurarColumnas()
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
End Class
