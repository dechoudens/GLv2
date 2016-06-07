Public Class frmConnection

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click

        Dim identifiant = txtIdentifiant.Text
        Dim mdp = txtMDP.Text
        utilisateurCourant = Nothing

        For i = 0 To utilisateurs.Count - 1
            Dim uti = utilisateurs.Item(i)
            If uti.getIdentifiant = identifiant Then
                If uti.getMDP = mdp Then
                    utilisateurCourant = uti
                    loadFesUti()
                    loadSceFes()
                    loadFrm()
                End If
            End If
        Next

        If utilisateurCourant Is Nothing Then
            MsgBox("Une erreur s'est produite lors de l'authentification", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
        frmPrincipal.Close()
    End Sub

    Public Sub loadFrm()
        Me.Close()
        frmPrincipal.Visible = True
        frmPrincipal.ShowInTaskbar = True
        frmPrincipal.WindowState = FormWindowState.Maximized
        frmPrincipal.setConnecte(utilisateurCourant.getIdentifiant)
        If festivalsUti.Count > 0 Then
            frmGestionScene.Show()
        Else
            frmFestival.Show()
        End If


        artistes.Sort(New ArtisteComparer)
        scenes.Sort(New SceneComparer)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmCreerUtilisateur.ShowDialog()
    End Sub
End Class
