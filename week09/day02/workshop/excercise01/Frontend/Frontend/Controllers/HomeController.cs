using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Frontend.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet]
        [Route("/doubling")]
        public IActionResult Doubling(int? input)
        {
            if (input != null)
            {
                return Json(new { received = input, result = input * 2 });
            }
            return Json(new { error = "Please provide an input!" });
        }

        [HttpGet]
        [Route("/greeter")]
        public IActionResult Greeter(string name, string title)
        {
            if (name == null)
            {
                return Json(new { error = "Please provide a name!" });
            }
            if (title == null)
            {
                return Json(new { error = "Please provide a title!" });
            }
            return Json(new { welcome_message = "Oh, hi there " + name +", my dear " + title + "!" });
        }

        [HttpGet]
        [Route("/appenda/{appendable}")]
        [Route("appenda")]
        public IActionResult Appenda(string appendable)
        {
            if (appendable == null)
            {
                return RedirectToAction("Randomness");
            }
            return Json(new { appended = appendable + "a" });
        }
    }
}
