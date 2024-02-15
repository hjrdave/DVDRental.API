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
    public async Task<ActionResult> Get(
        string name = "", 
        int page = 1, 
        int pageSize = 50
        )
    {
        var query = context.Countries.AsQueryable();
        if(!string.IsNullOrEmpty(name)){
            query = query.Where(c => c.CountryName.ToLower() == name.ToLower()); 
        }
        var results = await query.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
        return Ok(results);
    }
    [HttpGet("{id:int}", Name = "GetCountryById")]
    public async Task<ActionResult> GetCountry(int id)
    {
        var countryById = await context.Countries.FindAsync(id);
        return countryById == null ? NotFound() : Ok(countryById);
    }
}
