Public Class Laser
    Implements Weapon

    Public Function attack() As String Implements Weapon.attack
        Return "Lighter slice !"
    End Function
End Class
