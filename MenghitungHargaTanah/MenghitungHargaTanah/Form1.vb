Public Class Form1
    Private Sub lebar_TextChanged(sender As Object, e As EventArgs) Handles lebar.TextChanged

        luas.Text = Val(panjang.Text) * Val(lebar.Text)


        If Val(jarak.Text) <= 1 Then
            harga.Text = 500
        ElseIf Val(jarak.Text) > 1 And Val(jarak.Text) <= 5 Then
            harga.Text = 450
        ElseIf Val(jarak.Text) > 5 And Val(jarak.Text) <= 10 Then
            harga.Text = 400
        Else
            harga.Text = 350
        End If
        harga.Text *= Val(luas.Text)


        If Val(harga.Text) < 20000000 Then
            kategori.Text = "Murah"
        Else
            kategori.Text = "Mahal"
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        panjang.Text = ""
        lebar.Text = ""
        luas.Text = ""
        jarak.Text = ""
        harga.Text = ""
        kategori.Text = ""
    End Sub
End Class
