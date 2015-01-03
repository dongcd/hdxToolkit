Public Class disableOtaSuccess
    Private Sub okBtn_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub disableOtaSuccess_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        mainToolkit.disableOtaBtn.Enabled = True
        mainToolkit.enableOtaBtn.Enabled = True
    End Sub
End Class