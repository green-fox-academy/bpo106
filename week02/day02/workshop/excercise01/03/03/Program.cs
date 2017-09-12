using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string am = "kuty";
            appendA(am);
            Console.ReadLine();
        }

        static void appendA(string str)
        {
            str += "a";
            Console.WriteLine(str);
        }
    }
}
