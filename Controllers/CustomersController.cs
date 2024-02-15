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
    public async Task<ActionResult> Get(
        string firstName = "", 
        string lastName = "", 
        string email = "",  
        int page = 1, 
        int pageSize = 50
    )
    {
        var query = context.Customers.AsQueryable();
        if(!string.IsNullOrEmpty(firstName)){
            query = query.Where(c => c.FirstName.ToLower() == firstName.ToLower()); 
        }
        if(!string.IsNullOrEmpty(lastName)){
            query = query.Where(c => c.LastName.ToLower() == lastName.ToLower()); 
        }
        if(!string.IsNullOrEmpty(email)){
            query = query.Where(c => c.Email.ToLower() == email.ToLower()); 
        }
        var results = await query.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
        return Ok(results);
    }
    
   
    [HttpGet("{id:int}", Name = "GetCustomerById")]
    public async Task<ActionResult> GetCustomer(int id)
    {
        var customerById = await context.Customers.FindAsync(id);
        return customerById == null ? NotFound() : Ok(customerById);
    }
}
