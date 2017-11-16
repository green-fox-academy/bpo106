using Microsoft.AspNetCore.Mvc;
using BusListManager.Repositories;
using BusListManager.Models;
using System.Linq;

namespace BusListManager.Controllers
{
    public class ListController : Controller
    {
        ListRepository listRepository;

        public ListController(ListRepository listRepository)
        {
            this.listRepository = listRepository;
        }

        [Route("/")]
        [Route("/list")]
        [HttpGet]
        public IActionResult List()
        {
            return View(listRepository.listContext.List);
        }

        [HttpGet]
        [Route("/add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/add")]
        public IActionResult Add(Bus bus)
        {
            listRepository.AddRow(bus);
            return RedirectToAction("List");
        }

        [HttpPost("{id}")]
        [Route("/remove")]
        public IActionResult Remove(int id)
        {
            listRepository.RemoveRow(id);
            return RedirectToAction("List");
        }

        [HttpGet("{id}")]
        [Route("/update")]
        public IActionResult Update([FromQuery] int Id)
        {
            return View(listRepository.listContext.List.Where(x => x.Id == Id).FirstOrDefault());
        }

        [HttpPost("{id}")]
        [Route("/list/update")]
        public IActionResult UpdateRow(Bus newBus)
        {
            listRepository.Update(newBus);
            return RedirectToAction("List");
        }
    }
}