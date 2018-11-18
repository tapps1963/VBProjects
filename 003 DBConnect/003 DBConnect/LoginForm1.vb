Imports System.Data.OleDb

Public Class frmLogin

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        ' Going to try to connect to my Access

        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Shayne.Tappan\Dropbox\Shayne Tappan\MyDevelopments\Access DB\Question Bank\QuestionBank 20180807_be.accdb")
        Dim cmd As OleDbCommand
        Dim var1 As String
        Dim ds As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        'Dim dr As OleDbDataReader

        Dim mySql As String
        Dim thePassword As String

        mySql = "select * from tbl_users where user_login = '" & txtUserName.Text & "'"

        'da = New OleDb.OleDbDataAdapter(mySql, con)
        con.Open()

        cmd = New OleDbCommand(mySql, con)

        Using dr As OleDbDataReader = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                thePassword = dr("password")
                If txtPassword.Text = thePassword Then
                    txtFirstName.Text = "Correct"
                Else
                    txtFirstName.Text = "Wrong"
                End If

            Else
                txtFirstName.Text = "Record not found"
            End If
        End Using

        ' da.Fill(ds, "tbl_users")
        ' MessageBox.Show(ds.Tables("tbl_users").Rows(0).Item(2))
        'TextBox1.Text = ds.Tables("tbl_users").Rows(0).Item(4)

        con.Close()

        'Form1.Show()

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub


End Class
