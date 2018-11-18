<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelloWorld2
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
        Me.cmdHello = New System.Windows.Forms.Button()
        Me.txtHelloWorld = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdHello
        '
        Me.cmdHello.Location = New System.Drawing.Point(19, 34)
        Me.cmdHello.Name = "cmdHello"
        Me.cmdHello.Size = New System.Drawing.Size(107, 34)
        Me.cmdHello.TabIndex = 0
        Me.cmdHello.Text = "Hello"
        Me.cmdHello.UseVisualStyleBackColor = True
        '
        'txtHelloWorld
        '
        Me.txtHelloWorld.Location = New System.Drawing.Point(154, 34)
        Me.txtHelloWorld.Multiline = True
        Me.txtHelloWorld.Name = "txtHelloWorld"
        Me.txtHelloWorld.Size = New System.Drawing.Size(147, 34)
        Me.txtHelloWorld.TabIndex = 1
        '
        'frmHelloWorld2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 93)
        Me.Controls.Add(Me.txtHelloWorld)
        Me.Controls.Add(Me.cmdHello)
        Me.Name = "frmHelloWorld2"
        Me.Text = "Hello World 2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdHello As Button
    Friend WithEvents txtHelloWorld As TextBox
End Class
