﻿using DVDRental.Data;
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
    public async Task<ActionResult> Get()
    {
        var inventories = await context.Inventories.ToListAsync();
        return Ok(inventories);
    }
}
