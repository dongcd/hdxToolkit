Imports RegawMOD.Android

Public Class installHdxposed
    Dim android As AndroidController = AndroidController.Instance
    Dim device As Device
    Dim installExitValue As Boolean

    Private Sub installHdxposed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        delayTimer.Start()
    End Sub

    Private Sub delayTimer_Tick(sender As Object, e As EventArgs) Handles delayTimer.Tick
        delayTimer.Stop()
        installHdxposedApk.RunWorkerAsync()
    End Sub

    Private Sub installHdxposedApk_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles installHdxposedApk.DoWork
        android.WaitForDevice()

        device = android.GetConnectedDevice(android.ConnectedDevices(0))

        Dim hdxposedApkTemp As String = IO.Path.Combine(IO.Path.GetTempPath, "HDXposed-1.3.apk")
        My.Computer.FileSystem.WriteAllBytes(hdxposedApkTemp, My.Resources.hdxposedApk, False)

        If device.InstallApk(hdxposedApkTemp) = True Then
            installExitValue = True
        Else
            installExitValue = False
        End If
    End Sub

    Private Sub installHdxposedApk_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles installHdxposedApk.RunWorkerCompleted
        If installExitValue = True Then
            Adb.ExecuteAdbCommand(Adb.FormAdbShellCommand(device, False, "am start -a android.intent.action.MAIN -n de.robv.android.xposed.installer/.XposedInstallerActivity"))
            Me.Close()
            hdxposedSuccess.Show()
        Else
            Me.Close()
            errorCode8x03.Show()
        End If
    End Sub
End Class