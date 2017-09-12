using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] s = { 1, 2, 3, 8, 5, 6 };
            change(s);
            Console.ReadLine();
        }

        static void change (int[] line)
        {
            line[3] = 4;
            Console.WriteLine(line[3]);
        }
    }
}
