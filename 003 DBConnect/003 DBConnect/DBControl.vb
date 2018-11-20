Imports System.Data.OleDb

Public Class DBControl
    Private _pwIN As String

    Function GetPW(userLogin As String, pwIn As String)
        Dim ds As New DataSet
        Dim mySql As String

        Dim myPass As New MD5Maker
        Dim myPW As String

        mySql = "select * from tbl_users where user_login = '" & userLogin & "'"

        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Shayne.Tappan\Dropbox\Shayne Tappan\MyDevelopments\Access DB\Question Bank\QuestionBank 20180807_be.accdb")
        con.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(mySql, con)

        Using dr As OleDbDataReader = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                myPW = myPass.MD5(pwIn)

                If dr("password") = myPW Then
                    Return True
                Else
                    Return False
                End If
                'txtFirstName.Text = If(= = dr("password"), "Correct", "Wrong")
            Else
                'txtFirstName.Text = recNFound
            End If

        End Using
        con.Close()

    End Function

    Private Property typePW As String
        Get

        End Get
        Set(value As String)
            _pwIN = value
        End Set
    End Property

End Class
