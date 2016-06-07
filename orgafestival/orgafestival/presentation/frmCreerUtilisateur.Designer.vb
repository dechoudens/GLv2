<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreerUtilisateur
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
        Me.cmdEnregistrer = New System.Windows.Forms.Button()
        Me.cmdEffacer = New System.Windows.Forms.Button()
        Me.txtIdentifiant = New System.Windows.Forms.TextBox()
        Me.lblIdentifiant = New System.Windows.Forms.Label()
        Me.txtMdp = New System.Windows.Forms.TextBox()
        Me.lblMdp = New System.Windows.Forms.Label()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.lblPrenom = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.gbxIdentification = New System.Windows.Forms.GroupBox()
        Me.gbxInformation = New System.Windows.Forms.GroupBox()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.lblAdresse = New System.Windows.Forms.Label()
        Me.gbxIdentification.SuspendLayout()
        Me.gbxInformation.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdEnregistrer
        '
        Me.cmdEnregistrer.Enabled = False
        Me.cmdEnregistrer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEnregistrer.Location = New System.Drawing.Point(262, 427)
        Me.cmdEnregistrer.Name = "cmdEnregistrer"
        Me.cmdEnregistrer.Size = New System.Drawing.Size(162, 48)
        Me.cmdEnregistrer.TabIndex = 15
        Me.cmdEnregistrer.Text = "En&registrer"
        Me.cmdEnregistrer.UseVisualStyleBackColor = True
        '
        'cmdEffacer
        '
        Me.cmdEffacer.Enabled = False
        Me.cmdEffacer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEffacer.Location = New System.Drawing.Point(24, 427)
        Me.cmdEffacer.Name = "cmdEffacer"
        Me.cmdEffacer.Size = New System.Drawing.Size(162, 48)
        Me.cmdEffacer.TabIndex = 14
        Me.cmdEffacer.Text = "&Effacer"
        Me.cmdEffacer.UseVisualStyleBackColor = True
        '
        'txtIdentifiant
        '
        Me.txtIdentifiant.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdentifiant.Location = New System.Drawing.Point(134, 31)
        Me.txtIdentifiant.Name = "txtIdentifiant"
        Me.txtIdentifiant.Size = New System.Drawing.Size(245, 24)
        Me.txtIdentifiant.TabIndex = 17
        '
        'lblIdentifiant
        '
        Me.lblIdentifiant.AutoSize = True
        Me.lblIdentifiant.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdentifiant.Location = New System.Drawing.Point(19, 34)
        Me.lblIdentifiant.Name = "lblIdentifiant"
        Me.lblIdentifiant.Size = New System.Drawing.Size(69, 18)
        Me.lblIdentifiant.TabIndex = 16
        Me.lblIdentifiant.Text = "&Identifiant"
        '
        'txtMdp
        '
        Me.txtMdp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMdp.Location = New System.Drawing.Point(134, 80)
        Me.txtMdp.Name = "txtMdp"
        Me.txtMdp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMdp.Size = New System.Drawing.Size(245, 24)
        Me.txtMdp.TabIndex = 21
        '
        'lblMdp
        '
        Me.lblMdp.AutoSize = True
        Me.lblMdp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMdp.Location = New System.Drawing.Point(19, 83)
        Me.lblMdp.Name = "lblMdp"
        Me.lblMdp.Size = New System.Drawing.Size(98, 18)
        Me.lblMdp.TabIndex = 20
        Me.lblMdp.Text = "&Mot de passe"
        '
        'txtPrenom
        '
        Me.txtPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrenom.Location = New System.Drawing.Point(134, 80)
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(245, 24)
        Me.txtPrenom.TabIndex = 25
        '
        'lblPrenom
        '
        Me.lblPrenom.AutoSize = True
        Me.lblPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrenom.Location = New System.Drawing.Point(19, 83)
        Me.lblPrenom.Name = "lblPrenom"
        Me.lblPrenom.Size = New System.Drawing.Size(61, 18)
        Me.lblPrenom.TabIndex = 24
        Me.lblPrenom.Text = "&Prénom"
        '
        'txtNom
        '
        Me.txtNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNom.Location = New System.Drawing.Point(134, 38)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(245, 24)
        Me.txtNom.TabIndex = 23
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.Location = New System.Drawing.Point(19, 41)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(41, 18)
        Me.lblNom.TabIndex = 22
        Me.lblNom.Text = "&Nom"
        '
        'gbxIdentification
        '
        Me.gbxIdentification.Controls.Add(Me.lblIdentifiant)
        Me.gbxIdentification.Controls.Add(Me.txtIdentifiant)
        Me.gbxIdentification.Controls.Add(Me.lblMdp)
        Me.gbxIdentification.Controls.Add(Me.txtMdp)
        Me.gbxIdentification.Location = New System.Drawing.Point(24, 31)
        Me.gbxIdentification.Name = "gbxIdentification"
        Me.gbxIdentification.Size = New System.Drawing.Size(400, 124)
        Me.gbxIdentification.TabIndex = 26
        Me.gbxIdentification.TabStop = False
        Me.gbxIdentification.Text = "Identification"
        '
        'gbxInformation
        '
        Me.gbxInformation.Controls.Add(Me.txtTelephone)
        Me.gbxInformation.Controls.Add(Me.lblTelephone)
        Me.gbxInformation.Controls.Add(Me.txtAdresse)
        Me.gbxInformation.Controls.Add(Me.lblAdresse)
        Me.gbxInformation.Controls.Add(Me.lblNom)
        Me.gbxInformation.Controls.Add(Me.txtNom)
        Me.gbxInformation.Controls.Add(Me.txtPrenom)
        Me.gbxInformation.Controls.Add(Me.lblPrenom)
        Me.gbxInformation.Location = New System.Drawing.Point(24, 181)
        Me.gbxInformation.Name = "gbxInformation"
        Me.gbxInformation.Size = New System.Drawing.Size(400, 225)
        Me.gbxInformation.TabIndex = 27
        Me.gbxInformation.TabStop = False
        Me.gbxInformation.Text = "Information"
        '
        'txtTelephone
        '
        Me.txtTelephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelephone.Location = New System.Drawing.Point(134, 164)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(245, 24)
        Me.txtTelephone.TabIndex = 29
        '
        'lblTelephone
        '
        Me.lblTelephone.AutoSize = True
        Me.lblTelephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelephone.Location = New System.Drawing.Point(19, 167)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(77, 18)
        Me.lblTelephone.TabIndex = 28
        Me.lblTelephone.Text = "&Téléphone"
        '
        'txtAdresse
        '
        Me.txtAdresse.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdresse.Location = New System.Drawing.Point(134, 122)
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(245, 24)
        Me.txtAdresse.TabIndex = 27
        '
        'lblAdresse
        '
        Me.lblAdresse.AutoSize = True
        Me.lblAdresse.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdresse.Location = New System.Drawing.Point(19, 125)
        Me.lblAdresse.Name = "lblAdresse"
        Me.lblAdresse.Size = New System.Drawing.Size(62, 18)
        Me.lblAdresse.TabIndex = 26
        Me.lblAdresse.Text = "&Adresse"
        '
        'frmCreerUtilisateur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 496)
        Me.Controls.Add(Me.gbxInformation)
        Me.Controls.Add(Me.gbxIdentification)
        Me.Controls.Add(Me.cmdEnregistrer)
        Me.Controls.Add(Me.cmdEffacer)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmCreerUtilisateur"
        Me.Text = "Inscription"
        Me.gbxIdentification.ResumeLayout(False)
        Me.gbxIdentification.PerformLayout()
        Me.gbxInformation.ResumeLayout(False)
        Me.gbxInformation.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdEnregistrer As Button
    Friend WithEvents cmdEffacer As Button
    Friend WithEvents txtIdentifiant As TextBox
    Friend WithEvents lblIdentifiant As Label
    Friend WithEvents txtMdp As TextBox
    Friend WithEvents lblMdp As Label
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents lblPrenom As Label
    Friend WithEvents txtNom As TextBox
    Friend WithEvents lblNom As Label
    Friend WithEvents gbxIdentification As GroupBox
    Friend WithEvents gbxInformation As GroupBox
    Friend WithEvents txtTelephone As TextBox
    Friend WithEvents lblTelephone As Label
    Friend WithEvents txtAdresse As TextBox
    Friend WithEvents lblAdresse As Label
End Class
