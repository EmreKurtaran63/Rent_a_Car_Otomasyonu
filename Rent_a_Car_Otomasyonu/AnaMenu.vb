Public Class AnaMenu
    Private Sub AnaMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim afrm As AracFormu = New AracFormu()
        afrm.Show()
        Me.Hide()
    End Sub

    Private Sub MusteriButon_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MusteriFormu.TableLayoutPanel2.Show()
        MusteriFormu.DataGridView1.Dock = DockStyle.Top
        MusteriFormu.Cikis.Hide()
        MusteriFormu.Show()
        Me.Hide()
    End Sub

    Private Sub GuvenliCikisButton_Click(sender As Object, e As EventArgs) Handles GuvenliCikisButton.Click
        If MsgBox("Çıkmak istediğinizden emin misiniz?", vbYesNo + vbQuestion, "Çıkış Yapılıyor") = DialogResult.Yes Then
            Application.Exit()
        End If

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
        SoforFormu.TableLayoutPanel2.Show()
        SoforFormu.DataGridView1.Dock = DockStyle.Top
        SoforFormu.Cikis.Hide()
        SoforFormu.Show()
        Me.Hide()
    End Sub
End Class