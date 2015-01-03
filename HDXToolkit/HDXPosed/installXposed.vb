Imports RegawMOD.Android

Public Class installXposed
    Dim android As AndroidController = AndroidController.Instance
    Dim device As Device
    Dim installExitValue As Boolean

    Private Sub installXposed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        delayTimer.Start()
    End Sub

    Private Sub delayTimer_Tick(sender As Object, e As EventArgs) Handles delayTimer.Tick
        delayTimer.Stop()
        updateDeviceList.RunWorkerAsync()
    End Sub

    Private Sub installXposedApk_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles installXposedApk.DoWork
        Dim xposedApkTemp As String = IO.Path.Combine(IO.Path.GetTempPath, "xposedInstaller-33.apk")
        My.Computer.FileSystem.WriteAllBytes(xposedApkTemp, My.Resources.xposedApk, False)

        If device.InstallApk(xposedApkTemp) = True Then
            installExitValue = True
        Else
            installExitValue = False
        End If
    End Sub

    Private Sub updateDeviceList_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles updateDeviceList.DoWork
        android.UpdateDeviceList()
    End Sub

    Private Sub updateDeviceList_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles updateDeviceList.RunWorkerCompleted
        If (android.HasConnectedDevices) Then
            device = android.GetConnectedDevice(android.ConnectedDevices(0))
            If (device.HasRoot) Then
                installXposedApk.RunWorkerAsync()
            Else
                Me.Close()
                errorCode8x02.Show()
            End If
        Else
            Me.Close()
            errorCode8x01.Show()
        End If
    End Sub

    Private Sub installXposedApk_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles installXposedApk.RunWorkerCompleted
        If installExitValue = True Then
            Me.Close()
            installHdxposed.Show()
        Else
            Me.Close()
            warningCode8x03.Show()
        End If
    End Sub
End Class