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
            string[] abc = { "first", "second", "third" };
            abc=swap(abc);
            Console.ReadLine();
        }

        static string[] swap (string[] elements)
        {
            string temp = elements[0];
            elements[0] = elements[2];
            elements[2] = temp;
            return elements;
        }
    }
}
