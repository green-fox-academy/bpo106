using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();

            counter.Add(42);
            counter.Add();
            string str = counter.Get();
            counter.Reset();
        }
    }
}
