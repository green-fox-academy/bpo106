using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Groot.Controllers
{
    public class GrootController : Controller
    {
        [Route("/groot")]
        [HttpGet]
        public IActionResult Translate(string message)
        {
            if (message == null)
            {
                return Json(new { error = "I am Groot!" });
            }
            return Json(new { received = message, translated = "I am Groot!" });
        }
    }
}
