using DVDRental.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DVDRental.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CountriesController : ControllerBase
{
    private readonly DVDRentalDbContext context;
    public CountriesController(DVDRentalDbContext context)
    {
        this.context = context;
    }
    [HttpGet(Name = "AllCountries")]
    public async Task<ActionResult> Get()
    {
        var countries = await context.Countries.ToListAsync();
        return Ok(countries);
    }
}
