using DVDRental.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DVDRental.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FilmsController : ControllerBase
{
    private readonly DVDRentalDbContext context;
    public FilmsController(DVDRentalDbContext context)
    {
        this.context = context;
    }
    [HttpGet(Name = "AllFilms")]
    public async Task<ActionResult> Get()
    {
        var films = await context.Films.ToListAsync();
        return Ok(films);
    }
}
