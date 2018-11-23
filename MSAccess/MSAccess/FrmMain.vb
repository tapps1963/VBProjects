Public Class FrmMain
    'Public FrmUsers As New FrmUserMaintenance

    Private Sub FrmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        FrmUserMaintenance.MdiParent = Me
        FrmUserMaintenance.WindowState = FormWindowState.Maximized
        'FrmUsers.MdiParent = Me
        'FrmUsers.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub UserMaintenanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserMaintenanceToolStripMenuItem.Click

        FrmUserMaintenance.Show()

        'FrmUsers.Show()

    End Sub


End Class