using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using PersonalPage.Models.Entities.Twitter;

namespace PersonalPage.Models.Servicies.Twitter
{
    public class TwitterService
    {
        public IEnumerable<Tweet> GetCompleteUserTimeline(ITwitterClient twitterClient)
        {
            string tweetsJson = twitterClient.GetRequest(new Uri("https://api.twitter.com/1/statuses/user_timeline.json?include_entities=false&include_rts=false&screen_name=janstafa&count=1000000"));

            return JsonConvert.DeserializeObject<IEnumerable<Tweet>>(tweetsJson);
        }
    }
}