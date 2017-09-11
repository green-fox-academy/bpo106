using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine();
            Int32.TryParse(input1, out int number1);
            var input2 = Console.ReadLine();
            Int32.TryParse(input2, out int number2);
            if (number2 > number1) Console.WriteLine(input2);
            else Console.WriteLine(input1);
            Console.ReadLine();
        }
    }
}
