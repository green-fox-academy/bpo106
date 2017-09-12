using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            matrix();
            Console.ReadLine();
        }

        static void matrix()
        {
            for (int i=0;i<4;i++)
            {
                for (int j=0;j<4;j++)
                {
                    if (i == j) Console.Write("1 ");
                    else Console.Write("0 ");
                }
                Console.WriteLine();
            }
        }
    }
}
