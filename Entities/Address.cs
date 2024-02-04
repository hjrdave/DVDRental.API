using System.ComponentModel.DataAnnotations;

namespace DVDRental.Entities;

public class Address
{
    public int Id {get; set;}
    public string? Address1 {get; set;}
    public string? Address2 {get; set;}
    public int District {get; set;}
    public int CityId {get; set;}
    public int PostalId {get; set;}
    public string? Phone {get; set;}
    public TimestampAttribute? LastUpdate {get; set;}

}
