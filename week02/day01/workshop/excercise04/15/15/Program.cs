using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int km;
            Int32.TryParse(input, out km);
            Console.WriteLine(km * 1.609);
            Console.ReadLine();
        }
    }
}
