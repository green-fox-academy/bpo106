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

            string str = "";
            foreach (var element in stringElements)
            {
                str += element;
            }
            Console.WriteLine(str);
        }

        static void toStringLambda(char[] s)
        {
            Console.WriteLine(String.Join("", s.Select(x => x.ToString()).ToArray()));
        }

        static void Main(string[] args)
        {
            char[] s = { 'á', 'r', 'v', 'í', 'z', 't', 'ű', 'r', 'ő', ' ', 't', 'ü', 'k', 'ö', 'r', 'f', 'ú', 'r', 'ó', 'g', 'é', 'p' };

            toStringQuery(s);
            toStringLambda(s);

            Console.ReadLine();
        }
    }
}
