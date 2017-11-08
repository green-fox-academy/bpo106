using Microsoft.AspNetCore.Mvc;
using Frontend.Models;

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
                return NotFound();
            }
            return Json(new { appended = appendable + "a" });
        }

        [HttpPost]
        [Route("/dountil/{what}")]
        [Route("/dountil")]
        public IActionResult DoUntil(string what, [FromBody] BasicClass until)
        {
            if (until.until == null)
            {
                return Json(new { error = "Please provide a number!" });
            }
            int? end = until.until;
            for (int? i = until.until - 1; i > 0; i--)
            {
                if (what == "sum")
                {
                    end += i;
                }
                else if (what == "factor")
                {
                    end *= i;
                }
                else
                {
                    return Json(new { error = "Please provide an input!" });
                }
            }
            return Json(new { result = $"{end}" });
        }

        [HttpPost]
        [Route("/arrays")]
        public IActionResult Arrays([FromBody] string what, [FromBody] BasicClass array)
        {
            if (array.array.Length == 0)
            {
                return Json(new { error = "Please provide an array!" });
            }
            int konets = array.array[0];
            if (array.array.Length == 1)
            {
                return Json(new { what = what, result = konets });
            }
            for (int i = 1; i < array.array.Length; i++)
            {
                if (what == "sum")
                {
                    konets += i;
                }
                if (what == "multiply")
                {
                    konets *= i;
                }
                if (what == "double")
                {
                    array.array[i] *= 2;
                }
                else
                {
                    return Json(new { error = "Please provide a method!" });
                }
            }
            if (what == "double")
            {
                return Json(new { result = array.array });
            }
            else
            {
                return Json(new { result = konets });
            }
        }
    }
}
