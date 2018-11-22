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
        Me.msUserAction = New System.Windows.Forms.MenuStrip()
        Me.NewUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.cmdDisplay = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdUnitInOrg = New System.Windows.Forms.Button()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.msUserAction.SuspendLayout()
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
        Me.dgvData.Location = New System.Drawing.Point(12, 53)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.Size = New System.Drawing.Size(553, 118)
        Me.dgvData.TabIndex = 0
        '
        'txtFind
        '
        Me.txtFind.Location = New System.Drawing.Point(60, 27)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(178, 20)
        Me.txtFind.TabIndex = 2
        '
        'cmdFind
        '
        Me.cmdFind.Location = New System.Drawing.Point(244, 27)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(75, 20)
        Me.cmdFind.TabIndex = 3
        Me.cmdFind.Text = "Find"
        Me.cmdFind.UseVisualStyleBackColor = True
        '
        'msUserAction
        '
        Me.msUserAction.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewUserToolStripMenuItem})
        Me.msUserAction.Location = New System.Drawing.Point(0, 0)
        Me.msUserAction.Name = "msUserAction"
        Me.msUserAction.Size = New System.Drawing.Size(592, 24)
        Me.msUserAction.TabIndex = 4
        Me.msUserAction.Text = "MenuStrip1"
        '
        'NewUserToolStripMenuItem
        '
        Me.NewUserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateToolStripMenuItem, Me.ChangeToolStripMenuItem, Me.DisplayToolStripMenuItem})
        Me.NewUserToolStripMenuItem.Name = "NewUserToolStripMenuItem"
        Me.NewUserToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.NewUserToolStripMenuItem.Text = "User"
        '
        'CreateToolStripMenuItem
        '
        Me.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem"
        Me.CreateToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.CreateToolStripMenuItem.Text = "Create"
        '
        'ChangeToolStripMenuItem
        '
        Me.ChangeToolStripMenuItem.Name = "ChangeToolStripMenuItem"
        Me.ChangeToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.ChangeToolStripMenuItem.Text = "Change"
        '
        'DisplayToolStripMenuItem
        '
        Me.DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem"
        Me.DisplayToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.DisplayToolStripMenuItem.Text = "Display"
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(13, 30)
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
        Me.grbLogin.Location = New System.Drawing.Point(13, 177)
        Me.grbLogin.Name = "grbLogin"
        Me.grbLogin.Size = New System.Drawing.Size(306, 99)
        Me.grbLogin.TabIndex = 6
        Me.grbLogin.TabStop = False
        Me.grbLogin.Text = "Login Detail"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(85, 69)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(120, 20)
        Me.txtPassword.TabIndex = 8
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'cbxActive
        '
        Me.cbxActive.AutoSize = True
        Me.cbxActive.Location = New System.Drawing.Point(219, 17)
        Me.cbxActive.Name = "cbxActive"
        Me.cbxActive.Size = New System.Drawing.Size(56, 17)
        Me.cbxActive.TabIndex = 7
        Me.cbxActive.Text = "Active"
        Me.cbxActive.UseVisualStyleBackColor = True
        '
        'cmdResetPW
        '
        Me.cmdResetPW.Location = New System.Drawing.Point(219, 69)
        Me.cmdResetPW.Name = "cmdResetPW"
        Me.cmdResetPW.Size = New System.Drawing.Size(55, 23)
        Me.cmdResetPW.TabIndex = 6
        Me.cmdResetPW.Text = "Reset Password"
        Me.cmdResetPW.UseVisualStyleBackColor = True
        '
        'txtUserLogin
        '
        Me.txtUserLogin.Location = New System.Drawing.Point(85, 44)
        Me.txtUserLogin.Name = "txtUserLogin"
        Me.txtUserLogin.Size = New System.Drawing.Size(120, 20)
        Me.txtUserLogin.TabIndex = 4
        '
        'txtUserId
        '
        Me.txtUserId.Location = New System.Drawing.Point(85, 18)
        Me.txtUserId.Name = "txtUserId"
        Me.txtUserId.Size = New System.Drawing.Size(43, 20)
        Me.txtUserId.TabIndex = 3
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(6, 72)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(53, 13)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "Password"
        '
        'lblUserLogin
        '
        Me.lblUserLogin.AutoSize = True
        Me.lblUserLogin.Location = New System.Drawing.Point(6, 47)
        Me.lblUserLogin.Name = "lblUserLogin"
        Me.lblUserLogin.Size = New System.Drawing.Size(58, 13)
        Me.lblUserLogin.TabIndex = 1
        Me.lblUserLogin.Text = "User Login"
        '
        'lblUserId
        '
        Me.lblUserId.AutoSize = True
        Me.lblUserId.Location = New System.Drawing.Point(6, 21)
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
        Me.grbClient.Location = New System.Drawing.Point(325, 177)
        Me.grbClient.Name = "grbClient"
        Me.grbClient.Size = New System.Drawing.Size(240, 99)
        Me.grbClient.TabIndex = 7
        Me.grbClient.TabStop = False
        Me.grbClient.Text = "Client Detail"
        '
        'txtUnitInOrg
        '
        Me.txtUnitInOrg.Location = New System.Drawing.Point(81, 71)
        Me.txtUnitInOrg.Name = "txtUnitInOrg"
        Me.txtUnitInOrg.Size = New System.Drawing.Size(120, 20)
        Me.txtUnitInOrg.TabIndex = 7
        '
        'txtOrganisation
        '
        Me.txtOrganisation.Location = New System.Drawing.Point(81, 45)
        Me.txtOrganisation.Name = "txtOrganisation"
        Me.txtOrganisation.Size = New System.Drawing.Size(120, 20)
        Me.txtOrganisation.TabIndex = 6
        '
        'txtClient
        '
        Me.txtClient.Location = New System.Drawing.Point(81, 19)
        Me.txtClient.Name = "txtClient"
        Me.txtClient.Size = New System.Drawing.Size(120, 20)
        Me.txtClient.TabIndex = 5
        '
        'lblUnitInOrg
        '
        Me.lblUnitInOrg.AutoSize = True
        Me.lblUnitInOrg.Location = New System.Drawing.Point(6, 74)
        Me.lblUnitInOrg.Name = "lblUnitInOrg"
        Me.lblUnitInOrg.Size = New System.Drawing.Size(57, 13)
        Me.lblUnitInOrg.TabIndex = 3
        Me.lblUnitInOrg.Text = "Unit in Org"
        '
        'lblOrganisation
        '
        Me.lblOrganisation.AutoSize = True
        Me.lblOrganisation.Location = New System.Drawing.Point(6, 48)
        Me.lblOrganisation.Name = "lblOrganisation"
        Me.lblOrganisation.Size = New System.Drawing.Size(66, 13)
        Me.lblOrganisation.TabIndex = 2
        Me.lblOrganisation.Text = "Organisation"
        '
        'lblClient
        '
        Me.lblClient.AutoSize = True
        Me.lblClient.Location = New System.Drawing.Point(6, 22)
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
        Me.grbUserDetail.Location = New System.Drawing.Point(13, 280)
        Me.grbUserDetail.Name = "grbUserDetail"
        Me.grbUserDetail.Size = New System.Drawing.Size(306, 185)
        Me.grbUserDetail.TabIndex = 8
        Me.grbUserDetail.TabStop = False
        Me.grbUserDetail.Text = "User Detail"
        '
        'txtMobile
        '
        Me.txtMobile.Location = New System.Drawing.Point(85, 149)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(120, 20)
        Me.txtMobile.TabIndex = 19
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(85, 123)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(215, 20)
        Me.txtEmail.TabIndex = 18
        '
        'txtIdNumber
        '
        Me.txtIdNumber.Location = New System.Drawing.Point(85, 97)
        Me.txtIdNumber.Name = "txtIdNumber"
        Me.txtIdNumber.Size = New System.Drawing.Size(120, 20)
        Me.txtIdNumber.TabIndex = 17
        '
        'lblMobile
        '
        Me.lblMobile.AutoSize = True
        Me.lblMobile.Location = New System.Drawing.Point(6, 152)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(78, 13)
        Me.lblMobile.TabIndex = 16
        Me.lblMobile.Text = "Mobile Number"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(6, 126)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(73, 13)
        Me.lblEmail.TabIndex = 15
        Me.lblEmail.Text = "Email Address"
        '
        'lblIdNumber
        '
        Me.lblIdNumber.AutoSize = True
        Me.lblIdNumber.Location = New System.Drawing.Point(6, 100)
        Me.lblIdNumber.Name = "lblIdNumber"
        Me.lblIdNumber.Size = New System.Drawing.Size(79, 13)
        Me.lblIdNumber.TabIndex = 14
        Me.lblIdNumber.Text = "Id/Passport No"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(85, 71)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(120, 20)
        Me.txtLastName.TabIndex = 13
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Location = New System.Drawing.Point(85, 45)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(120, 20)
        Me.txtMiddleName.TabIndex = 12
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(85, 19)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(120, 20)
        Me.txtFirstName.TabIndex = 11
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(6, 74)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(49, 13)
        Me.lblLastName.TabIndex = 10
        Me.lblLastName.Text = "Surname"
        '
        'lblMiddleName
        '
        Me.lblMiddleName.AutoSize = True
        Me.lblMiddleName.Location = New System.Drawing.Point(6, 48)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(69, 13)
        Me.lblMiddleName.TabIndex = 9
        Me.lblMiddleName.Text = "Middle Name"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(6, 22)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(57, 13)
        Me.lblFirstName.TabIndex = 8
        Me.lblFirstName.Text = "First Name"
        '
        'cmdCreate
        '
        Me.cmdCreate.Location = New System.Drawing.Point(325, 292)
        Me.cmdCreate.Name = "cmdCreate"
        Me.cmdCreate.Size = New System.Drawing.Size(75, 23)
        Me.cmdCreate.TabIndex = 9
        Me.cmdCreate.Text = "Create"
        Me.cmdCreate.UseVisualStyleBackColor = True
        '
        'cmdChange
        '
        Me.cmdChange.Location = New System.Drawing.Point(406, 292)
        Me.cmdChange.Name = "cmdChange"
        Me.cmdChange.Size = New System.Drawing.Size(75, 23)
        Me.cmdChange.TabIndex = 10
        Me.cmdChange.Text = "Change"
        Me.cmdChange.UseVisualStyleBackColor = True
        '
        'cmdDisplay
        '
        Me.cmdDisplay.Location = New System.Drawing.Point(487, 292)
        Me.cmdDisplay.Name = "cmdDisplay"
        Me.cmdDisplay.Size = New System.Drawing.Size(75, 23)
        Me.cmdDisplay.TabIndex = 11
        Me.cmdDisplay.Text = "Display"
        Me.cmdDisplay.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(325, 318)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 12
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdUnitInOrg
        '
        Me.cmdUnitInOrg.Location = New System.Drawing.Point(207, 70)
        Me.cmdUnitInOrg.Name = "cmdUnitInOrg"
        Me.cmdUnitInOrg.Size = New System.Drawing.Size(27, 22)
        Me.cmdUnitInOrg.TabIndex = 8
        Me.cmdUnitInOrg.Text = "-"
        Me.cmdUnitInOrg.UseVisualStyleBackColor = True
        '
        'FrmUserMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 481)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdDisplay)
        Me.Controls.Add(Me.cmdChange)
        Me.Controls.Add(Me.cmdCreate)
        Me.Controls.Add(Me.grbUserDetail)
        Me.Controls.Add(Me.grbClient)
        Me.Controls.Add(Me.grbLogin)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.txtFind)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.msUserAction)
        Me.MainMenuStrip = Me.msUserAction
        Me.Name = "FrmUserMaintenance"
        Me.Text = "User Maintenance"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.msUserAction.ResumeLayout(False)
        Me.msUserAction.PerformLayout()
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
    Friend WithEvents msUserAction As MenuStrip
    Friend WithEvents NewUserToolStripMenuItem As ToolStripMenuItem
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
    Friend WithEvents CreateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cbxActive As CheckBox
    Friend WithEvents cmdCreate As Button
    Friend WithEvents cmdChange As Button
    Friend WithEvents cmdDisplay As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents cmdSave As Button
    Friend WithEvents cmdUnitInOrg As Button
End Class
