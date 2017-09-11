using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34
{
    class Program
    {
        // Write a program that asks for a number.
        // It would ask this many times to enter an integer,
        // if all the integers are entered, it should print the sum and average of these
        // integers like:
        //
        // Sum: 22, Average: 4.4

        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Int32.TryParse(input, out int num);
            int tomb;
            int sum = 0; double avg = num;
            for (int i = 0; i < num; i++)
            {
                input = Console.ReadLine();
                Int32.TryParse(input, out tomb);
                sum = sum + tomb;
            }
            avg = sum / avg;
            Console.WriteLine(sum);
            Console.WriteLine(avg);
            Console.ReadLine();
        }
    }
}
