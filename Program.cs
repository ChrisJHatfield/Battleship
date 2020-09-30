using System;
using System.Collections.Generic;

namespace BattleShip
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship Destroyer = new Ship("Destroyer", 2, 2, false);
            Ship Submarine = new Ship("Submarine", 3, 3, false);
            Ship Cruiser = new Ship("Cruiser", 3, 3, false);
            Ship BattleShip = new Ship("BattleShip", 4, 4, false);
            Ship Carrier = new Ship("Carrier", 5, 5, false);
            List<Ship> Fleet = new List<Ship>();
            Fleet.Add(Destroyer);
            Fleet.Add(Submarine);
            Fleet.Add(Cruiser);
            Fleet.Add(BattleShip);
            Fleet.Add(Carrier);
            Player p1 = new Player("Jimbo", Fleet);
            Player p2 = new Player("Chris", Fleet);
            Console.WriteLine(p1.Name);
            Console.WriteLine(p2.Name);
            Player.Greeting();
            Console.WriteLine(p1.BattleGrid.Warzone);
        }
    }
}
