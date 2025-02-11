using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.EntityFrameworkCore;

namespace MigratedMoviesEFCore.Models;

[Collection("users")]
public class User
{
    [BsonId]
    [BsonElement("_id")]
    public ObjectId Id { get; set; }
    
    [BsonElement("name")]
    public string? Name { get; set; }

    [BsonElement("email")]
    public string? Email { get; set; }
    
    [BsonElement("password")]
    public string? Password { get; set; }

    [BsonElement("created_at")]
    public DateTime? CreatedAt { get; set; }
}