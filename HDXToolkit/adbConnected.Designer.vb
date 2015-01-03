<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adbConnected
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
        Me.statusLabel = New System.Windows.Forms.Label()
        Me.delayTimer = New System.Windows.Forms.Timer(Me.components)
        Me.subLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'statusLabel
        '
        Me.statusLabel.AutoSize = True
        Me.statusLabel.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusLabel.Location = New System.Drawing.Point(65, 20)
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(110, 26)
        Me.statusLabel.TabIndex = 1
        Me.statusLabel.Text = "Connected!"
        '
        'delayTimer
        '
        Me.delayTimer.Interval = 3000
        '
        'subLabel
        '
        Me.subLabel.AutoSize = True
        Me.subLabel.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.subLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.subLabel.Location = New System.Drawing.Point(60, 50)
        Me.subLabel.Name = "subLabel"
        Me.subLabel.Size = New System.Drawing.Size(132, 17)
        Me.subLabel.TabIndex = 2
        Me.subLabel.Text = "Loading HDX Toolkit..."
        Me.subLabel.UseWaitCursor = True
        '
        'adbConnected
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(244, 90)
        Me.Controls.Add(Me.subLabel)
        Me.Controls.Add(Me.statusLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "adbConnected"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADB status"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents statusLabel As System.Windows.Forms.Label
    Friend WithEvents delayTimer As System.Windows.Forms.Timer
    Friend WithEvents subLabel As System.Windows.Forms.Label
End Class
