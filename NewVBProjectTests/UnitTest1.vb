Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports NewVBProject

<TestClass()> Public Class UnitGroupTest1

    <TestMethod()> Public Sub TestGetUnits1()
        Dim unit1 = New Unit(12345)
        Dim unit2 = New Unit(12346)
        Dim unit3 = New Unit(12347)
        Dim newTile = New Tile()
        newTile.addUnit(unit1)
        newTile.addUnit(unit2)
        Dim ug = New UnitGroup(newTile.unitList)
        Dim ugUnitList = ug.getUnits()
        CollectionAssert.AreEqual(newTile.unitList, ugUnitList)
    End Sub

End Class