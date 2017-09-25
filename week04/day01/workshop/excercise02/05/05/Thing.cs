using System;
using System.Collections.Generic;

namespace FleetOfThings
{
    public class Thing
    {
        private string Name;
        private bool Completed;

        public Thing(string name)
        {
            this.Name = name;

            if (this.Name == "Stand up" || this.Name == "Eat lunch")
            {
                this.Completed = true;
                Console.WriteLine("[X] {0}", this.Name);
            }
            else
            {
                this.Completed = false;
                Console.WriteLine("[ ] {0}", this.Name);
            }
        }
    }
}