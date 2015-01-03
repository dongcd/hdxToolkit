Public Class options
    Private Sub options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBox1.Checked = My.Settings.skipSelection
        CheckBox2.Checked = My.Settings.skipInitialAdb
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub applyBtn_Click(sender As Object, e As EventArgs) Handles applyBtn.Click
        Me.Hide()
        My.Settings.skipSelection = CheckBox1.Checked
        My.Settings.skipInitialAdb = CheckBox2.Checked
        My.Settings.Save()
    End Sub
End Class