using System;

namespace _03_instruments
{
    public class BassGuitar : StringedInstrument
    {
        public BassGuitar()
        {
            numberOfStrings = 4;
            Console.Write("Bass guitar is a {0}-stringed instrument that ", numberOfStrings);
            Sound();
        }

        public override void Sound()
        {
            Console.WriteLine("duum-duum-duum.");
        }
    }
}
