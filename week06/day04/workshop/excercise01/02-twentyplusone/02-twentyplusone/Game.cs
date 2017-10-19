using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_twentyplusone
{
    public static class Game
    {
        public static bool hasToStop = false;
        static Random random = new Random();

        public static int Sum(List<Card> list)
        {
            return list.Sum(x => x.colorSuitRank[2]);
        }

        public static void Continue()
        {
            Console.WriteLine("Do you want to continue? (Y/N)");
            string input = Console.ReadLine();
            if (input.ToLower() == "n")
            {
                hasToStop = true;
                return;
            }
            else if (input.ToLower() != "y")
            {
                Console.WriteLine("Wrong character, dude.");
            }
        }
    }
}
