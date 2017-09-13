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
            var planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus",
            "Neptune" };

            planetList.Insert(5, "Saturn");
            
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(planetList[i]);
            }
            Console.ReadLine();
        }
    }
}
