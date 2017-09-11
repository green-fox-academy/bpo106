using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Girls: ");
            var inputg = Console.ReadLine();
            Console.Write("Boys: ");
            var inputb = Console.ReadLine();
            Int32.TryParse(inputg, out int g);
            Int32.TryParse(inputb, out int b);
            if (g == 0) Console.WriteLine("Sausage party");
            else if (g + b > 20) {
                if (g == b) Console.WriteLine("The party is excellent!");
                else Console.WriteLine("Quite cool party!");
            }
            else Console.WriteLine("Average Party...");
            Console.ReadLine();
        }
    }
}
