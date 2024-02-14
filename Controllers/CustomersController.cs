using DVDRental.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DVDRental.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomersController : ControllerBase
{
    private readonly DVDRentalDbContext context;
    public CustomersController(DVDRentalDbContext context)
    {
        this.context = context;
    }
    [HttpGet(Name = "AllCustomers")]
    public async Task<ActionResult> Get()
    {
        var customers = await context.Customers.ToListAsync();
        return Ok(customers);
    }
    [HttpGet("{id:int}", Name = "GetCustomerById")]
    public async Task<ActionResult> GetCustomer(int id)
    {
        var customerById = await context.Customers.FindAsync(id);
        return customerById == null ? NotFound() : Ok(customerById);
    }
}
