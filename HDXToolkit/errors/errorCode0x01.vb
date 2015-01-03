Public Class errorCode0x01
    Private Sub quitBtn_Click(sender As Object, e As EventArgs) Handles quitBtn.Click
        Application.Exit()
    End Sub

    Private Sub retryBtn_Click(sender As Object, e As EventArgs) Handles retryBtn.Click
        Me.Close()
        adbChecking.Show()
    End Sub
End Class