Public Class NewUser
    Private Access As New DBControl

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub TextBox_Validate(sender As Object, e As EventArgs) Handles txtUserName.TextChanged, txtPassword.TextChanged
        If Not String.IsNullOrWhiteSpace(txtUserName.Text) AndAlso Not String.IsNullOrWhiteSpace(txtPassword.Text) Then
            cmdSave.Enabled = True
        End If
    End Sub

    Private Sub AddUser()
        ' Add Parameter
        Access.AddParam("@user", txtUserName.Text)
        Access.AddParam("@pass", txtPassword.Text)
        Access.AddParam("@email", txtEmail.Text)
        Access.AddParam("@active", cbIsActive.Checked)
        Access.AddParam("@unit", 3)

        ' Execute Insert Command
        Access.ExecQuery("Insert into tbl_users (user_login,[password],email_addr,active,client_unit) values (@user,@pass,@email,@active,@unit);")

        ' Report and Abort on Erros
        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception)
            Exit Sub
        End If

        ' Success
        MsgBox("User was added succesfully...")

        ' Refresh Data  Grid
        Form1.RefreshGrid()

        ' Close Form
        Me.Close()

    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        AddUser()
    End Sub
End Class