<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class superSuSuccess
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
        Me.components = New System.ComponentModel.Container()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.subLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.okBtn = New System.Windows.Forms.Button()
        Me.delayTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.Location = New System.Drawing.Point(20, 17)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(145, 23)
        Me.titleLabel.TabIndex = 0
        Me.titleLabel.Text = "One more thing..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'subLabel
        '
        Me.subLabel.AutoSize = True
        Me.subLabel.Location = New System.Drawing.Point(22, 48)
        Me.subLabel.Name = "subLabel"
        Me.subLabel.Size = New System.Drawing.Size(303, 13)
        Me.subLabel.TabIndex = 1
        Me.subLabel.Text = "To complete installation, update the SU binary when prompted."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.okBtn)
        Me.GroupBox1.Location = New System.Drawing.Point(-1, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(383, 100)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'okBtn
        '
        Me.okBtn.Enabled = False
        Me.okBtn.Location = New System.Drawing.Point(276, 19)
        Me.okBtn.Name = "okBtn"
        Me.okBtn.Size = New System.Drawing.Size(85, 30)
        Me.okBtn.TabIndex = 5
        Me.okBtn.Text = "OK"
        Me.okBtn.UseVisualStyleBackColor = True
        '
        'delayTimer
        '
        '
        'superSuSuccess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 146)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.subLabel)
        Me.Controls.Add(Me.titleLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "superSuSuccess"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SuperSU"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents titleLabel As System.Windows.Forms.Label
    Friend WithEvents subLabel As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents okBtn As System.Windows.Forms.Button
    Friend WithEvents delayTimer As System.Windows.Forms.Timer
End Class
