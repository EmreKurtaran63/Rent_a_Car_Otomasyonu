Imports System.Data.OleDb
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

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
        MusteriFormu.DataGridView1.Dock = DockStyle.Fill REM problem burda
        MusteriFormu.Cikis.Show()
        MusteriFormu.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AracFormu.TableLayoutPanel2.Visible = False
        AracFormu.DataGridView1.Dock = DockStyle.Fill
        AracFormu.Cikis.Show()
        AracFormu.ShowDialog()
    End Sub

    Private Sub EkleButton_Click(sender As Object, e As EventArgs) Handles EkleButton.Click
        Try
            Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='Veritabani/Rent_a_Car_Veritabani.mdb'") 'Veritabanımızın yerini belirtiyoruz.
            baglanti.Open()
            Dim eklekomutu As String
            If sofortc.Text = String.Empty Then

                If MsgBox("Şoför seçimi yapmadınız Devam etmek istiyoru musunuz?", vbYesNo + vbQuestion, "Şoför Seçilmedi") = DialogResult.Yes Then
                    eklekomutu = "insert into Kiralama_Tablosu (Arac_Plaka,Musteri_TC,Kiralama_Tarihi,Kiralama_Suresi,Kiralama_Ucreti,Odeme_tipi) values (@plaka,@MusteriTC,@KiralamaTarihi,@KiralamaSuresi,@KiralamaUcreti,@OdemeTipi)"

                Else
                    Return
                End If

            Else
                eklekomutu = "insert into Kiralama_Tablosu (Arac_Plaka,Sofor_TC,Musteri_TC,Kiralama_Tarihi,Kiralama_Suresi,Kiralama_Ucreti,Odeme_tipi) values (@plaka,@SoforTC,@MusteriTC,@KiralamaTarihi,@KiralamaSuresi,@KiralamaUcreti,@OdemeTipi)"

            End If
            Dim cmd As OleDbCommand = New OleDbCommand(eklekomutu, baglanti)
            cmd.Parameters.AddWithValue("@plaka", Plakatxt.Text.Trim())
            If sofortc.Text = String.Empty Then
            Else
                cmd.Parameters.AddWithValue("@SoforTC", sofortc.Text.Trim())
            End If

            cmd.Parameters.AddWithValue("@MusteriTC", Tctxt.Text.Trim())
            cmd.Parameters.AddWithValue("@KiralamaTarihi", DateTime.Now.ToString("dd.MM.yyyy"))
            cmd.Parameters.AddWithValue("@KiralamaSuresi", Km.Text.Trim())
            cmd.Parameters.AddWithValue("@KiralamaUcreti", Kucret.Text.Trim())
            cmd.Parameters.AddWithValue("@OdemeTipi", Kucret.Text.Trim())

            Dim obj As Integer = cmd.ExecuteNonQuery()
            If obj > 0 Then
                MessageBox.Show("Eklendi")

                Listele()
                temizle()
            Else
                MessageBox.Show("Hata")
            End If
            baglanti.Close()
        Catch ex As Exception
            MessageBox.Show("Hata Oluştu: " + ex.Message)

        End Try
    End Sub


    Private Sub Listele()
        Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='Veritabani/Rent_a_Car_Veritabani.mdb'") 'Veritabanımızın yerini belirtiyoruz.
        Dim selectkomutu As String = "SELECT 
    Kiralama_Tablosu.Kiralama_ID,
    Kiralama_Tablosu.Kiralama_Tarihi,
    Kiralama_Tablosu.Kiralama_Suresi,

    Arac_Tablosu.Arac_Plaka,
    Arac_Tablosu.Arac_Marka,
    Arac_Tablosu.Arac_Modeli,
    Arac_Tablosu.Kiralama_Ucreti,

    Musteri_Tablosu.Musteri_TC,
    Musteri_Tablosu.Musteri_Ad_Soyad,
    Musteri_Tablosu.Musteri_Telefon_No,

    Sofor_Tablosu.Sofor_TC,
    Sofor_Tablosu.Sofor_Ad_Soyad,
    Sofor_Tablosu.Sofor_Telefon_No

FROM 
    ((Kiralama_Tablosu
    INNER JOIN Arac_Tablosu ON Kiralama_Tablosu.Arac_Plaka = Arac_Tablosu.Arac_Plaka)
    INNER JOIN Musteri_Tablosu ON Kiralama_Tablosu.Musteri_TC = Musteri_Tablosu.Musteri_TC)
    INNER JOIN Sofor_Tablosu ON Kiralama_Tablosu.Sofor_TC = Sofor_Tablosu.Sofor_TC;
"

        Dim veriler As New DataTable()
        Dim adapter As New OleDbDataAdapter(selectkomutu, baglanti)

        adapter.Fill(veriler) 'buradaki veriler oluşturduğumuz sanal tablo.
        DataGridView1.DataSource = veriler 'veri tabanından gelen kayıtları DataGridView'e aktarıyoruz .
    End Sub

    Private Sub KiralamaFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        temizle()
        Listele()
    End Sub

    Private Sub SilButton_Click(sender As Object, e As EventArgs) Handles SilButton.Click
        Try
            If MsgBox("Silmek İstediğinize emin misiniz?", vbYesNo + vbQuestion, "Veri Silme") = DialogResult.Yes Then
                Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='Veritabani/Rent_a_Car_Veritabani.mdb'") 'Veritabanımızın yerini belirtiyoruz.
                baglanti.Open()
                Dim eklekomutu As String = "Delete from Kiralama_Tablosu where Kiralama_ID=@ID"
                Dim cmd As OleDbCommand = New OleDbCommand(eklekomutu, baglanti)

                cmd.Parameters.AddWithValue("@ID", DataGridView1.SelectedRows(0).Cells(0).Value.ToString())

                Dim obj As Integer = cmd.ExecuteNonQuery()
                If obj > 0 Then
                    MessageBox.Show("Silindi")
                    Listele()
                    temizle()
                Else
                    MessageBox.Show("Bulunamadı")
                End If
                baglanti.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Hata Oluştu: " + ex.Message)
        End Try
    End Sub

    Private Sub Ksuresitxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Ksuresitxt.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Ksuresitxt_TextChanged(sender As Object, e As EventArgs) Handles Ksuresitxt.TextChanged
        If Ksuresitxt.Text.Length < 1 Then
            Ksuresitxt.Text = "0"
        End If
        Dim ucret As Integer = Convert.ToInt32(Kucret.Text) + Convert.ToInt32(soforucret.Text)
        Kucretitxt.Text = ucret * Convert.ToInt32(Ksuresitxt.Text.Trim())
    End Sub

    Sub temizle()
        Plakatxt.Text = String.Empty
        Markatxt.Text = String.Empty
        Modeltxt.Text = String.Empty
        cikisyili.Text = String.Empty
        Km.Text = String.Empty
        Kucret.Text = "0"

        Tctxt.Text = String.Empty
        AdSoyadtxt.Text = String.Empty
        Yastxt.Text = String.Empty
        TelNotxt.Text = String.Empty
        Adrestxt.Text = String.Empty

        sofortc.Text = String.Empty
        soforadsoyad.Text = String.Empty
        soforyas.Text = String.Empty
        soforpuanı.Text = String.Empty
        sofortelno.Text = String.Empty
        soforadres.Text = String.Empty
        soforucret.Text = "0"

        OdemeTipComboBox.SelectedIndex = 0
        Ksuresitxt.Text = "0"

    End Sub
End Class