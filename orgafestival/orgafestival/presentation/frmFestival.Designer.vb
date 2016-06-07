<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFestival
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
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.txtNomFestival = New System.Windows.Forms.TextBox()
        Me.dtpDebut = New System.Windows.Forms.DateTimePicker()
        Me.dtpFin = New System.Windows.Forms.DateTimePicker()
        Me.lblDateDebut = New System.Windows.Forms.Label()
        Me.lblDateFin = New System.Windows.Forms.Label()
        Me.cmdCommencer = New System.Windows.Forms.Button()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblTitre
        '
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.Location = New System.Drawing.Point(12, 25)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(269, 20)
        Me.lblTitre.TabIndex = 0
        Me.lblTitre.Text = "&Créez votre festival"
        '
        'txtNomFestival
        '
        Me.txtNomFestival.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomFestival.Location = New System.Drawing.Point(16, 72)
        Me.txtNomFestival.Name = "txtNomFestival"
        Me.txtNomFestival.Size = New System.Drawing.Size(569, 29)
        Me.txtNomFestival.TabIndex = 1
        '
        'dtpDebut
        '
        Me.dtpDebut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDebut.Location = New System.Drawing.Point(156, 182)
        Me.dtpDebut.Name = "dtpDebut"
        Me.dtpDebut.Size = New System.Drawing.Size(200, 21)
        Me.dtpDebut.TabIndex = 3
        '
        'dtpFin
        '
        Me.dtpFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFin.Location = New System.Drawing.Point(156, 230)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(200, 21)
        Me.dtpFin.TabIndex = 5
        '
        'lblDateDebut
        '
        Me.lblDateDebut.AutoSize = True
        Me.lblDateDebut.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateDebut.Location = New System.Drawing.Point(11, 187)
        Me.lblDateDebut.Name = "lblDateDebut"
        Me.lblDateDebut.Size = New System.Drawing.Size(99, 18)
        Me.lblDateDebut.TabIndex = 2
        Me.lblDateDebut.Text = "&Date de début"
        '
        'lblDateFin
        '
        Me.lblDateFin.AutoSize = True
        Me.lblDateFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateFin.Location = New System.Drawing.Point(11, 235)
        Me.lblDateFin.Name = "lblDateFin"
        Me.lblDateFin.Size = New System.Drawing.Size(78, 18)
        Me.lblDateFin.TabIndex = 4
        Me.lblDateFin.Text = "Date de &fin"
        '
        'cmdCommencer
        '
        Me.cmdCommencer.Enabled = False
        Me.cmdCommencer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCommencer.Location = New System.Drawing.Point(423, 205)
        Me.cmdCommencer.Name = "cmdCommencer"
        Me.cmdCommencer.Size = New System.Drawing.Size(162, 48)
        Me.cmdCommencer.TabIndex = 6
        Me.cmdCommencer.Text = "C&ommencer"
        Me.cmdCommencer.UseVisualStyleBackColor = True
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocation.Location = New System.Drawing.Point(13, 141)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(65, 18)
        Me.lblLocation.TabIndex = 7
        Me.lblLocation.Text = "Location"
        '
        'txtLocation
        '
        Me.txtLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocation.Location = New System.Drawing.Point(156, 138)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(200, 24)
        Me.txtLocation.TabIndex = 8
        '
        'frmFestival
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 265)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.cmdCommencer)
        Me.Controls.Add(Me.lblDateFin)
        Me.Controls.Add(Me.lblDateDebut)
        Me.Controls.Add(Me.dtpFin)
        Me.Controls.Add(Me.dtpDebut)
        Me.Controls.Add(Me.txtNomFestival)
        Me.Controls.Add(Me.lblTitre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFestival"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Projet"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitre As Label
    Friend WithEvents txtNomFestival As TextBox
    Friend WithEvents dtpDebut As DateTimePicker
    Friend WithEvents dtpFin As DateTimePicker
    Friend WithEvents lblDateDebut As Label
    Friend WithEvents lblDateFin As Label
    Friend WithEvents cmdCommencer As Button
    Friend WithEvents lblLocation As Label
    Friend WithEvents txtLocation As TextBox
End Class
