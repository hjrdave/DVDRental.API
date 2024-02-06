using System.ComponentModel.DataAnnotations;

namespace DVDRental.Entities;

public class Customer
{
    public int Id {get; set;}
    public int StoreId {get; set;}
    public string? FirstName {get; set;}
    public string? LastName {get; set;}
    public string? Email {get; set;}
    public int AddressId {get; set;}
    public bool ActiveBool {get; set;}
    public DateTime? CreateDate {get; set;}
    public TimestampAttribute? LastUpdate {get; set;}
    public bool Active {get; set;}

}
