Imports OrgaFestival

Public Class SceneComparer
    Implements IComparer(Of Scene)

    Public Function Compare(x As Scene, y As Scene) As Integer Implements IComparer(Of Scene).Compare
        Return String.Compare(x.getNom, y.getNom)
    End Function

End Class
