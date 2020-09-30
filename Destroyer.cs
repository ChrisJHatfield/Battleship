using System;

namespace BattleShip
{
    public class Destroyer : Ship
    {
        public Destroyer(string Name, int Length, int Health, bool isSunk) : base(Name, Length, Health, isSunk)
        {
            Name = "Destroyer";
            Length = 2;
            Health = 2;
            isSunk = false;
        }
    }
}