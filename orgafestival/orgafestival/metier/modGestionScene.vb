Module modGestionScene
    Dim sceneCourante As Scene
    Dim artisteCourant As Artiste
    Dim artisteScene As New List(Of Artiste)
    Dim dateCourante As New Date
    Dim dates As New List(Of Date)

    Public Function getDates() As List(Of Date)
        Return dates
    End Function

    Public Function getDateCourante() As Date
        Return dateCourante
    End Function

    Public Sub setDates(ByVal newDates As List(Of Date))
        dates = newDates
    End Sub

    Public Sub setDateCourante(ByVal newDate As Date)
        dateCourante = newDate
    End Sub

    Public Function getSceneCourante() As Scene
        Return sceneCourante
    End Function

    Public Function getArtisteCourant() As Artiste
        Return artisteCourant
    End Function

    Public Sub addArtisteScene(ByVal art As Artiste)
        artisteScene.Add(art)
    End Sub

    Public Sub setArtisteCourante(ByVal scene As Artiste)
        artisteCourant = scene
    End Sub

    Public Sub setArtisteScene(ByVal artSce As List(Of Artiste))
        artisteScene = artSce
    End Sub

    Public Sub setSceneCourante(ByVal scene As Scene)
        sceneCourante = scene
    End Sub

    Public Function getArtisteScene() As List(Of Artiste)
        Return artisteScene
    End Function

    Public Sub initHeure(ByVal debut As Integer, ByVal fin As Integer, cboH As ComboBox)
        Dim Heure As New ArrayList
        cboH.Items.Clear()

        If debut < 10 Then
            For i = debut To 9
                Heure.Add("0" + i.ToString + ":00")
            Next
            For i = 10 To fin
                Heure.Add(i.ToString + ":00")
            Next
        Else
            For i = debut To fin
                Heure.Add(i.ToString + ":00")
            Next
        End If

        For i = debut To fin
            cboH.Items.Add(Heure(i - debut))
        Next
    End Sub

    Public Sub recupereArtisteScene()
        Dim artisteScene = getArtisteScene()
        artisteScene.Clear()


        For i = 0 To joues.Count - 1
            Dim current = joues.Item(i)
            If modGestionScene.getDateCourante.Day = current.getHeure().Day Then
                If modGestionScene.getSceneCourante.getId = current.getScene.getId Then
                    If Not artisteScene.Contains(current.getArtiste) Then
                        artisteScene.Add(current.getArtiste)
                    End If
                End If
            End If
        Next
        setArtisteScene(artisteScene)
    End Sub

    Public Sub recupereHorairesArtisteScene()
        Dim sceneCourante = getSceneCourante()
        Dim artisteScene = getArtisteScene()
        horaires.Clear()

        For i = 0 To artisteScene.Count - 1
            Dim horaireArt As New List(Of Date)
            Dim currentArtiste = artisteScene.Item(i)
            For j = 0 To joues.Count - 1
                Dim joue = joues.Item(j)
                If getDateCourante.Day = joue.getHeure().Day Then
                    If currentArtiste.getId = joue.getArtiste.getId And sceneCourante.getId = joue.getScene.getId Then
                        horaireArt.Add(joue.getHeure)
                    End If
                End If
            Next
            horaires.Add(New Horaire(horaireArt, artisteScene.Item(i)))
        Next
    End Sub
End Module
