using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    public class Tree : Garden
    {
        public Tree(string color)
        {
            this.color = color;
            waterLevel = 0;
            type = "Tree";
        }

        public override void waterLevelIncrease(int water, int count)
        {
            waterLevel += (int)(0.4 * water / count);
            if (waterLevel >= 10)
            {
                needs = "doesn't need";
            }
        }
    }
}
