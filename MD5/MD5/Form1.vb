Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdHash_Click(sender As Object, e As EventArgs) Handles cmdHash.Click

        Dim myPass As New MD5Maker

        If txtSample.Text <> "" Then
            txtMD5.Text = myPass.MD5(txtSample.Text)
        Else
            txtMD5.Text = myPass.MD5("ZERO")
        End If

    End Sub
End Class
