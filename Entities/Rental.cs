using System.ComponentModel.DataAnnotations;

namespace DVDRental.Entities;

public class Rental
{
    public int Id {get; set;}
    public DateTime RentalDate {get; set;}
    public int InventoryId {get; set;}
    public int CustomerId {get; set;}
    public DateTime ReturnDate {get; set;}
    public int StaffId {get; set;}
    public TimestampAttribute? LastUpdate {get; set;}
}
