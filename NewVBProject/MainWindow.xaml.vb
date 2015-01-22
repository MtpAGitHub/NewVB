Class MainWindow 

    Private Sub btnAddAll_Click(sender As Object, e As RoutedEventArgs) Handles btnAddAll.Click
        txtBoxResults.Text = "Adding all..."
    End Sub

    Private Sub btnAddSword_Click(sender As Object, e As RoutedEventArgs) Handles btnAddSword.Click
        Dim armsList As New WeaponInventory()
        armsList.addWeapon(WeaponType.Sword, "Cutlas")
        txtBoxResults.Text = armsList.ToString
    End Sub
End Class
