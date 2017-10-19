using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_parkinglot
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<Car> list = new List<Car>();

            for (int i = 0; i < 256; i++)
            {
                list.Add(new Car(random.Next(0, 9), random.Next(0, 9)));
            }

            Console.WriteLine("Types:");
            DoSomethingWithThoseCars.CountAndPrint(list, 0);
            Console.WriteLine("\nColors:");
            DoSomethingWithThoseCars.CountAndPrint(list, 1);
            Console.ReadLine();
        }
    }
}
