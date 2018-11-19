
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



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myPW As New DBControl
        Dim mypass As Boolean

        mypass = myPW.GetPW("SCT", "general")

    End Sub
End Class