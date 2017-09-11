using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Int32.TryParse(input, out int num);
            for (int i = 1; i < 11; i++) Console.WriteLine(i + " * " + num + " = " + i * num);
            Console.ReadLine();
        }
    }
}
