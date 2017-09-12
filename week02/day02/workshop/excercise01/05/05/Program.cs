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
            var input = Console.ReadLine();
            Int32.TryParse(input, out int num);
            Console.WriteLine(factorio(num));
            Console.ReadLine();
        }

        static int factorio(int factor)
        {
            for (int i = factor - 1; i > 1; i--) factor *= i;
            return factor;
        }
    }
}
