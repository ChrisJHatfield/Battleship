using System;
using System.Collections.Generic;

namespace BattleShip
{
    public class Player
    {
        public string Name;
        public List<Ship> Fleet;

        public Player(string name, List<Ship> fleet)
        {
            Name = name;
            Fleet = fleet;
        }

        public static void Greeting()
        {
            Console.WriteLine("What's Good Guy?");
        }
    }
}