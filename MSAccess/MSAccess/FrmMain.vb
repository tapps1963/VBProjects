Public Class FrmMain
    'Public FrmUsers As New FrmUserMaintenance
    Private Sub FrmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.WindowState = FormWindowState.Maximized
        FrmUserMaintenance.MdiParent = Me
    End Sub



    Private Sub FrmMain_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub

    Private Sub MaintainUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaintainUserToolStripMenuItem.Click
        FrmUserMaintenance.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        FrmMain_Closed(sender, e)
    End Sub



    Private Sub OpenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem1.Click
        FrmQuestion.ShowDialog()

    End Sub
End Class