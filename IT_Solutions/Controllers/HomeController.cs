using IT_Solutions.Models;
using IT_Solutions.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace IT_Solutions.Controllers
{
    public class HomeController : Controller
    {
        private readonly IListItemFactory _lists;
        private readonly IEmailSender _email;
        public HomeController(IListItemFactory lists, IEmailSender email)
        {
            _lists = lists;
            _email = email;
        }

        [Route("/{culture}/")]
        [Route("/{culture}/services")]
        [Route("services")]
        [Route("")]
        public IActionResult Index(string culture = "en")
        {
            List<ListItemModel> serviceList = _lists.GetAllServices();
            @ViewBag.Title = "Services";
            return View(serviceList);
        }

        [Route("/{culture}/contact")]
        [Route("contact")]
        public IActionResult Contact(string culture = "en")
        {
            @ViewBag.Title = "Contact";
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
        public IActionResult Technologies(string culture = "en")
        {
            List<ListItemModel> technologyList = _lists.GetAllTechnologies();
            @ViewBag.Title = "Technologies";
            return View(technologyList);
        }
    }
}
