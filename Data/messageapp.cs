using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Branch_app.Data
{
    [BsonIgnoreExtraElements]
    public class messageapp
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string messageId { get; set; }

        [BsonElement("User ID")]
        public string userId { get; set; }

        [BsonElement("Timestamp (UTC)")]
        public string timeStamp { get; set; }

        [BsonElement("Message Body")]
        public string message { get; set; }
    }
}
