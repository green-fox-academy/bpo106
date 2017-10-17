using System;

namespace instruments
{
    public class Violin : StringedInstrument
    {
        public Violin()
        {
            numberOfStrings = 4;
        }

        public override void Sound()
        {
            Console.WriteLine("Violin is a {0}-stringed instrument that screeches.", numberOfStrings);
        }
    }
}