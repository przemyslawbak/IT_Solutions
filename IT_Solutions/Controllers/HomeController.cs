using Microsoft.AspNetCore.Mvc;

namespace IT_Solutions.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            @ViewBag.Title = "Services";
            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            @ViewBag.Title = "Contact";
            return View();
        }

        [HttpGet("technologies")]
        public IActionResult Technologies()
        {
            @ViewBag.Title = "Technologies";
            return View();
        }
    }
}
