using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tree> list = new List<Tree>();

            list.Add(new Tree("pine", "green", 20, "male"));
            list.Add(new Tree("yew", "green", 2, "female"));
            list.Add(new Tree("apple", "green", 4, "monoecious"));
            list.Add(new Tree("pear", "green", 15, "monoecious"));
            list.Add(new Tree("plum", "green", 7, "monoecious"));
        }
    }
}
