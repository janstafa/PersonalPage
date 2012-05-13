using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using PersonalPage.Models.Entities.Twitter;

namespace PersonalPage.Models.Servicies.Twitter
{
    public class TwitterService
    {
        private readonly ITwitterClient _twitterClient;

        public TwitterService(ITwitterClient twitterClient)
        {
            _twitterClient = twitterClient;
        }


        public IEnumerable<Tweet> GetCompleteUserTimeline()
        {
            var tweetsJson = _twitterClient.GetRequest(new Uri("https://api.twitter.com/1/statuses/user_timeline.json?include_entities=false&include_rts=false&screen_name=janstafa&count=1000000"));

            return JsonConvert.DeserializeObject<IEnumerable<Tweet>>(tweetsJson);
        }
    }
}