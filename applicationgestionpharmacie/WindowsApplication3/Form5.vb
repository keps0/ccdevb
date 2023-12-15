Public Class Form5

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim position = DataGridView1.CurrentRow.Index
        DataGridView1.Rows.RemoveAt(position)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim numProduit As Integer = DataGridView1.CurrentRow.Cells(0).Value
        Dim nomduProduit As String = DataGridView1.CurrentRow.Cells(1).Value
        Dim prixProduit As Integer = DataGridView1.CurrentRow.Cells(2).Value
        Dim qteProduit As Integer = DataGridView1.CurrentRow.Cells(3).Value
        Form4.TextBoxidprod.Text = numProduit
        Form4.TextBoxnomprod.Text = nomduProduit
        Form4.TextBoxprixprod.Text = prixProduit
        Form4.TextBoxqteprod.Text = qteProduit

        Form4.Show()
        Me.Hide()
        Form4.Buttonmodifierprod.Show()
        Form4.Buttonajouterprod.Show()
        Form4.Buttonrecapitulatifsprod.Show()
        Form4.Button1.Show()
        Form4.ajout2.Hide()

        Form4.Buttonajouterprod.Enabled() = False
        Form4.Buttonrecapitulatifsprod.Enabled() = False
        Form4.Buttonmodifierprod.Enabled() = True

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form4.Show()
        Form4.Buttonmodifierprod.Hide()
        Form4.Buttonajouterprod.Show()
        Form4.Buttonrecapitulatifsprod.Hide()
        Form4.Buttonajouterprod.Enabled() = True
        Form4.Button1.Hide()
        Form4.ajout2.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        For i As Integer = 0 To Form4.Actualcase - 1

            If Form4.tab(i).NomProduit = TextBoxsearch.Text Then
                Dim element As Integer = i
                DataGridView1.Rows.Add(Form4.tab(element).idProduit, Form4.tab(element).NomProduit, Form4.tab(element).Prixproduit, Form4.tab(element).qteproduit)
                Label3.Text = ""
            Else
                Label3.Text = "element non trouve"
                DataGridView1.Rows.Clear()
            End If
        Next

        If TextBoxsearch.Text = "" Then
            DataGridView1.Rows.Clear()
            Label3.Text = ""
            For i As Integer = 0 To Form4.Actualcase - 1

                DataGridView1.Rows.Add(Form4.tab(i).idProduit, Form4.tab(i).NomProduit, Form4.tab(i).Prixproduit, Form4.tab(i).qteproduit)

            Next
        End If
    End Sub

    Private Sub TextBoxsearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxsearch.TextChanged

    End Sub
End Class