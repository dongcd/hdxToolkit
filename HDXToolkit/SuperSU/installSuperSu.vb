Imports RegawMOD.Android

Public Class installSuperSu
    Dim android As AndroidController = AndroidController.Instance
    Dim device As Device
    Dim installExitValue As Boolean

    Private Sub installSuperSu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            If (device.HasRoot) Then
                installSuperSuApk.RunWorkerAsync()
            Else
                Me.Close()
                errorCode2x02.Show()
            End If
        Else
            Me.Close()
            errorCode2x01.Show()
        End If
    End Sub

    Private Sub installSuperSuApk_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles installSuperSuApk.DoWork
        Dim superSuApkTemp As String = IO.Path.Combine(IO.Path.GetTempPath, "superSu-2.40.apk")
        My.Computer.FileSystem.WriteAllBytes(superSuApkTemp, My.Resources.superSuApk, False)

        If device.InstallApk(superSuApkTemp) = True Then
            installExitValue = True
        Else
            installExitValue = False
        End If
    End Sub

    Private Sub installSuperSuApk_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles installSuperSuApk.RunWorkerCompleted
        If installExitValue = True Then
            Adb.ExecuteAdbCommand(Adb.FormAdbShellCommand(device, False, "am start -a android.intent.action.MAIN -n eu.chainfire.supersu/.MainActivity"))
            Me.Close()
            superSuSuccess.Show()
        Else
            Me.Close()
            errorCode2x03.Show()
        End If
    End Sub
End Class