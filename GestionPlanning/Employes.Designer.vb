<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employes
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_nom = New System.Windows.Forms.TextBox()
        Me.txt_prenom = New System.Windows.Forms.TextBox()
        Me.date_embauche = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_commentaire = New System.Windows.Forms.TextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_annuler = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.combo_poste = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(129, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(129, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Prénom"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(129, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Poste"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(129, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date d'embauche"
        '
        'txt_nom
        '
        Me.txt_nom.Location = New System.Drawing.Point(250, 75)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.Size = New System.Drawing.Size(188, 20)
        Me.txt_nom.TabIndex = 4
        '
        'txt_prenom
        '
        Me.txt_prenom.Location = New System.Drawing.Point(250, 105)
        Me.txt_prenom.Name = "txt_prenom"
        Me.txt_prenom.Size = New System.Drawing.Size(188, 20)
        Me.txt_prenom.TabIndex = 5
        '
        'date_embauche
        '
        Me.date_embauche.Location = New System.Drawing.Point(251, 174)
        Me.date_embauche.Name = "date_embauche"
        Me.date_embauche.Size = New System.Drawing.Size(187, 20)
        Me.date_embauche.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(129, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Commentaire"
        '
        'txt_commentaire
        '
        Me.txt_commentaire.Location = New System.Drawing.Point(250, 217)
        Me.txt_commentaire.Multiline = True
        Me.txt_commentaire.Name = "txt_commentaire"
        Me.txt_commentaire.Size = New System.Drawing.Size(188, 101)
        Me.txt_commentaire.TabIndex = 9
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(168, 351)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(90, 30)
        Me.btn_save.TabIndex = 10
        Me.btn_save.Text = "Enregistrer"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_annuler
        '
        Me.btn_annuler.Location = New System.Drawing.Point(309, 351)
        Me.btn_annuler.Name = "btn_annuler"
        Me.btn_annuler.Size = New System.Drawing.Size(90, 30)
        Me.btn_annuler.TabIndex = 11
        Me.btn_annuler.Text = "Annuler"
        Me.btn_annuler.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(204, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(182, 24)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Nouveau Employe"
        '
        'combo_poste
        '
        Me.combo_poste.FormattingEnabled = True
        Me.combo_poste.Location = New System.Drawing.Point(250, 138)
        Me.combo_poste.Name = "combo_poste"
        Me.combo_poste.Size = New System.Drawing.Size(188, 21)
        Me.combo_poste.TabIndex = 13
        '
        'Employes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 450)
        Me.Controls.Add(Me.combo_poste)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_annuler)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.txt_commentaire)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.date_embauche)
        Me.Controls.Add(Me.txt_prenom)
        Me.Controls.Add(Me.txt_nom)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Employes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajout et modification employes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_nom As TextBox
    Friend WithEvents txt_prenom As TextBox
    Friend WithEvents date_embauche As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_commentaire As TextBox
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_annuler As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents combo_poste As ComboBox
End Class
