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

            ship1.ShipStatus();
            ship2.ShipStatus();

            BattleApp battle = new BattleApp(ship1, ship2);

            ship1.ShipStatus();
            ship2.ShipStatus();

            Console.ReadLine();

            Armada armada1 = new Armada();
            Armada armada2 = new Armada();

            armada1.FillFleet(random.Next(1, 42));
            armada2.FillFleet(random.Next(1, 42));

            WarApp war = new WarApp(armada1, armada2);

            Console.ReadLine();
        }
    }
}
