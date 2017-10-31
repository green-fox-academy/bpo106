using EFCoreIntro.Entities;
using EFCoreIntro.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreIntro.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        StudentRepository StudentRepository;

        public HomeController(StudentRepository studentRepository)
        {
            StudentRepository = studentRepository;
        }

        [Route("")]
        public IActionResult Index()
        {
            return View(StudentRepository.GetLastStudent());
        }

        [Route("/add")]
        public IActionResult AddStudent()
        {
            StudentRepository.AddStudent();
            return RedirectToAction("Index");
        }

        [Route("/update")]
        public IActionResult UpdateStudent()
        {
            StudentRepository.UpdateStudent();
            return RedirectToAction("Index");
        }

        [Route("/remove")]
        public IActionResult RemoveStudent()
        {
            StudentRepository.RemoveStudent();
            return RedirectToAction("Index");
        }
    }
}