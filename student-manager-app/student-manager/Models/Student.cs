﻿using MongoDB.Bson;
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
        [BsonElement("lastaname")]
        public string LastName { get; set; } = "Student Last Name";
        [BsonElement("department")]
        public string Department { get; set; } = "Department";
        [BsonElement("class")]
        public string Class { get; set; } = "Class";
        [BsonElement("birthday")]
        public DateTime birthday { get; set; } = DateTime.MinValue;
    }
}
