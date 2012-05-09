using Newtonsoft.Json;

namespace PersonalPage.Models.Entities.Twitter
{
    public class TwitterUser
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}