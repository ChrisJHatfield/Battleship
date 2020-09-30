using System;

namespace BattleShip
{
    public class Cruiser : Ship
    {
        public Cruiser(string Name, int Length, int Health, bool isSunk) : base(Name, Length, Health, isSunk)
        {
            Name = "Cruiser";
            Length = 3;
            Health = 3;
            isSunk = false;
        }
    }
}