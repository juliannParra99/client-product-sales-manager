Imports Microsoft.VisualBasic
Imports System.ComponentModel
Imports System.Reflection


Namespace Model
    Public Class Product
        <DisplayName("Id")>
        Public Property Id As Integer
        <DisplayName("Name")>
        Public Property Name As String
        <DisplayName("Price")>
        Public Property Price As Double
        <DisplayName("Category")>
        Public Property Category As String
    End Class
End Namespace