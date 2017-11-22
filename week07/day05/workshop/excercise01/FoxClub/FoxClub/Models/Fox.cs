using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Models
{
    public class Fox
    {
        public Name Name { get; set; }
        public List<Trick> Tricks { get; set; } = new List<Trick>();
        public Food Food { get; set; }
        public Drink Drink { get; set; }
    }
}
