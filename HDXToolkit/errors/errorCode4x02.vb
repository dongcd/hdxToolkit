Public Class errorCode4x02
    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub retryBtn_Click(sender As Object, e As EventArgs) Handles retryBtn.Click
        Me.Hide()
        enableOta.Show()
    End Sub

    Private Sub errorCode4x02_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        mainToolkit.disableOtaBtn.Enabled = True : mainToolkit.enableOtaBtn.Enabled = True
    End Sub
End Class