using System;
using System.Collections.Generic;

namespace BattleShip
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship Destroyer = new Ship("Destroyer", 2, 2);
            Ship Submarine = new Ship("Submarine", 3, 3);
            Ship Cruiser = new Ship("Cruiser", 3, 3);
            Ship BattleShip = new Ship("BattleShip", 4, 4);
            Ship Carrier = new Ship("Carrier", 5, 5);
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

        }
    }
}
