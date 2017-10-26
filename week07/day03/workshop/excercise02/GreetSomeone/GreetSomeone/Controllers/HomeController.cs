using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GreetSomeone.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GreetSomeone.Controllers
{
    public class HomeController : Controller
    {
        Name name;

        public HomeController(Name name)
        {
            this.name = name;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View(name);
        }

        [HttpPost]
        [Route("")]
        public IActionResult Post(Name name)
        {
            return RedirectToAction("Greet", name);
        }

        [HttpGet]
        [Route("greet")]
        public IActionResult Greet(Name name)
        {
            return View(name);
        }
    }
}
