using DVDRental.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DVDRental.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ActorsController : ControllerBase
{
    private readonly DVDRentalDbContext context;
    public ActorsController(DVDRentalDbContext context)
    {
        this.context = context;
    }
    [HttpGet(Name = "AllActors")]
    public async Task<ActionResult> Get()
    {
        var actors = await context.Actors.ToListAsync();
        return Ok(actors);
    }
}
