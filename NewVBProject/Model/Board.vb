Public Class Board

    Private _boardWidth As Integer
    Public Property boardWidth() As Integer
        Get
            Return _boardWidth
        End Get
        Set(ByVal value As Integer)
            _boardWidth = value
        End Set
    End Property
    Private _boardHeight As Integer
    Public Property boardHeight() As Integer
        Get
            Return _boardHeight
        End Get
        Set(ByVal value As Integer)
            _boardHeight = value
        End Set
    End Property
    Private _xPosList As List(Of Tile)
    Public Property xPosList() As List(Of Tile)
        Get
            Return _xPosList
        End Get
        Set(ByVal value As List(Of Tile))
            _xPosList = value
        End Set
    End Property
    Private _boardGrid As List(Of List(Of Tile))
    Public Property NewProperty() As List(Of List(Of Tile))
        Get
            Return _boardGrid
        End Get
        Set(ByVal value As List(Of List(Of Tile)))
            _boardGrid = value
        End Set
    End Property

    Public Function getTile(ByVal xPos As Integer, ByVal yPos As Integer) As Tile
        Dim boardRow = Me._boardGrid(yPos)
        Return boardRow(xPos)
    End Function

    Public Function addUnit(ByVal newUnit As Unit, ByVal xPos As Integer, ByVal yPos As Integer) As Boolean
        Dim selectedTile = getTile(xPos, yPos)
        selectedTile.addUnit(newUnit)
        Return True
    End Function

    Public Function removeUnit(ByVal delUnit As Unit, ByVal xPos As Integer, ByVal yPos As Integer) As Boolean
        Dim selectedTile = getTile(xPos, yPos)
        Return selectedTile.removeUnit(delUnit)
    End Function

    Public Function removeUnits(ByVal xPos As Integer, yPos As Integer)
        Dim selectedTile = getTile(xPos, yPos)
        selectedTile.removeUnits()
    End Function

    Public Function getUnits(ByVal xPos As Integer, yPos As Integer) As List(Of Unit)
        Dim selectedTile = getTile(xPos, yPos)
        Return selectedTile.unitList()
    End Function
End Class
