Public Class FrmUserMaintenance
    Private Access As New DBControl
    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        RefreshGrid()
    End Sub

    Public Sub RefreshGrid()
        ' Run Query
        Access.ExecQuery("select * from tbl_users order by first_name")

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
End Class