Public Class frmAjouterArtisteScene
    Dim artisteDispo As New List(Of Artiste)

    Private Sub frmAjouterArtiste_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        artisteDispo.Clear()
        lblTitre.Text = "Scène : " + modGestionScene.getSceneCourante().getNom
        lstArtistesDispo.Items.Clear()

        Dim artisteScene = modGestionScene.getArtisteScene()
        For Each artiste In artistes
            If Not artisteScene.Contains(artiste) Then
                artisteDispo.Add(artiste)
            End If
        Next

        For i = 0 To artisteDispo.Count - 1
            lstArtistesDispo.Items.Add(artisteDispo.Item(i).getNom)
        Next
    End Sub

    Private Sub lstArtistesDispo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstArtistesDispo.SelectedIndexChanged
        cmdAjouter.Enabled = True
    End Sub

    Private Sub cmdAjouter_Click(sender As Object, e As EventArgs) Handles cmdAjouter.Click
        Dim id = lstArtistesDispo.SelectedIndex
        Dim art = artisteDispo.Item(id)
        modGestionScene.setArtisteCourante(art)
        frmEnregistrerHoraire.ShowDialog()
    End Sub
End Class