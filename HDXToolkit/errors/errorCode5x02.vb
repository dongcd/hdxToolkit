Public Class errorCode5x02
    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub retryBtn_Click(sender As Object, e As EventArgs) Handles retryBtn.Click
        Me.Hide()
        mainToolkit.disableAds()
    End Sub

    Private Sub errorCode5x02_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        mainToolkit.disableAdsBtn.Enabled = True : mainToolkit.enableAdsBtn.Enabled = True
    End Sub
End Class