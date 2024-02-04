using System.ComponentModel.DataAnnotations;

namespace DVDRental.Entities;

public class Staff
{
    public int Id {get; set;}
    public string? FirstName {get; set;}
    public string? LastName {get; set;}
    public int AddressId {get; set;}
    public string? Email {get; set;}
    public int StoreId {get; set;}
    public bool Active {get; set;}
    public string? UserName {get; set;}
    public string? Password {get; set;}
    public TimestampAttribute? LastUpdate {get; set;}
    public string? Picture {get; set;}
}
