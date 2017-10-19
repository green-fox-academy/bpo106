using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_parkinglot
{
    public enum Types
    {
        VAZ,
        UAZ,
        GAZ,
        KAMAZ,
        IZH,
        GolAZ,
        BelAZ,
        MAZ,
        ZIL
    }

    public enum Colors
    {
        green,
        red,
        white,
        yellow,
        black,
        blue,
        brown,
        grey,
        wtf
    }

    public class Car
    {
        public int[] nameAndColor = new int[2];

        public Car(int name, int color)
        {
            nameAndColor[0] = name;
            nameAndColor[1] = color;
        }
    }
}
