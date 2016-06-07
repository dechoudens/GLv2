Public Class frmAjouterScene
    Private Sub cmdEffacer_Click(sender As Object, e As EventArgs) Handles cmdEffacer.Click
        txtCapacite.Text = ""
        txtDescription.Text = ""
        txtDimension2.Text = ""
        txtNom.Text = ""
        txtDimension1.Text = ""
        cmdEffacer.Enabled = False

        modGestionScene.initHeure(0, 23, cboHeureDebut)
    End Sub

    Private Sub cmdEnregistrer_Click(sender As Object, e As EventArgs) Handles cmdEnregistrer.Click
        Dim ddate = cboHeureDebut.SelectedItem
        Dim dateDebut As Date = Date.Parse(ddate)

        Dim fdate = cboHeureFin.SelectedItem
        Dim dateFin As Date = Date.Parse(fdate)

        Dim scene As New Scene(txtNom.Text, txtDescription.Text, txtCapacite.Text, txtDimension1.Text, txtDimension2.Text, dateDebut, fdate, festivalCourant)
        insererScene(scene)
        scenes.Sort(New SceneComparer())
        loadSceFes()
        frmGestionScene.initScene()

        Me.Close()
    End Sub

    Private Sub txtNom_TextChanged(sender As Object, e As EventArgs) Handles txtNom.TextChanged
        If txtNom.Text <> "" Then
            cmdEnregistrer.Enabled = True
        Else
            cmdEnregistrer.Enabled = False
        End If
    End Sub

    Private Sub txtBox_TextChanged(sender As Object, e As EventArgs) Handles txtNom.TextChanged, txtDimension2.TextChanged, txtDimension1.TextChanged, txtDescription.TextChanged, txtCapacite.TextChanged
        If txtNom.Text <> "" Or txtCapacite.Text <> "" Or txtDescription.Text <> "" Or txtDimension1.Text <> "" Or txtDimension2.Text <> "" Then
            cmdEffacer.Enabled = True
        End If

    End Sub

    Private Sub frmAjouterScene_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCapacite.Text = ""
        txtDescription.Text = ""
        txtDimension2.Text = ""
        txtNom.Text = ""
        txtDimension1.Text = ""
        modGestionScene.initHeure(0, 23, cboHeureDebut)
    End Sub


    Private Sub cboHeureDebut_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboHeureDebut.SelectedIndexChanged
        cboHeureFin.Items.Clear()

        Dim hDebut As Integer = cboHeureDebut.SelectedIndex

        modGestionScene.initHeure(hDebut + 1, 23, cboHeureFin)
    End Sub
End Class