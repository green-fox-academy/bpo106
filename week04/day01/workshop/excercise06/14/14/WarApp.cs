using System;

namespace _14
{
    public class WarApp
    {
        public WarApp(Armada armada1, Armada armada2)
        {
            if (armada1.War(armada2))
            {
                Console.WriteLine("Armada 1 won!");
            }
            else
            {
                Console.WriteLine("Armada 2 won!");
            }
        }
    }
}