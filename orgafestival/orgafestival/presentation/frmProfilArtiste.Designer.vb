<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProfilArtiste
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
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblGenre = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lstArtistesDispo = New System.Windows.Forms.ListBox()
        Me.lblListeArtistes = New System.Windows.Forms.Label()
        Me.cmdModifier = New System.Windows.Forms.Button()
        Me.cmdCréer = New System.Windows.Forms.Button()
        Me.cmdEnregistrer = New System.Windows.Forms.Button()
        Me.cboGenre = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(493, 117)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtDescription.Size = New System.Drawing.Size(245, 189)
        Me.txtDescription.TabIndex = 8
        '
        'txtNom
        '
        Me.txtNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNom.Location = New System.Drawing.Point(493, 35)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.ReadOnly = True
        Me.txtNom.Size = New System.Drawing.Size(245, 24)
        Me.txtNom.TabIndex = 4
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(393, 117)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(83, 18)
        Me.lblDescription.TabIndex = 7
        Me.lblDescription.Text = "&Description"
        '
        'lblGenre
        '
        Me.lblGenre.AutoSize = True
        Me.lblGenre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenre.Location = New System.Drawing.Point(393, 76)
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(49, 18)
        Me.lblGenre.TabIndex = 5
        Me.lblGenre.Text = "&Genre"
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.Location = New System.Drawing.Point(393, 35)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(41, 18)
        Me.lblNom.TabIndex = 3
        Me.lblNom.Text = "&Nom"
        '
        'lstArtistesDispo
        '
        Me.lstArtistesDispo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstArtistesDispo.FormattingEnabled = True
        Me.lstArtistesDispo.HorizontalScrollbar = True
        Me.lstArtistesDispo.ItemHeight = 18
        Me.lstArtistesDispo.Location = New System.Drawing.Point(12, 35)
        Me.lstArtistesDispo.Margin = New System.Windows.Forms.Padding(4)
        Me.lstArtistesDispo.Name = "lstArtistesDispo"
        Me.lstArtistesDispo.Size = New System.Drawing.Size(329, 508)
        Me.lstArtistesDispo.Sorted = True
        Me.lstArtistesDispo.TabIndex = 1
        '
        'lblListeArtistes
        '
        Me.lblListeArtistes.AutoSize = True
        Me.lblListeArtistes.Location = New System.Drawing.Point(9, 9)
        Me.lblListeArtistes.Name = "lblListeArtistes"
        Me.lblListeArtistes.Size = New System.Drawing.Size(119, 18)
        Me.lblListeArtistes.TabIndex = 0
        Me.lblListeArtistes.Text = "&Liste des artistes"
        '
        'cmdModifier
        '
        Me.cmdModifier.Enabled = False
        Me.cmdModifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdModifier.Location = New System.Drawing.Point(576, 331)
        Me.cmdModifier.Name = "cmdModifier"
        Me.cmdModifier.Size = New System.Drawing.Size(162, 48)
        Me.cmdModifier.TabIndex = 9
        Me.cmdModifier.Text = "&Modifier"
        Me.cmdModifier.UseVisualStyleBackColor = True
        '
        'cmdCréer
        '
        Me.cmdCréer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCréer.Location = New System.Drawing.Point(12, 554)
        Me.cmdCréer.Name = "cmdCréer"
        Me.cmdCréer.Size = New System.Drawing.Size(162, 48)
        Me.cmdCréer.TabIndex = 2
        Me.cmdCréer.Text = "&Créer un artiste"
        Me.cmdCréer.UseVisualStyleBackColor = True
        '
        'cmdEnregistrer
        '
        Me.cmdEnregistrer.Enabled = False
        Me.cmdEnregistrer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEnregistrer.Location = New System.Drawing.Point(576, 331)
        Me.cmdEnregistrer.Name = "cmdEnregistrer"
        Me.cmdEnregistrer.Size = New System.Drawing.Size(162, 48)
        Me.cmdEnregistrer.TabIndex = 10
        Me.cmdEnregistrer.Text = "Enregistrer"
        Me.cmdEnregistrer.UseVisualStyleBackColor = True
        '
        'cboGenre
        '
        Me.cboGenre.Enabled = False
        Me.cboGenre.FormattingEnabled = True
        Me.cboGenre.Location = New System.Drawing.Point(493, 72)
        Me.cboGenre.Name = "cboGenre"
        Me.cboGenre.Size = New System.Drawing.Size(245, 26)
        Me.cboGenre.TabIndex = 11
        '
        'frmProfilArtiste
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 614)
        Me.Controls.Add(Me.cboGenre)
        Me.Controls.Add(Me.cmdModifier)
        Me.Controls.Add(Me.cmdEnregistrer)
        Me.Controls.Add(Me.cmdCréer)
        Me.Controls.Add(Me.lblListeArtistes)
        Me.Controls.Add(Me.lstArtistesDispo)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblGenre)
        Me.Controls.Add(Me.lblNom)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmProfilArtiste"
        Me.Text = "Profil des artistes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblGenre As Label
    Friend WithEvents lblNom As Label
    Friend WithEvents lstArtistesDispo As ListBox
    Friend WithEvents lblListeArtistes As Label
    Friend WithEvents cmdModifier As Button
    Friend WithEvents cmdCréer As Button
    Friend WithEvents cmdEnregistrer As Button
    Friend WithEvents cboGenre As ComboBox
End Class
