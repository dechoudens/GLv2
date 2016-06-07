Public Class frmModifierPlanning
    Dim dt As DataTable

    Private Sub frmModifierPlanning_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitre.Text = "Scène : " + Controller.getSceneCourant()

        dt = New DataTable

        Dim b As Boolean = True
        For i As Integer = 8 To 24
            If b = True Then
                Dim checkCol As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn
                checkCol.HeaderText = i.ToString + ":00"
                dgvPlanningArtiste.Columns.Add(checkCol)
            Else
                Dim checkCol As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn
                checkCol.HeaderText = i.ToString + ":30"
                dgvPlanningArtiste.Columns.Add(checkCol)
            End If

            b = Not b
        Next

        dgvPlanningArtiste.DataSource = dt.DefaultView

        Dim column As DataGridViewColumn

        For k As Integer = 0 To dgvPlanningArtiste.ColumnCount - 1
            column = dgvPlanningArtiste.Columns(k)
            column.Width = 45
        Next

        For Each c As DataGridViewColumn In dgvPlanningArtiste.Columns
            c.SortMode = DataGridViewColumnSortMode.NotSortable
        Next


    End Sub

    Private Sub afficherHoraire()
        Dim row As String() = New String() {"1", "Product 1", "1000"}

    End Sub

    Private Sub lstArtiste_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstArtiste.SelectedIndexChanged
        afficherHoraire()
        cmdEnregistrer.Enabled = True
    End Sub

    Private Sub cmdEnregistrer_Click(sender As Object, e As EventArgs) Handles cmdEnregistrer.Click
        Me.Close()
    End Sub
End Class