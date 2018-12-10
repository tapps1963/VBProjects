Public Class FrmTapps

    Private Access As New DBControl
    Private mySql As String
    Private myTest() As String
    Private clientId As Integer
    Private orgId As Integer
    Private unitId As Integer

    Private myMd5 As New MD5Maker

    Private Sub FrmTapps_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'WindowState = FormWindowState.Maximized
    End Sub

    Private Sub cmdLogIn_Click(sender As Object, e As EventArgs) Handles cmdLogIn.Click

        Select Case UserCheck()
            Case 0
                MsgBox(Access.Exception, MsgBoxStyle.Critical, "System Error")

            Case 1
                MsgBox("User Name not Found", MsgBoxStyle.Critical, "User Name not found!!")

            Case 2
                MsgBox("Wrong Password", MsgBoxStyle.Critical, "Password not correct!!")

            Case 3
                MsgBox("Enter Username and Password", MsgBoxStyle.Critical, "Blank Fields")

            Case 99
                FrmMain.ShowDialog()
                Me.Close()

        End Select

    End Sub

    Private Function UserCheck() As Integer

        ' Check if both fields have been filled in
        '
        If txtUserName.Text <> "" And txtPassword.Text <> "" Then

            '  Happy....Username and Password fields are filled in

            ' But first
            ' Add Parameters - Order Matters !!!
            ' <<<EXTREMLY IMPORTANT>>>
            Access.AddParam("@userlogin", txtUserName.Text)

            ' Build the SQL String
            mySql = "select user_login, [password] from tbl_users where user_login = @userlogin;"

            ' Run the Query
            Access.ExecQuery(mySql)

            ' Check if Query was executed without Errors
            If Not String.IsNullOrEmpty(Access.Exception) Then
                UserCheck = 0   ' System check
            Else
                Dim getUserName As String = ""
                Dim getPassword As String = ""
                Dim chkPassword As String = ""

                If Access.RecordCount > 0 Then ' Username was found
                    For Each r As DataRow In Access.DBDT.Rows
                        getUserName = r("user_login")
                        getPassword = r("password")
                    Next

                    chkPassword = myMd5.MD5(txtPassword.Text)

                    If getPassword = chkPassword Then
                        UserCheck = 99
                    Else
                        UserCheck = 2
                    End If
                Else
                    UserCheck = 1
                End If
            End If
        Else
            UserCheck = 3
        End If

endAll:
        Return UserCheck

    End Function

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
        End
    End Sub
End Class