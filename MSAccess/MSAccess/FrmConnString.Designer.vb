<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConnString
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.lblConnString = New System.Windows.Forms.Label()
        Me.txtConnString = New System.Windows.Forms.TextBox()
        Me.txtAccessDB = New System.Windows.Forms.TextBox()
        Me.lblAccessDB = New System.Windows.Forms.Label()
        Me.cmdFindDB = New System.Windows.Forms.Button()
        Me.OpFilelDialog = New System.Windows.Forms.OpenFileDialog()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(267, 98)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'lblConnString
        '
        Me.lblConnString.AutoSize = True
        Me.lblConnString.Location = New System.Drawing.Point(17, 26)
        Me.lblConnString.Name = "lblConnString"
        Me.lblConnString.Size = New System.Drawing.Size(91, 13)
        Me.lblConnString.TabIndex = 1
        Me.lblConnString.Text = "Connection String"
        '
        'txtConnString
        '
        Me.txtConnString.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtConnString.Location = New System.Drawing.Point(114, 23)
        Me.txtConnString.Name = "txtConnString"
        Me.txtConnString.Size = New System.Drawing.Size(298, 20)
        Me.txtConnString.TabIndex = 2
        '
        'txtAccessDB
        '
        Me.txtAccessDB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAccessDB.Location = New System.Drawing.Point(114, 53)
        Me.txtAccessDB.Name = "txtAccessDB"
        Me.txtAccessDB.Size = New System.Drawing.Size(248, 20)
        Me.txtAccessDB.TabIndex = 3
        '
        'lblAccessDB
        '
        Me.lblAccessDB.AutoSize = True
        Me.lblAccessDB.Location = New System.Drawing.Point(17, 56)
        Me.lblAccessDB.Name = "lblAccessDB"
        Me.lblAccessDB.Size = New System.Drawing.Size(91, 13)
        Me.lblAccessDB.TabIndex = 4
        Me.lblAccessDB.Text = "Access Database"
        '
        'cmdFindDB
        '
        Me.cmdFindDB.Location = New System.Drawing.Point(368, 51)
        Me.cmdFindDB.Name = "cmdFindDB"
        Me.cmdFindDB.Size = New System.Drawing.Size(34, 23)
        Me.cmdFindDB.TabIndex = 5
        Me.cmdFindDB.Text = "DB"
        Me.cmdFindDB.UseVisualStyleBackColor = True
        '
        'OpFilelDialog
        '
        Me.OpFilelDialog.FileName = "OpenFileDialog1"
        '
        'FrmConnString
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(425, 139)
        Me.Controls.Add(Me.cmdFindDB)
        Me.Controls.Add(Me.lblAccessDB)
        Me.Controls.Add(Me.txtAccessDB)
        Me.Controls.Add(Me.txtConnString)
        Me.Controls.Add(Me.lblConnString)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConnString"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Setting - Connection String"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents lblConnString As Label
    Friend WithEvents txtConnString As TextBox
    Friend WithEvents txtAccessDB As TextBox
    Friend WithEvents lblAccessDB As Label
    Friend WithEvents cmdFindDB As Button
    Friend WithEvents OpFilelDialog As OpenFileDialog
End Class
