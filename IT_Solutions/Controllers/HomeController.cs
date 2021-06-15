using IT_Solutions.Models;
using IT_Solutions.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace IT_Solutions.Controllers
{
    public class HomeController : Controller
    {
        private readonly IListItemFactory _lists;
        public HomeController(IListItemFactory lists)
        {
            _lists = lists;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            List<ListItemModel> serviceList = _lists.GetAllServices();
            @ViewBag.Title = "Services";
            return View(serviceList);
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
            List<ListItemModel> technologyList = _lists.GetAllTechnologies();
            @ViewBag.Title = "Technologies";
            return View(technologyList);
        }
    }
}
