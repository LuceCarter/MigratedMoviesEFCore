using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MigratedMoviesEFCore.Models;

[Table("comments")]
public class Comment
{
    [Key]
    [Column("comment_id")]
    [JsonPropertyName("comment_id")]
    public int CommentId { get; set; }

    [Column("movie_id")]
    [JsonPropertyName("movie_id")]
    public int MovieId { get; set; }

    [Column("user_id")]
    [JsonPropertyName("user_id")]
    public int UserId { get; set; }

    [Column("text")]
    [JsonPropertyName("text")]
    public string? Text { get; set; }

    [Column("comment_date")]
    [JsonPropertyName("comment_date")]
    public DateTime? CommentDate { get; set; }
}
