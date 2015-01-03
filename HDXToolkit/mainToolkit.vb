Imports RegawMOD.Android

Public Class mainToolkit
    Dim android As AndroidController = AndroidController.Instance
    Dim device As Device

    Public Function deviceName()
        If My.Settings.device = "Kindle Fire HDX 7" Then
            deviceName = "thor"
        ElseIf My.Settings.device = "Kindle Fire HDX 8.9" Then
            deviceName = "apollo"
        End If

        Return "[error]"
    End Function

    Public Function rootMethod()
        If My.Settings.osVersion = "13.3.1.0" Or My.Settings.osVersion = "14.3.1.0" Then
            rootMethod = "jcase"
        Else
            rootMethod = "Towelroot"
        End If
    End Function

    Private Sub mainToolkit_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        codenameLabel.Text = "• " + deviceName.ToString
        modelLabel.Text = "• " + My.Settings.device
        firmwareLabel.Text = "• FireOS " + My.Settings.osVersion

        rootMethodLabel.Text = "method: " + rootMethod.ToString
        If rootMethod() = "Jcase" Then
            rootMethodLabel.Left = 63
        Else
            rootMethodLabel.Left = 50
        End If
    End Sub

    Public Sub root()
        rootBtn.Enabled = False

        android.UpdateDeviceList()

        If (android.HasConnectedDevices) Then
            device = android.GetConnectedDevice(android.ConnectedDevices(0))
            If (device.HasRoot) = False Then
                If rootMethod() = "Jcase" Then
                    jcaseRoot.Show()
                ElseIf rootMethod() = "Towelroot" Then
                    towelrootPre.Show()
                End If
            Else
                errorCode1x02.Show()
            End If
        Else
            errorCode1x01.Show()
        End If
    End Sub

    Private Sub rootBtn_Click(sender As Object, e As EventArgs) Handles rootBtn.Click
        root()
    End Sub

    Private Sub superSuBtn_Click(sender As Object, e As EventArgs) Handles superSuBtn.Click
        superSuPre.Show()
    End Sub

    Private Sub disableOtaBtn_Click(sender As Object, e As EventArgs) Handles disableOtaBtn.Click
        disableOtaBtn.Enabled = False : enableOtaBtn.Enabled = False
        disableOta.Show()
    End Sub

    Private Sub enableOtaBtn_Click(sender As Object, e As EventArgs) Handles enableOtaBtn.Click
        disableOtaBtn.Enabled = False : enableOtaBtn.Enabled = False
        enableOta.Show()
    End Sub

    Public Sub disableAds()
        android.UpdateDeviceList()

        If (android.HasConnectedDevices) Then
            device = android.GetConnectedDevice(android.ConnectedDevices(0))
            If (device.HasRoot) Then
                Adb.ExecuteAdbCommand(Adb.FormAdbShellCommand(device, True, "pm disable com.amazon.kindle.kso"))
                disableAdsSuccess.Show()
            Else
                errorCode5x02.Show()
            End If
        Else
            errorCode5x01.Show()
        End If
    End Sub

    Private Sub disableAdsBtn_Click(sender As Object, e As EventArgs) Handles disableAdsBtn.Click
        disableAdsBtn.Enabled = False : enableAdsBtn.Enabled = False
        disableAds()
    End Sub

    Public Sub enableAds()
        android.UpdateDeviceList()

        If (android.HasConnectedDevices) Then
            device = android.GetConnectedDevice(android.ConnectedDevices(0))
            If (device.HasRoot) Then
                Adb.ExecuteAdbCommand(Adb.FormAdbShellCommand(device, True, "pm enable com.amazon.kindle.kso"))
                enableAdsSuccess.Show()
            Else
                errorCode6x02.Show()
            End If
        Else
            errorCode6x01.Show()
        End If
    End Sub

    Private Sub enableAdsBtn_Click(sender As Object, e As EventArgs) Handles enableAdsBtn.Click
        disableAdsBtn.Enabled = False : enableAdsBtn.Enabled = False
        enableAds()
    End Sub

    Private Sub safestrapBtn_Click(sender As Object, e As EventArgs) Handles safestrapBtn.Click
        safestrapBtn.Enabled = False
        safestrapPre.Show()
    End Sub

    Private Sub hdxposedBtn_Click(sender As Object, e As EventArgs) Handles hdxposedBtn.Click
        hdxposedBtn.Enabled = False
        hdxposedPre.Show()
    End Sub

    Private Sub playStoreBtn_Click(sender As Object, e As EventArgs) Handles playStoreBtn.Click
        playStoreBtn.Enabled = False
        playStorePre.Show()
    End Sub

    Private Sub advancedUtilsBtn_Click(sender As Object, e As EventArgs) Handles advancedUtilsBtn.Click
        advancedUtils.Show()
    End Sub

    Private Sub optionsMenuItem_Click(sender As Object, e As EventArgs) Handles optionsMenuItem.Click
        options.Show()
    End Sub

    Private Sub aboutMenuItem_Click(sender As Object, e As EventArgs) Handles aboutMenuItem.Click
        about.Show()
    End Sub

    Private Sub xdaMenuItem_Click(sender As Object, e As EventArgs) Handles xdaMenuItem.Click
        Process.Start("http://forum.xda-developers.com/kindle-fire-hdx/development/hdx-toolkit-revived-gui-t2987043")
    End Sub

    Private Sub mainToolkit_FormClosed(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosed
        android.Dispose()
        Application.Exit()
    End Sub
End Class