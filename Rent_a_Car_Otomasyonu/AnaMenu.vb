Public Class AnaMenu
    Private Sub AnaMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim afrm As AracFormu = New AracFormu()
        afrm.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MusteriFormu.Show()
        Me.Hide()
    End Sub

    Private Sub AnaMenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub GuvenliCikisButton_Click(sender As Object, e As EventArgs) Handles GuvenliCikisButton.Click
        Application.Exit()
    End Sub

    Private Sub KiralamaButton_Click(sender As Object, e As EventArgs) Handles KiralamaButton.Click
        KiralamaFormu.Show()
        Me.Hide()
    End Sub

    Private Sub PersonelButton_Click(sender As Object, e As EventArgs) Handles PersonelButton.Click
        PersonelFormu.Show()
        Me.Hide()
    End Sub

    Private Sub SoforButton_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SoforFormu.Show()
        Me.Hide()
    End Sub
End Class