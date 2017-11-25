using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Reddit.Controllers
{
    [Route("")]
    public class PostController : Controller
    {
        [Route("")]
        [Route("/posts")]
        [HttpGet]
        public IActionResult Posts()
        {
            return View();
        }

        [Route("/posts/add")]
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
