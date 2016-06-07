Public Class Utilisateur
    Private id As Integer
    Private identifiant As String
    Private mdp As String
    Private nom As String
    Private prenom As String
    Private adresse As String
    Private telephone As Integer

    Public Sub New(ByVal identifiant As String, ByVal mdp As String, ByVal nom As String, ByVal prenom As String, ByVal adresse As String, ByVal telephone As Integer)
        Me.identifiant = identifiant
        Me.mdp = mdp
        Me.nom = nom
        Me.prenom = prenom
        Me.adresse = adresse
        Me.telephone = telephone
    End Sub

    Public Sub New(ByVal id As Integer, ByVal identifiant As String, ByVal mdp As String, ByVal nom As String, ByVal prenom As String, ByVal adresse As String, ByVal telephone As Integer)
        Me.id = id
        Me.identifiant = identifiant
        Me.mdp = mdp
        Me.nom = nom
        Me.prenom = prenom
        Me.adresse = adresse
        Me.telephone = telephone
    End Sub

    Public Function getId() As Integer
        Return id
    End Function
    Public Function getNom() As String
        Return nom
    End Function
    Public Function getIdentifiant() As String
        Return identifiant
    End Function
    Public Function getMDP() As String
        Return mdp
    End Function
    Public Function getPrenom() As String
        Return prenom
    End Function
    Public Function getAdresse() As String
        Return adresse
    End Function
    Public Function getTelephone() As String
        Return telephone
    End Function
    Public Sub setId(ByVal id As Integer)
        Me.id = id
    End Sub
End Class
