<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUserDetail
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
        Me.grbClientDetail = New System.Windows.Forms.GroupBox()
        Me.lblUnitInOrg = New System.Windows.Forms.Label()
        Me.lblOrganisation = New System.Windows.Forms.Label()
        Me.lblClient = New System.Windows.Forms.Label()
        Me.txtUnitInOrg = New System.Windows.Forms.TextBox()
        Me.txtOrganistation = New System.Windows.Forms.TextBox()
        Me.txtClient = New System.Windows.Forms.TextBox()
        Me.grbLoginDetail = New System.Windows.Forms.GroupBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUserLogin = New System.Windows.Forms.Label()
        Me.lblUserId = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUserLogin = New System.Windows.Forms.TextBox()
        Me.txtUserId = New System.Windows.Forms.TextBox()
        Me.grbUserDetail = New System.Windows.Forms.GroupBox()
        Me.lblMobile = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblIdNo = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtIdNo = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.lsbUsers = New System.Windows.Forms.ListBox()
        Me.btnNewUser = New System.Windows.Forms.Button()
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        Me.btnSaveUser = New System.Windows.Forms.Button()
        Me.dtgUsers = New System.Windows.Forms.DataGridView()
        Me.QuestionBank_20180807_beDataSet1 = New _003_DBConnect.QuestionBank_20180807_beDataSet()
        Me.grbClientDetail.SuspendLayout()
        Me.grbLoginDetail.SuspendLayout()
        Me.grbUserDetail.SuspendLayout()
        CType(Me.dtgUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuestionBank_20180807_beDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbClientDetail
        '
        Me.grbClientDetail.Controls.Add(Me.lblUnitInOrg)
        Me.grbClientDetail.Controls.Add(Me.lblOrganisation)
        Me.grbClientDetail.Controls.Add(Me.lblClient)
        Me.grbClientDetail.Controls.Add(Me.txtUnitInOrg)
        Me.grbClientDetail.Controls.Add(Me.txtOrganistation)
        Me.grbClientDetail.Controls.Add(Me.txtClient)
        Me.grbClientDetail.Location = New System.Drawing.Point(299, 193)
        Me.grbClientDetail.Name = "grbClientDetail"
        Me.grbClientDetail.Size = New System.Drawing.Size(193, 103)
        Me.grbClientDetail.TabIndex = 24
        Me.grbClientDetail.TabStop = False
        Me.grbClientDetail.Text = "Client Detail"
        '
        'lblUnitInOrg
        '
        Me.lblUnitInOrg.AutoSize = True
        Me.lblUnitInOrg.Location = New System.Drawing.Point(6, 75)
        Me.lblUnitInOrg.Name = "lblUnitInOrg"
        Me.lblUnitInOrg.Size = New System.Drawing.Size(57, 13)
        Me.lblUnitInOrg.TabIndex = 29
        Me.lblUnitInOrg.Text = "Unit in Org"
        '
        'lblOrganisation
        '
        Me.lblOrganisation.AutoSize = True
        Me.lblOrganisation.Location = New System.Drawing.Point(6, 49)
        Me.lblOrganisation.Name = "lblOrganisation"
        Me.lblOrganisation.Size = New System.Drawing.Size(66, 13)
        Me.lblOrganisation.TabIndex = 28
        Me.lblOrganisation.Text = "Organisation"
        '
        'lblClient
        '
        Me.lblClient.AutoSize = True
        Me.lblClient.Location = New System.Drawing.Point(6, 23)
        Me.lblClient.Name = "lblClient"
        Me.lblClient.Size = New System.Drawing.Size(33, 13)
        Me.lblClient.TabIndex = 27
        Me.lblClient.Text = "Client"
        '
        'txtUnitInOrg
        '
        Me.txtUnitInOrg.Location = New System.Drawing.Point(84, 71)
        Me.txtUnitInOrg.Name = "txtUnitInOrg"
        Me.txtUnitInOrg.Size = New System.Drawing.Size(100, 20)
        Me.txtUnitInOrg.TabIndex = 26
        '
        'txtOrganistation
        '
        Me.txtOrganistation.Location = New System.Drawing.Point(84, 45)
        Me.txtOrganistation.Name = "txtOrganistation"
        Me.txtOrganistation.Size = New System.Drawing.Size(100, 20)
        Me.txtOrganistation.TabIndex = 25
        '
        'txtClient
        '
        Me.txtClient.Location = New System.Drawing.Point(84, 19)
        Me.txtClient.Name = "txtClient"
        Me.txtClient.Size = New System.Drawing.Size(100, 20)
        Me.txtClient.TabIndex = 24
        '
        'grbLoginDetail
        '
        Me.grbLoginDetail.Controls.Add(Me.lblPassword)
        Me.grbLoginDetail.Controls.Add(Me.lblUserLogin)
        Me.grbLoginDetail.Controls.Add(Me.lblUserId)
        Me.grbLoginDetail.Controls.Add(Me.txtPassword)
        Me.grbLoginDetail.Controls.Add(Me.txtUserLogin)
        Me.grbLoginDetail.Controls.Add(Me.txtUserId)
        Me.grbLoginDetail.Location = New System.Drawing.Point(11, 193)
        Me.grbLoginDetail.Name = "grbLoginDetail"
        Me.grbLoginDetail.Size = New System.Drawing.Size(281, 103)
        Me.grbLoginDetail.TabIndex = 25
        Me.grbLoginDetail.TabStop = False
        Me.grbLoginDetail.Text = "User Login Detail"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(11, 75)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(53, 13)
        Me.lblPassword.TabIndex = 20
        Me.lblPassword.Text = "Password"
        '
        'lblUserLogin
        '
        Me.lblUserLogin.AutoSize = True
        Me.lblUserLogin.Location = New System.Drawing.Point(11, 50)
        Me.lblUserLogin.Name = "lblUserLogin"
        Me.lblUserLogin.Size = New System.Drawing.Size(58, 13)
        Me.lblUserLogin.TabIndex = 19
        Me.lblUserLogin.Text = "User Login"
        '
        'lblUserId
        '
        Me.lblUserId.AutoSize = True
        Me.lblUserId.Location = New System.Drawing.Point(11, 23)
        Me.lblUserId.Name = "lblUserId"
        Me.lblUserId.Size = New System.Drawing.Size(40, 13)
        Me.lblUserId.TabIndex = 18
        Me.lblUserId.Text = "User id"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(88, 71)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(147, 20)
        Me.txtPassword.TabIndex = 17
        '
        'txtUserLogin
        '
        Me.txtUserLogin.Location = New System.Drawing.Point(88, 45)
        Me.txtUserLogin.Name = "txtUserLogin"
        Me.txtUserLogin.Size = New System.Drawing.Size(70, 20)
        Me.txtUserLogin.TabIndex = 16
        '
        'txtUserId
        '
        Me.txtUserId.Location = New System.Drawing.Point(88, 19)
        Me.txtUserId.Name = "txtUserId"
        Me.txtUserId.Size = New System.Drawing.Size(29, 20)
        Me.txtUserId.TabIndex = 15
        '
        'grbUserDetail
        '
        Me.grbUserDetail.Controls.Add(Me.lblMobile)
        Me.grbUserDetail.Controls.Add(Me.lblEmail)
        Me.grbUserDetail.Controls.Add(Me.lblIdNo)
        Me.grbUserDetail.Controls.Add(Me.lblLastName)
        Me.grbUserDetail.Controls.Add(Me.lblMiddleName)
        Me.grbUserDetail.Controls.Add(Me.lblFirstName)
        Me.grbUserDetail.Controls.Add(Me.txtMobile)
        Me.grbUserDetail.Controls.Add(Me.txtEmail)
        Me.grbUserDetail.Controls.Add(Me.txtIdNo)
        Me.grbUserDetail.Controls.Add(Me.txtLastName)
        Me.grbUserDetail.Controls.Add(Me.txtFirstName)
        Me.grbUserDetail.Controls.Add(Me.txtMiddleName)
        Me.grbUserDetail.Location = New System.Drawing.Point(12, 302)
        Me.grbUserDetail.Name = "grbUserDetail"
        Me.grbUserDetail.Size = New System.Drawing.Size(484, 189)
        Me.grbUserDetail.TabIndex = 26
        Me.grbUserDetail.TabStop = False
        Me.grbUserDetail.Text = "User Detail"
        '
        'lblMobile
        '
        Me.lblMobile.AutoSize = True
        Me.lblMobile.Location = New System.Drawing.Point(11, 153)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(55, 13)
        Me.lblMobile.TabIndex = 33
        Me.lblMobile.Text = "Mobile No"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(11, 127)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(73, 13)
        Me.lblEmail.TabIndex = 32
        Me.lblEmail.Text = "Email Address"
        '
        'lblIdNo
        '
        Me.lblIdNo.AutoSize = True
        Me.lblIdNo.Location = New System.Drawing.Point(11, 101)
        Me.lblIdNo.Name = "lblIdNo"
        Me.lblIdNo.Size = New System.Drawing.Size(33, 13)
        Me.lblIdNo.TabIndex = 31
        Me.lblIdNo.Text = "Id No"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(11, 75)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(58, 13)
        Me.lblLastName.TabIndex = 30
        Me.lblLastName.Text = "Last Name"
        '
        'lblMiddleName
        '
        Me.lblMiddleName.AutoSize = True
        Me.lblMiddleName.Location = New System.Drawing.Point(11, 49)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(69, 13)
        Me.lblMiddleName.TabIndex = 29
        Me.lblMiddleName.Text = "Middle Name"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(11, 23)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(57, 13)
        Me.lblFirstName.TabIndex = 28
        Me.lblFirstName.Text = "First Name"
        '
        'txtMobile
        '
        Me.txtMobile.Location = New System.Drawing.Point(87, 149)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(100, 20)
        Me.txtMobile.TabIndex = 27
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(87, 123)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(319, 20)
        Me.txtEmail.TabIndex = 26
        '
        'txtIdNo
        '
        Me.txtIdNo.Location = New System.Drawing.Point(87, 97)
        Me.txtIdNo.Name = "txtIdNo"
        Me.txtIdNo.Size = New System.Drawing.Size(100, 20)
        Me.txtIdNo.TabIndex = 25
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(87, 71)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(128, 20)
        Me.txtLastName.TabIndex = 24
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(87, 19)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(128, 20)
        Me.txtFirstName.TabIndex = 23
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Location = New System.Drawing.Point(87, 45)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(128, 20)
        Me.txtMiddleName.TabIndex = 22
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(417, 496)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 27
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(344, 496)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 28
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(69, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(177, 20)
        Me.txtSearch.TabIndex = 29
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(23, 16)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(41, 13)
        Me.lblSearch.TabIndex = 30
        Me.lblSearch.Text = "Search"
        '
        'lsbUsers
        '
        Me.lsbUsers.FormattingEnabled = True
        Me.lsbUsers.Location = New System.Drawing.Point(11, 151)
        Me.lsbUsers.Name = "lsbUsers"
        Me.lsbUsers.Size = New System.Drawing.Size(480, 30)
        Me.lsbUsers.TabIndex = 31
        '
        'btnNewUser
        '
        Me.btnNewUser.Location = New System.Drawing.Point(252, 11)
        Me.btnNewUser.Name = "btnNewUser"
        Me.btnNewUser.Size = New System.Drawing.Size(75, 23)
        Me.btnNewUser.TabIndex = 32
        Me.btnNewUser.Text = "New User"
        Me.btnNewUser.UseVisualStyleBackColor = True
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.Location = New System.Drawing.Point(327, 11)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteUser.TabIndex = 33
        Me.btnDeleteUser.Text = "Delete User"
        Me.btnDeleteUser.UseVisualStyleBackColor = True
        '
        'btnSaveUser
        '
        Me.btnSaveUser.Location = New System.Drawing.Point(402, 11)
        Me.btnSaveUser.Name = "btnSaveUser"
        Me.btnSaveUser.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveUser.TabIndex = 34
        Me.btnSaveUser.Text = "Save"
        Me.btnSaveUser.UseVisualStyleBackColor = True
        '
        'dtgUsers
        '
        Me.dtgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgUsers.Location = New System.Drawing.Point(11, 40)
        Me.dtgUsers.Name = "dtgUsers"
        Me.dtgUsers.Size = New System.Drawing.Size(480, 105)
        Me.dtgUsers.TabIndex = 35
        '
        'QuestionBank_20180807_beDataSet1
        '
        Me.QuestionBank_20180807_beDataSet1.DataSetName = "QuestionBank_20180807_beDataSet"
        Me.QuestionBank_20180807_beDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FrmUserDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 539)
        Me.Controls.Add(Me.dtgUsers)
        Me.Controls.Add(Me.btnSaveUser)
        Me.Controls.Add(Me.btnDeleteUser)
        Me.Controls.Add(Me.btnNewUser)
        Me.Controls.Add(Me.lsbUsers)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.grbUserDetail)
        Me.Controls.Add(Me.grbLoginDetail)
        Me.Controls.Add(Me.grbClientDetail)
        Me.Name = "FrmUserDetail"
        Me.Text = "User Maintenance"
        Me.grbClientDetail.ResumeLayout(False)
        Me.grbClientDetail.PerformLayout()
        Me.grbLoginDetail.ResumeLayout(False)
        Me.grbLoginDetail.PerformLayout()
        Me.grbUserDetail.ResumeLayout(False)
        Me.grbUserDetail.PerformLayout()
        CType(Me.dtgUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuestionBank_20180807_beDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grbClientDetail As GroupBox
    Friend WithEvents lblUnitInOrg As Label
    Friend WithEvents lblOrganisation As Label
    Friend WithEvents lblClient As Label
    Friend WithEvents txtUnitInOrg As TextBox
    Friend WithEvents txtOrganistation As TextBox
    Friend WithEvents txtClient As TextBox
    Friend WithEvents grbLoginDetail As GroupBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUserLogin As Label
    Friend WithEvents lblUserId As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUserLogin As TextBox
    Friend WithEvents txtUserId As TextBox
    Friend WithEvents grbUserDetail As GroupBox
    Friend WithEvents lblMobile As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblIdNo As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblMiddleName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtMobile As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtIdNo As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents lsbUsers As ListBox
    Friend WithEvents btnNewUser As Button
    Friend WithEvents btnDeleteUser As Button
    Friend WithEvents btnSaveUser As Button
    Friend WithEvents QuestionBank_20180807_beDataSet As QuestionBank_20180807_beDataSet
    Friend WithEvents QryTestTableAdapter As QuestionBank_20180807_beDataSetTableAdapters.qryTestTableAdapter
    Friend WithEvents Tbl_usersTableAdapter As QuestionBank_20180807_beDataSetTableAdapters.tbl_usersTableAdapter
    Friend WithEvents UseridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClientunitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserloginDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MiddlenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailaddrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MobilenoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OfficenoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SecIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents APSERVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SapclientDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaplanguageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SILENTDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents EditquestionDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents CreatedonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreatedbyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ChangedonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ChangedbyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents dtgUsers As DataGridView
    Friend WithEvents QuestionBank_20180807_beDataSet1 As QuestionBank_20180807_beDataSet
End Class
