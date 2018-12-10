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
        If UserCheck() = True Then
            FrmMain.ShowDialog()
        Else
            MsgBox("O Gaats")
        End If

        Me.Close()
    End Sub

    Private Function UserCheck() As Boolean

        ' Add Parameters - Order Matters !!!
        ' EXTREMLY IMPORTANT
        Access.AddParam("@userlogin", txtUserName.Text)

        ' Build the SQL String
        mySql = "select user_login, [password] from tbl_users where user_login = @userlogin;"

        ' Run the Query
        Access.ExecQuery(mySql)

        ' Check if any records exist
        If Not String.IsNullOrEmpty(Access.Exception) Then
            UserCheck = False
        Else

            Dim getUserName As String = ""
            Dim getPassword As String = ""
            Dim chkPassword As String = ""

            If Access.RecordCount > 0 Then
                For Each r As DataRow In Access.DBDT.Rows
                    getUserName = r("user_login")
                    getPassword = r("password")
                Next

                chkPassword = myMd5.MD5(txtPassword.Text)

                If getPassword = chkPassword Then
                    UserCheck = True
                Else
                    UserCheck = False
                End If
            End If
        End If

        Return UserCheck
    End Function

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
        End
    End Sub
End Class