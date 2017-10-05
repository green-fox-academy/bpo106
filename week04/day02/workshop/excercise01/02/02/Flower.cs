using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    public class Flower : Garden
    {
        public Flower(string color)
        {
            this.color = color;
            waterLevel = 0;
            type = "Flower";
        }

        public override void waterLevelIncrease(int water, int count)
        {
            waterLevel += (int)(0.75 * water / count);
            if (waterLevel >= 5)
            {
                needs = "doesn't need";
            }
        }
    }
}
