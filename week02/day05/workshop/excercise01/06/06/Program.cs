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
            string input = Console.ReadLine();
            int inputnum = Int32.Parse(input);
            int number = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int k = 1;
                for (int j = 0; j < input.Length; j++)
                {
                    k *= (int)char.GetNumericValue(input[i]);
                }
                number += k;
            }

            if (number == inputnum) Console.WriteLine(number + " is an Armstrong number.");
            else Console.WriteLine(inputnum + " is not an Armstrong number.");
            Console.ReadLine();
        }
    }
}
