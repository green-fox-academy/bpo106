using System;
using System.Collections.Generic;

namespace _03_instruments
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Instrument> list = new List<Instrument>();
            list.Add(new ElectricGuitar());
            list.Add(new BassGuitar());
            list.Add(new Violin());

            Console.ReadLine();
        }
    }
}
