using DVDRental.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DVDRental.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StaffController : ControllerBase
{
    private readonly DVDRentalDbContext context;
    public StaffController(DVDRentalDbContext context)
    {
        this.context = context;
    }
    [HttpGet(Name = "AllStaff")]
    public async Task<ActionResult> Get(
        string firstName = "",
        string lastName = "",
        string email = "",
        string username = ""
    )
    {
        var query = context.Staff.AsQueryable();
        if(!string.IsNullOrEmpty(firstName)){
            query = query.Where(c => c.FirstName.ToLower() == firstName.ToLower()); 
        }
        if(!string.IsNullOrEmpty(lastName)){
            query = query.Where(c => c.LastName.ToLower() == lastName.ToLower()); 
        }
        if(!string.IsNullOrEmpty(email)){
            query = query.Where(c => c.Email.ToLower() == email.ToLower()); 
        }
        if(!string.IsNullOrEmpty(username)){
            query = query.Where(c => c.Username.ToLower() == username.ToLower()); 
        }
        var results = await query.ToListAsync();
        return Ok(results);
    }
    
    [HttpGet("{id:int}", Name = "GetStaffById")]
    public async Task<ActionResult> GetStaff(int id)
    {
        var staffId = await context.Staff.FindAsync(id);
        return staffId == null ? NotFound() : Ok(staffId);
    }
}
