Public Class Accueil
    Private Sub btn_quit_Click(sender As Object, e As EventArgs) Handles btn_quit.Click
        If MsgBox("Souhaitez-vous vraiment quitter ?", 36, "Confirmation de sortie") = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub btn_connect_Click(sender As Object, e As EventArgs) Handles btn_connect.Click
        Connexion.Show()
        Me.Hide()
    End Sub
End Class