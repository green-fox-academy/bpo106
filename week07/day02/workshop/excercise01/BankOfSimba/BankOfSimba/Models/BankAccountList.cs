using System;
using System.Collections.Generic;

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

        public void Increase(string name)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (name == list[i].Name)
                {
                    int integer = Int32.Parse(list[i].Balance.Substring(0, list[i].Balance.Length - 3));
                    if (list[i].IsKing)
                    {
                        integer += 100;
                    }
                    else
                    {
                        integer += 10;
                    }
                    list[i].Balance = integer.ToString() + ".00";
                    list[i].IsGood = false;
                }
            }
        }
    }
}
