Public Class about
    Private Sub Label9_MouseHover(sender As Object, e As EventArgs) Handles Label9.MouseHover
        Label9.Font = New Drawing.Font("Calibri", 16, FontStyle.Bold)
    End Sub

    Private Sub Label9_MouseLeave(sender As Object, e As EventArgs)
        Label9.Font = New Drawing.Font("Calibri", 16, FontStyle.Bold)
    End Sub

    Private Sub about_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Label5.Parent = Panel1
        'Label5.BackColor = Color.Transparent
    End Sub
End Class