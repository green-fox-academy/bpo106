using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication2.Controllers
{
    [Route("api")]
    public class RESTController : Controller
    {
        // GET: /<controller>/
        
        [Route("greeting")]
        public IActionResult Greeting()
        {
            Greeting obj = new Greeting() { Id = 1, Content = "Hello World!" };
            return new JsonResult(obj);
        }
    }
}
