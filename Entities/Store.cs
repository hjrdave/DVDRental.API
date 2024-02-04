using System.ComponentModel.DataAnnotations;

namespace DVDRental.Entities;

public class Store
{
    public int StoreId {get; set;}
    public int ManagerStaffId {get; set;}
    public int AddressId {get; set;}
    public TimestampAttribute? LastUpdate {get; set;}
}
