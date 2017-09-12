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
            //string[] mystrings = { "First" };
            //string[] mystrings = { "First", "Second" };
            //string[] mystrings = { "First", "Second", "Third" };
            string[] mystrings = { "First", "Second", "Third", "Fourth" };
            printer(mystrings);
            Console.ReadLine();
        }

        static void printer(params string[] strings)
        {
            for (int i = 0; i < strings.Length; i++) Console.WriteLine(strings[i]);
        }
    }
}
