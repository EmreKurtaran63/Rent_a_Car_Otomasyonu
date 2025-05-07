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
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.KiralamaButton, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.MusteriButton, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.SoforButton, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'KiralamaButton
        '
        Me.KiralamaButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.KiralamaButton.BackColor = System.Drawing.Color.Green
        Me.KiralamaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KiralamaButton.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KiralamaButton.Location = New System.Drawing.Point(344, 178)
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
        Me.MusteriButton.Location = New System.Drawing.Point(611, 178)
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
        Me.SoforButton.Location = New System.Drawing.Point(78, 178)
        Me.SoforButton.Name = "SoforButton"
        Me.SoforButton.Size = New System.Drawing.Size(109, 93)
        Me.SoforButton.TabIndex = 4
        Me.SoforButton.Text = "Şöför"
        Me.SoforButton.UseVisualStyleBackColor = False
        '
        'UserAnaMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "UserAnaMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserAnaMenu"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents KiralamaButton As Button
    Friend WithEvents MusteriButton As Button
    Friend WithEvents SoforButton As Button
End Class
