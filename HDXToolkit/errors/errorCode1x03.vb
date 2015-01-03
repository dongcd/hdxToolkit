Public Class errorCode1x03
    Private Sub okBtn_Click(sender As Object, e As EventArgs) Handles okBtn.Click
        Me.Close()
    End Sub

    Private Sub errorCode1x03_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        mainToolkit.rootBtn.Enabled = True
    End Sub
End Class