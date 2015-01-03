Imports RegawMOD.Android

Public Class playStore3
    Dim android As AndroidController = AndroidController.Instance
    Dim device As Device

    Private Sub playStore3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        delayTimer.Start()
    End Sub

    Private Sub delayTimer_Tick(sender As Object, e As EventArgs) Handles delayTimer.Tick
        delayTimer.Stop()
        installPlayServicesApk.RunWorkerAsync()
    End Sub

    Private Sub installPlayServicesApk_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles installPlayServicesApk.DoWork
        android.WaitForDevice()

        device = android.GetConnectedDevice(android.ConnectedDevices(0))

        Dim gPlayServicesApkTemp As String = IO.Path.Combine(IO.Path.GetTempPath, "Play Services 6.5.96 1630522-036).apk")
        My.Computer.FileSystem.WriteAllBytes(gPlayServicesApkTemp, My.Resources.gPlayServicesApk, False)
        device.InstallApk(gPlayServicesApkTemp)
    End Sub

    Private Sub installPlayServicesApk_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles installPlayServicesApk.RunWorkerCompleted
        Me.Close()
        playStore4.Show()
    End Sub
End Class