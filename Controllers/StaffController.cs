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
    public async Task<ActionResult> Get()
    {
        var staff = await context.Staff.ToListAsync();
        return Ok(staff);
    }
}
