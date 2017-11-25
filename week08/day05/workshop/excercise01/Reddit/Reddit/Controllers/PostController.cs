using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reddit.Repositories;

namespace Reddit.Controllers
{
    [Route("")]
    public class PostController : Controller
    {
        public PostRepository postRepository;

        public PostController(PostRepository postRepository)
        {
            this.postRepository = postRepository;
        }

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
