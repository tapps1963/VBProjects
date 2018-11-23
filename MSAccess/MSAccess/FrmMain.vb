Public Class FrmMain
    Private FrmUsers As New FrmUserMaintenance

    Private Sub FrmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        FrmUsers.MdiParent = Me
        FrmUsers.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub UserMaintenanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserMaintenanceToolStripMenuItem.Click

        FrmUsers.Show()

    End Sub
End Class