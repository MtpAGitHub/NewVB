Public Class Unit

    Private _unitId As Integer
    Public Property unitId() As Integer
        Get
            Return _unitId
        End Get
        Set(ByVal value As Integer)
            _unitId = value
        End Set
    End Property
    Private _unitType As UnitType
    Public Property unitType() As UnitType
        Get
            Return _unitType
        End Get
        Set(ByVal value As UnitType)
            _unitType = value
        End Set
    End Property
    Private _unitName As String
    Public Property unitName() As String
        Get
            Return _unitName
        End Get
        Set(ByVal value As String)
            _unitName = value
        End Set
    End Property
    Private _unitWeapons As WeaponInventory
    Public Property unitWeapons() As WeaponInventory
        Get
            Return _unitWeapons
        End Get
        Set(ByVal value As WeaponInventory)
            _unitWeapons = value
        End Set
    End Property
    Private _unitProperties As Dictionary(Of String, String)
    Public Property unitProperties() As Dictionary(Of String, String)
        Get
            Return _unitProperties
        End Get
        Set(ByVal value As Dictionary(Of String, String))
            _unitProperties = value
        End Set
    End Property


    Public Sub New()
        'empty constructor
    End Sub

    Public Sub New(ByVal newId As Integer)
        Me._unitId = newId
    End Sub

    Public Function addNewProperty(ByVal newPropertyKey As String, ByVal newPropertyValue As String)
        If IsNothing(Me.unitProperties) Then
            Me.unitProperties = New Dictionary(Of String, String)
        End If
        Me.unitProperties.Add(newPropertyKey, newPropertyValue)
    End Function
End Class
