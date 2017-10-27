using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public class BankAccountList
    {
        public List<BankAccount> list { get; set; } = new List<BankAccount>()
            {
            new BankAccount { Name = "Simba", Balance = "2000.00", AnimalType = "Lion", IsKing = true, IsGood = true },
            new BankAccount { Name = "RandomLion", Balance = "1000.00", AnimalType = "Lion", IsKing = false, IsGood = true },
            new BankAccount { Name = "SomeOtherRandomLion", Balance = "500.00", AnimalType = "Lion", IsKing = false, IsGood = false },
            new BankAccount { Name = "LionWithAProblematicName", Balance = "200.00", AnimalType = "Lion", IsKing = false, IsGood = false },
            new BankAccount { Name = "LionVersionOfAnonymous", Balance = "100.00", AnimalType = "Lion", IsKing = false, IsGood = true }
        };

        public void Increase()
        {
            foreach (BankAccount account in list)
            {
                int integer = Int32.Parse(account.Balance.Substring(0, account.Balance.Length - 3));
                if (account.IsKing)
                {
                    integer += 100;
                }
                else
                {
                    integer += 10;
                }
                account.Balance = integer.ToString() + ".00";
                account.IsGood = false;
            }
        }
    }
}
