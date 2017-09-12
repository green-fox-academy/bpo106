using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] r = { 54, 23, 66, 12 };
            sum(r);
            Console.ReadLine();
        }

        static void sum (int[] n)
        {
            Console.WriteLine(n[1] + n[2]);
        }
    }
}
