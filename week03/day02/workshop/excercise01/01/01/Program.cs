using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Divide (int input)
        {
            try
            {
                input = 10 / input;
                Console.WriteLine(input);
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine("fail");
            }

            finally
            {
                Console.ReadLine();
            }
        }

        static void Main(string[] args)
        {
            Divide(Int32.Parse(Console.ReadLine()));
        }
    }
}
