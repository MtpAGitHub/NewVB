Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports NewVBProject

<TestClass()> Public Class TileUnitTest1

    <TestMethod()> Public Sub TestConstructor1()
        Dim newUnit = New Unit()
        Assert.IsNotNull(newUnit)
    End Sub

    <TestMethod()> Public Sub TestConstructor2()
        Dim newUnit = New Unit(12345)
        Assert.AreEqual(12345, newUnit.unitId)
    End Sub

End Class