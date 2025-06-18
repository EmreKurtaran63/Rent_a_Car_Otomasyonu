Imports System.Data.OleDb

Public Class AracFormu

    Dim kmAra, isaret As String
    Private Sub AracFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kmAra = 0
        isaret = ">="
        KMaratxt.Text = 0
        isaretComboBox.Text = ">="
        Listele(PlakaAratxt.Text.Trim(), kmAra, isaret)
    End Sub

    'DataGridView nesnesine verileri aktar
    Private Sub Listele(plaka As String, km As String, isaret As String)
        Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='Veritabani/Rent_a_Car_Veritabani.mdb'") 'Veritabanımızın yerini belirtiyoruz.
        Dim selectkomutu As String = $"select * from Arac_Tablosu  where Arac_Plaka Like @plaka and Arac_KM " + isaret + " @KM"
        Dim veriler As New DataTable()
        Dim adapter As New OleDbDataAdapter(selectkomutu, baglanti)
        adapter.SelectCommand.Parameters.AddWithValue("@plaka", "%" + plaka + "%")
        adapter.SelectCommand.Parameters.AddWithValue("@KM", km)

        adapter.Fill(veriler) 'buradaki veriler oluşturduğumuz sanal tablo.
        DataGridView1.DataSource = veriler 'veri tabanından gelen kayıtları DataGridView'e aktarıyoruz .
    End Sub

    Private Sub GeriButton_Click(sender As Object, e As EventArgs) Handles GeriButton.Click
        AnaMenu.Show()
        Me.Hide()
    End Sub

    Private Sub EkleButton_Click(sender As Object, e As EventArgs) Handles EkleButton.Click

        Try
            Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='Veritabani/Rent_a_Car_Veritabani.mdb'") 'Veritabanımızın yerini belirtiyoruz.
            baglanti.Open()
            Dim eklekomutu As String = "insert into Arac_Tablosu values(@plaka,@marka,@model,@cikisYil,@KM,@kiralama)"
            Dim cmd As OleDbCommand = New OleDbCommand(eklekomutu, baglanti)
            cmd.Parameters.AddWithValue("@plaka", Plakatxt.Text.Trim())
            cmd.Parameters.AddWithValue("@marka", Markatxt.Text.Trim())
            cmd.Parameters.AddWithValue("@model", Modeltxt.Text.Trim())
            cmd.Parameters.AddWithValue("@cikisYil", cikisyili.Text.Trim())
            cmd.Parameters.AddWithValue("@KM", Km.Text.Trim())
            cmd.Parameters.AddWithValue("@kiralama", Kucret.Text.Trim())

            Dim obj As Integer = cmd.ExecuteNonQuery()
            If obj > 0 Then
                MessageBox.Show("Eklendi")
                Listele(PlakaAratxt.Text.Trim(), kmAra, isaret)
            Else
                MessageBox.Show("Hata")
            End If
            baglanti.Close()
        Catch ex As Exception
            MessageBox.Show("Hata Oluştu: " + ex.Message)
        End Try


    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Plakatxt.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
        Markatxt.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString()
        Modeltxt.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString()
        cikisyili.Text = DataGridView1.SelectedRows(0).Cells(3).Value.ToString()
        Km.Text = DataGridView1.SelectedRows(0).Cells(4).Value.ToString()
        Kucret.Text = DataGridView1.SelectedRows(0).Cells(5).Value.ToString()
    End Sub

    Private Sub GuncelleButton_Click(sender As Object, e As EventArgs) Handles GuncelleButton.Click
        Try
            Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='Veritabani/Rent_a_Car_Veritabani.mdb'") 'Veritabanımızın yerini belirtiyoruz.
            baglanti.Open()
            Dim eklekomutu As String = "Update Arac_Tablosu set Arac_Marka=@marka,Arac_Modeli=@model,Arac_Cikis_Yili=@cikisYil,Arac_KM=@KM,Kiralama_Ucreti=@kiralama where Arac_Plaka=@plaka"
            Dim cmd As OleDbCommand = New OleDbCommand(eklekomutu, baglanti)

            cmd.Parameters.AddWithValue("@marka", Markatxt.Text.Trim())
            cmd.Parameters.AddWithValue("@model", Modeltxt.Text.Trim())
            cmd.Parameters.AddWithValue("@cikisYil", cikisyili.Text.Trim())
            cmd.Parameters.AddWithValue("@KM", Km.Text.Trim())
            cmd.Parameters.AddWithValue("@kiralama", Kucret.Text.Trim())
            cmd.Parameters.AddWithValue("@plaka", Plakatxt.Text.Trim())

            Dim obj As Integer = cmd.ExecuteNonQuery()
            If obj > 0 Then
                MessageBox.Show("Güncellendi")
                Listele(PlakaAratxt.Text.Trim(), kmAra, isaret)
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
            Dim eklekomutu As String = "Delete from Arac_Tablosu where Arac_Plaka=@plaka"
            Dim cmd As OleDbCommand = New OleDbCommand(eklekomutu, baglanti)

            cmd.Parameters.AddWithValue("@plaka", Plakatxt.Text.Trim())

            Dim obj As Integer = cmd.ExecuteNonQuery()
            If obj > 0 Then
                MessageBox.Show("Silindi")
                Listele(PlakaAratxt.Text.Trim(), kmAra, isaret)
            Else
                MessageBox.Show("Bulunamadı")
            End If
            baglanti.Close()
        Catch ex As Exception
            MessageBox.Show("Hata Oluştu: " + ex.Message)
        End Try
    End Sub

    Private Sub PlakaAratxt_TextChanged(sender As Object, e As EventArgs) Handles PlakaAratxt.TextChanged
        Listele(PlakaAratxt.Text.Trim(), kmAra, isaret)
    End Sub

    Private Sub isaretComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles isaretComboBox.SelectedIndexChanged
        isaret = isaretComboBox.Text
        Listele(PlakaAratxt.Text.Trim(), kmAra, isaret)
    End Sub

    Private Sub KMaratxt_TextChanged(sender As Object, e As EventArgs) Handles KMaratxt.TextChanged
        If KMaratxt.Text.StartsWith("0") And KMaratxt.Text.Trim().Length > 1 Then
            KMaratxt.Text = KMaratxt.Text.Substring(1)
            KMaratxt.SelectionStart = KMaratxt.Text.Length
        End If

        If KMaratxt.Text = String.Empty Then
            KMaratxt.Text = "0"
            KMaratxt.SelectionStart = KMaratxt.Text.Length
        End If
        kmAra = KMaratxt.Text.Trim()
        Listele(PlakaAratxt.Text.Trim(), kmAra, isaret)
    End Sub

    Private Sub Kucret_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Kucret.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub KMaratxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles KMaratxt.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub AracFormu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub cikisyili_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cikisyili.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Cikis_Click(sender As Object, e As EventArgs) Handles Cikis.Click
        Me.Hide()
    End Sub

    Private Sub Km_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Km.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class