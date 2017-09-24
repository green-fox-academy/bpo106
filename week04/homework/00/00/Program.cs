using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> tree = new List<List<string>>();
            tree.Add(new List<string> { "pine", "green", "20", "male" });
            tree.Add(new List<string> { "yew", "green", "2", "female" });
            tree.Add(new List<string> { "apple", "green", "4", "monoecious" });
            tree.Add(new List<string> { "pear", "green", "15", "monoecious" });
            tree.Add(new List<string> { "plum", "green", "7", "monoecious" });
        }
    }
}
