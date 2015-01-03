Public Class adbConnected
    Private Sub adbConnected_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        delayTimer.Start()
    End Sub

    Private Sub delayTimer_Tick(sender As Object, e As EventArgs) Handles delayTimer.Tick
        delayTimer.Stop()

        Me.Close()
        mainToolkit.Show()
    End Sub
End Class