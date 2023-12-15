Public Class Form3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Buttonenregistrement.Click
        Form4.show()
        Me.Hide()
        Form4.Buttonmodifierprod.Show()
        Form4.Buttonajouterprod.Show()
        Form4.Buttonrecapitulatifsprod.Show()
        Form4.Button1.Show()
        Form4.ajout2.Hide()
        Form4.Buttonmodifierprod.Enabled() = False
        Form4.ajout2.Hide()

    End Sub

    Private Sub Buttonconsultation_Click(sender As Object, e As EventArgs) Handles Buttonconsultation.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class