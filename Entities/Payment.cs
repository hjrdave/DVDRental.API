using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DVDRental.Entities
{
    [Table("payment", Schema = "public")]
    public class Payment
    {
        [Key]
        [Column("payment_id")]
        public int PaymentId { get; set; }

        [Required(ErrorMessage = "Customer ID is required")]
        [Column("customer_id")]
        public short CustomerId { get; set; }

        [Required(ErrorMessage = "Staff ID is required")]
        [Column("staff_id")]
        public short StaffId { get; set; }

        [Column("rental_id")]
        public int? RentalId { get; set; }

        [Required(ErrorMessage = "Amount is required")]
        [Column("amount")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Payment date is required")]
        [Column("payment_date")]
        public DateTime PaymentDate { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer? Customer { get; set; }

        [ForeignKey("RentalId")]
        public virtual Rental? Rental { get; set; }

        [ForeignKey("StaffId")]
        public virtual Staff? Staff { get; set; }
    }
}
