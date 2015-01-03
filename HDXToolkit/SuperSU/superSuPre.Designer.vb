<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class superSuPre
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
        Me.continueBtn = New System.Windows.Forms.Button()
        Me.instructionsLabel = New System.Windows.Forms.Label()
        Me.divider.SuspendLayout()
        Me.SuspendLayout()
        '
        'divider
        '
        Me.divider.Controls.Add(Me.closeBtn)
        Me.divider.Controls.Add(Me.continueBtn)
        Me.divider.Location = New System.Drawing.Point(-1, 63)
        Me.divider.Name = "divider"
        Me.divider.Size = New System.Drawing.Size(446, 112)
        Me.divider.TabIndex = 10
        Me.divider.TabStop = False
        '
        'closeBtn
        '
        Me.closeBtn.Location = New System.Drawing.Point(237, 20)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(85, 30)
        Me.closeBtn.TabIndex = 5
        Me.closeBtn.Text = "Close"
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'continueBtn
        '
        Me.continueBtn.Location = New System.Drawing.Point(331, 20)
        Me.continueBtn.Name = "continueBtn"
        Me.continueBtn.Size = New System.Drawing.Size(85, 30)
        Me.continueBtn.TabIndex = 4
        Me.continueBtn.Text = "Continue"
        Me.continueBtn.UseVisualStyleBackColor = True
        '
        'instructionsLabel
        '
        Me.instructionsLabel.AutoSize = True
        Me.instructionsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.instructionsLabel.Location = New System.Drawing.Point(21, 20)
        Me.instructionsLabel.Name = "instructionsLabel"
        Me.instructionsLabel.Size = New System.Drawing.Size(384, 26)
        Me.instructionsLabel.TabIndex = 9
        Me.instructionsLabel.Text = "Prior to running this, please allow installation of outside applications by going" & _
    " into" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Settings → ""Applications"" menu → enable ""Apps from Unkown Sources"""
        '
        'superSuPre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 125)
        Me.Controls.Add(Me.divider)
        Me.Controls.Add(Me.instructionsLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "superSuPre"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SuperSU"
        Me.divider.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents divider As System.Windows.Forms.GroupBox
    Friend WithEvents closeBtn As System.Windows.Forms.Button
    Friend WithEvents continueBtn As System.Windows.Forms.Button
    Friend WithEvents instructionsLabel As System.Windows.Forms.Label
End Class
