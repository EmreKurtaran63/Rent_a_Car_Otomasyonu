<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AracFormu
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Plakatxt = New System.Windows.Forms.TextBox()
        Me.Markatxt = New System.Windows.Forms.TextBox()
        Me.cikisyili = New System.Windows.Forms.TextBox()
        Me.Kucret = New System.Windows.Forms.TextBox()
        Me.Km = New System.Windows.Forms.TextBox()
        Me.Modeltxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GeriButton = New System.Windows.Forms.Button()
        Me.EkleButton = New System.Windows.Forms.Button()
        Me.GuncelleButton = New System.Windows.Forms.Button()
        Me.SilButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.KMaratxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PlakaAratxt = New System.Windows.Forms.TextBox()
        Me.isaretComboBox = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.DataGridView1.Size = New System.Drawing.Size(1133, 177)
        Me.DataGridView1.TabIndex = 0
        '
        'Plakatxt
        '
        Me.Plakatxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Plakatxt.ForeColor = System.Drawing.Color.Black
        Me.Plakatxt.Location = New System.Drawing.Point(335, 274)
        Me.Plakatxt.MaxLength = 20
        Me.Plakatxt.Name = "Plakatxt"
        Me.Plakatxt.Size = New System.Drawing.Size(181, 27)
        Me.Plakatxt.TabIndex = 1
        '
        'Markatxt
        '
        Me.Markatxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Markatxt.ForeColor = System.Drawing.Color.Black
        Me.Markatxt.Location = New System.Drawing.Point(335, 307)
        Me.Markatxt.MaxLength = 20
        Me.Markatxt.Name = "Markatxt"
        Me.Markatxt.Size = New System.Drawing.Size(181, 27)
        Me.Markatxt.TabIndex = 2
        '
        'cikisyili
        '
        Me.cikisyili.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cikisyili.ForeColor = System.Drawing.Color.Black
        Me.cikisyili.Location = New System.Drawing.Point(335, 373)
        Me.cikisyili.MaxLength = 20
        Me.cikisyili.Name = "cikisyili"
        Me.cikisyili.Size = New System.Drawing.Size(181, 27)
        Me.cikisyili.TabIndex = 3
        '
        'Kucret
        '
        Me.Kucret.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Kucret.ForeColor = System.Drawing.Color.Black
        Me.Kucret.Location = New System.Drawing.Point(335, 439)
        Me.Kucret.MaxLength = 20
        Me.Kucret.Name = "Kucret"
        Me.Kucret.Size = New System.Drawing.Size(181, 27)
        Me.Kucret.TabIndex = 6
        '
        'Km
        '
        Me.Km.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Km.ForeColor = System.Drawing.Color.Black
        Me.Km.Location = New System.Drawing.Point(335, 406)
        Me.Km.MaxLength = 20
        Me.Km.Name = "Km"
        Me.Km.Size = New System.Drawing.Size(181, 27)
        Me.Km.TabIndex = 5
        '
        'Modeltxt
        '
        Me.Modeltxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Modeltxt.ForeColor = System.Drawing.Color.Black
        Me.Modeltxt.Location = New System.Drawing.Point(335, 340)
        Me.Modeltxt.MaxLength = 20
        Me.Modeltxt.Name = "Modeltxt"
        Me.Modeltxt.Size = New System.Drawing.Size(181, 27)
        Me.Modeltxt.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(110, 276)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Plaka"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(110, 309)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 23)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Marka:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(110, 375)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(219, 23)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Çıkış yılı:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(110, 342)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(219, 23)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Model:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(110, 441)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(219, 23)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Kiralama Ücreti:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(110, 408)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(219, 23)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "KM:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GeriButton
        '
        Me.GeriButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GeriButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GeriButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GeriButton.ForeColor = System.Drawing.Color.Black
        Me.GeriButton.Location = New System.Drawing.Point(842, 274)
        Me.GeriButton.Name = "GeriButton"
        Me.GeriButton.Size = New System.Drawing.Size(162, 78)
        Me.GeriButton.TabIndex = 13
        Me.GeriButton.Text = "Geri"
        Me.GeriButton.UseVisualStyleBackColor = False
        '
        'EkleButton
        '
        Me.EkleButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EkleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.EkleButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.EkleButton.ForeColor = System.Drawing.Color.Black
        Me.EkleButton.Location = New System.Drawing.Point(644, 274)
        Me.EkleButton.Name = "EkleButton"
        Me.EkleButton.Size = New System.Drawing.Size(162, 78)
        Me.EkleButton.TabIndex = 14
        Me.EkleButton.Text = "Ekle"
        Me.EkleButton.UseVisualStyleBackColor = False
        '
        'GuncelleButton
        '
        Me.GuncelleButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GuncelleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GuncelleButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GuncelleButton.ForeColor = System.Drawing.Color.Black
        Me.GuncelleButton.Location = New System.Drawing.Point(644, 388)
        Me.GuncelleButton.Name = "GuncelleButton"
        Me.GuncelleButton.Size = New System.Drawing.Size(162, 78)
        Me.GuncelleButton.TabIndex = 16
        Me.GuncelleButton.Text = "Güncelle"
        Me.GuncelleButton.UseVisualStyleBackColor = False
        '
        'SilButton
        '
        Me.SilButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SilButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SilButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SilButton.ForeColor = System.Drawing.Color.Black
        Me.SilButton.Location = New System.Drawing.Point(842, 388)
        Me.SilButton.Name = "SilButton"
        Me.SilButton.Size = New System.Drawing.Size(162, 78)
        Me.SilButton.TabIndex = 15
        Me.SilButton.Text = "Sil"
        Me.SilButton.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.KMaratxt, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PlakaAratxt, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.isaretComboBox, 4, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 177)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1133, 49)
        Me.TableLayoutPanel1.TabIndex = 35
        '
        'KMaratxt
        '
        Me.KMaratxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KMaratxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.KMaratxt.ForeColor = System.Drawing.Color.Black
        Me.KMaratxt.Location = New System.Drawing.Point(681, 11)
        Me.KMaratxt.Name = "KMaratxt"
        Me.KMaratxt.Size = New System.Drawing.Size(220, 27)
        Me.KMaratxt.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(504, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(171, 23)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "KM:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(52, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(171, 23)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Plaka:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PlakaAratxt
        '
        Me.PlakaAratxt.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PlakaAratxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.PlakaAratxt.ForeColor = System.Drawing.Color.Black
        Me.PlakaAratxt.Location = New System.Drawing.Point(229, 11)
        Me.PlakaAratxt.Name = "PlakaAratxt"
        Me.PlakaAratxt.Size = New System.Drawing.Size(171, 27)
        Me.PlakaAratxt.TabIndex = 26
        '
        'isaretComboBox
        '
        Me.isaretComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.isaretComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.isaretComboBox.FormattingEnabled = True
        Me.isaretComboBox.Items.AddRange(New Object() {">=", "<=", ">", "<", "="})
        Me.isaretComboBox.Location = New System.Drawing.Point(907, 12)
        Me.isaretComboBox.Name = "isaretComboBox"
        Me.isaretComboBox.Size = New System.Drawing.Size(121, 24)
        Me.isaretComboBox.TabIndex = 29
        '
        'AracFormu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1133, 487)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.GuncelleButton)
        Me.Controls.Add(Me.SilButton)
        Me.Controls.Add(Me.EkleButton)
        Me.Controls.Add(Me.GeriButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Kucret)
        Me.Controls.Add(Me.Km)
        Me.Controls.Add(Me.Modeltxt)
        Me.Controls.Add(Me.cikisyili)
        Me.Controls.Add(Me.Markatxt)
        Me.Controls.Add(Me.Plakatxt)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "AracFormu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AracFormu"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Plakatxt As TextBox
    Friend WithEvents Markatxt As TextBox
    Friend WithEvents cikisyili As TextBox
    Friend WithEvents Kucret As TextBox
    Friend WithEvents Km As TextBox
    Friend WithEvents Modeltxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GeriButton As Button
    Friend WithEvents EkleButton As Button
    Friend WithEvents GuncelleButton As Button
    Friend WithEvents SilButton As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PlakaAratxt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents KMaratxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents isaretComboBox As ComboBox
End Class
