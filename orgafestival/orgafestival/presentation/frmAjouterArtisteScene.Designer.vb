<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAjouterArtisteScene
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstArtistesDispo = New System.Windows.Forms.ListBox()
        Me.lblArtistesDispo = New System.Windows.Forms.Label()
        Me.cmdCreerArtiste = New System.Windows.Forms.Button()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.cmdAjouter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstArtistesDispo
        '
        Me.lstArtistesDispo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstArtistesDispo.FormattingEnabled = True
        Me.lstArtistesDispo.HorizontalScrollbar = True
        Me.lstArtistesDispo.ItemHeight = 18
        Me.lstArtistesDispo.Location = New System.Drawing.Point(13, 71)
        Me.lstArtistesDispo.Margin = New System.Windows.Forms.Padding(4)
        Me.lstArtistesDispo.Name = "lstArtistesDispo"
        Me.lstArtistesDispo.Size = New System.Drawing.Size(329, 508)
        Me.lstArtistesDispo.Sorted = True
        Me.lstArtistesDispo.TabIndex = 2
        '
        'lblArtistesDispo
        '
        Me.lblArtistesDispo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblArtistesDispo.AutoSize = True
        Me.lblArtistesDispo.Location = New System.Drawing.Point(9, 49)
        Me.lblArtistesDispo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblArtistesDispo.Name = "lblArtistesDispo"
        Me.lblArtistesDispo.Size = New System.Drawing.Size(135, 18)
        Me.lblArtistesDispo.TabIndex = 1
        Me.lblArtistesDispo.Text = "&Artistes disponibles"
        '
        'cmdCreerArtiste
        '
        Me.cmdCreerArtiste.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCreerArtiste.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCreerArtiste.Location = New System.Drawing.Point(180, 587)
        Me.cmdCreerArtiste.Name = "cmdCreerArtiste"
        Me.cmdCreerArtiste.Size = New System.Drawing.Size(162, 55)
        Me.cmdCreerArtiste.TabIndex = 4
        Me.cmdCreerArtiste.Text = "&Créer un artiste"
        Me.cmdCreerArtiste.UseVisualStyleBackColor = True
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.Location = New System.Drawing.Point(9, 9)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(65, 18)
        Me.lblTitre.TabIndex = 0
        Me.lblTitre.Text = "&Scène :"
        '
        'cmdAjouter
        '
        Me.cmdAjouter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdAjouter.Enabled = False
        Me.cmdAjouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAjouter.Location = New System.Drawing.Point(12, 586)
        Me.cmdAjouter.Name = "cmdAjouter"
        Me.cmdAjouter.Size = New System.Drawing.Size(162, 55)
        Me.cmdAjouter.TabIndex = 3
        Me.cmdAjouter.Text = "&Ajouter"
        Me.cmdAjouter.UseVisualStyleBackColor = True
        '
        'frmAjouterArtisteScene
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 654)
        Me.Controls.Add(Me.cmdAjouter)
        Me.Controls.Add(Me.lblTitre)
        Me.Controls.Add(Me.cmdCreerArtiste)
        Me.Controls.Add(Me.lblArtistesDispo)
        Me.Controls.Add(Me.lstArtistesDispo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmAjouterArtisteScene"
        Me.Text = "Assginer un artiste"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstArtistesDispo As ListBox
    Friend WithEvents lblArtistesDispo As Label
    Friend WithEvents cmdCreerArtiste As Button
    Friend WithEvents lblTitre As Label
    Friend WithEvents cmdAjouter As Button
End Class
