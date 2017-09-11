using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Int32.TryParse(input, out int number);
            if (number < 1) Console.WriteLine("Not enough");
            else {
                switch (number)
                {
                    case 1: Console.WriteLine("One");
                        break;
                    case 2: Console.WriteLine("Two");
                        break;
                    default: Console.WriteLine("A lot");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
