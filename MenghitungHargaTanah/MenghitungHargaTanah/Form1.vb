Public Class Form1
    Private Sub lebar_TextChanged(sender As Object, e As EventArgs) Handles lebar.TextChanged
        luas.Text = Val(panjang.Text) * Val(lebar.Text)

        If Val(jarak.Text) <= 1 Then
            harga.Text = Val(luas.Text) * 500000
        ElseIf Val(jarak.Text) > 1 And Val(jarak.Text) <= 5 Then
            harga.Text = Val(luas.Text) * 450000
        ElseIf Val(jarak.Text) > 5 And Val(jarak.Text) <= 10 Then
            harga.Text = Val(luas.Text) * 400000
        Else
            harga.Text = Val(luas.Text) * 350000
        End If


        If Val(harga.Text) < 100000000 Then
            kategori.Text = "Murah"
        Else
            kategori.Text = "Mahal"
        End If
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        jarak.Text = ""
        panjang.Text = ""
        lebar.Text = ""
        luas.Text = ""
        harga.Text = ""
        kategori.Text = ""
    End Sub

    Private Sub close_Click(sender As Object, e As EventArgs) Handles close.Click
        End
    End Sub
End Class
