﻿Public Class errorCode1x01
    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub retryBtn_Click(sender As Object, e As EventArgs) Handles retryBtn.Click
        Me.Hide()
        mainToolkit.root()
    End Sub

    Private Sub errorCode1x01_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        mainToolkit.rootBtn.Enabled = True
    End Sub
End Class