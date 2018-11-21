Public Class FrmUserMaintenance
    Private Access As New DBControl
    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        RefreshGrid()
    End Sub

    Public Sub RefreshGrid()

        Dim mySql As String

        'mySql = "select * from tbl_users order by first_name"

        mySql = "SELECT tbl_users.user_id, " _
            & "tbl_users.client_unit, " _
            & "tbl_users.user_login, " _
            & "tbl_users.password, " _
            & "tbl_users.first_name, " _
            & "tbl_users.middle_name, " _
            & "tbl_users.last_name, " _
            & "tbl_users.id_no, " _
            & "tbl_users.email_addr, " _
            & "tbl_users.mobile_no, " _
            & "tbl_client_unit.unit_text, " _
            & "tbl_client_org.org_text, " _
            & "tbl_client.client_text " _
            & "FROM(tbl_client " _
            & "INNER JOIN (tbl_client_org " _
            & "INNER JOIN tbl_client_unit On tbl_client_org.org_id = tbl_client_unit.org_id) " _
            & "On tbl_client.client_id = tbl_client_org.client_id) " _
            & "INNER JOIN tbl_users On tbl_client_unit.unit_id = tbl_users.client_unit; " _
        '& "WHERE(((tbl_users.user_id) = 1));"

        ' Run Query
        Access.ExecQuery(mySql)

        If NotEmpty(Access.Exception) Then
            MsgBox(Access.Exception)
            Exit Sub
        End If

        ' Fill DataGrid
        dgvData.DataSource = Access.DBDT

        ' Clear ComboBox
        cbxUsers.Items.Clear()

        ' Fill ComboBox
        For Each R As DataRow In Access.DBDT.Rows
            cbxUsers.Items.Add(R("user_login"))
        Next

        ' Display first name found
        If Access.RecordCount > 0 Then
            cbxUsers.SelectedIndex = 0

        End If
    End Sub

    Private Sub SearchMember(Name As String)
        ' Add Parameters
        Access.AddParam("@user_login", "%" & Name & "%")
        Access.ExecQuery("select * from tbl_users where user_login like @user_login")

        ' Report and Abort
        If NotEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ' Fill DataGrid
        dgvData.DataSource = Access.DBDT
    End Sub

    Private Sub cmdFind_Click(sender As Object, e As EventArgs) Handles cmdFind.Click
        SearchMember(txtFind.Text)
    End Sub

    Private Sub txtFind_TextChanged(sender As Object, e As EventArgs) Handles txtFind.TextChanged
        SearchMember(txtFind.Text)
    End Sub

    Private Sub NewUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewUserToolStripMenuItem.Click
        NewUser.Show()
    End Sub


    Private Sub dgvData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = dgvData.Rows(index)

        txtUserId.Text = selectedRow.Cells(0).Value.ToString
        txtUserLogin.Text = selectedRow.Cells(2).Value.ToString
        txtPassword.Text = selectedRow.Cells(3).Value.ToString
        txtFirstName.Text = selectedRow.Cells(4).Value.ToString
        txtMiddleName.Text = selectedRow.Cells(5).Value.ToString
        txtLastName.Text = selectedRow.Cells(6).Value.ToString
        txtIdNumber.Text = selectedRow.Cells(7).Value.ToString
        txtEmail.Text = selectedRow.Cells(8).Value.ToString
        txtMobile.Text = selectedRow.Cells(9).Value.ToString

        ' Need to get values for the Client,Org,Unit
        Dim myUnit As String
        myUnit = selectedRow.Cells(1).Value.ToString


        txtClient.Text = selectedRow.Cells(12).Value.ToString
        txtOrganisation.Text = selectedRow.Cells(11).Value.ToString
        txtUnitInOrg.Text = selectedRow.Cells(10).Value.ToString

    End Sub
End Class