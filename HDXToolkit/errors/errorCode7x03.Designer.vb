<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class errorCode7x03
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
        Me.divider = New System.Windows.Forms.GroupBox()
        Me.okBtn = New System.Windows.Forms.Button()
        Me.errorDetailLabel = New System.Windows.Forms.Label()
        Me.errorCodeLabel = New System.Windows.Forms.Label()
        Me.divider.SuspendLayout()
        Me.SuspendLayout()
        '
        'divider
        '
        Me.divider.Controls.Add(Me.okBtn)
        Me.divider.Location = New System.Drawing.Point(-1, 84)
        Me.divider.Name = "divider"
        Me.divider.Size = New System.Drawing.Size(424, 112)
        Me.divider.TabIndex = 12
        Me.divider.TabStop = False
        '
        'okBtn
        '
        Me.okBtn.Location = New System.Drawing.Point(301, 19)
        Me.okBtn.Name = "okBtn"
        Me.okBtn.Size = New System.Drawing.Size(85, 30)
        Me.okBtn.TabIndex = 4
        Me.okBtn.Text = "OK"
        Me.okBtn.UseVisualStyleBackColor = True
        '
        'errorDetailLabel
        '
        Me.errorDetailLabel.AutoSize = True
        Me.errorDetailLabel.Location = New System.Drawing.Point(22, 48)
        Me.errorDetailLabel.Name = "errorDetailLabel"
        Me.errorDetailLabel.Size = New System.Drawing.Size(338, 26)
        Me.errorDetailLabel.TabIndex = 11
        Me.errorDetailLabel.Text = "Failed installing Safestrap. It may already exist or you disconnected the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "device" & _
    " whilst the process was running."
        '
        'errorCodeLabel
        '
        Me.errorCodeLabel.AutoSize = True
        Me.errorCodeLabel.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errorCodeLabel.Location = New System.Drawing.Point(20, 17)
        Me.errorCodeLabel.Name = "errorCodeLabel"
        Me.errorCodeLabel.Size = New System.Drawing.Size(102, 26)
        Me.errorCodeLabel.TabIndex = 10
        Me.errorCodeLabel.Text = "Error 7×03"
        '
        'errorCode7x03
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 146)
        Me.Controls.Add(Me.divider)
        Me.Controls.Add(Me.errorDetailLabel)
        Me.Controls.Add(Me.errorCodeLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "errorCode7x03"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.divider.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents divider As System.Windows.Forms.GroupBox
    Friend WithEvents okBtn As System.Windows.Forms.Button
    Friend WithEvents errorDetailLabel As System.Windows.Forms.Label
    Friend WithEvents errorCodeLabel As System.Windows.Forms.Label
End Class
