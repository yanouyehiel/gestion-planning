Imports MySql.Data.MySqlClient
Module BaseDeDonnees

    'Permet de créer la connection
    Public Function Connect()
        Dim chaineConnection As String = "Datasource=localhost;user id=root;Database=gestion-planning;password="
        Dim connection = New MySqlConnection(chaineConnection)

        Try
            If connection.State <> ConnectionState.Open Then
                connection.Open()
            End If
        Catch ex As Exception
            Util.Manageerror(ex)
        End Try
        Return connection
    End Function

    Public Function GetCommande(ByVal sql As String) As MySqlCommand
        Dim cmd = Connect().CreateCommand
        cmd.CommandText = sql
        Return cmd
    End Function
End Module
