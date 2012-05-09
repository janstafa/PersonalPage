using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Attassa;
using Newtonsoft.Json;
using PersonalPage.Models.Servicies.Twitter;
using PersonalPage.Servicies;

namespace PersonalPage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            Tweet[] userTimeline = new TwitterService().GetUserTimeline(new TwitterClient());

            ViewBag.Tweets = userTimeline;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = Request.QueryString.ToString();

            //todo tady se budou vracet vyfiltrovany zaznamy
            //udelat objekt kterej se bude renderovat
            //od toho budou detit konkretni implementace

            //Record
            //-- Tweet
            //-- LinkedIn
            //-- StackoverflowQuestion
            //-- Article




            return View();
        }
    }
}
