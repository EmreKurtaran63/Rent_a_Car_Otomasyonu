<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserAnaMenu
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.KiralamaButton = New System.Windows.Forms.Button()
        Me.MusteriButton = New System.Windows.Forms.Button()
        Me.SoforButton = New System.Windows.Forms.Button()
        Me.GuvenliCikisButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.Controls.Add(Me.KiralamaButton, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.MusteriButton, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.SoforButton, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GuvenliCikisButton, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.55556!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.44444!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'KiralamaButton
        '
        Me.KiralamaButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.KiralamaButton.BackColor = System.Drawing.Color.Green
        Me.KiralamaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KiralamaButton.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KiralamaButton.Location = New System.Drawing.Point(344, 231)
        Me.KiralamaButton.Name = "KiralamaButton"
        Me.KiralamaButton.Size = New System.Drawing.Size(109, 93)
        Me.KiralamaButton.TabIndex = 1
        Me.KiralamaButton.Text = "Kiralama"
        Me.KiralamaButton.UseVisualStyleBackColor = False
        '
        'MusteriButton
        '
        Me.MusteriButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MusteriButton.BackColor = System.Drawing.Color.Green
        Me.MusteriButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MusteriButton.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MusteriButton.Location = New System.Drawing.Point(611, 231)
        Me.MusteriButton.Name = "MusteriButton"
        Me.MusteriButton.Size = New System.Drawing.Size(109, 93)
        Me.MusteriButton.TabIndex = 2
        Me.MusteriButton.Text = "Müşteri "
        Me.MusteriButton.UseVisualStyleBackColor = False
        '
        'SoforButton
        '
        Me.SoforButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SoforButton.BackColor = System.Drawing.Color.Green
        Me.SoforButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SoforButton.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SoforButton.Location = New System.Drawing.Point(78, 231)
        Me.SoforButton.Name = "SoforButton"
        Me.SoforButton.Size = New System.Drawing.Size(109, 93)
        Me.SoforButton.TabIndex = 4
        Me.SoforButton.Text = "Şöför"
        Me.SoforButton.UseVisualStyleBackColor = False
        '
        'GuvenliCikisButton
        '
        Me.GuvenliCikisButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GuvenliCikisButton.BackColor = System.Drawing.Color.Green
        Me.GuvenliCikisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GuvenliCikisButton.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuvenliCikisButton.Location = New System.Drawing.Point(621, 3)
        Me.GuvenliCikisButton.Name = "GuvenliCikisButton"
        Me.GuvenliCikisButton.Size = New System.Drawing.Size(176, 39)
        Me.GuvenliCikisButton.TabIndex = 7
        Me.GuvenliCikisButton.Text = "Güvenli Çıkış"
        Me.GuvenliCikisButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(290, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 64)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ANA MENÜYE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "HOŞGELDİNİZ"
        '
        'UserAnaMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UserAnaMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserAnaMenu"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents KiralamaButton As Button
    Friend WithEvents MusteriButton As Button
    Friend WithEvents SoforButton As Button
    Friend WithEvents GuvenliCikisButton As Button
    Friend WithEvents Label1 As Label
End Class
