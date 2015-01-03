Public Class towelrootPre
    Private Sub towelrootPre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mainToolkit.rootBtn.Enabled = False
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub continueBtn_Click(sender As Object, e As EventArgs) Handles continueBtn.Click
        Me.Hide()
        installTowelroot.Show()
    End Sub

    Private Sub towelrootPre_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        mainToolkit.rootBtn.Enabled = True
    End Sub
End Class