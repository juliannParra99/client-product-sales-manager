Imports Business.Business
Imports Model.Models

Public Class frmAddClients
    Private client As Client = Nothing

    ' Constructor without parameter to add a new one
    Public Sub New()
        InitializeComponent()
    End Sub

    ' constructur overcharged to update the client
    Public Sub New(client As Client)
        InitializeComponent()
        Text = "Modify Client"
        Me.client = client

        ' charge the info of the clients into the textbox
        If client IsNot Nothing Then
            txtName.Text = client.Name
            txtPhone.Text = client.Phone
            txtEmail.Text = client.Email
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub frmAddClients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If client IsNot Nothing Then
                txtName.Text = client.Name
                txtPhone.Text = client.Phone
                txtEmail.Text = client.Email
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        Dim businessClient As New ClientBusiness()

        Try
            If client Is Nothing Then
                client = New Client()
            End If

            If ValidateRequiredFields() Then
                Return
            End If

            client.Name = txtName.Text
            client.Phone = txtPhone.Text
            client.Email = txtEmail.Text

            If client.Id <> 0 Then
                businessClient.UpdateClient(client)
                MessageBox.Show("Successfully modified.")
            Else
                businessClient.AddClient(client)
                MessageBox.Show("Added successfully.")
            End If

            Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Clipboard.SetText(ex.ToString())
        End Try
    End Sub

    Private Function ValidateRequiredFields() As Boolean
        If String.IsNullOrEmpty(txtName.Text) Then
            MessageBox.Show("Please enter the client's name.")
            Return True
        End If
        If String.IsNullOrEmpty(txtPhone.Text) Then
            MessageBox.Show("Please enter the client's phone number.")
            Return True
        End If
        If String.IsNullOrEmpty(txtEmail.Text) Then
            MessageBox.Show("Please enter the client's email.")
            Return True
        End If
        Return False
    End Function
End Class
