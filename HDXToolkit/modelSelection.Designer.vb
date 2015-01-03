<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modelSelection
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
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.deviceLabel = New System.Windows.Forms.Label()
        Me.firmwareLabel = New System.Windows.Forms.Label()
        Me.deviceCombo = New System.Windows.Forms.ComboBox()
        Me.osVersionCombo = New System.Windows.Forms.ComboBox()
        Me.instructionsLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'saveBtn
        '
        Me.saveBtn.Enabled = False
        Me.saveBtn.Location = New System.Drawing.Point(21, 140)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(284, 34)
        Me.saveBtn.TabIndex = 0
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'deviceLabel
        '
        Me.deviceLabel.AutoSize = True
        Me.deviceLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deviceLabel.Location = New System.Drawing.Point(17, 20)
        Me.deviceLabel.Name = "deviceLabel"
        Me.deviceLabel.Size = New System.Drawing.Size(53, 19)
        Me.deviceLabel.TabIndex = 2
        Me.deviceLabel.Text = "Device"
        '
        'firmwareLabel
        '
        Me.firmwareLabel.AutoSize = True
        Me.firmwareLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Italic)
        Me.firmwareLabel.Location = New System.Drawing.Point(17, 78)
        Me.firmwareLabel.Name = "firmwareLabel"
        Me.firmwareLabel.Size = New System.Drawing.Size(120, 19)
        Me.firmwareLabel.TabIndex = 3
        Me.firmwareLabel.Text = "Firmware version"
        '
        'deviceCombo
        '
        Me.deviceCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.deviceCombo.FormattingEnabled = True
        Me.deviceCombo.Items.AddRange(New Object() {"Kindle Fire HDX 7", "Kindle Fire HDX 8.9"})
        Me.deviceCombo.Location = New System.Drawing.Point(20, 42)
        Me.deviceCombo.Name = "deviceCombo"
        Me.deviceCombo.Size = New System.Drawing.Size(284, 21)
        Me.deviceCombo.TabIndex = 4
        '
        'osVersionCombo
        '
        Me.osVersionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.osVersionCombo.FormattingEnabled = True
        Me.osVersionCombo.Location = New System.Drawing.Point(20, 102)
        Me.osVersionCombo.Name = "osVersionCombo"
        Me.osVersionCombo.Size = New System.Drawing.Size(284, 21)
        Me.osVersionCombo.TabIndex = 5
        '
        'instructionsLabel
        '
        Me.instructionsLabel.AutoSize = True
        Me.instructionsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.instructionsLabel.Location = New System.Drawing.Point(12, 13)
        Me.instructionsLabel.Name = "instructionsLabel"
        Me.instructionsLabel.Size = New System.Drawing.Size(291, 26)
        Me.instructionsLabel.TabIndex = 6
        Me.instructionsLabel.Text = "You can locate your current FireOS build number by going to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Settings → ""Device"" " & _
    "menu → ""System Updates"""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.deviceLabel)
        Me.GroupBox1.Controls.Add(Me.osVersionCombo)
        Me.GroupBox1.Controls.Add(Me.saveBtn)
        Me.GroupBox1.Controls.Add(Me.firmwareLabel)
        Me.GroupBox1.Controls.Add(Me.deviceCombo)
        Me.GroupBox1.Location = New System.Drawing.Point(-5, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(381, 237)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'modelSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(318, 242)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.instructionsLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "modelSelection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Model selection"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents saveBtn As System.Windows.Forms.Button
    Friend WithEvents deviceLabel As System.Windows.Forms.Label
    Friend WithEvents firmwareLabel As System.Windows.Forms.Label
    Friend WithEvents osVersionCombo As System.Windows.Forms.ComboBox
    Friend WithEvents instructionsLabel As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents deviceCombo As System.Windows.Forms.ComboBox

End Class
