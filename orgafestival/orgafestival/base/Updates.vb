Imports System.Data.OracleClient

Module updates
    Public Sub updateScene(ByVal sce As Scene)
        Dim req As New OracleCommand()
        req.Connection = con
        req.CommandText = "UPDATE vw_ObjScene SET Nom = :Nom, DescriptionScene = :Description, Capacite = :Capacite, DimensionX = :DimensionX, DimensionY = :DimensionY, HeureDebut = :HeureDebut, HeureFin = :HeureFin WHERE Numero = :Numero"
        req.CommandType = CommandType.Text
        req.Parameters.AddWithValue(":Nom", sce.getNom)
        req.Parameters.AddWithValue(":Description", sce.getDescription)
        req.Parameters.AddWithValue(":Capacite", sce.getCapacite)
        req.Parameters.AddWithValue(":DimensionX", sce.getDimensionX)
        req.Parameters.AddWithValue(":DimensionY", sce.getDimensionY)
        req.Parameters.AddWithValue(":HeureDebut", sce.getHeureDebut)
        req.Parameters.AddWithValue(":HeureFin", sce.getHeureFin)
        req.Parameters.AddWithValue(":Numero", sce.getId)
        req.ExecuteNonQuery()
    End Sub

    Public Sub updateArtiste(ByVal art As Artiste)
        Dim req As New OracleCommand()
        req.Connection = con
        req.CommandText = "UPDATE vw_artistes SET Nom = :Nom, biographie = :biographie, Genre = :Genre WHERE Numero = :Numero"
        req.CommandType = CommandType.Text
        req.Parameters.AddWithValue(":Nom", art.getNom)
        req.Parameters.AddWithValue(":biographie", art.getBiographie)
        req.Parameters.AddWithValue(":Genre", art.getGenre.getId)
        req.Parameters.AddWithValue(":Numero", art.getId)
        req.ExecuteNonQuery()
    End Sub

End Module
