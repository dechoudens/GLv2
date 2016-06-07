<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmModifierPlanning
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.lblArtiste = New System.Windows.Forms.Label()
        Me.lstArtiste = New System.Windows.Forms.ComboBox()
        Me.dgvPlanningArtiste = New System.Windows.Forms.DataGridView()
        Me.cmdEnregistrer = New System.Windows.Forms.Button()
        CType(Me.dgvPlanningArtiste, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.Location = New System.Drawing.Point(9, 9)
        Me.lblTitre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(65, 18)
        Me.lblTitre.TabIndex = 0
        Me.lblTitre.Text = "&Scène :"
        '
        'lblArtiste
        '
        Me.lblArtiste.AutoSize = True
        Me.lblArtiste.Location = New System.Drawing.Point(9, 56)
        Me.lblArtiste.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblArtiste.Name = "lblArtiste"
        Me.lblArtiste.Size = New System.Drawing.Size(49, 18)
        Me.lblArtiste.TabIndex = 1
        Me.lblArtiste.Text = "&Artiste"
        '
        'lstArtiste
        '
        Me.lstArtiste.FormattingEnabled = True
        Me.lstArtiste.Items.AddRange(New Object() {"AC/DC", "Elton John", "Nicki minaj ", "etc", "Shpongle"})
        Me.lstArtiste.Location = New System.Drawing.Point(69, 53)
        Me.lstArtiste.Name = "lstArtiste"
        Me.lstArtiste.Size = New System.Drawing.Size(257, 26)
        Me.lstArtiste.TabIndex = 2
        '
        'dgvPlanningArtiste
        '
        Me.dgvPlanningArtiste.AllowUserToDeleteRows = False
        Me.dgvPlanningArtiste.AllowUserToResizeColumns = False
        Me.dgvPlanningArtiste.AllowUserToResizeRows = False
        Me.dgvPlanningArtiste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPlanningArtiste.Location = New System.Drawing.Point(12, 109)
        Me.dgvPlanningArtiste.MultiSelect = False
        Me.dgvPlanningArtiste.Name = "dgvPlanningArtiste"
        Me.dgvPlanningArtiste.RowHeadersVisible = False
        Me.dgvPlanningArtiste.RowHeadersWidth = 10
        Me.dgvPlanningArtiste.Size = New System.Drawing.Size(775, 66)
        Me.dgvPlanningArtiste.TabIndex = 3
        '
        'cmdEnregistrer
        '
        Me.cmdEnregistrer.Enabled = False
        Me.cmdEnregistrer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEnregistrer.Location = New System.Drawing.Point(625, 182)
        Me.cmdEnregistrer.Name = "cmdEnregistrer"
        Me.cmdEnregistrer.Size = New System.Drawing.Size(162, 48)
        Me.cmdEnregistrer.TabIndex = 4
        Me.cmdEnregistrer.Text = "&Enregistrer"
        Me.cmdEnregistrer.UseVisualStyleBackColor = True
        '
        'frmModifierPlanning
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 242)
        Me.Controls.Add(Me.cmdEnregistrer)
        Me.Controls.Add(Me.dgvPlanningArtiste)
        Me.Controls.Add(Me.lstArtiste)
        Me.Controls.Add(Me.lblArtiste)
        Me.Controls.Add(Me.lblTitre)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmModifierPlanning"
        Me.Text = "Modifier le planning"
        CType(Me.dgvPlanningArtiste, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitre As Label
    Friend WithEvents lblArtiste As Label
    Friend WithEvents lstArtiste As ComboBox
    Friend WithEvents dgvPlanningArtiste As DataGridView
    Friend WithEvents cmdEnregistrer As Button
End Class
