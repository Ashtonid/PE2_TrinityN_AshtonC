Public Class LoginForm
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrEmpty(tbUsername.Text.Trim) Then
            ErrorProvider1.SetError(tbUsername, "Please enter a username.")
            tbUsername.Focus()
        Else
            ErrorProvider1.SetError(tbUsername, String.Empty)
        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub tbUsername_TextChanged(sender As Object, e As EventArgs) Handles tbUsername.TextChanged

    End Sub
End Class
