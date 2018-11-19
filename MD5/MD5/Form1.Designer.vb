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
        Me.cmdHash = New System.Windows.Forms.Button()
        Me.txtSample = New System.Windows.Forms.TextBox()
        Me.txtMD5 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdHash
        '
        Me.cmdHash.Location = New System.Drawing.Point(12, 38)
        Me.cmdHash.Name = "cmdHash"
        Me.cmdHash.Size = New System.Drawing.Size(75, 23)
        Me.cmdHash.TabIndex = 0
        Me.cmdHash.Text = "Hash It"
        Me.cmdHash.UseVisualStyleBackColor = True
        '
        'txtSample
        '
        Me.txtSample.Location = New System.Drawing.Point(12, 12)
        Me.txtSample.Name = "txtSample"
        Me.txtSample.Size = New System.Drawing.Size(177, 20)
        Me.txtSample.TabIndex = 1
        '
        'txtMD5
        '
        Me.txtMD5.Location = New System.Drawing.Point(195, 12)
        Me.txtMD5.Name = "txtMD5"
        Me.txtMD5.Size = New System.Drawing.Size(364, 20)
        Me.txtMD5.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 78)
        Me.Controls.Add(Me.txtMD5)
        Me.Controls.Add(Me.txtSample)
        Me.Controls.Add(Me.cmdHash)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdHash As Button
    Friend WithEvents txtSample As TextBox
    Friend WithEvents txtMD5 As TextBox
End Class
