Imports System.Data.OleDb

Public Class PersonelFormu
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Tctxt.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
        AdSoyadtxt.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString()
        KAditxt.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString()
        Sifretxt.Text = DataGridView1.SelectedRows(0).Cells(3).Value.ToString()
        Adrestxt.Text = DataGridView1.SelectedRows(0).Cells(4).Value.ToString()
    End Sub

    Private Sub EkleButton_Click(sender As Object, e As EventArgs) Handles EkleButton.Click
        Try
            Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='Veritabani/Rent_a_Car_Veritabani.mdb'") 'Veritabanımızın yerini belirtiyoruz.
            baglanti.Open()

            Dim eklekomutu As String = "insert into Personel_ve_Kullanici_Tablosu values(@TC,@AdSoyad,@Telno,@Kadi,@Sifre,@Yetki,@Adres)"
            Dim cmd As OleDbCommand = New OleDbCommand(eklekomutu, baglanti)

            cmd.Parameters.AddWithValue("@TC", Tctxt.Text.Trim())
            cmd.Parameters.AddWithValue("@AdSoyad", AdSoyadtxt.Text.Trim())
            cmd.Parameters.AddWithValue("@Telno", TelNotxt.Text.Trim())

            If KAditxt.Text IsNot String.Empty And KAditxt.Text IsNot Nothing Then
                cmd.Parameters.AddWithValue("@Kadi", KAditxt.Text.Trim())

                If Sifretxt.Text IsNot String.Empty And Sifretxt.Text IsNot Nothing And Sifretxt.TextLength > 6 Then
                    cmd.Parameters.AddWithValue("@Sifre", Adrestxt.Text.Trim())
                Else
                    MsgBox("Şifre boş veya 6 karakterden küçük olamaz")
                    Return
                End If

                cmd.Parameters.AddWithValue("@Yetki", YetkiCombobox.Text.Trim())
            Else
                cmd.Parameters.AddWithValue("@Kadi", String.Empty)
                cmd.Parameters.AddWithValue("@Sifre", String.Empty)
                cmd.Parameters.AddWithValue("@Yetki", String.Empty)
            End If

            cmd.Parameters.AddWithValue("@Adres", Adrestxt.Text.Trim())

            Dim obj As Integer = cmd.ExecuteNonQuery()
            If obj > 0 Then
                MessageBox.Show("Eklendi")
                Listele(TcAratxt.Text.Trim(), AdSoyadAratxt.Text.Trim(), TelNoAratxt.Text.Trim())
            Else
                MessageBox.Show("Hata")
            End If
            baglanti.Close()
        Catch ex As Exception
            MessageBox.Show("Hata Oluştu: " + ex.Message)
        End Try
    End Sub

    Private Sub Listele(tc As String, ad As String, telno As String)
        Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='Veritabani/Rent_a_Car_Veritabani.mdb'") 'Veritabanımızın yerini belirtiyoruz.
        Dim selectkomutu As String = "select * from Personel_ve_Kullanici_Tablosu where Personel_TC Like @tc and Personel_Ad_Soyad like @adsoyad and Personel_Tel_No like @telno"
        Dim veriler As New DataTable()
        Dim adapter As New OleDbDataAdapter(selectkomutu, baglanti)
        adapter.SelectCommand.Parameters.AddWithValue("@tc", "%" + tc + "%")
        adapter.SelectCommand.Parameters.AddWithValue("@adsoyad", "%" + ad + "%")
        adapter.SelectCommand.Parameters.AddWithValue("@telno", "%" + telno + "%")
        adapter.Fill(veriler) 'buradaki veriler oluşturduğumuz sanal tablo.
        DataGridView1.DataSource = veriler 'veri tabanından gelen kayıtları DataGridView'e aktarıyoruz .
    End Sub

    Private Sub GuncelleButton_Click(sender As Object, e As EventArgs) Handles GuncelleButton.Click
        Try
            Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='Veritabani/Rent_a_Car_Veritabani.mdb'") 'Veritabanımızın yerini belirtiyoruz.
            baglanti.Open()
            Dim eklekomutu As String = "Update Personel_ve_Kullanici_Tablosu set Personel_Ad_Soyad=@AdSoyad,Musteri_Yas=@Yas,Musteri_Telefon_No=@Telno,Musteri_Adres=@adres where Musteri_TC=@TC"
            Dim cmd As OleDbCommand = New OleDbCommand(eklekomutu, baglanti)

            cmd.Parameters.AddWithValue("@AdSoyad", AdSoyadtxt.Text.Trim())
            cmd.Parameters.AddWithValue("@Yas", KAditxt.Text.Trim())
            cmd.Parameters.AddWithValue("@Telno", Sifretxt.Text.Trim())
            cmd.Parameters.AddWithValue("@adres", Adrestxt.Text.Trim())
            cmd.Parameters.AddWithValue("@TC", Tctxt.Text.Trim())

            Dim obj As Integer = cmd.ExecuteNonQuery()
            If obj > 0 Then
                MessageBox.Show("Güncellendi")
                Listele(TcAratxt.Text.Trim(), AdSoyadAratxt.Text.Trim(), TelNoAratxt.Text.Trim())
            Else
                MessageBox.Show("Hata")
            End If
            baglanti.Close()
        Catch ex As Exception
            MessageBox.Show("Hata Oluştu: " + ex.Message)
        End Try
    End Sub

    Private Sub SilButton_Click(sender As Object, e As EventArgs) Handles SilButton.Click
        Try
            Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='Veritabani/Rent_a_Car_Veritabani.mdb'") 'Veritabanımızın yerini belirtiyoruz.
            baglanti.Open()
            Dim eklekomutu As String = "Delete from Personel_ve_Kullanici_Tablosu where Musteri_TC=@TC"
            Dim cmd As OleDbCommand = New OleDbCommand(eklekomutu, baglanti)

            cmd.Parameters.AddWithValue("@TC", Tctxt.Text.Trim())

            Dim obj As Integer = cmd.ExecuteNonQuery()
            If obj > 0 Then
                MessageBox.Show("Silindi")
                Listele(TcAratxt.Text.Trim(), AdSoyadAratxt.Text.Trim(), TelNoAratxt.Text.Trim())
            Else
                MessageBox.Show("Bulunamadı")
            End If
            baglanti.Close()
        Catch ex As Exception
            MessageBox.Show("Hata Oluştu: " + ex.Message)
        End Try
    End Sub

    Private Sub GeriButton_Click(sender As Object, e As EventArgs) Handles GeriButton.Click
        If ReferanceClass.yetki = "admin" Then
            Dim anamenu As AnaMenu = New AnaMenu()
            anamenu.Show()
            Me.Hide()
        Else
            Dim uanamenu As UserAnaMenu = New UserAnaMenu()
            uanamenu.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub CalisanFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listele(TcAratxt.Text.Trim(), AdSoyadAratxt.Text.Trim(), TelNoAratxt.Text.Trim())
    End Sub

    Private Sub TcAratxt_TextChanged(sender As Object, e As EventArgs) Handles TcAratxt.TextChanged
        Listele(TcAratxt.Text.Trim(), AdSoyadAratxt.Text.Trim(), TelNoAratxt.Text.Trim())
    End Sub

    Private Sub AdSoyadAratxt_TextChanged(sender As Object, e As EventArgs) Handles AdSoyadAratxt.TextChanged
        Listele(TcAratxt.Text.Trim(), AdSoyadAratxt.Text.Trim(), TelNoAratxt.Text.Trim())
    End Sub

    Private Sub TelNoAratxt_TextChanged(sender As Object, e As EventArgs) Handles TelNoAratxt.TextChanged
        Listele(TcAratxt.Text.Trim(), AdSoyadAratxt.Text.Trim(), TelNoAratxt.Text.Trim())
    End Sub

    Private Sub TcAratxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TcAratxt.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Tctxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tctxt.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Yastxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles KAditxt.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TelNotxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Sifretxt.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TelNoAratxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TelNoAratxt.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CalisanFormu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub KAditxt_TextChanged(sender As Object, e As EventArgs) Handles KAditxt.TextChanged
        If KAditxt.Text = Nothing Or KAditxt.Text = String.Empty Then
            Sifretxt.Enabled = False
            Sifretxt.Text = ""
            YetkiCombobox.Enabled = False
        End If
    End Sub
End Class