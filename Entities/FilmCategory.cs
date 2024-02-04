using System.ComponentModel.DataAnnotations;

namespace DVDRental;

public class FilmCategory
{
    public int Id {get; set;}
    public int CategoryId {get; set;}
    public TimestampAttribute? LastUpdate {get; set;}
}
