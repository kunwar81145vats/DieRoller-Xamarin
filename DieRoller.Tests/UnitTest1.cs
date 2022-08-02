using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DieRoller.Tests;

[TestClass]
public class UnitTest1
{
    DieClass die;

    [DataTestMethod]
    public void DieNullTest()
    {
        die = new DieClass();
        Assert.IsNotNull(die);
    }

    [DataTestMethod]
    [DataRow(6)]
    [DataRow(9)]
    [DataRow(12)]
    public void TestMethodForOneParameterConstructor(int sides)
    {
        die = new DieClass(sides);
        Assert.AreEqual(sides, die.getTotalSides());
    }

    [DataTestMethod]
    [DataRow(6, "d6")]
    [DataRow(9, "d9")]
    [DataRow(12, "12")]
    public void TestMethodForTwoParameterConstructorSides(int sides, string name)
    {
        die = new DieClass(sides, name);
        Assert.AreEqual(sides, die.getTotalSides());
    }

    [DataTestMethod]
    [DataRow(6, "d6")]
    [DataRow(9, "d9")]
    [DataRow(12, "12")]
    public void TestMethodForTwoParameterConstructorName(int sides, string name)
    {
        die = new DieClass(sides, name);
        Assert.AreEqual(name, die.getName());
    }

    [DataTestMethod]
    [DataRow(6, "d6", 2)]
    [DataRow(9, "d9", 3)]
    [DataRow(12, "12", 4)]
    public void TestMethodForThreeParameterConstructorSides(int sides, string name, int currentSide)
    {
        die = new DieClass(sides, name, currentSide);
        Assert.AreEqual(6, die.getTotalSides());
    }

    [DataTestMethod]
    [DataRow(6, "d6", 2)]
    [DataRow(9, "d9", 3)]
    [DataRow(12, "12", 4)]
    public void TestMethodForThreeParameterConstructorName(int sides, string name, int currentSide)
    {
        die = new DieClass(sides, name, currentSide);
        Assert.AreEqual("d6", die.getName());
    }

    [DataTestMethod]
    [DataRow(6, "d6", 2)]
    [DataRow(9, "d9", 3)]
    [DataRow(12, "12", 4)]
    public void TestMethodForThreeParameterConstructorCurrentSide(int sides, string name, int currentSide)
    {
        die = new DieClass(sides, name, currentSide);
        Assert.AreEqual(2, die.getCurrentSide());
    }

    [DataTestMethod]
    [DataRow(6)]
    [DataRow(9)]
    [DataRow(12)]
    public void TestMethodForValidCurrentSideUp(int sides)
    {
        die = new DieClass(sides);
        die.rollDie();
        if (die.getCurrentSide() <= die.getTotalSides())
        {
            return;
        }
        else
        {
            Assert.Fail();
        }
    }
}
