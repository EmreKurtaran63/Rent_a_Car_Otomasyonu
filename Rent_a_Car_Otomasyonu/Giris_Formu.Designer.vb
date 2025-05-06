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
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SifreLabel = New System.Windows.Forms.Label()
        Me.KullaniciLabel = New System.Windows.Forms.Label()
        Me.PTextBox = New System.Windows.Forms.TextBox()
        Me.KGTextBox = New System.Windows.Forms.TextBox()
        Me.GirisButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(176, 258)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(98, 20)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "Beni Hatırla"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Location = New System.Drawing.Point(147, 281)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(145, 23)
        Me.LinkLabel1.TabIndex = 5
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Şifremi Unuttum"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SifreLabel
        '
        Me.SifreLabel.AutoSize = True
        Me.SifreLabel.Location = New System.Drawing.Point(101, 91)
        Me.SifreLabel.Name = "SifreLabel"
        Me.SifreLabel.Size = New System.Drawing.Size(50, 16)
        Me.SifreLabel.TabIndex = 4
        Me.SifreLabel.Text = "Parola:"
        '
        'KullaniciLabel
        '
        Me.KullaniciLabel.AutoSize = True
        Me.KullaniciLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.KullaniciLabel.Location = New System.Drawing.Point(78, 39)
        Me.KullaniciLabel.Name = "KullaniciLabel"
        Me.KullaniciLabel.Size = New System.Drawing.Size(82, 16)
        Me.KullaniciLabel.TabIndex = 3
        Me.KullaniciLabel.Text = "Kullanıcı Adı:"
        '
        'PTextBox
        '
        Me.PTextBox.Location = New System.Drawing.Point(176, 88)
        Me.PTextBox.Name = "PTextBox"
        Me.PTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PTextBox.TabIndex = 2
        '
        'KGTextBox
        '
        Me.KGTextBox.Location = New System.Drawing.Point(176, 36)
        Me.KGTextBox.Name = "KGTextBox"
        Me.KGTextBox.Size = New System.Drawing.Size(100, 22)
        Me.KGTextBox.TabIndex = 1
        '
        'GirisButton
        '
        Me.GirisButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GirisButton.Location = New System.Drawing.Point(6, 258)
        Me.GirisButton.Name = "GirisButton"
        Me.GirisButton.Size = New System.Drawing.Size(145, 46)
        Me.GirisButton.TabIndex = 0
        Me.GirisButton.Text = "Giriş"
        Me.GirisButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GirisButton)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.SifreLabel)
        Me.Panel1.Controls.Add(Me.PTextBox)
        Me.Panel1.Controls.Add(Me.KullaniciLabel)
        Me.Panel1.Controls.Add(Me.KGTextBox)
        Me.Panel1.Location = New System.Drawing.Point(456, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(341, 376)
        Me.Panel1.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(357, 208)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Giris_Formu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Giris_Formu"
        Me.Text = "Rent a Car Giriş Paneli"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SifreLabel As Label
    Friend WithEvents KullaniciLabel As Label
    Friend WithEvents PTextBox As TextBox
    Friend WithEvents KGTextBox As TextBox
    Friend WithEvents GirisButton As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
