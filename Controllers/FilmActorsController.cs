using DVDRental.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DVDRental.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FilmActorsController : ControllerBase
{
    private readonly DVDRentalDbContext context;
    public FilmActorsController(DVDRentalDbContext context)
    {
        this.context = context;
    }
    [HttpGet(Name = "AllFilmActors")]
    public async Task<ActionResult> Get(
        int page = 1, 
        int pageSize = 50
    )
    {
        var query = context.FilmActors.AsQueryable();
        var results = await query.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
        return Ok(results);
    }

    [HttpGet("{id:int}", Name = "GetFilmActorById")]
    public async Task<ActionResult> GetFilmActor(int id)
    {
        var filmActorById = await context.FilmActors.FindAsync(id);
        return filmActorById == null ? NotFound() : Ok(filmActorById);
    }
}
