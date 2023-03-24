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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.nQuiz = New System.Windows.Forms.Label()
        Me.nUts = New System.Windows.Forms.Label()
        Me.nUas = New System.Windows.Forms.Label()
        Me.nAngka = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.nilaiQuiz = New System.Windows.Forms.TextBox()
        Me.nilaiUts = New System.Windows.Forms.TextBox()
        Me.nilaiUas = New System.Windows.Forms.TextBox()
        Me.nilaiAngka = New System.Windows.Forms.TextBox()
        Me.nilaiHuruf = New System.Windows.Forms.TextBox()
        Me.ket = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(140, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Mahasiswa"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(313, 90)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 26)
        Me.TextBox1.TabIndex = 1
        '
        'nQuiz
        '
        Me.nQuiz.AutoSize = True
        Me.nQuiz.Location = New System.Drawing.Point(200, 146)
        Me.nQuiz.Name = "nQuiz"
        Me.nQuiz.Size = New System.Drawing.Size(74, 20)
        Me.nQuiz.TabIndex = 2
        Me.nQuiz.Text = "Nilai Quiz"
        '
        'nUts
        '
        Me.nUts.AutoSize = True
        Me.nUts.Location = New System.Drawing.Point(200, 206)
        Me.nUts.Name = "nUts"
        Me.nUts.Size = New System.Drawing.Size(74, 20)
        Me.nUts.TabIndex = 3
        Me.nUts.Text = "Nilai UTS"
        '
        'nUas
        '
        Me.nUas.AutoSize = True
        Me.nUas.Location = New System.Drawing.Point(615, 90)
        Me.nUas.Name = "nUas"
        Me.nUas.Size = New System.Drawing.Size(76, 20)
        Me.nUas.TabIndex = 4
        Me.nUas.Text = "Nilai UAS"
        '
        'nAngka
        '
        Me.nAngka.AutoSize = True
        Me.nAngka.Location = New System.Drawing.Point(603, 146)
        Me.nAngka.Name = "nAngka"
        Me.nAngka.Size = New System.Drawing.Size(88, 20)
        Me.nAngka.TabIndex = 5
        Me.nAngka.Text = "Nilai Angka"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(609, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Nilai Huruf"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(376, 286)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Keterangan"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(420, 356)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 37)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Keluar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(590, 356)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 37)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Batal"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'nilaiQuiz
        '
        Me.nilaiQuiz.Location = New System.Drawing.Point(313, 143)
        Me.nilaiQuiz.Name = "nilaiQuiz"
        Me.nilaiQuiz.Size = New System.Drawing.Size(100, 26)
        Me.nilaiQuiz.TabIndex = 10
        '
        'nilaiUts
        '
        Me.nilaiUts.Location = New System.Drawing.Point(313, 206)
        Me.nilaiUts.Name = "nilaiUts"
        Me.nilaiUts.Size = New System.Drawing.Size(100, 26)
        Me.nilaiUts.TabIndex = 11
        '
        'nilaiUas
        '
        Me.nilaiUas.Location = New System.Drawing.Point(755, 90)
        Me.nilaiUas.Name = "nilaiUas"
        Me.nilaiUas.Size = New System.Drawing.Size(100, 26)
        Me.nilaiUas.TabIndex = 12
        '
        'nilaiAngka
        '
        Me.nilaiAngka.Location = New System.Drawing.Point(755, 146)
        Me.nilaiAngka.Name = "nilaiAngka"
        Me.nilaiAngka.Size = New System.Drawing.Size(100, 26)
        Me.nilaiAngka.TabIndex = 13
        '
        'nilaiHuruf
        '
        Me.nilaiHuruf.Location = New System.Drawing.Point(755, 206)
        Me.nilaiHuruf.Name = "nilaiHuruf"
        Me.nilaiHuruf.Size = New System.Drawing.Size(100, 26)
        Me.nilaiHuruf.TabIndex = 14
        '
        'ket
        '
        Me.ket.Location = New System.Drawing.Point(500, 286)
        Me.ket.Name = "ket"
        Me.ket.Size = New System.Drawing.Size(100, 26)
        Me.ket.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 450)
        Me.Controls.Add(Me.ket)
        Me.Controls.Add(Me.nilaiHuruf)
        Me.Controls.Add(Me.nilaiAngka)
        Me.Controls.Add(Me.nilaiUas)
        Me.Controls.Add(Me.nilaiUts)
        Me.Controls.Add(Me.nilaiQuiz)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.nAngka)
        Me.Controls.Add(Me.nUas)
        Me.Controls.Add(Me.nUts)
        Me.Controls.Add(Me.nQuiz)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents nQuiz As Label
    Friend WithEvents nUts As Label
    Friend WithEvents nUas As Label
    Friend WithEvents nAngka As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents nilaiQuiz As TextBox
    Friend WithEvents nilaiUts As TextBox
    Friend WithEvents nilaiUas As TextBox
    Friend WithEvents nilaiAngka As TextBox
    Friend WithEvents nilaiHuruf As TextBox
    Friend WithEvents ket As TextBox
End Class
