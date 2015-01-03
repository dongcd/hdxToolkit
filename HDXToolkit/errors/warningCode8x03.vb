Public Class warningCode8x03
    Private Sub abortBtn_Click(sender As Object, e As EventArgs) Handles abortBtn.Click
        Me.Close()

    End Sub

    Private Sub retryBtn_Click(sender As Object, e As EventArgs) Handles retryBtn.Click
        Me.Hide()
        installXposed.Show()
    End Sub

    Private Sub ignoreBtn_Click(sender As Object, e As EventArgs) Handles ignoreBtn.Click
        Me.Hide()
        installHdxposed.Show()
    End Sub

    Private Sub warningCode8x03_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        mainToolkit.hdxposedBtn.Enabled = True
    End Sub
End Class