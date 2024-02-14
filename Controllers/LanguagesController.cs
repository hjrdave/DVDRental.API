using DVDRental.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DVDRental.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LanguagesController : ControllerBase
{
    private readonly DVDRentalDbContext context;
    public LanguagesController(DVDRentalDbContext context)
    {
        this.context = context;
    }
    [HttpGet(Name = "AllLanguages")]
    public async Task<ActionResult> Get()
    {
        var languages = await context.Languages.ToListAsync();
        return Ok(languages);
    }
    [HttpGet("{id:int}", Name = "GetLanguageById")]
    public async Task<ActionResult> GetLanguage(int id)
    {
        var languageId = await context.Languages.FindAsync(id);
        return languageId == null ? NotFound() : Ok(languageId);
    }
}
