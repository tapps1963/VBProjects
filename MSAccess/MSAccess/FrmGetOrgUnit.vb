Imports System.Windows.Forms

Public Class FrmGetOrgUnit
    Private Access As New DBControl
    Private mySql As String
    Private myTest() As String
    Private clientId As Integer
    Private orgId As Integer
    Private unitId As Integer

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK

        FrmUserMaintenance.txtUnitInOrg.Tag = unitId

        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
        FrmUserMaintenance.cmdSave.Visible = False
    End Sub

    Private Sub GetOrgUnit_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        GetClient()

        OK_Button.Enabled = False
    End Sub

    Private Sub GetClient()
        ' Set  SQL String
        mySql = "select * from tbl_client"

        ' Run the Query
        Access.ExecQuery(mySql)

        ' Check if any records exist
        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception)
            Exit Sub
        End If

        ' Clear the Combo Box
        cbxClient.Items.Clear()

        ' Fill the Client Combo Box
        For Each R As DataRow In Access.DBDT.Rows
            cbxClient.Items.Add(R("client_text") & "|" & R("client_id"))
        Next

    End Sub

    Private Sub GetOrganisation()
        ' Set  SQL String
        mySql = "select * from tbl_client_org where client_id = " & clientId

        ' Run the Query
        Access.ExecQuery(mySql)

        ' Check if any records exist
        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception)
            Exit Sub
        End If

        ' Clear the Combo Box
        cbxOrganisation.ResetText()
        'cbxOrganisation.Text = ""
        cbxOrganisation.Items.Clear()

        ' Clear the Combo Box
        cbxUnitInOrg.ResetText()
        'cbxUnitInOrg.Text = ""
        cbxUnitInOrg.Items.Clear()

        ' Fill the Client Combo Box
        For Each R As DataRow In Access.DBDT.Rows
            cbxOrganisation.Items.Add(R("org_text") & "|" & R("org_id"))
        Next
    End Sub

    Private Sub GetUnitInOrg()
        ' Set  SQL String
        mySql = "select * from tbl_client_unit where org_id = " & orgId

        ' Run the Query
        Access.ExecQuery(mySql)

        ' Check if any records exist
        If Not String.IsNullOrEmpty(Access.Exception) Then
            MsgBox(Access.Exception)
            Exit Sub
        End If

        ' Clear the Combo Box
        cbxUnitInOrg.ResetText()
        'cbxUnitInOrg.Text = ""
        cbxUnitInOrg.Items.Clear()

        ' Fill the Client Combo Box
        For Each R As DataRow In Access.DBDT.Rows
            cbxUnitInOrg.Items.Add(R("unit_text") & "|" & R("unit_id"))
        Next
    End Sub

    Private Sub cbxClient_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxClient.SelectedIndexChanged

        myTest = Split(cbxClient.Text, "|")

        FrmUserMaintenance.txtClient.Text = myTest(0)

        clientId = Val(myTest(1))

        GetOrganisation()

        OK_Button.Enabled = False

    End Sub

    Private Sub cbxOrganisation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxOrganisation.SelectedIndexChanged

        myTest = Split(cbxOrganisation.Text, "|")
        FrmUserMaintenance.txtOrganisation.Text = myTest(0)
        orgId = Val(myTest(1))

        GetUnitInOrg()

        OK_Button.Enabled = False

    End Sub

    Private Sub cbxUnitInOrg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxUnitInOrg.SelectedIndexChanged

        myTest = Split(cbxUnitInOrg.Text, "|")
        FrmUserMaintenance.txtUnitInOrg.Text = myTest(0)
        unitId = Val(myTest(1))

        OK_Button.Enabled = True

    End Sub


End Class
