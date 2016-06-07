<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnregistrerHoraire
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
        Me.lblInserer = New System.Windows.Forms.Label()
        Me.lblDansScene = New System.Windows.Forms.Label()
        Me.lblDe = New System.Windows.Forms.Label()
        Me.lblA = New System.Windows.Forms.Label()
        Me.cboHDebut = New System.Windows.Forms.ComboBox()
        Me.cboHFin = New System.Windows.Forms.ComboBox()
        Me.cmdEnregistrer = New System.Windows.Forms.Button()
        Me.cmdAnnuler = New System.Windows.Forms.Button()
        Me.gbxPlageHoraire = New System.Windows.Forms.GroupBox()
        Me.lblLe = New System.Windows.Forms.Label()
        Me.cboDates = New System.Windows.Forms.ComboBox()
        Me.gbxPlageHoraire.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblInserer
        '
        Me.lblInserer.AutoSize = True
        Me.lblInserer.Location = New System.Drawing.Point(12, 15)
        Me.lblInserer.Name = "lblInserer"
        Me.lblInserer.Size = New System.Drawing.Size(58, 16)
        Me.lblInserer.TabIndex = 0
        Me.lblInserer.Text = "Insérer : "
        '
        'lblDansScene
        '
        Me.lblDansScene.AutoSize = True
        Me.lblDansScene.Location = New System.Drawing.Point(12, 57)
        Me.lblDansScene.Name = "lblDansScene"
        Me.lblDansScene.Size = New System.Drawing.Size(49, 16)
        Me.lblDansScene.TabIndex = 1
        Me.lblDansScene.Text = "Dans : "
        '
        'lblDe
        '
        Me.lblDe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDe.AutoSize = True
        Me.lblDe.Location = New System.Drawing.Point(6, 42)
        Me.lblDe.Name = "lblDe"
        Me.lblDe.Size = New System.Drawing.Size(32, 16)
        Me.lblDe.TabIndex = 2
        Me.lblDe.Text = "De :"
        '
        'lblA
        '
        Me.lblA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblA.AutoSize = True
        Me.lblA.Location = New System.Drawing.Point(6, 84)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(26, 16)
        Me.lblA.TabIndex = 3
        Me.lblA.Text = "A : "
        '
        'cboHDebut
        '
        Me.cboHDebut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboHDebut.FormattingEnabled = True
        Me.cboHDebut.Location = New System.Drawing.Point(47, 39)
        Me.cboHDebut.Name = "cboHDebut"
        Me.cboHDebut.Size = New System.Drawing.Size(150, 24)
        Me.cboHDebut.TabIndex = 4
        '
        'cboHFin
        '
        Me.cboHFin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboHFin.FormattingEnabled = True
        Me.cboHFin.Location = New System.Drawing.Point(47, 81)
        Me.cboHFin.Name = "cboHFin"
        Me.cboHFin.Size = New System.Drawing.Size(150, 24)
        Me.cboHFin.TabIndex = 5
        '
        'cmdEnregistrer
        '
        Me.cmdEnregistrer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdEnregistrer.Enabled = False
        Me.cmdEnregistrer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEnregistrer.Location = New System.Drawing.Point(105, 127)
        Me.cmdEnregistrer.Name = "cmdEnregistrer"
        Me.cmdEnregistrer.Size = New System.Drawing.Size(92, 35)
        Me.cmdEnregistrer.TabIndex = 12
        Me.cmdEnregistrer.Text = "Enregistrer"
        Me.cmdEnregistrer.UseVisualStyleBackColor = True
        '
        'cmdAnnuler
        '
        Me.cmdAnnuler.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAnnuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAnnuler.Location = New System.Drawing.Point(9, 127)
        Me.cmdAnnuler.Name = "cmdAnnuler"
        Me.cmdAnnuler.Size = New System.Drawing.Size(92, 35)
        Me.cmdAnnuler.TabIndex = 13
        Me.cmdAnnuler.Text = "Annuler"
        Me.cmdAnnuler.UseVisualStyleBackColor = True
        '
        'gbxPlageHoraire
        '
        Me.gbxPlageHoraire.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxPlageHoraire.Controls.Add(Me.cboHDebut)
        Me.gbxPlageHoraire.Controls.Add(Me.cmdAnnuler)
        Me.gbxPlageHoraire.Controls.Add(Me.lblDe)
        Me.gbxPlageHoraire.Controls.Add(Me.cmdEnregistrer)
        Me.gbxPlageHoraire.Controls.Add(Me.lblA)
        Me.gbxPlageHoraire.Controls.Add(Me.cboHFin)
        Me.gbxPlageHoraire.Location = New System.Drawing.Point(8, 131)
        Me.gbxPlageHoraire.Name = "gbxPlageHoraire"
        Me.gbxPlageHoraire.Size = New System.Drawing.Size(203, 168)
        Me.gbxPlageHoraire.TabIndex = 14
        Me.gbxPlageHoraire.TabStop = False
        Me.gbxPlageHoraire.Text = "Plage horaire"
        '
        'lblLe
        '
        Me.lblLe.AutoSize = True
        Me.lblLe.Location = New System.Drawing.Point(16, 99)
        Me.lblLe.Name = "lblLe"
        Me.lblLe.Size = New System.Drawing.Size(32, 16)
        Me.lblLe.TabIndex = 15
        Me.lblLe.Text = "Le : "
        '
        'cboDates
        '
        Me.cboDates.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboDates.FormattingEnabled = True
        Me.cboDates.Location = New System.Drawing.Point(55, 96)
        Me.cboDates.Name = "cboDates"
        Me.cboDates.Size = New System.Drawing.Size(150, 24)
        Me.cboDates.TabIndex = 14
        '
        'frmEnregistrerHoraire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(223, 311)
        Me.Controls.Add(Me.cboDates)
        Me.Controls.Add(Me.lblLe)
        Me.Controls.Add(Me.gbxPlageHoraire)
        Me.Controls.Add(Me.lblDansScene)
        Me.Controls.Add(Me.lblInserer)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmEnregistrerHoraire"
        Me.Text = "Enregistrer l'horaire"
        Me.gbxPlageHoraire.ResumeLayout(False)
        Me.gbxPlageHoraire.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInserer As Label
    Friend WithEvents lblDansScene As Label
    Friend WithEvents lblDe As Label
    Friend WithEvents lblA As Label
    Friend WithEvents cboHDebut As ComboBox
    Friend WithEvents cboHFin As ComboBox
    Friend WithEvents cmdEnregistrer As Button
    Friend WithEvents cmdAnnuler As Button
    Friend WithEvents gbxPlageHoraire As GroupBox
    Friend WithEvents lblLe As Label
    Friend WithEvents cboDates As ComboBox
End Class
