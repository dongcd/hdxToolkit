Public Class superSuSuccess
    Private Sub superSuSuccess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        delayTimer.Interval = 3500 'ms
        delayTimer.Start()
    End Sub

    Private Sub delayTimer_Tick(sender As Object, e As EventArgs) Handles delayTimer.Tick
        delayTimer.Stop()
        okBtn.Enabled = True
    End Sub

    Private Sub okBtn_Click(sender As Object, e As EventArgs) Handles okBtn.Click
        Me.Close()
    End Sub

    Private Sub superSuSuccess_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        mainToolkit.superSuBtn.Enabled = True
    End Sub
End Class