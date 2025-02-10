using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.EntityFrameworkCore;

namespace MigratedMoviesEFCore.Models;

[Collection("theaters")]
[BsonIgnoreExtraElements]
public class Theater
{
    
    [BsonId]
    [BsonElement("_id")]
    public ObjectId Id { get; set; }
    
    [BsonElement("theaterName")]
    public required string TheaterName { get; set; }
   
    [BsonElement("street1")]
    public string? Street1 { get; set; }

    [BsonElement("street2")]
    public string? Street2 { get; set; }

    [BsonElement("city")]
    public string? City { get; set; }

    [BsonElement("state")]
    public string? State { get; set; }

    [BsonElement("zipcode")]
    public string? Zipcode { get; set; }

    [BsonElement("location_lat")]
    public decimal? LocationLat { get; set; }

    [BsonElement("location_lon")]
    public decimal? LocationLon { get; set; }
}