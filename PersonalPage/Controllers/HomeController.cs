using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Attassa;
using Newtonsoft.Json;

namespace PersonalPage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            OAuthLinkedIn _oauth = new OAuthLinkedIn();
            _oauth.Verifier = "32493233";
            String requestToken = _oauth.getRequestToken();
            
            _oauth.authorizeToken();

            WebClient client = new WebClient();
           string aaaa =  client.DownloadString(
                "https://api.twitter.com/1/statuses/user_timeline.json?include_entities=false&include_rts=false&screen_name=janstafa&count=100");

           Dictionary<string, string>[] deserializeObject = JsonConvert.DeserializeObject<Dictionary<string, string>[]>(aaaa);

            //foreach (KeyValuePair<string, string> keyValuePair in deserializeObject)
            //{
            //    ViewBag.Message += keyValuePair.Value[3];
            //}


            //    string  asdfa= "\n" + _oauth.APIWebRequest("GET", "https://api.linkedin.com/v1/people/~", null);
         //   String accessToken = _oauth.getAccessToken();

            //https://api.twitter.com/1/statuses/user_timeline.json?include_entities=true&include_rts=true&screen_name=janstafa&count=2

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your quintessential app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your quintessential contact page.";

            return View();
        }
    }
}
