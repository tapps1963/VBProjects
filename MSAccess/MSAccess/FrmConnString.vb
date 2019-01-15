Imports System.Windows.Forms
Imports System.IO

Public Class FrmConnString

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK

        My.Settings.myDB = txtAccessDB.Text
        My.Settings.Save()

        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub



    Private Sub FrmConnString_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtConnString.Text = My.Settings.myConn
        txtAccessDB.Text = My.Settings.myDB


    End Sub

    Private Sub cmdFindDB_Click(sender As Object, e As EventArgs) Handles cmdFindDB.Click

        OpFilelDialog.Title = "Please select a DB file"
        OpFilelDialog.InitialDirectory = "C:\"
        OpFilelDialog.Filter = "DB Files|*.accdb"
        OpFilelDialog.FileName = ""

        If OpFilelDialog.ShowDialog() = DialogResult.OK Then
            'Do things here, the path is stored in openFileDialog1.Filename
            'If no files were selected, openFileDialog1.Filename is ""  
            If OpFilelDialog.FileName = "" Then
                Exit Sub
            Else
                txtAccessDB.Text = OpFilelDialog.FileName
            End If
        End If
    End Sub
End Class
