using IT_Solutions.Models;
using IT_Solutions.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.Collections.Generic;

namespace IT_Solutions.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStringLocalizer<HomeController> _localizer;
        private readonly IListItemFactory _lists;
        private readonly IEmailSender _email;
        public HomeController(IListItemFactory lists, IEmailSender email, IStringLocalizer<HomeController> localizer)
        {
            _lists = lists;
            _email = email;
            _localizer = localizer;
        }

        [Route("/{culture}/")]
        [Route("/{culture}/services")]
        [Route("services")]
        public IActionResult Index(string culture = "pl")
        {
            List<ListItemModel> serviceList = _lists.GetAllServices();
            @ViewBag.Title = "Services";
            @ViewBag.Culture = culture;
            @ViewBag.Description = _localizer["Index description"];
            return View(serviceList);
        }
        [Route("")]
        public IActionResult IndexRedirect(string culture = "pl")
        {
            return RedirectPermanent("/" + culture + "/services");
        }

        [Route("/{culture}/contact")]
        [Route("contact")]
        public IActionResult Contact(string culture = "pl")
        {
            @ViewBag.Title = "Contact";
            @ViewBag.Culture = culture;
            @ViewBag.Description = _localizer["Contact description"];
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(MessageModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _email.SendMessageAsync(model);

                    return View("MessageSent");
                }
                catch
                {
                    return View("MessageNotSent");
                }
            }
            else
            {
                return View("Contact", model);
            }
        }

        [Route("/{culture}/technologies")]
        [Route("technologies")]
        public IActionResult Technologies(string culture = "pl")
        {
            List<ListItemModel> technologyList = _lists.GetAllTechnologies();
            @ViewBag.Title = "Technologies";
            @ViewBag.Culture = culture;
            @ViewBag.Description = _localizer["Technologies description"];
            return View(technologyList);
        }
    }
}
