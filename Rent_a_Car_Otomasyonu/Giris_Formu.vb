Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

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
                    Dim anamenu As AnaMenu = New AnaMenu()
                    anamenu.Show()
                    Me.Hide()



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

    Private Sub kullanıcıtxt_TextChanged(sender As Object, e As EventArgs) Handles kullanicitxt.TextChanged

    End Sub
End Class
