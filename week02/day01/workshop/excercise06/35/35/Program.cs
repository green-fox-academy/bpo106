using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Int32.TryParse(input, out int num);
            /* Kissé félreértettem a feladatot, mert a sakktábla tetszőleges input méretű lett.
             * Amennyiben 8-hoz ragaszkodunk, akkor a 13. és 14. sor helyett semmi nincs,
             * a for ciklus pedig num/2 helyett 4-ig fut.*/

            for (int i=0;i<num;i++)
            {
                if (i%2==0)
                    for (int j=0;j<num/2;j++) Console.Write(" %");
                else
                    for (int j = 0; j < num / 2; j++) Console.Write("% ");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
