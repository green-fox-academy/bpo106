using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    public class Flower : Garden
    {
        Flower()
        {
            waterLevel = 0;
        }

        void waterLevelIncrease(int water)
        {
            waterLevel += (int)(0.75 * water);
        }
    }
}
