<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CalisanFormu
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TelNoAratxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.AdSoyadAratxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TcAratxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GuncelleButton
        '
        Me.GuncelleButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GuncelleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GuncelleButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GuncelleButton.ForeColor = System.Drawing.Color.Black
        Me.GuncelleButton.Location = New System.Drawing.Point(543, 377)
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
        Me.SilButton.Location = New System.Drawing.Point(741, 377)
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
        Me.EkleButton.Location = New System.Drawing.Point(543, 263)
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
        Me.GeriButton.Location = New System.Drawing.Point(741, 263)
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
        Me.Label6.Location = New System.Drawing.Point(9, 397)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(219, 23)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Çalışan Adres:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(9, 364)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(219, 23)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Çalışan Tel No:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(9, 331)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(219, 23)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Çalışan Yaş:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(9, 298)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 23)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Çalışan Ad Soyad:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 265)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 23)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Çalışan TC:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Adrestxt
        '
        Me.Adrestxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Adrestxt.ForeColor = System.Drawing.Color.Black
        Me.Adrestxt.Location = New System.Drawing.Point(234, 395)
        Me.Adrestxt.Name = "Adrestxt"
        Me.Adrestxt.Size = New System.Drawing.Size(181, 27)
        Me.Adrestxt.TabIndex = 22
        '
        'Yastxt
        '
        Me.Yastxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Yastxt.ForeColor = System.Drawing.Color.Black
        Me.Yastxt.Location = New System.Drawing.Point(234, 329)
        Me.Yastxt.Name = "Yastxt"
        Me.Yastxt.Size = New System.Drawing.Size(181, 27)
        Me.Yastxt.TabIndex = 21
        '
        'TelNotxt
        '
        Me.TelNotxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TelNotxt.ForeColor = System.Drawing.Color.Black
        Me.TelNotxt.Location = New System.Drawing.Point(234, 362)
        Me.TelNotxt.MaxLength = 11
        Me.TelNotxt.Name = "TelNotxt"
        Me.TelNotxt.Size = New System.Drawing.Size(181, 27)
        Me.TelNotxt.TabIndex = 20
        '
        'AdSoyadtxt
        '
        Me.AdSoyadtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.AdSoyadtxt.ForeColor = System.Drawing.Color.Black
        Me.AdSoyadtxt.Location = New System.Drawing.Point(234, 296)
        Me.AdSoyadtxt.MaxLength = 20
        Me.AdSoyadtxt.Name = "AdSoyadtxt"
        Me.AdSoyadtxt.Size = New System.Drawing.Size(181, 27)
        Me.AdSoyadtxt.TabIndex = 19
        '
        'Tctxt
        '
        Me.Tctxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Tctxt.ForeColor = System.Drawing.Color.Black
        Me.Tctxt.Location = New System.Drawing.Point(234, 263)
        Me.Tctxt.MaxLength = 11
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66736!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66736!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66736!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66736!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66736!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66319!))
        Me.TableLayoutPanel1.Controls.Add(Me.TelNoAratxt, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.AdSoyadAratxt, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TcAratxt, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 177)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1067, 49)
        Me.TableLayoutPanel1.TabIndex = 34
        '
        'TelNoAratxt
        '
        Me.TelNoAratxt.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TelNoAratxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TelNoAratxt.ForeColor = System.Drawing.Color.Black
        Me.TelNoAratxt.Location = New System.Drawing.Point(888, 11)
        Me.TelNoAratxt.Name = "TelNoAratxt"
        Me.TelNoAratxt.Size = New System.Drawing.Size(171, 27)
        Me.TelNoAratxt.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(711, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(171, 23)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Çalışan Tel No:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AdSoyadAratxt
        '
        Me.AdSoyadAratxt.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.AdSoyadAratxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.AdSoyadAratxt.ForeColor = System.Drawing.Color.Black
        Me.AdSoyadAratxt.Location = New System.Drawing.Point(534, 11)
        Me.AdSoyadAratxt.Name = "AdSoyadAratxt"
        Me.AdSoyadAratxt.Size = New System.Drawing.Size(171, 27)
        Me.AdSoyadAratxt.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(357, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(171, 23)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Çalışan Ad Soyad:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TcAratxt
        '
        Me.TcAratxt.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TcAratxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TcAratxt.ForeColor = System.Drawing.Color.Black
        Me.TcAratxt.Location = New System.Drawing.Point(180, 11)
        Me.TcAratxt.Name = "TcAratxt"
        Me.TcAratxt.Size = New System.Drawing.Size(171, 27)
        Me.TcAratxt.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 23)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Çalışan TC:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CalisanFormu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1067, 529)
        Me.Controls.Add(Me.TableLayoutPanel1)
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
        Me.Name = "CalisanFormu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CalisanFormu"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
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
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TelNoAratxt As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents AdSoyadAratxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TcAratxt As TextBox
    Friend WithEvents Label5 As Label
End Class
