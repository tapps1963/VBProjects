Public Class FrmMain
    'Public FrmUsers As New FrmUserMaintenance
    Private Sub FrmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.WindowState = FormWindowState.Maximized
        FrmUserMaintenance.MdiParent = Me
    End Sub

    Private Sub UserMaintenanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserMaintenanceToolStripMenuItem.Click
        FrmUserMaintenance.Show()
    End Sub

    Private Sub FrmMain_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub
End Class