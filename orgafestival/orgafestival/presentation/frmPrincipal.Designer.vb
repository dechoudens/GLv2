<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.tspMenu = New System.Windows.Forms.ToolStrip()
        Me.tspMenuGestionScene = New System.Windows.Forms.ToolStripButton()
        Me.tlsSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tspMenuArtistes = New System.Windows.Forms.ToolStripButton()
        Me.tlsSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuPrincipalConnection = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrincipalConnectionDeconnection = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.lblConnecte = New System.Windows.Forms.Label()
        Me.pbxConnecte = New System.Windows.Forms.PictureBox()
        Me.pnlLoginInfo = New System.Windows.Forms.Panel()
        Me.tspMenu.SuspendLayout()
        Me.mnuPrincipal.SuspendLayout()
        CType(Me.pbxConnecte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLoginInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'tspMenu
        '
        Me.tspMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.tspMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tspMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tspMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tspMenuGestionScene, Me.tlsSeparator1, Me.tspMenuArtistes, Me.tlsSeparator2})
        Me.tspMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tspMenu.Location = New System.Drawing.Point(0, 33)
        Me.tspMenu.Name = "tspMenu"
        Me.tspMenu.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.tspMenu.Size = New System.Drawing.Size(120, 595)
        Me.tspMenu.TabIndex = 1
        Me.tspMenu.Text = "tspMenu"
        '
        'tspMenuGestionScene
        '
        Me.tspMenuGestionScene.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tspMenuGestionScene.Image = CType(resources.GetObject("tspMenuGestionScene.Image"), System.Drawing.Image)
        Me.tspMenuGestionScene.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tspMenuGestionScene.Name = "tspMenuGestionScene"
        Me.tspMenuGestionScene.Padding = New System.Windows.Forms.Padding(0, 30, 10, 0)
        Me.tspMenuGestionScene.Size = New System.Drawing.Size(119, 49)
        Me.tspMenuGestionScene.Text = "&Gestion des scènes"
        Me.tspMenuGestionScene.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlsSeparator1
        '
        Me.tlsSeparator1.Name = "tlsSeparator1"
        Me.tlsSeparator1.Size = New System.Drawing.Size(119, 6)
        '
        'tspMenuArtistes
        '
        Me.tspMenuArtistes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tspMenuArtistes.Image = CType(resources.GetObject("tspMenuArtistes.Image"), System.Drawing.Image)
        Me.tspMenuArtistes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tspMenuArtistes.Name = "tspMenuArtistes"
        Me.tspMenuArtistes.Padding = New System.Windows.Forms.Padding(0, 30, 10, 0)
        Me.tspMenuArtistes.Size = New System.Drawing.Size(119, 49)
        Me.tspMenuArtistes.Text = "&Artistes"
        Me.tspMenuArtistes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlsSeparator2
        '
        Me.tlsSeparator2.Name = "tlsSeparator2"
        Me.tlsSeparator2.Size = New System.Drawing.Size(119, 6)
        '
        'mnuPrincipalConnection
        '
        Me.mnuPrincipalConnection.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrincipalConnectionDeconnection})
        Me.mnuPrincipalConnection.Name = "mnuPrincipalConnection"
        Me.mnuPrincipalConnection.Padding = New System.Windows.Forms.Padding(0, 0, 30, 10)
        Me.mnuPrincipalConnection.Size = New System.Drawing.Size(103, 29)
        Me.mnuPrincipalConnection.Text = "&Connection"
        '
        'mnuPrincipalConnectionDeconnection
        '
        Me.mnuPrincipalConnectionDeconnection.Name = "mnuPrincipalConnectionDeconnection"
        Me.mnuPrincipalConnectionDeconnection.Size = New System.Drawing.Size(152, 22)
        Me.mnuPrincipalConnectionDeconnection.Text = "&Déconnection"
        '
        'mnuPrincipal
        '
        Me.mnuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrincipalConnection})
        Me.mnuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.mnuPrincipal.Name = "mnuPrincipal"
        Me.mnuPrincipal.Size = New System.Drawing.Size(1148, 33)
        Me.mnuPrincipal.TabIndex = 0
        Me.mnuPrincipal.Text = "Connection"
        '
        'lblConnecte
        '
        Me.lblConnecte.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblConnecte.AutoSize = True
        Me.lblConnecte.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblConnecte.Location = New System.Drawing.Point(49, 9)
        Me.lblConnecte.Name = "lblConnecte"
        Me.lblConnecte.Size = New System.Drawing.Size(35, 13)
        Me.lblConnecte.TabIndex = 0
        Me.lblConnecte.Text = "admin"
        '
        'pbxConnecte
        '
        Me.pbxConnecte.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbxConnecte.Image = CType(resources.GetObject("pbxConnecte.Image"), System.Drawing.Image)
        Me.pbxConnecte.Location = New System.Drawing.Point(3, 3)
        Me.pbxConnecte.Name = "pbxConnecte"
        Me.pbxConnecte.Size = New System.Drawing.Size(40, 30)
        Me.pbxConnecte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxConnecte.TabIndex = 8
        Me.pbxConnecte.TabStop = False
        '
        'pnlLoginInfo
        '
        Me.pnlLoginInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlLoginInfo.Controls.Add(Me.pbxConnecte)
        Me.pnlLoginInfo.Controls.Add(Me.lblConnecte)
        Me.pnlLoginInfo.Location = New System.Drawing.Point(1001, 0)
        Me.pnlLoginInfo.Name = "pnlLoginInfo"
        Me.pnlLoginInfo.Size = New System.Drawing.Size(147, 33)
        Me.pnlLoginInfo.TabIndex = 2
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1148, 628)
        Me.Controls.Add(Me.pnlLoginInfo)
        Me.Controls.Add(Me.tspMenu)
        Me.Controls.Add(Me.mnuPrincipal)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuPrincipal
        Me.Name = "frmPrincipal"
        Me.Text = "OrgaFestival"
        Me.tspMenu.ResumeLayout(False)
        Me.tspMenu.PerformLayout()
        Me.mnuPrincipal.ResumeLayout(False)
        Me.mnuPrincipal.PerformLayout()
        CType(Me.pbxConnecte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLoginInfo.ResumeLayout(False)
        Me.pnlLoginInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tspMenu As ToolStrip
    Friend WithEvents tspMenuGestionScene As ToolStripButton
    Friend WithEvents tlsSeparator1 As ToolStripSeparator
    Friend WithEvents tspMenuArtistes As ToolStripButton
    Friend WithEvents tlsSeparator2 As ToolStripSeparator
    Private WithEvents mnuPrincipalConnection As ToolStripMenuItem
    Friend WithEvents mnuPrincipal As MenuStrip
    Friend WithEvents lblConnecte As Label
    Friend WithEvents pbxConnecte As PictureBox
    Friend WithEvents pnlLoginInfo As Panel
    Friend WithEvents mnuPrincipalConnectionDeconnection As ToolStripMenuItem
End Class
