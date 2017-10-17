using System;

namespace _03_instruments
{
    public class ElectricGuitar : StringedInstrument
    {
        public ElectricGuitar()
        {
            numberOfStrings = 6;
            Console.Write("Electric guitar is a {0}-stringed instrument that ", numberOfStrings);
            Sound();
        }

        public override void Sound()
        {
            Console.WriteLine("twangs.");
        }
    }
}
