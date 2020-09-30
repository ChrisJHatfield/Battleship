using System;
using System.Collections.Generic;

namespace BattleShip
{
    public class Ship
    {
        public string Name;
        public int Length;
        public int Health;
        public bool IsSunk;

        public Ship(string name, int length, int health, bool isSunk)
        {
            Name = name;
            Length = length;
            Health = health;
            IsSunk = isSunk;
        }

    }
}