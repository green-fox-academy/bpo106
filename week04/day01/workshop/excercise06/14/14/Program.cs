using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Ship ship1 = new Ship();
            Ship ship2 = new Ship();
            Ship ship3 = new Ship();

            ship1.FillShip(random.Next(30, 42));
            ship1.ShipStatus();
            ship2.FillShip(random.Next(20, 29));
            ship2.ShipStatus();
            ship3.FillShip(random.Next(15, 23));
            ship3.ShipStatus();

            BattleApp battle = new BattleApp(ship1, ship2);

            ship1.ShipStatus();
            ship2.ShipStatus();

            Console.ReadLine();

        }
    }
}
