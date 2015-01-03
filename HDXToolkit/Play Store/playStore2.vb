Imports RegawMOD.Android

Public Class playStore2
    Dim android As AndroidController = AndroidController.Instance
    Dim device As Device

    Private Sub playStore2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        delayTimer.Start()
    End Sub

    Private Sub delayTimer_Tick(sender As Object, e As EventArgs) Handles delayTimer.Tick
        delayTimer.Stop()
        installAccountManagerApk.RunWorkerAsync()
    End Sub

    Private Sub installAccountManagerApk_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles installAccountManagerApk.DoWork
        android.WaitForDevice()

        device = android.GetConnectedDevice(android.ConnectedDevices(0))

        Dim gAccountManagerApkTemp As String = IO.Path.Combine(IO.Path.GetTempPath, "Account Manager 4.0.3 (239410).apk")
        My.Computer.FileSystem.WriteAllBytes(gAccountManagerApkTemp, My.Resources.gAccountManagerApk, False)
        device.InstallApk(gAccountManagerApkTemp)
    End Sub

    Private Sub installAccountManagerApk_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles installAccountManagerApk.RunWorkerCompleted
        Me.Close()
        playStore3.Show()
    End Sub
End Class