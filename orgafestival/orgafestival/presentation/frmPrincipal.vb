Imports System.ComponentModel

Public Class frmPrincipal

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Visible = False
        Me.ShowInTaskbar = False
        Me.WindowState = FormWindowState.Minimized


        frmConnection.Show()

        connexionBDD()
        recupererDonnees()

    End Sub

    Private Sub tlsGestionScene_Click(sender As Object, e As EventArgs) Handles tspMenuGestionScene.Click
        frmGestionScene.Show()
    End Sub

    Private Sub tspMenuArtistes_Click(sender As Object, e As EventArgs) Handles tspMenuArtistes.Click
        frmProfilArtiste.Show()
    End Sub


    Private Sub mnuPrincipalConnectionDeconnection_Click(sender As Object, e As EventArgs) Handles mnuPrincipalConnectionDeconnection.Click
        frmGestionScene.Close()
        frmFestival.Close()
        frmAjouterScene.Close()
        frmProfilArtiste.Close()

        frmConnection.Show()

        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub frmPrincipal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        fermerBDD()
    End Sub

    Public Sub setConnecte(ByVal identifiant As String)
        lblConnecte.Text = identifiant
    End Sub
End Class
