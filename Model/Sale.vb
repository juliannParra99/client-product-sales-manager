Imports System.ComponentModel


Namespace Models
    Public Class Sale
        <DisplayName("Id")>
        Public Property Id As Integer

        <DisplayName("Client ID")>
        Public Property ClientId As Integer

        <DisplayName("Date")>
        Public Property [Date] As DateTime?

        <DisplayName("Total Amount")>
        Public Property Total As Double
    End Class
End Namespace