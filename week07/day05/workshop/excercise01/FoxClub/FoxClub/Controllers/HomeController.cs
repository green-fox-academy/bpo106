using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoxClub.Models;

namespace FoxClub.Controllers
{
    public class HomeController : Controller
    {
        public Fox fox;

        public HomeController(Fox fox)
        {
            this.fox = fox;
        }

        [HttpGet]
        [Route("/")]
        public IActionResult Index(Fox fox)
        {
            return View(fox);
        }
    }
}
