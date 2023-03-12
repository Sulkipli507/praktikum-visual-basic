Public Class Form1
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dim tutup As String
        tutup = MessageBox.Show("Anda yakin tutup form ini ?", "Lokal Variabel", MessageBoxButtons.YesNo,
        MessageBoxIcon.Question)
        If tutup = MsgBoxResult.Yes Then
            End
        Else
        End If
    End Sub
End Class
