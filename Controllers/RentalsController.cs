using DVDRental.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DVDRental.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RentalsController : ControllerBase
{
    private readonly DVDRentalDbContext context;
    public RentalsController(DVDRentalDbContext context)
    {
        this.context = context;
    }
    [HttpGet(Name = "AllRentals")]
    public async Task<ActionResult> Get(
        int page = 1, 
        int pageSize = 50
    )
    {
        var query = context.Rentals.AsQueryable();
        var results = await query.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
        return Ok(results);
    }
    [HttpGet("{id:int}", Name = "GetRentalById")]
    public async Task<ActionResult> GetRental(int id)
    {
        var rentalId = await context.Rentals.FindAsync(id);
        return rentalId == null ? NotFound() : Ok(rentalId);
    }
}
