Public Class jcaseRootSuccess
    Private Sub okBtn_Click(sender As Object, e As EventArgs) Handles okBtn.Click
        Me.Close()
    End Sub

    Private Sub jcaseRootSuccess_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        mainToolkit.rootBtn.Enabled = True
    End Sub
End Class