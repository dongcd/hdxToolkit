<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class advancedUtils
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
        Me.twrpBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'twrpBtn
        '
        Me.twrpBtn.Location = New System.Drawing.Point(27, 22)
        Me.twrpBtn.Name = "twrpBtn"
        Me.twrpBtn.Size = New System.Drawing.Size(218, 23)
        Me.twrpBtn.TabIndex = 0
        Me.twrpBtn.Text = "Flash TWRP"
        Me.twrpBtn.UseVisualStyleBackColor = True
        '
        'advancedUtils
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 250)
        Me.Controls.Add(Me.twrpBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "advancedUtils"
        Me.Text = "Advanced utilities"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents twrpBtn As System.Windows.Forms.Button
End Class
