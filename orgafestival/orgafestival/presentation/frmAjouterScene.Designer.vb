<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAjouterScene
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
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblCapacite = New System.Windows.Forms.Label()
        Me.lblDimension = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtCapacite = New System.Windows.Forms.TextBox()
        Me.txtDimension1 = New System.Windows.Forms.TextBox()
        Me.txtDimension2 = New System.Windows.Forms.TextBox()
        Me.lblX = New System.Windows.Forms.Label()
        Me.cmdEnregistrer = New System.Windows.Forms.Button()
        Me.cmdEffacer = New System.Windows.Forms.Button()
        Me.lblDebut = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboHeureDebut = New System.Windows.Forms.ComboBox()
        Me.cboHeureFin = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Location = New System.Drawing.Point(13, 47)
        Me.lblNom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(41, 18)
        Me.lblNom.TabIndex = 0
        Me.lblNom.Text = "&Nom"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(13, 92)
        Me.lblDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(83, 18)
        Me.lblDescription.TabIndex = 2
        Me.lblDescription.Text = "&Description"
        '
        'lblCapacite
        '
        Me.lblCapacite.AutoSize = True
        Me.lblCapacite.Location = New System.Drawing.Point(13, 165)
        Me.lblCapacite.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCapacite.Name = "lblCapacite"
        Me.lblCapacite.Size = New System.Drawing.Size(66, 18)
        Me.lblCapacite.TabIndex = 4
        Me.lblCapacite.Text = "&Capacité"
        '
        'lblDimension
        '
        Me.lblDimension.AutoSize = True
        Me.lblDimension.Location = New System.Drawing.Point(13, 210)
        Me.lblDimension.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDimension.Name = "lblDimension"
        Me.lblDimension.Size = New System.Drawing.Size(79, 18)
        Me.lblDimension.TabIndex = 6
        Me.lblDimension.Text = "&Dimension"
        '
        'txtNom
        '
        Me.txtNom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNom.Location = New System.Drawing.Point(165, 47)
        Me.txtNom.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(331, 24)
        Me.txtNom.TabIndex = 1
        '
        'txtDescription
        '
        Me.txtDescription.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescription.Location = New System.Drawing.Point(165, 92)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.Size = New System.Drawing.Size(331, 52)
        Me.txtDescription.TabIndex = 3
        '
        'txtCapacite
        '
        Me.txtCapacite.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCapacite.Location = New System.Drawing.Point(165, 165)
        Me.txtCapacite.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCapacite.Name = "txtCapacite"
        Me.txtCapacite.Size = New System.Drawing.Size(331, 24)
        Me.txtCapacite.TabIndex = 5
        '
        'txtDimension1
        '
        Me.txtDimension1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDimension1.Location = New System.Drawing.Point(164, 210)
        Me.txtDimension1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDimension1.Name = "txtDimension1"
        Me.txtDimension1.Size = New System.Drawing.Size(148, 24)
        Me.txtDimension1.TabIndex = 7
        '
        'txtDimension2
        '
        Me.txtDimension2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDimension2.Location = New System.Drawing.Point(347, 210)
        Me.txtDimension2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDimension2.Name = "txtDimension2"
        Me.txtDimension2.Size = New System.Drawing.Size(148, 24)
        Me.txtDimension2.TabIndex = 9
        '
        'lblX
        '
        Me.lblX.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblX.AutoSize = True
        Me.lblX.Location = New System.Drawing.Point(322, 216)
        Me.lblX.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(15, 18)
        Me.lblX.TabIndex = 8
        Me.lblX.Text = "x"
        '
        'cmdEnregistrer
        '
        Me.cmdEnregistrer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdEnregistrer.Enabled = False
        Me.cmdEnregistrer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEnregistrer.Location = New System.Drawing.Point(333, 363)
        Me.cmdEnregistrer.Name = "cmdEnregistrer"
        Me.cmdEnregistrer.Size = New System.Drawing.Size(162, 48)
        Me.cmdEnregistrer.TabIndex = 11
        Me.cmdEnregistrer.Text = "Enregistrer"
        Me.cmdEnregistrer.UseVisualStyleBackColor = True
        '
        'cmdEffacer
        '
        Me.cmdEffacer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdEffacer.Enabled = False
        Me.cmdEffacer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEffacer.Location = New System.Drawing.Point(165, 363)
        Me.cmdEffacer.Name = "cmdEffacer"
        Me.cmdEffacer.Size = New System.Drawing.Size(162, 48)
        Me.cmdEffacer.TabIndex = 10
        Me.cmdEffacer.Text = "Effacer"
        Me.cmdEffacer.UseVisualStyleBackColor = True
        '
        'lblDebut
        '
        Me.lblDebut.AutoSize = True
        Me.lblDebut.Location = New System.Drawing.Point(13, 262)
        Me.lblDebut.Name = "lblDebut"
        Me.lblDebut.Size = New System.Drawing.Size(137, 18)
        Me.lblDebut.TabIndex = 12
        Me.lblDebut.Text = "Début des concerts"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 307)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 18)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Fin des concerts"
        '
        'cboHeureDebut
        '
        Me.cboHeureDebut.FormattingEnabled = True
        Me.cboHeureDebut.Location = New System.Drawing.Point(165, 258)
        Me.cboHeureDebut.Name = "cboHeureDebut"
        Me.cboHeureDebut.Size = New System.Drawing.Size(147, 26)
        Me.cboHeureDebut.TabIndex = 14
        '
        'cboHeureFin
        '
        Me.cboHeureFin.FormattingEnabled = True
        Me.cboHeureFin.Location = New System.Drawing.Point(164, 299)
        Me.cboHeureFin.Name = "cboHeureFin"
        Me.cboHeureFin.Size = New System.Drawing.Size(148, 26)
        Me.cboHeureFin.TabIndex = 15
        '
        'frmAjouterScene
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 423)
        Me.Controls.Add(Me.cboHeureFin)
        Me.Controls.Add(Me.cboHeureDebut)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblDebut)
        Me.Controls.Add(Me.cmdEffacer)
        Me.Controls.Add(Me.cmdEnregistrer)
        Me.Controls.Add(Me.lblX)
        Me.Controls.Add(Me.txtDimension2)
        Me.Controls.Add(Me.txtDimension1)
        Me.Controls.Add(Me.txtCapacite)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.lblDimension)
        Me.Controls.Add(Me.lblCapacite)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblNom)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAjouterScene"
        Me.Text = "Ajouter une scène"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNom As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblCapacite As Label
    Friend WithEvents lblDimension As Label
    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtCapacite As TextBox
    Friend WithEvents txtDimension1 As TextBox
    Friend WithEvents txtDimension2 As TextBox
    Friend WithEvents lblX As Label
    Friend WithEvents cmdEnregistrer As Button
    Friend WithEvents cmdEffacer As Button
    Friend WithEvents lblDebut As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboHeureDebut As ComboBox
    Friend WithEvents cboHeureFin As ComboBox
End Class
