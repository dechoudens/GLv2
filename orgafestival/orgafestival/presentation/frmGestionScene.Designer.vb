<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGestionScene
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
        Me.cbxScene = New System.Windows.Forms.ComboBox()
        Me.lblSelectionScene = New System.Windows.Forms.Label()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.pnlInformation = New System.Windows.Forms.Panel()
        Me.cmdEnregistrerScene = New System.Windows.Forms.Button()
        Me.cmdCéerScene = New System.Windows.Forms.Button()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblDimension = New System.Windows.Forms.Label()
        Me.cmdModifierScene = New System.Windows.Forms.Button()
        Me.lblCapacite = New System.Windows.Forms.Label()
        Me.lblX = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtDimension2 = New System.Windows.Forms.TextBox()
        Me.txtCapacite = New System.Windows.Forms.TextBox()
        Me.txtDimension1 = New System.Windows.Forms.TextBox()
        Me.prdImprimerPlanning = New System.Windows.Forms.PrintDialog()
        Me.cmdPlanning = New System.Windows.Forms.Button()
        Me.pnlInformation.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbxScene
        '
        Me.cbxScene.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxScene.FormattingEnabled = True
        Me.cbxScene.Location = New System.Drawing.Point(129, 52)
        Me.cbxScene.Name = "cbxScene"
        Me.cbxScene.Size = New System.Drawing.Size(261, 26)
        Me.cbxScene.TabIndex = 1
        '
        'lblSelectionScene
        '
        Me.lblSelectionScene.AutoSize = True
        Me.lblSelectionScene.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectionScene.Location = New System.Drawing.Point(37, 52)
        Me.lblSelectionScene.Name = "lblSelectionScene"
        Me.lblSelectionScene.Size = New System.Drawing.Size(55, 20)
        Me.lblSelectionScene.TabIndex = 0
        Me.lblSelectionScene.Text = "&Scène"
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.Location = New System.Drawing.Point(16, 13)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(119, 24)
        Me.lblTitre.TabIndex = 0
        Me.lblTitre.Text = "Nom Festival"
        '
        'pnlInformation
        '
        Me.pnlInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlInformation.Controls.Add(Me.cmdEnregistrerScene)
        Me.pnlInformation.Controls.Add(Me.cmdCéerScene)
        Me.pnlInformation.Controls.Add(Me.lblNom)
        Me.pnlInformation.Controls.Add(Me.txtDescription)
        Me.pnlInformation.Controls.Add(Me.lblDimension)
        Me.pnlInformation.Controls.Add(Me.cmdModifierScene)
        Me.pnlInformation.Controls.Add(Me.lblCapacite)
        Me.pnlInformation.Controls.Add(Me.lblX)
        Me.pnlInformation.Controls.Add(Me.txtNom)
        Me.pnlInformation.Controls.Add(Me.lblDescription)
        Me.pnlInformation.Controls.Add(Me.txtDimension2)
        Me.pnlInformation.Controls.Add(Me.txtCapacite)
        Me.pnlInformation.Controls.Add(Me.txtDimension1)
        Me.pnlInformation.Controls.Add(Me.lblSelectionScene)
        Me.pnlInformation.Controls.Add(Me.cbxScene)
        Me.pnlInformation.Location = New System.Drawing.Point(20, 51)
        Me.pnlInformation.Name = "pnlInformation"
        Me.pnlInformation.Size = New System.Drawing.Size(430, 480)
        Me.pnlInformation.TabIndex = 1
        '
        'cmdEnregistrerScene
        '
        Me.cmdEnregistrerScene.Enabled = False
        Me.cmdEnregistrerScene.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEnregistrerScene.Location = New System.Drawing.Point(228, 394)
        Me.cmdEnregistrerScene.Name = "cmdEnregistrerScene"
        Me.cmdEnregistrerScene.Size = New System.Drawing.Size(162, 48)
        Me.cmdEnregistrerScene.TabIndex = 13
        Me.cmdEnregistrerScene.Text = "&Enregistrer"
        Me.cmdEnregistrerScene.UseVisualStyleBackColor = True
        Me.cmdEnregistrerScene.Visible = False
        '
        'cmdCéerScene
        '
        Me.cmdCéerScene.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCéerScene.Location = New System.Drawing.Point(41, 394)
        Me.cmdCéerScene.Name = "cmdCéerScene"
        Me.cmdCéerScene.Size = New System.Drawing.Size(162, 48)
        Me.cmdCéerScene.TabIndex = 12
        Me.cmdCéerScene.Text = "C&réer une scène"
        Me.cmdCéerScene.UseVisualStyleBackColor = True
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.Location = New System.Drawing.Point(38, 157)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(41, 18)
        Me.lblNom.TabIndex = 2
        Me.lblNom.Text = "&Nom"
        '
        'txtDescription
        '
        Me.txtDescription.Enabled = False
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(127, 205)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.Size = New System.Drawing.Size(261, 47)
        Me.txtDescription.TabIndex = 5
        '
        'lblDimension
        '
        Me.lblDimension.AutoSize = True
        Me.lblDimension.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDimension.Location = New System.Drawing.Point(38, 320)
        Me.lblDimension.Name = "lblDimension"
        Me.lblDimension.Size = New System.Drawing.Size(87, 18)
        Me.lblDimension.TabIndex = 8
        Me.lblDimension.Text = "&Dimensions"
        '
        'cmdModifierScene
        '
        Me.cmdModifierScene.Enabled = False
        Me.cmdModifierScene.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdModifierScene.Location = New System.Drawing.Point(228, 394)
        Me.cmdModifierScene.Name = "cmdModifierScene"
        Me.cmdModifierScene.Size = New System.Drawing.Size(162, 48)
        Me.cmdModifierScene.TabIndex = 9
        Me.cmdModifierScene.Text = "Modifier"
        Me.cmdModifierScene.UseVisualStyleBackColor = True
        '
        'lblCapacite
        '
        Me.lblCapacite.AutoSize = True
        Me.lblCapacite.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapacite.Location = New System.Drawing.Point(38, 272)
        Me.lblCapacite.Name = "lblCapacite"
        Me.lblCapacite.Size = New System.Drawing.Size(66, 18)
        Me.lblCapacite.TabIndex = 6
        Me.lblCapacite.Text = "&Capacite"
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Enabled = False
        Me.lblX.Location = New System.Drawing.Point(252, 325)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(12, 13)
        Me.lblX.TabIndex = 10
        Me.lblX.Text = "x"
        '
        'txtNom
        '
        Me.txtNom.Enabled = False
        Me.txtNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNom.Location = New System.Drawing.Point(129, 157)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.ReadOnly = True
        Me.txtNom.Size = New System.Drawing.Size(261, 24)
        Me.txtNom.TabIndex = 3
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(38, 205)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(83, 18)
        Me.lblDescription.TabIndex = 4
        Me.lblDescription.Text = "&Description"
        '
        'txtDimension2
        '
        Me.txtDimension2.Enabled = False
        Me.txtDimension2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDimension2.Location = New System.Drawing.Point(270, 321)
        Me.txtDimension2.Name = "txtDimension2"
        Me.txtDimension2.ReadOnly = True
        Me.txtDimension2.Size = New System.Drawing.Size(118, 24)
        Me.txtDimension2.TabIndex = 11
        '
        'txtCapacite
        '
        Me.txtCapacite.Enabled = False
        Me.txtCapacite.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCapacite.Location = New System.Drawing.Point(129, 272)
        Me.txtCapacite.Name = "txtCapacite"
        Me.txtCapacite.ReadOnly = True
        Me.txtCapacite.Size = New System.Drawing.Size(260, 24)
        Me.txtCapacite.TabIndex = 7
        '
        'txtDimension1
        '
        Me.txtDimension1.Enabled = False
        Me.txtDimension1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDimension1.Location = New System.Drawing.Point(128, 320)
        Me.txtDimension1.Name = "txtDimension1"
        Me.txtDimension1.ReadOnly = True
        Me.txtDimension1.Size = New System.Drawing.Size(118, 24)
        Me.txtDimension1.TabIndex = 9
        '
        'prdImprimerPlanning
        '
        Me.prdImprimerPlanning.UseEXDialog = True
        '
        'cmdPlanning
        '
        Me.cmdPlanning.Location = New System.Drawing.Point(496, 490)
        Me.cmdPlanning.Name = "cmdPlanning"
        Me.cmdPlanning.Size = New System.Drawing.Size(131, 40)
        Me.cmdPlanning.TabIndex = 2
        Me.cmdPlanning.Text = "Planning"
        Me.cmdPlanning.UseVisualStyleBackColor = True
        '
        'frmGestionScene
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 577)
        Me.Controls.Add(Me.cmdPlanning)
        Me.Controls.Add(Me.pnlInformation)
        Me.Controls.Add(Me.lblTitre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1398, 659)
        Me.Name = "frmGestionScene"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Gestion des scènes"
        Me.pnlInformation.ResumeLayout(False)
        Me.pnlInformation.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbxScene As ComboBox
    Friend WithEvents lblSelectionScene As Label
    Friend WithEvents lblTitre As Label
    Friend WithEvents pnlInformation As Panel
    Friend WithEvents cmdCéerScene As Button
    Friend WithEvents lblNom As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents lblDimension As Label
    Friend WithEvents lblCapacite As Label
    Friend WithEvents lblX As Label
    Friend WithEvents txtNom As TextBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtDimension2 As TextBox
    Friend WithEvents txtCapacite As TextBox
    Friend WithEvents txtDimension1 As TextBox
    Friend WithEvents cmdModifierScene As Button
    Friend WithEvents cmdEnregistrerScene As Button
    Friend WithEvents prdImprimerPlanning As PrintDialog
    Friend WithEvents cmdPlanning As Button
End Class
