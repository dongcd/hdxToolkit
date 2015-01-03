Public Class twrpPre

    Private Sub twrpPre_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        advancedUtils.twrpBtn.Enabled = True
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub continueBtn_Click(sender As Object, e As EventArgs) Handles continueBtn.Click
        Me.Hide()
        flashTwrp.Show()
    End Sub
End Class