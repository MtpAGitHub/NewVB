Public Class UnitGroup

    Private _unitGroupList As Dictionary(Of Integer, Unit)
    Public Property unitGroupList() As Dictionary(Of Integer, Unit)
        Get
            Return _unitGroupList
        End Get
        Set(ByVal value As Dictionary(Of Integer, Unit))
            _unitGroupList = value
        End Set
    End Property

    Public Sub New()
        'No args constructor
    End Sub

    Public Sub New(ByVal unitList As List(Of Unit))
        Me._unitGroupList = New Dictionary(Of Integer, Unit)
        For Each curUnit As Unit In unitList
            Me._unitGroupList.Add(curUnit.unitId, curUnit)
        Next
    End Sub

    Public Function addUnit(ByVal newUnit As Unit)
        If Me._unitGroupList Is Nothing Then
            Me._unitGroupList = New Dictionary(Of Integer, Unit)
        End If
        Me._unitGroupList.Add(newUnit.unitId, newUnit)
    End Function

    Public Function removeUnit(ByVal delUnit As Unit) As Boolean
        Return Me._unitGroupList.Remove(delUnit.unitId)
    End Function

    Public Function getUnits() As List(Of Unit)
        Dim unitList = New List(Of Unit)
        Dim unitGroupPair As KeyValuePair(Of Integer, Unit)
        For Each unitGroupPair In Me._unitGroupList
            unitList.Add(unitGroupPair.Value)
        Next
        Return unitList
    End Function
End Class
