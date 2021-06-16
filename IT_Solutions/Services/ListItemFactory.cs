using IT_Solutions.Models;
using System.Collections.Generic;

namespace IT_Solutions.Services
{
    public class ListItemFactory : IListItemFactory
    {
        public List<ListItemModel> GetAllServices()
        {
            return new List<ListItemModel>()
            {
                new ListItemModel() { ImgUrl = "/src/img/business.png", Name = "Business websites", Description = "A website (also written as web site) is a collection of web pages and related content that is identified by a common domain name and published on at least one web server. Notable examples are wikipedia.org, google.com, and amazon.com."},
                new ListItemModel() { ImgUrl = "/src/img/backend.png", Name = "Backend applications", Description = "Do you need software that will improve your daily work in your company? Or maybe the systems you are currently using must be upgraded because they do not meet the basic tasks or you notice too many errors in their operation? We will repair or create from the ground up programs and backend applications that will work quickly, flawlessly and will be well organized."},
                new ListItemModel() { ImgUrl = "/src/img/web.png", Name = "Web applications", Description = "Is application software that runs on a web server, unlike computer-based software programs that are run locally on the operating system (OS) of the device. Web applications are accessed by the user through a web browser with an active network connection."},
                new ListItemModel() { ImgUrl = "/src/img/rest.png", Name = "RESTful Web Apis", Description = "Restful Web Services is a lightweight, maintainable, and scalable service that is built on the REST architecture. Restful Web Service, expose API from your application in a secure, uniform, stateless manner to the calling client."},
                new ListItemModel() { ImgUrl = "/src/img/desktop.png", Name = "Windows desktop applications", Description = "A desktop application is a software program that can be run on a standalone computer to perform a specific task by an end-user. Some desktop applications such as word editor and media player allow you to perform different tasks while other such as gaming apps are developed purely for entertainment."},
                new ListItemModel() { ImgUrl = "/src/img/outsourcing.png", Name = "Outsourcing", Description = "We do what we know best. If your company needs support, we are willing to cooperate in the implementation of entire projects or their selected part. We also recommend proven companies that offer additional services that are not directly related to software development, such as network administration or periodic testing."},
                new ListItemModel() { ImgUrl = "/src/img/console.png", Name = "Console applications", Description = "We do what we know best. If your company needs support, we are willing to cooperate in the implementation of entire projects or their selected part. We also recommend proven companies that offer additional services that are not directly related to software development, such as network administration or periodic testing."},
            };
        }

        public List<ListItemModel> GetAllTechnologies()
        {
            return new List<ListItemModel>()
            {
                new ListItemModel() { ImgUrl = "/src/img/core.png", Name = "ASP.NET Core", Description = "ASP.NET Core is a free and open-source web framework and successor to ASP.NET, developed by Microsoft. It is a modular framework that runs on both the full .NET Framework, on Windows, and the cross-platform .NET Core."},
                new ListItemModel() { ImgUrl = "/src/img/angular.png", Name = "Angular", Description = "Angular is a TypeScript-based open-source web application framework led by the Angular Team at Google and by a community of individuals and corporations. Angular is a complete rewrite from the same team that built AngularJS."},
                new ListItemModel() { ImgUrl = "/src/img/wpf.png", Name = "WPF", Description = "Windows Presentation Foundation is a free and open-source graphical subsystem originally developed by Microsoft for rendering user interfaces in Windows-based applications. WPF, previously known as \"Avalo\", was initially released as part of .NET Framework 3.0 in 2006."},
                new ListItemModel() { ImgUrl = "/src/img/mssql.png", Name = "MSSQL", Description = "Microsoft SQL Server is a relational database management system developed by Microsoft. As a database server, it is a software product with the primary function of storing and retrieving data as requested by other software applications—which may run either on the same computer or on another computer across a network."},
            };
        }
    }
}
