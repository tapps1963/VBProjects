Imports System.Data.OleDb

Public Class FormLogin

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim ds As New DataSet
        Dim mySql As String
        Const recNFound As String = "Record not Found"

        mySql = "select * from tbl_users where user_login = '" & txtUserName.Text & "'"

        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Shayne.Tappan\Dropbox\Shayne Tappan\MyDevelopments\Access DB\Question Bank\QuestionBank 20180807_be.accdb")
        con.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(mySql, con)

        Using dr As OleDbDataReader = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                Dim thePassword As String = dr("password")

                txtFirstName.Text = If(txtPassword.Text = thePassword, "Correct", "Wrong")
            Else
                txtFirstName.Text = recNFound
            End If

        End Using
        con.Close()
    End Sub



    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub cmdSec_Click(sender As Object, e As EventArgs) Handles cmdSec.Click

        Dim passme As Security = New Security()

        txtFirstName.Text = passme.passMe

    End Sub
End Class
