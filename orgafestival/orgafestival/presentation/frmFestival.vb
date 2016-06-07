Public Class frmFestival

    Private Sub frmFestival_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal
    End Sub

    Private Sub cmdCommencer_Click(sender As Object, e As EventArgs) Handles cmdCommencer.Click
        Dim nom = txtNomFestival.Text
        Dim location = txtLocation.Text
        Dim dateDebut = Date.Parse(dtpDebut.Text)
        Dim dateFin = Date.Parse(dtpFin.Text)

        Dim festival = New Festival(nom, location, dateDebut, dateFin, utilisateurCourant)
        insererFestival(festival)

        loadFesUti()
        loadSceFes()
        frmGestionScene.Show()
        Me.Close()
    End Sub

    Private Sub txt_TextChanged(sender As Object, e As EventArgs) Handles txtNomFestival.TextChanged, txtLocation.TextChanged, dtpDebut.TextChanged, dtpFin.TextChanged
        If txtNomFestival.Text = "" Or txtLocation.Text = "" Then
            cmdCommencer.Enabled = False
        Else
            cmdCommencer.Enabled = True
        End If

        If Date.Compare(Date.Parse(dtpDebut.Text), Date.Parse(dtpFin.Text)) >= 0 Then

            cmdCommencer.Enabled = False
        End If
    End Sub

End Class