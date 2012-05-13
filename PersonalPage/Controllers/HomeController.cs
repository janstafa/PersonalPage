using System.Web.Mvc;
using PersonalPage.Models.Servicies.Twitter;
using Spring.Context;

namespace PersonalPage.Controllers
{

    public class MainController : Controller
    {
        //private readonly IApplicationContext _applicationContext = ContextHelper.GetProductionContext();
    }

    public class HomeController : MainController, IApplicationContextAware
    {
        public IApplicationContext ApplicationContext
        {
            set { throw new System.NotImplementedException(); }
        }
        
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
