Imports MySql.Data.MySqlClient
Public Class Connexion
    Private Sub btn_connexion_Click(sender As Object, e As EventArgs) Handles btn_connexion.Click
        Try
            If txt_pseudo.Text = "" And txt_mdp.Text = "" Then
                MsgBox("Veuillez remplir d'abord tous les champs.")
            Else
                Dim connection = BaseDeDonnees.Connect()
                Dim cmd As MySqlCommand = connection.CreateCommand

                If CheckBox1.Checked Then
                    cmd.CommandText = "SELECT * FROM employes WHERE pseudo=@pseudo AND password=@pass AND admin=1"
                    cmd.Parameters.Add("@pseudo", MySqlDbType.VarChar).Value = txt_pseudo.Text
                    cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = txt_mdp.Text

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    If table.Rows.Count() <= 0 Then
                        MsgBox("Pseudo ou mot de passe incorrect, vous n'êtes peut-être pas aussi un administrateur.")
                    Else
                        My.Settings.Pseudo = txt_pseudo.Text
                        My.Settings.Password = txt_mdp.Text
                        MsgBox("Connexion réussie ! Ravie de vous revoir " & txt_pseudo.Text & "")
                        Principale.Show()
                        Me.Hide()
                        connection.Close()
                    End If
                Else
                    cmd.CommandText = "SELECT * FROM employes WHERE pseudo=@pseudo AND password=@pass AND admin=0"
                    cmd.Parameters.Add("@pseudo", MySqlDbType.VarChar).Value = txt_pseudo.Text
                    cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = txt_mdp.Text

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    If table.Rows.Count() <= 0 Then
                        MsgBox("Pseudo ou mot de passe incorrect !")
                    Else
                        My.Settings.Pseudo = txt_pseudo.Text
                        My.Settings.Password = txt_mdp.Text
                        MsgBox("Connexion réussie ! Ravie de vous revoir " & txt_pseudo.Text & "")
                        Emploi_de_temps.Show()
                        Me.Hide()
                        connection.Close()
                    End If
                End If
            End If
        Catch ex As Exception
            Util.ManageError(ex)
        End Try
    End Sub

    Private Sub btn_quitter_Click(sender As Object, e As EventArgs) Handles btn_quitter.Click
        Me.Hide()
        Accueil.Show()
    End Sub
End Class