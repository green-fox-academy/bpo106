using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankOfSimba.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankOfSimba.Controllers
{
    [Route("Simba")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var bankAccount = new BankAccount("Simba", "2000.00", "Animal.Lion");
            return View(bankAccount);
        }
    }
}
