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
        public void notNullTest()
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
            sides.Should().Equals(die.getTotalSides());
        }

        [TestMethod]
        [DataRow(6, "d6")]
        [DataRow(9, "d9")]
        [DataRow(12, "12")]
        public void TestTwoParameterConstructorSides(int sides, string name)
        {
            die = new DieClass(sides, name);
            sides.Should().Equals(die.getTotalSides());
            name.Should().Equals(die.getName());
        }

        [TestMethod]
        [DataRow(6, "d6", 2)]
        [DataRow(9, "d9", 3)]
        [DataRow(12, "12", 4)]
        public void TestThreeParameterConstructorName(int sides, string name, int currentSide)
        {
            die = new DieClass(sides, name, currentSide);

            sides.Should().Equals(die.getTotalSides());
            name.Should().Equals(die.getName());
            currentSide.Should().Equals(die.getCurrentSide());
        }

        [TestMethod]
        [DataRow(6)]
        [DataRow(9)]
        [DataRow(12)]
        public void TestValidCurrentSideUp(int sides)
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
}

