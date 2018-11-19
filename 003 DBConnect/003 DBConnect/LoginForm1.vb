Imports System.Data.OleDb

Public Class FormLogin

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim ds As New DataSet
        Dim mySql As String
        Const recNFound As String = "Record not Found"

        Dim myPass As New MD5Maker

        mySql = "select * from tbl_users where user_login = '" & txtUserName.Text & "'"

        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Shayne.Tappan\Dropbox\Shayne Tappan\MyDevelopments\Access DB\Question Bank\QuestionBank 20180807_be.accdb")
        con.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(mySql, con)

        Using dr As OleDbDataReader = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()

                'txtFirstName.Text = If(myPass.MD5(txtPassword.Text) = dr("password"), "Correct", "Wrong")
            Else
                'txtFirstName.Text = recNFound
            End If

        End Using
        con.Close()
    End Sub



    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Form1.Show()
        'Close()
    End Sub

    Private Sub cmdSec_Click(sender As Object, e As EventArgs)

        Dim passme As Security = New Security()

        'txtFirstName.Text = passme.passMe

        Form1.Show()

    End Sub
End Class
