using Microsoft.AspNetCore.Mvc;

namespace IT_Solutions.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult PageNotFound()
        {
            return View();
        }
    }
}
