using Newtonsoft.Json;

namespace PersonalPage.Models.Servicies.Twitter
{
    public class TwitterUser
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}