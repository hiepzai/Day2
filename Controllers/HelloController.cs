using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Day2.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome(string name, int NumTimes = 1)
        {
            ViewData["Name"] = name;
            ViewData["NumTimes"] = NumTimes;
            return View();
        }
    }
}
