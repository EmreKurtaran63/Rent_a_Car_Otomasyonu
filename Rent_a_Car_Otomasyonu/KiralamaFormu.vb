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

End Class