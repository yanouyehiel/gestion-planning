Public Class Principale
    Private Sub btn_ajout_employe_Click(sender As Object, e As EventArgs) Handles btn_ajout_employe.Click
        Employes.Show()
        Me.Hide()
    End Sub

    Private Sub btn_liste_employe_Click(sender As Object, e As EventArgs) Handles btn_liste_employe.Click
        Liste_des_employes.Show()
        Me.Hide()
    End Sub

    Private Sub btn_planning_Click(sender As Object, e As EventArgs) Handles btn_planning.Click

    End Sub

    Private Sub btn_quitter_Click(sender As Object, e As EventArgs) Handles btn_quitter.Click
        Me.Hide()
        Accueil.Show()
    End Sub
End Class