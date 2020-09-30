using System;

namespace BattleShip
{
    public class Battleship : Ship
    {
        public Battleship(string Name, int Length, int Health, bool isSunk) : base(Name, Length, Health, isSunk)
        {
            Name = "Battleship";
            Length = 4;
            Health = 4;
            IsSunk = false;
        }
    }
}