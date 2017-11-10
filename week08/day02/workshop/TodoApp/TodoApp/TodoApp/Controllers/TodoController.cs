using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Repositories;
using TodoApp.Models;

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
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [Route("/add")]
        [HttpPost]
        public IActionResult Add(string title)
        {
            var todo = new Todo();
            todo.Title = title;
            todoRepository.AddRow(todo);
            return RedirectToAction("List");
        }

        [Route("/remove/{id}")]
        [HttpPost]
        public IActionResult Remove(int id)
        {
            todoRepository.RemoveRow(id);
            return RedirectToAction("List");
        }
    }
}
