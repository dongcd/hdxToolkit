Public Class hdxposedPre
    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub continueBtn_Click(sender As Object, e As EventArgs) Handles continueBtn.Click
        Me.Hide()
        installXposed.Show()
    End Sub

    Private Sub hdxposedPre_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        mainToolkit.hdxposedBtn.Enabled = True
    End Sub
End Class