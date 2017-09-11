using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine();
            Int32.TryParse(input1, out int int1);
            var input2 = Console.ReadLine();
            Int32.TryParse(input2, out int int2);
            if (int1 > int2) Console.WriteLine("The second number should be bigger.");
            else for (; int1 < int2+1; int1++) Console.WriteLine(int1);
            Console.ReadLine();
        }
    }
}
