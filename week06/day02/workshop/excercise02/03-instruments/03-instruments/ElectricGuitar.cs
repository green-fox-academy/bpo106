using System;

namespace instruments
{
    public class ElectricGuitar : StringedInstrument
    {
        public ElectricGuitar()
        {
            numberOfStrings = 6;
        }

        public ElectricGuitar(int number)
        {
            numberOfStrings = number;
        }

        public override void Sound()
        {
            Console.WriteLine("Electric guitar is a {0}-stringed instrument that twangs.", numberOfStrings);
        }
    }
}