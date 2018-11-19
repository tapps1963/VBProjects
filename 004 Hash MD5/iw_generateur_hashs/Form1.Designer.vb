<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LB_sha256 = New System.Windows.Forms.Label()
        Me.LB_md5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LB_sha1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtToBeHashed = New System.Windows.Forms.TextBox()
        Me.cmdHasher = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MD5 : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "SHA-256 : "
        '
        'LB_sha256
        '
        Me.LB_sha256.Location = New System.Drawing.Point(74, 124)
        Me.LB_sha256.Name = "LB_sha256"
        Me.LB_sha256.Size = New System.Drawing.Size(245, 35)
        Me.LB_sha256.TabIndex = 2
        Me.LB_sha256.Text = "-"
        '
        'LB_md5
        '
        Me.LB_md5.AutoSize = True
        Me.LB_md5.Location = New System.Drawing.Point(74, 72)
        Me.LB_md5.Name = "LB_md5"
        Me.LB_md5.Size = New System.Drawing.Size(10, 13)
        Me.LB_md5.TabIndex = 3
        Me.LB_md5.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "SHA-1 : "
        '
        'LB_sha1
        '
        Me.LB_sha1.AutoSize = True
        Me.LB_sha1.Location = New System.Drawing.Point(74, 98)
        Me.LB_sha1.Name = "LB_sha1"
        Me.LB_sha1.Size = New System.Drawing.Size(10, 13)
        Me.LB_sha1.TabIndex = 5
        Me.LB_sha1.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(96, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Hash Code Generator"
        '
        'txtToBeHashed
        '
        Me.txtToBeHashed.Location = New System.Drawing.Point(12, 35)
        Me.txtToBeHashed.Name = "txtToBeHashed"
        Me.txtToBeHashed.Size = New System.Drawing.Size(227, 20)
        Me.txtToBeHashed.TabIndex = 8
        '
        'cmdHasher
        '
        Me.cmdHasher.Location = New System.Drawing.Point(247, 33)
        Me.cmdHasher.Name = "cmdHasher"
        Me.cmdHasher.Size = New System.Drawing.Size(75, 23)
        Me.cmdHasher.TabIndex = 9
        Me.cmdHasher.Text = "Hasher"
        Me.cmdHasher.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 167)
        Me.Controls.Add(Me.cmdHasher)
        Me.Controls.Add(Me.txtToBeHashed)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LB_sha1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LB_md5)
        Me.Controls.Add(Me.LB_sha256)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Generate HasHCode"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LB_sha256 As System.Windows.Forms.Label
    Friend WithEvents LB_md5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LB_sha1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtToBeHashed As System.Windows.Forms.TextBox
    Friend WithEvents cmdHasher As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
