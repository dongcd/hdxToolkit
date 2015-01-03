Public Class safestrapPre
    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub continueBtn_Click(sender As Object, e As EventArgs) Handles continueBtn.Click
        Me.Hide()
        installSafestrap.Show()
    End Sub

    Private Sub safestrapPre_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        mainToolkit.safestrapBtn.Enabled = True
    End Sub
End Class