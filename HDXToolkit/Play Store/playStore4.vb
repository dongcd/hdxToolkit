Imports RegawMOD.Android

Public Class playStore4
    Dim android As AndroidController = AndroidController.Instance
    Dim device As Device

    Private Sub playStore4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        delayTimer.Start()
    End Sub

    Private Sub delayTimer_Tick(sender As Object, e As EventArgs) Handles delayTimer.Tick
        delayTimer.Stop()
        installPlayStoreApk.RunWorkerAsync()
    End Sub

    Private Sub installPlayStoreApk_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles installPlayStoreApk.DoWork
        android.WaitForDevice()

        device = android.GetConnectedDevice(android.ConnectedDevices(0))

        Dim gPlayStoreApkTemp As String = IO.Path.Combine(IO.Path.GetTempPath, "Play Store 5.1.11.apk")
        My.Computer.FileSystem.WriteAllBytes(gPlayStoreApkTemp, My.Resources.gPlayStoreApk, False)
        device.InstallApk(gPlayStoreApkTemp)
    End Sub

    Private Sub installPlayStoreApk_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles installPlayStoreApk.RunWorkerCompleted
        Me.Close()
        playStoreSuccess.Show()
    End Sub
End Class