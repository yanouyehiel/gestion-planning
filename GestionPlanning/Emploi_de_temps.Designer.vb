<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Emploi_de_temps
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nom_enseignant = New System.Windows.Forms.Label()
        Me.ListEmploiTemps = New System.Windows.Forms.ListView()
        Me.NomCours = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.HeureDebut = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.HeureFin = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Salle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btn_print = New System.Windows.Forms.Button()
        Me.btn_quitter = New System.Windows.Forms.Button()
        Me.prenom_enseignant = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pseudo_enseignant = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(308, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Emploi de temps"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(68, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nom :"
        '
        'nom_enseignant
        '
        Me.nom_enseignant.AutoSize = True
        Me.nom_enseignant.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nom_enseignant.Location = New System.Drawing.Point(133, 89)
        Me.nom_enseignant.Name = "nom_enseignant"
        Me.nom_enseignant.Size = New System.Drawing.Size(0, 20)
        Me.nom_enseignant.TabIndex = 2
        '
        'ListEmploiTemps
        '
        Me.ListEmploiTemps.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NomCours, Me.HeureDebut, Me.HeureFin, Me.Salle})
        Me.ListEmploiTemps.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListEmploiTemps.FullRowSelect = True
        Me.ListEmploiTemps.GridLines = True
        Me.ListEmploiTemps.HideSelection = False
        Me.ListEmploiTemps.Location = New System.Drawing.Point(72, 232)
        Me.ListEmploiTemps.Name = "ListEmploiTemps"
        Me.ListEmploiTemps.Size = New System.Drawing.Size(638, 216)
        Me.ListEmploiTemps.TabIndex = 3
        Me.ListEmploiTemps.UseCompatibleStateImageBehavior = False
        Me.ListEmploiTemps.View = System.Windows.Forms.View.Details
        '
        'NomCours
        '
        Me.NomCours.Text = "Nom du cours"
        Me.NomCours.Width = 185
        '
        'HeureDebut
        '
        Me.HeureDebut.Text = "Heure de début"
        Me.HeureDebut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.HeureDebut.Width = 173
        '
        'HeureFin
        '
        Me.HeureFin.Text = "Heure de fin"
        Me.HeureFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.HeureFin.Width = 177
        '
        'Salle
        '
        Me.Salle.Text = "Salle"
        Me.Salle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Salle.Width = 100
        '
        'btn_print
        '
        Me.btn_print.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print.Location = New System.Drawing.Point(519, 473)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(87, 35)
        Me.btn_print.TabIndex = 4
        Me.btn_print.Text = "Imprimer"
        Me.btn_print.UseVisualStyleBackColor = True
        '
        'btn_quitter
        '
        Me.btn_quitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_quitter.Location = New System.Drawing.Point(621, 473)
        Me.btn_quitter.Name = "btn_quitter"
        Me.btn_quitter.Size = New System.Drawing.Size(89, 35)
        Me.btn_quitter.TabIndex = 5
        Me.btn_quitter.Text = "Quitter"
        Me.btn_quitter.UseVisualStyleBackColor = True
        '
        'prenom_enseignant
        '
        Me.prenom_enseignant.AutoSize = True
        Me.prenom_enseignant.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prenom_enseignant.Location = New System.Drawing.Point(157, 123)
        Me.prenom_enseignant.Name = "prenom_enseignant"
        Me.prenom_enseignant.Size = New System.Drawing.Size(0, 20)
        Me.prenom_enseignant.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(68, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "prénom :"
        '
        'pseudo_enseignant
        '
        Me.pseudo_enseignant.AutoSize = True
        Me.pseudo_enseignant.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pseudo_enseignant.Location = New System.Drawing.Point(157, 157)
        Me.pseudo_enseignant.Name = "pseudo_enseignant"
        Me.pseudo_enseignant.Size = New System.Drawing.Size(0, 20)
        Me.pseudo_enseignant.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(68, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Pseudo :"
        '
        'Emploi_de_temps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 535)
        Me.Controls.Add(Me.pseudo_enseignant)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.prenom_enseignant)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_quitter)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.ListEmploiTemps)
        Me.Controls.Add(Me.nom_enseignant)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Emploi_de_temps"
        Me.Text = "Mon emploi de temps"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nom_enseignant As Label
    Friend WithEvents ListEmploiTemps As ListView
    Friend WithEvents NomCours As ColumnHeader
    Friend WithEvents HeureDebut As ColumnHeader
    Friend WithEvents HeureFin As ColumnHeader
    Friend WithEvents Salle As ColumnHeader
    Friend WithEvents btn_print As Button
    Friend WithEvents btn_quitter As Button
    Friend WithEvents prenom_enseignant As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents pseudo_enseignant As Label
    Friend WithEvents Label6 As Label
End Class
