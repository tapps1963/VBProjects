Public Class FrmUserMaintenance
    Private mySql As String
    Private Access As New DBControl

    Public MyOrgUnit As New FrmGetOrgUnit


    Private Function NotEmpty(text As String) As Boolean
        Return Not String.IsNullOrEmpty(text)
    End Function

    Private Sub FrmUserMaintenance_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Me.WindowState = FormWindowState.Maximized

        grbClient.Visible = False
        grbLogin.Visible = False
        grbUserDetail.Visible = False

        cmdCreate.Visible = False
        cmdCreate.Text = "Create"

        cmdChange.Visible = False
        cmdChange.Text = "Change"

        cmdUnitInOrg.Visible = False

        SetFields(True)

        RefreshGrid()

        cmdSave.Visible = False
        cmdSave.Text = "Save"
        cmdSave.Tag = ""

        cmdResetPW.Visible = False

        txtPassword.Enabled = False

    End Sub

    Private Function SetFields(OnOff As Boolean) As Boolean
        txtUserLogin.ReadOnly = OnOff
        txtPassword.ReadOnly = OnOff
        txtFirstName.ReadOnly = OnOff
        txtMiddleName.ReadOnly = OnOff
        txtLastName.ReadOnly = OnOff
        txtIdNumber.ReadOnly = OnOff
        txtEmail.ReadOnly = OnOff
        txtMobile.ReadOnly = OnOff
        cbxActive.Enabled = Not OnOff
    End Function

    Private Sub RefreshGrid()
        '& "tbl_users.password, " _
        'mySql = "select * from tbl_users order by first_name"

        mySql = "SELECT tbl_users.user_id, " _
        & "tbl_users.client_unit, " _
        & "tbl_users.user_login, " _
        & "tbl_users.first_name, " _
        & "tbl_users.middle_name, " _
        & "tbl_users.last_name, " _
        & "tbl_users.id_no, " _
        & "tbl_users.email_addr, " _
        & "tbl_users.mobile_no, " _
        & "tbl_users.active, " _
        & "tbl_client_unit.unit_text, " _
        & "tbl_client_org.org_text, " _
        & "tbl_client.client_text " _
        & "FROM(tbl_client " _
        & "INNER JOIN (tbl_client_org " _
        & "INNER JOIN tbl_client_unit On tbl_client_org.org_id = tbl_client_unit.org_id) " _
        & "On tbl_client.client_id = tbl_client_org.client_id) " _
        & "INNER JOIN tbl_users On tbl_client_unit.unit_id = tbl_users.client_unit " _
        & "ORDER BY tbl_users.user_id;"

        ' Run Query
        Access.ExecQuery(mySql)

        If NotEmpty(Access.Exception) Then
            MsgBox(Access.Exception)
            Exit Sub
        End If

        ' Fill DataGrid
        dgvData.DataSource = Access.DBDT

        '' Clear ComboBox
        'cbxUsers.Items.Clear()

        '' Fill ComboBox
        'For Each R As DataRow In Access.DBDT.Rows
        '    cbxUsers.Items.Add(R("user_login"))
        'Next

        ' Display first name found
        'If Access.RecordCount > 0 Then
        '    cbxUsers.SelectedIndex = 0

        'End If
    End Sub

    Private Sub SearchMember(Name As String)
        '& "tbl_users.password, " _
        'mySql = "select * from tbl_users where user_login like @user_login"

        mySql = "SELECT tbl_users.user_id, " _
        & "tbl_users.client_unit, " _
        & "tbl_users.user_login, " _
        & "tbl_users.first_name, " _
        & "tbl_users.middle_name, " _
        & "tbl_users.last_name, " _
        & "tbl_users.id_no, " _
        & "tbl_users.email_addr, " _
        & "tbl_users.mobile_no, " _
        & "tbl_users.active, " _
        & "tbl_client_unit.unit_text, " _
        & "tbl_client_org.org_text, " _
        & "tbl_client.client_text " _
        & "FROM(tbl_client " _
        & "INNER JOIN (tbl_client_org " _
        & "INNER JOIN tbl_client_unit On tbl_client_org.org_id = tbl_client_unit.org_id) " _
        & "On tbl_client.client_id = tbl_client_org.client_id) " _
        & "INNER JOIN tbl_users On tbl_client_unit.unit_id = tbl_users.client_unit " _
        & "WHERE first_name like @first_name;"

        ' Add Parameters
        Access.AddParam("@first_name", "%" & Name & "%")
        Access.ExecQuery(mySql)

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

    Private Sub dgvData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellClick

        grbClient.Visible = True
        grbLogin.Visible = True
        grbUserDetail.Visible = True

        cmdChange.Visible = True
        cmdCreate.Visible = True

        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = dgvData.Rows(index)

        txtUserId.Text = selectedRow.Cells(0).Value.ToString
        txtUnitInOrg.Tag = selectedRow.Cells(1).Value.ToString
        txtUserLogin.Text = selectedRow.Cells(2).Value.ToString
        txtPassword.Text = "abcdefghijklmnopqrst"
        txtFirstName.Text = selectedRow.Cells(3).Value.ToString
        txtMiddleName.Text = selectedRow.Cells(4).Value.ToString
        txtLastName.Text = selectedRow.Cells(5).Value.ToString
        txtIdNumber.Text = selectedRow.Cells(6).Value.ToString
        txtEmail.Text = selectedRow.Cells(7).Value.ToString
        txtMobile.Text = selectedRow.Cells(8).Value.ToString
        cbxActive.Checked = selectedRow.Cells(9).Value.ToString

        ' Need to get values for the Client,Org,Unit
        Dim myUnit As String
        myUnit = selectedRow.Cells(1).Value.ToString


        txtClient.Text = selectedRow.Cells(12).Value.ToString
        txtOrganisation.Text = selectedRow.Cells(11).Value.ToString
        txtUnitInOrg.Text = selectedRow.Cells(10).Value.ToString

    End Sub

    Private Sub cmdResetPW_Click(sender As Object, e As EventArgs) Handles cmdResetPW.Click
        cmdSave.Visible = True
        FrmPasswordReset.ShowDialog()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click

        Select Case cmdSave.Tag
            Case "Create"
                CreateUser()

            Case "Change"
                ChangeUser()
                cmdSave.Tag = "Change"

            Case Else

        End Select
    End Sub

    Private Sub CreateUser()
        ' Validate field content
        If ChkUserFields() = False Then Exit Sub

        ' Add Parameters - Order Matters !!!
        ' EXTREMLY IMPORTANT
        Access.AddParam("@userlogin", txtUserLogin.Text)
        Access.AddParam("@unit", Val(txtUnitInOrg.Tag))
        Access.AddParam("@password", txtPassword.Text)
        Access.AddParam("@firstname", txtFirstName.Text)
        Access.AddParam("@middlename", txtMiddleName.Text)
        Access.AddParam("@lastname", txtLastName.Text)
        Access.AddParam("@idno", txtIdNumber.Text)
        Access.AddParam("@email", txtEmail.Text)
        Access.AddParam("@mobile", txtMobile.Text)
        Access.AddParam("@active", cbxActive.Checked)

        ' Build the SQL String
        mySql = "insert into tbl_users " &
            "(user_login, " &
            "client_unit, " &
            "[password]," &
            "first_name, " &
            "middle_name, " &
            "last_name, " &
            "id_no, " &
            "email_addr, " &
            "mobile_no, " &
            "active) " &
            "values (@userlogin, " &
            "@unit, " &
            "@password, " &
            "@firstname, " &
            "@middlename, " &
            "@lastname, " &
            "@idno, " &
            "@email, " &
            "@mobile, " &
            "@active); "

        ' Run the Command
        Access.ExecQuery(mySql)

        ' Report and Abort
        If NoErrors(True) Then
            Exit Sub
        End If

        ' Refresh User data Grd
        RefreshGrid()

        cmdSave.Tag = "Change"

    End Sub

    Private Sub ChangeUser()
        ' Fail if no User is selected
        If String.IsNullOrEmpty(txtUserId.Text) Then
            Exit Sub
        End If
        ' TODO The passowrd does need update from the read Password...

        ' Add Parameters - Order Matters !!!
        ' EXTREMLY IMPORTANT
        Access.AddParam("@userlogin", txtUserLogin.Text)
        Access.AddParam("@unit", txtUnitInOrg.Tag)
        Access.AddParam("@password", txtPassword.Text)
        Access.AddParam("@firstname", txtFirstName.Text)
        Access.AddParam("@middlename", txtMiddleName.Text)
        Access.AddParam("@lastname", txtLastName.Text)
        Access.AddParam("@idno", txtIdNumber.Text)
        Access.AddParam("@email", txtEmail.Text)
        Access.AddParam("@mobile", txtMobile.Text)
        Access.AddParam("@active", cbxActive.Checked)
        Access.AddParam("@userid", txtUserId.Text)

        ' Run the Command
        mySql = "update tbl_users " &
            "set user_login=@userlogin," &
            "client_unit=@unit," &
            "[password]=@password," &
            "first_name=@firstname," &
            "middle_name=@middlename," &
            "last_name=@lastname," &
            "id_no=@idno," &
            "email_addr=@email, " &
            "mobile_no=@mobile," &
            "active=@active " &
            "where user_id=@userid"

        'mySql = "update tbl_users " &
        '    "set first_name=@firstname " &
        '    "where user_id=@userid"

        Access.ExecQuery(mySql)

        ' Report and Abort
        If NoErrors(True) Then
            Exit Sub
        End If

        ' Refresh User data Grd
        RefreshGrid()

        cmdSave.Visible = False

    End Sub


    Private Function ChkUserFields() As Boolean


        ' Check the User Login
        If txtUserLogin.Text <> "" Then
            ChkUserFields = True
        Else
            MsgBox("Enter the User Login", MsgBoxStyle.Exclamation, "User Detail Missing")
            ChkUserFields = False
            Exit Function
        End If

        ' Check if an Org Unit have been selected
        If txtUnitInOrg.Tag.ToString <> "" Then
            ChkUserFields = True
        Else
            MsgBox("Enter the Org Unit", MsgBoxStyle.Exclamation, "User Detail Missing")
            ChkUserFields = False
            Exit Function
        End If

        ' Check if the Password have been set
        If txtPassword.Text <> "" Then
            ChkUserFields = True
        Else
            MsgBox("Password not set", MsgBoxStyle.Exclamation, "User Detail Missing")
            ChkUserFields = False
            Exit Function
        End If

        ' Check First Name have been entered
        If txtFirstName.Text <> "" Then
            ChkUserFields = True
        Else
            MsgBox("Enter First Name", MsgBoxStyle.Exclamation, "User Detail Missing")
            ChkUserFields = False
            Exit Function
        End If

        ' Check Last Name have been entered
        If txtLastName.Text <> "" Then
            ChkUserFields = True
        Else
            MsgBox("Enter Last Name", MsgBoxStyle.Exclamation, "User Detail Missing")
            ChkUserFields = False
            Exit Function
        End If

        ' Check Id Number have been entered
        If txtIdNumber.Text <> "" Then
            ChkUserFields = True
        Else
            MsgBox("Enter Id Number", MsgBoxStyle.Exclamation, "User Detail Missing")
            ChkUserFields = False
            Exit Function
        End If

        ' Check email have been entered
        If txtEmail.Text <> "" Then
            ChkUserFields = True
        Else
            MsgBox("Enter eMail Address", MsgBoxStyle.Exclamation, "User Detail Missing")
            ChkUserFields = False
            Exit Function
        End If

        ' Check if Mobile Number have been entered
        If txtMobile.Text <> "" Then
            ChkUserFields = True
        Else
            MsgBox("Enter Mobile Number", MsgBoxStyle.Exclamation, "User Detail Missing")
            ChkUserFields = False
            Exit Function
        End If

        ' Active is True or False
        'Access.AddParam("@active", cbxActive.Checked)

    End Function

    Private Function NoErrors(Optional Report As Boolean = False) As Boolean
        If Not String.IsNullOrEmpty(Access.Exception) Then
            If Report = True Then
                MsgBox(Access.Exception)
                Return False
            Else
                Return True
            End If
        End If
    End Function

    Private Sub cmdCreate_Click(sender As Object, e As EventArgs) Handles cmdCreate.Click
        ' Clear the User Form
        ClearForm()
        SetFields(Not True)
        txtPassword.Text = ""
        cmdSave.Visible = True
        cmdUnitInOrg.Visible = True
        cmdResetPW.Visible = True

        cmdSave.Tag = "Create"
        ' TODO insert Data into the db

    End Sub

    Private Sub ClearForm()
        ' This sub will clear the User Form ready for input

        txtUserId.Text = "(new)"
        txtUnitInOrg.Tag = ""
        txtUserLogin.Text = ""
        txtPassword.Text = "abcdefghijklmnopqrst"
        txtFirstName.Text = ""
        txtMiddleName.Text = ""
        txtLastName.Text = ""
        txtIdNumber.Text = ""
        txtEmail.Text = ""
        txtMobile.Text = ""
        cbxActive.Checked = True

        txtClient.Text = ""
        txtOrganisation.Text = ""
        txtUnitInOrg.Text = ""

    End Sub

    Private Sub cmdUnitInOrg_Click(sender As Object, e As EventArgs) Handles cmdUnitInOrg.Click

        cmdSave.Visible = True

        MyOrgUnit.ShowDialog()
        'FrmGetOrgUnit.Show()

    End Sub

    Private Sub cmdChange_Click(sender As Object, e As EventArgs) Handles cmdChange.Click
        Select Case cmdChange.Text
            Case "Change"
                SetFields(Not True)
                cmdChange.Text = "Display"
                'cmdSave.Visible = True
                cmdSave.Tag = "Change"
                cmdUnitInOrg.Visible = True
                cmdResetPW.Visible = True

            Case "Display"
                SetFields(True)
                cmdChange.Text = "Change"
                cmdSave.Visible = False
                cmdUnitInOrg.Visible = False
                cmdResetPW.Visible = False

        End Select

    End Sub



    'Private Sub cbxActive_MouseClick(sender As Object, e As MouseEventArgs) Handles cbxActive.MouseClick
    '    cmdSave.Visible = True
    'End Sub

    Private Sub cbxActive_CheckedChanged(sender As Object, e As EventArgs) Handles cbxActive.CheckedChanged
        cmdSave.Visible = True
    End Sub

    Private Sub txtUserLogin_TextChanged(sender As Object, e As EventArgs) Handles txtUserLogin.TextChanged
        cmdSave.Visible = True
    End Sub

    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged
        cmdSave.Visible = True
    End Sub

    Private Sub txtMiddleName_TextChanged(sender As Object, e As EventArgs) Handles txtMiddleName.TextChanged
        cmdSave.Visible = True
    End Sub

    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged
        cmdSave.Visible = True
    End Sub

    Private Sub txtIdNumber_TextChanged(sender As Object, e As EventArgs) Handles txtIdNumber.TextChanged
        cmdSave.Visible = True
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        cmdSave.Visible = True
    End Sub

    Private Sub txtMobile_TextChanged(sender As Object, e As EventArgs) Handles txtMobile.TextChanged
        cmdSave.Visible = True
    End Sub
End Class