using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Disznó: ");
            var p = Console.ReadLine();
            Console.Write("Csirke: ");
            var c = Console.ReadLine();
            int pl, cl;
            Int32.TryParse(p, out pl);
            Int32.TryParse(c, out cl);
            Console.Write("Disznóláb: ");
            Console.WriteLine(4 * pl);
            Console.Write("Csirkeláb: ");
            Console.WriteLine(2 * cl);
            Console.ReadLine();
        }
    }
}
