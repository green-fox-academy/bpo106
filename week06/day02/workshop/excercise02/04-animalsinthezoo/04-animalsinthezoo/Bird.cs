using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_animalsinthezoo
{
    public class Bird : Animal
    {
        public override void Greet()
        {
        }

        public Bird(string name)
        {
            this.name = name;
        }

        public override string GetName()
        {
            return name;
        }

        public override string WantChild()
        {
            return "want a child from an egg!";
        }
    }
}
