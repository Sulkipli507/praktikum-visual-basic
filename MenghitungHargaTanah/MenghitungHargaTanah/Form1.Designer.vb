<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.jarak = New System.Windows.Forms.TextBox()
        Me.panjang = New System.Windows.Forms.TextBox()
        Me.lebar = New System.Windows.Forms.TextBox()
        Me.luas = New System.Windows.Forms.TextBox()
        Me.harga = New System.Windows.Forms.TextBox()
        Me.kategori = New System.Windows.Forms.TextBox()
        Me.clear = New System.Windows.Forms.Button()
        Me.close = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(183, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jarak tanah dengan jalan poros"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(303, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Panjang tanah"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(320, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Lebar tanah"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(326, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Luas tanah"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(317, 290)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Harga tanah"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(302, 338)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Kategori harga"
        '
        'jarak
        '
        Me.jarak.Location = New System.Drawing.Point(473, 96)
        Me.jarak.Name = "jarak"
        Me.jarak.Size = New System.Drawing.Size(100, 26)
        Me.jarak.TabIndex = 6
        '
        'panjang
        '
        Me.panjang.Location = New System.Drawing.Point(473, 143)
        Me.panjang.Name = "panjang"
        Me.panjang.Size = New System.Drawing.Size(100, 26)
        Me.panjang.TabIndex = 7
        '
        'lebar
        '
        Me.lebar.Location = New System.Drawing.Point(473, 189)
        Me.lebar.Name = "lebar"
        Me.lebar.Size = New System.Drawing.Size(100, 26)
        Me.lebar.TabIndex = 8
        '
        'luas
        '
        Me.luas.Location = New System.Drawing.Point(473, 244)
        Me.luas.Name = "luas"
        Me.luas.Size = New System.Drawing.Size(100, 26)
        Me.luas.TabIndex = 9
        '
        'harga
        '
        Me.harga.Location = New System.Drawing.Point(473, 290)
        Me.harga.Name = "harga"
        Me.harga.Size = New System.Drawing.Size(100, 26)
        Me.harga.TabIndex = 10
        '
        'kategori
        '
        Me.kategori.Location = New System.Drawing.Point(473, 338)
        Me.kategori.Name = "kategori"
        Me.kategori.Size = New System.Drawing.Size(100, 26)
        Me.kategori.TabIndex = 11
        '
        'clear
        '
        Me.clear.Location = New System.Drawing.Point(473, 391)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(75, 35)
        Me.clear.TabIndex = 12
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = True
        '
        'close
        '
        Me.close.Location = New System.Drawing.Point(358, 391)
        Me.close.Name = "close"
        Me.close.Size = New System.Drawing.Size(75, 35)
        Me.close.TabIndex = 13
        Me.close.Text = "close"
        Me.close.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(153, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(547, 29)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Program Sederhana Menghitung Harga Tanah"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(579, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "km"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(579, 146)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "meter"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(579, 192)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 20)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "meter"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(579, 247)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 20)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "m2"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(441, 290)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 20)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Rp"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.close)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.kategori)
        Me.Controls.Add(Me.harga)
        Me.Controls.Add(Me.luas)
        Me.Controls.Add(Me.lebar)
        Me.Controls.Add(Me.panjang)
        Me.Controls.Add(Me.jarak)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents jarak As TextBox
    Friend WithEvents panjang As TextBox
    Friend WithEvents lebar As TextBox
    Friend WithEvents luas As TextBox
    Friend WithEvents harga As TextBox
    Friend WithEvents kategori As TextBox
    Friend WithEvents clear As Button
    Friend WithEvents close As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
End Class
