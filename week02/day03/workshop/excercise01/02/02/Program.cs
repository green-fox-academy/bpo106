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
            string url = "https//www.reddit.com/r/nevertellmethebots";
            //1.
            //url = url.Replace("bots", "odds/");
            //2.
            url = url.Remove(38,4);
            url = string.Concat(url, "odds/");
            Console.WriteLine(url);
            Console.ReadLine();
        }
    }
}
