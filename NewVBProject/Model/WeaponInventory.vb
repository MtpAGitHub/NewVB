Imports System.Text

Public Class WeaponInventory

    Private _weaponList As Dictionary(Of WeaponType, String)
    Public Property weaponList() As Dictionary(Of WeaponType, String)
        Get
            Return _weaponList
        End Get
        Set(ByVal value As Dictionary(Of WeaponType, String))
            _weaponList = value
        End Set
    End Property

    Public Sub New()
        'blank constructor
    End Sub

    Public Function addWeapon(ByVal weaponKey As WeaponType, ByVal weaponName As String)
        If IsNothing(Me._weaponList) Then
            Me._weaponList = New Dictionary(Of WeaponType, String)
        End If
        Me._weaponList.Add(weaponKey, weaponName)
    End Function

    Public Overrides Function ToString() As String
        Dim weaponPair As KeyValuePair(Of WeaponType, String)
        Dim sb As New StringBuilder
        sb.Append("WeaponInventory [ ")
        For Each weaponPair In _weaponList
            sb.Append("item : " & weaponPair.Key & "-" & weaponPair.Value & vbCr)
        Next
        sb.Append(" ]")
        Return sb.ToString()
    End Function
End Class
