Public Class Joue
    Private id As Integer
    Private heure As Date
    Private art As Artiste
    Private sce As Scene

    Public Sub New(ByVal heure As Date, ByVal art As Artiste, ByVal sce As Scene)
        Me.heure = heure
        Me.art = art
        Me.sce = sce
    End Sub

    Public Sub New(ByVal id As Integer, ByVal heure As Date, ByVal art As Artiste, ByVal sce As Scene)
        Me.id = id
        Me.heure = heure
        Me.art = art
        Me.sce = sce
    End Sub

    Public Function getId() As Integer
        Return id
    End Function
    Public Function getHeure() As Date
        Return heure
    End Function
    Public Function getArtiste() As Artiste
        Return art
    End Function
    Public Function getScene() As Scene
        Return sce
    End Function

    Public Sub setId(ByVal id As Integer)
        Me.id = id
    End Sub

End Class
