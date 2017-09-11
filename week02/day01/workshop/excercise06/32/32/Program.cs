using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Int32.TryParse(input, out int num);
            for (int i = 0; i < num; i++) Console.Write("%");
            Console.WriteLine();
            for (int i = 2; i < num; i++)
            {
                Console.Write("%");
                for (int j = 2; j < num; j++)
                {
                    if (j == i) Console.Write("%");
                    else Console.Write(" ");
                }
                Console.WriteLine("%");
            }
            for (int i = 0; i < num; i++) Console.Write("%");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
