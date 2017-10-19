using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_parkinglot
{
    static public class DoSomethingWithThoseCars
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
    }
}
