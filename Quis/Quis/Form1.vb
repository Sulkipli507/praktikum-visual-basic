Public Class Form1

    Private Sub nilaiUas_TextChanged(sender As Object, e As EventArgs) Handles nilaiUas.TextChanged
        Dim nQuiz, nUts, nUas, hasil As Integer

        nQuiz = nilaiQuiz.Text
        nUts = nilaiUts.Text
        nUas = nilaiUas.Text

        hasil = (nQuiz * 20%) + (nUts * 20%) + (nUas * 20%)

        nilaiAngka.Text = hasil

    End Sub
End Class
