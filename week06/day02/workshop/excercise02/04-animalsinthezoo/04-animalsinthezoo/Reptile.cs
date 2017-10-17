using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_animalsinthezoo
{
    public class Reptile : Animal
    {
        public Reptile(string name)
        {
            this.name = name;
        }

        public override void Greet()
        {
        }

        public override string GetName()
        {
            return name;
        }

        public override string WantChild()
        {
            if (name == "frog")
            {
                return "want a child from my uterus!";
            }
            else
            {
                return "want a child from an egg!";
            }
        }
}
}
