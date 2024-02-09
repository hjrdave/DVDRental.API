using DVDRental.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DVDRental.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PaymentsController : ControllerBase
{
    private readonly DVDRentalDbContext context;
    public PaymentsController(DVDRentalDbContext context)
    {
        this.context = context;
    }
    [HttpGet(Name = "AllPayments")]
    public async Task<ActionResult> Get()
    {
        var payments = await context.Payments.ToListAsync();
        return Ok(payments);
    }
}
