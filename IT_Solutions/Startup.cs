using IT_Solutions.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization.Routing;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;

namespace IT_Solutions
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddHttpsRedirection(options => options.RedirectStatusCode = StatusCodes.Status301MovedPermanently);
            services.AddLocalization(options => options.ResourcesPath = "Resources");
            services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportedCultures = new[]{
                    new CultureInfo("en"),
                    new CultureInfo("pl"),
            };
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
                options.RequestCultureProviders.Insert(0, new RouteDataRequestCultureProvider());
            });
            services.AddTransient<IListItemFactory, ListItemFactory>();
            services.AddTransient<IEmailSender, EmailSender>();

            services.AddMvc()
                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
                .AddDataAnnotationsLocalization();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseHttpsRedirection();
            app.Use(async (context, next) =>
            {
                if (!context.Request.IsHttps)
                {
                    context.Response.Redirect("/error.html");

                    return;
                }

                await next();
            });
            app.UseStaticFiles();

            app.UseRouting();
            app.UseRequestLocalization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "culture-route", pattern: "{culture=en}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllers();
            });
        }
    }
}
