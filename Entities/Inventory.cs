﻿using System.ComponentModel.DataAnnotations;

namespace DVDRental.Entities;

public class Inventory
{
    public int Id {get; set;}
    public int FilmId {get; set;}
    public int StoreId {get; set;}
    public TimestampAttribute? LastUpdate {get; set;}

}
