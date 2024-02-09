﻿using DVDRental.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DVDRental.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CatergoriesController : ControllerBase
{
    private readonly DVDRentalDbContext context;
    public CatergoriesController(DVDRentalDbContext context)
    {
        this.context = context;
    }
    [HttpGet(Name = "AllCategories")]
    public async Task<ActionResult> Get()
    {
        var addresses = await context.Categories.ToListAsync();
        return Ok(addresses);
    }
}
