Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports NewVBProject

'Test whether the removeUnit method on class Tile works correctly

<TestClass()> Public Class TileUnitTest2

    <TestMethod()> Public Sub TestRemoveUnit()
        Dim newUnit = New Unit(12345)
        Dim newTile = New Tile()
        newTile.addUnit(newUnit)
        Dim preSize = newTile.unitList.Count
        Assert.AreEqual(True, newTile.removeUnit(newUnit))
    End Sub

End Class