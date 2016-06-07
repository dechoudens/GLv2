Public Class frmCreerArtiste
    Private Sub frmCreerArtiste_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initGenre()

        txtDescription.Text = ""
        txtNom.Text = ""
        cboGenre.ResetText()
    End Sub

    Public Sub initGenre()
        cboGenre.Items.Clear()
        For i = 0 To genres.Count - 1
            cboGenre.Items.Add(genres.Item(i).getNom)
        Next
    End Sub

    Private Sub cmdEnregistrer_Click(sender As Object, e As EventArgs) Handles cmdEnregistrer.Click
        Dim id = cboGenre.SelectedIndex
        Dim genre = genres.Item(id)

        Dim art = New Artiste(txtNom.Text, txtDescription.Text, genre)
        insererArtiste(art)
        artistes.Sort(New ArtisteComparer)
        frmProfilArtiste.initArtistes()

        Me.Close()
    End Sub


    Private Sub artisteValide(sender As Object, e As EventArgs) Handles txtNom.TextChanged, txtDescription.TextChanged, cboGenre.SelectedIndexChanged
        If txtNom.Text <> "" And cboGenre.SelectedIndex > 0 Then
            cmdEnregistrer.Enabled = True
        Else
            cmdEnregistrer.Enabled = False
        End If
    End Sub

    Private Sub effacerEnabled(sender As Object, e As EventArgs) Handles txtNom.TextChanged, txtDescription.TextChanged, cboGenre.SelectedIndexChanged
        If txtNom.Text <> "" Or txtDescription.Text <> "" Or cboGenre.SelectedIndex > 0 Then
            cmdEffacer.Enabled = True
        Else
            cmdEffacer.Enabled = False
        End If
    End Sub

    Private Sub cmdEffacer_Click(sender As Object, e As EventArgs) Handles cmdEffacer.Click
        txtNom.Text = ""
        txtDescription.Text = ""
        cboGenre.SelectedIndex = -1
    End Sub
End Class