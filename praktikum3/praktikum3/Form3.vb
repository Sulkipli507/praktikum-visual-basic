Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbOperator.Items.Add("+")
        CmbOperator.Items.Add("-")
        CmbOperator.Items.Add("x")
        CmbOperator.Items.Add("/")
        CmbOperator.Items.Add("Sisa")
        CmbOperator.Items.Add("Pangkat")
        CmbOperator.Items.Add("<>")
        CmbOperator.Items.Add("<")
        CmbOperator.Items.Add(">")
        CmbOperator.Items.Add("<=")
        CmbOperator.Items.Add(">=")
        CmbOperator.Items.Add("Like")
        CmbOperator.Items.Add("Not")
        CmbOperator.Items.Add("And")
        CmbOperator.Items.Add("Or")
        CmbOperator.Items.Add("Xor")
        CmbOperator.Items.Add("+p")
        CmbOperator.Items.Add("&")

    End Sub

    Private Sub BtnProses_Click(sender As Object, e As EventArgs) Handles BtnProses.Click
        Select Case CmbOperator.Text
            Case "+"
                TxtHasil.Text = Val(TxtNilai1.Text) + Val(TxtNilai2.Text)
            Case "-"
                TxtHasil.Text = Val(TxtNilai1.Text) - Val(TxtNilai2.Text)
            Case "x"
                TxtHasil.Text = Val(TxtNilai1.Text) * Val(TxtNilai2.Text)
            Case "/"
                TxtHasil.Text = Val(TxtNilai1.Text) / Val(TxtNilai2.Text)
            Case "Sisa"
                TxtHasil.Text = Val(TxtNilai1.Text) Mod Val(TxtNilai2.Text)
            Case "Pangkat"
                TxtHasil.Text = Val(TxtNilai1.Text) ^ Val(TxtNilai2.Text)
            Case "<>"
                TxtHasil.Text = TxtNilai1.Text <> TxtNilai2.Text
            Case "<"
                TxtHasil.Text = TxtNilai1.Text < TxtNilai2.Text
            Case ">"
                TxtHasil.Text = TxtNilai1.Text > TxtNilai2.Text
            Case "<="
                TxtHasil.Text = TxtNilai1.Text <= TxtNilai2.Text
            Case ">="
                TxtHasil.Text = TxtNilai1.Text >= TxtNilai2.Text
            Case "Like"
                TxtHasil.Text = TxtNilai1.Text Like TxtNilai2.Text
            Case "Not"
                TxtHasil.Text = Not TxtNilai1.Text = TxtNilai2.Text
            Case "And"
                TxtHasil.Text = TxtNilai1.Text = "INF" And TxtNilai2.Text = "INF"
            Case "Or"
                TxtHasil.Text = TxtNilai1.Text = "INF" Or TxtNilai2.Text = "INF"
            Case "Xor"
                TxtHasil.Text = TxtNilai1.Text = "INF" Xor TxtNilai2.Text = "INF"
            Case "+P"
                TxtHasil.Text = TxtNilai1.Text + TxtNilai2.Text
            Case "&"
                TxtHasil.Text = TxtNilai1.Text & TxtNilai2.Text
        End Select
    End Sub
End Class