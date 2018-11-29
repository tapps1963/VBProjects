<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGetOrgUnit
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
        Me.cbxClient = New System.Windows.Forms.ComboBox()
        Me.cbxOrganisation = New System.Windows.Forms.ComboBox()
        Me.cbxUnitInOrg = New System.Windows.Forms.ComboBox()
        Me.lblClient = New System.Windows.Forms.Label()
        Me.lblOrganisation = New System.Windows.Forms.Label()
        Me.lblUnitInOrg = New System.Windows.Forms.Label()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(61, 95)
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
        'cbxClient
        '
        Me.cbxClient.FormattingEnabled = True
        Me.cbxClient.Location = New System.Drawing.Point(84, 12)
        Me.cbxClient.Name = "cbxClient"
        Me.cbxClient.Size = New System.Drawing.Size(121, 21)
        Me.cbxClient.TabIndex = 1
        '
        'cbxOrganisation
        '
        Me.cbxOrganisation.FormattingEnabled = True
        Me.cbxOrganisation.Location = New System.Drawing.Point(84, 39)
        Me.cbxOrganisation.Name = "cbxOrganisation"
        Me.cbxOrganisation.Size = New System.Drawing.Size(121, 21)
        Me.cbxOrganisation.TabIndex = 2
        '
        'cbxUnitInOrg
        '
        Me.cbxUnitInOrg.FormattingEnabled = True
        Me.cbxUnitInOrg.Location = New System.Drawing.Point(84, 66)
        Me.cbxUnitInOrg.Name = "cbxUnitInOrg"
        Me.cbxUnitInOrg.Size = New System.Drawing.Size(121, 21)
        Me.cbxUnitInOrg.TabIndex = 3
        '
        'lblClient
        '
        Me.lblClient.AutoSize = True
        Me.lblClient.Location = New System.Drawing.Point(8, 15)
        Me.lblClient.Name = "lblClient"
        Me.lblClient.Size = New System.Drawing.Size(33, 13)
        Me.lblClient.TabIndex = 4
        Me.lblClient.Text = "Client"
        '
        'lblOrganisation
        '
        Me.lblOrganisation.AutoSize = True
        Me.lblOrganisation.Location = New System.Drawing.Point(8, 42)
        Me.lblOrganisation.Name = "lblOrganisation"
        Me.lblOrganisation.Size = New System.Drawing.Size(66, 13)
        Me.lblOrganisation.TabIndex = 5
        Me.lblOrganisation.Text = "Organisation"
        '
        'lblUnitInOrg
        '
        Me.lblUnitInOrg.AutoSize = True
        Me.lblUnitInOrg.Location = New System.Drawing.Point(8, 69)
        Me.lblUnitInOrg.Name = "lblUnitInOrg"
        Me.lblUnitInOrg.Size = New System.Drawing.Size(57, 13)
        Me.lblUnitInOrg.TabIndex = 6
        Me.lblUnitInOrg.Text = "Unit in Org"
        '
        'FrmGetOrgUnit
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(219, 136)
        Me.Controls.Add(Me.lblUnitInOrg)
        Me.Controls.Add(Me.lblOrganisation)
        Me.Controls.Add(Me.lblClient)
        Me.Controls.Add(Me.cbxUnitInOrg)
        Me.Controls.Add(Me.cbxOrganisation)
        Me.Controls.Add(Me.cbxClient)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmGetOrgUnit"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "GetOrgUnit"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents cbxClient As ComboBox
    Friend WithEvents cbxOrganisation As ComboBox
    Friend WithEvents cbxUnitInOrg As ComboBox
    Friend WithEvents lblClient As Label
    Friend WithEvents lblOrganisation As Label
    Friend WithEvents lblUnitInOrg As Label
End Class
