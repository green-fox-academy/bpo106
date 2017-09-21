using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    class Program
    {
        static string StringC(string s)
        {
            if (s.Length == 1)
            {
                return s;
            }
            else
            {
                return StringC(s.Substring(0, s.Length - 1)) + "*" + s[s.Length - 1];
            }
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(StringC(s));
            Console.ReadLine();
        }
    }
}