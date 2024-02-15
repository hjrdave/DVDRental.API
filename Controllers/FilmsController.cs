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
    public async Task<ActionResult> Get(
        string title = "", 
        int releaseYear = 0,
        int rentalDuration = 0,
        int page = 1, 
        int pageSize = 5
        )
    {
        var query = context.Films.AsQueryable();
        if(!string.IsNullOrEmpty(title)){
            query = query.Where(f => f.Title.ToLower() == title.ToLower()); 
        }
        if(releaseYear > 0){
            query = query.Where(f => f.ReleaseYear == releaseYear); 
        }
        if(rentalDuration > 0){
            query = query.Where(f => f.RentalDuration == rentalDuration); 
        }
        var results = await query.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
        return Ok(results);
    }
    
   
    [HttpGet("{id:int}", Name = "GetFilmById")]
    public async Task<ActionResult> GetFilm(int id)
    {
        var filmById = await context.Films.FindAsync(id);
        return filmById == null ? NotFound() : Ok(filmById);
    }
}
