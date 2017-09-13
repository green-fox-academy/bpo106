using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            //What I cannot create, I do not understand.
            var list = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };
            string temp = list[5];
            list.Remove(list[5]);
            list.Insert(2, temp);
            temp = list[3];
            list.Remove(list[3]);
            list.Insert(5, temp);
            Console.WriteLine("{0}", string.Join(" ", list));
            Console.ReadLine();
        }
    }
}
