using System.ComponentModel.DataAnnotations;
using DVDRental.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DVDRental.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<CustomerController> _logger;

    public CustomerController(ILogger<CustomerController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetCustomer")]
    public IEnumerable<Customer> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Customer
        {
           Id = 0,
            StoreId = 0,
            FirstName = "Foo",
            LastName = "Fee",
            Email = "foo@fee.com",
            AddressId = 0,
            ActiveBool = false,
            CreateDate = null,
            LastUpdate = null,
            Active = true
        })
        .ToArray();
    }
}
