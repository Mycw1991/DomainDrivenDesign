using Newtonsoft.Json;

namespace Application.DTO;

public class LocationRequestDTO
{
    [JsonProperty("postalcode")] public string PostalCode { get; set; } = null!;

    [JsonProperty("street-number")] public string StreetNumber { get; set; } = null!;
}