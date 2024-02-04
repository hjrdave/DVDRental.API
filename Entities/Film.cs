using System.ComponentModel.DataAnnotations;

namespace DVDRental.Entities;

public class Film
{
    public int Id {get; set;}
    public string? Title {get; set;}
    public string? Description {get; set;}
    public int ReleaseYear {get; set;}
    public int LanguageId {get; set;}
    public int RentalDuration {get; set;}
    public int RentalRate {get; set;}
    public int Length {get; set;}
    public int ReplacementCost {get; set;}
    public int Rating {get; set;}
    public TimestampAttribute? LastUpdate {get; set;}
    public string? SpecialFeatures {get; set;}
    public string? FullText {get; set;}

}
