using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Cities.API.Models
{
    public class City : BaseEntity
    {
        [BsonRequired]
        [JsonProperty("Name")]
        public string Name { get; set; }

        [BsonRequired]
        [JsonProperty("State")]
        public string State { get; set; }
    }
}
