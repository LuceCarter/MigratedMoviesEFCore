using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MigratedMoviesEFCore.Models;

[Table("movie_genres")]
public class MovieGenres
{
    [Key, Column("movie_id", Order = 0)]
    [JsonPropertyName("movie_id")]
    public int MovieId { get; set; }

    [Key, Column("genre", Order = 1)]
    [JsonPropertyName("genre")]
    public string? Genre { get; set; }
}

