using Newtonsoft.Json;

namespace Application.DTO;

public class LocationResponseDTO
{
    [JsonProperty("lat")]
    public double Lat { get; set; }

    [JsonProperty("lng")]
    public double Lng { get; set; }
    
    [JsonProperty("postalCode")]
    public string PostalCode { get; set; } = null!;
}