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
        public IActionResult Update(int id, [FromBody] Bus newBus)
        {
            var bus = listRepository.listContext.List.Where(t => t.Id == id).FirstOrDefault();

            bus.Number = newBus.Number;
            bus.FormerNumber = newBus.FormerNumber;
            bus.LicensePlate = newBus.LicensePlate;
            bus.FormerLicensePlate = newBus.FormerLicensePlate;
            bus.Type = newBus.Type;
            bus.Depot = newBus.Depot;
            bus.DateOfGet = newBus.DateOfGet;
            bus.DateOfWithdrawal = newBus.DateOfWithdrawal;
            bus.Kilometer = newBus.Kilometer;
            bus.IsInOperation = newBus.IsInOperation;
            bus.Comments = newBus.Comments;

            listRepository.Update(bus);

            return RedirectToAction("List", new { id = bus.Id });
        }
    }
}