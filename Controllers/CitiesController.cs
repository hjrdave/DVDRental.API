using DVDRental.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DVDRental.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CitiesController : ControllerBase
{
    private readonly DVDRentalDbContext context;
    public CitiesController(DVDRentalDbContext context)
    {
        this.context = context;
    }
    [HttpGet(Name = "AllCities")]
    public async Task<ActionResult> Get()
    {
        var cities = await context.Cities.ToListAsync();
        return Ok(cities);
    }
}
