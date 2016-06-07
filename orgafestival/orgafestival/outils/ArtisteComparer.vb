Imports OrgaFestival

Public Class ArtisteComparer
    Implements IComparer(Of Artiste)

    Public Function Compare(x As Artiste, y As Artiste) As Integer Implements IComparer(Of Artiste).Compare
        Return String.Compare(x.getNom, y.getNom)
    End Function

End Class
