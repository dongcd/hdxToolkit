Imports RegawMOD.Android

Public Class disableOta
    Dim android As AndroidController = AndroidController.Instance
    Dim device As Device

    Private Sub disableOta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateDeviceList.RunWorkerAsync()
    End Sub

    Private Sub updateDeviceList_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles updateDeviceList.DoWork
        android.UpdateDeviceList()
    End Sub

    Private Sub updateDeviceList_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles updateDeviceList.RunWorkerCompleted
        If (android.HasConnectedDevices) Then
            device = android.GetConnectedDevice(android.ConnectedDevices(0))
            If (device.HasRoot) Then
                disable.RunWorkerAsync()
            Else
                Me.Close()
                errorCode3x02.Show()
            End If
        Else
            Me.Close()
            errorCode3x01.Show()
        End If
    End Sub

    Private Sub disable_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles disable.DoWork
        Adb.ExecuteAdbCommand(Adb.FormAdbShellCommand(device, True, "pm disable com.amazon.dcp/.ota.OTAUpdateMessageHandler"))
        Adb.ExecuteAdbCommand(Adb.FormAdbShellCommand(device, True, "pm disable com.amazon.dcp/.ota.InventoryUploadService"))
        Adb.ExecuteAdbCommand(Adb.FormAdbShellCommand(device, True, "pm disable com.amazon.dcp/.ota.UpdatesLookupService"))
        Adb.ExecuteAdbCommand(Adb.FormAdbShellCommand(device, True, "pm disable com.amazon.dcp/.ota.OTAService"))
        Adb.ExecuteAdbCommand(Adb.FormAdbShellCommand(device, True, "pm disable com.amazon.dcp/.ota.AppStateMonitorService"))
        Adb.ExecuteAdbCommand(Adb.FormAdbShellCommand(device, True, "pm disable com.amazon.dcp/.ota.CheckForOTAUpdatesService"))
        Adb.ExecuteAdbCommand(Adb.FormAdbShellCommand(device, True, "pm disable com.amazon.dcp/.ota.ViewUpdateActivity"))
        Adb.ExecuteAdbCommand(Adb.FormAdbShellCommand(device, True, "pm disable com.amazon.dcp/.ota.OTAStatusActivity"))
        Adb.ExecuteAdbCommand(Adb.FormAdbShellCommand(device, True, "pm disable com.amazon.dcp/.ota.ResetOTAMessageHandler"))
        Adb.ExecuteAdbCommand(Adb.FormAdbShellCommand(device, True, "pm disable com.amazon.dcp/.ota.InventoryUploadService$InventoryUploadReceiver"))
        Adb.ExecuteAdbCommand(Adb.FormAdbShellCommand(device, True, "pm disable com.amazon.dcp/.ota.UpdatesLookupService$MountStatusChangedReceiver"))
        Adb.ExecuteAdbCommand(Adb.FormAdbShellCommand(device, True, "pm disable com.amazon.dcp/.ota.OTAService$OTAWakeupReceiver"))
        Adb.ExecuteAdbCommand(Adb.FormAdbShellCommand(device, True, "pm disable com.amazon.dcp/.ota.OTAService$OTADedupeReceiver"))
        Adb.ExecuteAdbCommand(Adb.FormAdbShellCommand(device, True, "pm disable com.amazon.dcp/.ota.OTAService$OTAInstallNowReceiver"))
        Adb.ExecuteAdbCommand(Adb.FormAdbShellCommand(device, True, "pm disable com.amazon.dcp/.ota.ScheduledUpdateCheckerService"))
    End Sub

    Private Sub disable_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles disable.RunWorkerCompleted
        Me.Close()
        disableOtaSuccess.Show()
    End Sub
End Class