using System.Net.Http.Json;
using Application.DTO;
using Application.Interfaces;

namespace Infrastructure.Services;

public class Pro6ppClient : ILocationService
{
    public async Task<LocationResponseDTO?> getLocationByAdress(LocationRequestDTO locationRequestDto)
    {
        var response = await new HttpClient().GetAsync(
            "https://api.pro6pp.nl/v2/suggest/nl/streetNumberAndPremise?authKey=n5SEkGlaFzbkWDfj&postalCode=" +
            locationRequestDto.PostalCode + "&streetNumberAndPremise=" + locationRequestDto.StreetNumber);

        return await response.Content.ReadFromJsonAsync<LocationResponseDTO>();
    }
}