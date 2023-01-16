<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Liste_des_employes
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
        Me.ListViewEmployes = New System.Windows.Forms.ListView()
        Me.Nom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Prenom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Email = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Poste = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DateEmbauche = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Admin = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btn_raffraichir = New System.Windows.Forms.Button()
        Me.btn_nouveau = New System.Windows.Forms.Button()
        Me.btn_editer = New System.Windows.Forms.Button()
        Me.btn_supprimer = New System.Windows.Forms.Button()
        Me.btn_imprimer = New System.Windows.Forms.Button()
        Me.btn_quitter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListViewEmployes
        '
        Me.ListViewEmployes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Nom, Me.Prenom, Me.Email, Me.Poste, Me.DateEmbauche, Me.Admin})
        Me.ListViewEmployes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewEmployes.FullRowSelect = True
        Me.ListViewEmployes.GridLines = True
        Me.ListViewEmployes.HideSelection = False
        Me.ListViewEmployes.Location = New System.Drawing.Point(12, 77)
        Me.ListViewEmployes.Name = "ListViewEmployes"
        Me.ListViewEmployes.Size = New System.Drawing.Size(1012, 390)
        Me.ListViewEmployes.TabIndex = 0
        Me.ListViewEmployes.UseCompatibleStateImageBehavior = False
        Me.ListViewEmployes.View = System.Windows.Forms.View.Details
        '
        'Nom
        '
        Me.Nom.Text = "Nom"
        Me.Nom.Width = 160
        '
        'Prenom
        '
        Me.Prenom.Text = "Prénom"
        Me.Prenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Prenom.Width = 162
        '
        'Email
        '
        Me.Email.Text = "Email"
        Me.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Email.Width = 199
        '
        'Poste
        '
        Me.Poste.Text = "Poste"
        Me.Poste.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Poste.Width = 196
        '
        'DateEmbauche
        '
        Me.DateEmbauche.Text = "Date d'embauche"
        Me.DateEmbauche.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DateEmbauche.Width = 166
        '
        'Admin
        '
        Me.Admin.Text = "Admin"
        Me.Admin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Admin.Width = 125
        '
        'btn_raffraichir
        '
        Me.btn_raffraichir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_raffraichir.Location = New System.Drawing.Point(12, 25)
        Me.btn_raffraichir.Name = "btn_raffraichir"
        Me.btn_raffraichir.Size = New System.Drawing.Size(101, 30)
        Me.btn_raffraichir.TabIndex = 1
        Me.btn_raffraichir.Text = "Raffraichir"
        Me.btn_raffraichir.UseVisualStyleBackColor = True
        '
        'btn_nouveau
        '
        Me.btn_nouveau.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nouveau.Location = New System.Drawing.Point(233, 25)
        Me.btn_nouveau.Name = "btn_nouveau"
        Me.btn_nouveau.Size = New System.Drawing.Size(98, 30)
        Me.btn_nouveau.TabIndex = 2
        Me.btn_nouveau.Text = "Nouveau"
        Me.btn_nouveau.UseVisualStyleBackColor = True
        '
        'btn_editer
        '
        Me.btn_editer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editer.Location = New System.Drawing.Point(442, 25)
        Me.btn_editer.Name = "btn_editer"
        Me.btn_editer.Size = New System.Drawing.Size(103, 30)
        Me.btn_editer.TabIndex = 3
        Me.btn_editer.Text = "Editer"
        Me.btn_editer.UseVisualStyleBackColor = True
        '
        'btn_supprimer
        '
        Me.btn_supprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_supprimer.Location = New System.Drawing.Point(668, 25)
        Me.btn_supprimer.Name = "btn_supprimer"
        Me.btn_supprimer.Size = New System.Drawing.Size(112, 30)
        Me.btn_supprimer.TabIndex = 4
        Me.btn_supprimer.Text = "Supprimer"
        Me.btn_supprimer.UseVisualStyleBackColor = True
        '
        'btn_imprimer
        '
        Me.btn_imprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_imprimer.Location = New System.Drawing.Point(912, 25)
        Me.btn_imprimer.Name = "btn_imprimer"
        Me.btn_imprimer.Size = New System.Drawing.Size(112, 30)
        Me.btn_imprimer.TabIndex = 5
        Me.btn_imprimer.Text = "Imprimer"
        Me.btn_imprimer.UseVisualStyleBackColor = True
        '
        'btn_quitter
        '
        Me.btn_quitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_quitter.Location = New System.Drawing.Point(912, 492)
        Me.btn_quitter.Name = "btn_quitter"
        Me.btn_quitter.Size = New System.Drawing.Size(112, 30)
        Me.btn_quitter.TabIndex = 6
        Me.btn_quitter.Text = "Quitter"
        Me.btn_quitter.UseVisualStyleBackColor = True
        '
        'Liste_des_employes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 534)
        Me.Controls.Add(Me.btn_quitter)
        Me.Controls.Add(Me.btn_imprimer)
        Me.Controls.Add(Me.btn_supprimer)
        Me.Controls.Add(Me.btn_editer)
        Me.Controls.Add(Me.btn_nouveau)
        Me.Controls.Add(Me.btn_raffraichir)
        Me.Controls.Add(Me.ListViewEmployes)
        Me.Name = "Liste_des_employes"
        Me.Text = "Liste des employés"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListViewEmployes As ListView
    Friend WithEvents Nom As ColumnHeader
    Friend WithEvents Prenom As ColumnHeader
    Friend WithEvents Email As ColumnHeader
    Friend WithEvents Poste As ColumnHeader
    Friend WithEvents btn_raffraichir As Button
    Friend WithEvents btn_nouveau As Button
    Friend WithEvents btn_editer As Button
    Friend WithEvents btn_supprimer As Button
    Friend WithEvents btn_imprimer As Button
    Friend WithEvents DateEmbauche As ColumnHeader
    Friend WithEvents Admin As ColumnHeader
    Friend WithEvents btn_quitter As Button
End Class
