using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    class Program
    {
        static int Add (int a, int b)
        {
            return a + b;
        }

        static int Diff(int a, int b)
        {
            return a - b;
        }

        static int Multi(int a, int b)
        {
            return a * b;
        }

        static int Div(int a, int b)
        {
            return a / b;
        }

        static int Mod(int a, int b)
        {
            return a % b;
        }

        static void Main(string[] args)
        {
            // Create a simple calculator application which reads the parameters from the prompt
            // and prints the result to the prompt.
            // It should support the following operations:
            // +, -, *, /, % and it should support two operands.
            // The format of the expressions must be: {operation} {operand} {operand}.
            // Examples: "+ 3 3" (the result will be 6) or "* 4 4" (the result will be 16)

            // You can use the Scanner class
            // It should work like this:

            // Start the program
            // It prints: "Please type in the expression:"
            // Waits for the user input
            // Print the result to the prompt
            // Exit

            Console.WriteLine("Please type in the expression:");
            string input = Console.ReadLine();
            int output;
            List<string> list = input.Split(' ').ToList();
            int a = Int32.Parse(list[1]);
            int b = Int32.Parse(list[2]);

            if (list[0] == "+") output = Add(a, b);

            else if (list[0] == "-") output = Diff(a, b);

            else if (list[0] == "*") output = Diff(a, b);

            else if (list[0] == "/") output = Div(a, b);

            else output = Mod(a, b);

            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
