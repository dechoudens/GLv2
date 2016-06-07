Public Class Festival

    Private id As Integer
    Private nom As String
    Private location As String
    Private dateDebut As Date
    Private dateFin As Date
    Private utilisateur As Utilisateur

    Public Sub New(ByVal nom As String, ByVal location As String, ByVal dateDebut As Date, ByVal dateFin As Date, ByVal utilisateur As Utilisateur)
        Me.nom = nom
        Me.location = location
        Me.dateDebut = dateDebut
        Me.dateFin = dateFin
        Me.utilisateur = utilisateur
    End Sub

    Public Sub New(ByVal id As Integer, ByVal nom As String, ByVal location As String, ByVal dateDebut As Date, ByVal dateFin As Date, ByVal utilisateur As Utilisateur)
        Me.id = id
        Me.nom = nom
        Me.location = location
        Me.dateDebut = dateDebut
        Me.dateFin = dateFin
        Me.utilisateur = utilisateur
    End Sub

    Public Function getId() As Integer
        Return id
    End Function
    Public Function getNom() As String
        Return nom
    End Function
    Public Function getLocation() As String
        Return location
    End Function
    Public Function getDateDebut() As Date
        Return dateDebut
    End Function
    Public Function getDateFin() As Date
        Return dateFin
    End Function
    Public Function getUtilisateur() As Utilisateur
        Return utilisateur
    End Function
    Public Sub setId(ByVal id As Integer)
        Me.id = id
    End Sub


End Class
