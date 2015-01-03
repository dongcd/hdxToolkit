Imports RegawMOD.Android

Public Class installSafestrap
    Dim android As AndroidController = AndroidController.Instance
    Dim device As Device
    Dim installExitValue As Boolean

    Private Sub installSafestrap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                installSafestrapApk.RunWorkerAsync()
            Else
                Me.Close()
                errorCode7x02.Show()
            End If
        Else
            Me.Close()
            errorCode7x01.Show()
        End If
    End Sub

    Private Sub installSafestrapApk_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles installSafestrapApk.DoWork
        If My.Settings.osVersion = "13.3.1.0" Or My.Settings.osVersion = "13.3.2.1" Then
            Dim safestrapThor_372Temp As String = IO.Path.Combine(IO.Path.GetTempPath, "Safestrap (thor) 3.72.apk")
            My.Computer.FileSystem.WriteAllBytes(safestrapThor_372Temp, My.Resources.safestrapThor372, False)

            If device.InstallApk(safestrapThor_372Temp) = True Then
                installExitValue = True
            Else
                installExitValue = False
            End If

        ElseIf My.Settings.osVersion = "13.3.2.2" Or My.Settings.osVersion = "13.3.2.3" Or My.Settings.osVersion = "13.3.2.4" Or My.Settings.osVersion = "13.3.2.5" Or My.Settings.osVersion = "13.3.2.6" Or My.Settings.osVersion = "13.3.2.7" Then
            Dim safestrapThor_375b02Temp As String = IO.Path.Combine(IO.Path.GetTempPath, "Safestrap (thor) 3.75 b02.apk")
            My.Computer.FileSystem.WriteAllBytes(safestrapThor_375b02Temp, My.Resources.safestrapThor375b02, False)

            If device.InstallApk(safestrapThor_375b02Temp) = True Then
                installExitValue = True
            Else
                installExitValue = False
            End If

        ElseIf My.Settings.osVersion = "14.3.1.0" Or My.Settings.osVersion = "14.3.2.1" Then
            Dim safestrapApollo_372Temp As String = IO.Path.Combine(IO.Path.GetTempPath, "Safestrap (apollo) 3.72.apk")
            My.Computer.FileSystem.WriteAllBytes(safestrapApollo_372Temp, My.Resources.safestrapApollo372, False)

            If device.InstallApk(safestrapApollo_372Temp) = True Then
                installExitValue = True
            Else
                installExitValue = False
            End If

        ElseIf My.Settings.osVersion = "14.3.2.2" Or My.Settings.osVersion = "14.3.2.3" Or My.Settings.osVersion = "14.3.2.4" Or My.Settings.osVersion = "14.3.2.5" Or My.Settings.osVersion = "14.3.2.6" Or My.Settings.osVersion = "14.3.2.7" Then
            Dim safestrapApollo_375b02Temp As String = IO.Path.Combine(IO.Path.GetTempPath, "Safestrap (apollo) 3.75 b02.apk")
            My.Computer.FileSystem.WriteAllBytes(safestrapApollo_375b02Temp, My.Resources.safestrapApollo375b02, False)

            If device.InstallApk(safestrapApollo_375b02Temp) = True Then
                installExitValue = True
            Else
                installExitValue = False
            End If
        End If
    End Sub

    Private Sub installSafestrapApk_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles installSafestrapApk.RunWorkerCompleted
        If installExitValue = True Then
            Adb.ExecuteAdbCommand(Adb.FormAdbShellCommand(device, False, "am start -a android.intent.action.MAIN -n com.hashcode.safestrap/.ics.SafestrapActivity"))
            Me.Close()
            safestrapSuccess.Show()
        Else
            Me.Close()
            errorCode7x03.Show()
        End If
    End Sub
End Class