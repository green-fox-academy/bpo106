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
        BankAccountList list;

        public HomeController(BankAccountList list)
        {
            this.list = list;
        }

        [HttpGet]
        [Route("client")]
        public IActionResult Index(string name)
        {
            var bankAccount = new BankAccount();
            foreach (BankAccount element in list.list)
            {
                if (element.Name == name)
                {
                    bankAccount = element;
                }
            }
            return View(bankAccount);
        }

        [HttpGet]
        [Route("allclients")]
        public IActionResult Index2()
        {
            return View(list.list);
        }

        [HttpPost]
        [Route("allclients")]
        public IActionResult Increase()
        {
            //list[0].Change();
            return RedirectToAction("Index2");
        }
    }
}
