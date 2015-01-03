Public Class disableAdsSuccess
    Private Sub disableAdsSuccess_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        mainToolkit.enableAdsBtn.Enabled = True : mainToolkit.disableAdsBtn.Enabled = True
    End Sub
End Class