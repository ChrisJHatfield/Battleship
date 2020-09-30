using System;
using System.Collections.Generic;

namespace BattleShip
{
    public class Ship
    {
        public string Name;
        public int Length;
        public int Health;
        //public List<object> Position;

        public Ship(string name, int length, int health)
        {
            Name = name;
            Length = length;
            Health = health;
        }
    }
}
