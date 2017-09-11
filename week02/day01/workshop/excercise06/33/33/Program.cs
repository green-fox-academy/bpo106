using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores a number, and the user has to figure it out.
            // The user can input guesses, after each guess the program would tell one
            // of the following:
            //
            // The stored number is higher
            // The stried number is lower
            // You found the number: 
            int guess = 8;
            var input = Console.ReadLine();
            Int32.TryParse(input, out int num);
            while (num != guess)
             {
                 if (num > guess)
                    Console.WriteLine("The stored number is lower.");
                 else
                    Console.WriteLine("The stored number is higher.");
                 input = Console.ReadLine();
                 Int32.TryParse(input, out num);
             }
             Console.WriteLine("You found the number: " + guess);
            Console.ReadLine();
        }
    }
}
