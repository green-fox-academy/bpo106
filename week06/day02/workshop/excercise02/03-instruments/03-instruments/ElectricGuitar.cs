using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_instruments
{
    public class ElectricGuitar : StringedInstrument
    {
        public ElectricGuitar()
        {
            numberOfStrings = 6;
            howItSounds = "twang";
            Console.Write("Electric Guitar");
        }

        public override void Sound()
        {
            Play();
            Console.WriteLine(howItSounds + "s");
        }
    }
}
