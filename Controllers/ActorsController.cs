using DVDRental.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DVDRental.Controllers;

[ApiController]
[Route("api/[controller]")]
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
    [HttpGet("{id:int}", Name = "GetActorById")]
    public async Task<ActionResult> GetActor(int id)
    {
        var actorById = await context.Actors.FindAsync(id);
        return actorById == null ? NotFound() : Ok(actorById);
    }
}
