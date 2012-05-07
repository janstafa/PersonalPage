using Newtonsoft.Json;

namespace PersonalPage.Servicies
{
    public class TwitterUser
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}