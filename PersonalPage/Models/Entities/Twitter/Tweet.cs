using System;
using Newtonsoft.Json;

namespace PersonalPage.Models.Servicies.Twitter
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