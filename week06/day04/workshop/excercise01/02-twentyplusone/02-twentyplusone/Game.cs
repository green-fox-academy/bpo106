using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_twentyplusone
{
    public class Game
    {
        Random random = new Random();

        public int GenerateOpponent()
        {
            return random.Next(15, 22);
        }

        public void Continue()
        {
            Console.WriteLine("Would you want to continue drawing? (Y/N)");
            string input = Console.ReadLine();
            if (input == "Y" || input == "y")
            {
                //do something
            }
            else if (input == "N" || input == "n")
            {
                //do something else
            }
            else
            {
                Console.WriteLine("Dude, can you even read?");
                Continue();
            }
        }
    }
}
