<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HakkimizdaFormu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GuvenliCikisButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GuvenliCikisButton
        '
        Me.GuvenliCikisButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GuvenliCikisButton.BackColor = System.Drawing.Color.Red
        Me.GuvenliCikisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GuvenliCikisButton.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuvenliCikisButton.Location = New System.Drawing.Point(307, 12)
        Me.GuvenliCikisButton.Name = "GuvenliCikisButton"
        Me.GuvenliCikisButton.Size = New System.Drawing.Size(54, 44)
        Me.GuvenliCikisButton.TabIndex = 7
        Me.GuvenliCikisButton.Text = "X"
        Me.GuvenliCikisButton.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Rent_a_Car_Otomasyonu.My.Resources.Resources.Wizard
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(12, 118)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(349, 140)
        Me.TextBox1.TabIndex = 9
        Me.TextBox1.Text = "RENT A CAR OTOMASYONU" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " PROGRAMI"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(12, 274)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(349, 231)
        Me.TextBox2.TabIndex = 10
        Me.TextBox2.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bu Program " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Emre Kurtaran" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ömer Yılmaz" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tarafından Yapılmıştır. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Teli" &
    "f hakları Yukarıdaki Üç İsme Aittir Ve Tüm Hakları Saklıdır."
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HakkimizdaFormu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(373, 551)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GuvenliCikisButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HakkimizdaFormu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HakkimizdaFormu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GuvenliCikisButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
