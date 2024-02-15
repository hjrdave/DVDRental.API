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
    public async Task<ActionResult> Get(
        string firstName = "",
        string lastName = "",
        int page = 1,
        int pageSize = 50
    )
    {
        var query = context.Actors.AsQueryable();
        if(!string.IsNullOrEmpty(firstName)){
            query = query.Where(c => c.FirstName.ToLower() == firstName.ToLower()); 
        }
        if(!string.IsNullOrEmpty(lastName)){
            query = query.Where(c => c.LastName.ToLower() == lastName.ToLower()); 
        }
        var results = await query.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
        return Ok(results);
    }
    [HttpGet("{id:int}", Name = "GetActorById")]
    public async Task<ActionResult> GetActor(int id)
    {
        var actorById = await context.Actors.FindAsync(id);
        return actorById == null ? NotFound() : Ok(actorById);
    }
}
