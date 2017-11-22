using Microsoft.AspNetCore.Mvc;
using BankOfSimba.Models;

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

        [HttpPost("{name}")]
        [Route("increase")]
        public IActionResult Increase(string name)
        {
            list.Increase(name);
            return RedirectToAction("Index2");
        }
    }
}
