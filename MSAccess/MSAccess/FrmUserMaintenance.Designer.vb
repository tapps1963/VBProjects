<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUserMaintenance
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.grbLogin = New System.Windows.Forms.GroupBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.cbxActive = New System.Windows.Forms.CheckBox()
        Me.cmdResetPW = New System.Windows.Forms.Button()
        Me.txtUserLogin = New System.Windows.Forms.TextBox()
        Me.txtUserId = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUserLogin = New System.Windows.Forms.Label()
        Me.lblUserId = New System.Windows.Forms.Label()
        Me.grbClient = New System.Windows.Forms.GroupBox()
        Me.cmdUnitInOrg = New System.Windows.Forms.Button()
        Me.txtUnitInOrg = New System.Windows.Forms.TextBox()
        Me.txtOrganisation = New System.Windows.Forms.TextBox()
        Me.txtClient = New System.Windows.Forms.TextBox()
        Me.lblUnitInOrg = New System.Windows.Forms.Label()
        Me.lblOrganisation = New System.Windows.Forms.Label()
        Me.lblClient = New System.Windows.Forms.Label()
        Me.grbUserDetail = New System.Windows.Forms.GroupBox()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtIdNumber = New System.Windows.Forms.TextBox()
        Me.lblMobile = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblIdNumber = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.cmdCreate = New System.Windows.Forms.Button()
        Me.cmdChange = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbLogin.SuspendLayout()
        Me.grbClient.SuspendLayout()
        Me.grbUserDetail.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.AllowUserToDeleteRows = False
        Me.dgvData.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(6, 33)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.Size = New System.Drawing.Size(635, 118)
        Me.dgvData.TabIndex = 0
        '
        'txtFind
        '
        Me.txtFind.Location = New System.Drawing.Point(54, 7)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(178, 20)
        Me.txtFind.TabIndex = 2
        '
        'cmdFind
        '
        Me.cmdFind.Location = New System.Drawing.Point(238, 7)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(75, 20)
        Me.cmdFind.TabIndex = 3
        Me.cmdFind.Text = "Find"
        Me.cmdFind.UseVisualStyleBackColor = True
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(7, 10)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(41, 13)
        Me.lblSearch.TabIndex = 5
        Me.lblSearch.Text = "Search"
        '
        'grbLogin
        '
        Me.grbLogin.Controls.Add(Me.txtPassword)
        Me.grbLogin.Controls.Add(Me.cbxActive)
        Me.grbLogin.Controls.Add(Me.cmdResetPW)
        Me.grbLogin.Controls.Add(Me.txtUserLogin)
        Me.grbLogin.Controls.Add(Me.txtUserId)
        Me.grbLogin.Controls.Add(Me.lblPassword)
        Me.grbLogin.Controls.Add(Me.lblUserLogin)
        Me.grbLogin.Controls.Add(Me.lblUserId)
        Me.grbLogin.Location = New System.Drawing.Point(7, 157)
        Me.grbLogin.Name = "grbLogin"
        Me.grbLogin.Size = New System.Drawing.Size(306, 99)
        Me.grbLogin.TabIndex = 6
        Me.grbLogin.TabStop = False
        Me.grbLogin.Text = "Login Detail"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(85, 72)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(120, 20)
        Me.txtPassword.TabIndex = 8
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'cbxActive
        '
        Me.cbxActive.AutoSize = True
        Me.cbxActive.Location = New System.Drawing.Point(219, 24)
        Me.cbxActive.Name = "cbxActive"
        Me.cbxActive.Size = New System.Drawing.Size(56, 17)
        Me.cbxActive.TabIndex = 7
        Me.cbxActive.Text = "Active"
        Me.cbxActive.UseVisualStyleBackColor = True
        '
        'cmdResetPW
        '
        Me.cmdResetPW.Location = New System.Drawing.Point(219, 71)
        Me.cmdResetPW.Name = "cmdResetPW"
        Me.cmdResetPW.Size = New System.Drawing.Size(55, 23)
        Me.cmdResetPW.TabIndex = 6
        Me.cmdResetPW.Text = "Reset Password"
        Me.cmdResetPW.UseVisualStyleBackColor = True
        '
        'txtUserLogin
        '
        Me.txtUserLogin.Location = New System.Drawing.Point(85, 47)
        Me.txtUserLogin.Name = "txtUserLogin"
        Me.txtUserLogin.Size = New System.Drawing.Size(120, 20)
        Me.txtUserLogin.TabIndex = 4
        '
        'txtUserId
        '
        Me.txtUserId.Location = New System.Drawing.Point(85, 22)
        Me.txtUserId.Name = "txtUserId"
        Me.txtUserId.ReadOnly = True
        Me.txtUserId.Size = New System.Drawing.Size(38, 20)
        Me.txtUserId.TabIndex = 3
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(6, 76)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(53, 13)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "Password"
        '
        'lblUserLogin
        '
        Me.lblUserLogin.AutoSize = True
        Me.lblUserLogin.Location = New System.Drawing.Point(6, 51)
        Me.lblUserLogin.Name = "lblUserLogin"
        Me.lblUserLogin.Size = New System.Drawing.Size(58, 13)
        Me.lblUserLogin.TabIndex = 1
        Me.lblUserLogin.Text = "User Login"
        '
        'lblUserId
        '
        Me.lblUserId.AutoSize = True
        Me.lblUserId.Location = New System.Drawing.Point(6, 26)
        Me.lblUserId.Name = "lblUserId"
        Me.lblUserId.Size = New System.Drawing.Size(41, 13)
        Me.lblUserId.TabIndex = 0
        Me.lblUserId.Text = "User Id"
        '
        'grbClient
        '
        Me.grbClient.Controls.Add(Me.cmdUnitInOrg)
        Me.grbClient.Controls.Add(Me.txtUnitInOrg)
        Me.grbClient.Controls.Add(Me.txtOrganisation)
        Me.grbClient.Controls.Add(Me.txtClient)
        Me.grbClient.Controls.Add(Me.lblUnitInOrg)
        Me.grbClient.Controls.Add(Me.lblOrganisation)
        Me.grbClient.Controls.Add(Me.lblClient)
        Me.grbClient.Location = New System.Drawing.Point(319, 157)
        Me.grbClient.Name = "grbClient"
        Me.grbClient.Size = New System.Drawing.Size(322, 99)
        Me.grbClient.TabIndex = 7
        Me.grbClient.TabStop = False
        Me.grbClient.Text = "Client Detail"
        '
        'cmdUnitInOrg
        '
        Me.cmdUnitInOrg.Location = New System.Drawing.Point(280, 71)
        Me.cmdUnitInOrg.Name = "cmdUnitInOrg"
        Me.cmdUnitInOrg.Size = New System.Drawing.Size(27, 22)
        Me.cmdUnitInOrg.TabIndex = 8
        Me.cmdUnitInOrg.Text = "-"
        Me.cmdUnitInOrg.UseVisualStyleBackColor = True
        '
        'txtUnitInOrg
        '
        Me.txtUnitInOrg.Location = New System.Drawing.Point(81, 72)
        Me.txtUnitInOrg.Name = "txtUnitInOrg"
        Me.txtUnitInOrg.ReadOnly = True
        Me.txtUnitInOrg.Size = New System.Drawing.Size(197, 20)
        Me.txtUnitInOrg.TabIndex = 7
        '
        'txtOrganisation
        '
        Me.txtOrganisation.Location = New System.Drawing.Point(81, 47)
        Me.txtOrganisation.Name = "txtOrganisation"
        Me.txtOrganisation.ReadOnly = True
        Me.txtOrganisation.Size = New System.Drawing.Size(197, 20)
        Me.txtOrganisation.TabIndex = 6
        '
        'txtClient
        '
        Me.txtClient.Location = New System.Drawing.Point(81, 22)
        Me.txtClient.Name = "txtClient"
        Me.txtClient.ReadOnly = True
        Me.txtClient.Size = New System.Drawing.Size(197, 20)
        Me.txtClient.TabIndex = 5
        '
        'lblUnitInOrg
        '
        Me.lblUnitInOrg.AutoSize = True
        Me.lblUnitInOrg.Location = New System.Drawing.Point(6, 76)
        Me.lblUnitInOrg.Name = "lblUnitInOrg"
        Me.lblUnitInOrg.Size = New System.Drawing.Size(57, 13)
        Me.lblUnitInOrg.TabIndex = 3
        Me.lblUnitInOrg.Text = "Unit in Org"
        '
        'lblOrganisation
        '
        Me.lblOrganisation.AutoSize = True
        Me.lblOrganisation.Location = New System.Drawing.Point(6, 51)
        Me.lblOrganisation.Name = "lblOrganisation"
        Me.lblOrganisation.Size = New System.Drawing.Size(66, 13)
        Me.lblOrganisation.TabIndex = 2
        Me.lblOrganisation.Text = "Organisation"
        '
        'lblClient
        '
        Me.lblClient.AutoSize = True
        Me.lblClient.Location = New System.Drawing.Point(6, 26)
        Me.lblClient.Name = "lblClient"
        Me.lblClient.Size = New System.Drawing.Size(33, 13)
        Me.lblClient.TabIndex = 1
        Me.lblClient.Text = "Client"
        '
        'grbUserDetail
        '
        Me.grbUserDetail.Controls.Add(Me.txtMobile)
        Me.grbUserDetail.Controls.Add(Me.txtEmail)
        Me.grbUserDetail.Controls.Add(Me.txtIdNumber)
        Me.grbUserDetail.Controls.Add(Me.lblMobile)
        Me.grbUserDetail.Controls.Add(Me.lblEmail)
        Me.grbUserDetail.Controls.Add(Me.lblIdNumber)
        Me.grbUserDetail.Controls.Add(Me.txtLastName)
        Me.grbUserDetail.Controls.Add(Me.txtMiddleName)
        Me.grbUserDetail.Controls.Add(Me.txtFirstName)
        Me.grbUserDetail.Controls.Add(Me.lblLastName)
        Me.grbUserDetail.Controls.Add(Me.lblMiddleName)
        Me.grbUserDetail.Controls.Add(Me.lblFirstName)
        Me.grbUserDetail.Location = New System.Drawing.Point(7, 260)
        Me.grbUserDetail.Name = "grbUserDetail"
        Me.grbUserDetail.Size = New System.Drawing.Size(306, 185)
        Me.grbUserDetail.TabIndex = 8
        Me.grbUserDetail.TabStop = False
        Me.grbUserDetail.Text = "User Detail"
        '
        'txtMobile
        '
        Me.txtMobile.Location = New System.Drawing.Point(85, 153)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(120, 20)
        Me.txtMobile.TabIndex = 19
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(85, 127)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(215, 20)
        Me.txtEmail.TabIndex = 18
        '
        'txtIdNumber
        '
        Me.txtIdNumber.Location = New System.Drawing.Point(85, 101)
        Me.txtIdNumber.Name = "txtIdNumber"
        Me.txtIdNumber.Size = New System.Drawing.Size(120, 20)
        Me.txtIdNumber.TabIndex = 17
        '
        'lblMobile
        '
        Me.lblMobile.AutoSize = True
        Me.lblMobile.Location = New System.Drawing.Point(6, 156)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(78, 13)
        Me.lblMobile.TabIndex = 16
        Me.lblMobile.Text = "Mobile Number"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(6, 130)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(73, 13)
        Me.lblEmail.TabIndex = 15
        Me.lblEmail.Text = "Email Address"
        '
        'lblIdNumber
        '
        Me.lblIdNumber.AutoSize = True
        Me.lblIdNumber.Location = New System.Drawing.Point(6, 104)
        Me.lblIdNumber.Name = "lblIdNumber"
        Me.lblIdNumber.Size = New System.Drawing.Size(79, 13)
        Me.lblIdNumber.TabIndex = 14
        Me.lblIdNumber.Text = "Id/Passport No"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(85, 75)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(120, 20)
        Me.txtLastName.TabIndex = 13
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Location = New System.Drawing.Point(85, 49)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(120, 20)
        Me.txtMiddleName.TabIndex = 12
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(85, 23)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(120, 20)
        Me.txtFirstName.TabIndex = 11
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(6, 78)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(49, 13)
        Me.lblLastName.TabIndex = 10
        Me.lblLastName.Text = "Surname"
        '
        'lblMiddleName
        '
        Me.lblMiddleName.AutoSize = True
        Me.lblMiddleName.Location = New System.Drawing.Point(6, 52)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(69, 13)
        Me.lblMiddleName.TabIndex = 9
        Me.lblMiddleName.Text = "Middle Name"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(6, 26)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(57, 13)
        Me.lblFirstName.TabIndex = 8
        Me.lblFirstName.Text = "First Name"
        '
        'cmdCreate
        '
        Me.cmdCreate.Location = New System.Drawing.Point(400, 272)
        Me.cmdCreate.Name = "cmdCreate"
        Me.cmdCreate.Size = New System.Drawing.Size(75, 23)
        Me.cmdCreate.TabIndex = 9
        Me.cmdCreate.Text = "Create"
        Me.cmdCreate.UseVisualStyleBackColor = True
        '
        'cmdChange
        '
        Me.cmdChange.Location = New System.Drawing.Point(319, 272)
        Me.cmdChange.Name = "cmdChange"
        Me.cmdChange.Size = New System.Drawing.Size(75, 23)
        Me.cmdChange.TabIndex = 10
        Me.cmdChange.Text = "Change"
        Me.cmdChange.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(481, 272)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 12
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'FrmUserMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 510)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdChange)
        Me.Controls.Add(Me.cmdCreate)
        Me.Controls.Add(Me.grbUserDetail)
        Me.Controls.Add(Me.grbClient)
        Me.Controls.Add(Me.grbLogin)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.txtFind)
        Me.Controls.Add(Me.dgvData)
        Me.Name = "FrmUserMaintenance"
        Me.Text = "User Maintenance"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbLogin.ResumeLayout(False)
        Me.grbLogin.PerformLayout()
        Me.grbClient.ResumeLayout(False)
        Me.grbClient.PerformLayout()
        Me.grbUserDetail.ResumeLayout(False)
        Me.grbUserDetail.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvData As DataGridView
    Friend WithEvents txtFind As TextBox
    Friend WithEvents cmdFind As Button
    Friend WithEvents lblSearch As Label
    Friend WithEvents grbLogin As GroupBox
    Friend WithEvents cmdResetPW As Button
    Friend WithEvents txtUserLogin As TextBox
    Friend WithEvents txtUserId As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUserLogin As Label
    Friend WithEvents lblUserId As Label
    Friend WithEvents grbClient As GroupBox
    Friend WithEvents grbUserDetail As GroupBox
    Friend WithEvents txtUnitInOrg As TextBox
    Friend WithEvents txtOrganisation As TextBox
    Friend WithEvents txtClient As TextBox
    Friend WithEvents lblUnitInOrg As Label
    Friend WithEvents lblOrganisation As Label
    Friend WithEvents lblClient As Label
    Friend WithEvents txtMobile As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtIdNumber As TextBox
    Friend WithEvents lblMobile As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblIdNumber As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblMiddleName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents cbxActive As CheckBox
    Friend WithEvents cmdCreate As Button
    Friend WithEvents cmdChange As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents cmdSave As Button
    Friend WithEvents cmdUnitInOrg As Button
End Class
