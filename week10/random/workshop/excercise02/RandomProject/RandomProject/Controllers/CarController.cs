using Microsoft.AspNetCore.Mvc;
using RandomProject.Models;
using RandomProject.Repositories;
using System.Collections.Generic;

namespace RandomProject.Controllers
{
    [Route("")]
    public class CarController : Controller
    {
        private CarRepository carRepository;

        public CarController(CarRepository carRepository)
        {
            this.carRepository = carRepository;
        }

        [HttpGet]
        [Route("")]
        [Route("search")]
        public IActionResult Search([FromQuery]string q, [FromQuery]int police, [FromQuery]int diplomat)
        {
            if (!string.IsNullOrEmpty(q))
            {
                return View(carRepository.FilterCars(q));
            }
            else
            {
                if (police == 1)
                {
                    return View(carRepository.FilterPolice());
                }
                else if (diplomat == 1)
                {
                    return View(carRepository.FilterDiplomat());
                }
                else
                {
                    return View(new List<Car>());
                }
            }
        }

        [HttpGet]
        [Route("search/{brand}")]
        public IActionResult BrandSearch(string brand)
        {
            return View("Search", carRepository.FilterBrand(brand)); //View
        }


        [Route("api/search/{brand}")]
        public IActionResult ApiSearch(string brand)
        {
            return Json(new { result = "ok", data = carRepository.FilterBrand(brand) });
        }
    }
}
