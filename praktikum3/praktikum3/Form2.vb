Public Class Form2
    Private tutup As DialogResult

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Class Form2
        Dim tutup As String

        Public Overrides Function Equals(obj As Object) As Boolean
            Dim form = TryCast(obj, Form2)
            Return form IsNot Nothing AndAlso
                   tutup = form.tutup
        End Function
    End Class

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        tutup = MessageBox.Show("Anda yakin tutup form ini ?", "Global Variabel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If tutup = MsgBoxResult.Yes Then
            End
        Else
        End If
    End Sub
End Class
