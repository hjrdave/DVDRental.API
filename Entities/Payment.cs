namespace DVDRental.Entities;

public class Payment
{
    public int Id {get; set;}
    public int CustomerId {get; set;}
    public int StaffId {get; set;}
    public int RentalId {get; set;}
    public int Amount {get; set;}
    public DateTime PaymentDate {get; set;}
}
