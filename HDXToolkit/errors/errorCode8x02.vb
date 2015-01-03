Public Class errorCode8x02
    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub retryBtn_Click(sender As Object, e As EventArgs) Handles retryBtn.Click
        Me.Hide()
        installXposed.Show()
    End Sub

    Private Sub errorCode8x02_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        mainToolkit.hdxposedBtn.Enabled = True
    End Sub
End Class