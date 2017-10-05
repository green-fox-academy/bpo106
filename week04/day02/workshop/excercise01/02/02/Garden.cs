using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    public class Garden
    {
        protected int waterLevel;
        protected string type;
        protected string color;
        protected string needs = "needs";

        public virtual void waterLevelIncrease(int water, int count)
        {
        }

        public void outputWaterLevel()
        {
            Console.WriteLine("The {0} {1} {2} water", color, type, needs);
        }
    }
}
