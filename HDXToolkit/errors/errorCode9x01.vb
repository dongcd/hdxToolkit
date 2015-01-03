Public Class errorCode9x01
    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub retryBtn_Click(sender As Object, e As EventArgs) Handles retryBtn.Click
        Me.Hide()
        playStore1.Show()
    End Sub

    Private Sub errorCode9x01_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        mainToolkit.playStoreBtn.Enabled = True
    End Sub
End Class