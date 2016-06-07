<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlanning
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.cboDatesFes = New System.Windows.Forms.ComboBox()
        Me.cmdModifierPlanning = New System.Windows.Forms.Button()
        Me.cmdImprimer = New System.Windows.Forms.Button()
        Me.cmdSupprimerArtiste = New System.Windows.Forms.Button()
        Me.cmdAjouterArtiste = New System.Windows.Forms.Button()
        Me.dgvPlanning = New System.Windows.Forms.DataGridView()
        Me.lblTitre = New System.Windows.Forms.Label()
        CType(Me.dgvPlanning, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(9, 66)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(37, 16)
        Me.lblDate.TabIndex = 15
        Me.lblDate.Text = "Date"
        '
        'cboDatesFes
        '
        Me.cboDatesFes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDatesFes.FormattingEnabled = True
        Me.cboDatesFes.Location = New System.Drawing.Point(53, 63)
        Me.cboDatesFes.Name = "cboDatesFes"
        Me.cboDatesFes.Size = New System.Drawing.Size(172, 24)
        Me.cboDatesFes.TabIndex = 14
        '
        'cmdModifierPlanning
        '
        Me.cmdModifierPlanning.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdModifierPlanning.Location = New System.Drawing.Point(404, 582)
        Me.cmdModifierPlanning.Name = "cmdModifierPlanning"
        Me.cmdModifierPlanning.Size = New System.Drawing.Size(162, 48)
        Me.cmdModifierPlanning.TabIndex = 12
        Me.cmdModifierPlanning.Text = "&Modifier"
        Me.cmdModifierPlanning.UseVisualStyleBackColor = True
        '
        'cmdImprimer
        '
        Me.cmdImprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImprimer.Location = New System.Drawing.Point(600, 582)
        Me.cmdImprimer.Name = "cmdImprimer"
        Me.cmdImprimer.Size = New System.Drawing.Size(162, 48)
        Me.cmdImprimer.TabIndex = 13
        Me.cmdImprimer.Text = "&Imprimer le planning"
        Me.cmdImprimer.UseVisualStyleBackColor = True
        '
        'cmdSupprimerArtiste
        '
        Me.cmdSupprimerArtiste.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSupprimerArtiste.Location = New System.Drawing.Point(208, 582)
        Me.cmdSupprimerArtiste.Name = "cmdSupprimerArtiste"
        Me.cmdSupprimerArtiste.Size = New System.Drawing.Size(162, 48)
        Me.cmdSupprimerArtiste.TabIndex = 11
        Me.cmdSupprimerArtiste.Text = "S&upprimer un artiste"
        Me.cmdSupprimerArtiste.UseVisualStyleBackColor = True
        '
        'cmdAjouterArtiste
        '
        Me.cmdAjouterArtiste.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAjouterArtiste.Location = New System.Drawing.Point(12, 582)
        Me.cmdAjouterArtiste.Name = "cmdAjouterArtiste"
        Me.cmdAjouterArtiste.Size = New System.Drawing.Size(162, 48)
        Me.cmdAjouterArtiste.TabIndex = 10
        Me.cmdAjouterArtiste.Text = "&Ajouter un artiste"
        Me.cmdAjouterArtiste.UseVisualStyleBackColor = True
        '
        'dgvPlanning
        '
        Me.dgvPlanning.AllowUserToAddRows = False
        Me.dgvPlanning.AllowUserToDeleteRows = False
        Me.dgvPlanning.AllowUserToResizeColumns = False
        Me.dgvPlanning.AllowUserToResizeRows = False
        Me.dgvPlanning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPlanning.Location = New System.Drawing.Point(12, 96)
        Me.dgvPlanning.MultiSelect = False
        Me.dgvPlanning.Name = "dgvPlanning"
        Me.dgvPlanning.RowHeadersVisible = False
        Me.dgvPlanning.Size = New System.Drawing.Size(886, 480)
        Me.dgvPlanning.TabIndex = 9
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.Location = New System.Drawing.Point(12, 9)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(119, 24)
        Me.lblTitre.TabIndex = 16
        Me.lblTitre.Text = "Nom Festival"
        '
        'frmPlanning
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 647)
        Me.Controls.Add(Me.lblTitre)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.cboDatesFes)
        Me.Controls.Add(Me.cmdModifierPlanning)
        Me.Controls.Add(Me.cmdImprimer)
        Me.Controls.Add(Me.cmdSupprimerArtiste)
        Me.Controls.Add(Me.cmdAjouterArtiste)
        Me.Controls.Add(Me.dgvPlanning)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPlanning"
        Me.Text = "Planning"
        CType(Me.dgvPlanning, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDate As Label
    Friend WithEvents cboDatesFes As ComboBox
    Friend WithEvents cmdModifierPlanning As Button
    Friend WithEvents cmdImprimer As Button
    Friend WithEvents cmdSupprimerArtiste As Button
    Friend WithEvents cmdAjouterArtiste As Button
    Friend WithEvents dgvPlanning As DataGridView
    Friend WithEvents lblTitre As Label
End Class
