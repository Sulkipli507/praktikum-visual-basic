Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Public Property TextBox1 As Object

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox1.Focus()

    End Sub
End Class
