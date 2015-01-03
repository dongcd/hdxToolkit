Public Class errorCode0x02
    Private Sub quitBtn_Click(sender As Object, e As EventArgs) Handles retryBtn.Click
        Application.Exit()
    End Sub

    Private Sub retryBtn_Click(sender As Object, e As EventArgs) Handles quitBtn.Click
        Me.Close()
        adbChecking.Show()
    End Sub
End Class