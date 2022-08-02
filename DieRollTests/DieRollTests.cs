using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using DieRoller;

namespace DieRollTests
{
    [TestClass]
    public class DieRollTests
    {
        DieClass die = new DieClass();

        [TestMethod]
        public void NotNullTest()
        {
            die.Should().NotBeNull();
        }

        [TestMethod]
        [DataRow(6)]
        [DataRow(9)]
        [DataRow(12)]
        public void TestOneParameterConstructor(int sides)
        {
            die = new DieClass(sides);
            die.GetTotalSides().Should().Be(sides);
        }

        [TestMethod]
        [DataRow(6, "d6")]
        [DataRow(9, "d9")]
        [DataRow(12, "12")]
        public void TestTwoParameterConstructorSides(int sides, string name)
        {
            die = new DieClass(sides, name);
            die.GetTotalSides().Should().Be(sides);
            die.GetName().Should().Be(name);
        }

        [TestMethod]
        [DataRow(6, "d6", 2)]
        [DataRow(9, "d9", 3)]
        [DataRow(12, "12", 4)]
        public void TestThreeParameterConstructorName(int sides, string name, int currentSide)
        {
            die = new DieClass(sides, name, currentSide);

            die.GetTotalSides().Should().Be(sides);
            die.GetName().Should().Be(name);
            die.GetCurrentSide().Should().Be(currentSide);
        }

        [TestMethod]
        [DataRow(6)]
        [DataRow(9)]
        [DataRow(12)]
        public void TestValidCurrentSideUp(int sides)
        {
            die = new DieClass(sides);
            die.RollDie();

            die.GetCurrentSide().Should().BeInRange(1, die.GetTotalSides());
        }


    }
}

