<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Giris_Formu
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Giris_Formu))
        Me.GirisButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.HakkimizdaBtn = New System.Windows.Forms.PictureBox()
        Me.GuvenliCikisButton = New System.Windows.Forms.Button()
        Me.label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.sifretxt = New System.Windows.Forms.TextBox()
        Me.pictureBox6 = New System.Windows.Forms.PictureBox()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.pictureBox5 = New System.Windows.Forms.PictureBox()
        Me.kullanicitxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.HakkimizdaBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel3.SuspendLayout()
        CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GirisButton
        '
        Me.GirisButton.BackColor = System.Drawing.Color.Green
        Me.GirisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GirisButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GirisButton.Location = New System.Drawing.Point(59, 243)
        Me.GirisButton.Name = "GirisButton"
        Me.GirisButton.Size = New System.Drawing.Size(237, 38)
        Me.GirisButton.TabIndex = 4
        Me.GirisButton.Text = "Giriş"
        Me.GirisButton.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel1.Controls.Add(Me.HakkimizdaBtn)
        Me.Panel1.Controls.Add(Me.GuvenliCikisButton)
        Me.Panel1.Controls.Add(Me.label7)
        Me.Panel1.Controls.Add(Me.GirisButton)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.panel3)
        Me.Panel1.Controls.Add(Me.panel2)
        Me.Panel1.Location = New System.Drawing.Point(471, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(344, 452)
        Me.Panel1.TabIndex = 0
        '
        'HakkimizdaBtn
        '
        Me.HakkimizdaBtn.BackColor = System.Drawing.Color.Transparent
        Me.HakkimizdaBtn.BackgroundImage = Global.Rent_a_Car_Otomasyonu.My.Resources.Resources.Wizard
        Me.HakkimizdaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.HakkimizdaBtn.Location = New System.Drawing.Point(279, 386)
        Me.HakkimizdaBtn.Name = "HakkimizdaBtn"
        Me.HakkimizdaBtn.Size = New System.Drawing.Size(52, 52)
        Me.HakkimizdaBtn.TabIndex = 24
        Me.HakkimizdaBtn.TabStop = False
        '
        'GuvenliCikisButton
        '
        Me.GuvenliCikisButton.BackColor = System.Drawing.Color.Green
        Me.GuvenliCikisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GuvenliCikisButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GuvenliCikisButton.Location = New System.Drawing.Point(59, 287)
        Me.GuvenliCikisButton.Name = "GuvenliCikisButton"
        Me.GuvenliCikisButton.Size = New System.Drawing.Size(237, 38)
        Me.GuvenliCikisButton.TabIndex = 23
        Me.GuvenliCikisButton.Text = "Güvenli Çıkış"
        Me.GuvenliCikisButton.UseVisualStyleBackColor = False
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Yi Baiti", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.label7.Location = New System.Drawing.Point(106, 86)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(93, 13)
        Me.label7.TabIndex = 22
        Me.label7.Text = "KULLANICI GİRİŞİ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(80, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 30)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "HOŞ GELDİNİZ"
        '
        'panel3
        '
        Me.panel3.Controls.Add(Me.sifretxt)
        Me.panel3.Controls.Add(Me.pictureBox6)
        Me.panel3.Location = New System.Drawing.Point(59, 174)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(237, 43)
        Me.panel3.TabIndex = 1
        '
        'sifretxt
        '
        Me.sifretxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.sifretxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.sifretxt.ForeColor = System.Drawing.SystemColors.Menu
        Me.sifretxt.Location = New System.Drawing.Point(50, 17)
        Me.sifretxt.MaxLength = 20
        Me.sifretxt.Name = "sifretxt"
        Me.sifretxt.Size = New System.Drawing.Size(157, 15)
        Me.sifretxt.TabIndex = 1
        Me.sifretxt.Text = "ŞİFRE"
        '
        'pictureBox6
        '
        Me.pictureBox6.Image = Global.Rent_a_Car_Otomasyonu.My.Resources.Resources.PASWORD
        Me.pictureBox6.Location = New System.Drawing.Point(3, 6)
        Me.pictureBox6.Name = "pictureBox6"
        Me.pictureBox6.Size = New System.Drawing.Size(41, 36)
        Me.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox6.TabIndex = 12
        Me.pictureBox6.TabStop = False
        '
        'panel2
        '
        Me.panel2.Controls.Add(Me.pictureBox5)
        Me.panel2.Controls.Add(Me.kullanicitxt)
        Me.panel2.Location = New System.Drawing.Point(59, 123)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(237, 44)
        Me.panel2.TabIndex = 0
        '
        'pictureBox5
        '
        Me.pictureBox5.Image = Global.Rent_a_Car_Otomasyonu.My.Resources.Resources.customer
        Me.pictureBox5.Location = New System.Drawing.Point(3, 3)
        Me.pictureBox5.Name = "pictureBox5"
        Me.pictureBox5.Size = New System.Drawing.Size(41, 36)
        Me.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox5.TabIndex = 3
        Me.pictureBox5.TabStop = False
        '
        'kullanicitxt
        '
        Me.kullanicitxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.kullanicitxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.kullanicitxt.ForeColor = System.Drawing.SystemColors.Menu
        Me.kullanicitxt.Location = New System.Drawing.Point(50, 15)
        Me.kullanicitxt.MaxLength = 20
        Me.kullanicitxt.Name = "kullanicitxt"
        Me.kullanicitxt.Size = New System.Drawing.Size(157, 15)
        Me.kullanicitxt.TabIndex = 0
        Me.kullanicitxt.Text = "KULLANICI ADI"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 25.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(114, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 48)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "RENT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 25.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(206, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 48)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "A"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 25.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(241, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 48)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "CAR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(175, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "GİRİŞ PANELİ"
        '
        'PictureBox3
        '
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox3.Image = Global.Rent_a_Car_Otomasyonu.My.Resources.Resources.yan2
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(108, 450)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Rent_a_Car_Otomasyonu.My.Resources.Resources.yan1
        Me.PictureBox2.Location = New System.Drawing.Point(351, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(118, 452)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(93, 255)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(262, 208)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Giris_Formu
        '
        Me.AcceptButton = Me.GirisButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(814, 450)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Giris_Formu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rent a Car Giriş Paneli"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.HakkimizdaBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel3.ResumeLayout(False)
        Me.panel3.PerformLayout()
        CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GirisButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Private WithEvents label7 As Label
    Private WithEvents Label5 As Label
    Private WithEvents panel3 As Panel
    Private WithEvents sifretxt As TextBox
    Private WithEvents pictureBox6 As PictureBox
    Private WithEvents panel2 As Panel
    Private WithEvents pictureBox5 As PictureBox
    Private WithEvents kullanicitxt As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents GuvenliCikisButton As Button
    Friend WithEvents HakkimizdaBtn As PictureBox
End Class
