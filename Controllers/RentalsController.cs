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
    public async Task<ActionResult> Get()
    {
        var rentals = await context.Rentals.ToListAsync();
        return Ok(rentals);
    }
    [HttpGet("{id:int}", Name = "GetRentalById")]
    public async Task<ActionResult> GetRental(int id)
    {
        var rentalId = await context.Rentals.FindAsync(id);
        return rentalId == null ? NotFound() : Ok(rentalId);
    }
}
