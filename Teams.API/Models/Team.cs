using Cities.API.Models;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using People.API.Models;
using System.Collections.Generic;

namespace Teams.API.Models
{
    public class Team : BaseEntity
    {
        [BsonRequired]
        [JsonProperty("Name")]
        public string Name { get; set; }

        [BsonRequired]
        [JsonProperty("People")]
        public virtual List<Person> People { get; set; }

        [BsonRequired]
        [JsonProperty("IsAvailable")]
        public bool IsAvailable { get; set; }

        [BsonRequired]
        [JsonProperty("OperatingCity")]
        public City OperatingCity { get; set; }
    }
}
