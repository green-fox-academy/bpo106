using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };

            // Check if the arrayList contains "7" if it contains print "Hoorray" otherwise print "Noooooo"
            // Do this again with a different solution using different list functions!

            //1. for-os

            /*for (int i=0;i< list.Count;i++)
            {
                if (list[i] == 7)
                {
                    Console.WriteLine("Hoorray");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Noooooo");
            Console.ReadLine();*/

            //2. listakeresős

            if (list.Contains(7))
            {
                Console.WriteLine("Hoorray");
            }
            else Console.WriteLine("Noooooo");
            Console.ReadLine();
        }
    }
}
