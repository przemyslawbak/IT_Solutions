using Microsoft.AspNetCore.Mvc;

namespace IT_Solutions.Controllers
{
    public class HomeController : Controller
    {
        [Route("about")]
        public IActionResult Index()
        {
            return View("About");
        }
    }
}
