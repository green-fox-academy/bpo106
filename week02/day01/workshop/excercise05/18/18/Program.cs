using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Int32.TryParse(input, out int number);
            if (number % 2 == 0) Console.WriteLine("Even");
            else Console.WriteLine("Odd");
            Console.ReadLine();
        }
    }
}
