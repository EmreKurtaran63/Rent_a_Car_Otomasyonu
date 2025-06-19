<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AnaMenu
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PersonelButton = New System.Windows.Forms.Button()
        Me.KiralamaButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GuvenliCikisButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.PersonelButton, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button3, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GuvenliCikisButton, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button5, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.KiralamaButton, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(900, 550)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button5.BackColor = System.Drawing.Color.Green
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(695, 378)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(109, 93)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Şöför"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'PersonelButton
        '
        Me.PersonelButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PersonelButton.BackColor = System.Drawing.Color.Green
        Me.PersonelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PersonelButton.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PersonelButton.Location = New System.Drawing.Point(95, 378)
        Me.PersonelButton.Name = "PersonelButton"
        Me.PersonelButton.Size = New System.Drawing.Size(109, 93)
        Me.PersonelButton.TabIndex = 3
        Me.PersonelButton.Text = "Personel"
        Me.PersonelButton.UseVisualStyleBackColor = False
        '
        'KiralamaButton
        '
        Me.KiralamaButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.KiralamaButton.BackColor = System.Drawing.Color.Green
        Me.KiralamaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KiralamaButton.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KiralamaButton.Location = New System.Drawing.Point(395, 378)
        Me.KiralamaButton.Name = "KiralamaButton"
        Me.KiralamaButton.Size = New System.Drawing.Size(109, 93)
        Me.KiralamaButton.TabIndex = 1
        Me.KiralamaButton.Text = "Kiralama"
        Me.KiralamaButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(95, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 93)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Araç Yönetimi"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button3.BackColor = System.Drawing.Color.Green
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(695, 128)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(109, 93)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Müşteri "
        Me.Button3.UseVisualStyleBackColor = False
        '
        'GuvenliCikisButton
        '
        Me.GuvenliCikisButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GuvenliCikisButton.BackColor = System.Drawing.Color.Green
        Me.GuvenliCikisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GuvenliCikisButton.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuvenliCikisButton.Location = New System.Drawing.Point(721, 3)
        Me.GuvenliCikisButton.Name = "GuvenliCikisButton"
        Me.GuvenliCikisButton.Size = New System.Drawing.Size(176, 44)
        Me.GuvenliCikisButton.TabIndex = 6
        Me.GuvenliCikisButton.Text = "Güvenli Çıkış"
        Me.GuvenliCikisButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(341, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 64)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ANA MENÜYE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "HOŞGELDİNİZ"
        '
        'AnaMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(900, 550)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AnaMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AnaMenu"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Button5 As Button
    Friend WithEvents PersonelButton As Button
    Friend WithEvents KiralamaButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GuvenliCikisButton As Button
    Friend WithEvents Label1 As Label
End Class
