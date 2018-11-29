Imports System.Windows.Forms

Public Class FrmPasswordReset
    Private Access As New DBControl
    Private myMd5 As New MD5Maker

    Private passwordCheck As Boolean

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        FrmUserMaintenance.txtPassword.Text = myMd5.MD5(txtNewPassword.Text)
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
        FrmUserMaintenance.cmdSave.Visible = False
    End Sub

    Private Sub txtNewPassword_TextChanged(sender As Object, e As EventArgs) Handles txtNewPassword.TextChanged
        chkPassword()
    End Sub

    Private Sub txtRetypePassword_TextChanged(sender As Object, e As EventArgs) Handles txtRetypePassword.TextChanged
        chkPassword()
    End Sub

    Private Sub FrmPasswordReset_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        passwordCheck = False
        OK_Button.Enabled = passwordCheck
    End Sub

    Private Sub chkPassword()
        If txtRetypePassword.Text = txtNewPassword.Text Then
            passwordCheck = True
            OK_Button.Enabled = passwordCheck
        End If

        If txtRetypePassword.Text = "" Or txtNewPassword.Text = "" Then
            passwordCheck = False
            OK_Button.Enabled = passwordCheck
        End If
    End Sub
End Class
