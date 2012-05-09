using System;
using Newtonsoft.Json;
using PersonalPage.Models.Servicies.Twitter;

namespace PersonalPage.Models.Entities.Twitter
{
    public class Tweet : ServiceRecord
    {
        [JsonProperty(PropertyName = "text")]
        public override string Text { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        [JsonConverter(typeof(TwitterDateTimeConverter))]
        public override DateTime CreatedAt { get; set; }

        [JsonProperty(PropertyName = "user")]
        public TwitterUser User { get; set; }



    }
}