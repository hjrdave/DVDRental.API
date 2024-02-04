using System.ComponentModel.DataAnnotations;

namespace DVDRental.Entities;

public class FilmActor
{
    public int Id {get; set;}
    public int FilmId {get; set;}
    public TimestampAttribute? LastUpdate {get; set;}
}
