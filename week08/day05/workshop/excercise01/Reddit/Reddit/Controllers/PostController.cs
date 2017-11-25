﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reddit.Repositories;
using Reddit.Models;

namespace Reddit.Controllers
{
    [Route("")]
    public class PostController : Controller
    {
        private PostRepository postRepository;

        public PostController(PostRepository postRepository)
        {
            this.postRepository = postRepository;
        }

        [Route("")]
        [Route("/posts")]
        [HttpGet]
        public IActionResult Posts()
        {
            return View(postRepository.ListPosts());
        }

        [Route("/posts/add")]
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [Route("/posts/add")]
        [HttpPost]
        public IActionResult Add(Post post)
        {
            postRepository.Add(post);
            return RedirectToAction("Posts");
        }

        [HttpPost("{id}")]
        [Route("/vote")]
        public IActionResult Vote(int Id)
        {
            postRepository.Change(Id, true);
            return RedirectToAction("Posts");
        }
    }
}
