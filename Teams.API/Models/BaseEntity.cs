using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Teams.API.Models
{
	public class BaseEntity
	{
		[BsonId]
		[BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
		[JsonProperty("Id")]
		public string Id { get; set; }
	}
}
