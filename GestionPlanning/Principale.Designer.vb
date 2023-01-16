<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principale
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
        Me.btn_ajout_employe = New System.Windows.Forms.Button()
        Me.btn_liste_employe = New System.Windows.Forms.Button()
        Me.btn_planning = New System.Windows.Forms.Button()
        Me.btn_quitter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_ajout_employe
        '
        Me.btn_ajout_employe.Location = New System.Drawing.Point(143, 214)
        Me.btn_ajout_employe.Name = "btn_ajout_employe"
        Me.btn_ajout_employe.Size = New System.Drawing.Size(121, 23)
        Me.btn_ajout_employe.TabIndex = 0
        Me.btn_ajout_employe.Text = "Nouveau Employé"
        Me.btn_ajout_employe.UseVisualStyleBackColor = True
        '
        'btn_liste_employe
        '
        Me.btn_liste_employe.Location = New System.Drawing.Point(337, 214)
        Me.btn_liste_employe.Name = "btn_liste_employe"
        Me.btn_liste_employe.Size = New System.Drawing.Size(137, 23)
        Me.btn_liste_employe.TabIndex = 1
        Me.btn_liste_employe.Text = "Liste des employés"
        Me.btn_liste_employe.UseVisualStyleBackColor = True
        '
        'btn_planning
        '
        Me.btn_planning.Location = New System.Drawing.Point(542, 214)
        Me.btn_planning.Name = "btn_planning"
        Me.btn_planning.Size = New System.Drawing.Size(117, 23)
        Me.btn_planning.TabIndex = 2
        Me.btn_planning.Text = "Gérer Planning"
        Me.btn_planning.UseVisualStyleBackColor = True
        '
        'btn_quitter
        '
        Me.btn_quitter.Location = New System.Drawing.Point(337, 282)
        Me.btn_quitter.Name = "btn_quitter"
        Me.btn_quitter.Size = New System.Drawing.Size(137, 23)
        Me.btn_quitter.TabIndex = 3
        Me.btn_quitter.Text = "Quitter"
        Me.btn_quitter.UseVisualStyleBackColor = True
        '
        'Principale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_quitter)
        Me.Controls.Add(Me.btn_planning)
        Me.Controls.Add(Me.btn_liste_employe)
        Me.Controls.Add(Me.btn_ajout_employe)
        Me.Name = "Principale"
        Me.Text = "Interface d'administration"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_ajout_employe As Button
    Friend WithEvents btn_liste_employe As Button
    Friend WithEvents btn_planning As Button
    Friend WithEvents btn_quitter As Button
End Class
