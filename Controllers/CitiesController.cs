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
    public async Task<ActionResult> Get(
        string name = "", 
        int page = 1, 
        int pageSize = 50
        )
    {
        var query = context.Cities.AsQueryable();
        if(!string.IsNullOrEmpty(name)){
            query = query.Where(c => c.CityName.ToLower() == name.ToLower()); 
        }
        var results = await query.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
        return Ok(results);
    }
    [HttpGet("{id:int}", Name = "GetCityById")]
    public async Task<ActionResult> GetCity(int id)
    {
        var cityById = await context.Cities.FindAsync(id);
        return cityById == null ? NotFound() : Ok(cityById);
    }
}
