Imports System.Data.OleDb

Public Class AnaMenu
    Private Sub AnaMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ReferanceClass.yetki = "admin" Then
            Panel1.Visible = True
            Panel1.Enabled = True

        Else
            Panel1.Visible = False
            Panel1.Enabled = False
        End If


        DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Listele("SELECT * FROM Kullanici_Tablosu")


    End Sub

    Private Sub Listele(ByVal SQL As String)
        Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Veritabani\Rent_a_Car_Veritabani.mdb") 'Veritabanımızın yerini belirtiyoruz.
        Dim veriler As New DataTable("Kayitlar")
        Dim adapter As New OleDbDataAdapter(SQL, baglanti)
        adapter.Fill(veriler) 'buradaki veriler oluşturduğumuz sanal tablo.
        DataGridView1.DataSource = veriler 'veri tabanından gelen kayıtları DataGridView'e aktarıyoruz .
    End Sub

End Class