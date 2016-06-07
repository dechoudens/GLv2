Public Class frmEnregistrerHoraire
    Dim sceneCourante As Scene
    Private Sub frmEnregistrerHoraire_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sceneCourante = modGestionScene.getSceneCourante
        lblInserer.Text = "Insérer : " & modGestionScene.getArtisteCourant.getNom
        lblDansScene.Text = "Dans : " & sceneCourante.getNom
        modGestionScene.initHeure(sceneCourante.getHeureDebut.Hour, sceneCourante.getHeureFin.Hour, cboHDebut)

        Dim dates = modGestionScene.getDates
        Dim dateCourante = modGestionScene.getDateCourante
        Dim id = dates.IndexOf(dateCourante)
        For i = 0 To dates.Count - 1
            cboDates.Items.Add(dates.Item(i))
        Next
        cboDates.SelectedIndex = id
    End Sub

    Private Sub cmdAnnuler_Click(sender As Object, e As EventArgs) Handles cmdAnnuler.Click
        cboHDebut.Text = ""
        cboHFin.Text = ""
        Me.Close()
    End Sub

    Private Sub cboHDebut_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboHDebut.SelectedIndexChanged
        cboHFin.Items.Clear()
        cboHFin.Text = ""

        Dim hDebut As Integer = sceneCourante.getHeureDebut.Hour + cboHDebut.SelectedIndex + 1
        Dim hFin As Integer = sceneCourante.getHeureFin.Hour

        modGestionScene.initHeure(hDebut, hFin, cboHFin)

        cmdEnregistrer.Enabled = False
    End Sub

    Private Sub cboHFin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboHFin.SelectedIndexChanged
        If cboHFin.Text IsNot "" Then
            cmdEnregistrer.Enabled = True
        End If
    End Sub

    Private Sub cmdEnregistrer_Click(sender As Object, e As EventArgs) Handles cmdEnregistrer.Click
        Dim nbInserts = cboHFin.SelectedIndex
        Dim hDebut As Integer = sceneCourante.getHeureDebut.Hour + cboHDebut.SelectedIndex + 1
        Dim d = cboDates.SelectedItem
        For i = 0 To nbInserts
            Dim h = cboHDebut.Items(cboHDebut.SelectedIndex + i)
            Dim heure = Date.Parse(d & " " & h)
            Dim joue = New Joue(heure, modGestionScene.getArtisteCourant, modGestionScene.getSceneCourante)
            insertJoue(joue)
        Next
        frmPlanning.afficherHoraire()
        Me.Close()
    End Sub
End Class