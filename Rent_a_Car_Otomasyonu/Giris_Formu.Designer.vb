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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SifreLabel = New System.Windows.Forms.Label()
        Me.KullaniciLabel = New System.Windows.Forms.Label()
        Me.PTextBox = New System.Windows.Forms.TextBox()
        Me.KGTextBox = New System.Windows.Forms.TextBox()
        Me.GirisButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.SifreLabel)
        Me.GroupBox1.Controls.Add(Me.KullaniciLabel)
        Me.GroupBox1.Controls.Add(Me.PTextBox)
        Me.GroupBox1.Controls.Add(Me.KGTextBox)
        Me.GroupBox1.Controls.Add(Me.GirisButton)
        Me.GroupBox1.Location = New System.Drawing.Point(234, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(305, 250)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Giriş Paneli"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(162, 126)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(98, 20)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "Beni Hatırla"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Location = New System.Drawing.Point(77, 209)
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
        Me.SifreLabel.Location = New System.Drawing.Point(87, 90)
        Me.SifreLabel.Name = "SifreLabel"
        Me.SifreLabel.Size = New System.Drawing.Size(50, 16)
        Me.SifreLabel.TabIndex = 4
        Me.SifreLabel.Text = "Parola:"
        '
        'KullaniciLabel
        '
        Me.KullaniciLabel.AutoSize = True
        Me.KullaniciLabel.Location = New System.Drawing.Point(55, 38)
        Me.KullaniciLabel.Name = "KullaniciLabel"
        Me.KullaniciLabel.Size = New System.Drawing.Size(82, 16)
        Me.KullaniciLabel.TabIndex = 3
        Me.KullaniciLabel.Text = "Kullanıcı Adı:"
        '
        'PTextBox
        '
        Me.PTextBox.Location = New System.Drawing.Point(162, 87)
        Me.PTextBox.Name = "PTextBox"
        Me.PTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PTextBox.TabIndex = 2
        '
        'KGTextBox
        '
        Me.KGTextBox.Location = New System.Drawing.Point(162, 35)
        Me.KGTextBox.Name = "KGTextBox"
        Me.KGTextBox.Size = New System.Drawing.Size(100, 22)
        Me.KGTextBox.TabIndex = 1
        '
        'GirisButton
        '
        Me.GirisButton.Location = New System.Drawing.Point(77, 152)
        Me.GirisButton.Name = "GirisButton"
        Me.GirisButton.Size = New System.Drawing.Size(145, 33)
        Me.GirisButton.TabIndex = 0
        Me.GirisButton.Text = "Giriş"
        Me.GirisButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(7, 105)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Giris_Formu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Giris_Formu"
        Me.Text = "Rent a Car Giriş Paneli"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SifreLabel As Label
    Friend WithEvents KullaniciLabel As Label
    Friend WithEvents PTextBox As TextBox
    Friend WithEvents KGTextBox As TextBox
    Friend WithEvents GirisButton As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Button1 As Button
End Class
