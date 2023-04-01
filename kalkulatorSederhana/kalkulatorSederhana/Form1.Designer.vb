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
        Me.bil1 = New System.Windows.Forms.TextBox()
        Me.bil2 = New System.Windows.Forms.TextBox()
        Me.Hasil = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(170, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nilai 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(170, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nilai 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(177, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hasil"
        '
        'bil1
        '
        Me.bil1.Location = New System.Drawing.Point(268, 121)
        Me.bil1.Name = "bil1"
        Me.bil1.Size = New System.Drawing.Size(100, 26)
        Me.bil1.TabIndex = 3
        '
        'bil2
        '
        Me.bil2.Location = New System.Drawing.Point(268, 173)
        Me.bil2.Name = "bil2"
        Me.bil2.Size = New System.Drawing.Size(100, 26)
        Me.bil2.TabIndex = 4
        '
        'Hasil
        '
        Me.Hasil.Location = New System.Drawing.Point(268, 225)
        Me.Hasil.Name = "Hasil"
        Me.Hasil.Size = New System.Drawing.Size(100, 26)
        Me.Hasil.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(460, 116)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(54, 37)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(460, 176)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(54, 37)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "-"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(460, 228)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(54, 39)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "End"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(540, 116)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(47, 37)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "X"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(540, 176)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(47, 36)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "/"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(540, 228)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(47, 39)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "C"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Hasil)
        Me.Controls.Add(Me.bil2)
        Me.Controls.Add(Me.bil1)
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
    Friend WithEvents bil1 As TextBox
    Friend WithEvents bil2 As TextBox
    Friend WithEvents Hasil As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
