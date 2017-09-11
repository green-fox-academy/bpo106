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
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;
            Console.Write(currentHours);
            Console.Write(":");
            Console.Write(currentMinutes);
            Console.Write(":");
            Console.WriteLine(currentSeconds);
            Console.Write(23-currentHours);
            Console.Write(":");
            Console.Write(59-currentMinutes);
            Console.Write(":");
            Console.WriteLine(60-currentSeconds);
            Console.ReadLine();
        }
    }
}
