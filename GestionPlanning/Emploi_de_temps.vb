Imports MySql.Data.MySqlClient
Public Class Emploi_de_temps
    Private Sub Emploi_de_temps_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowPlanning()
        'nom_enseignant.Text = My.Settings.Pseudo
    End Sub

    Private Sub ShowPlanning()
        Try
            Dim id As Integer
            Dim connection = BaseDeDonnees.Connect()
            Dim cmd As MySqlCommand = connection.CreateCommand
            cmd.CommandText = "SELECT * FROM employes WHERE pseudo=@pseudo"
            cmd.Parameters.Add("@pseudo", MySqlDbType.VarChar).Value = My.Settings.Pseudo
            Dim resultat = cmd.ExecuteReader()

            While resultat.Read
                nom_enseignant.Text = resultat.GetString("nom")
                prenom_enseignant.Text = resultat.GetString("prenom")
                pseudo_enseignant.Text = resultat.GetString("pseudo")
                id = resultat.GetInt32("id")
            End While

            Dim cmd1 As MySqlCommand = connection.CreateCommand
            cmd1.CommandText = "SELECT * FROM planning, cours, employes WHERE planning.id_cours=cours.id AND planning.id_enseignant=@id"
            cmd1.Parameters.Add("@id", MySqlDbType.Int32).Value = resultat.GetInt32("id")
            Dim resultat1 = cmd1.ExecuteReader()

            While resultat1.Read
                Dim item As ListViewItem = New ListViewItem(resultat1.GetString("intitule"))
                item.SubItems.Add(resultat1.GetDateTime("date_debut"))
                item.SubItems.Add(resultat1.GetDateTime("date_fin"))
                item.SubItems.Add(resultat1.GetString("salle"))
                ListEmploiTemps.Items.Add(item)
            End While
        Catch ex As Exception
            Util.ManageError(ex)
        End Try
    End Sub

    Private Sub btn_quitter_Click(sender As Object, e As EventArgs) Handles btn_quitter.Click
        Me.Hide()
        Accueil.Show()
    End Sub
End Class