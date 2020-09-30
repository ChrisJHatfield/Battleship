using System;

namespace BattleShip
{
    public class Carrier : Ship
    {
        public Carrier(string Name, int Length, int Health, bool isSunk) : base(Name, Length, Health, isSunk)
        {
            Name = "Carrier";
            Length = 5;
            Health = 5;
            IsSunk = false;
        }
    }
}