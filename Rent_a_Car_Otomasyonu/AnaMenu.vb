Imports System.Data.OleDb

Public Class AnaMenu
    Private Sub AnaMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim afrm As AracFormu = New AracFormu()
        afrm.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim musterifrm As MusteriFormu = New MusteriFormu()
        musterifrm.Show()
        Me.Hide()
    End Sub
End Class