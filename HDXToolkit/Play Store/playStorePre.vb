Public Class playStorePre
    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub continueBtn_Click(sender As Object, e As EventArgs) Handles continueBtn.Click
        Me.Hide()
        playStore1.Show()
    End Sub

    Private Sub playStorePre_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        mainToolkit.playStoreBtn.Enabled = True
    End Sub
End Class