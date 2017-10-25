using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankOfSimba.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankOfSimba.Controllers
{
    public class HomeController : Controller
    {
        List<BankAccount> list = new List<BankAccount>()
        {
            new BankAccount { Name = "Simba", Balance = "2000.00", AnimalType = "Lion", IsKing = true, IsGood = true },
            new BankAccount { Name = "RandomLion", Balance = "1000.00", AnimalType = "Lion", IsKing = false, IsGood = true },
            new BankAccount { Name = "SomeOtherRandomLion", Balance = "500.00", AnimalType = "Lion", IsKing = false, IsGood = false },
            new BankAccount { Name = "LionWithAReallyProblematicName", Balance = "200.00", AnimalType = "Lion", IsKing = false, IsGood = false },
            new BankAccount { Name = "LionVersionOfAnonymous", Balance = "100.00", AnimalType = "Lion", IsKing = false, IsGood = true }
        };

        [Route("client")]
        public IActionResult Index(string name)
        {
            var bankAccount = list.FirstOrDefault(x => x.Name == name);
            return View(bankAccount);
        }

        [Route("allclients")]
        public IActionResult Index2()
        {
            return View(list);
        }
    }
}
