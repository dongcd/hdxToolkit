Public Class modelSelection
    Private Sub loadVersionList()
        If deviceCombo.SelectedIndex = 0 Then
            osVersionCombo.Items.Clear()
            With osVersionCombo.Items
                .Add("13.3.1.0")
                .Add("13.3.2.1")
                .Add("13.3.2.2")
                .Add("13.3.2.3")
                .Add("13.3.2.4")
                .Add("13.3.2.5")
                .Add("13.3.2.6")
                .Add("13.3.2.7")
            End With
            osVersionCombo.SelectedItem = My.Settings.osVersion

        ElseIf deviceCombo.SelectedIndex = 1 Then
            osVersionCombo.Items.Clear()
            With osVersionCombo.Items
                .Add("14.3.1.0")
                .Add("14.3.2.1")
                .Add("14.3.2.2")
                .Add("14.3.2.3")
                .Add("14.3.2.4")
                .Add("14.3.2.5")
                .Add("14.3.2.6")
                .Add("14.3.2.7")
            End With
            osVersionCombo.SelectedItem = My.Settings.osVersion
        End If
    End Sub

    Private Sub modelSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.skipSelection = True Then
            Me.Opacity = 0
            Me.ShowInTaskbar = False
            adbChecking.Show()
        Else
            'My.MySettings.Default.Reset() ' Clear settings for debugging

            deviceCombo.SelectedItem = My.Settings.device
            osVersionCombo.SelectedItem = My.Settings.osVersion

            loadVersionList()

            If String.IsNullOrEmpty(deviceCombo.SelectedItem) Then
                osVersionCombo.Enabled = False
            End If

            If deviceCombo.SelectedItem IsNot Nothing And osVersionCombo.SelectedItem IsNot Nothing Then
                saveBtn.Enabled = True
            End If
        End If
    End Sub

    Private Sub deviceCombo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles deviceCombo.SelectionChangeCommitted
        osVersionCombo.Enabled = True

        loadVersionList()
        My.Settings.osVersion = osVersionCombo.SelectedItem

        If String.IsNullOrEmpty(osVersionCombo.SelectedItem) Then
            saveBtn.Enabled = False
        End If
    End Sub

    Private Sub osVersionCombo_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles osVersionCombo.SelectionChangeCommitted
        saveBtn.Enabled = True
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        My.Settings.device = deviceCombo.SelectedItem
        My.Settings.osVersion = osVersionCombo.SelectedItem
        My.Settings.Save()

        Me.Hide()
        adbChecking.Show()
    End Sub
End Class