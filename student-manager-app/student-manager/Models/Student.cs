using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace student_manager.Models
{
    
    public class Student
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;
        [BsonElement("fisrtname")]
        public string FirstName { get; set; } = "Student First Name";
        [BsonElement("lastname")]
        public string LastName { get; set; } = "Student Last Name";
        [BsonElement("department")]
        public string Department { get; set; } = "Department";
        [BsonElement("class")]
        public string Class { get; set; } = "Class";
        [BsonElement("birthday")]
        public DateTime Birthday { get; set; }
        [BsonElement("age")]
        public int Age { get; set; }
        [BsonElement("graduated")]
        public bool IsGraduated { get; set; }

    }
}
