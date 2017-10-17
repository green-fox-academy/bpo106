using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_instruments
{
    class Program
    {
        static void Main(string[] args)
        {
            ElectricGuitar electricGuitar = new ElectricGuitar();
            electricGuitar.Sound();
            Console.ReadLine();
        }
    }
}
