using System;

namespace BattleShip
{
    public class Submarine : Ship
    {
        public Submarine(string Name, int Length, int Health, bool isSunk) : base(Name, Length, Health, isSunk)
        {
            Name = "Submarine";
            Length = 3;
            Health = 3;
            isSunk = false;
        }
    }
}