﻿Imports System.Data.OleDb

Public Class Form1


    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'QBDataSet.tbl_users' table. You can move, or remove it, as needed.
        'Me.Tbl_usersTableAdapter.Fill(Me.QBDataSet.tbl_users)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ' Going to try to connect to my Access

        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Shayne.Tappan\Dropbox\Shayne Tappan\MyDevelopments\Access DB\Question Bank\QuestionBank 20180807_be.accdb")
        Dim cmd As OleDbCommand
        Dim var1 As String
        Dim ds As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        Dim mySql As String

        mySql = "select * from tbl_users where user_id = 33"

        da = New OleDb.OleDbDataAdapter(mySql, con)

        da.Fill(ds, "tbl_users")

        'TextBox1.Text = ds.Tables("tbl_users").Rows(0).Item(4)
        con.Close()

    End Sub

    Private Sub UserMaintenanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserMaintenanceToolStripMenuItem.Click
        FrmUserDetail.Show()
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim frmUser As New FrmUserDetail
        frmUser.MdiParent = Me
        frmUser.Show()
    End Sub
End Class
