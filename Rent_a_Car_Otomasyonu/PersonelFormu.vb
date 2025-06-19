Imports System.Data.OleDb

Public Class PersonelFormu
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Tctxt.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
        AdSoyadtxt.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString()
        TelNotxt.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString()
        KAditxt.Text = DataGridView1.SelectedRows(0).Cells(3).Value.ToString()
        Sifretxt.Text = DataGridView1.SelectedRows(0).Cells(4).Value.ToString()
        YetkiCombobox.Text = DataGridView1.SelectedRows(0).Cells(5).Value.ToString()
        Adrestxt.Text = DataGridView1.SelectedRows(0).Cells(6).Value.ToString()
    End Sub

    Private Sub EkleButton_Click(sender As Object, e As EventArgs) Handles EkleButton.Click
        Try
            If Tctxt.Text = Nothing Or Tctxt.Text = String.Empty Or Tctxt.Text.Length < 11 Then
                MsgBox("Personel TC'si boş bırakılamaz ve 11 haneden küçük olamaz")
                Return
            End If

            If AdSoyadtxt.Text = Nothing Or AdSoyadtxt.Text = String.Empty Then
                MsgBox("Personel Adı ve soyadı boş bırakılamaz")
                Return
            End If

            If TelNotxt.Text = Nothing Or TelNotxt.Text = String.Empty Then
                MsgBox("Personel Telefon Numarası boş bırakılamaz")
                Return
            End If

            If Adrestxt.Text = Nothing Or Adrestxt.Text = String.Empty Then
                MsgBox("Personel Adresi boş bırakılamaz")
                Return
            End If

            Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='Veritabani/Rent_a_Car_Veritabani.mdb'") 'Veritabanımızın yerini belirtiyoruz.
            baglanti.Open()

            Dim eklekomutu As String = "insert into Personel_ve_Kullanici_Tablosu values(@TC,@AdSoyad,@Telno,@Kadi,@Sifre,@Yetki,@Adres)"
            Dim cmd As OleDbCommand = New OleDbCommand(eklekomutu, baglanti)

            cmd.Parameters.AddWithValue("@TC", Tctxt.Text.Trim())
            cmd.Parameters.AddWithValue("@AdSoyad", AdSoyadtxt.Text.Trim())
            cmd.Parameters.AddWithValue("@Telno", TelNotxt.Text.Trim())

            If KAditxt.Text IsNot String.Empty And KAditxt.Text IsNot Nothing Then
                cmd.Parameters.AddWithValue("@Kadi", KAditxt.Text.Trim())

                If Sifretxt.Text IsNot String.Empty And Sifretxt.Text IsNot Nothing And Sifretxt.TextLength >= 6 Then
                    cmd.Parameters.AddWithValue("@Sifre", Sifretxt.Text.Trim())
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
            Dim eklekomutu As String = "Update Personel_ve_Kullanici_Tablosu set Personel_Ad_Soyad=@AdSoyad, Personel_Tel_No=@Telno, Personel_Kullanici_Adi=@Kadi, Personel_Sifre=@Sifre, Personel_Yetki=@Yetki, Personel_Adres=Adres where Personel_TC=@TC"
            Dim cmd As OleDbCommand = New OleDbCommand(eklekomutu, baglanti)


            cmd.Parameters.AddWithValue("@AdSoyad", AdSoyadtxt.Text.Trim())
            cmd.Parameters.AddWithValue("@Telno", TelNotxt.Text.Trim())

            If KAditxt.Text IsNot String.Empty And KAditxt.Text IsNot Nothing Then
                cmd.Parameters.AddWithValue("@Kadi", KAditxt.Text.Trim())

                If Sifretxt.Text IsNot String.Empty And Sifretxt.Text IsNot Nothing And Sifretxt.TextLength >= 6 Then
                    cmd.Parameters.AddWithValue("@Sifre", Sifretxt.Text.Trim())
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
            If Tctxt.Text = Nothing Or Tctxt.Text = String.Empty Or Tctxt.Text.Length < 11 Then
                MsgBox("Personel TC'si boş bırakılamaz ve 11 haneden küçük olamaz")
                Return
            End If

            If MsgBox("Personeli Silmek İstediğinizden Emin misiniz?", vbYesNo + vbQuestion, "Bilgiler Siliniyor") = DialogResult.Yes Then

                Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='Veritabani/Rent_a_Car_Veritabani.mdb'") 'Veritabanımızın yerini belirtiyoruz.
                baglanti.Open()
                Dim eklekomutu As String = "Delete from Personel_ve_Kullanici_Tablosu where Personel_TC=@TC"
                Dim cmd As OleDbCommand = New OleDbCommand(eklekomutu, baglanti)

                cmd.Parameters.AddWithValue("@TC", Tctxt.Text.Trim())

                Dim obj As Integer = cmd.ExecuteNonQuery()
                If obj > 0 Then
                    MessageBox.Show("Silindi")
                    Listele(TcAratxt.Text.Trim(), AdSoyadAratxt.Text.Trim(), TelNoAratxt.Text.Trim())
                Else
                    MessageBox.Show("Lütfen TC'yi doğru girdiğinizden emin olunuz!!!", "Bulunamadı!!!")
                End If
                baglanti.Close()

            End If


        Catch ex As Exception
            MessageBox.Show("Hata Oluştu: " + ex.Message)
        End Try
    End Sub

    Private Sub GeriButton_Click(sender As Object, e As EventArgs) Handles GeriButton.Click
        If ReferanceClass.yetki = "ADMİN" Then
            AnaMenu.Show()
            Me.Hide()
        Else
            UserAnaMenu.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub CalisanFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sifretxt.Enabled = False
        YetkiCombobox.Enabled = False
        YetkiCombobox.SelectedIndex = 0
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


    Private Sub TelNoAratxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TelNoAratxt.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CalisanFormu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub KAditxt_TextChanged(sender As Object, e As EventArgs) Handles KAditxt.TextChanged

        If KAditxt.Text.StartsWith(" ") Then
            KAditxt.Text = KAditxt.Text.Substring(1)
        End If

        If KAditxt.Text = Nothing Or KAditxt.Text = String.Empty Then
            Sifretxt.Enabled = False
            Sifretxt.Text = ""
            YetkiCombobox.Enabled = False
        Else
            Sifretxt.Enabled = True
            YetkiCombobox.Enabled = True
        End If
    End Sub

    Private Sub TelNotxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TelNotxt.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub AdSoyadtxt_TextChanged(sender As Object, e As EventArgs) Handles AdSoyadtxt.TextChanged
        If AdSoyadtxt.Text.StartsWith(" ") Then
            AdSoyadtxt.Text = AdSoyadtxt.Text.Substring(1)
        End If

    End Sub

    Private Sub TelNotxt_TextChanged(sender As Object, e As EventArgs) Handles TelNotxt.TextChanged
        If TelNotxt.Text.StartsWith(" ") Then
            TelNotxt.Text = TelNotxt.Text.Substring(1)
        End If
    End Sub

    Private Sub Sifretxt_TextChanged(sender As Object, e As EventArgs) Handles Sifretxt.TextChanged
        If Sifretxt.Text.StartsWith(" ") Then
            Sifretxt.Text = Sifretxt.Text.Substring(1)
        End If
    End Sub

    Private Sub Adrestxt_TextChanged(sender As Object, e As EventArgs) Handles Adrestxt.TextChanged
        If Adrestxt.Text.StartsWith(" ") Then
            Adrestxt.Text = Adrestxt.Text.Substring(1)
        End If
    End Sub
End Class