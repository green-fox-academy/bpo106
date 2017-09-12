using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] t = { 1, 2, 3, 4, 5 };
            inc(t);
            Console.ReadLine();
        }

        static void inc(int[] line)
        {
            line[2]++;
            Console.WriteLine(line[2]);
        }
    }
}
