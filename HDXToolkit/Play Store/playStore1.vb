Imports RegawMOD.Android

Public Class playStore1
    Dim android As AndroidController = AndroidController.Instance
    Dim device As Device

    Private Sub playStore1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        delayTimer.Start()
    End Sub

    Private Sub delayTimer_Tick(sender As Object, e As EventArgs) Handles delayTimer.Tick
        delayTimer.Stop()

        android.UpdateDeviceList()

        If (android.HasConnectedDevices) Then
            device = android.GetConnectedDevice(android.ConnectedDevices(0))
            If (device.HasRoot) Then
                installServicesFrameworkApk.RunWorkerAsync()
            Else
                Me.Close()
                errorCode9x02.Show()
            End If
        Else
            Me.Close()
            errorCode9x01.Show()
        End If
    End Sub

    Private Sub installServicesFrameworkApk_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles installServicesFrameworkApk.DoWork
        Dim gServicesFrameworkApkTemp As String = IO.Path.Combine(IO.Path.GetTempPath, "Services Framework 4.0.4 (338691).apk")
        My.Computer.FileSystem.WriteAllBytes(gServicesFrameworkApkTemp, My.Resources.gServicesFrameworkApk, False)
        device.InstallApk(gServicesFrameworkApkTemp)
    End Sub

    Private Sub installServicesFrameworkApk_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles installServicesFrameworkApk.RunWorkerCompleted
        Me.Close()
        playStore2.Show()
    End Sub
End Class