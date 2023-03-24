Public Class Form1
    Private Sub tahunLahir_TextChanged(sender As Object, e As EventArgs) Handles tahunLahir.TextChanged

        'inisialisai variabel tahun lair dan tahun sekarang
        Dim thlahir As Integer
        Dim thSekarang As Integer = DateTime.Now.Year

        'mengecek apakah data yang dimasukkan dapat diubah menjadi integer
        If Integer.TryParse(tahunLahir.Text, thlahir) Then
            Dim umur As Integer = thSekarang - thlahir
            usia.Text = umur
            If umur < 3 Then
                kategori.Text = "Balita"
            ElseIf umur >= 3 AndAlso umur < 13 Then
                kategori.Text = "Anak-anak"
            ElseIf umur >= 13 AndAlso umur < 20 Then
                kategori.Text = "Remaja"
            ElseIf umur >= 20 AndAlso umur < 60 Then
                kategori.Text = "Dewasa"
            Else
                kategori.Text = "Lansia"
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        nama.Text = ""
        tahunLahir.Text = ""
        usia.Text = ""
        kategori.Text = ""
    End Sub
End Class
