using Application.DTO;

namespace Application.Interfaces;

public interface ILocationService
{
    public Task<LocationResponseDTO?> getLocationByAdress(LocationRequestDTO locationRequestDto);
}