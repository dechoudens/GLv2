Public Class frmProfilArtiste

    Dim artisteCourant As Artiste

    Private Sub frmProfilArtiste_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
        initArtistes()
        initGenre()

    End Sub

    Public Sub initGenre()
        cboGenre.Items.Clear()
        For i = 0 To genres.Count - 1
            cboGenre.Items.Add(genres.Item(i).getNom)
        Next
    End Sub

    Public Sub initArtistes()
        lstArtistesDispo.Items.Clear()

        For Each artiste In artistes
            lstArtistesDispo.Items.Add(artiste.getNom)
        Next
    End Sub

    Public Sub setCurrentArtiste(ByVal art As Artiste)
        artisteCourant = art
    End Sub

    Private Sub cmdModifierPlanning_Click(sender As Object, e As EventArgs) Handles cmdModifier.Click


        txtDescription.Enabled = True
        cboGenre.Enabled = True
        txtNom.Enabled = True
        txtDescription.ReadOnly = False
        txtNom.ReadOnly = False

        cmdEnregistrer.Enabled = True
        cmdEnregistrer.Visible = True

        cmdModifier.Enabled = False
        cmdModifier.Visible = False

        lstArtistesDispo.Enabled = False
    End Sub

    Private Sub cmdEnregistrer_Click(sender As Object, e As EventArgs) Handles cmdEnregistrer.Click
        cmdEnregistrer.Enabled = False
        cmdEnregistrer.Visible = False

        cmdModifier.Enabled = True
        cmdModifier.Visible = True
        lstArtistesDispo.Enabled = True
        txtDescription.Enabled = False
        cboGenre.Enabled = False
        txtNom.Enabled = False
        txtDescription.ReadOnly = True
        txtNom.ReadOnly = True

        artisteCourant.setNom(txtNom.Text)
        artisteCourant.setBiographie(txtDescription.Text)
        Dim id = cboGenre.SelectedIndex
        artisteCourant.setGenre(genres.Item(id))

        updateArtiste(artisteCourant)
        initArtistes()
    End Sub



    Private Sub lstArtistesDispo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstArtistesDispo.SelectedIndexChanged
        cmdModifier.Enabled = True
        cmdModifier.Visible = True

        Dim index = lstArtistesDispo.SelectedIndex

        If index <> -1 Then
            artisteCourant = artistes.Item(index)
            txtDescription.Text = artisteCourant.getBiographie
            Dim id = genres.IndexOf(artisteCourant.getGenre)
            cboGenre.SelectedIndex = id
            txtNom.Text = artisteCourant.getNom
        End If

    End Sub

    Private Sub cmdCréer_Click(sender As Object, e As EventArgs) Handles cmdCréer.Click
        frmCreerArtiste.ShowDialog()
    End Sub
End Class