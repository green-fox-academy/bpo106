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
            int a = 3;
            a += 10;
            Console.WriteLine(a);

            int b = 100;
            b -= 7;
            Console.WriteLine(b);

            int c = 44;
            c *= 2;
            Console.WriteLine(c);

            int d = 125;
            d /= 5;
            Console.WriteLine(d);

            int e = 8;
            e *= e;
            Console.WriteLine(e);

            int f1 = 123;
            int f2 = 345;
            Console.WriteLine(f1 > f2);

            int g1 = 350;
            int g2 = 200;
            Console.WriteLine(g1 < 2*g2);

            long h = 1357988018575474;
            Console.WriteLine(h%11 == 0);

            int i1 = 10;
            int i2 = 3;
            Console.WriteLine((i1 > i2*i2) && (i1 < i2*i2*i2));

            int j = 1521;
            Console.WriteLine((j % 3 == 0) || (j % 5 == 0));

            string k = "Apple";
            k = string.Concat(k, k, k, k);
            Console.WriteLine(k);

            Console.ReadLine();
        }
    }
}
