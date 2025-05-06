<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MusteriFormu
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
        Me.GuncelleButton = New System.Windows.Forms.Button()
        Me.SilButton = New System.Windows.Forms.Button()
        Me.EkleButton = New System.Windows.Forms.Button()
        Me.GeriButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Adrestxt = New System.Windows.Forms.TextBox()
        Me.Yastxt = New System.Windows.Forms.TextBox()
        Me.TelNotxt = New System.Windows.Forms.TextBox()
        Me.AdSoyadtxt = New System.Windows.Forms.TextBox()
        Me.Tctxt = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GuncelleButton
        '
        Me.GuncelleButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GuncelleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GuncelleButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GuncelleButton.ForeColor = System.Drawing.Color.Black
        Me.GuncelleButton.Location = New System.Drawing.Point(542, 359)
        Me.GuncelleButton.Name = "GuncelleButton"
        Me.GuncelleButton.Size = New System.Drawing.Size(162, 78)
        Me.GuncelleButton.TabIndex = 33
        Me.GuncelleButton.Text = "Güncelle"
        Me.GuncelleButton.UseVisualStyleBackColor = False
        '
        'SilButton
        '
        Me.SilButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SilButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SilButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SilButton.ForeColor = System.Drawing.Color.Black
        Me.SilButton.Location = New System.Drawing.Point(740, 359)
        Me.SilButton.Name = "SilButton"
        Me.SilButton.Size = New System.Drawing.Size(162, 78)
        Me.SilButton.TabIndex = 32
        Me.SilButton.Text = "Sil"
        Me.SilButton.UseVisualStyleBackColor = False
        '
        'EkleButton
        '
        Me.EkleButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EkleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.EkleButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.EkleButton.ForeColor = System.Drawing.Color.Black
        Me.EkleButton.Location = New System.Drawing.Point(542, 245)
        Me.EkleButton.Name = "EkleButton"
        Me.EkleButton.Size = New System.Drawing.Size(162, 78)
        Me.EkleButton.TabIndex = 31
        Me.EkleButton.Text = "Ekle"
        Me.EkleButton.UseVisualStyleBackColor = False
        '
        'GeriButton
        '
        Me.GeriButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GeriButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GeriButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GeriButton.ForeColor = System.Drawing.Color.Black
        Me.GeriButton.Location = New System.Drawing.Point(740, 245)
        Me.GeriButton.Name = "GeriButton"
        Me.GeriButton.Size = New System.Drawing.Size(162, 78)
        Me.GeriButton.TabIndex = 30
        Me.GeriButton.Text = "Geri"
        Me.GeriButton.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(8, 379)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(219, 23)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Müşteri Adres:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(8, 346)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(219, 23)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Müşteri Tel No:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(8, 313)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(219, 23)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Müşteri Yaş:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 280)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 23)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Müşteri Ad Soyad:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 247)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 23)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Müşteri TC:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Adrestxt
        '
        Me.Adrestxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Adrestxt.ForeColor = System.Drawing.Color.Black
        Me.Adrestxt.Location = New System.Drawing.Point(233, 377)
        Me.Adrestxt.Name = "Adrestxt"
        Me.Adrestxt.Size = New System.Drawing.Size(181, 27)
        Me.Adrestxt.TabIndex = 22
        '
        'Yastxt
        '
        Me.Yastxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Yastxt.ForeColor = System.Drawing.Color.Black
        Me.Yastxt.Location = New System.Drawing.Point(233, 311)
        Me.Yastxt.Name = "Yastxt"
        Me.Yastxt.Size = New System.Drawing.Size(181, 27)
        Me.Yastxt.TabIndex = 21
        '
        'TelNotxt
        '
        Me.TelNotxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TelNotxt.ForeColor = System.Drawing.Color.Black
        Me.TelNotxt.Location = New System.Drawing.Point(233, 344)
        Me.TelNotxt.Name = "TelNotxt"
        Me.TelNotxt.Size = New System.Drawing.Size(181, 27)
        Me.TelNotxt.TabIndex = 20
        '
        'AdSoyadtxt
        '
        Me.AdSoyadtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.AdSoyadtxt.ForeColor = System.Drawing.Color.Black
        Me.AdSoyadtxt.Location = New System.Drawing.Point(233, 278)
        Me.AdSoyadtxt.Name = "AdSoyadtxt"
        Me.AdSoyadtxt.Size = New System.Drawing.Size(181, 27)
        Me.AdSoyadtxt.TabIndex = 19
        '
        'Tctxt
        '
        Me.Tctxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Tctxt.ForeColor = System.Drawing.Color.Black
        Me.Tctxt.Location = New System.Drawing.Point(233, 245)
        Me.Tctxt.Name = "Tctxt"
        Me.Tctxt.Size = New System.Drawing.Size(181, 27)
        Me.Tctxt.TabIndex = 18
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1067, 177)
        Me.DataGridView1.TabIndex = 17
        '
        'MusteriFormu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1067, 529)
        Me.Controls.Add(Me.GuncelleButton)
        Me.Controls.Add(Me.SilButton)
        Me.Controls.Add(Me.EkleButton)
        Me.Controls.Add(Me.GeriButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Adrestxt)
        Me.Controls.Add(Me.Yastxt)
        Me.Controls.Add(Me.TelNotxt)
        Me.Controls.Add(Me.AdSoyadtxt)
        Me.Controls.Add(Me.Tctxt)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "MusteriFormu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MusteriFormu"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GuncelleButton As Button
    Friend WithEvents SilButton As Button
    Friend WithEvents EkleButton As Button
    Friend WithEvents GeriButton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Adrestxt As TextBox
    Friend WithEvents Yastxt As TextBox
    Friend WithEvents TelNotxt As TextBox
    Friend WithEvents AdSoyadtxt As TextBox
    Friend WithEvents Tctxt As TextBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
