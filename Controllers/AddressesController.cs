using DVDRental.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;
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
    public async Task<ActionResult> Get(
        string address = "",
        string district = "",
        string postalCode = "",
    string phone = "",
        int page = 1, 
        int pageSize = 50
    )
    {
        var query = context.Addresses.AsQueryable();
        if(!string.IsNullOrEmpty(address)){
            query = query.Where(c => c.AddressLine.ToLower() == address.ToLower()); 
        }
        if(!string.IsNullOrEmpty(district)){
            query = query.Where(c => c.District.ToLower() == district.ToLower()); 
        }
        if(!string.IsNullOrEmpty(postalCode)){
            query = query.Where(c => c.PostalCode.ToLower() == postalCode.ToLower()); 
        }
        if(!string.IsNullOrEmpty(phone)){
            query = query.Where(c => c.Phone.ToLower() == phone.ToLower()); 
        }
        var results = await query.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
        return Ok(results);
    }
    [HttpGet("{id:int}", Name = "GetAddressById")]
    public async Task<ActionResult> GetAddress(int id)
    {
        var addressById = await context.Addresses.FindAsync(id);
        return addressById == null ? NotFound() : Ok(addressById);
    }
}
