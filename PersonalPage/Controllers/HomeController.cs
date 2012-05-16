using System.Web.Mvc;
using Autofac;
using PersonalPage.Library.Helpers;
using PersonalPage.Models.Servicies.Twitter;

namespace PersonalPage.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            var container = ContainerHelper.Container;

            var twitterService = container.Resolve<TwitterService>();

            var userTimeline = twitterService.GetCompleteUserTimeline();

            ViewBag.Tweets = userTimeline;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Kontakt";



            return View();
        }


    }
}
