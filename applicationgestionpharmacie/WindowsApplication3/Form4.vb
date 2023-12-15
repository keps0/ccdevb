Public Class Form4
    Public tab(99) As produit
    Public Actualcase As Integer = 0


    Private Sub Labelidprod_Click(sender As Object, e As EventArgs) Handles Labelidprod.Click

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Labelqte_Click(sender As Object, e As EventArgs) Handles Labelqte.Click

    End Sub

    Private Sub Buttonajouterprod_Click(sender As Object, e As EventArgs) Handles Buttonajouterprod.Click
        Dim prod As New produit()
        prod.idProduit = TextBoxidprod.Text
        prod.NomProduit = TextBoxnomprod.Text
        prod.Prixproduit = TextBoxprixprod.Text
        prod.qteproduit = TextBoxqteprod.Text


        'affichage du récapitulatifs
        If prod.valider() Then

            tab(Actualcase) = prod
            Actualcase = Actualcase + 1
            'Form5.DataGridView1.Rows.Add(prod.idProduit, prod.NomProduit, prod.Prixproduit, prod.qteproduit)
            Label1.Text = ""
            Label2.Text = ""
            Label3.Text = ""
            Label4.Text = ""
            Label5.Text = ""
        Else
            Label5.Text = "Veuillez remplir les champs correctement"
        End If


    End Sub

    Private Sub Buttonrecapitulatifsprod_Click(sender As Object, e As EventArgs) Handles Buttonrecapitulatifsprod.Click
        For i As Integer = 0 To Actualcase - 1

            Form5.DataGridView1.Rows.Add(tab(i).idProduit, tab(i).NomProduit, tab(i).Prixproduit, tab(i).qteproduit)

        Next
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub Buttonmodifierprod_Click(sender As Object, e As EventArgs) Handles Buttonmodifierprod.Click
        Form5.DataGridView1.CurrentRow.Cells(0).Value = TextBoxidprod.Text
        Form5.DataGridView1.CurrentRow.Cells(1).Value = TextBoxnomprod.Text
        Form5.DataGridView1.CurrentRow.Cells(2).Value = TextBoxprixprod.Text
        Form5.DataGridView1.CurrentRow.Cells(3).Value = TextBoxqteprod.Text

        Form5.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBoxidprod.Clear()
        TextBoxnomprod.Clear()
        TextBoxprixprod.Clear()
        TextBoxqteprod.Clear()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ajout2_Click(sender As Object, e As EventArgs) Handles ajout2.Click
        Form5.DataGridView1.Rows.Add(tab(Actualcase - 1).idProduit, tab(Actualcase - 1).NomProduit, tab(Actualcase - 1).Prixproduit, tab(Actualcase - 1).qteproduit)
        Form5.Show()
        Me.Hide()
    End Sub
End Class