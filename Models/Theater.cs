using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace MigratedMoviesEFCore.Models;

[Table("theaters")]
public class Theater
{
    [Key]
    [Column("theater_id")]
    [JsonPropertyName("theater_id")]
    public int TheaterId { get; set; }

    [Column("theater_name")]
    [JsonPropertyName("theater_name")]
    public string? TheaterName { get; set; }

    [Column("street1")]
    [JsonPropertyName("street1")]
    public string? Street1 { get; set; }

    [Column("street2")]
    [JsonPropertyName("street2")]
    public string? Street2 { get; set; }

    [Column("city")]
    [JsonPropertyName("city")]
    public string? City { get; set; }

    [Column("state")]
    [JsonPropertyName("state")]
    public string? State { get; set; }

    [Column("zipcode")]
    [JsonPropertyName("zipcode")]
    public string? Zipcode { get; set; }

    [Column("location_lat")]
    [JsonPropertyName("location_lat")]
    public decimal? LocationLat { get; set; }

    [Column("location_lon")]
    [JsonPropertyName("location_lon")]
    public decimal? LocationLon { get; set; }
}