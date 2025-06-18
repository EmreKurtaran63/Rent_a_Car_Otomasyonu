Imports System.Data.OleDb

Public Class SoforFormu
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Tctxt.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
        AdSoyadtxt.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString()
        Yastxt.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString()
        Puantxt.Text = DataGridView1.SelectedRows(0).Cells(3).Value.ToString()
        TelNotxt.Text = DataGridView1.SelectedRows(0).Cells(4).Value.ToString()
        Adrestxt.Text = DataGridView1.SelectedRows(0).Cells(5).Value.ToString()
        Ucrettxt.Text = DataGridView1.SelectedRows(0).Cells(6).Value.ToString()
    End Sub

    Private Sub EkleButton_Click(sender As Object, e As EventArgs) Handles EkleButton.Click
        Try
            REM eğerki gelen değer true değilse ekle butonu çalışmayacak
            If Not TextboxKontrol() Then
                Return
            End If

            REM True ise çalışacak

            Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='Veritabani/Rent_a_Car_Veritabani.mdb'") 'Veritabanımızın yerini belirtiyoruz.
            baglanti.Open()

            Dim eklekomutu As String = "insert into Sofor_Tablosu values (@TC,@AdSoyad, @Yas, @Puan, @Telno, @Adres, @Ucret)"
            Dim cmd As OleDbCommand = New OleDbCommand(eklekomutu, baglanti)

            cmd.Parameters.AddWithValue("@TC", Tctxt.Text.Trim())
            cmd.Parameters.AddWithValue("@AdSoyad", AdSoyadtxt.Text.Trim())
            cmd.Parameters.AddWithValue("@Yas", Yastxt.Text.Trim())
            cmd.Parameters.AddWithValue("@Puan", Puantxt.Text.Trim())
            cmd.Parameters.AddWithValue("@Telno", TelNotxt.Text.Trim())
            cmd.Parameters.AddWithValue("@Adres", Adrestxt.Text.Trim())
            cmd.Parameters.AddWithValue("@Ucret", Ucrettxt.Text.Trim())

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
        Dim selectkomutu As String = "select * from Sofor_Tablosu where Sofor_TC Like @tc and Sofor_Ad_Soyad like @adsoyad and Sofor_Telefon_No like @telno"
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
            REM eğerki gelen değer true değilse buton çalışmayacak
            If Not TextboxKontrol() Then
                Return
            End If
            REM True ise çalışacak

            Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='Veritabani/Rent_a_Car_Veritabani.mdb'") 'Veritabanımızın yerini belirtiyoruz.
            baglanti.Open()
            Dim eklekomutu As String = "Update Sofor_Tablosu set Sofor_Ad_Soyad=@AdSoyad, Sofor_Yas = @Yas, Sofor_Puani=@Puan, Sofor_Telefon_No=@Telno, Sofor_Adres=@Adres, Sofor_Ucreti=@Ucret where Sofor_TC=@TC"
            Dim cmd As OleDbCommand = New OleDbCommand(eklekomutu, baglanti)

            cmd.Parameters.AddWithValue("@AdSoyad", AdSoyadtxt.Text.Trim())
            cmd.Parameters.AddWithValue("@Yas", Yastxt.Text.Trim())
            cmd.Parameters.AddWithValue("@Puan", Puantxt.Text.Trim())
            cmd.Parameters.AddWithValue("@Telno", TelNotxt.Text.Trim())
            cmd.Parameters.AddWithValue("@Adres", Adrestxt.Text.Trim())
            cmd.Parameters.AddWithValue("@Ucret", Ucrettxt.Text.Trim())
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
                MsgBox("Şoför TC'si boş bırakılamaz ve 11 haneden küçük olamaz")
                Return
            End If

            If MsgBox("Şoförü Silmek İstediğinizden Emin misiniz?", vbYesNo + vbQuestion, "Bilgiler Siliniyor") = DialogResult.Yes Then

                Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='Veritabani/Rent_a_Car_Veritabani.mdb'") 'Veritabanımızın yerini belirtiyoruz.
                baglanti.Open()
                Dim eklekomutu As String = "Delete from Sofor_Tablosu where Sofor_TC=@TC"
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
            Dim anamenu As AnaMenu = New AnaMenu()
            anamenu.Show()
            Me.Hide()
        Else
            Dim uanamenu As UserAnaMenu = New UserAnaMenu()
            uanamenu.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub SoforFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub SoforFormu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
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


    Private Sub Yastxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Yastxt.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Function TextboxKontrol() As Boolean
        If Tctxt.Text = Nothing Or Tctxt.Text = String.Empty Or Tctxt.Text.Length < 11 Then
            MsgBox("Şoför TC'si boş bırakılamaz ve 11 haneden küçük olamaz")
            Return False
        End If

        If AdSoyadtxt.Text = Nothing Or AdSoyadtxt.Text = String.Empty Then
            MsgBox("Şoför Adı ve soyadı boş bırakılamaz")
            Return False
        End If

        If Yastxt.Text = Nothing Or Yastxt.Text = String.Empty Then
            MsgBox("Şoförün Yaşı boş bırakılamaz")
            Return False
        End If

        If Puantxt.Text = Nothing Or Puantxt.Text = String.Empty Then
            MsgBox("Şoför Puanı boş bırakılamaz")
            Return False
        End If

        If TelNotxt.Text = Nothing Or TelNotxt.Text = String.Empty Then
            MsgBox("Şoför Telefon Numarası boş bırakılamaz")
            Return False
        End If

        If Adrestxt.Text = Nothing Or Adrestxt.Text = String.Empty Then
            MsgBox("Şoför Adresi boş bırakılamaz")
            Return False
        End If

        If Ucrettxt.Text = Nothing Or Ucrettxt.Text = String.Empty Then
            MsgBox("Şoför Ücreti boş bırakılamaz")
            Return False
        End If

        Return True
    End Function

    Private Sub Ucrettxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Ucrettxt.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub AdSoyadtxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AdSoyadtxt.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Puantxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Puantxt.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Adrestxt_TextChanged(sender As Object, e As EventArgs) Handles Adrestxt.TextChanged
        If Adrestxt.Text.StartsWith(" ") Then
            Adrestxt.Text = Adrestxt.Text.Substring(1)
        End If
    End Sub

    Private Sub AdSoyadAratxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AdSoyadAratxt.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If

        If Char.IsWhiteSpace(e.KeyChar) And AdSoyadAratxt.Text.Length < 1 Then
            e.Handled = True
        End If
    End Sub
End Class