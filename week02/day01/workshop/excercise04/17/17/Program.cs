using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = new string[5];
            int[] number = new int[5];
            int sum = 0;
            int i = 0;
            double d = 0.0;
            for (;i<5;i++)
            {
                input[i] = Console.ReadLine();
                Int32.TryParse(input[i], out number[i]);
                sum += number[i];
            }
            d = i;
            Console.Write("Sum: ");
            Console.WriteLine(sum);
            Console.Write("Average: ");
            Console.WriteLine(sum/d);
            Console.ReadLine();
        }
    }
}
