
Public Class produit
    Public idProduit As String
    Public NomProduit As String
    Public Prixproduit As String
    Public prixconverti As Integer
    Public qteproduit As String
    Public qteconvert As Integer
    Public errorid As String
    Public errornom As String
    Public errorprix As String
    Public errorqte As String



    Public Function valider() As Boolean
        Dim state As Boolean = True

        'Vérification de l'id produit
        If Not IsNumeric(Me.idProduit) Or idProduit = "" Then
            state = False
            errorid = "cet identifiant n'est pas un nombre"
            Form4.Label1.Text = errorid
        Else
            Form4.Label1.Text = ""
        End If

        'vérification du nom du produit
        If IsNumeric(Me.NomProduit) Or NomProduit = "" Then
            state = False
            errornom = "le nom est incorrect"
            Form4.Label2.Text = errornom
        Else
            Form4.Label2.Text = ""
        End If

        'vérification du prix
        If Not IsNumeric(Prixproduit) Then
            state = False
            errorprix = "le prix est incorrect"
            Form4.Label3.Text = errorprix
        Else
            Integer.TryParse(Prixproduit, prixconverti)
            If prixconverti <= 0 Then
                state = False
                errorprix = "le prix est incorrect"
                Form4.Label3.Text = errorprix
            Else
                Form4.Label3.Text = ""
            End If
        End If

        'vérification de la quantité
        If Not IsNumeric(Prixproduit) Then
            state = False
            errorqte = "la quantité est incorrecte"
            Form4.Label4.Text = errorqte
        Else
            Integer.TryParse(qteproduit, qteconvert)
            If qteconvert <= 0 Or qteproduit = "" Then
                state = False
                errorqte = "la quantité est incorrecte"
                Form4.Label4.Text = errorqte
            Else
                Form4.Label4.Text = ""
            End If
        End If
        Return state
    End Function

End Class
