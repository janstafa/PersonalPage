using System.Web.Mvc;
using PersonalPage.Models.Servicies.Twitter;

namespace PersonalPage.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            var twitterService = new TwitterService();

            var userTimeline = twitterService.GetCompleteUserTimeline(new TwitterClient());
             
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
