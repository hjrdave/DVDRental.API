using System.ComponentModel.DataAnnotations;

namespace DVDRental;

public class Country
{
    public int Id {get; set;}
    public string? Name {get; set;}
    public TimestampAttribute? LastUpdate {get; set;}
}
