Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hasil.Text = Val(bil1.Text) + Val(bil2.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Hasil.Text = Val(bil1.Text) - Val(bil2.Text)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Hasil.Text = Val(bil1.Text) * Val(bil2.Text)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Hasil.Text = Val(bil1.Text) / Val(bil2.Text)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        bil1.Text = ""
        bil2.Text = ""
        Hasil.Text = ""
    End Sub
End Class
