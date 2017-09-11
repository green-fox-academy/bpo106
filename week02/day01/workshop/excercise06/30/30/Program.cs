using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Int32.TryParse(input, out int num);
            for (int i = 1; i < num / 2 + 1; i++)
            {
                for (int j = num / 2 + 1 - i; j > 0; j--) Console.Write(" ");
                Console.Write("*");
                for (int k = i + 1; k < 2 * i; k++) Console.Write("**");
                Console.WriteLine();
            }
            if (num % 2 == 1)
            {
                for (int i = 1; i < num+1; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = num / 2; i > 0; i--)
            {
                for (int j = num / 2 + 1 - i; j > 0; j--) Console.Write(" ");
                Console.Write("*");
                for (int k = i + 1; k < 2 * i; k++) Console.Write("**");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
