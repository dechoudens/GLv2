<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreerArtiste
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
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblGenre = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.cmdEffacer = New System.Windows.Forms.Button()
        Me.cmdEnregistrer = New System.Windows.Forms.Button()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.cboGenre = New System.Windows.Forms.ComboBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.Location = New System.Drawing.Point(12, 12)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(41, 18)
        Me.lblNom.TabIndex = 0
        Me.lblNom.Text = "&Nom"
        '
        'lblGenre
        '
        Me.lblGenre.AutoSize = True
        Me.lblGenre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenre.Location = New System.Drawing.Point(12, 51)
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(49, 18)
        Me.lblGenre.TabIndex = 2
        Me.lblGenre.Text = "&Genre"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(12, 94)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(83, 18)
        Me.lblDescription.TabIndex = 4
        Me.lblDescription.Text = "&Description"
        '
        'cmdEffacer
        '
        Me.cmdEffacer.Enabled = False
        Me.cmdEffacer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEffacer.Location = New System.Drawing.Point(15, 207)
        Me.cmdEffacer.Name = "cmdEffacer"
        Me.cmdEffacer.Size = New System.Drawing.Size(162, 48)
        Me.cmdEffacer.TabIndex = 6
        Me.cmdEffacer.Text = "&Effacer"
        Me.cmdEffacer.UseVisualStyleBackColor = True
        '
        'cmdEnregistrer
        '
        Me.cmdEnregistrer.Enabled = False
        Me.cmdEnregistrer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEnregistrer.Location = New System.Drawing.Point(195, 207)
        Me.cmdEnregistrer.Name = "cmdEnregistrer"
        Me.cmdEnregistrer.Size = New System.Drawing.Size(162, 48)
        Me.cmdEnregistrer.TabIndex = 7
        Me.cmdEnregistrer.Text = "En&registrer"
        Me.cmdEnregistrer.UseVisualStyleBackColor = True
        '
        'txtNom
        '
        Me.txtNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNom.Location = New System.Drawing.Point(112, 12)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(245, 24)
        Me.txtNom.TabIndex = 1
        '
        'cboGenre
        '
        Me.cboGenre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGenre.FormattingEnabled = True
        Me.cboGenre.Location = New System.Drawing.Point(112, 51)
        Me.cboGenre.Name = "cboGenre"
        Me.cboGenre.Size = New System.Drawing.Size(245, 26)
        Me.cboGenre.TabIndex = 3
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(112, 94)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(245, 90)
        Me.txtDescription.TabIndex = 5
        '
        'frmCreerArtiste
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 279)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.cboGenre)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.cmdEnregistrer)
        Me.Controls.Add(Me.cmdEffacer)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblGenre)
        Me.Controls.Add(Me.lblNom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCreerArtiste"
        Me.Text = "Créer un artiste"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNom As Label
    Friend WithEvents lblGenre As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents cmdEffacer As Button
    Friend WithEvents cmdEnregistrer As Button
    Friend WithEvents txtNom As TextBox
    Friend WithEvents cboGenre As ComboBox
    Friend WithEvents txtDescription As TextBox
End Class
