Public Class enableOtaSuccess
    Private Sub enableOtaSuccess_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        mainToolkit.enableOtaBtn.Enabled = True : mainToolkit.disableOtaBtn.Enabled = True
    End Sub
End Class