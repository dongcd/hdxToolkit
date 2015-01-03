Public Class superSuPre
    Private Sub superSuPre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mainToolkit.superSuBtn.Enabled = False
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub continueBtn_Click(sender As Object, e As EventArgs) Handles continueBtn.Click
        Me.Hide()
        installSuperSu.Show()
    End Sub

    Private Sub superSuPre_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        mainToolkit.superSuBtn.Enabled = True
    End Sub
End Class