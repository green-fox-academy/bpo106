using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string Name;
        public string Balance;
        public string AnimalType;
        public bool IsKing;
        public bool IsGood;

        public void Change()
        {
            int integer = Int32.Parse(Balance.Substring(0, Balance.Length - 3));
            if (IsKing)
            {
                integer += 100;
            }
            else
            {
                integer += 10;
            }
            Balance = integer.ToString() + ".00";
            IsGood = false;
        }
    }
}
