Public Class enableAdsSuccess
    Private Sub enableAdsSuccess_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        mainToolkit.enableAdsBtn.Enabled = True : mainToolkit.disableAdsBtn.Enabled = True
    End Sub
End Class