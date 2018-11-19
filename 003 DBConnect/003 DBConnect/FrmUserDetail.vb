Imports System.Data.OleDb
Public Class FrmUserDetail
    Private Sub FrmUserDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'QuestionBank_20180807_beDataSet.tbl_users' table. You can move, or remove it, as needed.
        Me.Tbl_usersTableAdapter.Fill(Me.QuestionBank_20180807_beDataSet.tbl_users)


    End Sub


    Private Sub dtgUsers_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dtgUsers.CellClick
        Dim index As Integer
        index = e.RowIndex

        Dim selectedRow As DataGridViewRow
        selectedRow = dtgUsers.Rows(index)

        txtUserId.Text = selectedRow.Cells(0).Value.ToString
        txtUserLogin.Text = selectedRow.Cells(1).Value.ToString
        txtPassword.Text = selectedRow.Cells(2).Value.ToString
        txtFirstName.Text = selectedRow.Cells(3).Value.ToString
        txtMiddleName.Text = selectedRow.Cells(4).Value.ToString
        txtLastName.Text = selectedRow.Cells(5).Value.ToString
        txtIdNo.Text = selectedRow.Cells(6).Value.ToString

        txtEmail.Text = selectedRow.Cells(7).Value.ToString
        txtMobile.Text = selectedRow.Cells(8).Value.ToString




        txtClient.Text = selectedRow.Cells(9).Value.ToString
        txtOrganistation.Text = selectedRow.Cells(10).Value.ToString
        txtUnitInOrg.Text = selectedRow.Cells(11).Value.ToString

    End Sub

    Private Sub myQuery()
        Dim ds As New DataSet
        Dim mySql As String
        Const recNFound As String = "Record not Found"

        Dim myPass As New MD5Maker

        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Shayne.Tappan\Dropbox\Shayne Tappan\MyDevelopments\Access DB\Question Bank\QuestionBank 20180807_be.accdb")
        Dim cmd As OleDbCommand = New OleDbCommand("qryTest", con)
        con.Open()

        cmd.ExecuteNonQuery()


        'Using dr As OleDbDataReader = cmd.ExecuteNonQuery()
        '    If dr.HasRows Then
        '        dr.Read()

        '        'txtFirstName.Text = If(myPass.MD5(txtPassword.Text) = dr("password"), "Correct", "Wrong")
        '    Else
        '        'txtFirstName.Text = recNFound
        '    End If

        'End Using
        con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        myQuery()
    End Sub
End Class