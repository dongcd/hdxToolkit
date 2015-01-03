Imports RegawMOD.Android

Public Class adbChecking
    Dim android As AndroidController = AndroidController.Instance
    Dim device As Device
    Dim deviceManufacturer As String

    Private Sub adbChecking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.skipInitialAdb = True Then
            Me.Close()
            mainToolkit.Show()
        Else
            delayTimer.Start()
        End If
    End Sub

    Private Sub delayTimer_Tick(sender As Object, e As EventArgs) Handles delayTimer.Tick
        delayTimer.Stop()

        android.UpdateDeviceList()

        If (android.HasConnectedDevices) Then
            device = android.GetConnectedDevice(android.ConnectedDevices(0))
            deviceManufacturer = device.BuildProp.GetProp("ro.product.manufacturer")

            If deviceManufacturer = "Amazon" Then
                Me.Close()
                adbConnected.Show()
            Else
                Me.Hide()
                errorCode0x02.Show()
            End If
        Else
            Me.Hide()
            errorCode0x01.Show()
        End If
    End Sub

    Private Sub adbChecking_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        android.Dispose()
    End Sub
End Class