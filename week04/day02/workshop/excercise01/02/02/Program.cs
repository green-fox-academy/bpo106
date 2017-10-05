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
            List<Garden> garden = new List<Garden>();
            garden.Add(new Flower("yellow"));
            garden.Add(new Flower("blue"));
            garden.Add(new Tree("purple"));
            garden.Add(new Tree("orange"));

            for (int i = 0; i < garden.Count; i++)
            {
                garden[i].outputWaterLevel();
            }

            Console.WriteLine("\nWatering with 40");
            for (int i = 0; i < garden.Count; i++)
            {
                garden[i].waterLevelIncrease(40, garden.Count);
                garden[i].outputWaterLevel();
            }

            Console.WriteLine("\nWatering with 70");
            for (int i = 0; i < garden.Count; i++)
            {
                garden[i].waterLevelIncrease(70, garden.Count);
                garden[i].outputWaterLevel();
            }
            Console.ReadLine();
        }
    }
}
