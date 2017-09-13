using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            var far = new List<string> { "kuty", "macsk", "kacs", "rók", "halacsk" };

            for (int i=0;i<far.Count;i++)
                far[i] = string.Concat(far[i], "a");

            Console.WriteLine("{0}", string.Join(", ", far));
            Console.ReadLine();
        }
    }
}
