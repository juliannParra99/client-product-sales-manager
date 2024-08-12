Imports System.ComponentModel

Namespace Models
    Public Class SaleItem
        <DisplayName("Id")>
        Public Property Id As Integer

        <DisplayName("Sale ID")>
        Public Property SaleId As Integer

        <DisplayName("Product ID")>
        Public Property ProductId As Integer

        <DisplayName("Unit Price")>
        Public Property UnitPrice As Double?

        <DisplayName("Quantity")>
        Public Property Quantity As Double?

        <DisplayName("Total Price")>
        Public Property TotalPrice As Double?
    End Class
End Namespace
