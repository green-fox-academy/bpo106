using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_parkinglot
{
    class Program
    {
        static public void CountAndPrint(List<Car> list, int i)
        {
            var frequency = list.Select(x => x.nameAndColor[i]).GroupBy(x => x).Select(x => new { Key = x.Key, Count = x.Count() });
            foreach (var element in frequency)
            {
                if (i == 0)
                {
                    Console.WriteLine(Enum.GetName(typeof(Types), element.Key) + ": " + element.Count);
                }
                else
                {
                    Console.WriteLine(Enum.GetName(typeof(Colors), element.Key) + ": " + element.Count);
                }
            }
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            List<Car> list = new List<Car>();

            for (int i = 0; i < 256; i++)
            {
                list.Add(new Car(random.Next(0, 9), random.Next(0, 9)));
            }

            Console.WriteLine("Types:");
            CountAndPrint(list, 0);
            Console.WriteLine("\nColors:");
            CountAndPrint(list, 1);
            Console.ReadLine();
        }
    }
}
