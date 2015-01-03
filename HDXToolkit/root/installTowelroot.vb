Imports RegawMOD.Android

Public Class installTowelroot
    Dim android As AndroidController = AndroidController.Instance
    Dim device As Device
    Dim installExitValue As Boolean

    Private Sub installTowelroot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        delayTimer.Start()
    End Sub

    Private Sub delayTimer_Tick(sender As Object, e As EventArgs) Handles delayTimer.Tick
        delayTimer.Stop()
        updateDeviceList.RunWorkerAsync()
    End Sub

    Private Sub updateDeviceList_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles updateDeviceList.DoWork
        android.UpdateDeviceList()
    End Sub

    Private Sub updateDeviceList_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles updateDeviceList.RunWorkerCompleted
        If (android.HasConnectedDevices) Then
            device = android.GetConnectedDevice(android.ConnectedDevices(0))
            installTowelrootApk.RunWorkerAsync()
        Else
            Me.Close()
            errorCode1x01.Show()
        End If
    End Sub

    Public Sub installTowelrootApk_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles installTowelrootApk.DoWork
        android.WaitForDevice()

        Dim towelrootApkTemp As String = IO.Path.Combine(IO.Path.GetTempPath, "towelroot v3.apk")
        My.Computer.FileSystem.WriteAllBytes(towelrootApkTemp, My.Resources.towelrootApk, False)

        If device.InstallApk(towelrootApkTemp) = True Then
            installExitValue = True
        Else
            installExitValue = False
        End If
    End Sub

    Private Sub installTowelrootApk_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles installTowelrootApk.RunWorkerCompleted
        If installExitValue = True Then
            Adb.ExecuteAdbCommand(Adb.FormAdbShellCommand(device, False, "am start -a android.intent.action.MAIN -n com.geohot.towelroot/.TowelRoot"))
            Me.Close()
            towelrootSuccess.Show()
        Else
            Me.Close()
            errorCode1x03.Show()
        End If
    End Sub
End Class