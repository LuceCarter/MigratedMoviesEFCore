using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MigratedMoviesEFCore.Models;

[Table("movies")]
public class Movie
{
    [Key]
    [Column("movie_id")]
    [JsonPropertyName("movie_id")]
    public int MovieId { get; set; }

    [Column("title")]
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [Column("year")]
    [JsonPropertyName("year")]
    public int? Year { get; set; }

    [Column("runtime")]
    [JsonPropertyName("runtime")]
    public int? Runtime { get; set; }

    [Column("plot")]
    [JsonPropertyName("plot")]
    public string? Plot { get; set; }

    [Column("fullplot")]
    [JsonPropertyName("fullplot")]
    public string? Fullplot { get; set; }

    [Column("type")]
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [Column("released")]
    [JsonPropertyName("released")]
    public DateTime? Released { get; set; }

    [Column("rated")]
    [JsonPropertyName("rated")]
    public string? Rated { get; set; }

    [Column("poster")]
    [JsonPropertyName("poster")]
    public string? Poster { get; set; }

    [Column("lastupdated")]
    [JsonPropertyName("lastupdated")]
    public DateTime? LastUpdated { get; set; }
}