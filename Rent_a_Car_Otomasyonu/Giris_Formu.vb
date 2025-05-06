Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Giris_Formu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles GirisButton.Click

        Using baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Veritabani\Rent_a_Car_Veritabani.mdb")
            baglanti.Open()
            Dim komut As New OleDb.OleDbCommand("SELECT Yetki FROM Kullanici_Tablosu where Kullanici_Adi = @Kadi and Sifre = @sifre", baglanti)

            komut.Parameters.AddWithValue("@Kadi", KGTextBox.Text)
            komut.Parameters.AddWithValue("@sifre", PTextBox.Text)

            Dim oku As OleDb.OleDbDataReader
            oku = komut.ExecuteReader()


            If oku.HasRows Then

                While oku.Read()


                    ReferanceClass.yetki = oku("Yetki")
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
End Class
