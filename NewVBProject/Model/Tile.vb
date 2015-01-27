Public Class Tile
    Private _unitList As List(Of Unit)
    Public Property unitList() As List(Of Unit)
        Get
            Return _unitList
        End Get
        Set(ByVal value As List(Of Unit))
            _unitList = value
        End Set
    End Property

    Public Sub New()
        'constructor with no args
    End Sub

    Public Function addUnit(ByVal newUnit As Unit)
        If IsNothing(Me._unitList) Then
            Me._unitList = New List(Of Unit)
        End If
        Me._unitList.Add(newUnit)
    End Function

    Public Function removeUnit(ByVal delUnit As Unit) As Boolean
        Return Me._unitList.Remove(delUnit)
    End Function

    Public Function removeUnits() As Boolean
        Me._unitList.Clear()
        Return True
    End Function
End Class
