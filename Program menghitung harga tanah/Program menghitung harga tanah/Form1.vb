Public Class Form1
    Private Sub jarak_TextChanged(sender As Object, e As EventArgs) Handles jarak.TextChanged


    End Sub

    Private Sub hapus_Click(sender As Object, e As EventArgs) Handles hapus.Click
        panjang.Text = ""
        lebar.Text = ""
        luas.Text = ""
        jarak.Text = ""
        harga.Text = ""
        kategori.Text = ""
    End Sub

    Private Sub lebar_TextChanged(sender As Object, e As EventArgs) Handles lebar.TextChanged
        luas.Text = Val(panjang.Text) * Val(lebar.Text)

        If Val(jarak.Text) <= 1 Then
            harga.Text = 500000
        ElseIf Val(jarak.Text) > 1 And Val(jarak.Text) <= 5 Then
            harga.Text = 450000
        ElseIf Val(jarak.Text) > 5 And Val(jarak.Text) <= 10 Then
            harga.Text = 400000
        Else
            harga.Text = 350000
        End If
        harga.Text *= Val(luas.Text)

        If Val(harga.Text) < 100000000 Then
            kategori.Text = "Murah"
        Else
            kategori.Text = "Mahal"
        End If
    End Sub
End Class
