<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class jcaseRootSuccess
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
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.subLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.okBtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.Location = New System.Drawing.Point(20, 17)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(182, 26)
        Me.titleLabel.TabIndex = 13
        Me.titleLabel.Text = "Successfully rooted!"
        '
        'subLabel
        '
        Me.subLabel.AutoSize = True
        Me.subLabel.Location = New System.Drawing.Point(22, 48)
        Me.subLabel.Name = "subLabel"
        Me.subLabel.Size = New System.Drawing.Size(338, 26)
        Me.subLabel.TabIndex = 14
        Me.subLabel.Text = "It is recommended that you now install SuperSU or the like and disable" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "over-the-" & _
    "air updates."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.okBtn)
        Me.GroupBox1.Location = New System.Drawing.Point(-1, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(468, 112)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'okBtn
        '
        Me.okBtn.Location = New System.Drawing.Point(299, 19)
        Me.okBtn.Name = "okBtn"
        Me.okBtn.Size = New System.Drawing.Size(85, 30)
        Me.okBtn.TabIndex = 4
        Me.okBtn.Text = "OK"
        Me.okBtn.UseVisualStyleBackColor = True
        '
        'jcaseRootSuccess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 146)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.subLabel)
        Me.Controls.Add(Me.titleLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "jcaseRootSuccess"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents titleLabel As System.Windows.Forms.Label
    Friend WithEvents subLabel As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents okBtn As System.Windows.Forms.Button
End Class
