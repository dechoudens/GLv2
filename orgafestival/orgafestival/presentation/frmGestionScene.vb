Public Class frmGestionScene


    Private Sub frmGestionScene_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = frmPrincipal


        lblTitre.Text = "Festival: " + festivalCourant.getNom

        initScene()
        cbxScene.SelectedIndex = 0
    End Sub



    Public Sub initScene()
        cbxScene.Items.Clear()
        For i = 0 To scenesFes.Count - 1
            cbxScene.Items.Add(scenesFes.Item(i).getNom)
        Next

        modGestionScene.setSceneCourante(scenesFes.Item(0))
        cbxScene.Text = ""
    End Sub

    Private Sub cmdAjouter_Click(sender As Object, e As EventArgs)
        frmAjouterScene.ShowDialog()
    End Sub

    'Recupere les artistes de la scene courante


    'Recupere les horaires de chaque artiste -> horaires


    Private Sub cbxScene_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxScene.SelectedIndexChanged
        If cbxScene.SelectedItem = "" Then
            cmdPlanning.Enabled = False
        Else
            cmdPlanning.Enabled = True
        End If

        changedScene()
    End Sub

    Public Sub changedScene()
        Dim id As Integer = cbxScene.SelectedIndex
        If id >= 0 Then
            Dim sceneCourante = scenesFes.Item(id)
            modGestionScene.setSceneCourante(sceneCourante)

            cmdCéerScene.Enabled = True
            cmdModifierScene.Enabled = True

            txtNom.Enabled = True
            txtCapacite.Enabled = True
            txtDescription.Enabled = True
            txtDimension1.Enabled = True
            txtDimension2.Enabled = True

            txtNom.Text = sceneCourante.getNom()
            txtCapacite.Text = sceneCourante.getCapacite()
            txtDescription.Text = sceneCourante.getDescription()
            txtDimension1.Text = sceneCourante.getDimensionX()
            txtDimension2.Text = sceneCourante.getDimensionY()
        End If

    End Sub


    Private Sub cmdAjouterScène_Click(sender As Object, e As EventArgs) Handles cmdCéerScene.Click
        frmAjouterScene.ShowDialog()
    End Sub



    Private Sub cmdModifier_Click(sender As Object, e As EventArgs) Handles cmdModifierScene.Click
        cbxScene.Enabled = False
        cmdModifierScene.Visible = False
        cmdModifierScene.Enabled = False
        cmdEnregistrerScene.Visible = True
        cmdEnregistrerScene.Enabled = True
        For Each ctrl As Control In pnlInformation.Controls
            If TypeOf ctrl Is TextBox Then
                DirectCast(ctrl, TextBox).Enabled = True
                DirectCast(ctrl, TextBox).ReadOnly = False
            End If
        Next
    End Sub

    Private Sub cmdEnregistrer_Click(sender As Object, e As EventArgs) Handles cmdEnregistrerScene.Click
        Dim sceneCourante = modGestionScene.getSceneCourante
        cbxScene.Enabled = True
        cmdModifierScene.Visible = True
        cmdModifierScene.Enabled = True
        cmdEnregistrerScene.Visible = False
        cmdEnregistrerScene.Enabled = False
        For Each ctrl As Control In pnlInformation.Controls
            If TypeOf ctrl Is TextBox Then
                DirectCast(ctrl, TextBox).Enabled = False
                DirectCast(ctrl, TextBox).ReadOnly = True
            End If
        Next

        sceneCourante.setNom(txtNom.Text)
        sceneCourante.setDescription(txtDescription.Text)
        sceneCourante.setCapacite(txtCapacite.Text)
        sceneCourante.setDimensionX(txtDimension1.Text)
        sceneCourante.setdimensionY(txtDimension2.Text)

        updateScene(sceneCourante)
    End Sub


    Private Sub cmdPlanning_Click(sender As Object, e As EventArgs) Handles cmdPlanning.Click
        frmPlanning.ShowDialog()
    End Sub
End Class