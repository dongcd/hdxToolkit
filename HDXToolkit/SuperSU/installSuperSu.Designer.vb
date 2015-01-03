<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class installSuperSu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.delayTimer = New System.Windows.Forms.Timer(Me.components)
        Me.updateDeviceList = New System.ComponentModel.BackgroundWorker()
        Me.installSuperSuApk = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(70, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Installing..."
        Me.Label1.UseWaitCursor = True
        '
        'delayTimer
        '
        Me.delayTimer.Interval = 2000
        '
        'updateDeviceList
        '
        Me.updateDeviceList.WorkerSupportsCancellation = True
        '
        'installSuperSuApk
        '
        Me.installSuperSuApk.WorkerSupportsCancellation = True
        '
        'installSuperSu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(244, 61)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "installSuperSu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SuperSU"
        Me.UseWaitCursor = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents delayTimer As System.Windows.Forms.Timer
    Friend WithEvents updateDeviceList As System.ComponentModel.BackgroundWorker
    Friend WithEvents installSuperSuApk As System.ComponentModel.BackgroundWorker
End Class
