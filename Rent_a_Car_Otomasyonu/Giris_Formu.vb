Imports System.Data.OleDb

Public Class Giris_Formu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles GirisButton.Click

        Using baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Veritabani\Rent_a_Car_Veritabani.mdb")
            baglanti.Open()
            Dim komut As New OleDb.OleDbCommand("SELECT * FROM Personel_ve_Kullanici_Tablosu where Personel_Kullanici_Adi = @Kadi and Personel_Sifre = @sifre", baglanti)

            komut.Parameters.AddWithValue("@Kadi", kullanicitxt.Text.Trim())
            komut.Parameters.AddWithValue("@sifre", sifretxt.Text.Trim())

            Dim oku As OleDb.OleDbDataReader
            oku = komut.ExecuteReader()


            If oku.HasRows Then

                While oku.Read()


                    ReferanceClass.yetki = oku("Personel_Yetki").ToString()
                    If oku("Personel_Yetki").ToString() = "admin" Then
                        Dim anamenu As AnaMenu = New AnaMenu()
                        anamenu.Show()
                        Me.Hide()
                    Else
                        Dim uanamenu As UserAnaMenu = New UserAnaMenu()
                        uanamenu.Show()
                        Me.Hide()
                    End If




                End While

            Else

                MessageBox.Show("Hatalı Giriş", "Giriş Hatası")

            End If




        End Using


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub kullanıcıtxt_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub kullanicitxt_Click(sender As Object, e As EventArgs)
        MessageBox.Show("asd")
    End Sub

    Private Sub kullanicitxt_TextChanged(sender As Object, e As EventArgs)
        MessageBox.Show("asd")
    End Sub

    Private Sub kullanicitxt_Enter(sender As Object, e As EventArgs) Handles kullanicitxt.Enter
        If kullanicitxt.ForeColor = SystemColors.Menu Then
            kullanicitxt.Text = String.Empty
            kullanicitxt.ForeColor = Color.White
        End If
    End Sub

    Private Sub kullanicitxt_Leave(sender As Object, e As EventArgs) Handles kullanicitxt.Leave
        If kullanicitxt.Text.Trim() = String.Empty Then
            kullanicitxt.Text = "KULLANICI ADI"
            kullanicitxt.ForeColor = SystemColors.Menu
        End If
    End Sub

    Private Sub sifretxt_Enter(sender As Object, e As EventArgs) Handles sifretxt.Enter
        If sifretxt.ForeColor = SystemColors.Menu Then
            sifretxt.Text = String.Empty
            sifretxt.ForeColor = Color.White
        End If
    End Sub

    Private Sub sifretxt_Leave(sender As Object, e As EventArgs) Handles sifretxt.Leave
        If sifretxt.Text.Trim() = String.Empty Then
            sifretxt.Text = "ŞİFRE"
            sifretxt.ForeColor = SystemColors.Menu
        End If
    End Sub

    Private Sub Giris_Formu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub GuvenliCikisButton_Click(sender As Object, e As EventArgs) Handles GuvenliCikisButton.Click
        Application.Exit()
    End Sub
End Class
