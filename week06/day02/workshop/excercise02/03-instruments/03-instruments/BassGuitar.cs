using System;

namespace instruments
{
    public class BassGuitar : StringedInstrument
    {
        public BassGuitar()
        {
            numberOfStrings = 4;
        }

        public BassGuitar(int number)
        {
            numberOfStrings = number;
        }

        public override void Sound()
        {
            Console.WriteLine("Bass guitar is a {0}-stringed instrument that duum-duum-duum.", numberOfStrings);
        }
    }
}