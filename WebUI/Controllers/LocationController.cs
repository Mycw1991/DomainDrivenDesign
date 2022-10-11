using Application.DTO;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers;

[Route("[controller]")]
public class LocationController : ControllerBase
{
    private readonly ILocationService _locationService;

    public LocationController(ILocationService locationService)
    {
        _locationService = locationService;
    }
    [HttpPost("")]
    public ActionResult Post(LocationRequestDTO locationRequestDto)
    {
        return Ok(_locationService.getLocationByAdress(locationRequestDto));
    }
}