using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MigratedMoviesEFCore.Models;

[Table("actors")]
public class Actor
{
    [Key]
    [Column("actor_id")]
    [JsonPropertyName("actor_id")]
    public int ActorId { get; set; }

    [Column("name")]
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [Column("date_of_birth")]
    [JsonPropertyName("date_of_birth")]
    public DateTime? DateOfBirth { get; set; }

    [Column("place_of_birth")]
    [JsonPropertyName("place_of_birth")]
    public string? PlaceOfBirth { get; set; }
}