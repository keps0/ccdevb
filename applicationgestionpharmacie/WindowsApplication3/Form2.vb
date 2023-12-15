Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        form3.show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Close()
        Form3.Close()
        Me.Close()
        Form4.Close()
        Form5.Close()
    End Sub
End Class