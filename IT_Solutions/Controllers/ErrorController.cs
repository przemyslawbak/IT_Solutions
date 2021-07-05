using Microsoft.AspNetCore.Mvc;

namespace IT_Solutions.Controllers
{
    public class ErrorController : Controller
    {
        [Route("/error/page-not-found")]
        public IActionResult PageNotFound(string culture = "pl")
        {
            @ViewBag.Culture = culture;
            return View();
        }
    }
}
