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
            //Rickrolled in 2017...?

            string output = "";
            int[] notSoCrypticMessage = { 1, 12, 1, 2, 11, 1, 7, 11, 1, 49, 1, 3, 11, 1, 50, 11 };

            var map = new Dictionary<int, string>();

            map.Add(7, "run around and desert you");
            map.Add(50, "tell a lie and hurt you");
            map.Add(49, "make you cry,");
            map.Add(2, "let you down");
            map.Add(12, "give you up,");
            map.Add(1, "Never gonna");
            map.Add(11, "\n");
            map.Add(3, "say goodbye");

            for (int i=0;i< notSoCrypticMessage.Length;i++)
            {
                string value;
                if (map.TryGetValue(notSoCrypticMessage[i], out value))
                {
                    output += value;
                    if (notSoCrypticMessage[i] != 11) output += " ";
                }            
            }

            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
