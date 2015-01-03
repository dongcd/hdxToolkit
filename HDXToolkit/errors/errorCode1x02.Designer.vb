<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class errorCode1x02
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
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.errorDetailLabel = New System.Windows.Forms.Label()
        Me.errorCodeLabel = New System.Windows.Forms.Label()
        Me.divider.SuspendLayout()
        Me.SuspendLayout()
        '
        'divider
        '
        Me.divider.Controls.Add(Me.closeBtn)
        Me.divider.Location = New System.Drawing.Point(-1, 84)
        Me.divider.Name = "divider"
        Me.divider.Size = New System.Drawing.Size(424, 112)
        Me.divider.TabIndex = 12
        Me.divider.TabStop = False
        '
        'closeBtn
        '
        Me.closeBtn.Location = New System.Drawing.Point(301, 19)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(85, 30)
        Me.closeBtn.TabIndex = 5
        Me.closeBtn.Text = "Close"
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'errorDetailLabel
        '
        Me.errorDetailLabel.AutoSize = True
        Me.errorDetailLabel.Location = New System.Drawing.Point(22, 48)
        Me.errorDetailLabel.Name = "errorDetailLabel"
        Me.errorDetailLabel.Size = New System.Drawing.Size(236, 13)
        Me.errorDetailLabel.TabIndex = 11
        Me.errorDetailLabel.Text = "It appears your device already has root access..."
        '
        'errorCodeLabel
        '
        Me.errorCodeLabel.AutoSize = True
        Me.errorCodeLabel.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errorCodeLabel.Location = New System.Drawing.Point(20, 17)
        Me.errorCodeLabel.Name = "errorCodeLabel"
        Me.errorCodeLabel.Size = New System.Drawing.Size(102, 26)
        Me.errorCodeLabel.TabIndex = 10
        Me.errorCodeLabel.Text = "Error 1×02"
        '
        'errorCode1x02
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 146)
        Me.Controls.Add(Me.divider)
        Me.Controls.Add(Me.errorDetailLabel)
        Me.Controls.Add(Me.errorCodeLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "errorCode1x02"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.divider.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents divider As System.Windows.Forms.GroupBox
    Friend WithEvents closeBtn As System.Windows.Forms.Button
    Friend WithEvents errorDetailLabel As System.Windows.Forms.Label
    Friend WithEvents errorCodeLabel As System.Windows.Forms.Label
End Class
