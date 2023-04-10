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
        Me.panjang = New System.Windows.Forms.TextBox()
        Me.lebar = New System.Windows.Forms.TextBox()
        Me.jarak = New System.Windows.Forms.TextBox()
        Me.luas = New System.Windows.Forms.TextBox()
        Me.harga = New System.Windows.Forms.TextBox()
        Me.kategori = New System.Windows.Forms.TextBox()
        Me.keluar = New System.Windows.Forms.Button()
        Me.hapus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(172, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jarak Tanah dengan jalan poros"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(296, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Panjang tanah"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(313, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Lebar tanah"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(319, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Luas tanah"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(310, 297)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Harga tanah"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(295, 344)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Kategori harga"
        '
        'panjang
        '
        Me.panjang.Location = New System.Drawing.Point(442, 143)
        Me.panjang.Name = "panjang"
        Me.panjang.Size = New System.Drawing.Size(100, 26)
        Me.panjang.TabIndex = 6
        '
        'lebar
        '
        Me.lebar.Location = New System.Drawing.Point(442, 189)
        Me.lebar.Name = "lebar"
        Me.lebar.Size = New System.Drawing.Size(100, 26)
        Me.lebar.TabIndex = 7
        '
        'jarak
        '
        Me.jarak.Location = New System.Drawing.Point(442, 93)
        Me.jarak.Name = "jarak"
        Me.jarak.Size = New System.Drawing.Size(100, 26)
        Me.jarak.TabIndex = 8
        '
        'luas
        '
        Me.luas.Location = New System.Drawing.Point(442, 249)
        Me.luas.Name = "luas"
        Me.luas.Size = New System.Drawing.Size(100, 26)
        Me.luas.TabIndex = 9
        '
        'harga
        '
        Me.harga.Location = New System.Drawing.Point(442, 297)
        Me.harga.Name = "harga"
        Me.harga.Size = New System.Drawing.Size(100, 26)
        Me.harga.TabIndex = 10
        '
        'kategori
        '
        Me.kategori.Location = New System.Drawing.Point(442, 344)
        Me.kategori.Name = "kategori"
        Me.kategori.Size = New System.Drawing.Size(100, 26)
        Me.kategori.TabIndex = 11
        '
        'keluar
        '
        Me.keluar.Location = New System.Drawing.Point(332, 401)
        Me.keluar.Name = "keluar"
        Me.keluar.Size = New System.Drawing.Size(75, 31)
        Me.keluar.TabIndex = 12
        Me.keluar.Text = "Keluar"
        Me.keluar.UseVisualStyleBackColor = True
        '
        'hapus
        '
        Me.hapus.Location = New System.Drawing.Point(442, 401)
        Me.hapus.Name = "hapus"
        Me.hapus.Size = New System.Drawing.Size(75, 31)
        Me.hapus.TabIndex = 13
        Me.hapus.Text = "Hapus"
        Me.hapus.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.hapus)
        Me.Controls.Add(Me.keluar)
        Me.Controls.Add(Me.kategori)
        Me.Controls.Add(Me.harga)
        Me.Controls.Add(Me.luas)
        Me.Controls.Add(Me.jarak)
        Me.Controls.Add(Me.lebar)
        Me.Controls.Add(Me.panjang)
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
    Friend WithEvents panjang As TextBox
    Friend WithEvents lebar As TextBox
    Friend WithEvents jarak As TextBox
    Friend WithEvents luas As TextBox
    Friend WithEvents harga As TextBox
    Friend WithEvents kategori As TextBox
    Friend WithEvents keluar As Button
    Friend WithEvents hapus As Button
End Class
