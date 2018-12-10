<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQuestion
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSetting = New System.Windows.Forms.TextBox()
        Me.cmdGet = New System.Windows.Forms.Button()
        Me.cmdSet = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Setting"
        '
        'txtSetting
        '
        Me.txtSetting.Location = New System.Drawing.Point(69, 21)
        Me.txtSetting.Name = "txtSetting"
        Me.txtSetting.Size = New System.Drawing.Size(151, 20)
        Me.txtSetting.TabIndex = 1
        '
        'cmdGet
        '
        Me.cmdGet.Location = New System.Drawing.Point(226, 12)
        Me.cmdGet.Name = "cmdGet"
        Me.cmdGet.Size = New System.Drawing.Size(75, 23)
        Me.cmdGet.TabIndex = 2
        Me.cmdGet.Text = "Get"
        Me.cmdGet.UseVisualStyleBackColor = True
        '
        'cmdSet
        '
        Me.cmdSet.Location = New System.Drawing.Point(226, 41)
        Me.cmdSet.Name = "cmdSet"
        Me.cmdSet.Size = New System.Drawing.Size(75, 23)
        Me.cmdSet.TabIndex = 3
        Me.cmdSet.Text = "Set"
        Me.cmdSet.UseVisualStyleBackColor = True
        '
        'FrmQuestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmdSet)
        Me.Controls.Add(Me.cmdGet)
        Me.Controls.Add(Me.txtSetting)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmQuestion"
        Me.Text = "FrmQuestion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtSetting As TextBox
    Friend WithEvents cmdGet As Button
    Friend WithEvents cmdSet As Button

    Private Sub cmdSet_Click(sender As Object, e As EventArgs) Handles cmdSet.Click

        My.Settings.Save()
    End Sub

    Private Sub cmdGet_Click(sender As Object, e As EventArgs) Handles cmdGet.Click


    End Sub
End Class
