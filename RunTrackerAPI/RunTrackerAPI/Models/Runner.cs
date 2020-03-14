using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace RunTrackerAPI.Models
{
    public class Runner
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public PersonalInfo personals { get; set; }

        public long totalSteps { get; set; }

        public long totalDistance { get; set; }

        public  long totalFloors { get; set; }

        public long totalElevation { get; set; }

        public long totalCalories { get; set; }
    }
}
