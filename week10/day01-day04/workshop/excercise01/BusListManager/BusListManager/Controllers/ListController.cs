using Microsoft.AspNetCore.Mvc;
using BusListManager.Repositories;
using BusListManager.Models;
using System;
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

        [Route("/add")]
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [Route("/add")]
        [HttpPost]
        public IActionResult Add(Bus bus)
        {
            listRepository.AddRow(bus);
            return RedirectToAction("List");
        }

        [Route("/remove/{id}")]
        [HttpPost]
        public IActionResult Remove(int id)
        {
            listRepository.RemoveRow(id);
            return RedirectToAction("List");
        }

        [Route("/list/update/{id}")]
        [HttpGet]
        public IActionResult Update([FromQuery] string Id)
        {
            int id = int.Parse(Id);
            var bus = listRepository.Id(id);
            return View(bus);
        }

        [Route("/update/{id}")]
        [HttpPost]
        public IActionResult Update(Bus bus)
        {

            listRepository.UpdateRow(bus);
            return RedirectToAction("List");
        }
    }
}