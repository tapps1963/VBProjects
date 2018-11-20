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
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvData
        '
        Me.dgvData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(12, 70)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.Size = New System.Drawing.Size(450, 165)
        Me.dgvData.TabIndex = 0
        '
        'cbxUsers
        '
        Me.cbxUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxUsers.FormattingEnabled = True
        Me.cbxUsers.Location = New System.Drawing.Point(12, 3)
        Me.cbxUsers.Name = "cbxUsers"
        Me.cbxUsers.Size = New System.Drawing.Size(178, 21)
        Me.cbxUsers.TabIndex = 1
        '
        'txtFind
        '
        Me.txtFind.Location = New System.Drawing.Point(12, 44)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(178, 20)
        Me.txtFind.TabIndex = 2
        '
        'cmdFind
        '
        Me.cmdFind.Location = New System.Drawing.Point(196, 44)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(75, 20)
        Me.cmdFind.TabIndex = 3
        Me.cmdFind.Text = "Find"
        Me.cmdFind.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 247)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.txtFind)
        Me.Controls.Add(Me.cbxUsers)
        Me.Controls.Add(Me.dgvData)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvData As DataGridView
    Friend WithEvents cbxUsers As ComboBox
    Friend WithEvents txtFind As TextBox
    Friend WithEvents cmdFind As Button
End Class
