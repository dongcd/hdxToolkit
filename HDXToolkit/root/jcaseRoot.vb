Imports RegawMOD.Android

Public Class jcaseRoot
    Dim android As AndroidController = AndroidController.Instance
    Dim device As Device

    Private Sub jcaseRoot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        delayTimer.Start()
    End Sub

    Private Sub delayTimer_Tick(sender As Object, e As EventArgs) Handles delayTimer.Tick
        delayTimer.Stop()

        If mainToolkit.deviceName = "thor" Then
            jcaseThor.RunWorkerAsync()
        ElseIf mainToolkit.deviceName = "apollo" Then
            jcaseApollo.RunWorkerAsync()
        End If
    End Sub

    Private Sub pushJcaseRootBase_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles jcaseRootBase.DoWork
        android.WaitForDevice()

        device = android.GetConnectedDevice(android.ConnectedDevices(0))

        Dim suBinaryTemp As String = IO.Path.Combine(IO.Path.GetTempPath, "su")
        My.Computer.FileSystem.WriteAllBytes(suBinaryTemp, My.Resources.suBinary, False)
        device.PushFile(suBinaryTemp, "/data/local/tmp/su")

        Dim rootShTemp As String = IO.Path.Combine(IO.Path.GetTempPath, "root.sh")
        My.Computer.FileSystem.WriteAllBytes(rootShTemp, My.Resources.rootScript, False)
        device.PushFile(rootShTemp, "/data/local/tmp/root.sh")

        Adb.ExecuteAdbCommand(Adb.FormAdbShellCommand(device, False, "chmod 755 /data/local/tmp/root.sh"))
    End Sub

    Private Sub jcaseThor_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles jcaseThor.DoWork
        jcaseRootBase.RunWorkerAsync()

        Dim thorExploitTemp As String = IO.Path.Combine(IO.Path.GetTempPath, "thorExploit")
        My.Computer.FileSystem.WriteAllBytes(thorExploitTemp, My.Resources.exploitThor, False)
        device.PushFile(thorExploitTemp, "/data/local/tmp/thorExploit")

        Adb.ExecuteAdbCommand(Adb.FormAdbShellCommand(device, False, "chmod 755 /data/local/tmp/thorExploit"))
        Adb.ExecuteAdbCommand(Adb.FormAdbShellCommand(device, False, "/data/local/tmp/thorExploit -c ""/data/local/tmp/root.sh"""))
    End Sub

    Private Sub jcaseApollo_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles jcaseApollo.DoWork
        jcaseRootBase.RunWorkerAsync()

        Dim apolloExploitTemp As String = IO.Path.Combine(IO.Path.GetTempPath, "apolloExploit")
        My.Computer.FileSystem.WriteAllBytes(apolloExploitTemp, My.Resources.exploitApollo, False)
        device.PushFile(apolloExploitTemp, "/data/local/tmp/exploitApollo")

        Adb.ExecuteAdbCommand(Adb.FormAdbShellCommand(device, False, "chmod 755 /data/local/tmp/apolloExploit"))
        Adb.ExecuteAdbCommand(Adb.FormAdbShellCommand(device, False, "/data/local/tmp/apolloExploit -c ""/data/local/tmp/root.sh"""))
    End Sub

    Private Sub rootSuccess(sender As System.Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles jcaseApollo.RunWorkerCompleted, jcaseThor.RunWorkerCompleted
        Me.Close()
        jcaseRootSuccess.Show()
    End Sub
End Class