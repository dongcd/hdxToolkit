<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class errorCode0x01
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
        Me.errorCodeLabel = New System.Windows.Forms.Label()
        Me.errorDetailLabel = New System.Windows.Forms.Label()
        Me.divider = New System.Windows.Forms.GroupBox()
        Me.retryBtn = New System.Windows.Forms.Button()
        Me.quitBtn = New System.Windows.Forms.Button()
        Me.divider.SuspendLayout()
        Me.SuspendLayout()
        '
        'errorCodeLabel
        '
        Me.errorCodeLabel.AutoSize = True
        Me.errorCodeLabel.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errorCodeLabel.Location = New System.Drawing.Point(20, 17)
        Me.errorCodeLabel.Name = "errorCodeLabel"
        Me.errorCodeLabel.Size = New System.Drawing.Size(102, 26)
        Me.errorCodeLabel.TabIndex = 1
        Me.errorCodeLabel.Text = "Error 0×01"
        '
        'errorDetailLabel
        '
        Me.errorDetailLabel.AutoSize = True
        Me.errorDetailLabel.Location = New System.Drawing.Point(22, 48)
        Me.errorDetailLabel.Name = "errorDetailLabel"
        Me.errorDetailLabel.Size = New System.Drawing.Size(324, 13)
        Me.errorDetailLabel.TabIndex = 2
        Me.errorDetailLabel.Text = "No device detected. Ensure all related drivers are properly installed." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'divider
        '
        Me.divider.Controls.Add(Me.retryBtn)
        Me.divider.Controls.Add(Me.quitBtn)
        Me.divider.Location = New System.Drawing.Point(-1, 84)
        Me.divider.Name = "divider"
        Me.divider.Size = New System.Drawing.Size(424, 112)
        Me.divider.TabIndex = 3
        Me.divider.TabStop = False
        '
        'retryBtn
        '
        Me.retryBtn.Location = New System.Drawing.Point(301, 19)
        Me.retryBtn.Name = "retryBtn"
        Me.retryBtn.Size = New System.Drawing.Size(85, 30)
        Me.retryBtn.TabIndex = 5
        Me.retryBtn.Text = "Retry"
        Me.retryBtn.UseVisualStyleBackColor = True
        '
        'quitBtn
        '
        Me.quitBtn.Location = New System.Drawing.Point(206, 19)
        Me.quitBtn.Name = "quitBtn"
        Me.quitBtn.Size = New System.Drawing.Size(85, 30)
        Me.quitBtn.TabIndex = 4
        Me.quitBtn.Text = "Quit"
        Me.quitBtn.UseVisualStyleBackColor = True
        '
        'errorCode0x01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 146)
        Me.Controls.Add(Me.divider)
        Me.Controls.Add(Me.errorDetailLabel)
        Me.Controls.Add(Me.errorCodeLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "errorCode0x01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADB status"
        Me.divider.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents errorCodeLabel As System.Windows.Forms.Label
    Friend WithEvents errorDetailLabel As System.Windows.Forms.Label
    Friend WithEvents divider As System.Windows.Forms.GroupBox
    Friend WithEvents retryBtn As System.Windows.Forms.Button
    Friend WithEvents quitBtn As System.Windows.Forms.Button
End Class
