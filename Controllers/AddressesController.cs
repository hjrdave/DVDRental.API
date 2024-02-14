﻿using DVDRental.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DVDRental.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AddressesController : ControllerBase
{
    private readonly DVDRentalDbContext context;
    public AddressesController(DVDRentalDbContext context)
    {
        this.context = context;
    }
    [HttpGet(Name = "AllAddresses")]
    public async Task<ActionResult> Get()
    {
        var addresses = await context.Addresses.ToListAsync();
        return Ok(addresses);
    }
    [HttpGet("{id:int}", Name = "GetAddressById")]
    public async Task<ActionResult> GetAddress(int id)
    {
        var addressById = await context.Addresses.FindAsync(id);
        return addressById == null ? NotFound() : Ok(addressById);
    }
}
