using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_animalsinthezoo
{
    public abstract class Animal
    {
        protected string name;
        protected int age;
        protected bool isMale;
        protected bool isDead;
        protected int legs;

        public abstract void Greet();
        public abstract string WantChild();
        public abstract string GetName();

    }
}
