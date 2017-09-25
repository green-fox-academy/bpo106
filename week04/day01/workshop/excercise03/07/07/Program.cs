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
            Sharpie sharpie = new Sharpie();
            sharpie.Color = "Black";
            sharpie.Width = 20;
            sharpie.Use();
        }
    }
}
