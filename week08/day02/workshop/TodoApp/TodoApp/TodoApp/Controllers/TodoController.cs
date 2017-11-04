using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Repositories;

namespace TodoApp.Controllers
{
    public class TodoController : Controller
    {
        TodoRepository todoRepository;

        public TodoController(TodoRepository todoRepository)
        {
            this.todoRepository = todoRepository;
        }

        [Route("/")]
        [Route("/list")]
        [HttpGet]
        public IActionResult List()
        {
            return View(todoRepository.context.Todos);
        }

        [Route("/add")]
        [HttpPost]
        public IActionResult Add()
        {
            todoRepository.AddRow();
            return RedirectToAction("List");
        }

        [Route("/remove")]
        [HttpPost]
        public IActionResult Remove()
        {
            todoRepository.RemoveRow();
            return RedirectToAction("List");
        }
    }
}
