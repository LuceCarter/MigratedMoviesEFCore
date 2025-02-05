using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MigratedMoviesEFCore.Models;

[Table("users")]
public class User
{
    [Key]
    [Column("user_id")]
    [JsonPropertyName("user_id")]
    public int UserId { get; set; }

    [Column("name")]
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [Column("email")]
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [Column("password")]
    [JsonPropertyName("password")]
    public string? Password { get; set; }

    [Column("created_at")]
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }
}