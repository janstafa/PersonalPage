using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PersonalPage.Servicies
{
    public class TwitterService
    {
        public Tweet[] GetUserTimeline(ITwitterClient twitterClient)
        {
            string tweetsJson = twitterClient.GetUserTimelineJson(new Uri("https://api.twitter.com/1/statuses/user_timeline.json?include_entities=false&include_rts=false&screen_name=janstafa&count=100"));

            Tweet[] tweets = JsonConvert.DeserializeObject<Tweet[]>(tweetsJson);

            return tweets;
        }
    }
}