Imports System.Runtime.CompilerServices

Public Class KiralamaFormu
    Private Sub GeriButton_Click(sender As Object, e As EventArgs) Handles GeriButton.Click
        If ReferanceClass.yetki = "ADMİN" Then
            AnaMenu.Show()
            Me.Hide()
        Else
            UserAnaMenu.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SoforFormu.TableLayoutPanel2.Hide()
        SoforFormu.DataGridView1.Dock = DockStyle.Fill
        SoforFormu.Cikis.Show()
        SoforFormu.ShowDialog()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MusteriFormu.TableLayoutPanel2.Hide()
        MusteriFormu.DataGridView1.Dock = DockStyle.Fill
        MusteriFormu.Cikis.Show()
        MusteriFormu.ShowDialog()
    End Sub
End Class