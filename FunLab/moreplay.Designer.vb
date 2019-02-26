<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class moreplay
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
        Me.txtcopy = New System.Windows.Forms.TextBox()
        Me.txtpaste = New System.Windows.Forms.TextBox()
        Me.btncopy = New System.Windows.Forms.Button()
        Me.btnpaste = New System.Windows.Forms.Button()
        Me.btnreturn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtcopy
        '
        Me.txtcopy.Location = New System.Drawing.Point(23, 37)
        Me.txtcopy.Name = "txtcopy"
        Me.txtcopy.Size = New System.Drawing.Size(317, 20)
        Me.txtcopy.TabIndex = 0
        '
        'txtpaste
        '
        Me.txtpaste.Location = New System.Drawing.Point(31, 118)
        Me.txtpaste.Name = "txtpaste"
        Me.txtpaste.Size = New System.Drawing.Size(308, 20)
        Me.txtpaste.TabIndex = 1
        '
        'btncopy
        '
        Me.btncopy.Location = New System.Drawing.Point(381, 38)
        Me.btncopy.Name = "btncopy"
        Me.btncopy.Size = New System.Drawing.Size(139, 63)
        Me.btncopy.TabIndex = 2
        Me.btncopy.Text = "Copy to clipboard"
        Me.btncopy.UseVisualStyleBackColor = True
        '
        'btnpaste
        '
        Me.btnpaste.Location = New System.Drawing.Point(385, 143)
        Me.btnpaste.Name = "btnpaste"
        Me.btnpaste.Size = New System.Drawing.Size(134, 73)
        Me.btnpaste.TabIndex = 3
        Me.btnpaste.Text = "<- Paste from clipboard"
        Me.btnpaste.UseVisualStyleBackColor = True
        '
        'btnreturn
        '
        Me.btnreturn.Location = New System.Drawing.Point(59, 205)
        Me.btnreturn.Name = "btnreturn"
        Me.btnreturn.Size = New System.Drawing.Size(215, 68)
        Me.btnreturn.TabIndex = 4
        Me.btnreturn.Text = "Back to main menu"
        Me.btnreturn.UseVisualStyleBackColor = True
        '
        'moreplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 314)
        Me.Controls.Add(Me.btnreturn)
        Me.Controls.Add(Me.btnpaste)
        Me.Controls.Add(Me.btncopy)
        Me.Controls.Add(Me.txtpaste)
        Me.Controls.Add(Me.txtcopy)
        Me.Name = "moreplay"
        Me.Text = "moreplay by rojeen mulmi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtcopy As System.Windows.Forms.TextBox
    Friend WithEvents txtpaste As System.Windows.Forms.TextBox
    Friend WithEvents btncopy As System.Windows.Forms.Button
    Friend WithEvents btnpaste As System.Windows.Forms.Button
    Friend WithEvents btnreturn As System.Windows.Forms.Button
End Class
