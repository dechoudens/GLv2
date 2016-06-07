Module Controller
    Dim listeScene As New Collection
    Dim nomFestival As String = Nothing
    Dim sceneCourante As Scene
    Public utilisateurCourant As Utilisateur = Nothing
    Public festivalsUti As New List(Of Festival)
    Public festivalCourant As Festival = Nothing
    Public scenesFes As New List(Of Scene)

    Public Sub addScene(ByVal nom As String, ByVal description As String, ByVal capacite As String, ByVal dimensionX As String, ByVal dimensionY As String)
        '  Dim scene As Scene = New Scene(nom, description, capacite, dimensionX, dimensionY)
        '    listeScene.Add(scene)
        '     frmGestionScene.cbxScene.Items.Clear()
        'For Each s As Scene In listeScene
        '        frmGestionScene.cbxScene.Items.Add(s.getNom())
        'Next
    End Sub

    Public Function getScene(ByVal i As Integer)
        Return listeScene.Item(i + 1)
    End Function


    Public Sub setSceneCourant(ByVal scene As Scene)
        sceneCourante = scene
    End Sub

    Public Function getSceneCourant() As String
        Return sceneCourante.getNom()
    End Function

    Public Sub loadFesUti()
        festivalsUti.Clear()
        MsgBox(utilisateurCourant.getId)
        Dim id = utilisateurCourant.getId
        For i = 0 To festivals.Count - 1
            Dim fes = festivals.Item(i)

            If fes.getUtilisateur.getId = id Then
                festivalsUti.Add(fes)
            End If
        Next
        If festivalsUti.Count > 0 Then
            festivalCourant = festivalsUti.Item(festivalsUti.Count - 1)
        End If
    End Sub

    Public Sub loadSceFes()
        scenesFes.Clear()

        If festivalCourant IsNot Nothing Then
            Dim id = festivalCourant.getId
            For i = 0 To scenes.Count - 1
                Dim scene = scenes.Item(i)

                If scene.getFestival.getId = id Then
                    scenesFes.Add(scene)
                End If
            Next
            If scenesFes.Count > 0 Then
                sceneCourante = scenesFes.Item(scenesFes.Count - 1)
            Else
                sceneCourante = Nothing
            End If

        End If
    End Sub
End Module
