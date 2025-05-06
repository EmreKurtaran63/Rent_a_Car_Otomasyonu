Imports System.Data.OleDb

Public Class AracFormu
    Private Sub AracFormu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listele()
    End Sub

    'DataGridView nesnesine verileri aktar
    Private Sub Listele()
        Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='Veritabani/Rent_a_Car_Veritabani.mdb'") 'Veritabanımızın yerini belirtiyoruz.
        Dim selectkomutu As String = "select * from Arac_Tablosu"
        Dim veriler As New DataTable()
        Dim adapter As New OleDbDataAdapter(selectkomutu, baglanti)
        adapter.Fill(veriler) 'buradaki veriler oluşturduğumuz sanal tablo.
        DataGridView1.DataSource = veriler 'veri tabanından gelen kayıtları DataGridView'e aktarıyoruz .
    End Sub

    Private Sub GeriButton_Click(sender As Object, e As EventArgs) Handles GeriButton.Click
        Dim anamenu As AnaMenu = New AnaMenu()
        anamenu.Show()
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
                Listele()
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
                Listele()
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
                Listele()
            Else
                MessageBox.Show("Bulunamadı")
            End If
            baglanti.Close()
        Catch ex As Exception
            MessageBox.Show("Hata Oluştu: " + ex.Message)
        End Try
    End Sub
End Class