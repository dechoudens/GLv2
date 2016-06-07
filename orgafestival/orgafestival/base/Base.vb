Imports System.Data.OracleClient
Module Base
    Public festivals As New List(Of Festival)
    Public utilisateurs As New List(Of Utilisateur)
    Public genres As New List(Of Genre)
    Public artistes As New List(Of Artiste)
    Public scenes As New List(Of Scene)
    Public joues As New List(Of Joue)
    Public horaires As New List(Of Horaire)

    Dim bdd As String = "Data Source=xe; User Id=OrgaFestival_user; Password=OrgaFestival_user;"
    'Dim bdd As String = "Data Source=HEGLOCAL; User Id=OrgaFestival_user; Password=OrgaFestival_user;"

    Public con As New OracleConnection(bdd)

    Public Sub connexionBDD()
        con.Open()
    End Sub

    Public Sub fermerBDD()
        con.Close()
    End Sub

    'DAO-----------------------------------------------------------------------------------------------
    Public Sub recupererDonnees()
        recupererUtilisateurs()
        recupererFestivals()
        recupererGenres()
        recupererArtistes()
        recupererScene()
        recupereHoraire()
    End Sub

End Module
