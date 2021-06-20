using IT_Solutions.Models;
using Microsoft.Extensions.Localization;
using System.Collections.Generic;

namespace IT_Solutions.Services
{
    public class ListItemFactory : IListItemFactory
    {
        private readonly IStringLocalizer<ListItemFactory> _localizer;

        public ListItemFactory(IStringLocalizer<ListItemFactory> localizer)
        {
            _localizer = localizer;
        }

        public List<ListItemModel> GetAllServices()
        {
            return new List<ListItemModel>()
            {
                new ListItemModel() { ImgUrl = "/src/img/business.png", Name = "Business websites", Description = _localizer["business"]},
                new ListItemModel() { ImgUrl = "/src/img/backend.png", Name = "Backend applications", Description = _localizer["backend"]},
                new ListItemModel() { ImgUrl = "/src/img/web.png", Name = "Web applications", Description = _localizer["web"]},
                new ListItemModel() { ImgUrl = "/src/img/rest.png", Name = "RESTful Web Apis", Description = _localizer["rest"]},
                new ListItemModel() { ImgUrl = "/src/img/desktop.png", Name = "Windows desktop applications", Description = _localizer["desktop"]},
                new ListItemModel() { ImgUrl = "/src/img/console.png", Name = "Console applications", Description = _localizer["console"]},
                new ListItemModel() { ImgUrl = "/src/img/outsourcing.png", Name = "Outsourcing", Description = _localizer["outsourcing"]},
                };
        }

        public List<ListItemModel> GetAllTechnologies()
        {
            return new List<ListItemModel>()
            {
                new ListItemModel() { ImgUrl = "/src/img/core.png", Name = "ASP.NET Core", Description = _localizer["core"]},
                new ListItemModel() { ImgUrl = "/src/img/angular.png", Name = "Angular", Description = _localizer["angular"]},
                new ListItemModel() { ImgUrl = "/src/img/wpf.png", Name = "WPF", Description = _localizer["wpf"]},
                new ListItemModel() { ImgUrl = "/src/img/mssql.png", Name = "MSSQL", Description = _localizer["mssql"]},
            };
        }
    }
}
