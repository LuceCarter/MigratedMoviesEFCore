using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.EntityFrameworkCore;

namespace MigratedMoviesEFCore.Models;

[Collection("movies")]
public class Movie
{
  [BsonId] [BsonElement("_id")] public ObjectId Id { get; set; } = ObjectId.GenerateNewId();
  
  [BsonElement("title")]
  public required string Title { get; set; }
  
  [BsonElement("year")]
  public required int Year { get; set; }
  
  [BsonElement("runtime")]
  public required int Runtime { get; set; }
  
  [BsonElement("plot")]
  public required string Plot { get; set; }
  
  [BsonElement("fullplot")]
  public string FullPlot { get; set; }
  
  [BsonElement("released")]
  public required DateTime Released { get; set; }
  
  [BsonElement("rated")]
  public required string Rated { get; set; }
  
  [BsonElement("poster")]
  public required string Poster { get; set; }

  [BsonElement("comments")] 
  public List<Comment>? Comments { get; set; } = new List<Comment>();

}
public class Comment
{
  [BsonElement("text")]
  public required string Text { get; set; }
  
  [BsonElement("commentDate")]
  public required DateTime CommentDate { get; set; }
}