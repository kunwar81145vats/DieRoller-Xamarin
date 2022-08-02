using System;
namespace DieRoller
{
    public class DieClass
    { 
        private int totalSides { get; set; }
        private string name { get; set; }
        private int currentSide { get; set; }

        //getter method for total sides
        public int getTotalSides()
        {
            return totalSides;
        }

        //setter method for total sides
        public void setTotalSides(int sides)
        {
            totalSides = sides;
        }

        //getter method for name
        public string getName()
        {
            return name;
        }


        //setter method for name
        public void setName(string value)
        {
            name = value;
        }

        //getter method for current side
        public int getCurrentSide()
        {
            return currentSide;
        }

        //setter method for current side
        public void setCurrentSide(int value)
        {
            currentSide = value;
        }

        //Default constructor creates 6 sided Die
        public DieClass()
        {
            currentSide = 1;
            name = "d6";
            totalSides = 6;
        }

        //Constructor with 1 parameter to set only total sides
        public DieClass(int sides)
        {
            currentSide = 1;
            name = "d" + sides;
            totalSides = sides;
        }

        //Constructor with 2 parameters to set total sides and name
        public DieClass(int sides, string nameValue)
        {
            currentSide = 1;
            name = nameValue;
            totalSides = sides;
        }

        //Constructor with 3 parameters to set total sides, name and current side
        public DieClass(int sides, string nameValue, int current)
        {
            currentSide = current;
            name = nameValue;
            totalSides = sides;
        }

        //Roll random side
        public int rollDie()
        {
            var rnd = new Random();
            var newNum = rnd.Next(1, totalSides);

            return newNum;
        }
    }
}

