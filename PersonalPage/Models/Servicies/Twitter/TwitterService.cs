using System;
using Newtonsoft.Json;
using PersonalPage.Models.Entities.Twitter;

namespace PersonalPage.Models.Servicies.Twitter
{
    public class TwitterService
    {
        public Tweet[] GetCompleteUserTimeline(ITwitterClient twitterClient)
        {
            string tweetsJson = twitterClient.GetRequest(new Uri("https://api.twitter.com/1/statuses/user_timeline.json?include_entities=false&include_rts=false&screen_name=janstafa&count=1000000"));

            Tweet[] tweets = JsonConvert.DeserializeObject<Tweet[]>(tweetsJson);

            return tweets;
        }
    }
}