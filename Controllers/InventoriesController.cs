using DVDRental.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DVDRental.Controllers;

[ApiController]
[Route("api/[controller]")]
public class InventoriesController : ControllerBase
{
    private readonly DVDRentalDbContext context;
    public InventoriesController(DVDRentalDbContext context)
    {
        this.context = context;
    }
    [HttpGet(Name = "AllInventories")]
    public async Task<ActionResult> Get( 
        int page = 1, 
        int pageSize = 5
    )
    {
        var query = context.Inventories.AsQueryable();
        var results = await query.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
        return Ok(results);
    }
    [HttpGet("{id:int}", Name = "GetInventoryById")]
    public async Task<ActionResult> GetInventory(int id)
    {
        var inventoryId = await context.Languages.FindAsync(id);
        return inventoryId == null ? NotFound() : Ok(inventoryId);
    }
}
