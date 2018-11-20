<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.cbxUsers = New System.Windows.Forms.ComboBox()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.msUserAction = New System.Windows.Forms.MenuStrip()
        Me.NewUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.msUserAction.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.AllowUserToDeleteRows = False
        Me.dgvData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(7, 99)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.Size = New System.Drawing.Size(506, 187)
        Me.dgvData.TabIndex = 0
        '
        'cbxUsers
        '
        Me.cbxUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxUsers.FormattingEnabled = True
        Me.cbxUsers.Location = New System.Drawing.Point(7, 35)
        Me.cbxUsers.Name = "cbxUsers"
        Me.cbxUsers.Size = New System.Drawing.Size(178, 21)
        Me.cbxUsers.TabIndex = 1
        '
        'txtFind
        '
        Me.txtFind.Location = New System.Drawing.Point(7, 62)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(178, 20)
        Me.txtFind.TabIndex = 2
        '
        'cmdFind
        '
        Me.cmdFind.Location = New System.Drawing.Point(191, 62)
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
        Me.msUserAction.Size = New System.Drawing.Size(530, 24)
        Me.msUserAction.TabIndex = 4
        Me.msUserAction.Text = "MenuStrip1"
        '
        'NewUserToolStripMenuItem
        '
        Me.NewUserToolStripMenuItem.Name = "NewUserToolStripMenuItem"
        Me.NewUserToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.NewUserToolStripMenuItem.Text = "New User"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 298)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.txtFind)
        Me.Controls.Add(Me.cbxUsers)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.msUserAction)
        Me.MainMenuStrip = Me.msUserAction
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.msUserAction.ResumeLayout(False)
        Me.msUserAction.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvData As DataGridView
    Friend WithEvents cbxUsers As ComboBox
    Friend WithEvents txtFind As TextBox
    Friend WithEvents cmdFind As Button
    Friend WithEvents msUserAction As MenuStrip
    Friend WithEvents NewUserToolStripMenuItem As ToolStripMenuItem
End Class
