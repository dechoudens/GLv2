Imports System.Data.OracleClient

Module Inserts

    Public Sub insererFestival(ByVal fes As Festival)
        Dim req As New OracleCommand()
        req.Connection = con
        req.Connection = con
        req.CommandText = "INSERT INTO vw_festivals VALUES(-1, :nom, :location, :dateDebut, :dateFin, :utilisateur)"
        req.CommandType = CommandType.Text
        req.Parameters.AddWithValue(":nom", fes.getNom)
        req.Parameters.AddWithValue(":location", fes.getLocation)
        req.Parameters.AddWithValue(":dateDebut", fes.getDateDebut)
        req.Parameters.AddWithValue(":dateFin", fes.getDateFin)
        req.Parameters.AddWithValue(":utilisateur", fes.getUtilisateur.getId)
        req.ExecuteNonQuery()

        Dim no As Integer = 0
        Dim sqlID = "SELECT MAX(Numero) as ""index"" FROM vw_festivals"
        Dim reqID As New OracleCommand(sqlID, con)
        Dim row As OracleDataReader = reqID.ExecuteReader
        While row.Read()
            fes.setId(row("index"))
        End While
        festivals.Add(fes)
    End Sub


    Public Sub insererScene(ByVal sce As Scene)
        Dim req As New OracleCommand()
        req.Connection = con
        req.CommandText = "INSERT INTO vw_ObjScene VALUES(-1, :nom, :description, :capacite, :dimensionX, :dimensionY, to_date(:heureDebut,'dd.mm.yyyy hh24:mi:ss'), to_date(:heureFin,'dd.mm.yyyy hh24:mi:ss') , :festival)"
        req.CommandType = CommandType.Text
        req.Parameters.AddWithValue(":nom", sce.getNom)
        req.Parameters.AddWithValue(":description", sce.getDescription)
        req.Parameters.AddWithValue(":capacite", sce.getCapacite)
        req.Parameters.AddWithValue(":dimensionX", sce.getDimensionX)
        req.Parameters.AddWithValue(":dimensionY", sce.getDimensionX)
        req.Parameters.AddWithValue(":heureDebut", sce.getHeureDebut)
        req.Parameters.AddWithValue(":heureFin", sce.getHeureFin)
        req.Parameters.AddWithValue(":festival", sce.getFestival.getId)
        req.ExecuteNonQuery()

        Dim no As Integer = 0
        Dim sqlID = "SELECT MAX(Numero) as ""index"" FROM vw_ObjScene"
        Dim reqID As New OracleCommand(sqlID, con)
        Dim row As OracleDataReader = reqID.ExecuteReader
        While row.Read()
            sce.setId(row("index"))
        End While
        scenes.Add(sce)
    End Sub

    Public Sub insererArtiste(ByVal art As Artiste)
        Dim req As New OracleCommand()
        req.Connection = con
        req.CommandText = "INSERT INTO vw_artistes VALUES(-1, :nom, :biographie, :genre )"
        req.CommandType = CommandType.Text
        req.Parameters.AddWithValue(":nom", art.getNom)
        req.Parameters.AddWithValue(":biographie", art.getBiographie)
        req.Parameters.AddWithValue(":genre", art.getGenre.getId)
        req.ExecuteNonQuery()
        Dim no As Integer = 0
        Dim sqlID = "SELECT MAX(Numero) as ""index"" FROM vw_artistes"
        Dim reqID As New OracleCommand(sqlID, con)
        Dim row As OracleDataReader = reqID.ExecuteReader
        While row.Read()
            art.setId(row("index"))
        End While
        artistes.Add(art)
    End Sub

    Public Sub insererUtilisateur(ByVal uti As Utilisateur)

        Dim req As New OracleCommand()
        req.Connection = con
        req.CommandText = "INSERT INTO vw_utilisateurs VALUES(-1, :identifiant, :mdp, :nom, :prenom, :adresse, :telephone)"
        req.CommandType = CommandType.Text
        req.Parameters.AddWithValue(":identifiant", uti.getIdentifiant)
        req.Parameters.AddWithValue(":mdp", uti.getMDP)
        req.Parameters.AddWithValue(":nom", uti.getNom)
        req.Parameters.AddWithValue(":prenom", uti.getPrenom)
        req.Parameters.AddWithValue(":adresse", uti.getAdresse)
        req.Parameters.AddWithValue(":telephone", uti.getTelephone)

        req.ExecuteNonQuery()


        Dim no As Integer = 0
        Dim sqlID = "SELECT MAX(Numero) as ""index"" FROM vw_utilisateurs"
        Dim reqID As New OracleCommand(sqlID, con)
        Dim row As OracleDataReader = reqID.ExecuteReader
        While row.Read()
            uti.setId(row("index"))
        End While
        utilisateurs.Add(uti)
    End Sub

    Public Sub insertJoue(ByVal joue As Joue)
        Dim req As New OracleCommand()
        req.Connection = con
        req.CommandText = "INSERT INTO vw_joue VALUES(-1, :heure, :artiste, :scene)"
        req.CommandType = CommandType.Text
        req.Parameters.AddWithValue(":heure", joue.getHeure)
        req.Parameters.AddWithValue(":artiste", joue.getArtiste.getId)
        req.Parameters.AddWithValue(":scene", joue.getScene.getId)

        req.ExecuteNonQuery()

        Dim no As Integer = 0
        Dim sqlID = "SELECT MAX(Numero) as ""index"" FROM vw_joue"
        Dim reqID As New OracleCommand(sqlID, con)
        Dim row As OracleDataReader = reqID.ExecuteReader
        While row.Read()
            joue.setId(row("index"))
        End While
        joues.Add(joue)
    End Sub

    Public Sub insertParticipe(ByVal art As Artiste, ByVal fes As Festival)

        Dim req As New OracleCommand()
        req.Connection = con
        req.CommandText = "INSERT INTO org_participe VALUES(:artiste, :festival)"
        req.CommandType = CommandType.Text
        req.Parameters.AddWithValue(":artiste", art.getId)
        req.Parameters.AddWithValue(":festival", fes.getId)

        req.ExecuteNonQuery()
    End Sub

    Public Sub insertAdministre(ByVal uti As Utilisateur, ByVal fes As Festival)
        Dim req As New OracleCommand()
        req.Connection = con
        req.CommandText = "INSERT INTO org_administre VALUES(:utilisateur, :festival)"
        req.CommandType = CommandType.Text
        req.Parameters.AddWithValue(":utilisateur", uti.getId)
        req.Parameters.AddWithValue(":festival", fes.getId)
        req.ExecuteNonQuery()
    End Sub
End Module
