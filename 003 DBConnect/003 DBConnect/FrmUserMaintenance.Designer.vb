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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'FrmUserMaintenance
        '
        Me.ClientSize = New System.Drawing.Size(770, 358)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmUserMaintenance"
        Me.Text = "User Maintenance"
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
    Friend WithEvents Label1 As Label
End Class
