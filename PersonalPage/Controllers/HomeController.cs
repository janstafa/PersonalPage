using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using PersonalPage.Models.Entities.Twitter;
using PersonalPage.Models.Servicies.Twitter;

namespace PersonalPage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            IEnumerable<Tweet> userTimeline = new TwitterService().GetCompleteUserTimeline(new TwitterClient());

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
