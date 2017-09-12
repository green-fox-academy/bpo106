using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mystrings1 = { "First" };
            string[] mystrings2 = { "First", "Second" };
            string[] mystrings3 = { "First", "Second", "Third" };
            string[] mystrings4 = { "First", "Second", "Third", "Fourth" };
            printer(mystrings1);
            printer(mystrings2);
            printer(mystrings3);
            printer(mystrings4);
            Console.ReadLine();
        }

        static void printer(params string[] strings)
        {
            for (int i = 0; i < strings.Length; i++) Console.WriteLine(strings[i]);
        }
    }
}
