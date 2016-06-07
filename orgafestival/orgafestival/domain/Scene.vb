Public Class Scene


    Private id As Integer
    Private nom As String
    Private desciption As String
    Private capacite As Integer
    Private dimensionX As Integer
    Private dimensionY As Integer
    Private heureDebut As Date
    Private heureFin As Date
    Private festival As Festival

    Public Sub New(ByVal nom As String, ByVal description As String, ByVal capacite As Integer, ByVal dimensionX As Integer, ByVal dimensionY As Integer, ByVal heureDebut As Date, ByVal heureFin As Date, ByVal festival As Festival)
        Me.nom = nom
        Me.desciption = description
        Me.capacite = capacite
        Me.dimensionX = dimensionX
        Me.dimensionY = dimensionY
        Me.heureDebut = heureDebut
        Me.heureFin = heureFin
        Me.festival = festival
    End Sub

    Public Sub New(ByVal id As Integer, ByVal nom As String, ByVal description As String, ByVal capacite As Integer, ByVal dimensionX As Integer, ByVal dimensionY As Integer, ByVal heureDebut As Date, ByVal heureFin As Date, ByVal festival As Festival)
        Me.id = id
        Me.nom = nom
        Me.desciption = description
        Me.capacite = capacite
        Me.dimensionX = dimensionX
        Me.dimensionY = dimensionY
        Me.heureDebut = heureDebut
        Me.heureFin = heureFin
        Me.festival = festival
    End Sub

    Public Function getId() As Integer
        Return id
    End Function
    Public Function getNom() As String
        Return nom
    End Function

    Public Function getDescription() As String
        Return desciption
    End Function
    Public Function getCapacite() As String
        Return capacite
    End Function
    Public Function getDimensionX() As String
        Return dimensionX
    End Function
    Public Function getDimensionY() As String
        Return dimensionY
    End Function
    Public Function getHeureDebut() As Date
        Return heureDebut
    End Function
    Public Function getHeureFin() As Date
        Return heureFin
    End Function
    Public Function getFestival() As Festival
        Return festival
    End Function

    Public Sub setId(ByVal id As Integer)
        Me.id = id
    End Sub
    Public Sub setNom(ByVal nom As String)
        Me.nom = nom
    End Sub
    Public Sub setDescription(ByVal description As String)
        Me.desciption = description
    End Sub
    Public Sub setCapacite(ByVal capacite As Integer)
        Me.capacite = capacite
    End Sub
    Public Sub setDimensionX(ByVal dimensionX As Integer)
        Me.dimensionX = dimensionX
    End Sub
    Public Sub setdimensionY(ByVal dimensionY As Integer)
        Me.dimensionY = dimensionY
    End Sub

End Class
