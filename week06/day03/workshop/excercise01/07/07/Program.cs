using System;
using System.Linq;

namespace _07
{
    class Program
    {
        static void aiLambda(string[] s)
        {
            var ai = s.Where(x => x[x.Length - 1] == 'I' && x[0] == 'A').Select(x => x);

            foreach (var element in ai)
            {
                Console.Write(element + " ");
            }
        }

        static void Main(string[] args)
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            foreach (string city in cities) {
                Console.Write(city + " ");
            }
            Console.WriteLine();
            aiLambda(cities);

            Console.ReadLine();
        }
    }
}
