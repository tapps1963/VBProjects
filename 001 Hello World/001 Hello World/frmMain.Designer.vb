<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lblHellowWorld = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblHellowWorld
        '
        Me.lblHellowWorld.AutoSize = True
        Me.lblHellowWorld.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHellowWorld.Location = New System.Drawing.Point(12, 9)
        Me.lblHellowWorld.Name = "lblHellowWorld"
        Me.lblHellowWorld.Size = New System.Drawing.Size(210, 42)
        Me.lblHellowWorld.TabIndex = 0
        Me.lblHellowWorld.Text = "Hello World"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(238, 66)
        Me.Controls.Add(Me.lblHellowWorld)
        Me.Name = "frmMain"
        Me.Text = "Hello World 1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHellowWorld As Label
End Class
