<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")>
Partial Class frmConnection
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
    Friend WithEvents pbxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblIdentifiant As System.Windows.Forms.Label
    Friend WithEvents lblMDP As System.Windows.Forms.Label
    Friend WithEvents txtIdentifiant As System.Windows.Forms.TextBox
    Friend WithEvents txtMDP As System.Windows.Forms.TextBox
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConnection))
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.lblIdentifiant = New System.Windows.Forms.Label()
        Me.lblMDP = New System.Windows.Forms.Label()
        Me.txtIdentifiant = New System.Windows.Forms.TextBox()
        Me.txtMDP = New System.Windows.Forms.TextBox()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbxLogo
        '
        Me.pbxLogo.Image = CType(resources.GetObject("pbxLogo.Image"), System.Drawing.Image)
        Me.pbxLogo.Location = New System.Drawing.Point(0, 0)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(165, 193)
        Me.pbxLogo.TabIndex = 0
        Me.pbxLogo.TabStop = False
        '
        'lblIdentifiant
        '
        Me.lblIdentifiant.Location = New System.Drawing.Point(172, 24)
        Me.lblIdentifiant.Name = "lblIdentifiant"
        Me.lblIdentifiant.Size = New System.Drawing.Size(220, 23)
        Me.lblIdentifiant.TabIndex = 0
        Me.lblIdentifiant.Text = "&Identifiant"
        Me.lblIdentifiant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMDP
        '
        Me.lblMDP.Location = New System.Drawing.Point(172, 81)
        Me.lblMDP.Name = "lblMDP"
        Me.lblMDP.Size = New System.Drawing.Size(220, 23)
        Me.lblMDP.TabIndex = 2
        Me.lblMDP.Text = "&Mot de passe"
        Me.lblMDP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIdentifiant
        '
        Me.txtIdentifiant.Location = New System.Drawing.Point(174, 44)
        Me.txtIdentifiant.Name = "txtIdentifiant"
        Me.txtIdentifiant.Size = New System.Drawing.Size(220, 20)
        Me.txtIdentifiant.TabIndex = 1
        Me.txtIdentifiant.Text = "admin"
        '
        'txtMDP
        '
        Me.txtMDP.Location = New System.Drawing.Point(174, 101)
        Me.txtMDP.Name = "txtMDP"
        Me.txtMDP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMDP.Size = New System.Drawing.Size(220, 20)
        Me.txtMDP.TabIndex = 3
        Me.txtMDP.Text = "123"
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(197, 161)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(94, 23)
        Me.cmdOk.TabIndex = 4
        Me.cmdOk.Text = "&Ok"
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Location = New System.Drawing.Point(300, 161)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(94, 23)
        Me.cmdCancel.TabIndex = 5
        Me.cmdCancel.Text = "&Annuler"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(255, 133)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(85, 13)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Créer un compte"
        '
        'frmConnection
        '
        Me.AcceptButton = Me.cmdOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(401, 192)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.txtMDP)
        Me.Controls.Add(Me.txtIdentifiant)
        Me.Controls.Add(Me.lblMDP)
        Me.Controls.Add(Me.lblIdentifiant)
        Me.Controls.Add(Me.pbxLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConnection"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Connection"
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LinkLabel1 As LinkLabel
End Class
