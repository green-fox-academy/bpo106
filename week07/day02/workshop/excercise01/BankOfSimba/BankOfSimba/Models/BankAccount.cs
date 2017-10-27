using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string Name;
        public string Balance { get; set; }
        public string AnimalType;
        public bool IsKing;
        public bool IsGood { get; set; }
    }
}
