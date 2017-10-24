using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication2.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        static int id = 0;

        [Route("greeting")]
        public IActionResult Greeting(string name)
        {
            var greeting = new Greeting();

            id++;
            greeting.Id = id;
            greeting.Content = name;

            return View(greeting);
        }
    }
}
