using System;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PersonalPage.Servicies
{
    public class Tweet
    {
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        [JsonConverter(typeof(TwitterDateTimeConverter))]
        public DateTime CreatedAt { get; set; }

        [JsonProperty(PropertyName = "user")]
        public TwitterUser User { get; set; }



    }

    public class TwitterDateTimeConverter : DateTimeConverterBase
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType != JsonToken.String)
            {
                throw new Exception(
                    String.Format("Unexpected token parsing date. Expected String, got {0}.",
                    reader.TokenType));
            }

            var twitterDateTime = (string)reader.Value;

            DateTime dateTime = DateTime.ParseExact(twitterDateTime, "ddd MMM dd HH:mm:ss zzz yyyy", CultureInfo.InvariantCulture);
            
            return dateTime;
        }
    }
}