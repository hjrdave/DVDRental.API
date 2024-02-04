using System.ComponentModel.DataAnnotations;
namespace DVDRental.Entities;

public class City
{
    public int Id {get; set;}
    public string? Name {get; set;}
    public int CountryId {get; set;}
    public TimestampAttribute? LastUpdate {get; set;}

}
