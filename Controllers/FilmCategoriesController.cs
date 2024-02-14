using DVDRental.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DVDRental.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FilmCategoriesController : ControllerBase
{
    private readonly DVDRentalDbContext context;
    public FilmCategoriesController(DVDRentalDbContext context)
    {
        this.context = context;
    }
    [HttpGet(Name = "AllFilmCategories")]
    public async Task<ActionResult> Get()
    {
        var filmCategories = await context.FilmCategories.ToListAsync();
        return Ok(filmCategories);
    }
    [HttpGet("{id:int}", Name = "GetFilmCategoryById")]
    public async Task<ActionResult> GetFilmCategory(int id)
    {
        var categoryById = await context.Categories.FindAsync(id);
        return categoryById == null ? NotFound() : Ok(categoryById);
    }
}
