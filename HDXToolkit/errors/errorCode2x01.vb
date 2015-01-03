Public Class errorCode2x01
    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub retryBtn_Click(sender As Object, e As EventArgs) Handles retryBtn.Click
        Me.Hide()
        installSuperSu.Show()
    End Sub

    Private Sub errorCode2x01_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        mainToolkit.superSuBtn.Enabled = True
    End Sub
End Class