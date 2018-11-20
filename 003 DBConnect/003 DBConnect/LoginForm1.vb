Imports System.Data.OleDb

Public Class FormLogin

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim myPW As New DBControl
        Dim mypass As Boolean

        mypass = myPW.GetPW(txtUserName.Text, txtPassword.Text)

        If mypass = True Then
            Me.Hide()
            Form1.ShowDialog()
        Else
            Close()
            MsgBox("Username & Password combination invalid.", MsgBoxStyle.Critical, "Authorisation Error")
        End If


    End Sub



    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Form1.Show()
        'Close()
    End Sub

    Private Sub cmdSec_Click(sender As Object, e As EventArgs)

        'Dim passme As Security = New Security()

        'txtFirstName.Text = passme.passMe

        Form1.Show()

    End Sub

End Class