Public Class Horaire
    Private heures As New List(Of Date)
    Private art As Artiste

    Public Sub New(ByVal heures As List(Of Date), ByVal art As Artiste)
        Me.heures = heures
        Me.art = art
    End Sub

    Public Function getHeures() As List(Of Date)
        Return heures
    End Function

    Public Function getArtiste() As Artiste
        Return art
    End Function

End Class
