using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Turbo_az.Areas.Api.Data;
using Turbo_az.Areas.Api.Models;
using Turbo_az.Areas.Api.Services;

namespace Turbo_az.Areas.Api.Controllers;

[ApiController]
[Area("Api")]
public class CarController : ControllerBase
{
    private readonly TurboDbContext _context;

    public CarController(TurboDbContext context) => _context = context;

    [HttpGet("GetAllCars")]
    [Route("{area}/{controller}/GetAllCars")]
    public async Task<IActionResult> GetAllCarsAsync()
    {
        return Ok();
    }
    
    [HttpGet("GetCarById")]
    [Route("{area}/{controller}/GetCarById/{id}")]
    public async Task<IActionResult> GetCarByIdAsync(int id)
    {
        return Ok();
    }
}