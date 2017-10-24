using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{

    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            //return View();
            //return new JsonResult(new { Id = 10, Content = "Hello World!" });
            return Content("Hello World!");
        }

        [Route("hello")]
        public IActionResult Hello(string content)
        {
            return Content("Hello!");
        }
    }
}
