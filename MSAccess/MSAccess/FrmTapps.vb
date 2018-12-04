Public Class FrmTapps
    Private Sub FrmTapps_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'WindowState = FormWindowState.Maximized
    End Sub

    Private Sub cmdLogIn_Click(sender As Object, e As EventArgs) Handles cmdLogIn.Click
        FrmMain.ShowDialog()
        Me.Close()
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
        End
    End Sub
End Class