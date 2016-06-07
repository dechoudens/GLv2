Public Class Genre
    Private id As Integer
    Private nom As String

    Public Sub New(ByVal nom As String)
        Me.id = id
        Me.nom = nom
    End Sub

    Public Sub New(ByVal Id As Integer, ByVal nom As String)
        Me.id = Id
        Me.nom = nom
    End Sub

    Public Function getId() As Integer
        Return id
    End Function
    Public Function getNom() As String
        Return nom
    End Function
    Public Sub setId(ByVal id As Integer)
        Me.id = id
    End Sub

End Class
