using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApp.Repositories;
using TodoApp.Entities;

namespace TodoApp.Controllers
{
    [Route("/todo")]
    public class TodoController : Controller
    {
        TodoRepository todoRepository;

        public TodoController(TodoRepository todoRepository)
        {
            this.todoRepository = todoRepository;
        }

        [Route("")]
        [Route("/list")]
        public IActionResult List()
        {
            return View();
        }
    }
}
