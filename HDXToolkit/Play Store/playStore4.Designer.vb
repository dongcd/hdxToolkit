﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class playStore4
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
        Me.stepLabel = New System.Windows.Forms.Label()
        Me.statusLabel = New System.Windows.Forms.Label()
        Me.delayTimer = New System.Windows.Forms.Timer(Me.components)
        Me.installPlayStoreApk = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'stepLabel
        '
        Me.stepLabel.AutoSize = True
        Me.stepLabel.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.stepLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.stepLabel.Location = New System.Drawing.Point(80, 50)
        Me.stepLabel.Name = "stepLabel"
        Me.stepLabel.Size = New System.Drawing.Size(89, 17)
        Me.stepLabel.TabIndex = 10
        Me.stepLabel.Text = "Step 4 out of 4"
        Me.stepLabel.UseWaitCursor = True
        '
        'statusLabel
        '
        Me.statusLabel.AutoSize = True
        Me.statusLabel.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusLabel.Location = New System.Drawing.Point(30, 20)
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(197, 26)
        Me.statusLabel.TabIndex = 9
        Me.statusLabel.Text = "Installing Play Store..."
        Me.statusLabel.UseWaitCursor = True
        '
        'delayTimer
        '
        Me.delayTimer.Interval = 1500
        '
        'installPlayStoreApk
        '
        '
        'playStore4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(256, 91)
        Me.ControlBox = False
        Me.Controls.Add(Me.stepLabel)
        Me.Controls.Add(Me.statusLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "playStore4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.UseWaitCursor = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents stepLabel As System.Windows.Forms.Label
    Friend WithEvents statusLabel As System.Windows.Forms.Label
    Friend WithEvents delayTimer As System.Windows.Forms.Timer
    Friend WithEvents installPlayStoreApk As System.ComponentModel.BackgroundWorker
End Class
