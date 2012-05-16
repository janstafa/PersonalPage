using System;
using System.Collections.Generic;
using Autofac;
using Newtonsoft.Json;
using PersonalPage.Models.Entities.Twitter;

namespace PersonalPage.Models.Servicies.Twitter
{
    public class TwitterService 
    {
        private readonly IComponentContext _componentContext;

        public TwitterService(IComponentContext componentContext)
        {
            _componentContext = componentContext;
        }

        public IEnumerable<Tweet> GetCompleteUserTimeline()
        {
            var twitterClient = _componentContext.Resolve<ITwitterClient>();

            var tweetsJson = twitterClient.GetRequest(new Uri("https://aapi.twitter.com/1/statuses/user_timeline.json?include_entities=false&include_rts=false&screen_name=janstafa&count=1000000"));

            return JsonConvert.DeserializeObject<IEnumerable<Tweet>>(tweetsJson);
        }
    }
}