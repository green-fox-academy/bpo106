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
        static int id = 0;
        
        [Route("greeting")]
        public IActionResult Greeting(string name)
        {
            var obj = new Greeting();
            id++;
            obj.Id = id;
            obj.Content = "Hello, " + name;
            return new JsonResult(obj);
        }
    }
}
