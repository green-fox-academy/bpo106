using System;

namespace _14
{
    public class BattleApp
    {
       public BattleApp (Ship ship1, Ship ship2)
        {
            if (ship1.Battle(ship2))
            {
                Console.WriteLine("Ship 1 won!");
            }
            else
            {
                Console.WriteLine("Ship 2 won!");
            }
        }
        

    }
}