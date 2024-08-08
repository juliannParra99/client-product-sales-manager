Imports System ' Asegúrate de incluir otros espacios de nombres necesarios

Namespace Models ' Cambia "Models" al espacio de nombres adecuado para tu proyecto
    Public Class SaleItem
        Public Property Id As Integer
        Public Property SaleId As Integer
        Public Property ProductId As Integer
        Public Property UnitPrice As Double?
        Public Property Quantity As Double?
        Public Property TotalPrice As Double?
    End Class
End Namespace
