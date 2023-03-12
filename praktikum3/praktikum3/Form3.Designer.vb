<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.TxtNilai1 = New System.Windows.Forms.TextBox()
        Me.CmbOperator = New System.Windows.Forms.ComboBox()
        Me.TxtNilai2 = New System.Windows.Forms.TextBox()
        Me.TxtHasil = New System.Windows.Forms.TextBox()
        Me.BtnProses = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(209, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nilai1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(209, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Operator"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(209, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nilai2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(213, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Hasil"
        '
        'TxtNilai1
        '
        Me.TxtNilai1.Location = New System.Drawing.Point(351, 109)
        Me.TxtNilai1.Name = "TxtNilai1"
        Me.TxtNilai1.Size = New System.Drawing.Size(100, 26)
        Me.TxtNilai1.TabIndex = 4
        '
        'CmbOperator
        '
        Me.CmbOperator.FormattingEnabled = True
        Me.CmbOperator.Location = New System.Drawing.Point(351, 149)
        Me.CmbOperator.Name = "CmbOperator"
        Me.CmbOperator.Size = New System.Drawing.Size(121, 28)
        Me.CmbOperator.TabIndex = 5
        '
        'TxtNilai2
        '
        Me.TxtNilai2.Location = New System.Drawing.Point(351, 192)
        Me.TxtNilai2.Name = "TxtNilai2"
        Me.TxtNilai2.Size = New System.Drawing.Size(100, 26)
        Me.TxtNilai2.TabIndex = 6
        '
        'TxtHasil
        '
        Me.TxtHasil.Location = New System.Drawing.Point(351, 232)
        Me.TxtHasil.Name = "TxtHasil"
        Me.TxtHasil.Size = New System.Drawing.Size(100, 26)
        Me.TxtHasil.TabIndex = 7
        '
        'BtnProses
        '
        Me.BtnProses.Location = New System.Drawing.Point(404, 292)
        Me.BtnProses.Name = "BtnProses"
        Me.BtnProses.Size = New System.Drawing.Size(75, 33)
        Me.BtnProses.TabIndex = 8
        Me.BtnProses.Text = "Proses"
        Me.BtnProses.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnProses)
        Me.Controls.Add(Me.TxtHasil)
        Me.Controls.Add(Me.TxtNilai2)
        Me.Controls.Add(Me.CmbOperator)
        Me.Controls.Add(Me.TxtNilai1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Operator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtNilai1 As TextBox
    Friend WithEvents CmbOperator As ComboBox
    Friend WithEvents TxtNilai2 As TextBox
    Friend WithEvents TxtHasil As TextBox
    Friend WithEvents BtnProses As Button
End Class
