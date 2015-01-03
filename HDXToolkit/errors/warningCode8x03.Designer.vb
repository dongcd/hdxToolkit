<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class warningCode8x03
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
        Me.warningDetailLabel = New System.Windows.Forms.Label()
        Me.warningCodeLabel = New System.Windows.Forms.Label()
        Me.divider = New System.Windows.Forms.GroupBox()
        Me.abortBtn = New System.Windows.Forms.Button()
        Me.ignoreBtn = New System.Windows.Forms.Button()
        Me.retryBtn = New System.Windows.Forms.Button()
        Me.divider.SuspendLayout()
        Me.SuspendLayout()
        '
        'warningDetailLabel
        '
        Me.warningDetailLabel.AutoSize = True
        Me.warningDetailLabel.Location = New System.Drawing.Point(22, 48)
        Me.warningDetailLabel.Name = "warningDetailLabel"
        Me.warningDetailLabel.Size = New System.Drawing.Size(269, 13)
        Me.warningDetailLabel.TabIndex = 14
        Me.warningDetailLabel.Text = "Failed installing Xposed Framework; it may already exist."
        '
        'warningCodeLabel
        '
        Me.warningCodeLabel.AutoSize = True
        Me.warningCodeLabel.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.warningCodeLabel.Location = New System.Drawing.Point(20, 17)
        Me.warningCodeLabel.Name = "warningCodeLabel"
        Me.warningCodeLabel.Size = New System.Drawing.Size(134, 26)
        Me.warningCodeLabel.TabIndex = 13
        Me.warningCodeLabel.Text = "Warning 8×03"
        '
        'divider
        '
        Me.divider.Controls.Add(Me.abortBtn)
        Me.divider.Controls.Add(Me.ignoreBtn)
        Me.divider.Controls.Add(Me.retryBtn)
        Me.divider.Location = New System.Drawing.Point(-1, 84)
        Me.divider.Name = "divider"
        Me.divider.Size = New System.Drawing.Size(424, 112)
        Me.divider.TabIndex = 19
        Me.divider.TabStop = False
        '
        'abortBtn
        '
        Me.abortBtn.Location = New System.Drawing.Point(111, 19)
        Me.abortBtn.Name = "abortBtn"
        Me.abortBtn.Size = New System.Drawing.Size(85, 30)
        Me.abortBtn.TabIndex = 6
        Me.abortBtn.Text = "Abort"
        Me.abortBtn.UseVisualStyleBackColor = True
        '
        'ignoreBtn
        '
        Me.ignoreBtn.Location = New System.Drawing.Point(301, 19)
        Me.ignoreBtn.Name = "ignoreBtn"
        Me.ignoreBtn.Size = New System.Drawing.Size(85, 30)
        Me.ignoreBtn.TabIndex = 5
        Me.ignoreBtn.Text = "Ignore"
        Me.ignoreBtn.UseVisualStyleBackColor = True
        '
        'retryBtn
        '
        Me.retryBtn.Location = New System.Drawing.Point(206, 19)
        Me.retryBtn.Name = "retryBtn"
        Me.retryBtn.Size = New System.Drawing.Size(85, 30)
        Me.retryBtn.TabIndex = 4
        Me.retryBtn.Text = "Retry"
        Me.retryBtn.UseVisualStyleBackColor = True
        '
        'warningCode8x03
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 146)
        Me.Controls.Add(Me.divider)
        Me.Controls.Add(Me.warningDetailLabel)
        Me.Controls.Add(Me.warningCodeLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "warningCode8x03"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.divider.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents warningDetailLabel As System.Windows.Forms.Label
    Friend WithEvents warningCodeLabel As System.Windows.Forms.Label
    Friend WithEvents divider As System.Windows.Forms.GroupBox
    Friend WithEvents abortBtn As System.Windows.Forms.Button
    Friend WithEvents ignoreBtn As System.Windows.Forms.Button
    Friend WithEvents retryBtn As System.Windows.Forms.Button
End Class
