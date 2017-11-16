using System.Linq;
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
        public IActionResult Add(Todo todo)
        {
            todoRepository.AddRow(todo);
            return RedirectToAction("List");
        }

        [HttpPost("{id}")]
        [Route("/remove")]
        public IActionResult Remove(int id)
        {
            todoRepository.RemoveRow(id);
            return RedirectToAction("List");
        }

        [HttpGet("{id}")]
        [Route("/update")]
        public IActionResult Update([FromQuery] int Id)
        {
            return View(todoRepository.context.Todos.Where(x => x.Id == Id).FirstOrDefault());
        }

        [HttpPost("{id}")]
        [Route("/list/update")]
        public IActionResult UpdateRow(Todo todo)
        {
            todoRepository.Update(todo);
            return RedirectToAction("List");
        }
    }
}
