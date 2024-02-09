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
    public async Task<ActionResult> Get()
    {
        var filmActors = await context.FilmActors.ToListAsync();
        return Ok(filmActors);
    }
}
