using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.EntityFrameworkCore;

namespace MigratedMoviesEFCore.Models;

[Collection("actors")]
public class Actor
{
    [BsonId]
    [BsonElement("_id")]
    public ObjectId Id { get; set; }
    
    [BsonElement("name")] 
    public required string Name { get; set; }
    [BsonElement("dateOfBirth")] 
    public required DateTime DateOfBirth { get; set; }
    [BsonElement("placeOfBirth")] 
    public required string PlaceOfBirth { get; set; }
}