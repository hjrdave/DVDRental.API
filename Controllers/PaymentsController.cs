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
    public async Task<ActionResult> Get(
        int page = 1, 
        int pageSize = 50
    )
    {
        var query = context.Payments.AsQueryable();
        var results = await query.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
        return Ok(results);
    }
    [HttpGet("{id:int}", Name = "GetPaymentById")]
    public async Task<ActionResult> GetPayment(int id)
    {
        var paymentId = await context.Payments.FindAsync(id);
        return paymentId == null ? NotFound() : Ok(paymentId);
    }
}
