using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void greenQuery(List<Fox> list)
        {
            var green = from x in list
                        where x.color == "Green"
                        select x;

            Console.WriteLine("Green foxes:");
            foreach (var element in green)
            {
                Console.WriteLine("Name: {0}, Type: {1}", element.name, element.type);
            }
        }

        static void greenPallidaQuery(List<Fox> list)
        {
            var green = from x in list
                        where x.color == "Green" && x.type == "Pallida"
                        select x;

            Console.WriteLine("Green Pallidas:");
            foreach (var element in green)
            {
                Console.WriteLine(element.name);
            }
        }

        static void greenLambda(List<Fox> list)
        {
            var green = list.Where(x => x.color == "Green").Select(x => x);

            Console.WriteLine("Green foxes:");
            foreach (var element in green)
            {
                Console.WriteLine("Name: {0}, Type: {1}", element.name, element.type);
            }
        }

        static void greenPallidaLambda(List<Fox> list)
        {
            var green = list.Where(x => x.color == "Green" && x.type == "Pallida").Select(x => x);

            Console.WriteLine("Green Pallidas:");
            foreach (var element in green)
            {
                Console.WriteLine(element.name);
            }
        }

        static void Main(string[] args)
        {
            var foxList = new List<Fox>();
            foxList.Add(new Fox("Vladimir Ilyich", "Bengalensis", "Red"));
            foxList.Add(new Fox("Iosif Vissarionovich", "Lagopus", "Black"));
            foxList.Add(new Fox("Nikita Sergeyevich", "Zerda", "Orange"));
            foxList.Add(new Fox("Leonid Ilyich", "Pallida", "Grey"));
            foxList.Add(new Fox("Yuri Vladimirovich", "Pallida", "Green"));
            foxList.Add(new Fox("Konstantin Ustinovich", "Vulpes", "Green"));
            foxList.Add(new Fox("Mikhail Sergeyevich", "Ferrilata", "Yellow"));

            Console.WriteLine("Query");
            Console.WriteLine();
            greenQuery(foxList);
            Console.WriteLine();
            greenPallidaQuery(foxList);
            Console.WriteLine();
            Console.WriteLine("Lambda");
            Console.WriteLine();
            greenLambda(foxList);
            Console.WriteLine();
            greenPallidaLambda(foxList);
            Console.ReadLine();
        }
    }
}
