Public Class frmPlanning
    Dim dt As DataTable

    Private Sub frmPlanning_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        lblTitre.Text = getSceneCourante.getNom

        modGestionScene.recupereArtisteScene()
        modGestionScene.recupereHorairesArtisteScene()
        initDate()
        initHoraire()
        afficherHoraire()
        painRows()
    End Sub

    Public Sub initDate()
        cboDatesFes.Items.Clear()
        Dim date1 As Date = festivalCourant.getDateDebut()
        Dim date2 As Date = festivalCourant.getDateFin()
        Dim interval = DateDiff(DateInterval.Day, date1, date2)
        Dim dates As New List(Of Date)
        For i = 0 To interval - 1
            dates.Add(date1.AddDays(i))
        Next
        modGestionScene.setDates(dates)

        For i = 0 To dates.Count - 1
            cboDatesFes.Items.Add(dates.Item(i))
        Next
        cboDatesFes.SelectedIndex = 0
        modGestionScene.setDateCourante(date1)
    End Sub

    Public Sub initHoraire()
        Dim sceneCourante = modGestionScene.getSceneCourante

        Dim debut = sceneCourante.getHeureDebut().Hour
        Dim fin = sceneCourante.getHeureFin().Hour
        dt = New DataTable
        dt.Columns.Add("Artistes")
        For i As Integer = debut To fin
            Dim str As String = i.ToString + ":00"
            dt.Columns.Add(str)

        Next

        dgvPlanning.DataSource = dt.DefaultView

        Dim column As DataGridViewColumn = dgvPlanning.Columns(0)
        column.Width = 100


        For k As Integer = 1 To dgvPlanning.ColumnCount - 1
            column = dgvPlanning.Columns(k)
            column.Width = 45
        Next

        For Each c As DataGridViewColumn In dgvPlanning.Columns
            c.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub

    Public Sub afficherHoraire()
        Dim sceneCourante = modGestionScene.getSceneCourante

        Dim debut = sceneCourante.getHeureDebut().Hour
        Dim fin = sceneCourante.getHeureFin().Hour

        For i = 0 To horaires.Count - 1
            Dim newRow As Object() = New Object(sceneCourante.getHeureFin.Hour - sceneCourante.getHeureDebut.Hour + 1) {}
            Dim current = horaires.Item(i)
            Dim horaireArt = current.getHeures
            newRow(0) = current.getArtiste.getNom
            For j = 0 To horaireArt.Count - 1
                Dim id = horaireArt.Item(j).Hour - sceneCourante.getHeureDebut.Hour + 1
                newRow(id) = "."
            Next

            dt.LoadDataRow(newRow, True)
        Next

    End Sub

    Public Sub painRows()
        Dim myColor As Color
        Dim rand As New Random
        For i As Integer = 0 To dgvPlanning.RowCount - 1
            myColor = Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256))
            For ColNo As Integer = 1 To dgvPlanning.ColumnCount - 1
                If dgvPlanning.Rows(i).Cells(ColNo).Value Is "." Then
                    dgvPlanning.Rows(i).Cells(ColNo).Style.BackColor = myColor
                End If
            Next
        Next

    End Sub

    Private Sub cboDatesFes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDatesFes.SelectedIndexChanged
        Dim dates = modGestionScene.getDates
        Dim id = cboDatesFes.SelectedIndex
        modGestionScene.setDateCourante(dates.Item(id))

        modGestionScene.recupereArtisteScene()
        modGestionScene.recupereHorairesArtisteScene()
        initHoraire()
        afficherHoraire()
        painRows()
    End Sub

    Private Sub cmdModifierPlanning_Click(sender As Object, e As EventArgs)
        frmModifierPlanning.ShowDialog()
    End Sub

    Private Sub cmdImprimer_Click(sender As Object, e As EventArgs)
        'prdImprimerPlanning.ShowDialog()
    End Sub

    Private Sub cmdAjouterArtiste_Click(sender As Object, e As EventArgs) Handles cmdAjouterArtiste.Click
        frmAjouterArtisteScene.ShowDialog()
    End Sub

    Private Sub cmdSupprimerArtiste_Click(sender As Object, e As EventArgs) Handles cmdSupprimerArtiste.Click
        frmSupprimerArtisteScene.ShowDialog()
    End Sub

End Class