using System;
using System.Collections.Generic;
using System.Linq;

namespace _09
{
    class Program
    {
        static void toStringQuery(char[] s)
        {
            var stringElements = from element in s
                                select element.ToString();

            Console.WriteLine(String.Join("", stringElements.Select(x => x.ToString().ToArray())));
        }

        static void toStringLambda(char[] s)
        {
            Console.WriteLine(String.Join("", s.Select(x => x.ToString().ToArray())));
        }

        static void Main(string[] args)
        {
            char[] s = { 'B', 'a', 's', 'z', 'ó', 'd', 'j', 'á', 'l', ' ', 'm', 'e', 'g', ',', ' ', 'K', 'D', 'N', 'P', '!' };

            toStringQuery(s);
            Console.WriteLine();
            toStringLambda(s);

            Console.ReadLine();
        }
    }
}
