﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class installTowelroot
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
        Me.installTowelrootApk = New System.ComponentModel.BackgroundWorker()
        Me.delayTimer = New System.Windows.Forms.Timer(Me.components)
        Me.statusLabel = New System.Windows.Forms.Label()
        Me.updateDeviceList = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'installTowelrootApk
        '
        '
        'delayTimer
        '
        Me.delayTimer.Interval = 3500
        '
        'statusLabel
        '
        Me.statusLabel.AutoSize = True
        Me.statusLabel.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusLabel.Location = New System.Drawing.Point(70, 19)
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(106, 26)
        Me.statusLabel.TabIndex = 1
        Me.statusLabel.Text = "Installing..."
        Me.statusLabel.UseWaitCursor = True
        '
        'updateDeviceList
        '
        '
        'installTowelroot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(245, 64)
        Me.ControlBox = False
        Me.Controls.Add(Me.statusLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "installTowelroot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Towelroot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents installTowelrootApk As System.ComponentModel.BackgroundWorker
    Friend WithEvents delayTimer As System.Windows.Forms.Timer
    Friend WithEvents statusLabel As System.Windows.Forms.Label
    Friend WithEvents updateDeviceList As System.ComponentModel.BackgroundWorker
End Class