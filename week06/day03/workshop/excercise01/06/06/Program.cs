using System;
using System.Collections.Generic;
using System.Linq;

namespace _06
{
    class Program
    {
        static void frequencyLambda(string s)
        {
            var frequency = s.ToLower().Where(x => x != '.' && x != ',' && x != ' ' && x != '-').GroupBy(x => x).Select(x => new { Character = x.Key, Count = x.Count() });
        
            foreach (var element in frequency)
            {
                Console.WriteLine(element.Character + ": " + element.Count);
            }
        }

        static void Main(string[] args)
        {
            string s = "Etelka, a tapír elmegy anyagmennyiség-becslőnek.";

            Console.WriteLine(s);
            frequencyLambda(s);

            Console.ReadLine();
        }
    }
}
