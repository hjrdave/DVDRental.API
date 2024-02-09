using DVDRental.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DVDRental.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StoresController : ControllerBase
{
    private readonly DVDRentalDbContext context;
    public StoresController(DVDRentalDbContext context)
    {
        this.context = context;
    }
    [HttpGet(Name = "AllStores")]
    public async Task<ActionResult> Get()
    {
        var stores = await context.Stores.ToListAsync();
        return Ok(stores);
    }
}
