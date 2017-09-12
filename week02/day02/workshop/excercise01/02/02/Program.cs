using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            string al = "Greenfox";
            greeting(al);
            Console.ReadLine();
        }

        static void greeting(string str)
        {
            Console.WriteLine("Greetings dear, " + str);
        }
    }
}
