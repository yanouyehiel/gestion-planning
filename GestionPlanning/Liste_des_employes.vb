Imports MySql.Data.MySqlClient
Public Class Liste_des_employes
    Private Sub Liste_des_employes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RemplirListeView()
    End Sub

    Private Sub RemplirListeView()
        'ListViewEmployes.Clear()
        Try
            Dim connection = BaseDeDonnees.Connect()
            Dim cmd As MySqlCommand = connection.CreateCommand
            cmd.CommandText = "SELECT * FROM employes"

            Dim resultat = cmd.ExecuteReader()
            While resultat.Read
                Dim item As ListViewItem = New ListViewItem(resultat.GetString("nom"))
                item.SubItems.Add(resultat.GetString("prenom"))
                item.SubItems.Add(resultat.GetString("email"))
                item.SubItems.Add(resultat.GetString("poste"))
                item.SubItems.Add(resultat.GetString("date_embauche"))
                item.SubItems.Add(resultat.GetString("admin"))
                ListViewEmployes.Items.Add(item)
            End While
        Catch ex As Exception
            Util.ManageError(ex)
        End Try
    End Sub

    Private Sub btn_nouveau_Click(sender As Object, e As EventArgs) Handles btn_nouveau.Click
        Dim formAjout = New Employes
        formAjout.Show()
    End Sub

    Private Sub btn_imprimer_Click(sender As Object, e As EventArgs) Handles btn_imprimer.Click
        Accueil.Show()
        Me.Hide()
    End Sub

    Private Sub btn_quitter_Click(sender As Object, e As EventArgs) Handles btn_quitter.Click
        Me.Hide()
        Principale.Show()
    End Sub
End Class
