<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class enableOta
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
        Me.enable = New System.ComponentModel.BackgroundWorker()
        Me.statusLabel = New System.Windows.Forms.Label()
        Me.updateDeviceList = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'enable
        '
        '
        'statusLabel
        '
        Me.statusLabel.AutoSize = True
        Me.statusLabel.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusLabel.Location = New System.Drawing.Point(69, 17)
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(102, 26)
        Me.statusLabel.TabIndex = 4
        Me.statusLabel.Text = "Enabling..."
        Me.statusLabel.UseWaitCursor = True
        '
        'updateDeviceList
        '
        '
        'enableOta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(244, 61)
        Me.ControlBox = False
        Me.Controls.Add(Me.statusLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "enableOta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OTA updates"
        Me.UseWaitCursor = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents enable As System.ComponentModel.BackgroundWorker
    Friend WithEvents statusLabel As System.Windows.Forms.Label
    Friend WithEvents updateDeviceList As System.ComponentModel.BackgroundWorker
End Class
