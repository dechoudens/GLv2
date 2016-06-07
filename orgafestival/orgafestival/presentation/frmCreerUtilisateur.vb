Public Class frmCreerUtilisateur
    Private Sub frmCreerUtilisateur_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        resetTxt()
    End Sub

    Public Sub resetTxt()
        Dim ctrl As Control
        For Each ctrl In gbxIdentification.Controls
            If (ctrl.GetType() Is GetType(TextBox)) Then
                Dim txt As TextBox = CType(ctrl, TextBox)
                txt.ResetText()
            End If
        Next

        For Each ctrl In gbxInformation.Controls
            If (ctrl.GetType() Is GetType(TextBox)) Then
                Dim txt As TextBox = CType(ctrl, TextBox)
                txt.ResetText()
            End If
        Next
    End Sub

    Private Sub txt_TextChanged(sender As Object, e As EventArgs) Handles txtTelephone.TextChanged, txtPrenom.TextChanged, txtNom.TextChanged, txtMdp.TextChanged, txtIdentifiant.TextChanged, txtAdresse.TextChanged
        Dim ctrl As Control

        cmdEffacer.Enabled = False
        For Each ctrl In gbxIdentification.Controls
            If (ctrl.GetType() Is GetType(TextBox)) Then
                Dim txt As TextBox = CType(ctrl, TextBox)
                If txt.Text.Length > 0 Then
                    cmdEffacer.Enabled = True
                    cmdEnregistrer.Enabled = True
                Else
                    cmdEnregistrer.Enabled = False
                End If
            End If
        Next

        For Each ctrl In gbxInformation.Controls
            If (ctrl.GetType() Is GetType(TextBox)) Then
                Dim txt As TextBox = CType(ctrl, TextBox)
                If txt.Text.Length > 0 Then
                    cmdEffacer.Enabled = True
                    cmdEnregistrer.Enabled = True
                Else
                    cmdEnregistrer.Enabled = False
                End If
            End If
        Next

        If txtTelephone.Text = "" Or txtPrenom.Text = "" Or txtNom.Text = "" Or txtMdp.Text = "" Or txtIdentifiant.Text = "" Or txtAdresse.Text = "" Then
            cmdEnregistrer.Enabled = False
        Else
            cmdEnregistrer.Enabled = True
        End If

    End Sub

    Private Sub cmdEffacer_Click(sender As Object, e As EventArgs) Handles cmdEffacer.Click
        resetTxt()
    End Sub

    Private Sub txtValue_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelephone.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmdEnregistrer_Click(sender As Object, e As EventArgs) Handles cmdEnregistrer.Click
        Dim identifiant = txtIdentifiant.Text
        Dim mdp = txtMdp.Text
        Dim nom = txtNom.Text
        Dim prenom = txtPrenom.Text
        Dim adresse = txtAdresse.Text
        Dim telephone = txtTelephone.Text
        Dim user = New Utilisateur(identifiant, mdp, nom, prenom, adresse, telephone)
        insererUtilisateur(user)

        utilisateurCourant = utilisateurs.Item(utilisateurs.Count - 1)

        loadFesUti()
        loadSceFes()
        frmConnection.loadFrm()
        Me.Close()
    End Sub
End Class