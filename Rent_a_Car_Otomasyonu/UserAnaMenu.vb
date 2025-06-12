Public Class UserAnaMenu
    Private Sub MusteriButton_Click(sender As Object, e As EventArgs) Handles MusteriButton.Click

        Me.Hide()
    End Sub

    Private Sub UserAnaMenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class