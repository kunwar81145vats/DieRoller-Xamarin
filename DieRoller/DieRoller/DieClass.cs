using System;
namespace DieRoller
{
    public class DieClass
    { 
        private int TotalSides { get; set; }
        private string Name { get; set; }
        private int CurrentSide { get; set; }

        //getter method for total sides
        public int GetTotalSides()
        {
            return TotalSides;
        }

        //setter method for total sides
        public void SetTotalSides(int sides)
        {
            TotalSides = sides;
        }

        //getter method for name
        public string GetName()
        {
            return Name;
        }


        //setter method for name
        public void SetName(string value)
        {
            Name = value;
        }

        //getter method for current side
        public int GetCurrentSide()
        {
            return CurrentSide;
        }

        //setter method for current side
        public void SetCurrentSide(int value)
        {
            CurrentSide = value;
        }

        //Default constructor creates 6 sided Die
        public DieClass()
        {
            CurrentSide = 1;
            Name = "d6";
            TotalSides = 6;
        }

        //Constructor with 1 parameter to set only total sides
        public DieClass(int sides)
        {
            CurrentSide = 1;
            Name = "d" + sides;
            TotalSides = sides;
        }

        //Constructor with 2 parameters to set total sides and name
        public DieClass(int sides, string nameValue)
        {
            CurrentSide = 1;
            Name = nameValue;
            TotalSides = sides;
        }

        //Constructor with 3 parameters to set total sides, name and current side
        public DieClass(int sides, string nameValue, int current)
        {
            CurrentSide = current;
            Name = nameValue;
            TotalSides = sides;
        }

        //Roll random side
        public int RollDie()
        {
            var rnd = new Random();
            CurrentSide = rnd.Next(1, TotalSides);

            return CurrentSide;
        }
    }
}

