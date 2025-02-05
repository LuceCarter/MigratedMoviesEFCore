using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MigratedMoviesEFCore.Models;

[Table("movie_cast")]
public class MovieCast
{
    [Key, Column("movie_id", Order = 0)]
    [JsonPropertyName("movie_id")]
    public int MovieId { get; set; }

    [Key, Column("actor_id", Order = 1)]
    [JsonPropertyName("actor_id")]
    public int ActorId { get; set; }
}
