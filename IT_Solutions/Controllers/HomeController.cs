using Microsoft.AspNetCore.Mvc;

namespace IT_Solutions.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpGet("technologies")]
        public IActionResult Technologies()
        {
            return View();
        }
    }
}
