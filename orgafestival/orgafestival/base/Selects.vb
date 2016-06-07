Imports System.Data.OracleClient

Module Selects

    Public Sub recupererFestivals()
        Dim uti_festival As Utilisateur

        Dim sql As String = "SELECT * FROM vw_festivals ORDER BY numero"
        Dim req As New OracleCommand(sql, con)
        Dim row As OracleDataReader = req.ExecuteReader
        While row.Read()
            uti_festival = utilisateurs.Item(row("utilisateur") - 1)
            Dim festival As Festival = New Festival(row("Numero"), row("Nom"), row("Location"), row("dateDebut"), row("dateFin"), uti_festival)
            festivals.Add(festival)
        End While
    End Sub

    Public Sub recupererUtilisateurs()
        Dim sql As String = "SELECT * FROM vw_utilisateurs ORDER BY numero"
        Dim req As New OracleCommand(sql, con)
        Dim row As OracleDataReader = req.ExecuteReader
        While row.Read()
            Dim utilistateur As Utilisateur = New Utilisateur(row("Numero"), row("Identifiant"), row("MDP"), row("Nom"), row("Prenom"), row("Adresse"), row("Telephone"))
            utilisateurs.Add(utilistateur)
        End While
    End Sub

    Public Sub recupererGenres()
        Dim sql As String = "SELECT * FROM vw_genres"
        Dim req As New OracleCommand(sql, con)
        Dim row As OracleDataReader = req.ExecuteReader
        While row.Read()
            Dim genre As Genre = New Genre(row("Numero"), row("Nom"))
            genres.Add(genre)
        End While
    End Sub

    Public Sub recupererArtistes()
        Dim genre_artiste As Genre

        Dim sql As String = "SELECT * FROM vw_artistes"
        Dim req As New OracleCommand(sql, con)
        Dim row As OracleDataReader = req.ExecuteReader
        While row.Read()
            genre_artiste = genres.Item(row("Genre") - 1)
            Dim artiste As Artiste = New Artiste(row("Numero"), row("Nom"), row("Biographie"), genre_artiste)
            artistes.Add(artiste)
        End While
    End Sub

    Public Sub recupererScene()
        Dim festival_scene As Festival
        Dim sql As String = "SELECT * FROM vw_ObjScene"
        Dim req As New OracleCommand(sql, con)
        Dim row As OracleDataReader = req.ExecuteReader
        While row.Read()
            festival_scene = festivals.Item(row("Festival") - 1)
            Dim scene As Scene = New Scene(row("Numero"), row("Nom"), row("DescriptionScene"), row("Capacite"), row("DimensionX"), row("DimensionY"), row("HeureDebut"), row("HeureFin"), festival_scene)
            scenes.Add(scene)
        End While
    End Sub

    Public Sub recupereHoraire()
        Dim joue_artiste As Artiste
        Dim joue_scene As Scene

        Dim sql As String = "SELECT * FROM vw_joue"
        Dim req As New OracleCommand(sql, con)
        Dim row As OracleDataReader = req.ExecuteReader
        While row.Read()
            joue_artiste = artistes.Item(row("Artiste") - 1)
            joue_scene = scenes.Item(row("Scene") - 1)
            Dim joue = New Joue(row("Numero"), row("Heure"), joue_artiste, joue_scene)
            joues.Add(joue)
        End While
    End Sub

End Module
