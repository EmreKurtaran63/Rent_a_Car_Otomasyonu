Public Class UserAnaMenu
    Private Sub MusteriButton_Click(sender As Object, e As EventArgs) Handles MusteriButton.Click
        MusteriFormu.TableLayoutPanel2.Show()
        MusteriFormu.DataGridView1.Dock = DockStyle.Top
        MusteriFormu.Cikis.Hide()
        MusteriFormu.Show()
        Me.Hide()
    End Sub

    Private Sub UserAnaMenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub GuvenliCikisButton_Click(sender As Object, e As EventArgs) Handles GuvenliCikisButton.Click
        If MsgBox("Çıkmak istediğinizden emin misiniz?", vbYesNo + vbQuestion, "Çıkış Yapılıyor") = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub SoforButton_Click(sender As Object, e As EventArgs) Handles SoforButton.Click
        SoforFormu.TableLayoutPanel2.Show()
        SoforFormu.DataGridView1.Dock = DockStyle.Top
        SoforFormu.Cikis.Hide()
        SoforFormu.Show()
        Me.Hide()
    End Sub

    Private Sub KiralamaButton_Click(sender As Object, e As EventArgs) Handles KiralamaButton.Click
        KiralamaFormu.Show()
        Me.Hide()
    End Sub
End Class