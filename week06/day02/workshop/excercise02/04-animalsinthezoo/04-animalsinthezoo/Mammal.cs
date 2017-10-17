using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_animalsinthezoo
{
    public class Mammal : Animal
    {
        public override void Greet()
        {
        }

        public Mammal(string name)
        {
            this.name = name;
        }

        public override string GetName()
        {
            return name;
        }

        public override string WantChild()
        {
            return "want a child from my uterus!";
        }
    }
}
