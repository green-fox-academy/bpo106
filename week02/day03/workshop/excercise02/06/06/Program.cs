using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16 };

            //1. for

            //You'd better not want to see four nested conditional for loops. It's like a bloody matryoshka doll.

            //2. list

            if (list.Contains(4) && list.Contains(8) && list.Contains(12) && list.Contains(16))
            {
                Console.WriteLine("Hoorray");
            }
            else Console.WriteLine("Noooooo");
            Console.ReadLine();
        }
    }
}
