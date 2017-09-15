using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static int Guess(int number, int log)
        {
            Console.Clear();
            Console.Write("Type your guess: ");
            int input = Int32.Parse(Console.ReadLine());
            
            log--;
            if (input < number)
            {
                Console.WriteLine("The number is higher than you need. Now you have only " + log + " guesses.\nPress any key to proceed.");
                Console.ReadLine();
            }
            else if (input > number)
            {
                Console.WriteLine("The number is lower than you need. Now you have only " + log + " guesses.\nPress any key to proceed.");
                Console.ReadLine();
            }

            else
            {
                log = 0;
                Console.WriteLine("You guessed the number! It is " + number + ".\nPress any key to proceed.");
                Console.ReadLine();
            }
            
            return log;
        }

        static void Main(string[] args)
        {
            Console.Write("Set the range.\nFirst number: ");
            int input1 = Int32.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            int input2 = Int32.Parse(Console.ReadLine());

            if (input1 > input2)
            {
                input1 += input2;
                input2 = input1 - input2;
                input1 -= input2;
            }

            int range = input2 - (input1 - 1);
            int two = 1;
            int log;

            for (log = 1; two < range; log++)
            {
                two *= 2;
            }

            Random random = new Random();

            int number = random.Next(input1, input2);

            while (log > 0)
            {
                log = Guess(number, log);
            }
        }
    }
}
