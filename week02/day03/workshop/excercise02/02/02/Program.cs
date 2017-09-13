using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            var girls = new List<string> { "Eve", "Ashley", "Bözsi", "Kat", "Jane" };
            var boys = new List<string> { "Joe", "Fred", "Béla", "Todd", "Neef", "Jeff" };
            var order = new List<string>();

            // Join the two lists by matching one girl with one boy in the order list
            // Exepected output: "Eve", "Joe", "Ashley", "Fred"...
            int g = 0;
            int b = 0;

            while (b + g < (girls.Count + boys.Count))
            {
                if (g < girls.Count )
                {
                    order.Add(girls[g]);
                    g++;
                }
                if ( b < boys.Count )
                {
                    order.Add(boys[b]);
                    b++;
                }
            }
            Console.WriteLine("{0}", string.Join(", ", order));
            Console.ReadLine();
        }
    }
}
