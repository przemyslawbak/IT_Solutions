using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace IT_Solutions.Controllers
{
    public class ErrorController : Controller
    {
        private readonly IStringLocalizer<HomeController> _localizer;

        public ErrorController(IStringLocalizer<HomeController> localizer)
        {
            _localizer = localizer;
        }

        [Route("/error/page-not-found")]
        public IActionResult PageNotFound()
        {
            @ViewBag.Message = _localizer["Page not found"];
            return View();
        }
    }
}
