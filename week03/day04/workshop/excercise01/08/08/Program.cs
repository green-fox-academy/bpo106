using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    class Program
    {
        static string StringX(string s)
        {
            if (s.Length == 0)
            {
                return "";
            }
            else
            {
                if (s[s.Length - 1] == 'x')
                {
                    return StringX(s.Substring(0, s.Length - 1));
                }
                else
                {
                    return StringX(s.Substring(0, s.Length - 1)) + s[s.Length - 1];
                }
            }
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(StringX(s));
            Console.ReadLine();
        }
    }
}