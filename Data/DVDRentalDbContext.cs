using DVDRental.Entities;
using Microsoft.EntityFrameworkCore;

namespace DVDRental.Data;

public class DVDRentalDbContext: DbContext
{
    public DbSet<Actor> Actors {get; set;}
    public DVDRentalDbContext(DbContextOptions options) : base(options)
    {

    }
}
