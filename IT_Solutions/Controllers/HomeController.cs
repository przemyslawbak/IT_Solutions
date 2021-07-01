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
            @ViewBag.KeyWords = "services, usługi, development, it, it development, websites, applications, strony, aplikacje, web api, console, outsourcing, business, Przemysław Bąk, IT Solutions, Przemysław Bąk IT Solutions";
            return View(serviceList);
        }
        [Route("")]
        [Route("/")]
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
            @ViewBag.KeyWords = "contact form, contact, contact us, formularz kontaktowy, kontakt, skontaktuj się, Przemysław Bąk, IT Solutions, Przemysław Bąk IT Solutions";
            return View();
        }

        [Route("/{culture}/technologies")]
        [Route("technologies")]
        public IActionResult Technologies(string culture = "pl")
        {
            List<ListItemModel> technologyList = _lists.GetAllTechnologies();
            @ViewBag.Title = "Technologies";
            @ViewBag.Culture = culture;
            @ViewBag.Description = _localizer["Technologies description"];
            @ViewBag.KeyWords = "techologies, technologie, development, ASP.NET Core, Angular, WPF, MSSQL, it, it development, websites, applications, strony, aplikacje, web api, console, outsourcing, business, Przemysław Bąk, IT Solutions, Przemysław Bąk IT Solutions";
            return View(technologyList);
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
    }
}
