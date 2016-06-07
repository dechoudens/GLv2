Public Class Artiste

    Private id As Integer
    Private nom As String
    Private biographie As String
    Private genre As Genre

    Public Sub New(ByVal nom As String, ByVal biographie As String, ByVal genre As Genre)
        Me.nom = nom
        Me.biographie = biographie
        Me.genre = genre
    End Sub

    Public Sub New(ByVal Id As Integer, ByVal nom As String, ByVal biographie As String, ByVal genre As Genre)
        Me.id = Id
        Me.nom = nom
        Me.biographie = biographie
        Me.genre = genre
    End Sub

    Public Function getId() As Integer
        Return id
    End Function
    Public Function getNom() As String
        Return nom
    End Function

    Public Function getBiographie() As String
        Return biographie
    End Function
    Public Function getGenre() As Genre
        Return genre
    End Function

    Public Sub setId(ByVal id As Integer)
        Me.id = id
    End Sub
    Public Sub setNom(ByVal nom As String)
        Me.nom = nom
    End Sub
    Public Sub setBiographie(ByVal biographie As String)
        Me.biographie = biographie
    End Sub
    Public Sub setGenre(ByVal genre As Genre)
        Me.genre = genre
    End Sub

End Class
