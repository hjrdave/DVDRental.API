using System.ComponentModel.DataAnnotations;

namespace DVDRental;

public class Category
{
    public int Id {get; set;}
    public string? Name {get; set;}
    public TimestampAttribute? LastUpdate {get; set;}

}
