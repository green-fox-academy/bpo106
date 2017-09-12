using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int ak = 123;
            doubling(ak);
            Console.ReadLine();
        }

        static void doubling(int num)
        {
            num *= 2;
            Console.WriteLine(num);
        }
    }
}
