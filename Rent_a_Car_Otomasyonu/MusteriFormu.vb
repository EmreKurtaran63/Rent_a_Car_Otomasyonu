Imports System.Data.OleDb

Public Class MusteriFormu
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        If KiralamaFormu.Visible = True Then
            KiralamaFormu.Tctxt.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
            KiralamaFormu.AdSoyadtxt.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString()
            KiralamaFormu.Yastxt.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString()
            KiralamaFormu.TelNotxt.Text = DataGridView1.SelectedRows(0).Cells(3).Value.ToString()
            KiralamaFormu.Adrestxt.Text = DataGridView1.SelectedRows(0).Cells(4).Value.ToString()
            Me.Hide()

        Else
            Tctxt.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
            AdSoyadtxt.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString()
            Yastxt.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString()
            TelNotxt.Text = DataGridView1.SelectedRows(0).Cells(3).Value.ToString()
            Adrestxt.Text = DataGridView1.SelectedRows(0).Cells(4).Value.ToString()
        End If


    End Sub

    Private Sub EkleButton_Click(sender As Object, e As EventArgs) Handles EkleButton.Click
        Try
            Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='Veritabani/Rent_a_Car_Veritabani.mdb'") 'Veritabanımızın yerini belirtiyoruz.
            baglanti.Open()
            Dim eklekomutu As String = "insert into Musteri_Tablosu values(@TC,@AdSoyad,@Yas,@Telno,@adres)"
            Dim cmd As OleDbCommand = New OleDbCommand(eklekomutu, baglanti)
            cmd.Parameters.AddWithValue("@TC", Tctxt.Text.Trim())
            cmd.Parameters.AddWithValue("@AdSoyad", AdSoyadtxt.Text.Trim())
            cmd.Parameters.AddWithValue("@Yas", Yastxt.Text.Trim())
            cmd.Parameters.AddWithValue("@Telno", TelNotxt.Text.Trim())
            cmd.Parameters.AddWithValue("@adres", Adrestxt.Text.Trim())

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
        Dim selectkomutu As String = "select * from Musteri_Tablosu where Musteri_TC Like @tc and Musteri_Ad_Soyad like @adsoyad and Musteri_Telefon_No like @telno"
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
            Dim eklekomutu As String = "Update Musteri_Tablosu set Musteri_Ad_Soyad=@AdSoyad,Musteri_Yas=@Yas,Musteri_Telefon_No=@Telno,Musteri_Adres=@adres where Musteri_TC=@TC"
            Dim cmd As OleDbCommand = New OleDbCommand(eklekomutu, baglanti)

            cmd.Parameters.AddWithValue("@AdSoyad", AdSoyadtxt.Text.Trim())
            cmd.Parameters.AddWithValue("@Yas", Yastxt.Text.Trim())
            cmd.Parameters.AddWithValue("@Telno", TelNotxt.Text.Trim())
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
            Dim eklekomutu As String = "Delete from Musteri_Tablosu where Musteri_TC=@TC"
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
        If ReferanceClass.yetki = "ADMİN" Then
            AnaMenu.Show()
            Me.Hide()
        Else
            UserAnaMenu.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub MusteriFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub Yastxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Yastxt.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TelNotxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TelNotxt.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TelNoAratxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TelNoAratxt.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub MusteriFormu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub Cikis_Click(sender As Object, e As EventArgs) Handles Cikis.Click
        Me.Hide()
    End Sub
End Class