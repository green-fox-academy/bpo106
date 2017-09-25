using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            Station station = new Station();
            Car car = new Car();

            car = station.Refill(car);
        }
    }
}
